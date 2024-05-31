Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class EditExam
    Public maDe As String
    Public maKhoa As String
    Public maMonHoc As String
    Public tenDe As String
    Public soPhut As Integer
    Public hienDeThi As Boolean
    Public userName As String
    Dim sql As String

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Xác nhận xoá đề thi?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.No Then
            Return
        End If
        Dim params As New List(Of SqlParameter)

        ' Xoá câu hỏi
        sql = "DELETE FROM CauHoi WHERE MaDeThi = @Made"
        params.Add(New SqlParameter("@Made", maDe))
        If Not runSqlCommand(sql, params) Then
            MessageBox.Show("Xoá đề thi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        params.Clear()

        ' Xoá thông tin đề
        sql = "DELETE FROM DeThi WHERE MaDeThi = @Made"
        params.Add(New SqlParameter("@Made", maDe))
        If runSqlCommand(sql, params) Then
            ExamManagement.loadData("SELECT * FROM DeThi", Nothing)
            log(userName, "Xoá đề thi", "Thành công", "Xoá đề thi " & maDe)
            Close()
        Else
            MessageBox.Show("Xoá đề thi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            log(userName, "Xoá đề thi", "Thất bại", "Xoá đề thi " & maDe)
        End If

    End Sub

    Private Sub EditExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataTable As DataTable = getData("SELECT MaKhoa FROM Khoa", Nothing)
        For Each row As DataRow In dataTable.Rows
            cbbMaKhoa.Items.Add(row("MaKhoa"))
        Next
        dataTable = getData("SELECT Mamonhoc FROM Monhoc", Nothing)
        For Each row As DataRow In dataTable.Rows
            cbbMaMonHoc.Items.Add(row("Mamonhoc"))
        Next
        txtMaDe.Text = maDe
		cbbMaKhoa.SelectedItem = maKhoa
		cbbMaMonHoc.SelectedItem = maMonHoc
		txtTenDe.Text = tenDe
        numMinute.Value = soPhut
        cbAnHien.Checked = hienDeThi
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If cbbMaKhoa.SelectedItem = "" Or txtTenDe.Text = "" Then
            MessageBox.Show("Không được để trống thông tin!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("Xác nhận thay đổi thông tin?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.No Then
                Return
            End If
            Dim params As New List(Of SqlParameter)
            sql = "UPDATE DeThi SET MaKhoa = @MaKhoa, Mamonhoc = @MaMonHoc, ThoiGian = @ThoiGian, HienDeThi = @HienDeThi WHERE MaDeThi = @MaDe"
            params.Add(New SqlParameter("@MaKhoa", cbbMaKhoa.SelectedItem))
            params.Add(New SqlParameter("@MaMonHoc", cbbMaMonHoc.SelectedItem))
            params.Add(New SqlParameter("@MaDe", maDe))
            params.Add(New SqlParameter("@ThoiGian", numMinute.Value))
            params.Add(New SqlParameter("@HienDeThi", If(cbAnHien.Checked, 1, 0)))
            If Not runSqlCommand(sql, params) Then
                MessageBox.Show("Chỉnh sửa đề thi thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                log(userName, "Chỉnh sửa đề thi", "Thất bại", "Chỉnh sửa đề thi " & maDe)
            Else
                ExamManagement.loadData("SELECT * FROM DeThi", Nothing)
                log(userName, "Chỉnh sửa đề thi", "Thành công", "Chỉnh sửa đề thi " & maDe)
            End If
        End If
    End Sub

    Private Sub EditExam_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EditType.Close()
        ExamManagement.Show()
    End Sub

	Private Sub cbAnHien_CheckedChanged(sender As Object, e As EventArgs) Handles cbAnHien.CheckedChanged
        cbAnHien.Text = If(cbAnHien.Checked, "Hiện", "Ẩn")
    End Sub

    Private Sub cbbMaMonHoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMaMonHoc.SelectedIndexChanged
        sql = "SELECT Tenmonhoc FROM Monhoc WHERE Mamonhoc = @MaMonHoc"
        Dim params As New List(Of SqlParameter) From {New SqlParameter("@MaMonHoc", cbbMaMonHoc.SelectedItem)}
        Dim dataTable As DataTable = getData(sql, params)

        If dataTable.Rows.Count > 0 Then
            txtTenDe.Text = dataTable.Rows(0)("Tenmonhoc")
        Else
            MessageBox.Show("Không tìm thấy thông tin môn học này!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class