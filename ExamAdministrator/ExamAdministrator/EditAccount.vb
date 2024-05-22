Imports System.Data.SqlClient

Public Class EditAccount
    Public accountType As Integer '0: Teacher, 1: Student
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
            txtUser.Text = userName
            txtName.Text = fullName
            cbbGender.Items.Add("Nam")
            cbbGender.Items.Add("Nữ")
            cbbGender.SelectedValue = gender
            txtLopChucVu.Text = lopChucVu
            txtKhoa.Text = khoa
            cbAdmin.Checked = administrator
        Else
            lblUser.Text = "Mã sinh viên"
            lblLopChucVu.Text = "Lớp"
            txtUser.Text = userName
            txtName.Text = fullName
            cbbGender.Items.Add("Nam")
            cbbGender.Items.Add("Nữ")
            cbbGender.SelectedValue = gender
            txtLopChucVu.Text = lopChucVu
            txtKhoa.Text = khoa
            cbAdmin.Enabled = False
        End If
    End Sub

    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        Dim sql As String
        Dim success As Boolean
        success = False

        If accountType = 0 Then
            Dim admin As Integer
            admin = If(cbAdmin.Checked, 1, 0)

            sql = "UPDATE Giangvien SET Passgv = @Passgv, Hotengv = @Hotengv, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Chucvu = @Chucvu, Khoa = @Khoa, Administrator = @Administrator " &
                  "WHERE Magv = @Magv"

            If checkExists("Magv", "Giangvien", txtUser.Text) Then
                Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@Magv", txtUser.Text),
                New SqlParameter("@Passgv", txtPass.Text),
                New SqlParameter("@Hotengv", txtName.Text),
                New SqlParameter("@Gioitinh", cbbGender.SelectedItem.ToString()),
                New SqlParameter("@Ngaysinh", dtpBirth.Value.ToString("MM-dd-yyyy")),
                New SqlParameter("@Chucvu", txtLopChucVu.Text),
                New SqlParameter("@Khoa", txtKhoa.Text),
                New SqlParameter("@Administrator", admin)
            }

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

            log(userName, "Chỉnh sửa tài khoản", If(success, "Thành công", "Thất bại"), "Chỉnh sửa tài khoản giảng viên")

        Else
            sql = "UPDATE Sinhvien SET Passsv = @Passsv, HoTen = @HoTen, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Lop = @Lop, Khoa = @Khoa " &
                  "WHERE Masv = @Masv"

            If checkExists("Masv", "Sinhvien", txtUser.Text) Then
                Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@Masv", txtUser.Text),
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

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim sql As String
        Dim success As Boolean
        success = False

        If accountType = 0 Then
            sql = "DELETE FROM Giangvien WHERE Magv = @Magv"

            If checkExists("Magv", "Giangvien", txtUser.Text) Then
                Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@Magv", txtUser.Text)
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

            If checkExists("Masv", "Sinhvien", txtUser.Text) Then
                Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@Masv", txtUser.Text)
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
        End

    End Sub
End Class