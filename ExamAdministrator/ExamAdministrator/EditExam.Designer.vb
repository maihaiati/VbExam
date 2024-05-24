<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditExam
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
        btnExit = New Button()
        btnDelete = New Button()
        txtTenDe = New TextBox()
        txtMaKhoa = New TextBox()
        txtMaDe = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnEdit = New Button()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(344, 237)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(110, 52)
        btnExit.TabIndex = 17
        btnExit.Text = "Thoát"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(197, 237)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(110, 52)
        btnDelete.TabIndex = 16
        btnDelete.Text = "Xoá đề thi"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtTenDe
        ' 
        txtTenDe.Location = New Point(173, 172)
        txtTenDe.Margin = New Padding(3, 4, 3, 4)
        txtTenDe.Name = "txtTenDe"
        txtTenDe.Size = New Size(281, 27)
        txtTenDe.TabIndex = 15
        ' 
        ' txtMaKhoa
        ' 
        txtMaKhoa.Location = New Point(173, 133)
        txtMaKhoa.Margin = New Padding(3, 4, 3, 4)
        txtMaKhoa.Name = "txtMaKhoa"
        txtMaKhoa.Size = New Size(281, 27)
        txtMaKhoa.TabIndex = 14
        ' 
        ' txtMaDe
        ' 
        txtMaDe.Location = New Point(173, 94)
        txtMaDe.Margin = New Padding(3, 4, 3, 4)
        txtMaDe.Name = "txtMaDe"
        txtMaDe.Size = New Size(281, 27)
        txtMaDe.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 20)
        Label4.TabIndex = 12
        Label4.Text = "Tên đề thi"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 11
        Label3.Text = "Mã khoa"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 10
        Label2.Text = "Mã đề thi"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.Location = New Point(105, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 46)
        Label1.TabIndex = 9
        Label1.Text = "Chỉnh Sửa Đề Thi"
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(42, 237)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(110, 52)
        btnEdit.TabIndex = 18
        btnEdit.Text = "Sửa đề thi"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' EditExam
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 317)
        Controls.Add(btnEdit)
        Controls.Add(btnExit)
        Controls.Add(btnDelete)
        Controls.Add(txtTenDe)
        Controls.Add(txtMaKhoa)
        Controls.Add(txtMaDe)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "EditExam"
        Text = "EditExam"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtTenDe As TextBox
    Friend WithEvents txtMaKhoa As TextBox
    Friend WithEvents txtMaDe As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEdit As Button
End Class
