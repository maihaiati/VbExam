Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ExamDepartment
	Public userName As String
	Public fullName As String
	Dim machineName As String = Environment.MachineName
	Dim logout = False

	Private Sub ExamDepartment_Load(sender As Object, e As EventArgs) Handles Me.Load
		btnMe.Text = fullName
		LoadData()
	End Sub
	Private Sub LoadData()
		assignData(DGVKhoa, "SELECT * FROM Khoa", Nothing)
	End Sub

	Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
		If txtmakhoa.Text = "" Or txttkhoa.Text = "" Then
			MessageBox.Show("Không được để trống thông tin!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If
		Dim query As String = "INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES (@MaKhoa, @TenKhoa)"
		Dim params As New List(Of SqlParameter)
		params.Add(New SqlParameter("@MaKhoa", txtmakhoa.Text))
		params.Add(New SqlParameter("@TenKhoa", txttkhoa.Text))
		If runSqlCommand(query, params) Then
			MessageBox.Show("Thêm thành công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MessageBox.Show("Thêm thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
		LoadData()
		txtmakhoa.Text = ""
		txttkhoa.Text = ""
	End Sub

	Private Sub btnchinhsua_Click(sender As Object, e As EventArgs) Handles btnchinhsua.Click
		Dim result As DialogResult = MessageBox.Show("Xác nhận chỉnh sửa Khoa?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If result = DialogResult.No Then
			Return
		End If
		Dim query As String = "UPDATE Khoa SET TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoa"
		Dim params As New List(Of SqlParameter)
		params.Add(New SqlParameter("@MaKhoa", txtmakhoa.Text))
		params.Add(New SqlParameter("@TenKhoa", txttkhoa.Text))
		If runSqlCommand(query, params) Then
			MessageBox.Show("Cập Nhập Thành Công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MessageBox.Show("Cập Nhập Thất Bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
		LoadData()
		txtmakhoa.Text = ""
		txttkhoa.Text = ""
	End Sub

	Private Sub ExamScienceBranch_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVKhoa.CellMouseClick
		If e.RowIndex >= 0 Then
			Dim row As DataGridViewRow = DGVKhoa.Rows(e.RowIndex)
			txtmakhoa.Text = row.Cells("MaKhoa").Value.ToString()
			txttkhoa.Text = row.Cells("TenKhoa").Value.ToString()
		End If
	End Sub

	Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
		Dim result As DialogResult = MessageBox.Show("Xác nhận xoá khoa và tất cả những người thuộc khoa này?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If result = DialogResult.No Then
			Return
		End If

		Dim params As New List(Of SqlParameter)
		params.Add(New SqlParameter("@MaKhoa", txtmakhoa.Text))

		' Xóa những người liên quan đến khoa
		If getData("SELECT * FROM Giangvien WHERE MaKhoa = @MaKhoa", params).Rows.Count > 0 Or getData("SELECT * FROM Sinhvien WHERE MaKhoa = @MaKhoa", params).Rows.Count > 0 Then
			If Not (runSqlCommand("DELETE FROM Giangvien WHERE MaKhoa = @MaKhoa", params) And runSqlCommand("DELETE FROM Sinhvien WHERE MaKhoa = @MaKhoa", params)) Then
				MessageBox.Show("Xoá người trong khoa thất bại.", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			End If
		End If

		' Xoá bảng điểm
		For Each row As DataRow In getData("SELECT * FROM Monhoc WHERE MaKhoa = @MaKhoa", params).Rows
			params.Clear()
			params.Add(New SqlParameter("@MaMonHoc", row("Mamonhoc")))
			If Not runSqlCommand("DELETE FROM Bangdiem WHERE Mamonhoc = @MaMonHoc", params) Then
				MessageBox.Show("Xoá Thất Bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			End If
		Next

		' Xoá câu hỏi và đề thi
		params.Clear()
		params.Add(New SqlParameter("@MaKhoa", txtmakhoa.Text))
		For Each row As DataRow In getData("SELECT * FROM DeThi WHERE MaKhoa = @MaKhoa", params).Rows
			params.Clear()
			params.Add(New SqlParameter("@MaDeThi", row("MaDeThi")))
			If Not runSqlCommand("DELETE FROM CauHoi WHERE MaDeThi = @MaDeThi", params) Then
				MessageBox.Show("Xoá Thất Bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			End If
			If Not runSqlCommand("DELETE FROM DeThi WHERE MaDeThi = @MaDeThi", params) Then
				MessageBox.Show("Xoá Thất Bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			End If
		Next

		'Xoá môn học
		params.Clear()
		params.Add(New SqlParameter("@MaKhoa", txtmakhoa.Text))
		If Not runSqlCommand("DELETE FROM Monhoc WHERE MaKhoa = @MaKhoa", params) Then
			MessageBox.Show("Xoá khoa thất bại.", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If

		' Xóa khoa
		If Not runSqlCommand("DELETE FROM Khoa WHERE MaKhoa = @MaKhoa", params) Then
			MessageBox.Show("Xoá khoa thất bại.", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		Else
			MessageBox.Show("Xoá Thành Công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If

		LoadData()
		txtmakhoa.Text = ""
		txttkhoa.Text = ""
	End Sub

	Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
		Close()
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		logout = True
		Close()
	End Sub

	Private Sub ExamDepartment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If logout Then
			Dashboard.Close()
		Else
			Dashboard.Show()
		End If
	End Sub

	Private Sub btnMyAccount_Click(sender As Object, e As EventArgs) Handles btnMyAccount.Click
		Dim result As DialogResult = MessageBox.Show("Chuyển sang tài khoản của bạn, các tiến trình bạn thực hiện tại đây sẽ bị loại bỏ. Xác nhận?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If result = DialogResult.Yes Then
			Dashboard.openInfoAccount()
			Close()
		End If
	End Sub
End Class