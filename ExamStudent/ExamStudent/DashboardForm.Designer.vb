<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
		DataGridView1 = New DataGridView()
		Label1 = New Label()
		Label2 = New Label()
		CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' DataGridView1
		' 
		DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridView1.Location = New Point(12, 81)
		DataGridView1.Name = "DataGridView1"
		DataGridView1.Size = New Size(758, 416)
		DataGridView1.TabIndex = 0
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label1.Location = New Point(332, 9)
		Label1.Name = "Label1"
		Label1.Size = New Size(107, 28)
		Label1.TabIndex = 1
		Label1.Text = "Trang Chủ"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Segoe UI", 12F)
		Label2.Location = New Point(12, 49)
		Label2.Name = "Label2"
		Label2.Size = New Size(237, 21)
		Label2.TabIndex = 2
		Label2.Text = "Chọn đề thi có sẵn để bắt đầu thi"
		' 
		' DashboardForm
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(782, 509)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(DataGridView1)
		Name = "DashboardForm"
		Text = "Exam Student - Dashboard"
		CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
End Class
