Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Data.SqlClient
Imports System.IO
Public Class InfoAccount
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
        Dashboard.Show()
    End Sub

    Private Sub InfoAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
    End Sub
End Class