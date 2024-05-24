<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditType
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
		btnProperties = New Button()
		btnQuestion = New Button()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label1.Location = New Point(68, 9)
		Label1.Name = "Label1"
		Label1.Size = New Size(214, 28)
		Label1.TabIndex = 0
		Label1.Text = "Bạn muốn chỉnh sửa?"
		' 
		' btnProperties
		' 
		btnProperties.Font = New Font("Segoe UI", 11F)
		btnProperties.Location = New Point(18, 48)
		btnProperties.Margin = New Padding(3, 2, 3, 2)
		btnProperties.Name = "btnProperties"
		btnProperties.Size = New Size(139, 139)
		btnProperties.TabIndex = 1
		btnProperties.Text = "Thông tin đề thi"
		btnProperties.UseVisualStyleBackColor = True
		' 
		' btnQuestion
		' 
		btnQuestion.Font = New Font("Segoe UI", 11F)
		btnQuestion.Location = New Point(190, 48)
		btnQuestion.Margin = New Padding(3, 2, 3, 2)
		btnQuestion.Name = "btnQuestion"
		btnQuestion.Size = New Size(139, 139)
		btnQuestion.TabIndex = 2
		btnQuestion.Text = "Câu hỏi và đáp án"
		btnQuestion.UseVisualStyleBackColor = True
		' 
		' EditType
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(347, 206)
		Controls.Add(btnQuestion)
		Controls.Add(btnProperties)
		Controls.Add(Label1)
		Margin = New Padding(3, 2, 3, 2)
		Name = "EditType"
		Text = "Exam Administrator - Edit type"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents btnProperties As Button
    Friend WithEvents btnQuestion As Button
End Class
