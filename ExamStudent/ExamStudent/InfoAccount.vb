Imports System.Data.SqlClient
Imports System.IO

Public Class InfoAccount
	Public userName As String
	Dim sql As String
	Dim imageByte As Byte() = Nothing
	Dim machineName As String = Environment.MachineName ' Lấy tên của máy tính

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
		For Each row As DataRow In getData("SELECT MaKhoa FROM Khoa", Nothing).Rows
			cbbKhoa.Items.Add(row("MaKhoa"))
		Next
		cbbKhoa.SelectedItem = dataTable.Rows(0)("MaKhoa")
		dtpNgaySinh.Value = dataTable.Rows(0)("Ngaysinh")
		cbbGioiTinh.Items.Add("Nam")
		cbbGioiTinh.Items.Add("Nữ")
		cbbGioiTinh.SelectedItem = dataTable.Rows(0)("Gioitinh")
		imageByte = GetUserImageFromDatabase(userName)
		picture.Image = ByteArrayToImage(imageByte)
	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Close()
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim result As DialogResult = MessageBox.Show("Xác nhận thay đổi thông tin?", "Exam Student", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
		If result = DialogResult.No Then
			Return
		End If
		sql = "UPDATE Sinhvien SET Image = @Image, HoTen = @HoTen, Gioitinh = @GioiTinh, Ngaysinh = @NgaySinh, Lop = @Lop, MaKhoa = @MaKhoa WHERE Masv = @MaSv"
		Dim params As New List(Of SqlParameter)
		params.Add(New SqlParameter("@Image", If(imageByte IsNot Nothing, imageByte, DBNull.Value)))
		params.Add(New SqlParameter("@HoTen", txtHoTen.Text))
		params.Add(New SqlParameter("@GioiTinh", cbbGioiTinh.SelectedItem))
		params.Add(New SqlParameter("@NgaySinh", dtpNgaySinh.Value.ToString))
		params.Add(New SqlParameter("@Lop", txtLop.Text))
		params.Add(New SqlParameter("@MaKhoa", cbbKhoa.SelectedItem))
		params.Add(New SqlParameter("@MaSv", userName))
		If runSqlCommand(sql, params) Then
			MessageBox.Show("Thay đổi thông tin thành công!", "Exam Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MessageBox.Show("Thay đổi thông tin thất bại!", "Exam Student", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub
End Class