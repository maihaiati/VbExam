Public Class Dashboard
	Public userName As String
	Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnMe.Text = userName
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

	End Sub
End Class