<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoAccount
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        TXTmasinhvien = New TextBox()
        TXTtensinhvien = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        dtpBirth = New DateTimePicker()
        btnedit = New Button()
        btncancel = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(205, 419)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.Location = New Point(348, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 46)
        Label1.TabIndex = 1
        Label1.Text = "Thông tin Hồ sơ"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(260, 303)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 20)
        Label2.TabIndex = 2
        Label2.Text = "Lớp :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(260, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 3
        Label3.Text = "Mã sinh viên :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(258, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 20)
        Label4.TabIndex = 4
        Label4.Text = "Tên sinh viên :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(260, 362)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 5
        Label5.Text = "Khoa :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(258, 196)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 20)
        Label6.TabIndex = 6
        Label6.Text = "ngày sinh :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(258, 250)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 20)
        Label7.TabIndex = 7
        Label7.Text = "Giới Tính :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(60, -144)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 8
        ' 
        ' TXTmasinhvien
        ' 
        TXTmasinhvien.Location = New Point(440, 79)
        TXTmasinhvien.Name = "TXTmasinhvien"
        TXTmasinhvien.Size = New Size(308, 27)
        TXTmasinhvien.TabIndex = 9
        ' 
        ' TXTtensinhvien
        ' 
        TXTtensinhvien.Location = New Point(440, 135)
        TXTtensinhvien.Name = "TXTtensinhvien"
        TXTtensinhvien.Size = New Size(308, 27)
        TXTtensinhvien.TabIndex = 11
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(440, 243)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(308, 27)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(440, 296)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(308, 27)
        TextBox6.TabIndex = 10
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(440, 355)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(308, 27)
        TextBox7.TabIndex = 10
        ' 
        ' dtpBirth
        ' 
        dtpBirth.CustomFormat = ""
        dtpBirth.Format = DateTimePickerFormat.Short
        dtpBirth.Location = New Point(440, 191)
        dtpBirth.Margin = New Padding(3, 4, 3, 4)
        dtpBirth.Name = "dtpBirth"
        dtpBirth.Size = New Size(308, 27)
        dtpBirth.TabIndex = 12
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(228, 428)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(163, 46)
        btnedit.TabIndex = 13
        btnedit.Text = "Thay Đổi Thông Tin"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btncancel
        ' 
        btncancel.Location = New Point(531, 428)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(113, 46)
        btncancel.TabIndex = 14
        btncancel.Text = "Huỷ Bỏ"
        btncancel.UseVisualStyleBackColor = True
        ' 
        ' InfoAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(792, 501)
        Controls.Add(btncancel)
        Controls.Add(btnedit)
        Controls.Add(dtpBirth)
        Controls.Add(TXTtensinhvien)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TXTmasinhvien)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "InfoAccount"
        Text = "InfoAccount"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TXTmasinhvien As TextBox
    Friend WithEvents TXTtensinhvien As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents dtpBirth As DateTimePicker
    Friend WithEvents btnedit As Button
    Friend WithEvents btncancel As Button
End Class
