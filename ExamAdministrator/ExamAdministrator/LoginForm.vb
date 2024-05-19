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
            Dim logSql = "INSERT INTO Loginfo (Tennguoidung,Hoatdong,Trangthai,thoigian,chitiet) VALUES (N'" + txtUser.Text + "',N'Đăng Nhập',N'Thành công',GETDATE(),null);"
            MsgBox("Đăng nhập thành công!")
			runSqlCommand(logSql)

            sql = "SELECT Hotengv FROM Giangvien WHERE Magv = '" + txtUser.Text + "'"
			dataTable = getData(sql)
            If dataTable.Rows.Count > 0 Then
                Dashboard.userName = dataTable.Rows(0)("Hotengv").ToString()
            Else
                Dashboard.userName = txtUser.Text
            End If
            Dashboard.Show()
            Me.Hide()
        Else
				Dim logSql = "INSERT INTO Loginfo (Tennguoidung,Hoatdong,Trangthai,thoigian,chitiet) VALUES (N'" + txtUser.Text + "',N'Đăng Nhập',N'Thất bại',GETDATE(),null);"
            MsgBox("Đăng nhập thất bại!")

            ' Câu lệnh SQL với các tham số
            sql = "SELECT * FROM Giangvien WHERE Magv = @Magv"

            ' Tạo danh sách các tham số
            params = New List(Of SqlParameter) From {
                New SqlParameter("@Magv", txtUser.Text)
            }
            If getData(sql, params).Rows.Count > 0 Then
                runSqlCommand(logSql)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
