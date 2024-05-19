<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		lblUser = New Label()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		lblLopChucVu = New Label()
		Label4 = New Label()
		Label6 = New Label()
		txtUser = New TextBox()
		txtPass = New TextBox()
		cbbGender = New ComboBox()
		dtpBirth = New DateTimePicker()
		txtLopChucVu = New TextBox()
		txtKhoa = New TextBox()
		cbAdmin = New CheckBox()
		Label5 = New Label()
		btnExit = New Button()
		btnCreateAcc = New Button()
		txtName = New TextBox()
		Label7 = New Label()
		SuspendLayout()
		' 
		' lblUser
		' 
		lblUser.AutoSize = True
		lblUser.Location = New Point(19, 63)
		lblUser.Name = "lblUser"
		lblUser.Size = New Size(41, 15)
		lblUser.TabIndex = 0
		lblUser.Text = "Label1"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(19, 95)
		Label1.Name = "Label1"
		Label1.Size = New Size(57, 15)
		Label1.TabIndex = 1
		Label1.Text = "Mật khẩu"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(19, 155)
		Label2.Name = "Label2"
		Label2.Size = New Size(52, 15)
		Label2.TabIndex = 2
		Label2.Text = "Giới tính"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(19, 184)
		Label3.Name = "Label3"
		Label3.Size = New Size(60, 15)
		Label3.TabIndex = 3
		Label3.Text = "Ngày sinh"
		' 
		' lblLopChucVu
		' 
		lblLopChucVu.AutoSize = True
		lblLopChucVu.Location = New Point(19, 213)
		lblLopChucVu.Name = "lblLopChucVu"
		lblLopChucVu.Size = New Size(41, 15)
		lblLopChucVu.TabIndex = 4
		lblLopChucVu.Text = "Label4"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(19, 242)
		Label4.Name = "Label4"
		Label4.Size = New Size(34, 15)
		Label4.TabIndex = 5
		Label4.Text = "Khoa"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		Label6.Location = New Point(110, 9)
		Label6.Name = "Label6"
		Label6.Size = New Size(198, 37)
		Label6.TabIndex = 7
		Label6.Text = "Tạo Tài Khoản"
		' 
		' txtUser
		' 
		txtUser.Location = New Point(180, 60)
		txtUser.Name = "txtUser"
		txtUser.Size = New Size(225, 23)
		txtUser.TabIndex = 8
		' 
		' txtPass
		' 
		txtPass.Location = New Point(180, 92)
		txtPass.Name = "txtPass"
		txtPass.Size = New Size(225, 23)
		txtPass.TabIndex = 9
		' 
		' cbbGender
		' 
		cbbGender.FormattingEnabled = True
		cbbGender.Location = New Point(180, 152)
		cbbGender.Name = "cbbGender"
		cbbGender.Size = New Size(225, 23)
		cbbGender.TabIndex = 10
		' 
		' dtpBirth
		' 
		dtpBirth.CustomFormat = ""
		dtpBirth.Format = DateTimePickerFormat.Short
		dtpBirth.Location = New Point(180, 181)
		dtpBirth.Name = "dtpBirth"
		dtpBirth.Size = New Size(225, 23)
		dtpBirth.TabIndex = 11
		' 
		' txtLopChucVu
		' 
		txtLopChucVu.Location = New Point(180, 210)
		txtLopChucVu.Name = "txtLopChucVu"
		txtLopChucVu.Size = New Size(225, 23)
		txtLopChucVu.TabIndex = 12
		' 
		' txtKhoa
		' 
		txtKhoa.Location = New Point(180, 239)
		txtKhoa.Name = "txtKhoa"
		txtKhoa.Size = New Size(225, 23)
		txtKhoa.TabIndex = 13
		' 
		' cbAdmin
		' 
		cbAdmin.AutoSize = True
		cbAdmin.Location = New Point(180, 273)
		cbAdmin.Name = "cbAdmin"
		cbAdmin.Size = New Size(15, 14)
		cbAdmin.TabIndex = 14
		cbAdmin.UseVisualStyleBackColor = True
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(19, 272)
		Label5.Name = "Label5"
		Label5.Size = New Size(111, 15)
		Label5.TabIndex = 6
		Label5.Text = "Quyền quản trị viên"
		' 
		' btnExit
		' 
		btnExit.Location = New Point(83, 305)
		btnExit.Name = "btnExit"
		btnExit.Size = New Size(88, 36)
		btnExit.TabIndex = 15
		btnExit.Text = "Thoát"
		btnExit.UseVisualStyleBackColor = True
		' 
		' btnCreateAcc
		' 
		btnCreateAcc.Location = New Point(246, 305)
		btnCreateAcc.Name = "btnCreateAcc"
		btnCreateAcc.Size = New Size(88, 36)
		btnCreateAcc.TabIndex = 16
		btnCreateAcc.Text = "Tạo tài khoản"
		btnCreateAcc.UseVisualStyleBackColor = True
		' 
		' txtName
		' 
		txtName.Location = New Point(180, 123)
		txtName.Name = "txtName"
		txtName.Size = New Size(225, 23)
		txtName.TabIndex = 17
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Location = New Point(19, 126)
		Label7.Name = "Label7"
		Label7.Size = New Size(58, 15)
		Label7.TabIndex = 18
		Label7.Text = "Họ và tên"
		' 
		' CreateAccount
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(417, 362)
		Controls.Add(Label7)
		Controls.Add(txtName)
		Controls.Add(btnCreateAcc)
		Controls.Add(btnExit)
		Controls.Add(cbAdmin)
		Controls.Add(txtKhoa)
		Controls.Add(txtLopChucVu)
		Controls.Add(dtpBirth)
		Controls.Add(cbbGender)
		Controls.Add(txtPass)
		Controls.Add(txtUser)
		Controls.Add(Label6)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(lblLopChucVu)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(lblUser)
		Name = "CreateAccount"
		Text = "Exam Administrator - Create Account"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents lblUser As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblLopChucVu As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtUser As TextBox
	Friend WithEvents txtPass As TextBox
	Friend WithEvents cbbGender As ComboBox
	Friend WithEvents dtpBirth As DateTimePicker
	Friend WithEvents txtLopChucVu As TextBox
	Friend WithEvents txtKhoa As TextBox
	Friend WithEvents cbAdmin As CheckBox
	Friend WithEvents Label5 As Label
	Friend WithEvents btnExit As Button
	Friend WithEvents btnCreateAcc As Button
	Friend WithEvents txtName As TextBox
	Friend WithEvents Label7 As Label
End Class
