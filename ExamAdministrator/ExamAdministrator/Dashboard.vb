Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Dashboard
    Public fullName As String
    Public userName As String
    Dim sql As String
    Dim params As New List(Of SqlParameter)

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnMe.Text = fullName
        sql = "SELECT Administrator FROM Giangvien WHERE Magv = @Magv"
        params.Add(New SqlParameter("@Magv", userName))
        If getData(sql, params).Rows.Item(0).Item("Administrator") = 0 Then
            btnAccount.Enabled = False
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Close()
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        AccountManagement.userName = userName
        AccountManagement.fullName = fullName
        AccountManagement.Show()
        Hide()
    End Sub

    Private Sub Dashboard_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        log(userName, "Đăng xuất", "Thành công", "Đăng xuất")
        LoginForm.Show()
    End Sub

    Private Sub btnExam_Click(sender As Object, e As EventArgs) Handles btnExam.Click
        ExamManagement.userName = userName
        ExamManagement.fullName = fullName
        ExamManagement.Show()
        Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub


End Class