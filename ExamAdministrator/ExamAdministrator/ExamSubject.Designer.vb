<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamSubject
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamSubject))
		DGVMonhoc = New DataGridView()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		txtmamh = New TextBox()
		txttmh = New TextBox()
		btnthem = New Button()
		btnxoa = New Button()
		btnchinhsua = New Button()
		txttimkiem = New TextBox()
		txtsotiet = New TextBox()
		Label5 = New Label()
		ContextMenuStrip1 = New ContextMenuStrip(components)
		ThoátToolStripMenuItem = New ToolStripMenuItem()
		MenuStrip1 = New MenuStrip()
		btnDashboard = New ToolStripMenuItem()
		btnMe = New ToolStripMenuItem()
		btnMyAccount = New ToolStripMenuItem()
		btnLogout = New ToolStripMenuItem()
		Label6 = New Label()
		cbbMaKhoa = New ComboBox()
		CType(DGVMonhoc, ComponentModel.ISupportInitialize).BeginInit()
		ContextMenuStrip1.SuspendLayout()
		MenuStrip1.SuspendLayout()
		SuspendLayout()
		' 
		' DGVMonhoc
		' 
		DGVMonhoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DGVMonhoc.Location = New Point(34, 106)
		DGVMonhoc.Margin = New Padding(3, 2, 3, 2)
		DGVMonhoc.Name = "DGVMonhoc"
		DGVMonhoc.ReadOnly = True
		DGVMonhoc.RowHeadersWidth = 51
		DGVMonhoc.Size = New Size(486, 326)
		DGVMonhoc.TabIndex = 0
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
		Label1.ForeColor = Color.Coral
		Label1.Location = New Point(343, 25)
		Label1.Name = "Label1"
		Label1.Size = New Size(191, 25)
		Label1.TabIndex = 1
		Label1.Text = "Thông Tin Môn Học"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
		Label2.ForeColor = SystemColors.Highlight
		Label2.Location = New Point(34, 62)
		Label2.Name = "Label2"
		Label2.Size = New Size(80, 19)
		Label2.TabIndex = 2
		Label2.Text = "Tìm Kiếm: "
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
		Label3.ForeColor = SystemColors.Highlight
		Label3.Location = New Point(554, 104)
		Label3.Name = "Label3"
		Label3.Size = New Size(99, 19)
		Label3.TabIndex = 3
		Label3.Text = "Mã Môn Học:"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
		Label4.ForeColor = SystemColors.Highlight
		Label4.Location = New Point(552, 166)
		Label4.Name = "Label4"
		Label4.Size = New Size(101, 19)
		Label4.TabIndex = 4
		Label4.Text = "Tên Môn Học:"
		' 
		' txtmamh
		' 
		txtmamh.Location = New Point(552, 123)
		txtmamh.Margin = New Padding(3, 2, 3, 2)
		txtmamh.Name = "txtmamh"
		txtmamh.Size = New Size(308, 23)
		txtmamh.TabIndex = 5
		' 
		' txttmh
		' 
		txttmh.Location = New Point(552, 186)
		txttmh.Margin = New Padding(3, 2, 3, 2)
		txttmh.Name = "txttmh"
		txttmh.Size = New Size(308, 23)
		txttmh.TabIndex = 6
		' 
		' btnthem
		' 
		btnthem.BackColor = SystemColors.GradientActiveCaption
		btnthem.FlatStyle = FlatStyle.Flat
		btnthem.Location = New Point(553, 351)
		btnthem.Margin = New Padding(3, 2, 3, 2)
		btnthem.Name = "btnthem"
		btnthem.Size = New Size(136, 33)
		btnthem.TabIndex = 7
		btnthem.Text = "Thêm Môn Học"
		btnthem.UseVisualStyleBackColor = False
		' 
		' btnxoa
		' 
		btnxoa.BackColor = SystemColors.GradientActiveCaption
		btnxoa.FlatStyle = FlatStyle.Flat
		btnxoa.Location = New Point(724, 351)
		btnxoa.Margin = New Padding(3, 2, 3, 2)
		btnxoa.Name = "btnxoa"
		btnxoa.Size = New Size(136, 33)
		btnxoa.TabIndex = 8
		btnxoa.Text = "Xoá Môn Học"
		btnxoa.UseVisualStyleBackColor = False
		' 
		' btnchinhsua
		' 
		btnchinhsua.BackColor = SystemColors.GradientActiveCaption
		btnchinhsua.FlatStyle = FlatStyle.Flat
		btnchinhsua.Location = New Point(553, 399)
		btnchinhsua.Margin = New Padding(3, 2, 3, 2)
		btnchinhsua.Name = "btnchinhsua"
		btnchinhsua.Size = New Size(307, 33)
		btnchinhsua.TabIndex = 9
		btnchinhsua.Text = "Chỉnh Sửa Môn Học"
		btnchinhsua.UseVisualStyleBackColor = False
		' 
		' txttimkiem
		' 
		txttimkiem.Location = New Point(116, 62)
		txttimkiem.Margin = New Padding(3, 2, 3, 2)
		txttimkiem.Name = "txttimkiem"
		txttimkiem.Size = New Size(138, 23)
		txttimkiem.TabIndex = 10
		' 
		' txtsotiet
		' 
		txtsotiet.Location = New Point(552, 304)
		txtsotiet.Margin = New Padding(3, 2, 3, 2)
		txtsotiet.Name = "txtsotiet"
		txtsotiet.Size = New Size(308, 23)
		txtsotiet.TabIndex = 12
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
		Label5.ForeColor = SystemColors.Highlight
		Label5.Location = New Point(552, 284)
		Label5.Name = "Label5"
		Label5.Size = New Size(56, 19)
		Label5.TabIndex = 11
		Label5.Text = "Số tiết:"
		' 
		' ContextMenuStrip1
		' 
		ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
		ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ThoátToolStripMenuItem})
		ContextMenuStrip1.Name = "ContextMenuStrip1"
		ContextMenuStrip1.Size = New Size(105, 26)
		' 
		' ThoátToolStripMenuItem
		' 
		ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
		ThoátToolStripMenuItem.Size = New Size(104, 22)
		ThoátToolStripMenuItem.Text = "Thoát"
		' 
		' MenuStrip1
		' 
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {btnDashboard, btnMe})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Padding = New Padding(5, 2, 0, 2)
		MenuStrip1.Size = New Size(921, 24)
		MenuStrip1.TabIndex = 14
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
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
		Label6.ForeColor = SystemColors.Highlight
		Label6.Location = New Point(552, 229)
		Label6.Name = "Label6"
		Label6.Size = New Size(72, 19)
		Label6.TabIndex = 15
		Label6.Text = "Mã Khoa:"
		' 
		' cbbMaKhoa
		' 
		cbbMaKhoa.FormattingEnabled = True
		cbbMaKhoa.Location = New Point(552, 251)
		cbbMaKhoa.Name = "cbbMaKhoa"
		cbbMaKhoa.Size = New Size(308, 23)
		cbbMaKhoa.TabIndex = 16
		' 
		' ExamSubject
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(921, 447)
		Controls.Add(cbbMaKhoa)
		Controls.Add(Label6)
		Controls.Add(MenuStrip1)
		Controls.Add(txtsotiet)
		Controls.Add(Label5)
		Controls.Add(txttimkiem)
		Controls.Add(btnchinhsua)
		Controls.Add(btnxoa)
		Controls.Add(btnthem)
		Controls.Add(txttmh)
		Controls.Add(txtmamh)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(DGVMonhoc)
		Icon = CType(resources.GetObject("$this.Icon"), Icon)
		MainMenuStrip = MenuStrip1
		Margin = New Padding(3, 2, 3, 2)
		Name = "ExamSubject"
		Text = "Exam Administrator - Exam Subject"
		CType(DGVMonhoc, ComponentModel.ISupportInitialize).EndInit()
		ContextMenuStrip1.ResumeLayout(False)
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents DGVMonhoc As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmamh As TextBox
    Friend WithEvents txttmh As TextBox
    Friend WithEvents btnthem As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents btnchinhsua As Button
    Friend WithEvents txttimkiem As TextBox
    Friend WithEvents txtsotiet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnDashboard As ToolStripMenuItem
	Friend WithEvents btnMe As ToolStripMenuItem
    Friend WithEvents Label6 As Label
	Friend WithEvents cbbMaKhoa As ComboBox
	Friend WithEvents btnMyAccount As ToolStripMenuItem
	Friend WithEvents btnLogout As ToolStripMenuItem
End Class
