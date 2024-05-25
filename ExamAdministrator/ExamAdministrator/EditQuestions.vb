Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles

Public Class EditQuestions
	Public maDe As String
	Public maKhoa As String
	Public tenDe As String

	Dim sql As String

	Dim maCauHoi As String
	Dim question As String
	Dim answerA As String
	Dim answerB As String
	Dim answerC As String
	Dim answerD As String
	Dim trueAnswer As Integer
	Dim quesIndex As Integer ' Câu hỏi hiện tại
	Dim numOfQues As Integer ' Tổng số lượng câu hỏi
	Dim dataTable As New DataTable
	Dim imageBytes As Byte() = Nothing
	Dim saved = True

	Function ImageToByteArray(ByVal image As Image) As Byte()
		Using ms As New MemoryStream()
			image.Save(ms, image.RawFormat)
			Return ms.ToArray()
		End Using
	End Function

	' Hàm tải ảnh từ hộp thoại tệp và hiển thị trong PictureBox
	Function LoadImage() As Byte()
		Using ofd As New OpenFileDialog()
			ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
			If ofd.ShowDialog() = DialogResult.OK Then
				Dim img As Image = Image.FromFile(ofd.FileName)
				picPreview.Image = img
				Return ImageToByteArray(img)
			End If
		End Using
		Return Nothing
	End Function

	Function GetImageFromDatabase(ByVal maCauHoi As String) As Byte()
		Dim imageData As Byte() = Nothing

		sql = "SELECT image FROM Giangvien WHERE Magv = @Magv"

			Using conn As New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
			Using cmd As New SqlCommand(sql, conn)
				cmd.Parameters.AddWithValue(If(isTeacher, "@Magv", "@Masv"), userId)
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

	Private Sub loadData(quesIndex As Integer)
		Dim params As New List(Of SqlParameter)
		sql = "SELECT MaCauHoi, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, ThuTuCau FROM CauHoi WHERE MaDeThi = @MaDeThi ORDER BY ThuTuCau ASC"
		params.Add(New SqlParameter("@MaDeThi", maDe))
		dataTable = getData(sql, params)

		If (dataTable.Rows.Count = 0) Then
			createQuestion()
			Return
		End If

		maCauHoi = dataTable.Rows.Item(quesIndex).Item("MaCauHoi")
		question = If(Not IsDBNull(dataTable.Rows.Item(quesIndex).Item("NoiDung")), dataTable.Rows.Item(quesIndex).Item("NoiDung"), "")
		answerA = If(Not IsDBNull(dataTable.Rows.Item(quesIndex).Item("DapAnA")), dataTable.Rows.Item(quesIndex).Item("DapAnA"), "")
		answerB = If(Not IsDBNull(dataTable.Rows.Item(quesIndex).Item("DapAnB")), dataTable.Rows.Item(quesIndex).Item("DapAnB"), "")
		answerC = If(Not IsDBNull(dataTable.Rows.Item(quesIndex).Item("DapAnC")), dataTable.Rows.Item(quesIndex).Item("DapAnC"), "")
		answerD = If(Not IsDBNull(dataTable.Rows.Item(quesIndex).Item("DapAnD")), dataTable.Rows.Item(quesIndex).Item("DapAnD"), "")
		trueAnswer = If(Not IsDBNull(dataTable.Rows.Item(quesIndex).Item("DapAnDung")), dataTable.Rows.Item(quesIndex).Item("DapAnDung"), -1)

		lblQues.Text = "Câu hỏi " & quesIndex + 1
		txtQues.Text = question
		txtA.Text = answerA
		txtB.Text = answerB
		txtC.Text = answerC
		txtD.Text = answerD
		cbbQues.SelectedItem = quesIndex + 1

		Select Case trueAnswer
			Case 1
				radioA.Checked = True
				radioB.Checked = False
				radioC.Checked = False
				radioD.Checked = False
			Case 2
				radioA.Checked = False
				radioB.Checked = True
				radioC.Checked = False
				radioD.Checked = False
			Case 3
				radioA.Checked = False
				radioB.Checked = False
				radioC.Checked = True
				radioD.Checked = False
			Case 4
				radioA.Checked = False
				radioB.Checked = False
				radioC.Checked = False
				radioD.Checked = True
			Case -1
				radioA.Checked = False
				radioB.Checked = False
				radioC.Checked = False
				radioD.Checked = False
		End Select
	End Sub

	Private Sub EditQuestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim params As New List(Of SqlParameter)
		sql = "SELECT COUNT(*) AS SoCau FROM CauHoi WHERE MaDeThi = @MaDeThi"
		params.Add(New SqlParameter("@MaDeThi", maDe))
		dataTable = getData(sql, params)
		numOfQues = dataTable.Rows.Item(0).Item("SoCau")
		quesIndex = 0
		For i = 1 To numOfQues
			cbbQues.Items.Add(i)
		Next
		loadData(quesIndex)
    End Sub

	Private Sub saveData()
		If Not saved Then
			Dim params As New List(Of SqlParameter)
			sql = "UPDATE CauHoi SET NoiDung = @NoiDung, DapAnA = @DapAnA, DapAnB = @DapAnB, DapAnC = @DapAnC, DapAnD = @DapAnD, DapAnDung = @DapAnDung WHERE MaCauHoi = @MaCauHoi"
			params.Add(New SqlParameter("@NoiDung", question))
			params.Add(New SqlParameter("@DapAnA", answerA))
			params.Add(New SqlParameter("@DapAnB", answerB))
			params.Add(New SqlParameter("@DapAnC", answerC))
			params.Add(New SqlParameter("@DapAnD", answerD))
			params.Add(New SqlParameter("@DapAnDung", trueAnswer))
			params.Add(New SqlParameter("@MaCauHoi", maCauHoi))
			If Not runSqlCommand(sql, params) Then
				MessageBox.Show("Lưu câu hỏi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Else
				saved = True
			End If
		End If
	End Sub

	Private Sub EditQuestions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		ExamManagement.Show()
	End Sub

	Private Sub nextQues_Click(sender As Object, e As EventArgs) Handles nextQues.Click
		saveData()
		quesIndex += 1
		If quesIndex > numOfQues - 1 Then
			quesIndex = 0
		End If
		loadData(quesIndex)
	End Sub

	Private Sub previousQues_Click(sender As Object, e As EventArgs) Handles previousQues.Click
		saveData()
		quesIndex -= 1
		If quesIndex < 0 Then
			quesIndex = numOfQues - 1
		End If
		loadData(quesIndex)
	End Sub

	Private Sub txtQues_TextChanged(sender As Object, e As EventArgs) Handles txtQues.TextChanged
		saved = False
		question = txtQues.Text
		If txtQues.Text = "" Then
			nextQues.Enabled = False
			previousQues.Enabled = False
			createQues.Enabled = False
			cbbQues.Enabled = False
		Else
			nextQues.Enabled = True
			previousQues.Enabled = True
			createQues.Enabled = True
			cbbQues.Enabled = True
		End If
	End Sub

	Private Sub txtA_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged
		saved = False
		answerA = txtA.Text
		If txtA.Text = "" Then
			radioA.Enabled = False
		Else
			radioA.Enabled = True
		End If
	End Sub

	Private Sub txtB_TextChanged(sender As Object, e As EventArgs) Handles txtB.TextChanged
		saved = False
		answerB = txtB.Text
		If txtB.Text = "" Then
			radioB.Enabled = False
		Else
			radioB.Enabled = True
		End If
	End Sub

	Private Sub txtC_TextChanged(sender As Object, e As EventArgs) Handles txtC.TextChanged
		saved = False
		answerC = txtC.Text
		If txtC.Text = "" Then
			radioC.Enabled = False
		Else
			radioC.Enabled = True
		End If
	End Sub

	Private Sub txtD_TextChanged(sender As Object, e As EventArgs) Handles txtD.TextChanged
		saved = False
		answerD = txtD.Text
		If txtD.Text = "" Then
			radioD.Enabled = False
		Else
			radioD.Enabled = True
		End If
	End Sub

	Private Sub radioA_CheckedChanged(sender As Object, e As EventArgs) Handles radioA.CheckedChanged
		saved = False
		If radioA.Checked Then
			trueAnswer = 1
		End If
	End Sub

	Private Sub radioB_CheckedChanged(sender As Object, e As EventArgs) Handles radioB.CheckedChanged
		saved = False
		If radioB.Checked Then
			trueAnswer = 2
		End If
	End Sub

	Private Sub radioC_CheckedChanged(sender As Object, e As EventArgs) Handles radioC.CheckedChanged
		saved = False
		If radioC.Checked Then
			trueAnswer = 3
		End If
	End Sub

	Private Sub radioD_CheckedChanged(sender As Object, e As EventArgs) Handles radioD.CheckedChanged
		saved = False
		If radioD.Checked Then
			trueAnswer = 4
		End If
	End Sub

	Private Sub clearData()
		question = ""
		answerA = ""
		answerB = ""
		answerC = ""
		answerD = ""
		trueAnswer = 1
		txtQues.Clear()
		txtA.Clear()
		txtB.Clear()
		txtC.Clear()
		txtD.Clear()
	End Sub

	Private Sub createQuestion()
		Dim params As New List(Of SqlParameter)
		Dim timeID As String
		timeID = getData("SELECT CONCAT(MONTH(GETDATE()), DAY(GETDATE()), YEAR(GETDATE()), '_', DATEPART(HOUR, GETDATE()), DATEPART(MINUTE, GETDATE()), DATEPART(SECOND, GETDATE())) AS TimeID", Nothing).Rows.Item(0).Item("TimeID")
		sql = "INSERT INTO CauHoi (MaCauHoi, MaDeThi, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, ThuTuCau) VALUES (@MaCauHoi, @MaDeThi, N'', NULL, NULL, NULL, NULL, NULL, @ThuTuCau)"
		params.Add(New SqlParameter("@MaCauHoi", maDe & "_" & timeID))
		params.Add(New SqlParameter("@MaDeThi", maDe))
		params.Add(New SqlParameter("@ThuTuCau", numOfQues + 1))
		If Not runSqlCommand(sql, params) Then
			MessageBox.Show("Tạo câu hỏi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		Else
			numOfQues += 1
			cbbQues.Items.Add(numOfQues)
			loadData(numOfQues - 1)
		End If
	End Sub

	Private Sub createQues_Click(sender As Object, e As EventArgs) Handles createQues.Click
		createQuestion()
	End Sub

	Private Sub delQues_Click(sender As Object, e As EventArgs) Handles delQues.Click
		Dim params As New List(Of SqlParameter)
		sql = "DELETE "
	End Sub
End Class