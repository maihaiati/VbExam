Imports System.Data.SqlClient

Public Class ExamLog
    Private Sub loadData(sql As String, params As List(Of SqlParameter))
        DGV_Log.DataSource = getData(sql, params)
    End Sub
    Private Sub txttimkiem_TextChanged(sender As Object, e As EventArgs) Handles txttimkiem.TextChanged
        Dim params As New List(Of SqlParameter)
        params.Add(New SqlParameter("@TenNguoiDung", "%" & txttimkiem.Text & "%"))
        loadData("SELECT * FROM Loginfo WHERE TenNguoiDung LIKE @TenNguoiDung", params)
    End Sub

    Private Sub ExamLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData("SELECT * FROM Loginfo", Nothing)
    End Sub
End Class