﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Data.SqlClient
Imports System.IO
Imports System.ComponentModel
Public Class InfoAccount
	Public userName As String
	Dim imageByte As Byte() = Nothing

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Close()
	End Sub

	Private Sub InfoAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim params As New List(Of SqlParameter) From {New SqlParameter("@MaGv", userName)}
		Dim dataTable As DataTable = getData("SELECT Image, Hotengv, Gioitinh, Ngaysinh, Chucvu, Khoa FROM Giangvien WHERE Magv = @MaGv", params)

		If dataTable.Rows.Count > 0 Then
			txtMaGV.Text = userName
			txtTenGV.Text = dataTable.Rows(0)("Hotengv")
			dtpBirth.Value = dataTable.Rows(0)("Ngaysinh")
			cbbGender.Items.Add("Nam")
			cbbGender.Items.Add("Nữ")
			cbbGender.SelectedItem = dataTable.Rows(0)("Gioitinh")
			txtChucVu.Text = dataTable.Rows(0)("Chucvu")
			txtKhoa.Text = dataTable.Rows(0)("Khoa")
			imageByte = GetUserImageFromDatabase(userName, True)
			imgAvatar.Image = ByteArrayToImage(imageByte)
		Else
			MessageBox.Show("Tải thông tin thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
		Dim sql As String = "UPDATE Giangvien SET Image = @Image, Hotengv = @HoTen, Gioitinh = @GioiTinh, Ngaysinh = @NgaySinh, Chucvu = @ChucVu, Khoa = @Khoa WHERE Magv = @MaGv"
		Dim params As New List(Of SqlParameter)
		params.Add(New SqlParameter("@Image", If(imageByte IsNot Nothing, imageByte, DBNull.Value)))
		params.Add(New SqlParameter("@HoTen", txtTenGV.Text))
		params.Add(New SqlParameter("@GioiTinh", cbbGender.SelectedItem))
		params.Add(New SqlParameter("@NgaySinh", dtpBirth.Value.ToString))
		params.Add(New SqlParameter("@ChucVu", txtChucVu.Text))
		params.Add(New SqlParameter("@Khoa", txtKhoa.Text))
		params.Add(New SqlParameter("@MaGv", userName))
		If runSqlCommand(sql, params) Then
			MessageBox.Show("Thay đổi thông tin thành công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MessageBox.Show("Thay đổi thông tin thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub imgAvatar_Click(sender As Object, e As EventArgs) Handles imgAvatar.Click
		imageByte = LoadImage(imgAvatar)
	End Sub
End Class