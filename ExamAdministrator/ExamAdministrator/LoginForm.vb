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
            log(txtUser.Text, "Đăng nhập", "Thành công", "Đăng nhập")

            ' Định nghĩa chuỗi SQL với tham số
            sql = "SELECT Hotengv FROM Giangvien WHERE Magv = @Magv"

            ' Tạo danh sách các tham số
            params = New List(Of SqlParameter) From {
                New SqlParameter("@Magv", txtUser.Text)
            }

            ' Gọi hàm getData với chuỗi SQL và danh sách tham số
            dataTable = getData(sql, params)
            If dataTable.Rows.Count > 0 Then
                Dashboard.fullName = dataTable.Rows(0)("Hotengv").ToString()
            Else
                Dashboard.fullName = txtUser.Text
            End If
            Dashboard.userName = txtUser.Text
            Dashboard.Show()
            Hide()
        Else
            MsgBox("Đăng nhập thất bại!")
            txtUser.Text = ""
            txtPass.Text = ""
            ' Câu lệnh SQL với các tham số
            sql = "SELECT * FROM Giangvien WHERE Magv = @Magv"

            ' Tạo danh sách các tham số
            params = New List(Of SqlParameter) From {
                New SqlParameter("@Magv", txtUser.Text)
            }
            If getData(sql, params).Rows.Count > 0 Then
                log(txtUser.Text, "Đăng nhập", "Thất bại", "Đăng nhập")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        EditAccount.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
