Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class EditExam
    Public maDe As String
    Public maKhoa As String
    Public tenDe As String
    Dim sql As String

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim params As New List(Of SqlParameter)

        ' Xoá câu hỏi
        sql = "DELETE FROM CauHoi WHERE MaDeThi = @Made"
        params.Add(New SqlParameter("@Made", maDe))
        If Not runSqlCommand(sql, params) Then
            MessageBox.Show("Xoá đề thi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        params.Clear()

        ' Xoá thông tin đề
        sql = "DELETE FROM DeThi WHERE MaDeThi = @Made"
        params.Add(New SqlParameter("@Made", maDe))
        If runSqlCommand(sql, params) Then
            ExamManagement.loadData("SELECT * FROM DeThi", Nothing)
            Close()
        Else
            MessageBox.Show("Xoá đề thi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

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
        If txtMaKhoa.Text = "" Or txtTenDe.Text = "" Then
            MessageBox.Show("Không được để trống thông tin!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
			Dim params As New List(Of SqlParameter)
            sql = "UPDATE DeThi SET MaKhoa = @MaKhoa, TenDeThi = @TenDeThi WHERE MaDeThi = @MaDe"
            params.Add(New SqlParameter("@MaKhoa", txtMaKhoa.Text))
			params.Add(New SqlParameter("@TenDeThi", txtTenDe.Text))
			params.Add(New SqlParameter("@MaDe", maDe))
			If Not runSqlCommand(sql, params) Then
				MessageBox.Show("Chỉnh sửa đề thi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Else
				ExamManagement.loadData("SELECT * FROM DeThi", Nothing)
			End If
        End If
    End Sub

    Private Sub EditExam_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EditType.Close()
        ExamManagement.Show()
    End Sub
End Class