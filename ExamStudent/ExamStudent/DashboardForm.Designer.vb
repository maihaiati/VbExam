<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        dgExam = New DataGridView()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        btnMe = New ToolStripMenuItem()
        btnMyAccount = New ToolStripMenuItem()
        btnLogout = New ToolStripMenuItem()
        Timer = New Timer(components)
        CType(dgExam, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgExam
        ' 
        dgExam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgExam.Location = New Point(14, 108)
        dgExam.Margin = New Padding(3, 4, 3, 4)
        dgExam.Name = "dgExam"
        dgExam.ReadOnly = True
        dgExam.RowHeadersWidth = 51
        dgExam.Size = New Size(866, 555)
        dgExam.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(14, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(300, 28)
        Label2.TabIndex = 2
        Label2.Text = "Chọn đề thi có sẵn để bắt đầu thi"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnMe})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(894, 30)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnMe
        ' 
        btnMe.Alignment = ToolStripItemAlignment.Right
        btnMe.DropDownItems.AddRange(New ToolStripItem() {btnMyAccount, btnLogout})
        btnMe.Name = "btnMe"
        btnMe.Size = New Size(27, 24)
        btnMe.Text = " "
        ' 
        ' btnMyAccount
        ' 
        btnMyAccount.Name = "btnMyAccount"
        btnMyAccount.Size = New Size(203, 26)
        btnMyAccount.Text = "Tài khoản của tôi"
        ' 
        ' btnLogout
        ' 
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(203, 26)
        btnLogout.Text = "Đăng xuất"
        ' 
        ' Timer
        ' 
        Timer.Enabled = True
        Timer.Interval = 10000
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(894, 679)
        Controls.Add(Label2)
        Controls.Add(dgExam)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "DashboardForm"
        Text = "Exam Student - Dashboard"
        CType(dgExam, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgExam As DataGridView
	Friend WithEvents Label2 As Label
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents btnMyAccount As ToolStripMenuItem
	Friend WithEvents btnLogout As ToolStripMenuItem
	Friend WithEvents Timer As Timer
End Class
