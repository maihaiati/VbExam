Imports System
Public Class AccountManager
	Public accountType As Integer '0: Teacher, 1: Student, 2: Both
	Public userName As String

	Private Sub AccountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If accountType = 0 Then
			assignData(dgAccount, "SELECT * FROM ")
		End If
	End Sub
End Class