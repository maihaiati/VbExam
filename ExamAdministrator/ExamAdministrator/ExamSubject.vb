Imports System.Data.SqlClient

Public Class ExamSubject
    Public userName As String
    Dim machineName As String = Environment.MachineName
    Dim connectionString As String = "Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;"
    Dim connection As New SqlConnection(connectionString)
    Private Sub ExamSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        assignData(DGVMonhoc, "SELECT * FROM MonHoc", Nothing)
    End Sub
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim query As String = "INSERT INTO MonHoc (Mamonhoc, Tenmonhoc,Sotiet) VALUES (@MaMonHoc, @TenMonHoc, @SoTiet)"
        Dim params As New List(Of SqlParameter)
        params.Add(New SqlParameter("@MaMonHoc", txtmamh.Text))
        params.Add(New SqlParameter("@TenMonHoc", txttmh.Text))
        params.Add(New SqlParameter("@SoTiet", txtsotiet.Text))
        If runSqlCommand(query, params) Then
            MessageBox.Show("Thêm thành công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Thêm thất bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        LoadData()
        txtmamh.Text = ""
        txttmh.Text = ""
        txtsotiet.Text = ""
    End Sub
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim result As DialogResult = MessageBox.Show("Xác nhận xoá môn học?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.No Then
            Return
        End If
        Dim query As String = "DELETE FROM MonHoc WHERE MaMonHoc = @MaMonHoc"
        Dim params As New List(Of SqlParameter)
        params.Add(New SqlParameter("@MaMonHoc", txtmamh.Text))
        If runSqlCommand(query, params) Then
            MessageBox.Show("Xoá Thành Công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Xoá Thất Bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        LoadData()
        txtmamh.Text = ""
        txttmh.Text = ""
        txtsotiet.Text = ""
    End Sub

    Private Sub btnchinhsua_Click(sender As Object, e As EventArgs) Handles btnchinhsua.Click
        Dim result As DialogResult = MessageBox.Show("Xác nhận chỉnh sửa môn học?", "Exam Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.No Then
            Return
        End If
        Dim query As String = "UPDATE MonHoc SET TenMonHoc = @TenMonHoc,SoTiet = @SoTiet WHERE MaMonHoc = @MaMonHoc"
        Dim params As New List(Of SqlParameter)
        params.Add(New SqlParameter("@MaMonHoc", txtmamh.Text))
        params.Add(New SqlParameter("@TenMonHoc", txttmh.Text))
        params.Add(New SqlParameter("@SoTiet", txtsotiet.Text))
        If runSqlCommand(query, params) Then
            MessageBox.Show("Cập Nhập Thành Công!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Cập Nhập Thất Bại!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        LoadData()
        txtmamh.Text = ""
        txttmh.Text = ""
        txtsotiet.Text = ""
    End Sub

    Private Sub txttimkiem_KeyUp(sender As Object, e As KeyEventArgs) Handles txttimkiem.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim params As New List(Of SqlParameter)
            params.Add(New SqlParameter("@MaMonHoc", txttimkiem.Text))
            assignData(DGVMonhoc, "SELECT * FROM MonHoc WHERE MaMonHoc LIKE '%' + @MaMonHoc + '%'", params)
        End If
    End Sub

    Private Sub DGVMonhoc_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVMonhoc.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGVMonhoc.Rows(e.RowIndex)
            txtmamh.Text = row.Cells("MaMonHoc").Value.ToString()
            txttmh.Text = row.Cells("TenMonHoc").Value.ToString()
            txtsotiet.Text = row.Cells("SoTiet").Value.ToString()
        End If
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Dashboard.Show()
        Hide()
    End Sub
End Class