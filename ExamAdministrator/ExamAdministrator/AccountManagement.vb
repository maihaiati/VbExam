Imports System
Imports System.ComponentModel
Public Class AccountManagement
	Public accountType As Integer '0: Teacher, 1: Student
	Public fullName As String
	Public userName As String
	Dim logout = False

	Public Sub loadData()
		If accountType = 0 Then
			assignData(dgAccount, "SELECT Magv, Hotengv, Gioitinh, Ngaysinh, Chucvu, Khoa, Administrator FROM Giangvien", Nothing)
			lblFilter.Text = "Lọc tài khoản: Giảng viên"
		Else
			assignData(dgAccount, "SELECT Masv, HoTen, Gioitinh, Ngaysinh, Lop, Khoa FROM Sinhvien", Nothing)
			lblFilter.Text = "Lọc tài khoản: Sinh viên"
		End If
	End Sub

	Private Sub AccountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		accountType = 0
		btnMe.Text = fullName
		loadData()
	End Sub

	Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
		accountType = 1
		loadData()
	End Sub

	Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
		accountType = 0
		loadData()
	End Sub

	Private Sub dgAccount_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgAccount.CellMouseDoubleClick
		' Lấy số dòng được nhấn
		Dim rowIndex As Integer = e.RowIndex
		' Lấy số cột được nhấn
		Dim columnIndex As Integer = e.ColumnIndex
		' Kiểm tra xem dòng được nhấn có hợp lệ không
		If rowIndex >= 0 AndAlso columnIndex >= 0 Then
			' Lấy dữ liệu của hàng được nhấn
			Dim selectedRow As DataGridViewRow = dgAccount.Rows(rowIndex)

			' Tạo instance của form chỉnh sửa
			Dim editForm As New EditAccount()
			If editForm.accountType = accountType Then
				' Truyền dữ liệu từ DataGridView sang form chỉnh sửa
				editForm.userName = selectedRow.Cells("Magv").Value.ToString()
				editForm.fullName = selectedRow.Cells("Hotengv").Value.ToString()
				editForm.gender = selectedRow.Cells("Gioitinh").Value.ToString()
				editForm.dtpBirth.Value = DateTime.Parse(selectedRow.Cells("Ngaysinh").Value.ToString())
				editForm.lopChucVu = selectedRow.Cells("Chucvu").Value.ToString()
				editForm.khoa = selectedRow.Cells("Khoa").Value.ToString()
				editForm.administrator = Convert.ToBoolean(selectedRow.Cells("Administrator").Value)
			Else
				editForm.userName = selectedRow.Cells("Masv").Value.ToString()
				editForm.fullName = selectedRow.Cells("Hoten").Value.ToString()
				editForm.gender = selectedRow.Cells("Gioitinh").Value.ToString()
				editForm.dtpBirth.Value = DateTime.Parse(selectedRow.Cells("Ngaysinh").Value.ToString())
				editForm.lopChucVu = selectedRow.Cells("Lop").Value.ToString()
				editForm.khoa = selectedRow.Cells("Khoa").Value.ToString()
			End If
			' Hiển thị form chỉnh sửa
			If editForm.ShowDialog() = DialogResult.OK Then
				' Tải lại dữ liệu sau khi chỉnh sửa
				loadData()
			End If
		End If
	End Sub


	Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
		Dashboard.Show()
		Close()
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		log(userName, "Đăng xuất", "Thành công", Nothing)
		LoginForm.Show()
		logout = True
		Close()
	End Sub

	Private Sub btnCreateTeacher_Click(sender As Object, e As EventArgs) Handles btnCreateTeacher.Click
		CreateAccount.accountType = 0
		CreateAccount.userName = userName
		CreateAccount.Show()
	End Sub

	Private Sub btnCreateStudent_Click(sender As Object, e As EventArgs) Handles btnCreateStudent.Click
		CreateAccount.accountType = 1
		CreateAccount.userName = userName
		CreateAccount.Show()
	End Sub

	Private Sub AccountManagement_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If Not logout Then
			Dashboard.Show()
		Else
			Dashboard.Close()
		End If
	End Sub
End Class