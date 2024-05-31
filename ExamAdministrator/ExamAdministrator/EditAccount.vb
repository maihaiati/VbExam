Imports System.Data.SqlClient
Imports System.IO

Public Class EditAccount
    Public accountType As Integer '0: Teacher, 1: Student
    Public activeUserName As String
    Public userName As String
    Public fullName As String
    Public gender As String
    Public lopChucVu As String
    Public khoa As String
    Public administrator As Boolean
    Dim sql As String
    Dim success = False
    Dim imageBytes As Byte() = Nothing ' Khởi tạo giá trị mặc định

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
            cbAdmin.Enabled = False
        End If
        txtUser.Enabled = False
        txtUser.Text = userName
        txtName.Text = fullName
        cbbGender.Items.Add("Nam")
        cbbGender.Items.Add("Nữ")
        cbbGender.SelectedItem = gender
        txtLopChucVu.Text = lopChucVu
        txtKhoa.Text = khoa
        imgAvatar.SizeMode = PictureBoxSizeMode.Zoom
        imageBytes = GetUserImageFromDatabase(userName, accountType = 0)
        If imageBytes IsNot Nothing Then
            imgAvatar.Image = ByteArrayToImage(imageBytes)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim sql As String
        Dim success = False
        Dim admin As Integer
        admin = If(cbAdmin.Checked, 1, 0)
        Dim params As New List(Of SqlParameter)

        If txtName.Text = "" Or cbbGender.SelectedItem = "" Or txtLopChucVu.Text = "" Or txtKhoa.Text = "" Then
            MessageBox.Show("Không được để trống thông tin trừ mật khẩu!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Xác nhận thay đổi thông tin?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.No Then
            Return
        End If

        If accountType = 0 Then

            If txtPass.Text <> "" Then
                sql = "UPDATE Giangvien SET Passgv = @Passgv, Image = @Image , Hotengv = @Hotengv, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Chucvu = @Chucvu, Khoa = @Khoa, salt = @Salt, Administrator = @Administrator " &
              "WHERE Magv = @Magv"

                Dim salt = GenerateSalt(15)
                Dim pass As String = HashPasswordWithSalt(txtPass.Text, salt)

                If checkExists("Magv", "Giangvien", userName) Then
                    params.Add(New SqlParameter("@Magv", userName))
                    params.Add(New SqlParameter("@Passgv", pass))
                    params.Add(New SqlParameter("@Image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value)))
                    params.Add(New SqlParameter("@Hotengv", txtName.Text))
                    params.Add(New SqlParameter("@Gioitinh", cbbGender.SelectedItem.ToString()))
                    params.Add(New SqlParameter("@Ngaysinh", dtpBirth.Value.ToString("MM-dd-yyyy")))
                    params.Add(New SqlParameter("@Chucvu", txtLopChucVu.Text))
                    params.Add(New SqlParameter("@Khoa", txtKhoa.Text))
                    params.Add(New SqlParameter("@Salt", salt))
                    params.Add(New SqlParameter("@Administrator", admin))

                    If runSqlCommand(sql, params) Then
                        MessageBox.Show("Chỉnh sửa tài khoản thành công", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        success = True
                        AccountManagement.loadData()
                    Else
                        MessageBox.Show("Chỉnh sửa tài khoản thất bại", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MsgBox("Không tìm thấy mã giảng viên!")
                End If
            Else
                sql = "UPDATE Giangvien SET Hotengv = @Hotengv,Image = @Image, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Chucvu = @Chucvu, Khoa = @Khoa, Administrator = @Administrator " &
              "WHERE Magv = @Magv"

                If checkExists("Magv", "Giangvien", userName) Then
                    params.Add(New SqlParameter("@Magv", userName))
                    params.Add(New SqlParameter("@Image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value)))
                    params.Add(New SqlParameter("@Hotengv", txtName.Text))
                    params.Add(New SqlParameter("@Gioitinh", cbbGender.SelectedItem.ToString()))
                    params.Add(New SqlParameter("@Ngaysinh", dtpBirth.Value.ToString("MM-dd-yyyy")))
                    params.Add(New SqlParameter("@Chucvu", txtLopChucVu.Text))
                    params.Add(New SqlParameter("@Khoa", txtKhoa.Text))
                    params.Add(New SqlParameter("@Administrator", admin))

                    If runSqlCommand(sql, params) Then
                        MessageBox.Show("Chỉnh sửa tài khoản thành công", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        success = True
                        AccountManagement.loadData()
                    Else
                        MessageBox.Show("Chỉnh sửa tài khoản thất bại", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Không tìm thấy mã giảng viên!", "Exem Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            log(userName, "Chỉnh sửa tài khoản", If(success, "Thành công", "Thất bại"), "Chỉnh sửa tài khoản giảng viên")

        Else
            If txtPass.Text <> "" Then
                sql = "UPDATE Sinhvien SET Passsv = @Passsv,image = @image, HoTen = @HoTen, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Lop = @Lop, Khoa = @Khoa, salt = @Salt " &
                "WHERE Masv = @Masv"

                Dim salt = GenerateSalt(15)
                Dim pass As String = HashPasswordWithSalt(txtPass.Text, salt)

                If checkExists("Masv", "Sinhvien", userName) Then
                    params.Add(New SqlParameter("@Masv", userName))
                    params.Add(New SqlParameter("@Passsv", pass))
                    params.Add(New SqlParameter("@image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value)))
                    params.Add(New SqlParameter("@HoTen", txtName.Text))
                    params.Add(New SqlParameter("@Gioitinh", cbbGender.SelectedItem.ToString()))
                    params.Add(New SqlParameter("@Ngaysinh", dtpBirth.Value.ToString("MM-dd-yyyy")))
                    params.Add(New SqlParameter("@Lop", txtLopChucVu.Text))
                    params.Add(New SqlParameter("@Khoa", txtKhoa.Text))
                    params.Add(New SqlParameter("@Salt", salt))

                    If runSqlCommand(sql, params) Then
                        MessageBox.Show("Chỉnh sửa tài khoản thành công", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        success = True
                        AccountManagement.loadData()
                    Else
                        MessageBox.Show("Chỉnh sửa tài khoản thất bại", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Không tìm thấy mã sinh viên!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                sql = "UPDATE Sinhvien SET image = @image, HoTen = @HoTen, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Lop = @Lop, Khoa = @Khoa " &
                "WHERE Masv = @Masv"

                If checkExists("Masv", "Sinhvien", userName) Then
                    params.Add(New SqlParameter("@Masv", userName))
                    params.Add(New SqlParameter("@image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value)))
                    params.Add(New SqlParameter("@HoTen", txtName.Text))
                    params.Add(New SqlParameter("@Gioitinh", cbbGender.SelectedItem.ToString()))
                    params.Add(New SqlParameter("@Ngaysinh", dtpBirth.Value.ToString("MM-dd-yyyy")))
                    params.Add(New SqlParameter("@Lop", txtLopChucVu.Text))
                    params.Add(New SqlParameter("@Khoa", txtKhoa.Text))

                    If runSqlCommand(sql, params) Then
                        MessageBox.Show("Chỉnh sửa tài khoản thành công", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        success = True
                        AccountManagement.loadData()
                    Else
                        MessageBox.Show("Chỉnh sửa tài khoản thất bại", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Không tìm thấy mã sinh viên!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            log(userName, "Chỉnh sửa tài khoản", If(success, "Thành công", "Thất bại"), "Chỉnh sửa tài khoản sinh viên")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Xác nhận xoá thông tin?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.No Then
            Return
        End If
        Dim sql As String
        Dim success = False

        If accountType = 0 Then
            sql = "DELETE FROM Giangvien WHERE Magv = @Magv"

            If checkExists("Magv", "Giangvien", userName) Then
                Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@Magv", userName)
            }

                If runSqlCommand(sql, params) Then
                    MessageBox.Show("Xóa tài khoản thành công", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    success = True
                    AccountManagement.loadData()
                Else
                    MessageBox.Show("Xóa tài khoản thất bại", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Không tìm thấy mã giảng viên!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            log(userName, "Xóa tài khoản", If(success, "Thành công", "Thất bại"), "Xóa tài khoản giảng viên")
            If success Then
                Close()
            End If

        Else
            sql = "DELETE FROM Sinhvien WHERE Masv = @Masv"

            If checkExists("Masv", "Sinhvien", userName) Then
                Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@Masv", userName)
            }

                If runSqlCommand(sql, params) Then
                    MessageBox.Show("Xóa tài khoản thành công", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    success = True
                    AccountManagement.loadData()
                Else
                    MessageBox.Show("Xóa tài khoản thất bại", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Không tìm thấy mã sinh viên!", "Exam Adminstrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            log(userName, "Xóa tài khoản", If(success, "Thành công", "Thất bại"), "Xóa tài khoản sinh viên")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub imgAvatar_Click(sender As Object, e As EventArgs) Handles imgAvatar.Click
        imageBytes = LoadImage(imgAvatar)
    End Sub
End Class