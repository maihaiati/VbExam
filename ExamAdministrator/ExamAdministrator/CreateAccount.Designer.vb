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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccount))
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
        imgAcc = New PictureBox()
        CType(imgAcc, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUser
        ' 
        resources.ApplyResources(lblUser, "lblUser")
        lblUser.Name = "lblUser"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.Name = "Label3"
        ' 
        ' lblLopChucVu
        ' 
        resources.ApplyResources(lblLopChucVu, "lblLopChucVu")
        lblLopChucVu.Name = "lblLopChucVu"
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.Name = "Label4"
        ' 
        ' Label6
        ' 
        resources.ApplyResources(Label6, "Label6")
        Label6.Name = "Label6"
        ' 
        ' txtUser
        ' 
        resources.ApplyResources(txtUser, "txtUser")
        txtUser.Name = "txtUser"
        ' 
        ' txtPass
        ' 
        resources.ApplyResources(txtPass, "txtPass")
        txtPass.Name = "txtPass"
        ' 
        ' cbbGender
        ' 
        resources.ApplyResources(cbbGender, "cbbGender")
        cbbGender.FormattingEnabled = True
        cbbGender.Name = "cbbGender"
        ' 
        ' dtpBirth
        ' 
        resources.ApplyResources(dtpBirth, "dtpBirth")
        dtpBirth.Format = DateTimePickerFormat.Short
        dtpBirth.Name = "dtpBirth"
        ' 
        ' txtLopChucVu
        ' 
        resources.ApplyResources(txtLopChucVu, "txtLopChucVu")
        txtLopChucVu.Name = "txtLopChucVu"
        ' 
        ' txtKhoa
        ' 
        resources.ApplyResources(txtKhoa, "txtKhoa")
        txtKhoa.Name = "txtKhoa"
        ' 
        ' cbAdmin
        ' 
        resources.ApplyResources(cbAdmin, "cbAdmin")
        cbAdmin.Name = "cbAdmin"
        cbAdmin.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        resources.ApplyResources(Label5, "Label5")
        Label5.Name = "Label5"
        ' 
        ' btnExit
        ' 
        resources.ApplyResources(btnExit, "btnExit")
        btnExit.Name = "btnExit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnCreateAcc
        ' 
        resources.ApplyResources(btnCreateAcc, "btnCreateAcc")
        btnCreateAcc.Name = "btnCreateAcc"
        btnCreateAcc.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        resources.ApplyResources(txtName, "txtName")
        txtName.Name = "txtName"
        ' 
        ' Label7
        ' 
        resources.ApplyResources(Label7, "Label7")
        Label7.Name = "Label7"
        ' 
        ' imgAcc
        ' 
<<<<<<< HEAD
        resources.ApplyResources(imgacc, "imgacc")
        imgacc.Name = "imgacc"
        imgacc.TabStop = False
=======
        imgAcc.Location = New Point(55, 81)
        imgAcc.Name = "imgAcc"
        imgAcc.Size = New Size(291, 386)
        imgAcc.TabIndex = 19
        imgAcc.TabStop = False
>>>>>>> 5c600edff47f64d22c4778f2bca47c82416e856d
        ' 
        ' CreateAccount
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
<<<<<<< HEAD
        Controls.Add(imgacc)
=======
        ClientSize = New Size(918, 493)
        Controls.Add(imgAcc)
>>>>>>> 5c600edff47f64d22c4778f2bca47c82416e856d
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
<<<<<<< HEAD
        CType(imgacc, ComponentModel.ISupportInitialize).EndInit()
=======
        Text = "Exam Administrator - Create Account"
        CType(imgAcc, ComponentModel.ISupportInitialize).EndInit()
>>>>>>> 5c600edff47f64d22c4778f2bca47c82416e856d
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
    Friend WithEvents imgAcc As PictureBox
End Class
