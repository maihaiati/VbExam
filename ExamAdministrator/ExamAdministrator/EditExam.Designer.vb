<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditExam
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
		btnExit = New Button()
		btnDelete = New Button()
		txtMaDe = New TextBox()
		Label2 = New Label()
		Label1 = New Label()
		btnEdit = New Button()
		cbbMaKhoa = New ComboBox()
		cbbMaMonHoc = New ComboBox()
		cbAnHien = New CheckBox()
		Label7 = New Label()
		Label6 = New Label()
		numMinute = New NumericUpDown()
		Label5 = New Label()
		txtTenDe = New TextBox()
		Label4 = New Label()
		Label3 = New Label()
		CType(numMinute, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' btnExit
		' 
		btnExit.Location = New Point(301, 265)
		btnExit.Name = "btnExit"
		btnExit.Size = New Size(96, 39)
		btnExit.TabIndex = 17
		btnExit.Text = "Thoát"
		btnExit.UseVisualStyleBackColor = True
		' 
		' btnDelete
		' 
		btnDelete.Location = New Point(172, 265)
		btnDelete.Name = "btnDelete"
		btnDelete.Size = New Size(96, 39)
		btnDelete.TabIndex = 16
		btnDelete.Text = "Xoá đề thi"
		btnDelete.UseVisualStyleBackColor = True
		' 
		' txtMaDe
		' 
		txtMaDe.Location = New Point(151, 70)
		txtMaDe.Name = "txtMaDe"
		txtMaDe.ReadOnly = True
		txtMaDe.Size = New Size(246, 23)
		txtMaDe.TabIndex = 13
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(37, 74)
		Label2.Name = "Label2"
		Label2.Size = New Size(57, 15)
		Label2.TabIndex = 10
		Label2.Text = "Mã đề thi"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		Label1.Location = New Point(100, 9)
		Label1.Name = "Label1"
		Label1.Size = New Size(234, 37)
		Label1.TabIndex = 9
		Label1.Text = "Chỉnh Sửa Đề Thi"
		' 
		' btnEdit
		' 
		btnEdit.Location = New Point(37, 265)
		btnEdit.Name = "btnEdit"
		btnEdit.Size = New Size(96, 39)
		btnEdit.TabIndex = 18
		btnEdit.Text = "Sửa đề thi"
		btnEdit.UseVisualStyleBackColor = True
		' 
		' cbbMaKhoa
		' 
		cbbMaKhoa.FormattingEnabled = True
		cbbMaKhoa.Location = New Point(151, 132)
		cbbMaKhoa.Name = "cbbMaKhoa"
		cbbMaKhoa.Size = New Size(246, 23)
		cbbMaKhoa.TabIndex = 28
		' 
		' cbbMaMonHoc
		' 
		cbbMaMonHoc.FormattingEnabled = True
		cbbMaMonHoc.Location = New Point(151, 99)
		cbbMaMonHoc.Name = "cbbMaMonHoc"
		cbbMaMonHoc.Size = New Size(246, 23)
		cbbMaMonHoc.TabIndex = 27
		' 
		' cbAnHien
		' 
		cbAnHien.AutoSize = True
		cbAnHien.Location = New Point(151, 226)
		cbAnHien.Name = "cbAnHien"
		cbAnHien.Size = New Size(41, 19)
		cbAnHien.TabIndex = 26
		cbAnHien.Text = "Ẩn"
		cbAnHien.UseVisualStyleBackColor = True
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Location = New Point(37, 227)
		Label7.Name = "Label7"
		Label7.Size = New Size(81, 15)
		Label7.TabIndex = 25
		Label7.Text = "Ẩn hiện đề thi"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Location = New Point(37, 135)
		Label6.Name = "Label6"
		Label6.Size = New Size(53, 15)
		Label6.TabIndex = 24
		Label6.Text = "Mã khoa"
		' 
		' numMinute
		' 
		numMinute.Location = New Point(151, 197)
		numMinute.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		numMinute.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		numMinute.Name = "numMinute"
		numMinute.Size = New Size(246, 23)
		numMinute.TabIndex = 23
		numMinute.Value = New Decimal(New Integer() {1, 0, 0, 0})
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(37, 198)
		Label5.Name = "Label5"
		Label5.Size = New Size(92, 15)
		Label5.TabIndex = 22
		Label5.Text = "Thời gian (phút)"
		' 
		' txtTenDe
		' 
		txtTenDe.Enabled = False
		txtTenDe.Location = New Point(151, 167)
		txtTenDe.Name = "txtTenDe"
		txtTenDe.ReadOnly = True
		txtTenDe.Size = New Size(246, 23)
		txtTenDe.TabIndex = 21
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(37, 169)
		Label4.Name = "Label4"
		Label4.Size = New Size(58, 15)
		Label4.TabIndex = 20
		Label4.Text = "Tên đề thi"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(37, 102)
		Label3.Name = "Label3"
		Label3.Size = New Size(75, 15)
		Label3.TabIndex = 19
		Label3.Text = "Mã môn học"
		' 
		' EditExam
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(438, 321)
		Controls.Add(cbbMaKhoa)
		Controls.Add(cbbMaMonHoc)
		Controls.Add(cbAnHien)
		Controls.Add(Label7)
		Controls.Add(Label6)
		Controls.Add(numMinute)
		Controls.Add(Label5)
		Controls.Add(txtTenDe)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(btnEdit)
		Controls.Add(btnExit)
		Controls.Add(btnDelete)
		Controls.Add(txtMaDe)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Margin = New Padding(3, 2, 3, 2)
		Name = "EditExam"
		Text = "EditExam"
		CType(numMinute, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtMaDe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEdit As Button
	Friend WithEvents cbbMaKhoa As ComboBox
	Friend WithEvents cbbMaMonHoc As ComboBox
	Friend WithEvents cbAnHien As CheckBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents numMinute As NumericUpDown
	Friend WithEvents Label5 As Label
	Friend WithEvents txtTenDe As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
End Class
