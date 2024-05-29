Imports System.Data.SqlClient

Public Class ExamSubject
    Dim machineName As String = Environment.MachineName
    Dim connectionString As String = "Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;"
    Dim connection As New SqlConnection(connectionString)
    Private Sub ExamSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim query As String = "SELECT * FROM MonHoc"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DGVMonhoc.DataSource = table
    End Sub
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim query As String = "INSERT INTO MonHoc (Mamonhoc, Tenmonhoc,Sotiet) VALUES (@MaMonHoc, @TenMonHoc, @SoTiet)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@MaMonHoc", txtmamh.Text)
        command.Parameters.AddWithValue("@TenMonHoc", txttmh.Text)
        command.Parameters.AddWithValue("@SoTiet", txtsotiet.Text)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        LoadData()
        MsgBox("Thêm Thành Công!", MsgBoxStyle.Information)
        txtmamh.Text = ""
        txttmh.Text = ""
        txtsotiet.Text = ""
    End Sub
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim query As String = "DELETE FROM MonHoc WHERE MaMonHoc = @MaMonHoc"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@MaMonHoc", txtmamh.Text)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        LoadData()
        MsgBox("Xoá Thành Công!", MsgBoxStyle.Information)
        txtmamh.Text = ""
        txttmh.Text = ""
        txtsotiet.Text = ""
    End Sub

    Private Sub btnchinhsua_Click(sender As Object, e As EventArgs) Handles btnchinhsua.Click
        Dim query As String = "UPDATE MonHoc SET TenMonHoc = @TenMonHoc,SoTiet = @SoTiet WHERE MaMonHoc = @MaMonHoc"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@MaMonHoc", txtmamh.Text)
        command.Parameters.AddWithValue("@TenMonHoc", txttmh.Text)
        command.Parameters.AddWithValue("@SoTiet", txtsotiet.Text)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        LoadData()
        MsgBox("Cập Nhập Thành Công!", MsgBoxStyle.Information)
        txtmamh.Text = ""
        txttmh.Text = ""
        txtsotiet.Text = ""
    End Sub

    Private Sub DGVMonhoc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMonhoc.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGVMonhoc.Rows(e.RowIndex)
            txtmamh.Text = row.Cells("MaMonHoc").Value.ToString()
            txttmh.Text = row.Cells("TenMonHoc").Value.ToString()
            txtsotiet.Text = row.Cells("SoTiet").Value.ToString()
        End If
    End Sub

    Private Sub txttimkiem_KeyUp(sender As Object, e As KeyEventArgs) Handles txttimkiem.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim query As String = "SELECT * FROM MonHoc WHERE MaMonHoc LIKE '%' + @MaMonHoc + '%'"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@MaMonHoc", txttimkiem.Text)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVMonhoc.DataSource = table
        End If
    End Sub
End Class