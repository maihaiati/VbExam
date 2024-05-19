<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountManager
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
		MenuStrip1 = New MenuStrip()
		btnCreate = New ToolStripMenuItem()
		btnMe = New ToolStripMenuItem()
		btnFilter = New ToolStripMenuItem()
		btnStudent = New ToolStripMenuItem()
		btnTeacher = New ToolStripMenuItem()
		dgAccount = New DataGridView()
		MenuStrip1.SuspendLayout()
		CType(dgAccount, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.Items.AddRange(New ToolStripItem() {btnCreate, btnMe, btnFilter})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(778, 24)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' btnCreate
		' 
		btnCreate.Name = "btnCreate"
		btnCreate.Size = New Size(90, 20)
		btnCreate.Text = "Tạo tài khoản"
		' 
		' btnMe
		' 
		btnMe.Alignment = ToolStripItemAlignment.Right
		btnMe.Name = "btnMe"
		btnMe.Size = New Size(22, 20)
		btnMe.Text = " "
		' 
		' btnFilter
		' 
		btnFilter.DropDownItems.AddRange(New ToolStripItem() {btnStudent, btnTeacher})
		btnFilter.Name = "btnFilter"
		btnFilter.Size = New Size(38, 20)
		btnFilter.Text = "Lọc"
		' 
		' btnStudent
		' 
		btnStudent.Name = "btnStudent"
		btnStudent.Size = New Size(182, 22)
		btnStudent.Text = "Tài khoản sinh viên"
		' 
		' btnTeacher
		' 
		btnTeacher.Name = "btnTeacher"
		btnTeacher.Size = New Size(182, 22)
		btnTeacher.Text = "Tài khoản giảng viên"
		' 
		' dgAccount
		' 
		dgAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgAccount.Location = New Point(12, 27)
		dgAccount.Name = "dgAccount"
		dgAccount.Size = New Size(755, 316)
		dgAccount.TabIndex = 1
		' 
		' AccountManager
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(778, 355)
		Controls.Add(dgAccount)
		Controls.Add(MenuStrip1)
		Name = "AccountManager"
		Text = "Exam Administrator - Account Manager"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		CType(dgAccount, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents btnCreate As ToolStripMenuItem
	Friend WithEvents dgAccount As DataGridView
	Friend WithEvents btnMe As ToolStripMenuItem
	Friend WithEvents btnFilter As ToolStripMenuItem
	Friend WithEvents btnStudent As ToolStripMenuItem
	Friend WithEvents btnTeacher As ToolStripMenuItem
End Class
