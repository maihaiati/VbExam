Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class DoTest
	Public userName As String
	Public fullName As String
	Public maDeThi As String
	Public imageStudent As Byte() = Nothing
	Dim sql As String
	Dim dataTable As DataTable
	Dim shuffleDataTable As New DataTable
	Dim numOfQues As Integer
	Dim quesIndex As Integer
	Dim machineName As String = Environment.MachineName
	Dim studentAnswer As New List(Of Integer)

	Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
		Using ms As New MemoryStream(byteArray)
			Return Image.FromStream(ms)
		End Using
	End Function

	Function GetImageFromDatabase(ByVal maAnh As String) As Byte()
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

	Private Sub insertImage(rtb As RichTextBox, maAnh As String)
		Dim image As Image = ByteArrayToImage(GetImageFromDatabase(maAnh))
		Clipboard.SetImage(image)
		rtb.Paste()
	End Sub

	Private Sub loadQues(quesIndex As Integer)
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
	End Sub

	Private Sub shuffleQues()
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
		btnMe.Text = fullName
		sql = "SELECT * FROM CauHoi WHERE MaDeThi = @MaDeThi"
		Dim params As New List(Of SqlParameter) From {New SqlParameter("@MaDeThi", maDeThi)}
		dataTable = getData(sql, params)
		If dataTable.Rows.Count > 0 Then
			numOfQues = dataTable.Rows.Count
			For i = 1 To numOfQues
				cbbQues.Items.Add(i)
				studentAnswer.Add(-1)
			Next
			shuffleQues()
			quesIndex = 0
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
		studentAnswer.Item(quesIndex) = 1
		quesIndex += 1
		If quesIndex > numOfQues - 1 Then
			quesIndex = 0
		End If
		loadQues(quesIndex)
	End Sub

	Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
		cbbQues.Items(quesIndex) = cbbQues.SelectedIndex + 1 & " (Đã chọn B)"
		studentAnswer.Item(quesIndex) = 2
		quesIndex += 1
		If quesIndex > numOfQues - 1 Then
			quesIndex = 0
		End If
		loadQues(quesIndex)
	End Sub

	Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
		cbbQues.Items(quesIndex) = cbbQues.SelectedIndex + 1 & " (Đã chọn C)"
		studentAnswer.Item(quesIndex) = 3
		quesIndex += 1
		If quesIndex > numOfQues - 1 Then
			quesIndex = 0
		End If
		loadQues(quesIndex)
	End Sub

	Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
		cbbQues.Items(quesIndex) = cbbQues.SelectedIndex + 1 & " (Đã chọn D)"
		studentAnswer.Item(quesIndex) = 4
		quesIndex += 1
		If quesIndex > numOfQues - 1 Then
			quesIndex = 0
		End If
		loadQues(quesIndex)
	End Sub

	Private Sub DoTest_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		ConfirmInfoForm.Close()
		DashboardForm.Show()
	End Sub
End Class