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
        KhoaToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        lblTime = New Label()
        Timer = New Timer(components)
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnAccount, btnExam, btnResult, btnMe, btnmonhoc, KhoaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(926, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnAccount
        ' 
        btnAccount.Name = "btnAccount"
        btnAccount.Size = New Size(138, 24)
        btnAccount.Text = "Quản lý &tài khoản"
        ' 
        ' btnExam
        ' 
        btnExam.Name = "btnExam"
        btnExam.Size = New Size(115, 24)
        btnExam.Text = "Quản lý &đề thi"
        ' 
        ' btnResult
        ' 
        btnResult.Name = "btnResult"
        btnResult.Size = New Size(147, 24)
        btnResult.Text = "Quản lý &kết quả thi"
        ' 
        ' btnMe
        ' 
        btnMe.Alignment = ToolStripItemAlignment.Right
        btnMe.DropDownItems.AddRange(New ToolStripItem() {btnMyAcc, btnLogout})
        btnMe.Name = "btnMe"
        btnMe.Size = New Size(27, 24)
        btnMe.Text = " "
        ' 
        ' btnMyAcc
        ' 
        btnMyAcc.Name = "btnMyAcc"
        btnMyAcc.Size = New Size(203, 26)
        btnMyAcc.Text = "Tài khoản của tôi"
        ' 
        ' btnLogout
        ' 
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(203, 26)
        btnLogout.Text = "Đăng xuất"
        ' 
        ' btnmonhoc
        ' 
        btnmonhoc.Name = "btnmonhoc"
        btnmonhoc.Size = New Size(132, 24)
        btnmonhoc.Text = "Quản lí &môn học"
        ' 
        ' KhoaToolStripMenuItem
        ' 
        KhoaToolStripMenuItem.Name = "KhoaToolStripMenuItem"
        KhoaToolStripMenuItem.Size = New Size(106, 24)
        KhoaToolStripMenuItem.Text = "Quản lí &khoa"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(134, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(663, 35)
        Label1.TabIndex = 1
        Label1.Text = "Chào Mừng Bạn Đến Hệ Thống Tài Khoản Thi Trắc Nghiệm"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(240, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(451, 28)
        Label2.TabIndex = 2
        Label2.Text = "Trường Đại Học Kinh Doanh và Công Nghệ Hà Nội"
        ' 
        ' lblTime
        ' 
        lblTime.Font = New Font("Segoe UI", 30F)
        lblTime.Location = New Point(187, 232)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(545, 145)
        lblTime.TabIndex = 3
        lblTime.Text = "lblTime"
        lblTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer
        ' 
        Timer.Enabled = True
        Timer.Interval = 1000
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(926, 512)
        Controls.Add(lblTime)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents btnmonhoc As ToolStripMenuItem
    Friend WithEvents KhoaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer As Timer
End Class
