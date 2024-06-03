Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ScoreManagement
	Public userName As String
	Public fullName As String
	Dim sql As String
	Dim maDiem As String
	Dim logout = False
	Private Sub loadData()
		Dim params As New List(Of SqlParameter)
		params.Add(New SqlParameter("@MaSv", "%" & txtSearchSV.Text & "%"))
		params.Add(New SqlParameter("@MaMonHoc", cbbSearchMH.SelectedItem))
		If txtSearchSV.Text = "" And cbbSearchMH.SelectedItem = "None" Then
			dgScore.DataSource = getData("SELECT * FROM Bangdiem", Nothing)
			Return
		End If
		sql = "SELECT * FROM Bangdiem WHERE Masv LIKE @MaSv Or Mamonhoc = @MaMonHoc"
		dgScore.DataSource = getData(sql, params)
	End Sub
	Private Sub ScoreManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnMe.Text = fullName
		For Each row As DataRow In getData("SELECT Mamonhoc FROM Monhoc", Nothing).Rows
			cbbSearchMH.Items.Add(row("Mamonhoc"))
			cbbMaMH.Items.Add(row("Mamonhoc"))
		Next
		cbbSearchMH.Items.Add("None")
		cbbSearchMH.SelectedItem = "None"
		loadData()
	End Sub

	Private Sub txtSearchSV_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSV.TextChanged
		loadData()
	End Sub

	Private Sub cbbSearchMH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSearchMH.SelectedIndexChanged
		loadData()
	End Sub

	Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
		If txtMaSV.ReadOnly Then
			Return
		End If
		If cbbMaMH.SelectedItem <> "" And txtMaSV.Text <> "" And txtTenMH.Text <> "" Then
			Dim timeID As String = getData("SELECT CONCAT(MONTH(GETDATE()), DAY(GETDATE()), YEAR(GETDATE()), '_', DATEPART(HOUR, GETDATE()), DATEPART(MINUTE, GETDATE()), DATEPART(SECOND, GETDATE())) AS TimeID", Nothing).Rows.Item(0).Item("TimeID")
			Dim params As New List(Of SqlParameter)
			params.Add(New SqlParameter("@MaDiem", timeID))
			params.Add(New SqlParameter("@MaMonHoc", cbbMaMH.SelectedItem))
			params.Add(New SqlParameter("@MaSv", txtMaSV.Text))
			params.Add(New SqlParameter("@TenMonHoc", txtTenMH.Text))
			params.Add(New SqlParameter("@DiemThi", numDiemThi.Value))

			sql = "SELECT * FROM Sinhvien WHERE Masv = @MaSv"
			If getData(sql, params).Rows.Count = 0 Then
				MessageBox.Show("Không tồn tại mã sinh viên!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				log(userName, "Thêm điểm thi", "Thất bại", "Thêm điểm thi cho sv" & txtMaSV.Text)
				Return
			End If

			sql = "INSERT INTO Bangdiem (MaDiem, Mamonhoc, Masv, tenmonhoc, Diemthi) VALUES (@MaDiem, @MaMonHoc, @MaSv, @TenMonHoc, @DiemThi)"
			If Not runSqlCommand(sql, params) Then
				MessageBox.Show("Thêm điểm thi không thành công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				log(userName, "Thêm điểm thi", "Thất bại", "Thêm điểm thi cho sv " & txtMaSV.Text)
			Else
				log(userName, "Thêm điểm thi", "Thành công", "Thêm điểm thi cho sv " & txtMaSV.Text)
			End If

		Else
			MessageBox.Show("Không được để trống thông tin!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			log(userName, "Thêm điểm thi", "Thất bại", "Thêm điểm thi cho sv" & txtMaSV.Text)
		End If
		loadData()
	End Sub

	Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
		If maDiem = "" Then
			Return
		End If
		Dim result As DialogResult = MessageBox.Show("Xác nhận chỉnh sửa điểm thi?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If result = DialogResult.No Then
			Return
		End If
		Dim params As New List(Of SqlParameter)
		params.Add(New SqlParameter("@MaDiem", maDiem))
		params.Add(New SqlParameter("@DiemThi", numDiemThi.Value))
		sql = "UPDATE Bangdiem SET Diemthi = @DiemThi WHERE MaDiem = @MaDiem"
		If Not runSqlCommand(sql, params) Then
			MessageBox.Show("Sửa điểm thi không thành công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			log(userName, "Sửa điểm thi", "Thất bại", "Sửa điểm thi của sv " & txtMaSV.Text)
		Else
			log(userName, "Sửa điểm thi", "Thành công", "Sửa điểm thi của sv " & txtMaSV.Text)
		End If
		loadData()
	End Sub

	Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
		If maDiem = "" Then
			Return
		End If
		Dim result As DialogResult = MessageBox.Show("Xác nhận xoá điểm thi?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If result = DialogResult.No Then
			Return
		End If
		Dim params As New List(Of SqlParameter) From {New SqlParameter("@MaDiem", maDiem)}
		sql = "DELETE FROM Bangdiem WHERE MaDiem = @MaDiem"
		If Not runSqlCommand(sql, params) Then
			MessageBox.Show("Xoá điểm thi không thành công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			log(userName, "Xoá điểm thi", "Thất bại", "Xoá điểm thi của sv " & txtMaSV.Text)
		Else
			log(userName, "Xoá điểm thi", "Thành công", "Xoá điểm thi của sv " & txtMaSV.Text)
		End If
		loadData()
	End Sub

	Private Sub dgScore_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgScore.CellMouseClick
		Dim row As DataGridViewRow = dgScore.Rows(e.RowIndex)
		If row.Cells("MaDiem").Value.ToString = "" Then
			maDiem = ""
			txtMaSV.ReadOnly = False
			cbbMaMH.Enabled = True
			txtMaSV.Clear()
		Else
			maDiem = row.Cells("MaDiem").Value.ToString
			txtMaSV.ReadOnly = True
			cbbMaMH.Enabled = False
			txtMaSV.Text = row.Cells("Masv").Value.ToString
			cbbMaMH.SelectedItem = row.Cells("Mamonhoc").Value.ToString
			numDiemThi.Value = row.Cells("Diemthi").Value
		End If
	End Sub

	Private Sub cbbMaMH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMaMH.SelectedIndexChanged
		Dim params As New List(Of SqlParameter) From {New SqlParameter("@MaMonHoc", cbbMaMH.SelectedItem)}
		Dim dataTable As DataTable = getData("SELECT Tenmonhoc FROM Monhoc WHERE Mamonhoc = @MaMonHoc", params)
		If dataTable.Rows.Count > 0 Then
			txtTenMH.Text = dataTable.Rows(0)("Tenmonhoc")
		Else
			MessageBox.Show("Không tìm thấy thông tin môn học!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		logout = True
		Close()
	End Sub

	Private Sub ScoreManagement_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If logout Then
			Dashboard.Close()
		Else
			Dashboard.Show()
		End If
	End Sub

	Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
		Close()
	End Sub

	Private Sub btnMyAccount_Click(sender As Object, e As EventArgs) Handles btnMyAccount.Click
		Dim result As DialogResult = MessageBox.Show("Chuyển sang tài khoản của bạn, các tiến trình bạn thực hiện tại đây sẽ bị loại bỏ. Xác nhận?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If result = DialogResult.Yes Then
			Dashboard.openInfoAccount()
			Close()
		End If
	End Sub
End Class