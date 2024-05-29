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
        clnMon = New DataGridViewTextBoxColumn()
        clnLop = New DataGridViewTextBoxColumn()
        clnNgayThi = New DataGridViewTextBoxColumn()
        clnPhong = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label6 = New Label()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ThoátToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1297, 28)
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {clnMMH, clnMon, clnLop, clnNgayThi, clnPhong})
        DataGridView1.Location = New Point(12, 155)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(805, 469)
        DataGridView1.TabIndex = 1
        ' 
        ' clnMMH
        ' 
        clnMMH.HeaderText = "Mã Môn Học"
        clnMMH.MinimumWidth = 6
        clnMMH.Name = "clnMMH"
        clnMMH.Width = 125
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(887, 162)
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
        Label2.Location = New Point(888, 284)
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
        Label3.Location = New Point(887, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 20)
        Label3.TabIndex = 4
        Label3.Text = "Thời Gian Thi:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.Blue
        Label4.Location = New Point(888, 347)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 5
        Label4.Text = "Phòng Thi:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(1012, 155)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(172, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(1012, 343)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(172, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(1012, 284)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(172, 27)
        TextBox3.TabIndex = 9
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "hh:mm dd-MM-yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(1012, 220)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(172, 27)
        DateTimePicker1.TabIndex = 10
        DateTimePicker1.Value = New Date(2024, 5, 23, 0, 0, 0, 0)
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Underline)
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(542, 48)
        Label5.Name = "Label5"
        Label5.Size = New Size(294, 28)
        Label5.TabIndex = 11
        Label5.Text = "Thông Tin Danh Sách Lịch Thi"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(152, 109)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(173, 27)
        TextBox4.TabIndex = 12
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.Location = New Point(897, 510)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 45)
        Button2.TabIndex = 13
        Button2.Text = "Xoá Lịch"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button3.Location = New Point(1060, 510)
        Button3.Name = "Button3"
        Button3.Size = New Size(143, 45)
        Button3.TabIndex = 14
        Button3.Text = "Sắp xếp"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button4.BackgroundImageLayout = ImageLayout.None
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button4.Location = New Point(897, 442)
        Button4.Name = "Button4"
        Button4.Size = New Size(143, 45)
        Button4.TabIndex = 15
        Button4.Text = "Tạo lịch thi"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button5.BackgroundImageLayout = ImageLayout.None
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button5.Location = New Point(1060, 442)
        Button5.Name = "Button5"
        Button5.Size = New Size(143, 45)
        Button5.TabIndex = 16
        Button5.Text = "Thay Đổi Lịch Thi"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.Blue
        Label6.Location = New Point(12, 112)
        Label6.Name = "Label6"
        Label6.Size = New Size(138, 20)
        Label6.TabIndex = 17
        Label6.Text = "Tìm Kiếm Lịch Thi:"
        ' 
        ' ExamSchedule
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1297, 649)
        Controls.Add(Label6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents clnMMH As DataGridViewTextBoxColumn
    Friend WithEvents clnMon As DataGridViewTextBoxColumn
    Friend WithEvents clnLop As DataGridViewTextBoxColumn
    Friend WithEvents clnNgayThi As DataGridViewTextBoxColumn
    Friend WithEvents clnPhong As DataGridViewTextBoxColumn
End Class
