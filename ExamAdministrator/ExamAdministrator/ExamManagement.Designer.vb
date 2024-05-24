<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamManagement
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
		MenuStrip1 = New MenuStrip()
		btnCreateExam = New ToolStripMenuItem()
		btnFilter = New ToolStripMenuItem()
		btnMe = New ToolStripMenuItem()
		btnMyAccount = New ToolStripMenuItem()
		btnLogout = New ToolStripMenuItem()
		btnDashboard = New ToolStripMenuItem()
		dgExam = New DataGridView()
		MenuStrip1.SuspendLayout()
		CType(dgExam, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {btnCreateExam, btnFilter, btnMe, btnDashboard})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(800, 24)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' btnCreateExam
		' 
		btnCreateExam.Name = "btnCreateExam"
		btnCreateExam.Size = New Size(71, 20)
		btnCreateExam.Text = "Tạo đề thi"
		' 
		' btnFilter
		' 
		btnFilter.Name = "btnFilter"
		btnFilter.Size = New Size(38, 20)
		btnFilter.Text = "Lọc"
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
		btnMyAccount.Size = New Size(163, 22)
		btnMyAccount.Text = "Tài khoản của tôi"
		' 
		' btnLogout
		' 
		btnLogout.Name = "btnLogout"
		btnLogout.Size = New Size(163, 22)
		btnLogout.Text = "Đăng xuất"
		' 
		' btnDashboard
		' 
		btnDashboard.Name = "btnDashboard"
		btnDashboard.Size = New Size(86, 20)
		btnDashboard.Text = "Về trang chủ"
		' 
		' dgExam
		' 
		dgExam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgExam.Location = New Point(12, 50)
		dgExam.Name = "dgExam"
		dgExam.ReadOnly = True
		dgExam.RowHeadersWidth = 51
		dgExam.Size = New Size(776, 388)
		dgExam.TabIndex = 1
		' 
		' ExamManagement
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(dgExam)
		Controls.Add(MenuStrip1)
		MainMenuStrip = MenuStrip1
		Name = "ExamManagement"
		Text = "Exam Administrator - Exam Management"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		CType(dgExam, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents btnCreateExam As ToolStripMenuItem
	Friend WithEvents btnFilter As ToolStripMenuItem
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents dgExam As DataGridView
	Friend WithEvents btnMyAccount As ToolStripMenuItem
	Friend WithEvents btnLogout As ToolStripMenuItem
	Friend WithEvents btnDashboard As ToolStripMenuItem
End Class
