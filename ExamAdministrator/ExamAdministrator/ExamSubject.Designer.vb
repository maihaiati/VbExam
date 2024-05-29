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
        CType(DGVMonhoc, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGVMonhoc
        ' 
        DGVMonhoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVMonhoc.Location = New Point(39, 141)
        DGVMonhoc.Name = "DGVMonhoc"
        DGVMonhoc.RowHeadersWidth = 51
        DGVMonhoc.Size = New Size(556, 365)
        DGVMonhoc.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.ForeColor = Color.Coral
        Label1.Location = New Point(385, 23)
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
        Label3.Location = New Point(633, 138)
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
        Label4.Location = New Point(631, 222)
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
        btnthem.Location = New Point(631, 397)
        btnthem.Name = "btnthem"
        btnthem.Size = New Size(156, 44)
        btnthem.TabIndex = 7
        btnthem.Text = "Thêm Môn Học"
        btnthem.UseVisualStyleBackColor = False
        ' 
        ' btnxoa
        ' 
        btnxoa.BackColor = SystemColors.GradientActiveCaption
        btnxoa.FlatStyle = FlatStyle.Flat
        btnxoa.Location = New Point(826, 397)
        btnxoa.Name = "btnxoa"
        btnxoa.Size = New Size(156, 44)
        btnxoa.TabIndex = 8
        btnxoa.Text = "Xoá Môn Học"
        btnxoa.UseVisualStyleBackColor = False
        ' 
        ' btnchinhsua
        ' 
        btnchinhsua.BackColor = SystemColors.GradientActiveCaption
        btnchinhsua.FlatStyle = FlatStyle.Flat
        btnchinhsua.Location = New Point(631, 462)
        btnchinhsua.Name = "btnchinhsua"
        btnchinhsua.Size = New Size(351, 44)
        btnchinhsua.TabIndex = 9
        btnchinhsua.Text = "Chỉnh Sủa Môn Học"
        btnchinhsua.UseVisualStyleBackColor = False
        ' 
        ' txttimkiem
        ' 
        txttimkiem.Location = New Point(132, 82)
        txttimkiem.Name = "txttimkiem"
        txttimkiem.Size = New Size(157, 27)
        txttimkiem.TabIndex = 10
        ' 
        ' txtsotiet
        ' 
        txtsotiet.Location = New Point(631, 327)
        txtsotiet.Name = "txtsotiet"
        txtsotiet.Size = New Size(351, 27)
        txtsotiet.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.Highlight
        Label5.Location = New Point(631, 301)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 23)
        Label5.TabIndex = 11
        Label5.Text = "Số tiết:"
        ' 
        ' ExamSubject
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1053, 539)
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
        Name = "ExamSubject"
        Text = "ExamSubject"
        CType(DGVMonhoc, ComponentModel.ISupportInitialize).EndInit()
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
End Class
