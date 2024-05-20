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
End Class