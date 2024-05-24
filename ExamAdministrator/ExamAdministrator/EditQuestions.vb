Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class EditQuestions
    Public maDe As String
    Public maKhoa As String
    Public tenDe As String

    Dim sql As String
    Dim params As New List(Of SqlParameter)

    Dim question As String
    Dim answerA As String
    Dim answerB As String
    Dim answerC As String
    Dim answerD As String
    Dim trueAnswer As Integer
    Dim quesIndex As Integer
    Dim numOfQues As Integer
    Dim dataTable As New DataTable

    Private Sub loadData(quesIndex As Integer)
        sql = "SELECT NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, ThuTuCau FROM CauHoi WHERE MaDeThi = @MaDeThi"
        params.Add(New SqlParameter("@MaDeThi", maDe))
        dataTable = getData(sql, params)
        question = dataTable.Rows.Item(quesIndex).Item("NoiDung")
        answerA = dataTable.Rows.Item(quesIndex).Item("DapAnA")
        answerB = dataTable.Rows.Item(quesIndex).Item("DapAnB")
        answerC = dataTable.Rows.Item(quesIndex).Item("DapAnC")
        answerD = dataTable.Rows.Item(quesIndex).Item("DapAnD")
        trueAnswer = dataTable.Rows.Item(quesIndex).Item("DapAnDung")

        lblQues.Text = "Câu hỏi " & quesIndex + 1
        txtQues.Text = question
        txtA.Text = answerA
        txtB.Text = answerB
        txtC.Text = answerC
        txtD.Text = answerD

        params.Clear()
    End Sub

    Private Sub EditQuestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData(0)
    End Sub

    Private Sub EditQuestions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ExamManagement.Show()
    End Sub
End Class