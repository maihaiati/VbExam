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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        MenuStrip1 = New MenuStrip()
        btnAccount = New ToolStripMenuItem()
        btnExam = New ToolStripMenuItem()
        btnResult = New ToolStripMenuItem()
        btnSchedule = New ToolStripMenuItem()
        btnMe = New ToolStripMenuItem()
        btnMyAcc = New ToolStripMenuItem()
        btnLogout = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnAccount, btnExam, btnResult, btnSchedule, btnMe})
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
        ' btnSchedule
        ' 
        btnSchedule.Name = "btnSchedule"
        btnSchedule.Size = New Size(97, 24)
        btnSchedule.Text = "&Xếp lịch thi"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(130, 230)
        Label1.Name = "Label1"
        Label1.Size = New Size(666, 35)
        Label1.TabIndex = 1
        Label1.Text = "Chào Mừng Bạn Đến Hệ Thống Tải Khoản Thi Trắc Nghiệm"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(277, 275)
        Label2.Name = "Label2"
        Label2.Size = New Size(377, 28)
        Label2.TabIndex = 2
        Label2.Text = "Trường Kinh Doanh và Công Nghệ Hà Nội"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(326, 60)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(269, 153)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(440, 333)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 4
        Label3.Text = "Label3"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.imgae_truong_hubt
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(926, 512)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Dashboard"
        Text = "Exam Administrator - Dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
