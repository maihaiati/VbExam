Imports System.ComponentModel

Public Class Dashboard
	Public fullName As String
	Public userName As String
	Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnMe.Text = fullName
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		Close()
	End Sub

	Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
		AccountManagement.userName = userName
		AccountManagement.fullName = fullName
		AccountManagement.Show()
		Hide()
	End Sub

    Private Sub Dashboard_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        log(userName, "Đăng xuất", "Thành công", "Đăng xuất")
        LoginForm.Show
    End Sub

    Private Sub btnExam_Click(sender As Object, e As EventArgs) Handles btnExam.Click
		ExamManagement.userName = userName
		ExamManagement.fullName = fullName
		ExamManagement.Show()
		Hide()
	End Sub
End Class