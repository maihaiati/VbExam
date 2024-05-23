<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamSchedule
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
        ThoátToolStripMenuItem = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        clnMMH = New DataGridViewTextBoxColumn()
        clnMSV = New DataGridViewTextBoxColumn()
        clnMon = New DataGridViewTextBoxColumn()
        clnLop = New DataGridViewTextBoxColumn()
        clnNgayThi = New DataGridViewTextBoxColumn()
        clnPhong = New DataGridViewTextBoxColumn()
        TạoLịchToolStripMenuItem = New ToolStripMenuItem()
        ThayĐổiLịchThiToolStripMenuItem = New ToolStripMenuItem()
        XóaLịchToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        SắpXếpLịchThiToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TạoLịchToolStripMenuItem, ThayĐổiLịchThiToolStripMenuItem, XóaLịchToolStripMenuItem, SắpXếpLịchThiToolStripMenuItem, ThoátToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(808, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ThoátToolStripMenuItem
        ' 
        ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        ThoátToolStripMenuItem.Size = New Size(61, 24)
        ThoátToolStripMenuItem.Text = "Thoát"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {clnMMH, clnMSV, clnMon, clnLop, clnNgayThi, clnPhong})
        DataGridView1.Location = New Point(0, 269)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(805, 333)
        DataGridView1.TabIndex = 1
        ' 
        ' clnMMH
        ' 
        clnMMH.HeaderText = "Mã Môn Học"
        clnMMH.MinimumWidth = 6
        clnMMH.Name = "clnMMH"
        clnMMH.Width = 125
        ' 
        ' clnMSV
        ' 
        clnMSV.HeaderText = "MSV"
        clnMSV.MinimumWidth = 6
        clnMSV.Name = "clnMSV"
        clnMSV.Width = 125
        ' 
        ' clnMon
        ' 
        clnMon.HeaderText = "Môn"
        clnMon.MinimumWidth = 6
        clnMon.Name = "clnMon"
        clnMon.Width = 125
        ' 
        ' clnLop
        ' 
        clnLop.HeaderText = "Lớp"
        clnLop.MinimumWidth = 6
        clnLop.Name = "clnLop"
        clnLop.Width = 125
        ' 
        ' clnNgayThi
        ' 
        clnNgayThi.HeaderText = "Ngày Thi"
        clnNgayThi.MinimumWidth = 6
        clnNgayThi.Name = "clnNgayThi"
        clnNgayThi.Width = 125
        ' 
        ' clnPhong
        ' 
        clnPhong.HeaderText = "Phòng Thi"
        clnPhong.MinimumWidth = 6
        clnPhong.Name = "clnPhong"
        clnPhong.Width = 125
        ' 
        ' TạoLịchToolStripMenuItem
        ' 
        TạoLịchToolStripMenuItem.Name = "TạoLịchToolStripMenuItem"
        TạoLịchToolStripMenuItem.Size = New Size(102, 24)
        TạoLịchToolStripMenuItem.Text = "Tạo Lịch Thi"
        ' 
        ' ThayĐổiLịchThiToolStripMenuItem
        ' 
        ThayĐổiLịchThiToolStripMenuItem.Name = "ThayĐổiLịchThiToolStripMenuItem"
        ThayĐổiLịchThiToolStripMenuItem.Size = New Size(136, 24)
        ThayĐổiLịchThiToolStripMenuItem.Text = "Thay Đổi Lịch Thi"
        ' 
        ' XóaLịchToolStripMenuItem
        ' 
        XóaLịchToolStripMenuItem.Name = "XóaLịchToolStripMenuItem"
        XóaLịchToolStripMenuItem.Size = New Size(79, 24)
        XóaLịchToolStripMenuItem.Text = "Xóa Lịch"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(31, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 20)
        Label1.TabIndex = 2
        Label1.Text = "Mã Môn Học:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(446, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 3
        Label2.Text = "Lớp:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.Blue
        Label3.Location = New Point(31, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 20)
        Label3.TabIndex = 4
        Label3.Text = "Ngày Thi:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.Blue
        Label4.Location = New Point(446, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 5
        Label4.Text = "Phòng Thi:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.Location = New Point(645, 41)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 37)
        Button1.TabIndex = 6
        Button1.Text = "Tìm Kiếm"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' SắpXếpLịchThiToolStripMenuItem
        ' 
        SắpXếpLịchThiToolStripMenuItem.Name = "SắpXếpLịchThiToolStripMenuItem"
        SắpXếpLịchThiToolStripMenuItem.Size = New Size(132, 24)
        SắpXếpLịchThiToolStripMenuItem.Text = "Sắp Xếp Lịch Thi"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(156, 112)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(172, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(539, 175)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(172, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(539, 116)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(172, 27)
        TextBox3.TabIndex = 9
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(156, 177)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(172, 27)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Underline)
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(52, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(294, 28)
        Label5.TabIndex = 11
        Label5.Text = "Thông Tin Danh Sách Lịch Thi"
        ' 
        ' ExamSchedule
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(808, 604)
        Controls.Add(Label5)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ExamSchedule"
        Text = "Exam Administrator - Exam Schedule"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents clnMMH As DataGridViewTextBoxColumn
    Friend WithEvents clnMSV As DataGridViewTextBoxColumn
    Friend WithEvents clnMon As DataGridViewTextBoxColumn
    Friend WithEvents clnLop As DataGridViewTextBoxColumn
    Friend WithEvents clnNgayThi As DataGridViewTextBoxColumn
    Friend WithEvents clnPhong As DataGridViewTextBoxColumn
    Friend WithEvents TạoLịchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThayĐổiLịchThiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XóaLịchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents SắpXếpLịchThiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
