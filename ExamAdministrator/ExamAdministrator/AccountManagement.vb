Imports System
Imports System.ComponentModel
Public Class AccountManagement
    Public accountType As Integer '0: Teacher, 1: Student
    Public fullName As String
    Public userName As String
    Dim logout = False

    Public Sub loadData()
        If accountType = 0 Then
            assignData(dgAccount, "SELECT Magv, Hotengv, Gioitinh, Ngaysinh, Chucvu, MaKhoa, Administrator FROM Giangvien", Nothing)
            lblFilter.Text = "Lọc tài khoản: Giảng viên"
        Else
            assignData(dgAccount, "SELECT Masv, HoTen, Gioitinh, Ngaysinh, Lop, MaKhoa FROM Sinhvien", Nothing)
            lblFilter.Text = "Lọc tài khoản: Sinh viên"
        End If
    End Sub

    Private Sub AccountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountType = 0
        btnMe.Text = fullName
        loadData()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        accountType = 1
        loadData()
    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        accountType = 0
        loadData()
    End Sub

    Private Sub dgAccount_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgAccount.CellMouseDoubleClick
        ' Lấy số dòng được nhấn
        Dim rowIndex As Integer = e.RowIndex
        ' Lấy số cột được nhấn
        Dim columnIndex As Integer = e.ColumnIndex
        ' Kiểm tra xem dòng được nhấn có hợp lệ không
        If rowIndex >= 0 AndAlso columnIndex >= 0 Then
            ' Lấy dữ liệu của hàng được nhấn
            Dim selectedRow As DataGridViewRow = dgAccount.Rows(rowIndex)

            If accountType = 0 Then
                If selectedRow.Cells("Magv").Value.ToString() = "" Then
                    Return
                End If
                EditAccount.accountType = accountType
                EditAccount.activeUserName = userName
                EditAccount.userName = selectedRow.Cells("Magv").Value.ToString()
                EditAccount.fullName = selectedRow.Cells("Hotengv").Value.ToString()
                EditAccount.gender = selectedRow.Cells("Gioitinh").Value.ToString()
                EditAccount.dtpBirth.Value = DateTime.Parse(selectedRow.Cells("Ngaysinh").Value.ToString())
                EditAccount.lopChucVu = selectedRow.Cells("Chucvu").Value.ToString()
                EditAccount.khoa = selectedRow.Cells("MaKhoa").Value.ToString()
                EditAccount.administrator = Convert.ToBoolean(selectedRow.Cells("Administrator").Value)
            Else
                If selectedRow.Cells("Masv").Value.ToString() = "" Then
                    Return
                End If
                EditAccount.accountType = accountType
                EditAccount.activeUserName = userName
                EditAccount.userName = selectedRow.Cells("Masv").Value.ToString()
                EditAccount.fullName = selectedRow.Cells("Hoten").Value.ToString()
                EditAccount.gender = selectedRow.Cells("Gioitinh").Value.ToString()
                EditAccount.dtpBirth.Value = DateTime.Parse(selectedRow.Cells("Ngaysinh").Value.ToString())
                EditAccount.lopChucVu = selectedRow.Cells("Lop").Value.ToString()
                EditAccount.khoa = selectedRow.Cells("MaKhoa").Value.ToString()
            End If
            EditAccount.Show()
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        logout = True
        Close()
    End Sub

    Private Sub btnCreateTeacher_Click(sender As Object, e As EventArgs) Handles btnCreateTeacher.Click
        CreateAccount.accountType = 0
        CreateAccount.userName = userName
        CreateAccount.Show()
    End Sub

    Private Sub btnCreateStudent_Click(sender As Object, e As EventArgs) Handles btnCreateStudent.Click
        CreateAccount.accountType = 1
        CreateAccount.userName = userName
        CreateAccount.Show()
    End Sub

    Private Sub AccountManagement_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        EditAccount.Close()
        CreateAccount.Close()
        If Not logout Then
            Dashboard.Show()
        Else
            Dashboard.Close()
        End If
    End Sub

    Private Sub btnMyAcc_Click(sender As Object, e As EventArgs) Handles btnMyAcc.Click
        Dim result As DialogResult = MessageBox.Show("Chuyển sang tài khoản của bạn, các tiến trình bạn thực hiện tại đây sẽ bị loại bỏ. Xác nhận?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dashboard.openInfoAccount()
            CreateAccount.Close()
            Close()
        End If
    End Sub
End Class