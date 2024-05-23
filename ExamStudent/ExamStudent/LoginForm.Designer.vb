<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnExit = New Button()
        btnLogin = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkOrange
        Label1.Location = New Point(451, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 46)
        Label1.TabIndex = 0
        Label1.Text = "Exam Student"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(389, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 35)
        Label2.TabIndex = 1
        Label2.Text = "Tên đăng nhập"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(389, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 35)
        Label3.TabIndex = 2
        Label3.Text = "Mật khẩu"
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Segoe UI", 10F)
        txtUser.Location = New Point(404, 180)
        txtUser.Margin = New Padding(3, 4, 3, 4)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(344, 30)
        txtUser.TabIndex = 3
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Segoe UI", 10F)
        txtPass.Location = New Point(404, 265)
        txtPass.Margin = New Padding(3, 4, 3, 4)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(344, 30)
        txtPass.TabIndex = 4
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(615, 347)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(133, 48)
        btnExit.TabIndex = 5
        btnExit.Text = "Thoát"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(404, 347)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(133, 48)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Đăng nhập"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(357, 424)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnExit
        ClientSize = New Size(790, 421)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogin)
        Controls.Add(btnExit)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Exam Student - Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtUser As TextBox
	Friend WithEvents txtPass As TextBox
	Friend WithEvents btnExit As Button
	Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
