Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ScoreView
	Public userName As String
	Public fullName As String
	Dim logout = False

	Private Sub ScoreView_Load(sender As Object, e As EventArgs) Handles Me.Load
		btnMe.Text = fullName
		Dim params As New List(Of SqlParameter) From {New SqlParameter("@MaSv", userName)}
		dgScore.DataSource = getData("SELECT * FROM Bangdiem WHERE Masv = @MaSv", params)
	End Sub

	Private Sub btnMyAccount_Click(sender As Object, e As EventArgs) Handles btnMyAccount.Click
		DashboardForm.needToChangeInfo()
		Close()
	End Sub

	Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
		Close()
	End Sub

	Private Sub ScoreView_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If logout Then
			DashboardForm.Close()
		Else
			DashboardForm.Show()
		End If
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		logout = True
		Close()
	End Sub
End Class