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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditType))
        Label1 = New Label()
        btnProperties = New Button()
        btnQuestion = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.Location = New Point(78, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 35)
        Label1.TabIndex = 0
        Label1.Text = "Bạn muốn chỉnh sửa?"
        ' 
        ' btnProperties
        ' 
        btnProperties.Font = New Font("Segoe UI", 11F)
        btnProperties.Location = New Point(21, 64)
        btnProperties.Name = "btnProperties"
        btnProperties.Size = New Size(159, 185)
        btnProperties.TabIndex = 1
        btnProperties.Text = "Thông tin đề thi"
        btnProperties.UseVisualStyleBackColor = True
        ' 
        ' btnQuestion
        ' 
        btnQuestion.Font = New Font("Segoe UI", 11F)
        btnQuestion.Location = New Point(217, 64)
        btnQuestion.Name = "btnQuestion"
        btnQuestion.Size = New Size(159, 185)
        btnQuestion.TabIndex = 2
        btnQuestion.Text = "Câu hỏi và đáp án"
        btnQuestion.UseVisualStyleBackColor = True
        ' 
        ' EditType
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(397, 275)
        Controls.Add(btnQuestion)
        Controls.Add(btnProperties)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "EditType"
        Text = "Exam Administrator - Edit type"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnProperties As Button
    Friend WithEvents btnQuestion As Button
End Class
