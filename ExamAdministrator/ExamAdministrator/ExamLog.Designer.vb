<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamLog
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamLog))
		DGV_Log = New DataGridView()
		txttimkiem = New TextBox()
		Label1 = New Label()
		Label2 = New Label()
		CType(DGV_Log, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' DGV_Log
		' 
		DGV_Log.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DGV_Log.Location = New Point(0, 115)
		DGV_Log.Margin = New Padding(3, 2, 3, 2)
		DGV_Log.Name = "DGV_Log"
		DGV_Log.ReadOnly = True
		DGV_Log.RowHeadersWidth = 51
		DGV_Log.Size = New Size(801, 318)
		DGV_Log.TabIndex = 0
		' 
		' txttimkiem
		' 
		txttimkiem.Location = New Point(189, 82)
		txttimkiem.Margin = New Padding(3, 2, 3, 2)
		txttimkiem.Name = "txttimkiem"
		txttimkiem.Size = New Size(223, 23)
		txttimkiem.TabIndex = 1
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
		Label1.ForeColor = SystemColors.Highlight
		Label1.Location = New Point(17, 84)
		Label1.Name = "Label1"
		Label1.Size = New Size(147, 15)
		Label1.TabIndex = 2
		Label1.Text = "Tìm Kiếm (Mã Tài Khoản):"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
		Label2.ForeColor = Color.Blue
		Label2.Location = New Point(272, 20)
		Label2.Name = "Label2"
		Label2.Size = New Size(263, 25)
		Label2.TabIndex = 3
		Label2.Text = "Thông Tin Lịch Sử Hoạt Động"
		' 
		' ExamLog
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(802, 433)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(txttimkiem)
		Controls.Add(DGV_Log)
		Icon = CType(resources.GetObject("$this.Icon"), Icon)
		Margin = New Padding(3, 2, 3, 2)
		Name = "ExamLog"
		Text = "Exam Administrator - Exam log"
		CType(DGV_Log, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents DGV_Log As DataGridView
    Friend WithEvents txttimkiem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
