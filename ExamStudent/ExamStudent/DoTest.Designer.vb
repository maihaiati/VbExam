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
		MenuStrip1 = New MenuStrip()
		btnMe = New ToolStripMenuItem()
		picture = New PictureBox()
		Label2 = New Label()
		lblMsv = New Label()
		lblHoTen = New Label()
		lblLop = New Label()
		lblNgaySinh = New Label()
		lblKhoa = New Label()
		Timer = New Timer(components)
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		Label6 = New Label()
		Label7 = New Label()
		Label8 = New Label()
		Label9 = New Label()
		MenuStrip1.SuspendLayout()
		CType(picture, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' txtQues
		' 
		txtQues.Font = New Font("Segoe UI", 12F)
		txtQues.Location = New Point(250, 37)
		txtQues.Name = "txtQues"
		txtQues.Size = New Size(637, 562)
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
		' MenuStrip1
		' 
		MenuStrip1.Items.AddRange(New ToolStripItem() {btnMe})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(899, 24)
		MenuStrip1.TabIndex = 9
		MenuStrip1.Text = "MenuStrip1"
		' 
		' btnMe
		' 
		btnMe.Alignment = ToolStripItemAlignment.Right
		btnMe.Name = "btnMe"
		btnMe.Size = New Size(22, 20)
		btnMe.Text = " "
		' 
		' picture
		' 
		picture.Location = New Point(12, 37)
		picture.Name = "picture"
		picture.Size = New Size(232, 285)
		picture.SizeMode = PictureBoxSizeMode.Zoom
		picture.TabIndex = 10
		picture.TabStop = False
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(22, 397)
		Label2.Name = "Label2"
		Label2.Size = New Size(212, 15)
		Label2.TabIndex = 11
		Label2.Text = "_________________________________________"
		' 
		' lblMsv
		' 
		lblMsv.AutoSize = True
		lblMsv.Location = New Point(12, 420)
		lblMsv.Name = "lblMsv"
		lblMsv.Size = New Size(80, 15)
		lblMsv.TabIndex = 12
		lblMsv.Text = "Mã sinh viên: "
		' 
		' lblHoTen
		' 
		lblHoTen.AutoSize = True
		lblHoTen.Location = New Point(12, 445)
		lblHoTen.Name = "lblHoTen"
		lblHoTen.Size = New Size(64, 15)
		lblHoTen.TabIndex = 13
		lblHoTen.Text = "Họ và tên: "
		' 
		' lblLop
		' 
		lblLop.AutoSize = True
		lblLop.Location = New Point(12, 495)
		lblLop.Name = "lblLop"
		lblLop.Size = New Size(33, 15)
		lblLop.TabIndex = 14
		lblLop.Text = "Lớp: "
		' 
		' lblNgaySinh
		' 
		lblNgaySinh.AutoSize = True
		lblNgaySinh.Location = New Point(12, 470)
		lblNgaySinh.Name = "lblNgaySinh"
		lblNgaySinh.Size = New Size(63, 15)
		lblNgaySinh.TabIndex = 15
		lblNgaySinh.Text = "Ngày sinh:"
		' 
		' lblKhoa
		' 
		lblKhoa.AutoSize = True
		lblKhoa.Location = New Point(12, 520)
		lblKhoa.Name = "lblKhoa"
		lblKhoa.Size = New Size(40, 15)
		lblKhoa.TabIndex = 16
		lblKhoa.Text = "Khoa: "
		' 
		' Timer
		' 
		Timer.Interval = 1000
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(22, 532)
		Label3.Name = "Label3"
		Label3.Size = New Size(212, 15)
		Label3.TabIndex = 17
		Label3.Text = "_________________________________________"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(12, 560)
		Label4.Name = "Label4"
		Label4.Size = New Size(87, 15)
		Label4.TabIndex = 18
		Label4.Text = "Số câu đã làm: "
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(12, 584)
		Label5.Name = "Label5"
		Label5.Size = New Size(100, 15)
		Label5.TabIndex = 19
		Label5.Text = "Thời gian còn lại: "
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Location = New Point(22, 322)
		Label6.Name = "Label6"
		Label6.Size = New Size(212, 15)
		Label6.TabIndex = 20
		Label6.Text = "_________________________________________"
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Location = New Point(12, 339)
		Label7.Name = "Label7"
		Label7.Size = New Size(64, 15)
		Label7.TabIndex = 21
		Label7.Text = "Tên đề thi: "
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Location = New Point(12, 363)
		Label8.Name = "Label8"
		Label8.Size = New Size(48, 15)
		Label8.TabIndex = 22
		Label8.Text = "Số câu: "
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.Location = New Point(12, 388)
		Label9.Name = "Label9"
		Label9.Size = New Size(54, 15)
		Label9.TabIndex = 23
		Label9.Text = "Số phút: "
		' 
		' DoTest
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(899, 675)
		Controls.Add(Label9)
		Controls.Add(Label8)
		Controls.Add(Label7)
		Controls.Add(Label6)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(lblKhoa)
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
		Controls.Add(MenuStrip1)
		MainMenuStrip = MenuStrip1
		Name = "DoTest"
		Text = "Exam Student"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
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
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents picture As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents lblMsv As Label
	Friend WithEvents lblHoTen As Label
	Friend WithEvents lblLop As Label
	Friend WithEvents lblNgaySinh As Label
	Friend WithEvents lblKhoa As Label
	Friend WithEvents Timer As Timer
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
End Class
