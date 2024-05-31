Imports System.Data.SqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dataTable As DataTable
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("Không được để trống thông tin đăng nhập!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim sql As String = "SELECT * FROM Giangvien WHERE Magv = @Magv"

        Dim params As New List(Of SqlParameter) From {New SqlParameter("@Magv", txtUser.Text)}

		dataTable = getData(sql, params)
        If dataTable.Rows.Count = 0 Then
            MessageBox.Show("Đăng nhập thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'Không ghi log vì trường hợp này mã gv không tồn tại (tương tự với Exam Student)
            txtUser.Text = ""
            txtPass.Text = ""
            Return
        End If

        Dim inputPass = HashPasswordWithSalt(txtPass.Text, dataTable.Rows.Item(0).Item("salt"))

        If inputPass = dataTable.Rows.Item(0).Item("Passgv") Then
            log(txtUser.Text, "Đăng nhập", "Thành công", "Đăng nhập")

            Dashboard.fullName = dataTable.Rows.Item(0).Item("Hotengv").ToString()
            Dashboard.userName = txtUser.Text
            Dashboard.Show()
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
