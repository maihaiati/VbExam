<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoTest
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
		txtQues = New RichTextBox()
		btnA = New Button()
		btnB = New Button()
		btnC = New Button()
		btnD = New Button()
		btnPrevious = New Button()
		btnNext = New Button()
		Label1 = New Label()
		cbbQues = New ComboBox()
		picture = New PictureBox()
		Label2 = New Label()
		lblMsv = New Label()
		lblHoTen = New Label()
		lblLop = New Label()
		lblNgaySinh = New Label()
		lblGioiTinh = New Label()
		Timer = New Timer(components)
		Label3 = New Label()
		lblTienTrinh = New Label()
		lblThoiGian = New Label()
		Label6 = New Label()
		lblTenDeThi = New Label()
		lblSoCau = New Label()
		lblSoPhut = New Label()
		btnSubmit = New Button()
		CType(picture, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' txtQues
		' 
		txtQues.Font = New Font("Segoe UI", 12F)
		txtQues.Location = New Point(250, 12)
		txtQues.Name = "txtQues"
		txtQues.Size = New Size(756, 587)
		txtQues.TabIndex = 0
		txtQues.Text = ""
		' 
		' btnA
		' 
		btnA.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		btnA.Location = New Point(12, 614)
		btnA.Name = "btnA"
		btnA.Size = New Size(113, 49)
		btnA.TabIndex = 1
		btnA.Text = "A"
		btnA.UseVisualStyleBackColor = True
		' 
		' btnB
		' 
		btnB.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		btnB.Location = New Point(131, 614)
		btnB.Name = "btnB"
		btnB.Size = New Size(113, 49)
		btnB.TabIndex = 2
		btnB.Text = "B"
		btnB.UseVisualStyleBackColor = True
		' 
		' btnC
		' 
		btnC.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		btnC.Location = New Point(250, 614)
		btnC.Name = "btnC"
		btnC.Size = New Size(113, 49)
		btnC.TabIndex = 3
		btnC.Text = "C"
		btnC.UseVisualStyleBackColor = True
		' 
		' btnD
		' 
		btnD.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		btnD.Location = New Point(369, 614)
		btnD.Name = "btnD"
		btnD.Size = New Size(113, 49)
		btnD.TabIndex = 4
		btnD.Text = "D"
		btnD.UseVisualStyleBackColor = True
		' 
		' btnPrevious
		' 
		btnPrevious.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
		btnPrevious.Location = New Point(655, 614)
		btnPrevious.Name = "btnPrevious"
		btnPrevious.Size = New Size(113, 49)
		btnPrevious.TabIndex = 5
		btnPrevious.Text = "Câu trước"
		btnPrevious.UseVisualStyleBackColor = True
		' 
		' btnNext
		' 
		btnNext.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
		btnNext.Location = New Point(774, 614)
		btnNext.Name = "btnNext"
		btnNext.Size = New Size(113, 49)
		btnNext.TabIndex = 6
		btnNext.Text = "Câu kế tiếp"
		btnNext.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
		Label1.Location = New Point(512, 614)
		Label1.Name = "Label1"
		Label1.Size = New Size(73, 20)
		Label1.TabIndex = 7
		Label1.Text = "Chọn câu"
		' 
		' cbbQues
		' 
		cbbQues.FormattingEnabled = True
		cbbQues.Location = New Point(512, 640)
		cbbQues.Name = "cbbQues"
		cbbQues.Size = New Size(121, 23)
		cbbQues.TabIndex = 8
		' 
		' picture
		' 
		picture.Location = New Point(12, 12)
		picture.Name = "picture"
		picture.Size = New Size(232, 285)
		picture.SizeMode = PictureBoxSizeMode.Zoom
		picture.TabIndex = 10
		picture.TabStop = False
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(22, 381)
		Label2.Name = "Label2"
		Label2.Size = New Size(212, 15)
		Label2.TabIndex = 11
		Label2.Text = "_________________________________________"
		' 
		' lblMsv
		' 
		lblMsv.AutoSize = True
		lblMsv.Location = New Point(12, 404)
		lblMsv.Name = "lblMsv"
		lblMsv.Size = New Size(80, 15)
		lblMsv.TabIndex = 12
		lblMsv.Text = "Mã sinh viên: "
		' 
		' lblHoTen
		' 
		lblHoTen.AutoSize = True
		lblHoTen.Location = New Point(12, 429)
		lblHoTen.Name = "lblHoTen"
		lblHoTen.Size = New Size(64, 15)
		lblHoTen.TabIndex = 13
		lblHoTen.Text = "Họ và tên: "
		' 
		' lblLop
		' 
		lblLop.AutoSize = True
		lblLop.Location = New Point(12, 479)
		lblLop.Name = "lblLop"
		lblLop.Size = New Size(33, 15)
		lblLop.TabIndex = 14
		lblLop.Text = "Lớp: "
		' 
		' lblNgaySinh
		' 
		lblNgaySinh.AutoSize = True
		lblNgaySinh.Location = New Point(12, 454)
		lblNgaySinh.Name = "lblNgaySinh"
		lblNgaySinh.Size = New Size(63, 15)
		lblNgaySinh.TabIndex = 15
		lblNgaySinh.Text = "Ngày sinh:"
		' 
		' lblGioiTinh
		' 
		lblGioiTinh.AutoSize = True
		lblGioiTinh.Location = New Point(12, 504)
		lblGioiTinh.Name = "lblGioiTinh"
		lblGioiTinh.Size = New Size(58, 15)
		lblGioiTinh.TabIndex = 16
		lblGioiTinh.Text = "Giới tính: "
		' 
		' Timer
		' 
		Timer.Interval = 1000
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(22, 516)
		Label3.Name = "Label3"
		Label3.Size = New Size(212, 15)
		Label3.TabIndex = 17
		Label3.Text = "_________________________________________"
		' 
		' lblTienTrinh
		' 
		lblTienTrinh.AutoSize = True
		lblTienTrinh.Location = New Point(12, 544)
		lblTienTrinh.Name = "lblTienTrinh"
		lblTienTrinh.Size = New Size(87, 15)
		lblTienTrinh.TabIndex = 18
		lblTienTrinh.Text = "Số câu đã làm: "
		' 
		' lblThoiGian
		' 
		lblThoiGian.AutoSize = True
		lblThoiGian.Location = New Point(12, 568)
		lblThoiGian.Name = "lblThoiGian"
		lblThoiGian.Size = New Size(100, 15)
		lblThoiGian.TabIndex = 19
		lblThoiGian.Text = "Thời gian còn lại: "
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Location = New Point(22, 299)
		Label6.Name = "Label6"
		Label6.Size = New Size(212, 15)
		Label6.TabIndex = 20
		Label6.Text = "_________________________________________"
		' 
		' lblTenDeThi
		' 
		lblTenDeThi.AutoSize = True
		lblTenDeThi.Location = New Point(12, 323)
		lblTenDeThi.Name = "lblTenDeThi"
		lblTenDeThi.Size = New Size(64, 15)
		lblTenDeThi.TabIndex = 21
		lblTenDeThi.Text = "Tên đề thi: "
		' 
		' lblSoCau
		' 
		lblSoCau.AutoSize = True
		lblSoCau.Location = New Point(12, 347)
		lblSoCau.Name = "lblSoCau"
		lblSoCau.Size = New Size(48, 15)
		lblSoCau.TabIndex = 22
		lblSoCau.Text = "Số câu: "
		' 
		' lblSoPhut
		' 
		lblSoPhut.AutoSize = True
		lblSoPhut.Location = New Point(12, 372)
		lblSoPhut.Name = "lblSoPhut"
		lblSoPhut.Size = New Size(54, 15)
		lblSoPhut.TabIndex = 23
		lblSoPhut.Text = "Số phút: "
		' 
		' btnSubmit
		' 
		btnSubmit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
		btnSubmit.Location = New Point(893, 614)
		btnSubmit.Name = "btnSubmit"
		btnSubmit.Size = New Size(113, 49)
		btnSubmit.TabIndex = 24
		btnSubmit.Text = "Nộp bài"
		btnSubmit.UseVisualStyleBackColor = True
		' 
		' DoTest
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(1020, 677)
		Controls.Add(btnSubmit)
		Controls.Add(lblSoPhut)
		Controls.Add(lblSoCau)
		Controls.Add(lblTenDeThi)
		Controls.Add(Label6)
		Controls.Add(lblThoiGian)
		Controls.Add(lblTienTrinh)
		Controls.Add(Label3)
		Controls.Add(lblGioiTinh)
		Controls.Add(lblNgaySinh)
		Controls.Add(lblLop)
		Controls.Add(lblHoTen)
		Controls.Add(lblMsv)
		Controls.Add(Label2)
		Controls.Add(picture)
		Controls.Add(cbbQues)
		Controls.Add(Label1)
		Controls.Add(btnNext)
		Controls.Add(btnPrevious)
		Controls.Add(btnD)
		Controls.Add(btnC)
		Controls.Add(btnB)
		Controls.Add(btnA)
		Controls.Add(txtQues)
		Name = "DoTest"
		Text = "Exam Student"
		CType(picture, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents txtQues As RichTextBox
	Friend WithEvents btnA As Button
	Friend WithEvents btnB As Button
	Friend WithEvents btnC As Button
	Friend WithEvents btnD As Button
	Friend WithEvents btnPrevious As Button
	Friend WithEvents btnNext As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents cbbQues As ComboBox
	Friend WithEvents picture As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents lblMsv As Label
	Friend WithEvents lblHoTen As Label
	Friend WithEvents lblLop As Label
	Friend WithEvents lblNgaySinh As Label
	Friend WithEvents lblGioiTinh As Label
	Friend WithEvents Timer As Timer
	Friend WithEvents Label3 As Label
	Friend WithEvents lblTienTrinh As Label
	Friend WithEvents lblThoiGian As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents lblTenDeThi As Label
	Friend WithEvents lblSoCau As Label
	Friend WithEvents lblSoPhut As Label
	Friend WithEvents btnSubmit As Button
End Class
