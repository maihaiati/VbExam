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
		Label2 = New Label()
		MenuStrip1 = New MenuStrip()
		btnMe = New ToolStripMenuItem()
		TàiKhoảnCủaTôiToolStripMenuItem = New ToolStripMenuItem()
		ĐăngXuấtToolStripMenuItem = New ToolStripMenuItem()
		CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
		MenuStrip1.SuspendLayout()
		SuspendLayout()
		' 
		' DataGridView1
		' 
		DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridView1.Location = New Point(12, 81)
		DataGridView1.Name = "DataGridView1"
		DataGridView1.RowHeadersWidth = 51
		DataGridView1.Size = New Size(758, 416)
		DataGridView1.TabIndex = 0
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Segoe UI", 12F)
		Label2.Location = New Point(12, 41)
		Label2.Name = "Label2"
		Label2.Size = New Size(237, 21)
		Label2.TabIndex = 2
		Label2.Text = "Chọn đề thi có sẵn để bắt đầu thi"
		' 
		' MenuStrip1
		' 
		MenuStrip1.Items.AddRange(New ToolStripItem() {btnMe})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(782, 24)
		MenuStrip1.TabIndex = 3
		MenuStrip1.Text = "MenuStrip1"
		' 
		' btnMe
		' 
		btnMe.Alignment = ToolStripItemAlignment.Right
		btnMe.DropDownItems.AddRange(New ToolStripItem() {TàiKhoảnCủaTôiToolStripMenuItem, ĐăngXuấtToolStripMenuItem})
		btnMe.Name = "btnMe"
		btnMe.Size = New Size(22, 20)
		btnMe.Text = " "
		' 
		' TàiKhoảnCủaTôiToolStripMenuItem
		' 
		TàiKhoảnCủaTôiToolStripMenuItem.Name = "TàiKhoảnCủaTôiToolStripMenuItem"
		TàiKhoảnCủaTôiToolStripMenuItem.Size = New Size(180, 22)
		TàiKhoảnCủaTôiToolStripMenuItem.Text = "Tài khoản của tôi"
		' 
		' ĐăngXuấtToolStripMenuItem
		' 
		ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
		ĐăngXuấtToolStripMenuItem.Size = New Size(180, 22)
		ĐăngXuấtToolStripMenuItem.Text = "Đăng xuất"
		' 
		' DashboardForm
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(782, 509)
		Controls.Add(Label2)
		Controls.Add(DataGridView1)
		Controls.Add(MenuStrip1)
		MainMenuStrip = MenuStrip1
		Name = "DashboardForm"
		Text = "Exam Student - Dashboard"
		CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label2 As Label
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents TàiKhoảnCủaTôiToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ĐăngXuấtToolStripMenuItem As ToolStripMenuItem
End Class
