Imports System.Data.SqlClient

Public Class CreateExam
    Dim sql As String
    Dim params As New List(Of SqlParameter)
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtMaDe.Text = "" Or txtMaKhoa.Text = "" Or txtTenDe.Text = "" Then
            MessageBox.Show("Không được để trống thông tin!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql = "INSERT INTO DeThi (MaDeThi, MaKhoa, TenDeThi, SoCau) VALUES (@Madethi, @Makhoa, @Tendethi, 0)"
            params.Add(New SqlParameter("@Madethi", txtMaDe.Text))
            params.Add(New SqlParameter("@Makhoa", txtMaKhoa.Text))
            params.Add(New SqlParameter("@Tendethi", txtTenDe.Text))

            If runSqlCommand(sql, params) Then
                ExamManagement.loadData("SELECT * FROM DeThi", Nothing)
            Else
                MessageBox.Show("Tạo đề thi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class