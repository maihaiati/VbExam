Public Class EditType
    Public maDe As String
    Public maKhoa As String
    Public tenDe As String

    Private Sub btnProperties_Click(sender As Object, e As EventArgs) Handles btnProperties.Click
        EditExam.maDe = maDe
        EditExam.maKhoa = maKhoa
        EditExam.tenDe = tenDe
        Hide()
        EditExam.Show()
    End Sub

    Private Sub btnQuestion_Click(sender As Object, e As EventArgs) Handles btnQuestion.Click
        ExamManagement.Hide()
        Hide()
        EditQuestions.Show()
    End Sub
End Class