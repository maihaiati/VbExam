Imports System.Data.SqlClient

Public Class CreateExam
	Public userName As String
	Dim sql As String
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Close()
	End Sub

	Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		Dim params As New List(Of SqlParameter)
		If txtMaDe.Text = "" Or cbbMaKhoa.SelectedItem = "" Or cbbMaMonHoc.SelectedItem = "" Then
			MessageBox.Show("Không được để trống thông tin!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		Else
			If txtMaDe.Text.Length > 40 Then
				MessageBox.Show("Mã đề không được quá 40 ký tự!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
			sql = "INSERT INTO DeThi (MaDeThi, MaKhoa, Mamonhoc, SoCau, ThoiGian, HienDeThi) VALUES (@Madethi, @Makhoa, @Mamonhoc, 0, @ThoiGian, @HienDeThi)"
			params.Add(New SqlParameter("@Madethi", txtMaDe.Text))
			params.Add(New SqlParameter("@Makhoa", cbbMaKhoa.Text))
			params.Add(New SqlParameter("@Mamonhoc", cbbMaMonHoc.SelectedItem))
			params.Add(New SqlParameter("@ThoiGian", numMinute.Value))
			params.Add(New SqlParameter("@HienDeThi", If(cbAnHien.Checked, 1, 0)))
			If runSqlCommand(sql, params) Then
				ExamManagement.loadData("SELECT * FROM DeThi", Nothing)
				MessageBox.Show("Tạo đề thi thành công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				MessageBox.Show("Tạo đề thi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			End If
		End If
	End Sub

	Private Sub cbAnHien_CheckedChanged(sender As Object, e As EventArgs) Handles cbAnHien.CheckedChanged
		cbAnHien.Text = If(cbAnHien.Checked, "Hiện", "Ẩn")
	End Sub

	Private Sub CreateExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim dataTable As DataTable = getData("SELECT MaKhoa FROM Khoa", Nothing)

		For Each row As DataRow In dataTable.Rows
			cbbMaKhoa.Items.Add(row("MaKhoa"))
		Next

		dataTable = getData("SELECT Mamonhoc FROM Monhoc", Nothing)

		For Each row As DataRow In dataTable.Rows
			cbbMaMonHoc.Items.Add(row("Mamonhoc"))
		Next
	End Sub

	Private Sub cbbMaMonHoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMaMonHoc.SelectedIndexChanged
		sql = "SELECT Tenmonhoc FROM Monhoc WHERE Mamonhoc = @MaMonHoc"
		Dim params As New List(Of SqlParameter) From {New SqlParameter("@MaMonHoc", cbbMaMonHoc.SelectedItem)}
		Dim dataTable As DataTable = getData(sql, params)

		If dataTable.Rows.Count > 0 Then
			txtTenDe.Text = dataTable.Rows(0)("Tenmonhoc")
		Else
			MessageBox.Show("Không tìm thấy thông tin môn học này!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub
End Class