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
        DGV_Log.Location = New Point(0, 153)
        DGV_Log.Name = "DGV_Log"
        DGV_Log.RowHeadersWidth = 51
        DGV_Log.Size = New Size(915, 424)
        DGV_Log.TabIndex = 0
        ' 
        ' txttimkiem
        ' 
        txttimkiem.Location = New Point(216, 109)
        txttimkiem.Name = "txttimkiem"
        txttimkiem.Size = New Size(254, 27)
        txttimkiem.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(19, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 20)
        Label1.TabIndex = 2
        Label1.Text = "Tìm Kiếm (Mã Tài Khoản):"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(311, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(316, 30)
        Label2.TabIndex = 3
        Label2.Text = "Thông Tin Lịch Sử Hoạt Động"
        ' 
        ' ExamLog
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(916, 577)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txttimkiem)
        Controls.Add(DGV_Log)
        Name = "ExamLog"
        Text = "ExamLog"
        CType(DGV_Log, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGV_Log As DataGridView
    Friend WithEvents txttimkiem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
