Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ExamLog
	Public userName As String
    Public fullName As String
    Dim logout = False
    Private Sub loadData(sql As String, params As List(Of SqlParameter))
        DGV_Log.DataSource = getData(sql, params)
    End Sub
    Private Sub txttimkiem_TextChanged(sender As Object, e As EventArgs) Handles txttimkiem.TextChanged
        Dim params As New List(Of SqlParameter)
        params.Add(New SqlParameter("@TenNguoiDung", "%" & txttimkiem.Text & "%"))
        loadData("SELECT * FROM Loginfo WHERE TenNguoiDung LIKE @TenNguoiDung", params)
    End Sub

    Private Sub ExamLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMe.Text = fullName
        loadData("SELECT * FROM Loginfo", Nothing)
    End Sub

    Private Sub ExamLog_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If logout Then
            Dashboard.Close()
        Else
            Dashboard.Show()
        End If
    End Sub

    Private Sub btnMyAccount_Click(sender As Object, e As EventArgs) Handles btnMyAccount.Click
        Dashboard.openInfoAccount()
        Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        logout = True
        Close()
    End Sub
End Class