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
        DataGridView1 = New DataGridView()
        btnthem = New Button()
        btnSua = New Button()
        btnXoa = New Button()
        GroupBox1 = New GroupBox()
        Label6 = New Label()
        txtdiemthi = New TextBox()
        Label5 = New Label()
        txtmamh = New TextBox()
        Label4 = New Label()
        txttmh = New TextBox()
        Label3 = New Label()
        txtsinhvien = New TextBox()
        Label2 = New Label()
        txtmadiem = New TextBox()
        Label7 = New Label()
        txtsreach = New TextBox()
        cblop = New ComboBox()
        MenuStrip1 = New MenuStrip()
        ThoátToolStripMenuItem = New ToolStripMenuItem()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label1.ForeColor = Color.DeepSkyBlue
        Label1.Location = New Point(723, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 30)
        Label1.TabIndex = 0
        Label1.Text = "Thông Tin Điểm Thi"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 125)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1002, 503)
        DataGridView1.TabIndex = 1
        ' 
        ' btnthem
        ' 
        btnthem.Location = New Point(1057, 571)
        btnthem.Name = "btnthem"
        btnthem.Size = New Size(131, 57)
        btnthem.TabIndex = 2
        btnthem.Text = "Thêm Thông Tin"
        btnthem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(1217, 571)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(131, 57)
        btnSua.TabIndex = 3
        btnSua.Text = "Sửa Thông Tin"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(1369, 571)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(131, 57)
        btnXoa.TabIndex = 4
        btnXoa.Text = "Xoá Thông Tin"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtdiemthi)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtmamh)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txttmh)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtsinhvien)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtmadiem)
        GroupBox1.Location = New Point(1057, 125)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(443, 416)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Thông Tin Điểm"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.5F)
        Label6.Location = New Point(27, 331)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 21)
        Label6.TabIndex = 9
        Label6.Text = "Điểm Thi:"
        ' 
        ' txtdiemthi
        ' 
        txtdiemthi.Location = New Point(26, 354)
        txtdiemthi.Name = "txtdiemthi"
        txtdiemthi.Size = New Size(390, 27)
        txtdiemthi.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.5F)
        Label5.Location = New Point(26, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 21)
        Label5.TabIndex = 7
        Label5.Text = "Mã Môn Học:"
        ' 
        ' txtmamh
        ' 
        txtmamh.Location = New Point(26, 140)
        txtmamh.Name = "txtmamh"
        txtmamh.Size = New Size(390, 27)
        txtmamh.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.5F)
        Label4.Location = New Point(27, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 21)
        Label4.TabIndex = 5
        Label4.Text = "Tên Môn Học:"
        ' 
        ' txttmh
        ' 
        txttmh.Location = New Point(26, 274)
        txttmh.Name = "txttmh"
        txttmh.Size = New Size(390, 27)
        txttmh.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.5F)
        Label3.Location = New Point(27, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 21)
        Label3.TabIndex = 3
        Label3.Text = "Mã Sinh Viên:"
        ' 
        ' txtsinhvien
        ' 
        txtsinhvien.Location = New Point(26, 206)
        txtsinhvien.Name = "txtsinhvien"
        txtsinhvien.Size = New Size(390, 27)
        txtsinhvien.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.5F)
        Label2.Location = New Point(26, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 21)
        Label2.TabIndex = 1
        Label2.Text = "Mã Điểm:"
        ' 
        ' txtmadiem
        ' 
        txtmadiem.Location = New Point(26, 65)
        txtmadiem.Name = "txtmadiem"
        txtmadiem.Size = New Size(390, 27)
        txtmadiem.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 20)
        Label7.TabIndex = 6
        Label7.Text = "Tìm kiếm (MSV):"
        ' 
        ' txtsreach
        ' 
        txtsreach.Location = New Point(135, 90)
        txtsreach.Name = "txtsreach"
        txtsreach.Size = New Size(156, 27)
        txtsreach.TabIndex = 7
        ' 
        ' cblop
        ' 
        cblop.FormattingEnabled = True
        cblop.Location = New Point(863, 89)
        cblop.Name = "cblop"
        cblop.Size = New Size(151, 28)
        cblop.TabIndex = 8
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ThoátToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1516, 28)
        MenuStrip1.TabIndex = 9
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ThoátToolStripMenuItem
        ' 
        ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        ThoátToolStripMenuItem.Size = New Size(61, 24)
        ThoátToolStripMenuItem.Text = "Thoát"
        ' 
        ' ScoreManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1516, 653)
        Controls.Add(cblop)
        Controls.Add(txtsreach)
        Controls.Add(Label7)
        Controls.Add(GroupBox1)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnthem)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "ScoreManagement"
        Text = "ScoreManagement"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnthem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmadiem As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdiemthi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmamh As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txttmh As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsinhvien As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtsreach As TextBox
    Friend WithEvents cblop As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
End Class
