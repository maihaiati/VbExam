Public Class Dashboard
	Public name As String
	Public userName
	Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnMe.Text = name
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		log(userName, "Đăng xuất", "Thành công", "Đăng xuất")
		LoginForm.Show()
		Close()
	End Sub

	Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
		AccountManagement.userName = userName
		AccountManagement.name = Me.name
		AccountManagement.Show()
		Hide()
	End Sub
End Class