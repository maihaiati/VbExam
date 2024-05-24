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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtMaDe = New TextBox()
        txtMaKhoa = New TextBox()
        txtTenDe = New TextBox()
        btnCreate = New Button()
        btnExit = New Button()
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
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 2
        Label3.Text = "Mã khoa"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 171)
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
        ' txtMaKhoa
        ' 
        txtMaKhoa.Location = New Point(190, 128)
        txtMaKhoa.Margin = New Padding(3, 4, 3, 4)
        txtMaKhoa.Name = "txtMaKhoa"
        txtMaKhoa.Size = New Size(281, 27)
        txtMaKhoa.TabIndex = 5
        ' 
        ' txtTenDe
        ' 
        txtTenDe.Location = New Point(190, 167)
        txtTenDe.Margin = New Padding(3, 4, 3, 4)
        txtTenDe.Name = "txtTenDe"
        txtTenDe.Size = New Size(281, 27)
        txtTenDe.TabIndex = 6
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(133, 227)
        btnCreate.Margin = New Padding(3, 4, 3, 4)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(110, 52)
        btnCreate.TabIndex = 7
        btnCreate.Text = "Tạo đề"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(299, 227)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(110, 52)
        btnExit.TabIndex = 8
        btnExit.Text = "Thoát"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' CreateExam
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(544, 295)
        Controls.Add(btnExit)
        Controls.Add(btnCreate)
        Controls.Add(txtTenDe)
        Controls.Add(txtMaKhoa)
        Controls.Add(txtMaDe)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "CreateExam"
        Text = "Exam Administrator - Create Exam"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtMaDe As TextBox
	Friend WithEvents txtMaKhoa As TextBox
	Friend WithEvents txtTenDe As TextBox
	Friend WithEvents btnCreate As Button
	Friend WithEvents btnExit As Button
End Class
