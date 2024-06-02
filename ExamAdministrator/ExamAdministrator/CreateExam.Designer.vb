<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateExam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateExam))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtMaDe = New TextBox()
        txtTenDe = New TextBox()
        btnCreate = New Button()
        btnExit = New Button()
        Label5 = New Label()
        numMinute = New NumericUpDown()
        Label6 = New Label()
        Label7 = New Label()
        cbAnHien = New CheckBox()
        cbbMaMonHoc = New ComboBox()
        cbbMaKhoa = New ComboBox()
        CType(numMinute, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.Location = New Point(178, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 46)
        Label1.TabIndex = 0
        Label1.Text = "Tạo Đề Thi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 1
        Label2.Text = "Mã đề thi"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 20)
        Label3.TabIndex = 2
        Label3.Text = "Mã môn học"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 221)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 20)
        Label4.TabIndex = 3
        Label4.Text = "Tên đề thi"
        ' 
        ' txtMaDe
        ' 
        txtMaDe.Location = New Point(190, 89)
        txtMaDe.Margin = New Padding(3, 4, 3, 4)
        txtMaDe.Name = "txtMaDe"
        txtMaDe.Size = New Size(281, 27)
        txtMaDe.TabIndex = 4
        ' 
        ' txtTenDe
        ' 
        txtTenDe.Location = New Point(190, 219)
        txtTenDe.Margin = New Padding(3, 4, 3, 4)
        txtTenDe.Name = "txtTenDe"
        txtTenDe.ReadOnly = True
        txtTenDe.Size = New Size(281, 27)
        txtTenDe.TabIndex = 6
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(133, 363)
        btnCreate.Margin = New Padding(3, 4, 3, 4)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(110, 52)
        btnCreate.TabIndex = 7
        btnCreate.Text = "Tạo đề"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(299, 363)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(110, 52)
        btnExit.TabIndex = 8
        btnExit.Text = "Thoát"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(59, 260)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 20)
        Label5.TabIndex = 10
        Label5.Text = "Thời gian (phút)"
        ' 
        ' numMinute
        ' 
        numMinute.Location = New Point(190, 259)
        numMinute.Margin = New Padding(3, 4, 3, 4)
        numMinute.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        numMinute.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numMinute.Name = "numMinute"
        numMinute.Size = New Size(281, 27)
        numMinute.TabIndex = 11
        numMinute.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(59, 176)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 20)
        Label6.TabIndex = 12
        Label6.Text = "Mã khoa"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(59, 299)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 20)
        Label7.TabIndex = 14
        Label7.Text = "Ẩn hiện đề thi"
        ' 
        ' cbAnHien
        ' 
        cbAnHien.AutoSize = True
        cbAnHien.Location = New Point(190, 297)
        cbAnHien.Margin = New Padding(3, 4, 3, 4)
        cbAnHien.Name = "cbAnHien"
        cbAnHien.Size = New Size(49, 24)
        cbAnHien.TabIndex = 15
        cbAnHien.Text = "Ẩn"
        cbAnHien.UseVisualStyleBackColor = True
        ' 
        ' cbbMaMonHoc
        ' 
        cbbMaMonHoc.FormattingEnabled = True
        cbbMaMonHoc.Location = New Point(190, 128)
        cbbMaMonHoc.Margin = New Padding(3, 4, 3, 4)
        cbbMaMonHoc.Name = "cbbMaMonHoc"
        cbbMaMonHoc.Size = New Size(281, 28)
        cbbMaMonHoc.TabIndex = 16
        ' 
        ' cbbMaKhoa
        ' 
        cbbMaKhoa.FormattingEnabled = True
        cbbMaKhoa.Location = New Point(190, 172)
        cbbMaKhoa.Margin = New Padding(3, 4, 3, 4)
        cbbMaKhoa.Name = "cbbMaKhoa"
        cbbMaKhoa.Size = New Size(281, 28)
        cbbMaKhoa.TabIndex = 17
        ' 
        ' CreateExam
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(543, 433)
        Controls.Add(cbbMaKhoa)
        Controls.Add(cbbMaMonHoc)
        Controls.Add(cbAnHien)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(numMinute)
        Controls.Add(Label5)
        Controls.Add(btnExit)
        Controls.Add(btnCreate)
        Controls.Add(txtTenDe)
        Controls.Add(txtMaDe)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "CreateExam"
        Text = "Exam Administrator - Create Exam"
        CType(numMinute, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtMaDe As TextBox
	Friend WithEvents txtTenDe As TextBox
	Friend WithEvents btnCreate As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents numMinute As NumericUpDown
    Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents cbAnHien As CheckBox
	Friend WithEvents cbbMaMonHoc As ComboBox
	Friend WithEvents cbbMaKhoa As ComboBox
End Class
