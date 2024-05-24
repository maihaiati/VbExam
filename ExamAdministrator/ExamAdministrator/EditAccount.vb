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
    Dim machineName As String = Environment.MachineName

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
        imgAvatar.SizeMode = PictureBoxSizeMode.Zoom
        imageBytes = GetImageFromDatabase(userName, accountType = 0)
        If imageBytes IsNot Nothing Then
            imgAvatar.Image = ByteArrayToImage(imageBytes)
        End If
    End Sub

    ' Hàm chuyển đổi từ mảng byte sang đối tượng Image
    Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
        Using ms As New MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    ' Hàm chuyển đổi từ đối tượng Image sang mảng byte
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
                imgAvatar.Image = img
                Return ImageToByteArray(img)
            End If
        End Using
        Return Nothing
    End Function

    ' Hàm lấy dữ liệu ảnh từ cơ sở dữ liệu
    Function GetImageFromDatabase(ByVal userId As String, ByVal isTeacher As Boolean) As Byte()
        Dim imageData As Byte() = Nothing
        Dim sql As String

        If isTeacher Then
            sql = "SELECT image FROM Giangvien WHERE Magv = @Magv"
        Else
            sql = "SELECT image FROM Sinhvien WHERE Masv = @Masv"
        End If

        Using conn As New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue(If(isTeacher, "@Magv", "@Masv"), userId)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    If Not IsDBNull(reader("image")) Then
                        imageData = CType(reader("image"), Byte())
                    End If
                End If
            End Using
        End Using
        Return imageData
    End Function

    ' Hàm cập nhật ảnh trong cơ sở dữ liệu
    Function UpdateImageInDatabase(ByVal userId As String, ByVal imageBytes As Byte(), ByVal isTeacher As Boolean) As Boolean
        Dim sql As String

        If isTeacher Then
            sql = "UPDATE Giangvien SET image = @Image WHERE Magv = @Magv"
        Else
            sql = "UPDATE Sinhvien SET image = @Image WHERE Masv = @Masv"
        End If

        Using conn As New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue(If(isTeacher, "@Magv", "@Masv"), userId)
                cmd.Parameters.AddWithValue("@image", imageBytes)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim sql As String
        Dim success = False

        If txtName.Text = "" Or cbbGender.SelectedItem = "" Or txtLopChucVu.Text = "" Or txtKhoa.Text = "" Then
            MessageBox.Show("Không được để trống thông tin trừ mật khẩu!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If accountType = 0 Then
            Dim admin As Integer
            admin = If(cbAdmin.Checked, 1, 0)
            Dim params As New List(Of SqlParameter)

            If txtPass.Text <> "" Then
                sql = "UPDATE Giangvien SET Passgv = @Passgv, image = @image , Hotengv = @Hotengv, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Chucvu = @Chucvu, Khoa = @Khoa, Administrator = @Administrator" &
              "WHERE Magv = @Magv"

                If checkExists("Magv", "Giangvien", userName) Then
                    params.Add(New SqlParameter("@Magv", userName))
                    params.Add(New SqlParameter("@Passgv", txtPass.Text))
                    params.Add(New SqlParameter("@image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value)))
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
                    MsgBox("Không tìm thấy mã giảng viên!")
                End If
            Else
                sql = "UPDATE Giangvien SET  image = @image,Hotengv = @Hotengv, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Chucvu = @Chucvu, Khoa = @Khoa, Administrator = @Administrator " &
              "WHERE Magv = @Magv"

                If checkExists("Magv", "Giangvien", userName) Then
                    params.Add(New SqlParameter("@image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value)))
                    params.Add(New SqlParameter("@Magv", userName))
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
            sql = "UPDATE Sinhvien SET Passsv = @Passsv,image = @image, HoTen = @HoTen, Gioitinh = @Gioitinh, Ngaysinh = @Ngaysinh, Lop = @Lop, Khoa = @Khoa " &
          "WHERE Masv = @Masv"

            If checkExists("Masv", "Sinhvien", userName) Then
                Dim params As New List(Of SqlParameter) From {
        New SqlParameter("@Masv", userName),
        New SqlParameter("@Passsv", txtPass.Text),
        New SqlParameter("@image", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value)),
        New SqlParameter("@HoTen", txtName.Text),
        New SqlParameter("@Gioitinh", cbbGender.SelectedItem.ToString()),
        New SqlParameter("@Ngaysinh", dtpBirth.Value.ToString("MM-dd-yyyy")),
        New SqlParameter("@Lop", txtLopChucVu.Text),
        New SqlParameter("@Khoa", txtKhoa.Text)
    }

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
        imageBytes = LoadImage()
        If imageBytes IsNot Nothing Then
            If UpdateImageInDatabase(userName, imageBytes, accountType = 0) Then
                MessageBox.Show("Cập nhật ảnh thành công", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật ảnh thất bại", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class