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
		MenuStrip1 = New MenuStrip()
		btnDashboard = New ToolStripMenuItem()
		btnMe = New ToolStripMenuItem()
		btnMyAccount = New ToolStripMenuItem()
		btnLogout = New ToolStripMenuItem()
		CType(DGV_Log, ComponentModel.ISupportInitialize).BeginInit()
		MenuStrip1.SuspendLayout()
		SuspendLayout()
		' 
		' DGV_Log
		' 
		DGV_Log.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DGV_Log.Location = New Point(10, 111)
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
		Label2.Location = New Point(287, 38)
		Label2.Name = "Label2"
		Label2.Size = New Size(263, 25)
		Label2.TabIndex = 3
		Label2.Text = "Thông Tin Lịch Sử Hoạt Động"
		' 
		' MenuStrip1
		' 
		MenuStrip1.Items.AddRange(New ToolStripItem() {btnDashboard, btnMe})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(821, 24)
		MenuStrip1.TabIndex = 4
		MenuStrip1.Text = "MenuStrip1"
		' 
		' btnDashboard
		' 
		btnDashboard.Name = "btnDashboard"
		btnDashboard.Size = New Size(86, 20)
		btnDashboard.Text = "Về trang chủ"
		' 
		' btnMe
		' 
		btnMe.Alignment = ToolStripItemAlignment.Right
		btnMe.DropDownItems.AddRange(New ToolStripItem() {btnMyAccount, btnLogout})
		btnMe.Name = "btnMe"
		btnMe.Size = New Size(22, 20)
		btnMe.Text = " "
		' 
		' btnMyAccount
		' 
		btnMyAccount.Name = "btnMyAccount"
		btnMyAccount.Size = New Size(163, 22)
		btnMyAccount.Text = "Tài khoản của tôi"
		' 
		' btnLogout
		' 
		btnLogout.Name = "btnLogout"
		btnLogout.Size = New Size(163, 22)
		btnLogout.Text = "Đăng xuất"
		' 
		' ExamLog
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(821, 438)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(txttimkiem)
		Controls.Add(DGV_Log)
		Controls.Add(MenuStrip1)
		Icon = CType(resources.GetObject("$this.Icon"), Icon)
		MainMenuStrip = MenuStrip1
		Margin = New Padding(3, 2, 3, 2)
		Name = "ExamLog"
		Text = "Exam Administrator - Exam log"
		CType(DGV_Log, ComponentModel.ISupportInitialize).EndInit()
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents DGV_Log As DataGridView
    Friend WithEvents txttimkiem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents btnDashboard As ToolStripMenuItem
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents btnMyAccount As ToolStripMenuItem
	Friend WithEvents btnLogout As ToolStripMenuItem
End Class
