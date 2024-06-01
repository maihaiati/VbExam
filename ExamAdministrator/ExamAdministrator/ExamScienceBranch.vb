Imports System.Data.SqlClient

Public Class ExamScienceBranch
    Public userName As String
    Dim machineName As String = Environment.MachineName
    Dim connectionString As String = "Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;"
    Dim connection As New SqlConnection(connectionString)

    Private Sub ExamScienceBranch_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        assignData(DGVKhoa, "SELECT * FROM Khoa", Nothing)
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim query As String = "INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES (@MaKhoa, @TenKhoa)"
        Dim params As New List(Of SqlParameter)
        params.Add(New SqlParameter("@MaKhoa", txtmakhoa.Text))
        params.Add(New SqlParameter("@TenKhoa", txttkhoa.Text))
        If runSqlCommand(query, params) Then
            MessageBox.Show("Thêm thành công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Thêm thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        LoadData()
        txtmakhoa.Text = ""
        txttkhoa.Text = ""
    End Sub

    Private Sub btnchinhsua_Click(sender As Object, e As EventArgs) Handles btnchinhsua.Click
        Dim result As DialogResult = MessageBox.Show("Xác nhận chỉnh sửa Khoa?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.No Then
            Return
        End If
        Dim query As String = "UPDATE Khoa SET TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoa"
        Dim params As New List(Of SqlParameter)
        params.Add(New SqlParameter("@MaKhoa", txtmakhoa.Text))
        params.Add(New SqlParameter("@TenKhoa", txttkhoa.Text))
        If runSqlCommand(query, params) Then
            MessageBox.Show("Cập Nhập Thành Công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Cập Nhập Thất Bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        LoadData()
        txtmakhoa.Text = ""
        txttkhoa.Text = ""
    End Sub

    Private Sub ExamScienceBranch_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVKhoa.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGVKhoa.Rows(e.RowIndex)
            txtmakhoa.Text = row.Cells("MaKhoa").Value.ToString()
            txttkhoa.Text = row.Cells("TenKhoa").Value.ToString()
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim result As DialogResult = MessageBox.Show("Xác nhận xoá khoa và tất cả những người thuộc khoa này?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.No Then
            Return
        End If
        ' Xóa những người liên quan đến khoa
        Dim deleteGVQuery As String = "DELETE FROM GiangVien WHERE Khoa = @MaKhoa"
        Dim params As New List(Of SqlParameter)
        params.Add(New SqlParameter("@MaKhoa", txtmakhoa.Text))
        If Not runSqlCommand(deleteGVQuery, params) Then
            Throw New Exception("Xoá người trong khoa thất bại.")
        End If
        ' Xóa khoa
        Dim deleteKhoaQuery As String = "DELETE FROM Khoa WHERE MaKhoa = @MaKhoa"
        If Not runSqlCommand(deleteKhoaQuery, params) Then
            Throw New Exception("Xoá khoa thất bại.")
        Else
            ' Cam kết giao dịch nếu cả hai lệnh xoá thành công
            MessageBox.Show("Xoá Thành Công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LoadData()
        txtmakhoa.Text = ""
        txttkhoa.Text = ""
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Hide()
        Dashboard.Show()
    End Sub
End Class