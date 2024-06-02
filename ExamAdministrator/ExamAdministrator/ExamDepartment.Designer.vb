<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamDepartment))
        btnchinhsua = New Button()
        btnxoa = New Button()
        btnthem = New Button()
        txttkhoa = New TextBox()
        txtmakhoa = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        DGVKhoa = New DataGridView()
        MenuStrip1 = New MenuStrip()
        btnExit = New ToolStripMenuItem()
        CType(DGVKhoa, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnchinhsua
        ' 
        btnchinhsua.BackColor = SystemColors.GradientActiveCaption
        btnchinhsua.FlatStyle = FlatStyle.Flat
        btnchinhsua.Location = New Point(75, 351)
        btnchinhsua.Name = "btnchinhsua"
        btnchinhsua.Size = New Size(339, 44)
        btnchinhsua.TabIndex = 22
        btnchinhsua.Text = "Chỉnh Sửa Khoa"
        btnchinhsua.UseVisualStyleBackColor = False
        ' 
        ' btnxoa
        ' 
        btnxoa.BackColor = SystemColors.GradientActiveCaption
        btnxoa.FlatStyle = FlatStyle.Flat
        btnxoa.Location = New Point(271, 287)
        btnxoa.Name = "btnxoa"
        btnxoa.Size = New Size(143, 44)
        btnxoa.TabIndex = 21
        btnxoa.Text = "Xoá Khoa"
        btnxoa.UseVisualStyleBackColor = False
        ' 
        ' btnthem
        ' 
        btnthem.BackColor = SystemColors.GradientActiveCaption
        btnthem.FlatStyle = FlatStyle.Flat
        btnthem.Location = New Point(75, 287)
        btnthem.Name = "btnthem"
        btnthem.Size = New Size(143, 44)
        btnthem.TabIndex = 20
        btnthem.Text = "Thêm Khoa"
        btnthem.UseVisualStyleBackColor = False
        ' 
        ' txttkhoa
        ' 
        txttkhoa.Location = New Point(75, 219)
        txttkhoa.Name = "txttkhoa"
        txttkhoa.Size = New Size(339, 27)
        txttkhoa.TabIndex = 19
        ' 
        ' txtmakhoa
        ' 
        txtmakhoa.Location = New Point(75, 133)
        txtmakhoa.Name = "txtmakhoa"
        txtmakhoa.Size = New Size(339, 27)
        txtmakhoa.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(75, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 23)
        Label4.TabIndex = 17
        Label4.Text = "Tên Khoa:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Highlight
        Label3.Location = New Point(77, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 23)
        Label3.TabIndex = 16
        Label3.Text = "Mã Khoa:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.ForeColor = Color.Coral
        Label1.Location = New Point(403, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 32)
        Label1.TabIndex = 14
        Label1.Text = "Thông Tin Khoa"
        ' 
        ' DGVKhoa
        ' 
        DGVKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVKhoa.Location = New Point(507, 109)
        DGVKhoa.Name = "DGVKhoa"
        DGVKhoa.ReadOnly = True
        DGVKhoa.RowHeadersWidth = 51
        DGVKhoa.Size = New Size(425, 285)
        DGVKhoa.TabIndex = 13
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnExit})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(1010, 30)
        MenuStrip1.TabIndex = 23
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnExit
        ' 
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(61, 24)
        btnExit.Text = "Thoát"
        ' 
        ' ExamDepartment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1010, 444)
        Controls.Add(btnchinhsua)
        Controls.Add(btnxoa)
        Controls.Add(btnthem)
        Controls.Add(txttkhoa)
        Controls.Add(txtmakhoa)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(DGVKhoa)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "ExamDepartment"
        Text = "Exam Administrator - Departments"
        CType(DGVKhoa, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnchinhsua As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents btnthem As Button
    Friend WithEvents txttkhoa As TextBox
    Friend WithEvents txtmakhoa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVKhoa As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnExit As ToolStripMenuItem
End Class
