Imports System.Data.SqlClient

Public Class ExamFilter
	Dim sql As String
	Dim params As New List(Of SqlParameter)
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		ExamManagement.loadData("SELECT * FROM DeThi", Nothing)
		Close()
	End Sub

	Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If cbAllTrue.Checked Then
			sql = "SELECT * FROM DeThi WHERE" + If(txtMaDeThi.Text <> "", " MaDeThi LIKE @Madethi AND ", "") + If(cbbMaKhoa.SelectedItem <> "", " MaKhoa = @Makhoa AND ", "") + If(cbbMaMonHoc.SelectedItem <> "", " Mamonhoc LIKE @MaMonHoc AND ", "") + " SoCau = " + numOfQues.Value.ToString()
			If txtMaDeThi.Text <> "" Then
				params.Add(New SqlParameter("@Madethi", "%" & txtMaDeThi.Text))
			End If
			If cbbMaKhoa.SelectedItem <> "" Then
				params.Add(New SqlParameter("@Makhoa", cbbMaKhoa.SelectedItem))
			End If
			If cbbMaMonHoc.SelectedItem <> "" Then
				params.Add(New SqlParameter("@MaMonHoc", "%" & cbbMaMonHoc.SelectedItem))
			End If
			ExamManagement.loadData(sql, params)
            'Debug.WriteLine(sql)
        Else
			sql = "SELECT * FROM DeThi WHERE" + If(txtMaDeThi.Text <> "", " MaDeThi LIKE @Madethi OR ", "") + If(cbbMaKhoa.SelectedItem <> "", " MaKhoa = @Makhoa OR ", "") + If(cbbMaMonHoc.SelectedItem <> "", " Mamonhoc LIKE @MaMonHoc OR ", "") + " SoCau = " + numOfQues.Value.ToString()
			If txtMaDeThi.Text <> "" Then
				params.Add(New SqlParameter("@Madethi", "%" & txtMaDeThi.Text))
			End If
			If cbbMaKhoa.SelectedItem <> "" Then
				params.Add(New SqlParameter("@Makhoa", cbbMaKhoa.SelectedItem))
			End If
			If cbbMaMonHoc.SelectedItem <> "" Then
				params.Add(New SqlParameter("@MaMonHoc", "%" & cbbMaMonHoc.SelectedItem))
			End If

			ExamManagement.loadData(sql, params)
			'Debug.WriteLine(sql)
		End If
		params.Clear()
	End Sub

	Private Sub ExamFilter_Load(sender As Object, e As EventArgs) Handles Me.Load
		Dim dataTable As DataTable = getData("SELECT MaKhoa FROM Khoa", Nothing)
		For Each row As DataRow In dataTable.Rows
			cbbMaKhoa.Items.Add(row("MaKhoa"))
		Next
		dataTable = getData("SELECT Mamonhoc FROM Monhoc", Nothing)
		For Each row As DataRow In dataTable.Rows
			cbbMaMonHoc.Items.Add(row("Mamonhoc"))
		Next
	End Sub
End Class