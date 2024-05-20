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
		RichTextBox1 = New RichTextBox()
		Button1 = New Button()
		Button2 = New Button()
		Button3 = New Button()
		Button4 = New Button()
		Button5 = New Button()
		Button6 = New Button()
		Label1 = New Label()
		ComboBox1 = New ComboBox()
		SuspendLayout()
		' 
		' RichTextBox1
		' 
		RichTextBox1.Location = New Point(12, 12)
		RichTextBox1.Name = "RichTextBox1"
		RichTextBox1.Size = New Size(875, 587)
		RichTextBox1.TabIndex = 0
		RichTextBox1.Text = ""
		' 
		' Button1
		' 
		Button1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		Button1.Location = New Point(12, 614)
		Button1.Name = "Button1"
		Button1.Size = New Size(113, 49)
		Button1.TabIndex = 1
		Button1.Text = "A"
		Button1.UseVisualStyleBackColor = True
		' 
		' Button2
		' 
		Button2.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		Button2.Location = New Point(131, 614)
		Button2.Name = "Button2"
		Button2.Size = New Size(113, 49)
		Button2.TabIndex = 2
		Button2.Text = "B"
		Button2.UseVisualStyleBackColor = True
		' 
		' Button3
		' 
		Button3.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		Button3.Location = New Point(250, 614)
		Button3.Name = "Button3"
		Button3.Size = New Size(113, 49)
		Button3.TabIndex = 3
		Button3.Text = "C"
		Button3.UseVisualStyleBackColor = True
		' 
		' Button4
		' 
		Button4.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
		Button4.Location = New Point(369, 614)
		Button4.Name = "Button4"
		Button4.Size = New Size(113, 49)
		Button4.TabIndex = 4
		Button4.Text = "D"
		Button4.UseVisualStyleBackColor = True
		' 
		' Button5
		' 
		Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
		Button5.Location = New Point(655, 614)
		Button5.Name = "Button5"
		Button5.Size = New Size(113, 49)
		Button5.TabIndex = 5
		Button5.Text = "Câu trước"
		Button5.UseVisualStyleBackColor = True
		' 
		' Button6
		' 
		Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
		Button6.Location = New Point(774, 614)
		Button6.Name = "Button6"
		Button6.Size = New Size(113, 49)
		Button6.TabIndex = 6
		Button6.Text = "Câu kế tiếp"
		Button6.UseVisualStyleBackColor = True
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
		' ComboBox1
		' 
		ComboBox1.FormattingEnabled = True
		ComboBox1.Location = New Point(512, 640)
		ComboBox1.Name = "ComboBox1"
		ComboBox1.Size = New Size(121, 23)
		ComboBox1.TabIndex = 8
		' 
		' DoTest
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(899, 675)
		Controls.Add(ComboBox1)
		Controls.Add(Label1)
		Controls.Add(Button6)
		Controls.Add(Button5)
		Controls.Add(Button4)
		Controls.Add(Button3)
		Controls.Add(Button2)
		Controls.Add(Button1)
		Controls.Add(RichTextBox1)
		Name = "DoTest"
		Text = "Exam Student"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button5 As Button
	Friend WithEvents Button6 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents ComboBox1 As ComboBox
End Class
