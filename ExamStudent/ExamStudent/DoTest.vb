﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class DoTest
	Public userName As String
	Public fullName As String
	Public maDeThi As String
	Public imageStudent As Byte() = Nothing
	Public ngaySinh As String
	Public gioiTinh As String
	Public lop As String

	Dim sql As String
	Dim dataTable As DataTable ' Dữ liệu đề thi chưa đảo
	Dim shuffleDataTable As New DataTable ' Dữ liệu đề thi đảo
	Dim numOfQues As Integer ' Số câu
	Dim quesIndex As Integer ' Câu hỏi đang xem
	Dim machineName As String = Environment.MachineName ' Lấy tên của máy tính
	Dim studentAnswer As New List(Of Integer) ' Mảng chứa đáp án đã chọn
	Dim progress As Integer = 0 ' Số câu đã làm
	Dim hour As Integer
	Dim minute As Integer
	Dim second As Integer

	Function GetImageFromDatabase(ByVal maAnh As String) As Byte() ' Lấy ảnh từ database theo mã ảnh
		Dim imageData As Byte() = Nothing
		Dim sql As String
		sql = "SELECT image FROM ImageData WHERE Maanh = @MaAnh"

		Using conn As New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
			Using cmd As New SqlCommand(sql, conn)
				cmd.Parameters.AddWithValue("@MaAnh", maAnh)
				conn.Open()
				Dim reader As SqlDataReader = cmd.ExecuteReader()
				If reader.Read() Then
					If Not IsDBNull(reader("image")) Then
						imageData = CType(reader("image"), Byte())
					End If
				End If
			End Using
		End Using
		Return imageData
	End Function

	Private Sub insertImage(rtb As RichTextBox, maAnh As String) ' Chèn ảnh vào textbox
		Dim image As Image = ByteArrayToImage(GetImageFromDatabase(maAnh))
		Clipboard.SetImage(image)
		rtb.Paste()
	End Sub

	Private Sub loadQues(quesIndex As Integer) ' Hàm hiển thị câu hỏi
		Dim quesData As String
		cbbQues.SelectedIndex = quesIndex
		quesData = shuffleDataTable.Rows.Item(quesIndex).Item("NoiDung") & vbCrLf & vbCrLf & "A: " & shuffleDataTable.Rows.Item(quesIndex).Item("DapAnA") & vbCrLf & vbCrLf & "B: " & shuffleDataTable.Rows.Item(quesIndex).Item("DapAnB") & vbCrLf & vbCrLf & "C: " & shuffleDataTable.Rows.Item(quesIndex).Item("DapAnC") & vbCrLf & vbCrLf & "D: " + shuffleDataTable.Rows.Item(quesIndex).Item("DapAnD")
		txtQues.Clear()

		If Not IsDBNull(shuffleDataTable.Rows.Item(quesIndex).Item("Maanh")) Then
			insertImage(txtQues, shuffleDataTable.Rows.Item(quesIndex).Item("Maanh"))
			txtQues.AppendText(vbCrLf & quesData)
		Else
			txtQues.Text = quesData
		End If
		btnA.Enabled = If(shuffleDataTable.Rows.Item(quesIndex).Item("DapAnA") <> "", True, False)
		btnB.Enabled = If(shuffleDataTable.Rows.Item(quesIndex).Item("DapAnB") <> "", True, False)
		btnC.Enabled = If(shuffleDataTable.Rows.Item(quesIndex).Item("DapAnC") <> "", True, False)
		btnD.Enabled = If(shuffleDataTable.Rows.Item(quesIndex).Item("DapAnD") <> "", True, False)
	End Sub

	Private Sub shuffleQues() ' Hàm đảo câu hỏi
		Dim rows As DataRow() = dataTable.Select()
		shuffleDataTable = dataTable.Clone()

		Dim random As New Random()
		Dim index As Integer = rows.Length
		While index > 1
			index -= 1
			Dim randomElement As Integer = random.Next(index + 1)
			Dim temp As DataRow = rows(randomElement)
			rows(randomElement) = rows(index)
			rows(index) = temp
		End While

		For Each row As DataRow In rows
			shuffleDataTable.ImportRow(row)
		Next
	End Sub

	Private Sub DoTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		sql = "SELECT * FROM CauHoi WHERE MaDeThi = @MaDeThi"
		picture.Image = ByteArrayToImage(imageStudent)
		Dim params As New List(Of SqlParameter) From {New SqlParameter("@MaDeThi", maDeThi)}

		dataTable = getData("SELECT * FROM DeThi WHERE MaDeThi = @MaDeThi", params)
		If dataTable.Rows.Count > 0 Then
			lblSoPhut.Text = "Số phút: " & dataTable.Rows(0)("ThoiGian")
			hour = Convert.ToInt32(dataTable.Rows(0)("ThoiGian")) \ 60
			minute = Convert.ToInt32(dataTable.Rows(0)("ThoiGian")) Mod 60
			second = 0

			params.Add(New SqlParameter("@MaMonHoc", dataTable.Rows(0)("Mamonhoc")))
			dataTable = getData("SELECT Tenmonhoc FROM Monhoc WHERE Mamonhoc = @MaMonHoc", params)
			lblTenDeThi.Text = "Tên đề thi: " & dataTable.Rows(0)("Tenmonhoc")
		End If
		lblMsv.Text = "Mã sinh viên: " & userName
		lblHoTen.Text = "Họ và tên: " & fullName
		lblNgaySinh.Text = "Ngày sinh: " & ngaySinh
		lblLop.Text = "Lớp: " & lop
		lblGioiTinh.Text = "Giới tính: " & gioiTinh

		dataTable = getData(sql, params)
		If dataTable.Rows.Count > 0 Then
			numOfQues = dataTable.Rows.Count
			lblSoCau.Text = "Số câu: " & numOfQues
			lblTienTrinh.Text = "Số câu đã làm: " & progress & "/" & numOfQues
			For i = 1 To numOfQues
				cbbQues.Items.Add(i)
				studentAnswer.Add(-1)
			Next
			shuffleQues()
			quesIndex = 0
			countDown()
			Timer.Start()
			loadQues(quesIndex)
		Else
			MessageBox.Show("Không tải được đề thi", "Exam student", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		quesIndex += 1
		If quesIndex > numOfQues - 1 Then
			quesIndex = 0
		End If
		loadQues(quesIndex)
	End Sub

	Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
		quesIndex -= 1
		If quesIndex < 0 Then
			quesIndex = numOfQues - 1
		End If
		loadQues(quesIndex)
	End Sub

	Private Sub cbbQues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbQues.SelectedIndexChanged
		quesIndex = cbbQues.SelectedIndex
		loadQues(quesIndex)
	End Sub

	Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
		cbbQues.Items(quesIndex) = cbbQues.SelectedIndex + 1 & " (Đã chọn A)"
		If studentAnswer.Item(quesIndex) = -1 Then
			progress += 1
		End If
		lblTienTrinh.Text = "Số câu đã làm: " & progress & "/" & numOfQues
		studentAnswer.Item(quesIndex) = 1
		If progress = numOfQues Then
			Dim result As DialogResult = MessageBox.Show("Bạn đã làm xong đề thi. Bạn có muốn nộp bài?", "Exam Student", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
			If result = DialogResult.Yes Then
				scoreCal()
				Return
			End If
		End If
		quesIndex += 1
		If quesIndex > numOfQues - 1 Then
			quesIndex = 0
		End If
		loadQues(quesIndex)
	End Sub

	Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
		cbbQues.Items(quesIndex) = cbbQues.SelectedIndex + 1 & " (Đã chọn B)"
		If studentAnswer.Item(quesIndex) = -1 Then
			progress += 1
		End If
		lblTienTrinh.Text = "Số câu đã làm: " & progress & "/" & numOfQues
		studentAnswer.Item(quesIndex) = 2
		If progress = numOfQues Then
			Dim result As DialogResult = MessageBox.Show("Bạn đã làm xong đề thi. Bạn có muốn nộp bài?", "Exam Student", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
			If result = DialogResult.Yes Then
				scoreCal()
				Return
			End If
		End If
		quesIndex += 1
		If quesIndex > numOfQues - 1 Then
			quesIndex = 0
		End If
		loadQues(quesIndex)
	End Sub

	Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
		cbbQues.Items(quesIndex) = cbbQues.SelectedIndex + 1 & " (Đã chọn C)"
		If studentAnswer.Item(quesIndex) = -1 Then
			progress += 1
		End If
		lblTienTrinh.Text = "Số câu đã làm: " & progress & "/" & numOfQues
		studentAnswer.Item(quesIndex) = 3
		If progress = numOfQues Then
			Dim result As DialogResult = MessageBox.Show("Bạn đã làm xong đề thi. Bạn có muốn nộp bài?", "Exam Student", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
			If result = DialogResult.Yes Then
				scoreCal()
				Return
			End If
		End If
		quesIndex += 1
		If quesIndex > numOfQues - 1 Then
			quesIndex = 0
		End If
		loadQues(quesIndex)
	End Sub

	Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
		cbbQues.Items(quesIndex) = cbbQues.SelectedIndex + 1 & " (Đã chọn D)"
		If studentAnswer.Item(quesIndex) = -1 Then
			progress += 1
		End If
		lblTienTrinh.Text = "Số câu đã làm: " & progress & "/" & numOfQues
		studentAnswer.Item(quesIndex) = 4
		If progress = numOfQues Then
			Dim result As DialogResult = MessageBox.Show("Bạn đã làm xong đề thi. Bạn có muốn nộp bài?", "Exam Student", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
			If result = DialogResult.Yes Then
				scoreCal()
				Return
			End If
		End If
		quesIndex += 1
		If quesIndex > numOfQues - 1 Then
			quesIndex = 0
		End If
		loadQues(quesIndex)
	End Sub

	Private Sub DoTest_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn nộp bài?", "Exam Student", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
		If result = DialogResult.Yes Then
			scoreCal()
		Else
			e.Cancel = True
			Return
		End If
		MessageBox.Show("Chương trình sẽ thoát khỏi đề thi!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
		ConfirmInfoForm.Close()
		DashboardForm.Show()
	End Sub

	Private Sub scoreCal()
		' Vô hiệu hoá các phần tử điều khiển trên form
		btnA.Enabled = False
		btnB.Enabled = False
		btnC.Enabled = False
		btnD.Enabled = False
		btnSubmit.Enabled = False
		cbbQues.Enabled = False
		btnNext.Enabled = False
		btnPrevious.Enabled = False
		' Dừng timer
		Timer.Stop()
		Dim score As Double = 0 ' Điểm
		Dim trueAnsNum As Integer = 0 ' Số câu đúng
		Dim skipNum As Integer = 0 ' Số câu bỏ qua
		For answer = 0 To numOfQues - 1
			If studentAnswer.Item(answer) = shuffleDataTable.Rows.Item(answer).Item("DapAnDung") Then
				trueAnsNum += 1
			ElseIf studentAnswer.Item(answer) = -1 Then
				skipNum += 1
			End If
		Next
		score = (10 / numOfQues) * trueAnsNum
		txtQues.Text = "Điểm của bạn: " & score
	End Sub

	Private Sub countDown() ' Hàm đếm ngược
		Dim strHour, strMinute, strSecond As String
		strHour = If(hour < 10, "0" & hour, hour)
		strMinute = If(minute < 10, "0" & minute, minute)
		strSecond = If(second < 10, "0" & second, second)
		lblThoiGian.Text = "Thời gian còn lại: " & strHour & ":" & strMinute & ":" & strSecond
		If hour = 0 And minute = 0 And second = 0 Then
			Timer.Stop()
			MessageBox.Show("Đã hết thời gian làm bài. Hệ thống sẽ tự động nộp bài", "Exam Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
			scoreCal()
			Return
		End If
		If second > 0 Then
			second -= 1
		Else
			second = 59
			If minute > 0 Then
				minute -= 1
			Else
				minute = 59
				If hour > 0 Then
					hour -= 1
				End If
			End If
		End If
	End Sub

	Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
		countDown()
	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
		Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn nộp bài?", "Exam Student", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
		If result = DialogResult.Yes Then
			scoreCal()
		End If
	End Sub
End Class