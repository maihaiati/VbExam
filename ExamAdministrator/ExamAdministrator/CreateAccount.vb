Imports System
Imports System.Data.SqlClient
Public Class CreateAccount
	Public accountType As Integer '0: Teacher, 1: Student
	Public userName As String
	Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If accountType = 0 Then
			lblUser.Text = "Mã giảng viên"
			lblLopChucVu.Text = "Chức vụ"
		Else
			lblUser.Text = "Mã sinh viên"
			lblLopChucVu.Text = "Lớp"
			cbAdmin.Enabled = False
		End If
		cbbGender.Items.Add("Nam")
		cbbGender.Items.Add("Nữ")
        cbbGender.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        Dim sql As String
        Dim success As Boolean
        success = False

        If accountType = 0 Then
            Dim admin As Integer
            admin = If(cbAdmin.Checked, 1, 0)

            sql = "INSERT INTO Giangvien (Magv, Passgv, Hotengv, Gioitinh, Ngaysinh, Chucvu, Khoa, Administrator) " &
              "VALUES (@Magv, @Passgv, @Hotengv, @Gioitinh, @Ngaysinh, @Chucvu, @Khoa, @Administrator)"

            If Not checkExists("Magv", "Giangvien", txtUser.Text) Then
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
                    MsgBox("Tạo tài khoản thành công")
                    success = True
                    AccountManagement.loadData()
                Else
                    MsgBox("Tạo tài khoản thất bại")
                End If
            Else
                MsgBox("Không được trùng mã giảng viên!")
            End If

            log(userName, "Tạo tài khoản", If(success, "Thành công", "Thất bại"), "Tạo tài khoản giảng viên")

        Else
            sql = "INSERT INTO Sinhvien (Masv, Passsv, HoTen, Gioitinh, Ngaysinh, Lop, Khoa) " &
              "VALUES (@Masv, @Passsv, @HoTen, @Gioitinh, @Ngaysinh, @Lop, @Khoa)"

            If Not checkExists("Masv", "Sinhvien", txtUser.Text) Then
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
                    MsgBox("Tạo tài khoản thành công")
                    success = True
                    AccountManagement.loadData()
                Else
                    MsgBox("Tạo tài khoản thất bại")
                End If
            Else
                MsgBox("Không được trùng mã sinh viên!")
            End If

            log(userName, "Tạo tài khoản", If(success, "Thành công", "Thất bại"), "Tạo tài khoản sinh viên")
        End If
    End Sub
End Class