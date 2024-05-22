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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnExit = New Button()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.Location = New Point(158, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 46)
        Label1.TabIndex = 0
        Label1.Text = "Exam Administrator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(117, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 35)
        Label2.TabIndex = 1
        Label2.Text = "Tên đăng nhập"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(117, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 35)
        Label3.TabIndex = 2
        Label3.Text = "Mật khẩu"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(117, 149)
        txtUser.Margin = New Padding(3, 4, 3, 4)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(383, 27)
        txtUser.TabIndex = 3
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(117, 249)
        txtPass.Margin = New Padding(3, 4, 3, 4)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(383, 27)
        txtPass.TabIndex = 4
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(158, 315)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(119, 59)
        btnExit.TabIndex = 5
        btnExit.Text = "Thoát"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(339, 315)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(119, 59)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Đăng nhập"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(623, 419)
        Controls.Add(btnLogin)
        Controls.Add(btnExit)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "LoginForm"
        Text = "Exam Administrator - Login"
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

End Class
