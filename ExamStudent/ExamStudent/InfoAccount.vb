Imports System.Data.SqlClient
Imports System.IO

Public Class InfoAccount
	Public userName As String
	Dim sql As String
	Dim machineName As String = Environment.MachineName ' Lấy tên của máy tính

	Function ByteArrayToImage(ByVal byteArray As Byte()) As Image ' Chuyển đổi mảng byte thành ảnh
		Using ms As New MemoryStream(byteArray)
			Return Image.FromStream(ms)
		End Using
	End Function

	Function GetImageFromDatabase(ByVal userid As String) As Byte() ' Lấy ảnh từ database theo mã ảnh
		Dim imageData As Byte() = Nothing
		Dim sql As String
		sql = "SELECT image FROM Sinhvien WHERE Masv = @Masv"

		Using conn As New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
			Using cmd As New SqlCommand(sql, conn)
				cmd.Parameters.AddWithValue("@Masv", userid)
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

	Private Sub InfoAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim params As New List(Of SqlParameter) From {New SqlParameter("@Masv", userName)}
		Dim dataTable As DataTable = getData("SELECT * FROM Sinhvien WHERE Masv = @Masv", params)
		If dataTable.Rows.Count = 0 Then
			MessageBox.Show("Không lấy được thông tin tài khoản!", "Exam Student", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If
		txtMsv.Text = userName
		txtHoTen.Text = dataTable.Rows(0)("HoTen")
		txtLop.Text = dataTable.Rows(0)("Lop")
		txtKhoa.Text = dataTable.Rows(0)("Khoa")
		dtpNgaySinh.Value = dataTable.Rows(0)("Ngaysinh")
		cbbGioiTinh.Items.Add("Nam")
		cbbGioiTinh.Items.Add("Nữ")
		cbbGioiTinh.SelectedItem = dataTable.Rows(0)("Gioitinh")
		picture.Image = ByteArrayToImage(GetImageFromDatabase(userName))
	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Close()
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		sql = "UPDATE Sinhvien SET "
	End Sub
End Class