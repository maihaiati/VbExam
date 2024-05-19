<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
		btnAccount = New ToolStripMenuItem()
		btnExam = New ToolStripMenuItem()
		btnResult = New ToolStripMenuItem()
		btnSchedule = New ToolStripMenuItem()
		btnMe = New ToolStripMenuItem()
		btnMyAcc = New ToolStripMenuItem()
		btnLogout = New ToolStripMenuItem()
		MenuStrip1.SuspendLayout()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.Items.AddRange(New ToolStripItem() {btnAccount, btnExam, btnResult, btnSchedule, btnMe})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(672, 24)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' btnAccount
		' 
		btnAccount.Name = "btnAccount"
		btnAccount.Size = New Size(112, 20)
		btnAccount.Text = "Quản lý &tài khoản"
		' 
		' btnExam
		' 
		btnExam.Name = "btnExam"
		btnExam.Size = New Size(93, 20)
		btnExam.Text = "Quản lý &đề thi"
		' 
		' btnResult
		' 
		btnResult.Name = "btnResult"
		btnResult.Size = New Size(119, 20)
		btnResult.Text = "Quản lý &kết quả thi"
		' 
		' btnSchedule
		' 
		btnSchedule.Name = "btnSchedule"
		btnSchedule.Size = New Size(78, 20)
		btnSchedule.Text = "&Xếp lịch thi"
		' 
		' btnMe
		' 
		btnMe.Alignment = ToolStripItemAlignment.Right
		btnMe.DropDownItems.AddRange(New ToolStripItem() {btnMyAcc, btnLogout})
		btnMe.Name = "btnMe"
		btnMe.Size = New Size(22, 20)
		btnMe.Text = " "
		' 
		' btnMyAcc
		' 
		btnMyAcc.Name = "btnMyAcc"
		btnMyAcc.Size = New Size(180, 22)
		btnMyAcc.Text = "Tài khoản của tôi"
		' 
		' btnLogout
		' 
		btnLogout.Name = "btnLogout"
		btnLogout.Size = New Size(180, 22)
		btnLogout.Text = "Đăng xuất"
		' 
		' Dashboard
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(672, 382)
		Controls.Add(MenuStrip1)
		MainMenuStrip = MenuStrip1
		Name = "Dashboard"
		Text = "Exam Administrator - Dashboard"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents btnAccount As ToolStripMenuItem
	Friend WithEvents btnExam As ToolStripMenuItem
	Friend WithEvents btnResult As ToolStripMenuItem
	Friend WithEvents btnSchedule As ToolStripMenuItem
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents btnMyAcc As ToolStripMenuItem
	Friend WithEvents btnLogout As ToolStripMenuItem
End Class
