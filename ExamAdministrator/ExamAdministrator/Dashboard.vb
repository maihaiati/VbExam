Public Class Dashboard
	Public name As String
	Public userName
	Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnMe.Text = name
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		runSqlCommand("INSERT INTO Loginfo (Tennguoidung,Hoatdong,Trangthai,thoigian,chitiet) VALUES (N'" + userName + "',N'Đăng xuất',N'Thành công',GETDATE(),null);")
		LoginForm.Show()
		Close()
	End Sub

	Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
		AccountManagement.userName = userName
		AccountManagement.name = name
		AccountManagement.Show()
		Hide()
	End Sub
End Class