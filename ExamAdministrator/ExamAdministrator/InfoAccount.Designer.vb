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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoAccount))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        txtMaGV = New TextBox()
        txtTenGV = New TextBox()
        txtChucVu = New TextBox()
        dtpBirth = New DateTimePicker()
        btnEdit = New Button()
        btnCancel = New Button()
        imgAvatar = New PictureBox()
        cbbGender = New ComboBox()
        cbbKhoa = New ComboBox()
        CType(imgAvatar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(241, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 46)
        Label1.TabIndex = 1
        Label1.Text = "Thông tin Hồ sơ"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(295, 319)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 21)
        Label2.TabIndex = 2
        Label2.Text = "Chức Vụ :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(295, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 21)
        Label3.TabIndex = 3
        Label3.Text = "Mã giảng viên :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Location = New Point(295, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 21)
        Label4.TabIndex = 4
        Label4.Text = "Tên giảng viên :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(295, 377)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 21)
        Label5.TabIndex = 5
        Label5.Text = "Mã khoa :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.HotTrack
        Label6.Location = New Point(295, 213)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 21)
        Label6.TabIndex = 6
        Label6.Text = "Ngày sinh :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.HotTrack
        Label7.Location = New Point(295, 268)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 21)
        Label7.TabIndex = 7
        Label7.Text = "Giới Tính :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(59, -144)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 8
        ' 
        ' txtMaGV
        ' 
        txtMaGV.Location = New Point(434, 100)
        txtMaGV.Name = "txtMaGV"
        txtMaGV.ReadOnly = True
        txtMaGV.Size = New Size(259, 27)
        txtMaGV.TabIndex = 9
        ' 
        ' txtTenGV
        ' 
        txtTenGV.Location = New Point(434, 156)
        txtTenGV.Name = "txtTenGV"
        txtTenGV.Size = New Size(259, 27)
        txtTenGV.TabIndex = 11
        ' 
        ' txtChucVu
        ' 
        txtChucVu.Location = New Point(434, 317)
        txtChucVu.Name = "txtChucVu"
        txtChucVu.Size = New Size(259, 27)
        txtChucVu.TabIndex = 10
        ' 
        ' dtpBirth
        ' 
        dtpBirth.CustomFormat = ""
        dtpBirth.Format = DateTimePickerFormat.Short
        dtpBirth.Location = New Point(434, 212)
        dtpBirth.Margin = New Padding(3, 4, 3, 4)
        dtpBirth.Name = "dtpBirth"
        dtpBirth.Size = New Size(163, 27)
        dtpBirth.TabIndex = 12
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(99, 452)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(185, 48)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Thay Đổi Thông Tin"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(462, 452)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(135, 48)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Huỷ Bỏ"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' imgAvatar
        ' 
        imgAvatar.BackColor = SystemColors.ActiveBorder
        imgAvatar.Location = New Point(29, 100)
        imgAvatar.Name = "imgAvatar"
        imgAvatar.Size = New Size(231, 315)
        imgAvatar.SizeMode = PictureBoxSizeMode.Zoom
        imgAvatar.TabIndex = 15
        imgAvatar.TabStop = False
        ' 
        ' cbbGender
        ' 
        cbbGender.FormattingEnabled = True
        cbbGender.Items.AddRange(New Object() {"Nam", "Nữ"})
        cbbGender.Location = New Point(434, 267)
        cbbGender.Name = "cbbGender"
        cbbGender.Size = New Size(151, 28)
        cbbGender.TabIndex = 16
        ' 
        ' cbbKhoa
        ' 
        cbbKhoa.FormattingEnabled = True
        cbbKhoa.Items.AddRange(New Object() {"Nam", "Nữ"})
        cbbKhoa.Location = New Point(434, 376)
        cbbKhoa.Name = "cbbKhoa"
        cbbKhoa.Size = New Size(259, 28)
        cbbKhoa.TabIndex = 17
        ' 
        ' InfoAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(745, 531)
        Controls.Add(cbbKhoa)
        Controls.Add(cbbGender)
        Controls.Add(imgAvatar)
        Controls.Add(btnCancel)
        Controls.Add(btnEdit)
        Controls.Add(dtpBirth)
        Controls.Add(txtTenGV)
        Controls.Add(txtChucVu)
        Controls.Add(txtMaGV)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "InfoAccount"
        Text = "InfoAccount"
        CType(imgAvatar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtMaGV As TextBox
    Friend WithEvents txtTenGV As TextBox
    Friend WithEvents txtChucVu As TextBox
    Friend WithEvents dtpBirth As DateTimePicker
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents imgAvatar As PictureBox
    Friend WithEvents cbbGender As ComboBox
	Friend WithEvents cbbKhoa As ComboBox
End Class
