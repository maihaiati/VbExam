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
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        grpChooseAns.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnDelImage
        ' 
        btnDelImage.Font = New Font("Segoe UI", 11F)
        btnDelImage.Location = New Point(664, 737)
        btnDelImage.Margin = New Padding(3, 4, 3, 4)
        btnDelImage.Name = "btnDelImage"
        btnDelImage.Size = New Size(221, 57)
        btnDelImage.TabIndex = 45
        btnDelImage.Text = "Bỏ chèn ảnh"
        btnDelImage.UseVisualStyleBackColor = True
        ' 
        ' picPreview
        ' 
        picPreview.BorderStyle = BorderStyle.FixedSingle
        picPreview.Location = New Point(907, 592)
        picPreview.Margin = New Padding(3, 4, 3, 4)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(380, 267)
        picPreview.SizeMode = PictureBoxSizeMode.Zoom
        picPreview.TabIndex = 44
        picPreview.TabStop = False
        ' 
        ' btnBrowImg
        ' 
        btnBrowImg.Font = New Font("Segoe UI", 11F)
        btnBrowImg.Location = New Point(664, 653)
        btnBrowImg.Margin = New Padding(3, 4, 3, 4)
        btnBrowImg.Name = "btnBrowImg"
        btnBrowImg.Size = New Size(221, 57)
        btnBrowImg.TabIndex = 43
        btnBrowImg.Text = "Chèn ảnh"
        btnBrowImg.UseVisualStyleBackColor = True
        ' 
        ' delQues
        ' 
        delQues.Font = New Font("Segoe UI", 11F)
        delQues.Location = New Point(208, 713)
        delQues.Margin = New Padding(3, 4, 3, 4)
        delQues.Name = "delQues"
        delQues.Size = New Size(152, 60)
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
        grpChooseAns.Location = New Point(399, 619)
        grpChooseAns.Margin = New Padding(3, 4, 3, 4)
        grpChooseAns.Name = "grpChooseAns"
        grpChooseAns.Padding = New Padding(3, 4, 3, 4)
        grpChooseAns.Size = New Size(242, 201)
        grpChooseAns.TabIndex = 39
        grpChooseAns.TabStop = False
        grpChooseAns.Text = "Chọn đáp án đúng"
        ' 
        ' radioC
        ' 
        radioC.AutoSize = True
        radioC.Enabled = False
        radioC.Font = New Font("Segoe UI", 11F)
        radioC.Location = New Point(7, 109)
        radioC.Margin = New Padding(3, 4, 3, 4)
        radioC.Name = "radioC"
        radioC.Size = New Size(110, 29)
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
        radioD.Location = New Point(7, 149)
        radioD.Margin = New Padding(3, 4, 3, 4)
        radioD.Name = "radioD"
        radioD.Size = New Size(111, 29)
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
        radioB.Location = New Point(7, 69)
        radioB.Margin = New Padding(3, 4, 3, 4)
        radioB.Name = "radioB"
        radioB.Size = New Size(109, 29)
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
        radioA.Location = New Point(7, 29)
        radioA.Margin = New Padding(3, 4, 3, 4)
        radioA.Name = "radioA"
        radioA.Size = New Size(110, 29)
        radioA.TabIndex = 0
        radioA.TabStop = True
        radioA.Text = "Đáp án A"
        radioA.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(24, 787)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 28)
        Label1.TabIndex = 38
        Label1.Text = "Chọn câu hỏi:"
        ' 
        ' cbbQues
        ' 
        cbbQues.Enabled = False
        cbbQues.FormattingEnabled = True
        cbbQues.Location = New Point(208, 789)
        cbbQues.Margin = New Padding(3, 4, 3, 4)
        cbbQues.Name = "cbbQues"
        cbbQues.Size = New Size(151, 28)
        cbbQues.TabIndex = 37
        ' 
        ' createQues
        ' 
        createQues.Enabled = False
        createQues.Font = New Font("Segoe UI", 11F)
        createQues.Location = New Point(24, 713)
        createQues.Margin = New Padding(3, 4, 3, 4)
        createQues.Name = "createQues"
        createQues.Size = New Size(152, 60)
        createQues.TabIndex = 36
        createQues.Text = "Thêm câu hỏi"
        createQues.UseVisualStyleBackColor = True
        ' 
        ' nextQues
        ' 
        nextQues.Enabled = False
        nextQues.Font = New Font("Segoe UI", 11F)
        nextQues.Location = New Point(208, 629)
        nextQues.Margin = New Padding(3, 4, 3, 4)
        nextQues.Name = "nextQues"
        nextQues.Size = New Size(152, 60)
        nextQues.TabIndex = 35
        nextQues.Text = "Câu kế tiếp"
        nextQues.UseVisualStyleBackColor = True
        ' 
        ' previousQues
        ' 
        previousQues.Enabled = False
        previousQues.Font = New Font("Segoe UI", 11F)
        previousQues.Location = New Point(24, 629)
        previousQues.Margin = New Padding(3, 4, 3, 4)
        previousQues.Name = "previousQues"
        previousQues.Size = New Size(152, 60)
        previousQues.TabIndex = 34
        previousQues.Text = "Câu trước"
        previousQues.UseVisualStyleBackColor = True
        ' 
        ' txtD
        ' 
        txtD.Location = New Point(664, 469)
        txtD.Margin = New Padding(3, 4, 3, 4)
        txtD.Multiline = True
        txtD.Name = "txtD"
        txtD.Size = New Size(623, 85)
        txtD.TabIndex = 33
        ' 
        ' txtC
        ' 
        txtC.Location = New Point(664, 337)
        txtC.Margin = New Padding(3, 4, 3, 4)
        txtC.Multiline = True
        txtC.Name = "txtC"
        txtC.Size = New Size(623, 85)
        txtC.TabIndex = 32
        ' 
        ' txtB
        ' 
        txtB.Location = New Point(664, 205)
        txtB.Margin = New Padding(3, 4, 3, 4)
        txtB.Multiline = True
        txtB.Name = "txtB"
        txtB.Size = New Size(623, 85)
        txtB.TabIndex = 31
        ' 
        ' txtA
        ' 
        txtA.Location = New Point(664, 73)
        txtA.Margin = New Padding(3, 4, 3, 4)
        txtA.Multiline = True
        txtA.Name = "txtA"
        txtA.Size = New Size(623, 85)
        txtA.TabIndex = 30
        ' 
        ' txtQues
        ' 
        txtQues.Location = New Point(24, 73)
        txtQues.Margin = New Padding(3, 4, 3, 4)
        txtQues.Multiline = True
        txtQues.Name = "txtQues"
        txtQues.Size = New Size(617, 481)
        txtQues.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label5.Location = New Point(664, 428)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 35)
        Label5.TabIndex = 28
        Label5.Text = "Đáp án D"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label4.Location = New Point(664, 296)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 35)
        Label4.TabIndex = 27
        Label4.Text = "Đáp án C"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label3.Location = New Point(664, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 35)
        Label3.TabIndex = 26
        Label3.Text = "Đáp án B"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label2.Location = New Point(664, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 35)
        Label2.TabIndex = 25
        Label2.Text = "Đáp án A"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblQues
        ' 
        lblQues.AutoSize = True
        lblQues.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblQues.Location = New Point(24, 19)
        lblQues.Name = "lblQues"
        lblQues.Size = New Size(103, 35)
        lblQues.TabIndex = 24
        lblQues.Text = "Câu hỏi"
        lblQues.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EditQuestions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1315, 893)
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
End Class
