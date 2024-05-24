Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security.Principal

Public Class ExamManagement
	Public userName As String
	Public fullName As String
	Dim logout = False
	Dim sql As String

	Public Sub loadData(sql As String, params As List(Of SqlParameter))
		assignData(dgExam, sql, params)
	End Sub
	Private Sub ExamManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnMe.Text = fullName
		loadData("SELECT * FROM DeThi", Nothing)
	End Sub

	Private Sub ExamManagement_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
		ExamFilter.Close()

		If Not logout Then
			Dashboard.Show()
		Else
			Dashboard.Close()
		End If
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		logout = True
		Close()
	End Sub

	Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
		Close()
	End Sub

	Private Sub dgExam_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgExam.CellMouseDoubleClick
		' Lấy số dòng được nhấn
		Dim rowIndex As Integer = e.RowIndex
		' Lấy số cột được nhấn
		Dim columnIndex As Integer = e.ColumnIndex
		' Kiểm tra xem dòng được nhấn có hợp lệ không
		If rowIndex >= 0 AndAlso columnIndex >= 0 Then
			' Lấy dữ liệu của hàng được nhấn
			Dim selectedRow As DataGridViewRow = dgExam.Rows(rowIndex)

			EditType.maDe = selectedRow.Cells("MaDeThi").Value.ToString()
			EditType.maKhoa = selectedRow.Cells("MaKhoa").Value.ToString()
			EditType.tenDe = selectedRow.Cells("TenDeThi").Value.ToString()
			EditType.Show()
		End If
	End Sub

	Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
		ExamFilter.Show()
	End Sub

	Private Sub btnCreateExam_Click(sender As Object, e As EventArgs) Handles btnCreateExam.Click
		CreateExam.Show()
	End Sub
End Class