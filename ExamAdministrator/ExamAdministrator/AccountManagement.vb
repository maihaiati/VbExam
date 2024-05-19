Imports System
Public Class AccountManagement
	Public accountType As Integer '0: Teacher, 1: Student
	Public name As String
	Public userName As String

	Public Sub loadData()
		If accountType = 1 Then
			assignData(dgAccount, "SELECT * FROM Sinhvien", Nothing)
			lblFilter.Text = "Lọc tài khoản: Sinh viên"
		Else
			assignData(dgAccount, "SELECT * FROM Giangvien", Nothing)
			lblFilter.Text = "Lọc tài khoản: Giảng viên"
		End If
	End Sub

	Private Sub AccountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		accountType = 1
		btnMe.Text = Me.name
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

		' Hiển thị thông tin dòng và cột
		MessageBox.Show($"Dòng: {rowIndex}, Cột: {columnIndex}")
	End Sub

	Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
		Dashboard.Show()
		Close()
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		log(userName, "Đăng xuất", "Thành công", Nothing)
		LoginForm.Show()
		Dashboard.Close()
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
End Class