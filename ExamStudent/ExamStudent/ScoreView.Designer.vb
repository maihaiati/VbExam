<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreView
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
		dgScore = New DataGridView()
		MenuStrip1 = New MenuStrip()
		btnDashboard = New ToolStripMenuItem()
		btnMe = New ToolStripMenuItem()
		btnMyAccount = New ToolStripMenuItem()
		btnLogout = New ToolStripMenuItem()
		CType(dgScore, ComponentModel.ISupportInitialize).BeginInit()
		MenuStrip1.SuspendLayout()
		SuspendLayout()
		' 
		' dgScore
		' 
		dgScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgScore.Location = New Point(12, 46)
		dgScore.Name = "dgScore"
		dgScore.Size = New Size(776, 392)
		dgScore.TabIndex = 0
		' 
		' MenuStrip1
		' 
		MenuStrip1.Items.AddRange(New ToolStripItem() {btnDashboard, btnMe})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(800, 24)
		MenuStrip1.TabIndex = 1
		MenuStrip1.Text = "MenuStrip1"
		' 
		' btnDashboard
		' 
		btnDashboard.Name = "btnDashboard"
		btnDashboard.Size = New Size(86, 20)
		btnDashboard.Text = "Về trang chủ"
		' 
		' btnMe
		' 
		btnMe.Alignment = ToolStripItemAlignment.Right
		btnMe.DropDownItems.AddRange(New ToolStripItem() {btnMyAccount, btnLogout})
		btnMe.Name = "btnMe"
		btnMe.Size = New Size(22, 20)
		btnMe.Text = " "
		' 
		' btnMyAccount
		' 
		btnMyAccount.Name = "btnMyAccount"
		btnMyAccount.Size = New Size(180, 22)
		btnMyAccount.Text = "Tài khoản của tôi"
		' 
		' btnLogout
		' 
		btnLogout.Name = "btnLogout"
		btnLogout.Size = New Size(180, 22)
		btnLogout.Text = "Đăng xuất"
		' 
		' ScoreView
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(dgScore)
		Controls.Add(MenuStrip1)
		MainMenuStrip = MenuStrip1
		Name = "ScoreView"
		Text = "Exam Student - Score view"
		CType(dgScore, ComponentModel.ISupportInitialize).EndInit()
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents dgScore As DataGridView
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents btnDashboard As ToolStripMenuItem
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents btnMyAccount As ToolStripMenuItem
	Friend WithEvents btnLogout As ToolStripMenuItem
End Class
