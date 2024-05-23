<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountManagement
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
        MenuStrip1 = New MenuStrip()
        btnCreate = New ToolStripMenuItem()
        btnCreateTeacher = New ToolStripMenuItem()
        btnCreateStudent = New ToolStripMenuItem()
        btnMe = New ToolStripMenuItem()
        btnMyAcc = New ToolStripMenuItem()
        btnLogout = New ToolStripMenuItem()
        btnFilter = New ToolStripMenuItem()
        btnStudent = New ToolStripMenuItem()
        btnTeacher = New ToolStripMenuItem()
        btnDashboard = New ToolStripMenuItem()
        dgAccount = New DataGridView()
        lblFilter = New Label()
        MenuStrip1.SuspendLayout()
        CType(dgAccount, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnCreate, btnMe, btnFilter, btnDashboard})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(889, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnCreate
        ' 
        btnCreate.DropDownItems.AddRange(New ToolStripItem() {btnCreateTeacher, btnCreateStudent})
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(113, 24)
        btnCreate.Text = "Tạo tài khoản"
        ' 
        ' btnCreateTeacher
        ' 
        btnCreateTeacher.Name = "btnCreateTeacher"
        btnCreateTeacher.Size = New Size(162, 26)
        btnCreateTeacher.Text = "Giảng viên"
        ' 
        ' btnCreateStudent
        ' 
        btnCreateStudent.Name = "btnCreateStudent"
        btnCreateStudent.Size = New Size(162, 26)
        btnCreateStudent.Text = "Sinh viên"
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
        ' btnFilter
        ' 
        btnFilter.DropDownItems.AddRange(New ToolStripItem() {btnStudent, btnTeacher})
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(46, 24)
        btnFilter.Text = "Lọc"
        ' 
        ' btnStudent
        ' 
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(227, 26)
        btnStudent.Text = "Tài khoản sinh viên"
        ' 
        ' btnTeacher
        ' 
        btnTeacher.Name = "btnTeacher"
        btnTeacher.Size = New Size(227, 26)
        btnTeacher.Text = "Tài khoản giảng viên"
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(106, 24)
        btnDashboard.Text = "Về trang chủ"
        ' 
        ' dgAccount
        ' 
        dgAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgAccount.Location = New Point(14, 107)
        dgAccount.Margin = New Padding(3, 4, 3, 4)
        dgAccount.Name = "dgAccount"
        dgAccount.ReadOnly = True
        dgAccount.RowHeadersWidth = 51
        dgAccount.Size = New Size(863, 398)
        dgAccount.TabIndex = 1
        ' 
        ' lblFilter
        ' 
        lblFilter.AutoSize = True
        lblFilter.Font = New Font("Segoe UI", 10F)
        lblFilter.Location = New Point(14, 75)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(121, 23)
        lblFilter.TabIndex = 2
        lblFilter.Text = "Lọc tài khoản: "
        ' 
        ' AccountManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(889, 518)
        Controls.Add(lblFilter)
        Controls.Add(dgAccount)
        Controls.Add(MenuStrip1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AccountManagement"
        Text = "Exam Administrator - Account Manager"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(dgAccount, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents btnCreate As ToolStripMenuItem
	Friend WithEvents dgAccount As DataGridView
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents btnFilter As ToolStripMenuItem
	Friend WithEvents btnStudent As ToolStripMenuItem
	Friend WithEvents btnTeacher As ToolStripMenuItem
	Friend WithEvents lblFilter As Label
	Friend WithEvents btnDashboard As ToolStripMenuItem
	Friend WithEvents btnMyAcc As ToolStripMenuItem
	Friend WithEvents btnLogout As ToolStripMenuItem
	Friend WithEvents btnCreateTeacher As ToolStripMenuItem
	Friend WithEvents btnCreateStudent As ToolStripMenuItem
End Class
