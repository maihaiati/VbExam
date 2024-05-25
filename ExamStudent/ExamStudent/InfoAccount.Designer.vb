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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        cbgioitinh = New ComboBox()
        Label1 = New Label()
        Label8 = New Label()
        btnupdate = New Button()
        btncannel = New Button()
        Label9 = New Label()
        Label10 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(351, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 3
        Label2.Text = "MÃ SINH VIÊN:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.Blue
        Label3.Location = New Point(351, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 20)
        Label3.TabIndex = 4
        Label3.Text = "HỌ TÊN:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.Blue
        Label4.Location = New Point(351, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 20)
        Label4.TabIndex = 5
        Label4.Text = "NGÀY SINH:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(351, 267)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 20)
        Label5.TabIndex = 6
        Label5.Text = "GIỚI TÍNH:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Control
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.Blue
        Label6.Location = New Point(351, 317)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 7
        Label6.Text = "LỚP:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.Blue
        Label7.Location = New Point(351, 367)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 20)
        Label7.TabIndex = 8
        Label7.Text = "KHOA:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlDark
        PictureBox1.Location = New Point(49, 101)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(257, 323)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(490, 114)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(251, 27)
        TextBox1.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(490, 167)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(251, 27)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(490, 317)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(251, 27)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(490, 364)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(251, 27)
        TextBox4.TabIndex = 13
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(490, 212)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(151, 27)
        DateTimePicker1.TabIndex = 14
        ' 
        ' cbgioitinh
        ' 
        cbgioitinh.FormattingEnabled = True
        cbgioitinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        cbgioitinh.Location = New Point(490, 264)
        cbgioitinh.Name = "cbgioitinh"
        cbgioitinh.Size = New Size(151, 28)
        cbgioitinh.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.ForeColor = Color.IndianRed
        Label1.Location = New Point(304, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 29)
        Label1.TabIndex = 16
        Label1.Text = "Thông Tin Sinh Viên"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.5F)
        Label8.Location = New Point(176, 461)
        Label8.Name = "Label8"
        Label8.Size = New Size(364, 21)
        Label8.TabIndex = 17
        Label8.Text = "Bạn xác minh và cập nhật đầy đủ thông tin cá nhân." + vbCrLf
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(120, 535)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(171, 52)
        btnupdate.TabIndex = 18
        btnupdate.Text = "Cập Nhật"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btncannel
        ' 
        btncannel.Location = New Point(511, 535)
        btncannel.Name = "btncannel"
        btncannel.Size = New Size(171, 52)
        btncannel.TabIndex = 19
        btncannel.Text = "Thoát"
        btncannel.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.5F)
        Label9.Location = New Point(176, 484)
        Label9.Name = "Label9"
        Label9.Size = New Size(607, 21)
        Label9.TabIndex = 20
        Label9.Text = "Trong trường hợp mất mật khẩu hãy báo cho phòng kĩ thuật để được cấp lại mật khẩu."
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(93, 461)
        Label10.Name = "Label10"
        Label10.Size = New Size(77, 32)
        Label10.TabIndex = 21
        Label10.Text = "Lưu ý"
        ' 
        ' InfoAccountform
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(865, 612)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(btncannel)
        Controls.Add(btnupdate)
        Controls.Add(Label8)
        Controls.Add(Label1)
        Controls.Add(cbgioitinh)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Margin = New Padding(3, 4, 3, 4)
        Name = "InfoAccountform"
        Text = "ExamStudent - InfoAccount"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbgioitinh As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents btncannel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
