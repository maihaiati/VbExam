Imports System.Data.SqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dataTable As DataTable
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Không được để trống thông tin đăng nhập!")
            Return
        End If

        ' Câu lệnh SQL với các tham số
        Dim sql As String = "SELECT * FROM Giangvien WHERE Magv = @Magv AND Passgv = @Passgv"

        ' Tạo danh sách các tham số
        Dim params As New List(Of SqlParameter) From {
New SqlParameter("@Magv", txtUser.Text),
        New SqlParameter("@Passgv", txtPass.Text)
    }

        ' Gọi hàm getData với câu lệnh SQL và các tham số
        dataTable = getData(sql, params)

        ' Kiểm tra kết quả
        If dataTable.Rows.Count > 0 Then
            MsgBox("Đăng nhập thành công!")
        Else
            MsgBox("Đăng nhập thất bại!")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
