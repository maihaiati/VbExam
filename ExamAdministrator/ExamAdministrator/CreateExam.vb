Imports System.Data.SqlClient

Public Class CreateExam
	Dim sql As String
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Close()
	End Sub

	Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		Dim params As New List(Of SqlParameter)
		If txtMaDe.Text = "" Or txtMaKhoa.Text = "" Or txtTenDe.Text = "" Then
			MessageBox.Show("Không được để trống thông tin!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Else
			If txtMaDe.Text.Length > 20 Then
				MessageBox.Show("Mã đề không được quá 20 ký tự!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
			sql = "INSERT INTO DeThi (MaDeThi, MaKhoa, TenDeThi, SoCau, ThoiGian) VALUES (@Madethi, @Makhoa, @Tendethi, 0, @ThoiGian)"
			params.Add(New SqlParameter("@Madethi", txtMaDe.Text))
			params.Add(New SqlParameter("@Makhoa", txtMaKhoa.Text))
			params.Add(New SqlParameter("@Tendethi", txtTenDe.Text))
			params.Add(New SqlParameter("@ThoiGian", numMinute.Value))

			If runSqlCommand(sql, params) Then
				ExamManagement.loadData("SELECT * FROM DeThi", Nothing)
			Else
				MessageBox.Show("Tạo đề thi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			End If
		End If
	End Sub
End Class