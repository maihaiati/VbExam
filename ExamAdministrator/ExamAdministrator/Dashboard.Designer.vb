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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		components = New ComponentModel.Container()
		MenuStrip1 = New MenuStrip()
		btnAccount = New ToolStripMenuItem()
		btnExam = New ToolStripMenuItem()
		btnResult = New ToolStripMenuItem()
		btnMe = New ToolStripMenuItem()
		btnMyAcc = New ToolStripMenuItem()
		btnLogout = New ToolStripMenuItem()
		btnmonhoc = New ToolStripMenuItem()
		btnKhoa = New ToolStripMenuItem()
		Label1 = New Label()
		lblLoiChao = New Label()
		lblTime = New Label()
		Timer = New Timer(components)
		MenuStrip1.SuspendLayout()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {btnAccount, btnExam, btnResult, btnMe, btnmonhoc, btnKhoa})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(810, 24)
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
		btnMyAcc.Size = New Size(163, 22)
		btnMyAcc.Text = "Tài khoản của tôi"
		' 
		' btnLogout
		' 
		btnLogout.Name = "btnLogout"
		btnLogout.Size = New Size(163, 22)
		btnLogout.Text = "Đăng xuất"
		' 
		' btnmonhoc
		' 
		btnmonhoc.Name = "btnmonhoc"
		btnmonhoc.Size = New Size(108, 20)
		btnmonhoc.Text = "Quản lí &môn học"
		' 
		' btnKhoa
		' 
		btnKhoa.Name = "btnKhoa"
		btnKhoa.Size = New Size(86, 20)
		btnKhoa.Text = "Quản lí &khoa"
		' 
		' Label1
		' 
		Label1.Font = New Font("Segoe UI", 15F)
		Label1.Location = New Point(164, 49)
		Label1.Name = "Label1"
		Label1.Size = New Size(506, 26)
		Label1.TabIndex = 1
		Label1.Text = "Trường Đại Học Kinh Doanh và Công Nghệ Hà Nội"
		Label1.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblLoiChao
		' 
		lblLoiChao.Font = New Font("Segoe UI", 12F)
		lblLoiChao.Location = New Point(214, 103)
		lblLoiChao.Name = "lblLoiChao"
		lblLoiChao.Size = New Size(395, 21)
		lblLoiChao.TabIndex = 2
		lblLoiChao.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblTime
		' 
		lblTime.Font = New Font("Segoe UI", 30F)
		lblTime.Location = New Point(176, 174)
		lblTime.Name = "lblTime"
		lblTime.Size = New Size(477, 109)
		lblTime.TabIndex = 3
		lblTime.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Timer
		' 
		Timer.Enabled = True
		Timer.Interval = 1000
		' 
		' Dashboard
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(810, 384)
		Controls.Add(lblTime)
		Controls.Add(lblLoiChao)
		Controls.Add(Label1)
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
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents btnMyAcc As ToolStripMenuItem
	Friend WithEvents btnLogout As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLoiChao As Label
    Friend WithEvents btnmonhoc As ToolStripMenuItem
    Friend WithEvents btnKhoa As ToolStripMenuItem
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer As Timer
End Class
