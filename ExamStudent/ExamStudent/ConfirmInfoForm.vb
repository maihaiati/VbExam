Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class ConfirmInfoForm
	Public userName As String
	Public maDeThi As String
	Dim fullName As String

	Private Sub btnDenied_Click(sender As Object, e As EventArgs) Handles btnDenied.Click
		DashboardForm.needToChangeInfo()
		Close()
	End Sub
	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		DoTest.userName = userName
		DoTest.maDeThi = maDeThi
		DoTest.fullName = fullName
		DoTest.gioiTinh = lbGioiTinh.Text
		DoTest.lop = lbLop.Text
		DoTest.ngaySinh = lbNgaySinh.Text
		DoTest.imageStudent = GetUserImageFromDatabase(userName)
		DoTest.Show()
		Hide()
	End Sub

	Private Sub ConfirmInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim sql = "SELECT HoTen, Gioitinh, Ngaysinh, Lop, MaKhoa FROM Sinhvien WHERE Masv = @MaSv"
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
			lbKhoa.Text = dataTable.Rows.Item(0).Item("MaKhoa")
			picture.Image = ByteArrayToImage(GetUserImageFromDatabase(userName))
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