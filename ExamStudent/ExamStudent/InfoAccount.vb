Imports System.Data.SqlClient
Imports System.IO

Public Class InfoAccount
	Public userName As String
	Dim sql As String
	Dim machineName As String = Environment.MachineName ' Lấy tên của máy tính

	' Hàm chuyển đổi ảnh thành mảng byte
	Function ImageToByteArray(ByVal image As Image) As Byte()
		Using ms As New MemoryStream()
			image.Save(ms, image.RawFormat)
			Return ms.ToArray()
		End Using
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
		picture.Image = ByteArrayToImage(GetUserImageFromDatabase(userName))
		txtMsv.Enabled = False
	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Close()
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		sql = "UPDATE Sinhvien SET "
	End Sub
End Class