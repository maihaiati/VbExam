Imports System
Public Class AccountManager
	Public accountType As Integer '0: Teacher, 1: Student
	Public userName As String

	Private Sub AccountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		accountType = 0
		If accountType = 0 Then
			assignData(dgAccount, "SELECT * FROM Sinhvien")
		End If
	End Sub
End Class