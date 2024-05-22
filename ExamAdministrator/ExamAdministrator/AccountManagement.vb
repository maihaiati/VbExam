Imports System
Imports System.ComponentModel
Public Class AccountManagement
	Public accountType As Integer '0: Teacher, 1: Student
	Public fullName As String
	Public userName As String
	Dim logout = False

	Public Sub loadData()
		If accountType = 1 Then
			assignData(dgAccount, "SELECT Masv, HoTen, Gioitinh, Ngaysinh, Lop, Khoa FROM Sinhvien", Nothing)
			lblFilter.Text = "Lọc tài khoản: Sinh viên"
		Else
			assignData(dgAccount, "SELECT Magv, Hotengv, Gioitinh, Ngaysinh, Chucvu, Khoa, Administrator FROM Giangvien", Nothing)
			lblFilter.Text = "Lọc tài khoản: Giảng viên"
		End If
	End Sub

	Private Sub AccountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		accountType = 1
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

        ' Hiển thị thông tin dòng và cột
        MessageBox.Show($"Dòng: {rowIndex}, Cột: {columnIndex}")
		' Kiểm tra xem dòng được nhấn có hợp lệ không
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			' Lấy dữ liệu của hàng được nhấn
			Dim selectedRow As DataGridViewRow = dgAccount.Rows(e.RowIndex)

			' Tạo instance của form chỉnh sửa
			Dim editForm As New EditAccount()

			' Truyền dữ liệu từ DataGridView sang form chỉnh sửa
			editForm.txtUser.Text = selectedRow.Cells("Magv").Value.ToString()
			editForm.txtPass.Text = selectedRow.Cells("Passgv").Value.ToString()
			editForm.txtName.Text = selectedRow.Cells("Hotengv").Value.ToString()
			editForm.cbbGender.SelectedItem = selectedRow.Cells("Gioitinh").Value.ToString()
			editForm.dtpBirth.Value = DateTime.Parse(selectedRow.Cells("Ngaysinh").Value.ToString())
			editForm.txtLopChucVu.Text = selectedRow.Cells("Chucvu").Value.ToString()
			editForm.txtKhoa.Text = selectedRow.Cells("Khoa").Value.ToString()
			editForm.cbAdmin.Checked = Convert.ToBoolean(selectedRow.Cells("Administrator").Value)

			' Hiển thị form chỉnh sửa
			If editForm.ShowDialog() = DialogResult.OK Then
				' Tải lại dữ liệu sau khi chỉnh sửa
				loadData()
			End If
		End If
	End Sub


	Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
		Dashboard.Show()
		Close()
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		log(userName, "Đăng xuất", "Thành công", Nothing)
		LoginForm.Show()
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

	Private Sub AccountManagement_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If Not logout Then
			Dashboard.Show()
		Else
			Dashboard.Close()
		End If
	End Sub
End Class