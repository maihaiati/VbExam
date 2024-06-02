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
        btnthoat = New ToolStripMenuItem()
        btnMe = New ToolStripMenuItem()
        txtmakhoa = New TextBox()
        Label6 = New Label()
        CType(DGVMonhoc, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGVMonhoc
        ' 
        DGVMonhoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVMonhoc.Location = New Point(39, 141)
        DGVMonhoc.Name = "DGVMonhoc"
        DGVMonhoc.ReadOnly = True
        DGVMonhoc.RowHeadersWidth = 51
        DGVMonhoc.Size = New Size(555, 435)
        DGVMonhoc.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.ForeColor = Color.Coral
        Label1.Location = New Point(392, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 32)
        Label1.TabIndex = 1
        Label1.Text = "Thông Tin Môn Học"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Highlight
        Label2.Location = New Point(39, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 23)
        Label2.TabIndex = 2
        Label2.Text = "Tìm Kiếm: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Highlight
        Label3.Location = New Point(633, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 23)
        Label3.TabIndex = 3
        Label3.Text = "Mã Môn Học:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(631, 221)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 23)
        Label4.TabIndex = 4
        Label4.Text = "Tên Môn Học:"
        ' 
        ' txtmamh
        ' 
        txtmamh.Location = New Point(631, 164)
        txtmamh.Name = "txtmamh"
        txtmamh.Size = New Size(351, 27)
        txtmamh.TabIndex = 5
        ' 
        ' txttmh
        ' 
        txttmh.Location = New Point(631, 248)
        txttmh.Name = "txttmh"
        txttmh.Size = New Size(351, 27)
        txttmh.TabIndex = 6
        ' 
        ' btnthem
        ' 
        btnthem.BackColor = SystemColors.GradientActiveCaption
        btnthem.FlatStyle = FlatStyle.Flat
        btnthem.Location = New Point(632, 468)
        btnthem.Name = "btnthem"
        btnthem.Size = New Size(155, 44)
        btnthem.TabIndex = 7
        btnthem.Text = "Thêm Môn Học"
        btnthem.UseVisualStyleBackColor = False
        ' 
        ' btnxoa
        ' 
        btnxoa.BackColor = SystemColors.GradientActiveCaption
        btnxoa.FlatStyle = FlatStyle.Flat
        btnxoa.Location = New Point(827, 468)
        btnxoa.Name = "btnxoa"
        btnxoa.Size = New Size(155, 44)
        btnxoa.TabIndex = 8
        btnxoa.Text = "Xoá Môn Học"
        btnxoa.UseVisualStyleBackColor = False
        ' 
        ' btnchinhsua
        ' 
        btnchinhsua.BackColor = SystemColors.GradientActiveCaption
        btnchinhsua.FlatStyle = FlatStyle.Flat
        btnchinhsua.Location = New Point(632, 532)
        btnchinhsua.Name = "btnchinhsua"
        btnchinhsua.Size = New Size(351, 44)
        btnchinhsua.TabIndex = 9
        btnchinhsua.Text = "Chỉnh Sửa Môn Học"
        btnchinhsua.UseVisualStyleBackColor = False
        ' 
        ' txttimkiem
        ' 
        txttimkiem.Location = New Point(133, 83)
        txttimkiem.Name = "txttimkiem"
        txttimkiem.Size = New Size(157, 27)
        txttimkiem.TabIndex = 10
        ' 
        ' txtsotiet
        ' 
        txtsotiet.Location = New Point(631, 405)
        txtsotiet.Name = "txtsotiet"
        txtsotiet.Size = New Size(351, 27)
        txtsotiet.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.Highlight
        Label5.Location = New Point(631, 379)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 23)
        Label5.TabIndex = 11
        Label5.Text = "Số tiết:"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ThoátToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(117, 28)
        ' 
        ' ThoátToolStripMenuItem
        ' 
        ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        ThoátToolStripMenuItem.Size = New Size(116, 24)
        ThoátToolStripMenuItem.Text = "Thoát"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnthoat, btnMe})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(1053, 30)
        MenuStrip1.TabIndex = 14
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnthoat
        ' 
        btnthoat.Name = "btnthoat"
        btnthoat.Size = New Size(61, 24)
        btnthoat.Text = "Thoát"
        ' 
        ' btnMe
        ' 
        btnMe.Alignment = ToolStripItemAlignment.Right
        btnMe.Name = "btnMe"
        btnMe.Size = New Size(27, 24)
        btnMe.Text = " "
        ' 
        ' txtmakhoa
        ' 
        txtmakhoa.Location = New Point(631, 332)
        txtmakhoa.Name = "txtmakhoa"
        txtmakhoa.Size = New Size(351, 27)
        txtmakhoa.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.Highlight
        Label6.Location = New Point(631, 305)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 23)
        Label6.TabIndex = 15
        Label6.Text = "Mã Khoa:"
        ' 
        ' ExamSubject
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1053, 596)
        Controls.Add(txtmakhoa)
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
    Friend WithEvents btnthoat As ToolStripMenuItem
	Friend WithEvents btnMe As ToolStripMenuItem
    Friend WithEvents txtmakhoa As TextBox
    Friend WithEvents Label6 As Label
End Class
