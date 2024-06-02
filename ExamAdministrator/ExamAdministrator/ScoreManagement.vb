Imports System.Data.SqlClient

Public Class ScoreManagement
	Public userName As String
	Public fullName As String
	Dim sql As String
	Dim maDiem As String
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

	End Sub

	Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
		If maDiem = "" Then
			Return
		End If
	End Sub

	Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
		If maDiem = "" Then
			Return
		End If
		Dim params As New List(Of SqlParameter) From {New SqlParameter("@MaDiem", maDiem)}
		sql = "DELETE FROM Bangdiem WHERE MaDiem = @MaDiem"
		If Not runSqlCommand(sql, params) Then
			MessageBox.Show("Xoá điểm thi không thành công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub dgScore_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgScore.CellMouseClick
		Dim row As DataGridViewRow = dgScore.Rows(e.RowIndex)
		If row.Cells("MaDiem").Value.ToString = "" Then
			maDiem = ""
			txtMaSV.ReadOnly = False
			txtMaSV.Clear()
			txtDiemThi.Clear()
		Else
			maDiem = row.Cells("MaDiem").Value.ToString
			txtMaSV.ReadOnly = True
			txtMaSV.Text = row.Cells("Masv").Value.ToString
			cbbMaMH.SelectedItem = row.Cells("Mamonhoc").Value.ToString
			txtDiemThi.Text = row.Cells("Diemthi").Value.ToString
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
End Class