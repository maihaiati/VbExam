Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Dashboard
	Public fullName As String
	Public userName As String
	Dim sql As String
	Dim params As New List(Of SqlParameter)
	Dim timeInitSuccess = True
	Dim morningStart, morningEnd, noonStart, noonEnd, afternoonStart, afternoonEnd, eveningStart, eveningEnd, nightStart, nightEnd As TimeSpan

	Private Sub updateWelcome()
		If timeInitSuccess Then
			lblLoiChao.Text = "Xin chào " & fullName
			Return
		End If
		Dim currentTime As TimeSpan = DateTime.Now.TimeOfDay
		If currentTime >= morningStart And currentTime <= morningEnd Then
			lblLoiChao.Text = "Chào buổi sáng " & fullName
		ElseIf currentTime >= noonStart And currentTime <= noonEnd Then
			lblLoiChao.Text = "Chào buổi trưa " & fullName
		ElseIf currentTime >= afternoonStart And currentTime <= afternoonEnd Then
			lblLoiChao.Text = "Chào buổi chiều " & fullName
		ElseIf currentTime >= eveningStart And currentTime <= eveningEnd Then
			lblLoiChao.Text = "Chào buổi tối " & fullName
		ElseIf currentTime >= nightStart And currentTime <= nightEnd Then
			lblLoiChao.Text = "Chào buổi đêm " & fullName
		Else
			lblLoiChao.Text = "Xin chào " & fullName
		End If
	End Sub

	Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnMe.Text = fullName
		lblTime.Text = DateTime.Now().ToString("HH:mm:ss")
		If (TimeSpan.TryParse("01:00:00", morningStart) And
			TimeSpan.TryParse("10:59:59", morningEnd) And
			TimeSpan.TryParse("11:00:00", noonStart) And
			TimeSpan.TryParse("12:59:59", noonEnd) And
			TimeSpan.TryParse("13:00:00", afternoonStart) And
			TimeSpan.TryParse("18:59:59", afternoonEnd) And
			TimeSpan.TryParse("19:00:00", eveningStart) And
			TimeSpan.TryParse("22:59:59", eveningEnd) And
			TimeSpan.TryParse("23:00:00", nightStart) And
			TimeSpan.TryParse("00:59:59", nightEnd)) Then
			timeInitSuccess = False
			Debug.WriteLine("Init timeline failed!")
		End If
		updateWelcome()
		sql = "SELECT Administrator FROM Giangvien WHERE Magv = @Magv"
		params.Add(New SqlParameter("@Magv", userName))
		If getData(sql, params).Rows.Item(0).Item("Administrator") = 0 Then
			btnAccount.Enabled = False
		End If
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		Close()
	End Sub

	Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
		AccountManagement.userName = userName
		AccountManagement.fullName = fullName
		AccountManagement.Show()
		Hide()
	End Sub

	Private Sub Dashboard_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
		log(userName, "Đăng xuất", "Thành công", "Đăng xuất")
		LoginForm.Show()
	End Sub

	Private Sub btnExam_Click(sender As Object, e As EventArgs) Handles btnExam.Click
		ExamManagement.userName = userName
		ExamManagement.fullName = fullName
		ExamManagement.Show()
		Hide()
	End Sub

	Private Sub btnMyAcc_Click(sender As Object, e As EventArgs) Handles btnMyAcc.Click
		InfoAccount.userName = userName
		InfoAccount.Show()
	End Sub

	Private Sub btnmonhoc_Click(sender As Object, e As EventArgs) Handles btnmonhoc.Click
		ExamSubject.userName = userName
		ExamSubject.Show()
	End Sub

	Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
		lblTime.Text = DateTime.Now().ToString("HH:mm:ss")
		updateWelcome()
	End Sub

	Private Sub btnKhoa_Click(sender As Object, e As EventArgs) Handles btnKhoa.Click
		ExamDepartment.userName = userName
		ExamDepartment.Show()
	End Sub

	Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
		ScoreManagement.Show()
	End Sub

	Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
		ExamLog.Show()
	End Sub
End Class