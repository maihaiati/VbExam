Imports System.Data.SqlClient
Imports System.Data
Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dataTable As DataTable
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Không được để trống thông tin đăng nhập!")
            Return
        End If

        Dim sql As String = "SELECT * FROM Sinhvien WHERE Masv = @Masv"
        Dim params As New List(Of SqlParameter) From {New SqlParameter("@Masv", txtUser.Text)}

        dataTable = getData(sql, params)
        If dataTable.Rows.Count = 0 Then
            MessageBox.Show("Đăng nhập thất bại!", "Exam Student", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUser.Text = ""
            txtPass.Text = ""
        End If

        Dim inputPass = HashPasswordWithSalt(txtPass.Text, dataTable.Rows.Item(0).Item("salt"))

        If inputPass = dataTable.Rows.Item(0).Item("Passsv") Then
            log(txtUser.Text, "Đăng nhập", "Thành công", "Đăng nhập")

            DashboardForm.userName = dataTable.Rows.Item(0).Item("Masv")
            DashboardForm.fullName = dataTable.Rows.Item(0).Item("HoTen")
            DashboardForm.Show()
            Hide()
            txtUser.Text = ""
            txtPass.Text = ""
        Else
            MessageBox.Show("Đăng nhập thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            log(txtUser.Text, "Đăng nhập", "Thất bại", "Đăng nhập")
            txtUser.Text = ""
            txtPass.Text = ""
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
