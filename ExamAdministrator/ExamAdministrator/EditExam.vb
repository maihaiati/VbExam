Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class EditExam
    Public maDe As String
    Public maKhoa As String
    Public tenDe As String
    Dim sql As String
    Dim params As New List(Of SqlParameter)
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        sql = "DELETE FROM DeThi WHERE MaDeThi = @Made"
        params.Add(New SqlParameter("@Made", maDe))
        If checkExists("MaDeThi", "DeThi", maDe) Then
            If runSqlCommand(sql, params) Then
                ExamManagement.loadData("SELECT * FROM DeThi", Nothing)
            Else
                MessageBox.Show("Xoá đề thi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Mã đề thi không tồn tại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        params.Clear()
    End Sub

    Private Sub EditExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaDe.Text = maDe
        txtMaKhoa.Text = maKhoa
        txtTenDe.Text = tenDe
        txtMaDe.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub EditExam_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EditType.Close()
        ExamManagement.Show()
    End Sub
End Class