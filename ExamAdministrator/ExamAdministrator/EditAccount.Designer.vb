<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAccount
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
		Label7 = New Label()
		txtName = New TextBox()
		btnUpdate = New Button()
		btnExit = New Button()
		cbAdmin = New CheckBox()
		txtLopChucVu = New TextBox()
		dtpBirth = New DateTimePicker()
		cbbGender = New ComboBox()
		txtPass = New TextBox()
		txtUser = New TextBox()
		Label6 = New Label()
		Label5 = New Label()
		Label4 = New Label()
		lblLopChucVu = New Label()
		Label3 = New Label()
		Label2 = New Label()
		Label1 = New Label()
		lblUser = New Label()
		btnDelete = New Button()
		imgAvatar = New PictureBox()
		cbbKhoa = New ComboBox()
		CType(imgAvatar, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Location = New Point(279, 147)
		Label7.Name = "Label7"
		Label7.Size = New Size(58, 15)
		Label7.TabIndex = 37
		Label7.Text = "Họ và tên"
		' 
		' txtName
		' 
		txtName.Location = New Point(440, 144)
		txtName.Name = "txtName"
		txtName.Size = New Size(225, 23)
		txtName.TabIndex = 36
		' 
		' btnUpdate
		' 
		btnUpdate.Location = New Point(283, 326)
		btnUpdate.Name = "btnUpdate"
		btnUpdate.Size = New Size(104, 36)
		btnUpdate.TabIndex = 35
		btnUpdate.Text = "Cập nhật"
		btnUpdate.UseVisualStyleBackColor = True
		' 
		' btnExit
		' 
		btnExit.Location = New Point(561, 326)
		btnExit.Name = "btnExit"
		btnExit.Size = New Size(104, 36)
		btnExit.TabIndex = 34
		btnExit.Text = "Thoát"
		btnExit.UseVisualStyleBackColor = True
		' 
		' cbAdmin
		' 
		cbAdmin.AutoSize = True
		cbAdmin.Location = New Point(440, 294)
		cbAdmin.Name = "cbAdmin"
		cbAdmin.Size = New Size(15, 14)
		cbAdmin.TabIndex = 33
		cbAdmin.UseVisualStyleBackColor = True
		' 
		' txtLopChucVu
		' 
		txtLopChucVu.Location = New Point(440, 231)
		txtLopChucVu.Name = "txtLopChucVu"
		txtLopChucVu.Size = New Size(225, 23)
		txtLopChucVu.TabIndex = 31
		' 
		' dtpBirth
		' 
		dtpBirth.CustomFormat = ""
		dtpBirth.Format = DateTimePickerFormat.Short
		dtpBirth.Location = New Point(440, 202)
		dtpBirth.Name = "dtpBirth"
		dtpBirth.Size = New Size(225, 23)
		dtpBirth.TabIndex = 30
		' 
		' cbbGender
		' 
		cbbGender.FormattingEnabled = True
		cbbGender.Location = New Point(440, 173)
		cbbGender.Name = "cbbGender"
		cbbGender.Size = New Size(225, 23)
		cbbGender.TabIndex = 29
		' 
		' txtPass
		' 
		txtPass.Location = New Point(440, 113)
		txtPass.Name = "txtPass"
		txtPass.Size = New Size(225, 23)
		txtPass.TabIndex = 28
		' 
		' txtUser
		' 
		txtUser.Location = New Point(440, 84)
		txtUser.Name = "txtUser"
		txtUser.ReadOnly = True
		txtUser.Size = New Size(225, 23)
		txtUser.TabIndex = 27
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		Label6.Location = New Point(205, 9)
		Label6.Name = "Label6"
		Label6.Size = New Size(278, 37)
		Label6.TabIndex = 26
		Label6.Text = "Chỉnh Sửa Tài Khoản"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(279, 293)
		Label5.Name = "Label5"
		Label5.Size = New Size(111, 15)
		Label5.TabIndex = 25
		Label5.Text = "Quyền quản trị viên"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(279, 263)
		Label4.Name = "Label4"
		Label4.Size = New Size(53, 15)
		Label4.TabIndex = 24
		Label4.Text = "Mã khoa"
		' 
		' lblLopChucVu
		' 
		lblLopChucVu.AutoSize = True
		lblLopChucVu.Location = New Point(279, 234)
		lblLopChucVu.Name = "lblLopChucVu"
		lblLopChucVu.Size = New Size(41, 15)
		lblLopChucVu.TabIndex = 23
		lblLopChucVu.Text = "Label4"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(279, 205)
		Label3.Name = "Label3"
		Label3.Size = New Size(60, 15)
		Label3.TabIndex = 22
		Label3.Text = "Ngày sinh"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(279, 176)
		Label2.Name = "Label2"
		Label2.Size = New Size(52, 15)
		Label2.TabIndex = 21
		Label2.Text = "Giới tính"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(279, 116)
		Label1.Name = "Label1"
		Label1.Size = New Size(57, 15)
		Label1.TabIndex = 20
		Label1.Text = "Mật khẩu"
		' 
		' lblUser
		' 
		lblUser.AutoSize = True
		lblUser.Location = New Point(279, 84)
		lblUser.Name = "lblUser"
		lblUser.Size = New Size(41, 15)
		lblUser.TabIndex = 19
		lblUser.Text = "Label1"
		' 
		' btnDelete
		' 
		btnDelete.Location = New Point(423, 326)
		btnDelete.Name = "btnDelete"
		btnDelete.Size = New Size(104, 36)
		btnDelete.TabIndex = 38
		btnDelete.Text = "Xoá"
		btnDelete.UseVisualStyleBackColor = True
		' 
		' imgAvatar
		' 
		imgAvatar.BackColor = SystemColors.AppWorkspace
		imgAvatar.Location = New Point(18, 68)
		imgAvatar.Margin = New Padding(3, 2, 3, 2)
		imgAvatar.Name = "imgAvatar"
		imgAvatar.Size = New Size(247, 295)
		imgAvatar.TabIndex = 39
		imgAvatar.TabStop = False
		' 
		' cbbKhoa
		' 
		cbbKhoa.FormattingEnabled = True
		cbbKhoa.Location = New Point(440, 260)
		cbbKhoa.Name = "cbbKhoa"
		cbbKhoa.Size = New Size(225, 23)
		cbbKhoa.TabIndex = 40
		' 
		' EditAccount
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(686, 384)
		Controls.Add(cbbKhoa)
		Controls.Add(imgAvatar)
		Controls.Add(btnDelete)
		Controls.Add(Label7)
		Controls.Add(txtName)
		Controls.Add(btnUpdate)
		Controls.Add(btnExit)
		Controls.Add(cbAdmin)
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
		Name = "EditAccount"
		Text = "Exam Administrator - Edit Account"
		CType(imgAvatar, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label7 As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents cbAdmin As CheckBox
	Friend WithEvents txtLopChucVu As TextBox
	Friend WithEvents dtpBirth As DateTimePicker
	Friend WithEvents cbbGender As ComboBox
	Friend WithEvents txtPass As TextBox
	Friend WithEvents txtUser As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents lblLopChucVu As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents lblUser As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents imgAvatar As PictureBox
	Friend WithEvents cbbKhoa As ComboBox
End Class
