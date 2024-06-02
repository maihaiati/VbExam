<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmInfoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmInfoForm))
        Label1 = New Label()
        picture = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        btnConfirm = New Button()
        btnDenied = New Button()
        Label14 = New Label()
        lbMSV = New Label()
        lbHoTen = New Label()
        lbNgaySinh = New Label()
        lbGioiTinh = New Label()
        lbLop = New Label()
        lbKhoa = New Label()
        CType(picture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(189, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(343, 46)
        Label1.TabIndex = 0
        Label1.Text = "Xác Nhận Thông Tin"
        ' 
        ' picture
        ' 
        picture.Location = New Point(24, 107)
        picture.Name = "picture"
        picture.Size = New Size(192, 255)
        picture.SizeMode = PictureBoxSizeMode.Zoom
        picture.TabIndex = 1
        picture.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(242, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 2
        Label2.Text = "MÃ SINH VIÊN:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.Blue
        Label3.Location = New Point(242, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 20)
        Label3.TabIndex = 3
        Label3.Text = "HỌ TÊN:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.Blue
        Label4.Location = New Point(242, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 20)
        Label4.TabIndex = 4
        Label4.Text = "NGÀY SINH:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(242, 253)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 20)
        Label5.TabIndex = 5
        Label5.Text = "GIỚI TÍNH:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Control
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.Blue
        Label6.Location = New Point(242, 299)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 6
        Label6.Text = "LỚP:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.Blue
        Label7.Location = New Point(242, 341)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 20)
        Label7.TabIndex = 7
        Label7.Text = "KHOA:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(24, 377)
        Label8.Name = "Label8"
        Label8.Size = New Size(651, 20)
        Label8.TabIndex = 8
        Label8.Text = "___________________________________________________________________________________________________________"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Underline)
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(24, 408)
        Label9.Name = "Label9"
        Label9.Size = New Size(95, 28)
        Label9.TabIndex = 16
        Label9.Text = "Nội Quy:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label10.Location = New Point(24, 457)
        Label10.Name = "Label10"
        Label10.Size = New Size(325, 40)
        Label10.TabIndex = 17
        Label10.Text = "1. Đến phòng thi sớm 15-20 phút để ổn định " & vbCrLf & "chỗ ngồi."
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label11.Location = New Point(24, 519)
        Label11.Name = "Label11"
        Label11.Size = New Size(342, 40)
        Label11.TabIndex = 18
        Label11.Text = "2. Không mang theo tài liệu, điện thoại di động " & vbCrLf & "hoặc các thiết bị điện tử khác vào phòng thi."
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label12.Location = New Point(24, 583)
        Label12.Name = "Label12"
        Label12.Size = New Size(336, 40)
        Label12.TabIndex = 19
        Label12.Text = "3. Không nói chuyện, trao đổi với thí sinh khác " & vbCrLf & "hoặc có hành vi gian lận trong thi."
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Underline)
        Label13.ForeColor = Color.Red
        Label13.Location = New Point(416, 413)
        Label13.Name = "Label13"
        Label13.Size = New Size(229, 46)
        Label13.TabIndex = 20
        Label13.Text = "Hãy kiểm tra những thông " & vbCrLf & "tin trên đã đúng chưa?"
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.Lime
        btnConfirm.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnConfirm.Location = New Point(416, 485)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(94, 59)
        btnConfirm.TabIndex = 21
        btnConfirm.Text = "Đúng, tôi " & vbCrLf & "đồng ý"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' btnDenied
        ' 
        btnDenied.BackColor = Color.Red
        btnDenied.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDenied.Location = New Point(551, 485)
        btnDenied.Name = "btnDenied"
        btnDenied.Size = New Size(94, 59)
        btnDenied.TabIndex = 22
        btnDenied.Text = "Chưa, cần " & vbCrLf & "sửa lại"
        btnDenied.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(411, 573)
        Label14.Name = "Label14"
        Label14.Size = New Size(263, 40)
        Label14.TabIndex = 23
        Label14.Text = "Lưu ý: Sau khi xác nhận, bạn sẽ tự chịu " & vbCrLf & "trách nhiệm với thông tin của mình!"
        ' 
        ' lbMSV
        ' 
        lbMSV.AutoSize = True
        lbMSV.Location = New Point(379, 113)
        lbMSV.Name = "lbMSV"
        lbMSV.Size = New Size(61, 20)
        lbMSV.TabIndex = 24
        lbMSV.Text = "Label15"
        ' 
        ' lbHoTen
        ' 
        lbHoTen.AutoSize = True
        lbHoTen.Location = New Point(379, 155)
        lbHoTen.Name = "lbHoTen"
        lbHoTen.Size = New Size(61, 20)
        lbHoTen.TabIndex = 25
        lbHoTen.Text = "Label16"
        ' 
        ' lbNgaySinh
        ' 
        lbNgaySinh.AutoSize = True
        lbNgaySinh.Location = New Point(379, 199)
        lbNgaySinh.Name = "lbNgaySinh"
        lbNgaySinh.Size = New Size(61, 20)
        lbNgaySinh.TabIndex = 26
        lbNgaySinh.Text = "Label17"
        ' 
        ' lbGioiTinh
        ' 
        lbGioiTinh.AutoSize = True
        lbGioiTinh.Location = New Point(379, 253)
        lbGioiTinh.Name = "lbGioiTinh"
        lbGioiTinh.Size = New Size(61, 20)
        lbGioiTinh.TabIndex = 27
        lbGioiTinh.Text = "Label18"
        ' 
        ' lbLop
        ' 
        lbLop.AutoSize = True
        lbLop.Location = New Point(379, 299)
        lbLop.Name = "lbLop"
        lbLop.Size = New Size(61, 20)
        lbLop.TabIndex = 28
        lbLop.Text = "Label19"
        ' 
        ' lbKhoa
        ' 
        lbKhoa.AutoSize = True
        lbKhoa.Location = New Point(379, 341)
        lbKhoa.Name = "lbKhoa"
        lbKhoa.Size = New Size(61, 20)
        lbKhoa.TabIndex = 29
        lbKhoa.Text = "Label20"
        ' 
        ' ConfirmInfoForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(686, 651)
        Controls.Add(lbKhoa)
        Controls.Add(lbLop)
        Controls.Add(lbGioiTinh)
        Controls.Add(lbNgaySinh)
        Controls.Add(lbHoTen)
        Controls.Add(lbMSV)
        Controls.Add(Label14)
        Controls.Add(btnDenied)
        Controls.Add(btnConfirm)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(picture)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ConfirmInfoForm"
        Text = "Exam Student - Comfirm infomation"
        CType(picture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picture As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnDenied As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents lbMSV As Label
    Friend WithEvents lbHoTen As Label
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lbGioiTinh As Label
    Friend WithEvents lbLop As Label
    Friend WithEvents lbKhoa As Label
End Class
