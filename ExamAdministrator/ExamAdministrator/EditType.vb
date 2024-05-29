Public Class EditType
    Public maDe As String
    Public maKhoa As String
    Public maMonHoc As String
    Public tenDe As String
    Public soPhut As Integer
    Public hienDeThi As Boolean

    Private Sub btnProperties_Click(sender As Object, e As EventArgs) Handles btnProperties.Click
        EditExam.maDe = maDe
        EditExam.maKhoa = maKhoa
		EditExam.maMonHoc = maMonHoc
		EditExam.tenDe = tenDe
		EditExam.soPhut = soPhut
		EditExam.hienDeThi = hienDeThi
		Hide()
        EditExam.Show()
    End Sub

    Private Sub btnQuestion_Click(sender As Object, e As EventArgs) Handles btnQuestion.Click
        EditQuestions.maDe = maDe
        EditQuestions.maKhoa = maKhoa
        EditQuestions.tenDe = tenDe
        ExamManagement.Hide()
        Hide()
        EditQuestions.Show()
    End Sub
End Class