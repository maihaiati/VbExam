Imports System.Data.SqlClient

Public Class EditAccount
    Public accountType As Integer '0: Teacher, 1: Student
    Public activeUserName As String
    Public userName As String
    Public fullName As String
    Public gender As String
    Public lopChucVu As String
    Public khoa As String
    Public administrator As Boolean

    Private Sub EditAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If accountType = 0 Then
            lblUser.Text = "Mã giảng viên"
            lblLopChucVu.Text = "Chức vụ"
            cbAdmin.Checked = administrator
        Else
            lblUser.Text = "Mã sinh viên"
            lblLopChucVu.Text = "Lớp"
            cbAdmin.Enabled = False
        End If

        If userName = activeUserName Then
            btnDelete.Enabled = False
        End If
        txtUser.Enabled = False
        txtUser.Text = userName
        txtName.Text = fullName
        cbbGender.Items.Add("Nam")
        cbbGender.Items.Add("Nữ")
        cbbGender.SelectedItem = gender
        txtLopChucVu.Text = lopChucVu
        txtKhoa.Text = khoa
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim sql As String
        Dim success = False

        If txtName.Text = "" Or cbbGender.SelectedItem = "" Or txtLopChucVu.Text = "" Or txtKhoa.Text = "" Then
            MessageBox.Show("Không được để trống thông tin trừ mật khẩu!")
            Return
        End If

        If accountType = 0 Then
            Dim admin As Integer
            admin = If(cbAdmin.Checked, 1, 0)
            Dim params As New List(Of SqlParameter)

            If txtPass.Text <> "" Then
                sql = "UPDATE Giangvien SET Passgv = @Passgv, Hotengv = @Hotengv, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Chucvu = @Chucvu, Khoa = @Khoa, Administrator = @Administrator " &
                  "WHERE Magv = @Magv"

                If checkExists("Magv", "Giangvien", userName) Then
                    params.Add(New SqlParameter("@Magv", userName))
                    params.Add(New SqlParameter("@Passgv", txtPass.Text))
                    params.Add(New SqlParameter("@Hotengv", txtName.Text))
                    params.Add(New SqlParameter("@Gioitinh", cbbGender.SelectedItem.ToString()))
                    params.Add(New SqlParameter("@Ngaysinh", dtpBirth.Value.ToString("MM-dd-yyyy")))
                    params.Add(New SqlParameter("@Chucvu", txtLopChucVu.Text))
                    params.Add(New SqlParameter("@Khoa", txtKhoa.Text))
                    params.Add(New SqlParameter("@Administrator", admin))

                    If runSqlCommand(sql, params) Then
                        MsgBox("Chỉnh sửa tài khoản thành công")
                        success = True
                        AccountManagement.loadData()
                    Else
                        MsgBox("Chỉnh sửa tài khoản thất bại")
                    End If
                Else
                    MsgBox("Không tìm thấy mã giảng viên!")
                End If
            Else
                sql = "UPDATE Giangvien SET Hotengv = @Hotengv, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Chucvu = @Chucvu, Khoa = @Khoa, Administrator = @Administrator " &
                  "WHERE Magv = @Magv"

                If checkExists("Magv", "Giangvien", userName) Then
                    params.Add(New SqlParameter("@Magv", userName))
                    params.Add(New SqlParameter("@Hotengv", txtName.Text))
                    params.Add(New SqlParameter("@Gioitinh", cbbGender.SelectedItem.ToString()))
                    params.Add(New SqlParameter("@Ngaysinh", dtpBirth.Value.ToString("MM-dd-yyyy")))
                    params.Add(New SqlParameter("@Chucvu", txtLopChucVu.Text))
                    params.Add(New SqlParameter("@Khoa", txtKhoa.Text))
                    params.Add(New SqlParameter("@Administrator", admin))

                    If runSqlCommand(sql, params) Then
                        MsgBox("Chỉnh sửa tài khoản thành công")
                        success = True
                        AccountManagement.loadData()
                    Else
                        MsgBox("Chỉnh sửa tài khoản thất bại")
                    End If
                Else
                    MsgBox("Không tìm thấy mã giảng viên!")
                End If
            End If

            log(userName, "Chỉnh sửa tài khoản", If(success, "Thành công", "Thất bại"), "Chỉnh sửa tài khoản giảng viên")

        Else
            sql = "UPDATE Sinhvien SET Passsv = @Passsv, HoTen = @HoTen, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Lop = @Lop, Khoa = @Khoa " &
                  "WHERE Masv = @Masv"

            If checkExists("Masv", "Sinhvien", userName) Then
                Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@Masv", userName),
                New SqlParameter("@Passsv", txtPass.Text),
                New SqlParameter("@HoTen", txtName.Text),
                New SqlParameter("@Gioitinh", cbbGender.SelectedItem.ToString()),
                New SqlParameter("@Ngaysinh", dtpBirth.Value.ToString("MM-dd-yyyy")),
                New SqlParameter("@Lop", txtLopChucVu.Text),
                New SqlParameter("@Khoa", txtKhoa.Text)
            }

                If runSqlCommand(sql, params) Then
                    MsgBox("Chỉnh sửa tài khoản thành công")
                    success = True
                    AccountManagement.loadData()
                Else
                    MsgBox("Chỉnh sửa tài khoản thất bại")
                End If
            Else
                MsgBox("Không tìm thấy mã sinh viên!")
            End If

            log(userName, "Chỉnh sửa tài khoản", If(success, "Thành công", "Thất bại"), "Chỉnh sửa tài khoản sinh viên")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sql As String
        Dim success = False

        If accountType = 0 Then
            sql = "DELETE FROM Giangvien WHERE Magv = @Magv"

            If checkExists("Magv", "Giangvien", userName) Then
                Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@Magv", userName)
            }

                If runSqlCommand(sql, params) Then
                    MsgBox("Xóa tài khoản thành công")
                    success = True
                    AccountManagement.loadData()
                Else
                    MsgBox("Xóa tài khoản thất bại")
                End If
            Else
                MsgBox("Không tìm thấy mã giảng viên!")
            End If

            log(userName, "Xóa tài khoản", If(success, "Thành công", "Thất bại"), "Xóa tài khoản giảng viên")

        Else
            sql = "DELETE FROM Sinhvien WHERE Masv = @Masv"

            If checkExists("Masv", "Sinhvien", userName) Then
                Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@Masv", userName)
            }

                If runSqlCommand(sql, params) Then
                    MsgBox("Xóa tài khoản thành công")
                    success = True
                    AccountManagement.loadData()
                Else
                    MsgBox("Xóa tài khoản thất bại")
                End If
            Else
                MsgBox("Không tìm thấy mã sinh viên!")
            End If

            log(userName, "Xóa tài khoản", If(success, "Thành công", "Thất bại"), "Xóa tài khoản sinh viên")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class