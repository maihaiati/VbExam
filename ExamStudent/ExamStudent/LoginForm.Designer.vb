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
		Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label1.Location = New Point(133, 25)
		Label1.Name = "Label1"
		Label1.Size = New Size(143, 28)
		Label1.TabIndex = 0
		Label1.Text = "Exam Student"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Segoe UI", 12F)
		Label2.Location = New Point(42, 67)
		Label2.Name = "Label2"
		Label2.Size = New Size(111, 21)
		Label2.TabIndex = 1
		Label2.Text = "Tên đăng nhập"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Segoe UI", 12F)
		Label3.Location = New Point(42, 131)
		Label3.Name = "Label3"
		Label3.Size = New Size(75, 21)
		Label3.TabIndex = 2
		Label3.Text = "Mật khẩu"
		' 
		' txtUser
		' 
		txtUser.Location = New Point(47, 91)
		txtUser.Name = "txtUser"
		txtUser.Size = New Size(309, 23)
		txtUser.TabIndex = 3
		' 
		' txtPass
		' 
		txtPass.Location = New Point(47, 155)
		txtPass.Name = "txtPass"
		txtPass.PasswordChar = "*"c
		txtPass.Size = New Size(309, 23)
		txtPass.TabIndex = 4
		' 
		' btnExit
		' 
		btnExit.Location = New Point(85, 196)
		btnExit.Name = "btnExit"
		btnExit.Size = New Size(97, 36)
		btnExit.TabIndex = 5
		btnExit.Text = "Thoát"
		btnExit.UseVisualStyleBackColor = True
		' 
		' btnLogin
		' 
		btnLogin.Location = New Point(223, 196)
		btnLogin.Name = "btnLogin"
		btnLogin.Size = New Size(97, 36)
		btnLogin.TabIndex = 6
		btnLogin.Text = "Đăng nhập"
		btnLogin.UseVisualStyleBackColor = True
		' 
		' LoginForm
		' 
		AcceptButton = btnLogin
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		CancelButton = btnExit
		ClientSize = New Size(406, 244)
		Controls.Add(btnLogin)
		Controls.Add(btnExit)
		Controls.Add(txtPass)
		Controls.Add(txtUser)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Name = "LoginForm"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Exam Student - Login"
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
