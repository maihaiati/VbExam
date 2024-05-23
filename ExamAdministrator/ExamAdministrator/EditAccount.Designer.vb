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
        txtKhoa = New TextBox()
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
        imgavatar = New PictureBox()
        CType(imgavatar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(319, 196)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 20)
        Label7.TabIndex = 37
        Label7.Text = "Họ và tên"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(503, 192)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(257, 27)
        txtName.TabIndex = 36
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(323, 435)
        btnUpdate.Margin = New Padding(3, 4, 3, 4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(119, 48)
        btnUpdate.TabIndex = 35
        btnUpdate.Text = "Cập nhật"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(641, 435)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(119, 48)
        btnExit.TabIndex = 34
        btnExit.Text = "Thoát"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' cbAdmin
        ' 
        cbAdmin.AutoSize = True
        cbAdmin.Location = New Point(503, 392)
        cbAdmin.Margin = New Padding(3, 4, 3, 4)
        cbAdmin.Name = "cbAdmin"
        cbAdmin.Size = New Size(18, 17)
        cbAdmin.TabIndex = 33
        cbAdmin.UseVisualStyleBackColor = True
        ' 
        ' txtKhoa
        ' 
        txtKhoa.Location = New Point(503, 347)
        txtKhoa.Margin = New Padding(3, 4, 3, 4)
        txtKhoa.Name = "txtKhoa"
        txtKhoa.Size = New Size(257, 27)
        txtKhoa.TabIndex = 32
        ' 
        ' txtLopChucVu
        ' 
        txtLopChucVu.Location = New Point(503, 308)
        txtLopChucVu.Margin = New Padding(3, 4, 3, 4)
        txtLopChucVu.Name = "txtLopChucVu"
        txtLopChucVu.Size = New Size(257, 27)
        txtLopChucVu.TabIndex = 31
        ' 
        ' dtpBirth
        ' 
        dtpBirth.CustomFormat = ""
        dtpBirth.Format = DateTimePickerFormat.Short
        dtpBirth.Location = New Point(503, 269)
        dtpBirth.Margin = New Padding(3, 4, 3, 4)
        dtpBirth.Name = "dtpBirth"
        dtpBirth.Size = New Size(257, 27)
        dtpBirth.TabIndex = 30
        ' 
        ' cbbGender
        ' 
        cbbGender.FormattingEnabled = True
        cbbGender.Location = New Point(503, 231)
        cbbGender.Margin = New Padding(3, 4, 3, 4)
        cbbGender.Name = "cbbGender"
        cbbGender.Size = New Size(257, 28)
        cbbGender.TabIndex = 29
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(503, 151)
        txtPass.Margin = New Padding(3, 4, 3, 4)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(257, 27)
        txtPass.TabIndex = 28
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(503, 108)
        txtUser.Margin = New Padding(3, 4, 3, 4)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(257, 27)
        txtUser.TabIndex = 27
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label6.Location = New Point(256, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(346, 46)
        Label6.TabIndex = 26
        Label6.Text = "Chỉnh Sửa Tài Khoản"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(319, 391)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 20)
        Label5.TabIndex = 25
        Label5.Text = "Quyền quản trị viên"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(319, 351)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 24
        Label4.Text = "Khoa"
        ' 
        ' lblLopChucVu
        ' 
        lblLopChucVu.AutoSize = True
        lblLopChucVu.Location = New Point(319, 312)
        lblLopChucVu.Name = "lblLopChucVu"
        lblLopChucVu.Size = New Size(53, 20)
        lblLopChucVu.TabIndex = 23
        lblLopChucVu.Text = "Label4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(319, 273)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 22
        Label3.Text = "Ngày sinh"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(319, 235)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 21
        Label2.Text = "Giới tính"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(319, 155)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 20
        Label1.Text = "Mật khẩu"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Location = New Point(319, 112)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(53, 20)
        lblUser.TabIndex = 19
        lblUser.Text = "Label1"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(483, 435)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(119, 48)
        btnDelete.TabIndex = 38
        btnDelete.Text = "Xoá"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' imgavatar
        ' 
        imgavatar.Location = New Point(20, 90)
        imgavatar.Name = "imgavatar"
        imgavatar.Size = New Size(282, 393)
        imgavatar.TabIndex = 39
        imgavatar.TabStop = False
        ' 
        ' EditAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(808, 512)
        Controls.Add(imgavatar)
        Controls.Add(btnDelete)
        Controls.Add(Label7)
        Controls.Add(txtName)
        Controls.Add(btnUpdate)
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
        Name = "EditAccount"
        Text = "Exam Administrator - Edit Account"
        CType(imgavatar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents cbAdmin As CheckBox
	Friend WithEvents txtKhoa As TextBox
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
    Friend WithEvents imgavatar As PictureBox
End Class
