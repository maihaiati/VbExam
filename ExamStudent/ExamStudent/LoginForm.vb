Imports System.Data.SqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dataTable As DataTable
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Không được để trống thông tin đăng nhập!")
            Return
        End If

        ' Câu lệnh SQL với các tham số
        Dim sql As String = "SELECT * FROM Sinhvien WHERE Masv = @Masv AND Passsv = @Passsv"

        ' Tạo danh sách các tham số
        Dim params As New List(Of SqlParameter) From {
        New SqlParameter("@Masv", txtUser.Text),
        New SqlParameter("@Passsv", txtPass.Text)
}

        ' Gọi hàm getData với câu lệnh SQL và các tham số
        dataTable = getData(sql, params)

        ' Kiểm tra kết quả
        If dataTable.Rows.Count > 0 Then
            log(txtUser.Text, "Đăng nhập", "Thành công", "Đăng nhập")
            MsgBox("Đăng nhập thành công!")

            ' Định nghĩa chuỗi SQL với tham số
            sql = "SELECT Hoten FROM Sinhvien WHERE Masv = @Masv"

            ' Tạo danh sách các tham số
            params = New List(Of SqlParameter) From {
            New SqlParameter("@Masv", txtUser.Text)
}

            'Gọi hàm getData với chuỗi SQL và danh sách tham số
            'dataTable = getData(sql, params)
            'If dataTable.Rows.Count > 0 Then
            'Dashboard.name = dataTable.Rows(0)("Hotensv").ToString()
            'Else
            'Dashboard.name = txtUser.Text
            'End If
            'Dashboard.userName = txtUser.Text
            'Dashboard.Show()
            'Hide()
            'DashboardForm.Show()
        Else
            MsgBox("Đăng nhập thất bại!")

            ' Câu lệnh SQL với các tham số
            sql = "SELECT * FROM Sinhvien WHERE Masv = @Masv"

            ' Tạo danh sách các tham số
            params = New List(Of SqlParameter) From {
            New SqlParameter("@Masv", txtUser.Text)
}
            If getData(sql, params).Rows.Count > 0 Then
                log(txtUser.Text, "Đăng nhập", "Thất bại", "Đăng nhập")
            End If
        End If
    End Sub
End Class
