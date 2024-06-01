<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoAccount
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
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		Label6 = New Label()
		Label7 = New Label()
		picture = New PictureBox()
		txtMsv = New TextBox()
		txtHoTen = New TextBox()
		txtLop = New TextBox()
		dtpNgaySinh = New DateTimePicker()
		cbbGioiTinh = New ComboBox()
		Label1 = New Label()
		Label8 = New Label()
		btnUpdate = New Button()
		btnExit = New Button()
		Label9 = New Label()
		Label10 = New Label()
		cbbKhoa = New ComboBox()
		CType(picture, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = SystemColors.Control
		Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
		Label2.ForeColor = Color.Blue
		Label2.Location = New Point(307, 88)
		Label2.Name = "Label2"
		Label2.Size = New Size(91, 15)
		Label2.TabIndex = 3
		Label2.Text = "MÃ SINH VIÊN:"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = SystemColors.Control
		Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
		Label3.ForeColor = Color.Blue
		Label3.Location = New Point(307, 125)
		Label3.Name = "Label3"
		Label3.Size = New Size(53, 15)
		Label3.TabIndex = 4
		Label3.Text = "HỌ TÊN:"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = SystemColors.Control
		Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
		Label4.ForeColor = Color.Blue
		Label4.Location = New Point(307, 163)
		Label4.Name = "Label4"
		Label4.Size = New Size(74, 15)
		Label4.TabIndex = 5
		Label4.Text = "NGÀY SINH:"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = SystemColors.Control
		Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
		Label5.ForeColor = Color.Blue
		Label5.Location = New Point(307, 200)
		Label5.Name = "Label5"
		Label5.Size = New Size(68, 15)
		Label5.TabIndex = 6
		Label5.Text = "GIỚI TÍNH:"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.BackColor = SystemColors.Control
		Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
		Label6.ForeColor = Color.Blue
		Label6.Location = New Point(307, 238)
		Label6.Name = "Label6"
		Label6.Size = New Size(32, 15)
		Label6.TabIndex = 7
		Label6.Text = "LỚP:"
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.BackColor = SystemColors.Control
		Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
		Label7.ForeColor = Color.Blue
		Label7.Location = New Point(307, 275)
		Label7.Name = "Label7"
		Label7.Size = New Size(44, 15)
		Label7.TabIndex = 8
		Label7.Text = "KHOA:"
		' 
		' picture
		' 
		picture.BackColor = SystemColors.ControlDark
		picture.Location = New Point(34, 74)
		picture.Margin = New Padding(3, 2, 3, 2)
		picture.Name = "picture"
		picture.Size = New Size(220, 242)
		picture.SizeMode = PictureBoxSizeMode.Zoom
		picture.TabIndex = 9
		picture.TabStop = False
		' 
		' txtMsv
		' 
		txtMsv.Enabled = False
		txtMsv.Location = New Point(429, 86)
		txtMsv.Margin = New Padding(3, 2, 3, 2)
		txtMsv.Name = "txtMsv"
		txtMsv.Size = New Size(220, 23)
		txtMsv.TabIndex = 10
		' 
		' txtHoTen
		' 
		txtHoTen.Location = New Point(429, 125)
		txtHoTen.Margin = New Padding(3, 2, 3, 2)
		txtHoTen.Name = "txtHoTen"
		txtHoTen.Size = New Size(220, 23)
		txtHoTen.TabIndex = 11
		' 
		' txtLop
		' 
		txtLop.Location = New Point(429, 238)
		txtLop.Margin = New Padding(3, 2, 3, 2)
		txtLop.Name = "txtLop"
		txtLop.Size = New Size(220, 23)
		txtLop.TabIndex = 12
		' 
		' dtpNgaySinh
		' 
		dtpNgaySinh.Format = DateTimePickerFormat.Short
		dtpNgaySinh.Location = New Point(429, 159)
		dtpNgaySinh.Margin = New Padding(3, 2, 3, 2)
		dtpNgaySinh.Name = "dtpNgaySinh"
		dtpNgaySinh.Size = New Size(133, 23)
		dtpNgaySinh.TabIndex = 14
		' 
		' cbbGioiTinh
		' 
		cbbGioiTinh.FormattingEnabled = True
		cbbGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ"})
		cbbGioiTinh.Location = New Point(429, 198)
		cbbGioiTinh.Margin = New Padding(3, 2, 3, 2)
		cbbGioiTinh.Name = "cbbGioiTinh"
		cbbGioiTinh.Size = New Size(133, 23)
		cbbGioiTinh.TabIndex = 15
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = Color.IndianRed
		Label1.Location = New Point(282, 21)
		Label1.Name = "Label1"
		Label1.Size = New Size(179, 23)
		Label1.TabIndex = 16
		Label1.Text = "Thông Tin Sinh Viên"
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Font = New Font("Segoe UI", 9.5F)
		Label8.Location = New Point(154, 346)
		Label8.Name = "Label8"
		Label8.Size = New Size(307, 17)
		Label8.TabIndex = 17
		Label8.Text = "Bạn xác minh và cập nhật đầy đủ thông tin cá nhân." & vbCrLf
		' 
		' btnUpdate
		' 
		btnUpdate.Location = New Point(163, 401)
		btnUpdate.Margin = New Padding(3, 2, 3, 2)
		btnUpdate.Name = "btnUpdate"
		btnUpdate.Size = New Size(150, 39)
		btnUpdate.TabIndex = 18
		btnUpdate.Text = "Cập Nhật"
		btnUpdate.UseVisualStyleBackColor = True
		' 
		' btnExit
		' 
		btnExit.Location = New Point(442, 401)
		btnExit.Margin = New Padding(3, 2, 3, 2)
		btnExit.Name = "btnExit"
		btnExit.Size = New Size(150, 39)
		btnExit.TabIndex = 19
		btnExit.Text = "Thoát"
		btnExit.UseVisualStyleBackColor = True
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.Font = New Font("Segoe UI", 9.5F)
		Label9.Location = New Point(154, 363)
		Label9.Name = "Label9"
		Label9.Size = New Size(515, 17)
		Label9.TabIndex = 20
		Label9.Text = "Trong trường hợp mất mật khẩu hãy báo cho phòng kĩ thuật để được cấp lại mật khẩu."
		' 
		' Label10
		' 
		Label10.AutoSize = True
		Label10.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
		Label10.ForeColor = Color.Red
		Label10.Location = New Point(81, 346)
		Label10.Name = "Label10"
		Label10.Size = New Size(62, 25)
		Label10.TabIndex = 21
		Label10.Text = "Lưu ý"
		' 
		' cbbKhoa
		' 
		cbbKhoa.FormattingEnabled = True
		cbbKhoa.Location = New Point(429, 272)
		cbbKhoa.Name = "cbbKhoa"
		cbbKhoa.Size = New Size(220, 23)
		cbbKhoa.TabIndex = 22
		' 
		' InfoAccount
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(757, 459)
		Controls.Add(cbbKhoa)
		Controls.Add(Label10)
		Controls.Add(Label9)
		Controls.Add(btnExit)
		Controls.Add(btnUpdate)
		Controls.Add(Label8)
		Controls.Add(Label1)
		Controls.Add(cbbGioiTinh)
		Controls.Add(dtpNgaySinh)
		Controls.Add(txtLop)
		Controls.Add(txtHoTen)
		Controls.Add(txtMsv)
		Controls.Add(picture)
		Controls.Add(Label7)
		Controls.Add(Label6)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Name = "InfoAccount"
		Text = "ExamStudent - InfoAccount"
		CType(picture, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents picture As PictureBox
    Friend WithEvents txtMsv As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtLop As TextBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents cbbGioiTinh As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
	Friend WithEvents cbbKhoa As ComboBox
End Class
