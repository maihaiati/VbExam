Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ExamManagement
	Public userName As String
	Public fullName As String
	Dim logout = False
	Dim sql As String

	Public Sub loadData(sql As String, params As List(Of SqlParameter))
		assignData(dgExam, sql, params)
	End Sub
	Private Sub ExamManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnMe.Text = fullName
		loadData("SELECT * FROM DeThi", Nothing)
	End Sub

	Private Sub ExamManagement_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		ExamFilter.Close()
		If Not logout Then
			Dashboard.Show()
		Else
			Dashboard.Close()
		End If
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		logout = True
		Close()
	End Sub

	Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
		Close()
	End Sub

	Private Sub dgExam_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgExam.CellMouseDoubleClick

	End Sub

	Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
		ExamFilter.Show()
	End Sub
End Class