Imports System.Data.SqlClient
Imports System.Data
Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dataTable As DataTable
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Không được để trống thông tin đăng nhập!")
            Return
        End If

        Dim sql As String = "SELECT * FROM Sinhvien WHERE Masv = @Masv AND Passsv = @Passsv"
        Dim params As New List(Of SqlParameter)

        params.Add(New SqlParameter("@Masv", txtUser.Text))
        params.Add(New SqlParameter("@Passsv", txtPass.Text))

        dataTable = getData(sql, params)

        If dataTable.Rows.Count > 0 Then
            log(txtUser.Text, "Đăng nhập", "Thành công", "Đăng nhập")

            DashboardForm.userName = dataTable.Rows.Item(0).Item("Masv")
            DashboardForm.fullName = dataTable.Rows.Item(0).Item("HoTen")
            DashboardForm.Show()
            Hide()
            txtUser.Text = ""
            txtPass.Text = ""
        Else
            MsgBox("Đăng nhập thất bại, vui lòng thử lại!")
            txtUser.Text = ""
            txtPass.Text = ""

            sql = "SELECT * FROM Sinhvien WHERE Masv = @Masv"

            params.Clear()
            params.Add(New SqlParameter("@Masv", txtUser.Text))

            If getData(sql, params).Rows.Count > 0 Then
                log(txtUser.Text, "Đăng nhập", "Thất bại", "Đăng nhập")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
