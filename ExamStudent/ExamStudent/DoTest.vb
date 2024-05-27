Public Class DoTest
	Public userName As String
	Public fullName As String
	Public maDeThi As String

	Private Sub DoTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnMe.Text = fullName
	End Sub
End Class