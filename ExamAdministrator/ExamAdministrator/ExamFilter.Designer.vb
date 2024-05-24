<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamFilter
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
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		Label6 = New Label()
		txtMaDeThi = New TextBox()
		txtMaKhoa = New TextBox()
		txtTenDeThi = New TextBox()
		cbAllTrue = New CheckBox()
		btnFilter = New Button()
		btnExit = New Button()
		numOfQues = New NumericUpDown()
		CType(numOfQues, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		Label1.Location = New Point(151, 9)
		Label1.Name = "Label1"
		Label1.Size = New Size(150, 37)
		Label1.TabIndex = 0
		Label1.Text = "Lọc Đề Thi"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(36, 75)
		Label2.Name = "Label2"
		Label2.Size = New Size(57, 15)
		Label2.TabIndex = 1
		Label2.Text = "Mã đề thi"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(36, 104)
		Label3.Name = "Label3"
		Label3.Size = New Size(53, 15)
		Label3.TabIndex = 2
		Label3.Text = "Mã khoa"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(36, 133)
		Label4.Name = "Label4"
		Label4.Size = New Size(58, 15)
		Label4.TabIndex = 3
		Label4.Text = "Tên đề thi"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(36, 161)
		Label5.Name = "Label5"
		Label5.Size = New Size(42, 15)
		Label5.TabIndex = 4
		Label5.Text = "Số câu"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Location = New Point(36, 187)
		Label6.Name = "Label6"
		Label6.Size = New Size(167, 15)
		Label6.TabIndex = 5
		Label6.Text = "Thoả mãn tất cả điều kiện trên"
		' 
		' txtMaDeThi
		' 
		txtMaDeThi.Location = New Point(248, 72)
		txtMaDeThi.Name = "txtMaDeThi"
		txtMaDeThi.Size = New Size(171, 23)
		txtMaDeThi.TabIndex = 6
		' 
		' txtMaKhoa
		' 
		txtMaKhoa.Location = New Point(248, 101)
		txtMaKhoa.Name = "txtMaKhoa"
		txtMaKhoa.Size = New Size(171, 23)
		txtMaKhoa.TabIndex = 7
		' 
		' txtTenDeThi
		' 
		txtTenDeThi.Location = New Point(248, 130)
		txtTenDeThi.Name = "txtTenDeThi"
		txtTenDeThi.Size = New Size(171, 23)
		txtTenDeThi.TabIndex = 8
		' 
		' cbAllTrue
		' 
		cbAllTrue.AutoSize = True
		cbAllTrue.Location = New Point(248, 188)
		cbAllTrue.Name = "cbAllTrue"
		cbAllTrue.Size = New Size(15, 14)
		cbAllTrue.TabIndex = 10
		cbAllTrue.UseVisualStyleBackColor = True
		' 
		' btnFilter
		' 
		btnFilter.Location = New Point(101, 225)
		btnFilter.Name = "btnFilter"
		btnFilter.Size = New Size(93, 43)
		btnFilter.TabIndex = 11
		btnFilter.Text = "Lọc"
		btnFilter.UseVisualStyleBackColor = True
		' 
		' btnExit
		' 
		btnExit.Location = New Point(261, 225)
		btnExit.Name = "btnExit"
		btnExit.Size = New Size(93, 43)
		btnExit.TabIndex = 12
		btnExit.Text = "Thoát"
		btnExit.UseVisualStyleBackColor = True
		' 
		' numOfQues
		' 
		numOfQues.Location = New Point(248, 159)
		numOfQues.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		numOfQues.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		numOfQues.Name = "numOfQues"
		numOfQues.Size = New Size(171, 23)
		numOfQues.TabIndex = 13
		numOfQues.Value = New Decimal(New Integer() {1, 0, 0, 0})
		' 
		' ExamFilter
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(456, 280)
		Controls.Add(numOfQues)
		Controls.Add(btnExit)
		Controls.Add(btnFilter)
		Controls.Add(cbAllTrue)
		Controls.Add(txtTenDeThi)
		Controls.Add(txtMaKhoa)
		Controls.Add(txtMaDeThi)
		Controls.Add(Label6)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Name = "ExamFilter"
		Text = "Exam Administrator - Exam Filter"
		CType(numOfQues, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtMaDeThi As TextBox
	Friend WithEvents txtMaKhoa As TextBox
	Friend WithEvents txtTenDeThi As TextBox
	Friend WithEvents cbAllTrue As CheckBox
	Friend WithEvents btnFilter As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents numOfQues As NumericUpDown
End Class
