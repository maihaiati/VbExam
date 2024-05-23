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
        imgacc = New PictureBox()
        CType(imgacc, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Location = New Point(386, 103)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(53, 20)
        lblUser.TabIndex = 0
        lblUser.Text = "Label1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(386, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 1
        Label1.Text = "Mật khẩu"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(386, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 2
        Label2.Text = "Giới tính"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(386, 264)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 3
        Label3.Text = "Ngày sinh"
        ' 
        ' lblLopChucVu
        ' 
        lblLopChucVu.AutoSize = True
        lblLopChucVu.Location = New Point(386, 303)
        lblLopChucVu.Name = "lblLopChucVu"
        lblLopChucVu.Size = New Size(53, 20)
        lblLopChucVu.TabIndex = 4
        lblLopChucVu.Text = "Label4"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(386, 342)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 5
        Label4.Text = "Khoa"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label6.Location = New Point(326, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(244, 46)
        Label6.TabIndex = 7
        Label6.Text = "Tạo Tài Khoản"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(570, 99)
        txtUser.Margin = New Padding(3, 4, 3, 4)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(257, 27)
        txtUser.TabIndex = 8
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(570, 142)
        txtPass.Margin = New Padding(3, 4, 3, 4)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(257, 27)
        txtPass.TabIndex = 9
        ' 
        ' cbbGender
        ' 
        cbbGender.FormattingEnabled = True
        cbbGender.Location = New Point(570, 222)
        cbbGender.Margin = New Padding(3, 4, 3, 4)
        cbbGender.Name = "cbbGender"
        cbbGender.Size = New Size(257, 28)
        cbbGender.TabIndex = 10
        ' 
        ' dtpBirth
        ' 
        dtpBirth.CustomFormat = ""
        dtpBirth.Format = DateTimePickerFormat.Short
        dtpBirth.Location = New Point(570, 260)
        dtpBirth.Margin = New Padding(3, 4, 3, 4)
        dtpBirth.Name = "dtpBirth"
        dtpBirth.Size = New Size(257, 27)
        dtpBirth.TabIndex = 11
        ' 
        ' txtLopChucVu
        ' 
        txtLopChucVu.Location = New Point(570, 299)
        txtLopChucVu.Margin = New Padding(3, 4, 3, 4)
        txtLopChucVu.Name = "txtLopChucVu"
        txtLopChucVu.Size = New Size(257, 27)
        txtLopChucVu.TabIndex = 12
        ' 
        ' txtKhoa
        ' 
        txtKhoa.Location = New Point(570, 338)
        txtKhoa.Margin = New Padding(3, 4, 3, 4)
        txtKhoa.Name = "txtKhoa"
        txtKhoa.Size = New Size(257, 27)
        txtKhoa.TabIndex = 13
        ' 
        ' cbAdmin
        ' 
        cbAdmin.AutoSize = True
        cbAdmin.Location = New Point(570, 383)
        cbAdmin.Margin = New Padding(3, 4, 3, 4)
        cbAdmin.Name = "cbAdmin"
        cbAdmin.Size = New Size(18, 17)
        cbAdmin.TabIndex = 14
        cbAdmin.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(386, 382)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 20)
        Label5.TabIndex = 6
        Label5.Text = "Quyền quản trị viên"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(706, 419)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(121, 48)
        btnExit.TabIndex = 15
        btnExit.Text = "Thoát"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnCreateAcc
        ' 
        btnCreateAcc.Location = New Point(434, 419)
        btnCreateAcc.Margin = New Padding(3, 4, 3, 4)
        btnCreateAcc.Name = "btnCreateAcc"
        btnCreateAcc.Size = New Size(126, 48)
        btnCreateAcc.TabIndex = 16
        btnCreateAcc.Text = "Tạo tài khoản"
        btnCreateAcc.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(570, 183)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(257, 27)
        txtName.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(386, 187)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 20)
        Label7.TabIndex = 18
        Label7.Text = "Họ và tên"
        ' 
        ' imgacc
        ' 
        imgacc.Location = New Point(55, 81)
        imgacc.Name = "imgacc"
        imgacc.Size = New Size(291, 386)
        imgacc.TabIndex = 19
        imgacc.TabStop = False
        ' 
        ' CreateAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(918, 493)
        Controls.Add(imgacc)
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
        Margin = New Padding(3, 4, 3, 4)
        Name = "CreateAccount"
        Text = "Exam Administrator - Create Account"
        CType(imgacc, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents imgacc As PictureBox
End Class
