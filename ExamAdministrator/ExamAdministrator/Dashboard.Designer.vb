﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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

<<<<<<< HEAD
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
        DataGridView1 = New DataGridView()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnAccount, btnExam, btnResult, btnSchedule, btnMe})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(768, 30)
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
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 84)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(744, 399)
        DataGridView1.TabIndex = 1
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(768, 509)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Dashboard"
        Text = "Exam Administrator - Dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
=======
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		MenuStrip1 = New MenuStrip()
		btnAccount = New ToolStripMenuItem()
		TạoTàiKhoảnToolStripMenuItem = New ToolStripMenuItem()
		DanhSáchTàiKhoảnToolStripMenuItem = New ToolStripMenuItem()
		TàiKhoảnSinhViênToolStripMenuItem = New ToolStripMenuItem()
		TàiKhoảnGiảngViênToolStripMenuItem = New ToolStripMenuItem()
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
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {btnAccount, btnExam, btnResult, btnSchedule, btnMe})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(672, 24)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' btnAccount
		' 
		btnAccount.DropDownItems.AddRange(New ToolStripItem() {TạoTàiKhoảnToolStripMenuItem, DanhSáchTàiKhoảnToolStripMenuItem})
		btnAccount.Name = "btnAccount"
		btnAccount.Size = New Size(112, 20)
		btnAccount.Text = "Quản lý &tài khoản"
		' 
		' TạoTàiKhoảnToolStripMenuItem
		' 
		TạoTàiKhoảnToolStripMenuItem.Name = "TạoTàiKhoảnToolStripMenuItem"
		TạoTàiKhoảnToolStripMenuItem.Size = New Size(184, 22)
		TạoTàiKhoảnToolStripMenuItem.Text = "Tạo Tài Khoản"
		' 
		' DanhSáchTàiKhoảnToolStripMenuItem
		' 
		DanhSáchTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TàiKhoảnSinhViênToolStripMenuItem, TàiKhoảnGiảngViênToolStripMenuItem})
		DanhSáchTàiKhoảnToolStripMenuItem.Name = "DanhSáchTàiKhoảnToolStripMenuItem"
		DanhSáchTàiKhoảnToolStripMenuItem.Size = New Size(184, 22)
		DanhSáchTàiKhoảnToolStripMenuItem.Text = "Danh Sách Tài Khoản"
		' 
		' TàiKhoảnSinhViênToolStripMenuItem
		' 
		TàiKhoảnSinhViênToolStripMenuItem.Name = "TàiKhoảnSinhViênToolStripMenuItem"
		TàiKhoảnSinhViênToolStripMenuItem.Size = New Size(185, 22)
		TàiKhoảnSinhViênToolStripMenuItem.Text = "Tài Khoản Sinh Viên"
		' 
		' TàiKhoảnGiảngViênToolStripMenuItem
		' 
		TàiKhoảnGiảngViênToolStripMenuItem.Name = "TàiKhoảnGiảngViênToolStripMenuItem"
		TàiKhoảnGiảngViênToolStripMenuItem.Size = New Size(185, 22)
		TàiKhoảnGiảngViênToolStripMenuItem.Text = "Tài Khoản Giảng Viên"
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
		btnMyAcc.Size = New Size(163, 22)
		btnMyAcc.Text = "Tài khoản của tôi"
		' 
		' btnLogout
		' 
		btnLogout.Name = "btnLogout"
		btnLogout.Size = New Size(163, 22)
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
>>>>>>> a36d3fefd450d6fb7d8ef9b3778394f050b7d939

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents btnAccount As ToolStripMenuItem
	Friend WithEvents btnExam As ToolStripMenuItem
	Friend WithEvents btnResult As ToolStripMenuItem
	Friend WithEvents btnSchedule As ToolStripMenuItem
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents btnMyAcc As ToolStripMenuItem
	Friend WithEvents btnLogout As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
End Class
