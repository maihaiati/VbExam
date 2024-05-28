Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class DashboardForm
	Dim sql As String
	Public userName As String
	Public fullName As String

	Private Sub loadData(data As DataTable)
		dgExam.DataSource = data
	End Sub
	Private Sub btnMyAccount_Click(sender As Object, e As EventArgs) Handles btnMyAccount.Click
		InfoAccount.userName = userName
		InfoAccount.Show()
	End Sub

	Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnMe.Text = fullName
		updateList()
	End Sub

	Private Sub DashboardForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		log(userName, "Đăng xuất", "Thành công", "Đăng xuất")
		LoginForm.Show()
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		Close()
	End Sub

	Private Sub updateList()
		Dim currentTime As DateTime = DateTime.Now
		sql = "SELECT MaDeThi, Masv, Tenmonhoc, Lop, Ngaythi, Phongthi FROM Lichthi WHERE Masv = @MaSv"
		Dim params As New List(Of SqlParameter)
		params.Add(New SqlParameter("@MaSv", userName))

		Dim dataTable As DataTable = getData(sql, params)
		Dim result As DataTable = dataTable.Clone()

		If dataTable.Rows.Count > 0 Then
			Dim examTime As DateTime

			For Each row As DataRow In dataTable.Rows
				examTime = Convert.ToDateTime(row("Ngaythi"))

				If currentTime > examTime Then
					result.ImportRow(row)
				End If
			Next

			loadData(result)
		End If
	End Sub

	Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
		updateList()
	End Sub

	Private Sub dgExam_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgExam.CellMouseClick
		' Lấy số dòng được nhấn
		Dim rowIndex As Integer = e.RowIndex
		' Lấy số cột được nhấn
		Dim columnIndex As Integer = e.ColumnIndex
		' Kiểm tra xem dòng được nhấn có hợp lệ không
		If rowIndex >= 0 AndAlso columnIndex >= 0 Then
			' Lấy dữ liệu của hàng được nhấn
			Dim selectedRow As DataGridViewRow = dgExam.Rows(rowIndex)

			If (selectedRow.Cells("Masv").Value.ToString() = "" Or selectedRow.Cells("MaDeThi").Value.ToString() = "") Then
				Return
			End If

			ConfirmInfoForm.userName = selectedRow.Cells("Masv").Value.ToString()
			ConfirmInfoForm.maDeThi = selectedRow.Cells("MaDeThi").Value.ToString()
			ConfirmInfoForm.Show()
			Hide()
		End If
	End Sub
End Class