<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreManagement
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScoreManagement))
		Label1 = New Label()
		dgScore = New DataGridView()
		btnThem = New Button()
		btnSua = New Button()
		btnXoa = New Button()
		GroupBox1 = New GroupBox()
		cbbMaMH = New ComboBox()
		Label6 = New Label()
		Label5 = New Label()
		Label4 = New Label()
		txtTenMH = New TextBox()
		Label3 = New Label()
		txtMaSV = New TextBox()
		Label7 = New Label()
		txtSearchSV = New TextBox()
		cbbSearchMH = New ComboBox()
		MenuStrip1 = New MenuStrip()
		btnDashboard = New ToolStripMenuItem()
		btnMe = New ToolStripMenuItem()
		btnMyAccount = New ToolStripMenuItem()
		btnLogout = New ToolStripMenuItem()
		Label8 = New Label()
		numDiemThi = New NumericUpDown()
		CType(dgScore, ComponentModel.ISupportInitialize).BeginInit()
		GroupBox1.SuspendLayout()
		MenuStrip1.SuspendLayout()
		CType(numDiemThi, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
		Label1.ForeColor = Color.DeepSkyBlue
		Label1.Location = New Point(449, 24)
		Label1.Name = "Label1"
		Label1.Size = New Size(180, 25)
		Label1.TabIndex = 0
		Label1.Text = "Thông Tin Điểm Thi"
		' 
		' dgScore
		' 
		dgScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgScore.Location = New Point(10, 94)
		dgScore.Margin = New Padding(3, 2, 3, 2)
		dgScore.Name = "dgScore"
		dgScore.ReadOnly = True
		dgScore.RowHeadersWidth = 51
		dgScore.Size = New Size(665, 377)
		dgScore.TabIndex = 1
		' 
		' btnThem
		' 
		btnThem.Location = New Point(690, 428)
		btnThem.Margin = New Padding(3, 2, 3, 2)
		btnThem.Name = "btnThem"
		btnThem.Size = New Size(115, 43)
		btnThem.TabIndex = 2
		btnThem.Text = "Thêm Thông Tin"
		btnThem.UseVisualStyleBackColor = True
		' 
		' btnSua
		' 
		btnSua.Location = New Point(830, 428)
		btnSua.Margin = New Padding(3, 2, 3, 2)
		btnSua.Name = "btnSua"
		btnSua.Size = New Size(115, 43)
		btnSua.TabIndex = 3
		btnSua.Text = "Sửa Thông Tin"
		btnSua.UseVisualStyleBackColor = True
		' 
		' btnXoa
		' 
		btnXoa.Location = New Point(963, 428)
		btnXoa.Margin = New Padding(3, 2, 3, 2)
		btnXoa.Name = "btnXoa"
		btnXoa.Size = New Size(115, 43)
		btnXoa.TabIndex = 4
		btnXoa.Text = "Xoá Thông Tin"
		btnXoa.UseVisualStyleBackColor = True
		' 
		' GroupBox1
		' 
		GroupBox1.Controls.Add(numDiemThi)
		GroupBox1.Controls.Add(cbbMaMH)
		GroupBox1.Controls.Add(Label6)
		GroupBox1.Controls.Add(Label5)
		GroupBox1.Controls.Add(Label4)
		GroupBox1.Controls.Add(txtTenMH)
		GroupBox1.Controls.Add(Label3)
		GroupBox1.Controls.Add(txtMaSV)
		GroupBox1.Location = New Point(690, 94)
		GroupBox1.Margin = New Padding(3, 2, 3, 2)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Padding = New Padding(3, 2, 3, 2)
		GroupBox1.Size = New Size(388, 312)
		GroupBox1.TabIndex = 5
		GroupBox1.TabStop = False
		GroupBox1.Text = "Thông Tin Điểm"
		' 
		' cbbMaMH
		' 
		cbbMaMH.FormattingEnabled = True
		cbbMaMH.Location = New Point(23, 58)
		cbbMaMH.Name = "cbbMaMH"
		cbbMaMH.Size = New Size(342, 23)
		cbbMaMH.TabIndex = 10
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Font = New Font("Segoe UI", 9.5F)
		Label6.Location = New Point(24, 236)
		Label6.Name = "Label6"
		Label6.Size = New Size(62, 17)
		Label6.TabIndex = 9
		Label6.Text = "Điểm Thi:"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Font = New Font("Segoe UI", 9.5F)
		Label5.Location = New Point(23, 37)
		Label5.Name = "Label5"
		Label5.Size = New Size(88, 17)
		Label5.TabIndex = 7
		Label5.Text = "Mã Môn Học:"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Font = New Font("Segoe UI", 9.5F)
		Label4.Location = New Point(24, 167)
		Label4.Name = "Label4"
		Label4.Size = New Size(89, 17)
		Label4.TabIndex = 5
		Label4.Text = "Tên Môn Học:"
		' 
		' txtTenMH
		' 
		txtTenMH.Location = New Point(23, 188)
		txtTenMH.Margin = New Padding(3, 2, 3, 2)
		txtTenMH.Name = "txtTenMH"
		txtTenMH.ReadOnly = True
		txtTenMH.Size = New Size(342, 23)
		txtTenMH.TabIndex = 4
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Segoe UI", 9.5F)
		Label3.Location = New Point(24, 104)
		Label3.Name = "Label3"
		Label3.Size = New Size(87, 17)
		Label3.TabIndex = 3
		Label3.Text = "Mã Sinh Viên:"
		' 
		' txtMaSV
		' 
		txtMaSV.Location = New Point(23, 125)
		txtMaSV.Margin = New Padding(3, 2, 3, 2)
		txtMaSV.Name = "txtMaSV"
		txtMaSV.ReadOnly = True
		txtMaSV.Size = New Size(342, 23)
		txtMaSV.TabIndex = 2
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Location = New Point(10, 70)
		Label7.Name = "Label7"
		Label7.Size = New Size(94, 15)
		Label7.TabIndex = 6
		Label7.Text = "Tìm kiếm (MSV):"
		' 
		' txtSearchSV
		' 
		txtSearchSV.Location = New Point(118, 68)
		txtSearchSV.Margin = New Padding(3, 2, 3, 2)
		txtSearchSV.Name = "txtSearchSV"
		txtSearchSV.Size = New Size(137, 23)
		txtSearchSV.TabIndex = 7
		' 
		' cbbSearchMH
		' 
		cbbSearchMH.FormattingEnabled = True
		cbbSearchMH.Location = New Point(542, 67)
		cbbSearchMH.Margin = New Padding(3, 2, 3, 2)
		cbbSearchMH.Name = "cbbSearchMH"
		cbbSearchMH.Size = New Size(133, 23)
		cbbSearchMH.TabIndex = 8
		' 
		' MenuStrip1
		' 
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {btnDashboard, btnMe})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Padding = New Padding(5, 2, 0, 2)
		MenuStrip1.Size = New Size(1094, 24)
		MenuStrip1.TabIndex = 9
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
		btnMyAccount.Size = New Size(163, 22)
		btnMyAccount.Text = "Tài khoản của tôi"
		' 
		' btnLogout
		' 
		btnLogout.Name = "btnLogout"
		btnLogout.Size = New Size(163, 22)
		btnLogout.Text = "Đăng xuất"
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Location = New Point(449, 71)
		Label8.Name = "Label8"
		Label8.Size = New Size(78, 15)
		Label8.TabIndex = 10
		Label8.Text = "Mã môn học:"
		' 
		' numDiemThi
		' 
		numDiemThi.DecimalPlaces = 2
		numDiemThi.Location = New Point(23, 256)
		numDiemThi.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		numDiemThi.Name = "numDiemThi"
		numDiemThi.Size = New Size(342, 23)
		numDiemThi.TabIndex = 11
		' 
		' ScoreManagement
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(1094, 490)
		Controls.Add(Label8)
		Controls.Add(cbbSearchMH)
		Controls.Add(txtSearchSV)
		Controls.Add(Label7)
		Controls.Add(GroupBox1)
		Controls.Add(btnXoa)
		Controls.Add(btnSua)
		Controls.Add(btnThem)
		Controls.Add(dgScore)
		Controls.Add(Label1)
		Controls.Add(MenuStrip1)
		Icon = CType(resources.GetObject("$this.Icon"), Icon)
		MainMenuStrip = MenuStrip1
		Margin = New Padding(3, 2, 3, 2)
		Name = "ScoreManagement"
		Text = "Exam Administrator - Score management"
		CType(dgScore, ComponentModel.ISupportInitialize).EndInit()
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		CType(numDiemThi, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents dgScore As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTenMH As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearchSV As TextBox
    Friend WithEvents cbbSearchMH As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnDashboard As ToolStripMenuItem
	Friend WithEvents Label8 As Label
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents cbbMaMH As ComboBox
	Friend WithEvents btnMyAccount As ToolStripMenuItem
	Friend WithEvents btnLogout As ToolStripMenuItem
	Friend WithEvents numDiemThi As NumericUpDown
End Class
