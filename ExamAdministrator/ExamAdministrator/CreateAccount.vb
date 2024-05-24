Imports System
Imports System.Data.SqlClient
Imports System.IO
Public Class CreateAccount
    Dim imageBytes As Byte() = Nothing
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
    ' Hàm chuyển đổi ảnh thành mảng byte
    Function ImageToByteArray(ByVal image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, image.RawFormat)
            Return ms.ToArray()
        End Using
    End Function

    ' Hàm tải ảnh từ hộp thoại tệp và hiển thị trong PictureBox
    Function LoadImage() As Byte()
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim img As Image = Image.FromFile(ofd.FileName)
                imgAcc.Image = img
                Return ImageToByteArray(img)
            End If
        End Using
        Return Nothing
    End Function

    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        Dim sql As String
        Dim success As Boolean
        success = False

        If accountType = 0 Then
            Dim admin As Integer
            admin = If(cbAdmin.Checked, 1, 0)
            sql = "INSERT INTO Giangvien (Magv, Passgv,image, Hotengv, Gioitinh, Ngaysinh, Chucvu, Khoa, Administrator, ) " &
          "VALUES (@Magv, @Passgv,@image, @Hotengv, @Gioitinh, @Ngaysinh, @Chucvu, @Khoa, @Administrator )"

                If Not checkExists("Magv", "Giangvien", txtUser.Text) Then
                    Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@Magv", txtUser.Text),
                New SqlParameter("@Passgv", txtPass.Text),
                New SqlParameter("@image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value)),
                New SqlParameter("@Hotengv", txtName.Text),
                New SqlParameter("@Gioitinh", cbbGender.SelectedItem.ToString()),
                New SqlParameter("@Ngaysinh", dtpBirth.Value.ToString("MM-dd-yyyy")),
                New SqlParameter("@Chucvu", txtLopChucVu.Text),
                New SqlParameter("@Khoa", txtKhoa.Text),
                New SqlParameter("@Administrator", admin)
            }

                    If runSqlCommand(sql, params) Then
                    MessageBox.Show("Tạo tài khoản thành công", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    success = True
                    AccountManagement.loadData()
                Else
                    MessageBox.Show("Tạo tài khoản thất bại", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Không được trùng mã giảng viên!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            log(userName, "Tạo tài khoản", If(success, "Thành công", "Thất bại"), "Tạo tài khoản giảng viên")

        Else
            sql = "INSERT INTO Sinhvien (Masv, Passsv,image, HoTen, Gioitinh, Ngaysinh, Lop, Khoa) " &
          "VALUES (@Masv, @Passsv,@image, @HoTen, @Gioitinh, @Ngaysinh, @Lop, @Khoa)"

            If Not checkExists("Masv", "Sinhvien", txtUser.Text) Then
                Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@Masv", txtUser.Text),
            New SqlParameter("@Passsv", txtPass.Text),
            New SqlParameter("@image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value)),
            New SqlParameter("@HoTen", txtName.Text),
            New SqlParameter("@Gioitinh", cbbGender.SelectedItem.ToString()),
            New SqlParameter("@Ngaysinh", dtpBirth.Value.ToString("MM-dd-yyyy")),
            New SqlParameter("@Lop", txtLopChucVu.Text),
            New SqlParameter("@Khoa", txtKhoa.Text)
        }

                If runSqlCommand(sql, params) Then
                    MessageBox.Show("Tạo tài khoản thành công", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    success = True
                    AccountManagement.loadData()
                Else
                    MessageBox.Show("Tạo tài khoản thất bại", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Không được trùng mã sinh viên!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            log(userName, "Tạo tài khoản", If(success, "Thành công", "Thất bại"), "Tạo tài khoản sinh viên")
        End If
    End Sub

    Private Sub imgAcc_Click(sender As Object, e As EventArgs) Handles imgAcc.Click
        imgAcc.SizeMode = PictureBoxSizeMode.Zoom
        imageBytes = LoadImage()
    End Sub
End Class