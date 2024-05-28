Imports System.Data.SqlClient

Public Class ExamFilter
	Dim sql As String
	Dim params As New List(Of SqlParameter)
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Close()
	End Sub

	Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If cbAllTrue.Checked Then
			sql = "SELECT * FROM DeThi WHERE" + If(txtMaDeThi.Text <> "", " MaDeThi = @Madethi AND ", "") + If(txtMaKhoa.Text <> "", " MaKhoa = @Makhoa AND ", "") + If(txtTenDeThi.Text <> "", " TenDeThi = @Tendethi AND ", "") + " SoCau = " + numOfQues.Value.ToString() + ""
			If txtMaDeThi.Text <> "" Then
                params.Add(New SqlParameter("@Madethi", txtMaDeThi.Text))
            End If
            If txtMaKhoa.Text <> "" Then
                params.Add(New SqlParameter("@Makhoa", txtMaKhoa.Text))
            End If
            If txtTenDeThi.Text <> "" Then
                params.Add(New SqlParameter("@Tendethi", txtTenDeThi))
            End If
            ExamManagement.loadData(sql, params)
            'Debug.WriteLine(sql)
        Else
			sql = "SELECT * FROM DeThi WHERE" + If(txtMaDeThi.Text <> "", " MaDeThi = @Madethi OR ", "") + If(txtMaKhoa.Text <> "", " MaKhoa = @Makhoa OR ", "") + If(txtTenDeThi.Text <> "", " TenDeThi = @Tendethi OR ", "") + " SoCau = " + numOfQues.Value.ToString()
			If txtMaDeThi.Text <> "" Then
				params.Add(New SqlParameter("@Madethi", txtMaDeThi.Text))
			End If
			If txtMaKhoa.Text <> "" Then
				params.Add(New SqlParameter("@Makhoa", txtMaKhoa.Text))
			End If
			If txtTenDeThi.Text <> "" Then
				params.Add(New SqlParameter("@Tendethi", txtTenDeThi))
			End If

			ExamManagement.loadData(sql, params)
			'Debug.WriteLine(sql)
		End If
		params.Clear()
	End Sub
End Class