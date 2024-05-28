Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class ConfirmInfoForm
	Public userName As String
	Public maDeThi As String
	Dim fullName As String
	Dim machineName As String = Environment.MachineName

	Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
		Using ms As New MemoryStream(byteArray)
			Return Image.FromStream(ms)
		End Using
	End Function

	Function GetImageFromDatabase(ByVal userId As String) As Byte()
		Dim imageData As Byte() = Nothing
		Dim sql As String
		sql = "SELECT image FROM Sinhvien WHERE Masv = @Masv"

		Using conn As New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
			Using cmd As New SqlCommand(sql, conn)
				cmd.Parameters.AddWithValue("@Masv", userId)
				conn.Open()
				Dim reader As SqlDataReader = cmd.ExecuteReader()
				If reader.Read() Then
					If Not IsDBNull(reader("image")) Then
						imageData = CType(reader("image"), Byte())
					End If
				End If
			End Using
		End Using
		Return imageData
	End Function

	Private Sub btnDenied_Click(sender As Object, e As EventArgs) Handles btnDenied.Click

	End Sub

	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		DoTest.userName = userName
		DoTest.maDeThi = maDeThi
		DoTest.fullName = fullName
		DoTest.gioiTinh = lbGioiTinh.Text
		DoTest.lop = lbLop.Text
		DoTest.ngaySinh = lbNgaySinh.Text
		DoTest.imageStudent = GetImageFromDatabase(userName)
		DoTest.Show()
		Hide()
	End Sub

	Private Sub ConfirmInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim sql = "SELECT HoTen, Gioitinh, Ngaysinh, Lop, Khoa FROM Sinhvien WHERE Masv = @MaSv"
		Dim params As New List(Of SqlParameter)
		params.Add(New SqlParameter("@MaSv", userName))
		Dim dataTable As DataTable = getData(sql, params)
		If dataTable.Rows.Count > 0 Then
			lbMSV.Text = userName
			lbHoTen.Text = dataTable.Rows.Item(0).Item("HoTen")
			fullName = dataTable.Rows.Item(0).Item("HoTen")
			lbGioiTinh.Text = dataTable.Rows.Item(0).Item("Gioitinh")
			lbNgaySinh.Text = dataTable.Rows.Item(0).Item("Ngaysinh")
			lbLop.Text = dataTable.Rows.Item(0).Item("Lop")
			lbKhoa.Text = dataTable.Rows.Item(0).Item("Khoa")
			picture.Image = ByteArrayToImage(GetImageFromDatabase(userName))
		Else
			MessageBox.Show("Không tìm thấy dữ liệu. Vui lòng báo cáo giám thị để được giải quyết!", "Exam Student", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			btnConfirm.Enabled = False
			btnDenied.Enabled = False
		End If
	End Sub

	Private Sub ConfirmInfoForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		DashboardForm.Show()
	End Sub
End Class