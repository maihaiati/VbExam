<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditQuestions
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditQuestions))
		btnDelImage = New Button()
		picPreview = New PictureBox()
		btnBrowImg = New Button()
		delQues = New Button()
		grpChooseAns = New GroupBox()
		radioC = New RadioButton()
		radioD = New RadioButton()
		radioB = New RadioButton()
		radioA = New RadioButton()
		Label1 = New Label()
		cbbQues = New ComboBox()
		createQues = New Button()
		nextQues = New Button()
		previousQues = New Button()
		txtD = New TextBox()
		txtC = New TextBox()
		txtB = New TextBox()
		txtA = New TextBox()
		txtQues = New TextBox()
		Label5 = New Label()
		Label4 = New Label()
		Label3 = New Label()
		Label2 = New Label()
		lblQues = New Label()
		Label6 = New Label()
		CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
		grpChooseAns.SuspendLayout()
		SuspendLayout()
		' 
		' btnDelImage
		' 
		btnDelImage.Font = New Font("Segoe UI", 11F)
		btnDelImage.Location = New Point(581, 553)
		btnDelImage.Name = "btnDelImage"
		btnDelImage.Size = New Size(193, 43)
		btnDelImage.TabIndex = 45
		btnDelImage.Text = "Bỏ chèn ảnh"
		btnDelImage.UseVisualStyleBackColor = True
		' 
		' picPreview
		' 
		picPreview.BorderStyle = BorderStyle.FixedSingle
		picPreview.Location = New Point(794, 444)
		picPreview.Name = "picPreview"
		picPreview.Size = New Size(333, 201)
		picPreview.SizeMode = PictureBoxSizeMode.Zoom
		picPreview.TabIndex = 44
		picPreview.TabStop = False
		' 
		' btnBrowImg
		' 
		btnBrowImg.Font = New Font("Segoe UI", 11F)
		btnBrowImg.Location = New Point(581, 490)
		btnBrowImg.Name = "btnBrowImg"
		btnBrowImg.Size = New Size(193, 43)
		btnBrowImg.TabIndex = 43
		btnBrowImg.Text = "Chèn ảnh"
		btnBrowImg.UseVisualStyleBackColor = True
		' 
		' delQues
		' 
		delQues.Font = New Font("Segoe UI", 11F)
		delQues.Location = New Point(182, 535)
		delQues.Name = "delQues"
		delQues.Size = New Size(133, 45)
		delQues.TabIndex = 41
		delQues.Text = "Xoá câu hỏi"
		delQues.UseVisualStyleBackColor = True
		' 
		' grpChooseAns
		' 
		grpChooseAns.Controls.Add(radioC)
		grpChooseAns.Controls.Add(radioD)
		grpChooseAns.Controls.Add(radioB)
		grpChooseAns.Controls.Add(radioA)
		grpChooseAns.Location = New Point(349, 464)
		grpChooseAns.Name = "grpChooseAns"
		grpChooseAns.Size = New Size(212, 151)
		grpChooseAns.TabIndex = 39
		grpChooseAns.TabStop = False
		grpChooseAns.Text = "Chọn đáp án đúng"
		' 
		' radioC
		' 
		radioC.AutoSize = True
		radioC.Enabled = False
		radioC.Font = New Font("Segoe UI", 11F)
		radioC.Location = New Point(6, 82)
		radioC.Name = "radioC"
		radioC.Size = New Size(88, 24)
		radioC.TabIndex = 3
		radioC.TabStop = True
		radioC.Text = "Đáp án C"
		radioC.UseVisualStyleBackColor = True
		' 
		' radioD
		' 
		radioD.AutoSize = True
		radioD.Enabled = False
		radioD.Font = New Font("Segoe UI", 11F)
		radioD.Location = New Point(6, 112)
		radioD.Name = "radioD"
		radioD.Size = New Size(90, 24)
		radioD.TabIndex = 2
		radioD.TabStop = True
		radioD.Text = "Đáp án D"
		radioD.UseVisualStyleBackColor = True
		' 
		' radioB
		' 
		radioB.AutoSize = True
		radioB.Enabled = False
		radioB.Font = New Font("Segoe UI", 11F)
		radioB.Location = New Point(6, 52)
		radioB.Name = "radioB"
		radioB.Size = New Size(88, 24)
		radioB.TabIndex = 1
		radioB.TabStop = True
		radioB.Text = "Đáp án B"
		radioB.UseVisualStyleBackColor = True
		' 
		' radioA
		' 
		radioA.AutoSize = True
		radioA.Enabled = False
		radioA.Font = New Font("Segoe UI", 11F)
		radioA.Location = New Point(6, 22)
		radioA.Name = "radioA"
		radioA.Size = New Size(89, 24)
		radioA.TabIndex = 0
		radioA.TabStop = True
		radioA.Text = "Đáp án A"
		radioA.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 12F)
		Label1.Location = New Point(21, 590)
		Label1.Name = "Label1"
		Label1.Size = New Size(104, 21)
		Label1.TabIndex = 38
		Label1.Text = "Chọn câu hỏi:"
		' 
		' cbbQues
		' 
		cbbQues.Enabled = False
		cbbQues.FormattingEnabled = True
		cbbQues.Location = New Point(182, 592)
		cbbQues.Name = "cbbQues"
		cbbQues.Size = New Size(133, 23)
		cbbQues.TabIndex = 37
		' 
		' createQues
		' 
		createQues.Enabled = False
		createQues.Font = New Font("Segoe UI", 11F)
		createQues.Location = New Point(21, 535)
		createQues.Name = "createQues"
		createQues.Size = New Size(133, 45)
		createQues.TabIndex = 36
		createQues.Text = "Thêm câu hỏi"
		createQues.UseVisualStyleBackColor = True
		' 
		' nextQues
		' 
		nextQues.Enabled = False
		nextQues.Font = New Font("Segoe UI", 11F)
		nextQues.Location = New Point(182, 472)
		nextQues.Name = "nextQues"
		nextQues.Size = New Size(133, 45)
		nextQues.TabIndex = 35
		nextQues.Text = "Câu kế tiếp"
		nextQues.UseVisualStyleBackColor = True
		' 
		' previousQues
		' 
		previousQues.Enabled = False
		previousQues.Font = New Font("Segoe UI", 11F)
		previousQues.Location = New Point(21, 472)
		previousQues.Name = "previousQues"
		previousQues.Size = New Size(133, 45)
		previousQues.TabIndex = 34
		previousQues.Text = "Câu trước"
		previousQues.UseVisualStyleBackColor = True
		' 
		' txtD
		' 
		txtD.Location = New Point(581, 352)
		txtD.Multiline = True
		txtD.Name = "txtD"
		txtD.Size = New Size(546, 65)
		txtD.TabIndex = 33
		' 
		' txtC
		' 
		txtC.Location = New Point(581, 253)
		txtC.Multiline = True
		txtC.Name = "txtC"
		txtC.Size = New Size(546, 65)
		txtC.TabIndex = 32
		' 
		' txtB
		' 
		txtB.Location = New Point(581, 154)
		txtB.Multiline = True
		txtB.Name = "txtB"
		txtB.Size = New Size(546, 65)
		txtB.TabIndex = 31
		' 
		' txtA
		' 
		txtA.Location = New Point(581, 55)
		txtA.Multiline = True
		txtA.Name = "txtA"
		txtA.Size = New Size(546, 65)
		txtA.TabIndex = 30
		' 
		' txtQues
		' 
		txtQues.Location = New Point(21, 55)
		txtQues.Multiline = True
		txtQues.Name = "txtQues"
		txtQues.Size = New Size(540, 362)
		txtQues.TabIndex = 29
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label5.Location = New Point(581, 321)
		Label5.Name = "Label5"
		Label5.Size = New Size(100, 28)
		Label5.TabIndex = 28
		Label5.Text = "Đáp án D"
		Label5.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label4.Location = New Point(581, 222)
		Label4.Name = "Label4"
		Label4.Size = New Size(97, 28)
		Label4.TabIndex = 27
		Label4.Text = "Đáp án C"
		Label4.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label3.Location = New Point(581, 123)
		Label3.Name = "Label3"
		Label3.Size = New Size(98, 28)
		Label3.TabIndex = 26
		Label3.Text = "Đáp án B"
		Label3.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label2.Location = New Point(581, 14)
		Label2.Name = "Label2"
		Label2.Size = New Size(99, 28)
		Label2.TabIndex = 25
		Label2.Text = "Đáp án A"
		Label2.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblQues
		' 
		lblQues.AutoSize = True
		lblQues.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		lblQues.Location = New Point(21, 14)
		lblQues.Name = "lblQues"
		lblQues.Size = New Size(83, 28)
		lblQues.TabIndex = 24
		lblQues.Text = "Câu hỏi"
		lblQues.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.ForeColor = Color.Red
		Label6.Location = New Point(12, 646)
		Label6.Name = "Label6"
		Label6.Size = New Size(192, 15)
		Label6.TabIndex = 46
		Label6.Text = "Mọi thay đổi đều được lưu tự động"
		' 
		' EditQuestions
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(1151, 670)
		Controls.Add(Label6)
		Controls.Add(btnDelImage)
		Controls.Add(picPreview)
		Controls.Add(btnBrowImg)
		Controls.Add(delQues)
		Controls.Add(grpChooseAns)
		Controls.Add(Label1)
		Controls.Add(cbbQues)
		Controls.Add(createQues)
		Controls.Add(nextQues)
		Controls.Add(previousQues)
		Controls.Add(txtD)
		Controls.Add(txtC)
		Controls.Add(txtB)
		Controls.Add(txtA)
		Controls.Add(txtQues)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(lblQues)
		Icon = CType(resources.GetObject("$this.Icon"), Icon)
		Margin = New Padding(3, 2, 3, 2)
		Name = "EditQuestions"
		Text = "Exam Administrator - Edit questions"
		CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
		grpChooseAns.ResumeLayout(False)
		grpChooseAns.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents btnDelImage As Button
	Friend WithEvents picPreview As PictureBox
	Friend WithEvents btnBrowImg As Button
	Friend WithEvents delQues As Button
	Friend WithEvents grpChooseAns As GroupBox
	Friend WithEvents radioC As RadioButton
	Friend WithEvents radioD As RadioButton
	Friend WithEvents radioB As RadioButton
	Friend WithEvents radioA As RadioButton
	Friend WithEvents Label1 As Label
	Friend WithEvents cbbQues As ComboBox
	Friend WithEvents createQues As Button
	Friend WithEvents nextQues As Button
	Friend WithEvents previousQues As Button
	Friend WithEvents txtD As TextBox
	Friend WithEvents txtC As TextBox
	Friend WithEvents txtB As TextBox
	Friend WithEvents txtA As TextBox
	Friend WithEvents txtQues As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents lblQues As Label
	Friend WithEvents Label6 As Label
End Class
