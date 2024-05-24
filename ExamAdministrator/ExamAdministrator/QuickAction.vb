Imports System
Imports System.Data
Imports System.Data.SqlClient
Module QuickAction
	Public sqlCon As SqlClient.SqlConnection
	Public dataAdapter As SqlClient.SqlDataAdapter
	Public dataTable As DataTable
	Dim sqlCommand As SqlCommand
	Public sql As String

	Public Function runSqlCommand(sql As String, params As List(Of SqlParameter)) As Boolean
		Try
			sqlCommand = New SqlCommand(sql, sqlConnect())
			If params IsNot Nothing Then
				If params.Count > 0 Then
					sqlCommand.Parameters.AddRange(params.ToArray())
				End If
			End If
			If sqlCon.State <> ConnectionState.Open Then sqlCon.Open()
			sqlCommand.ExecuteNonQuery()
			Return True
		Catch ex As Exception
			Debug.WriteLine("====================================")
			Debug.WriteLine(sql)
			Debug.WriteLine("====================================")
			Debug.WriteLine(ex.ToString())
			Return False
		End Try
	End Function

	Public Function sqlConnect() As SqlConnection
		Dim machineName As String = Environment.MachineName
		sqlCon = New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
		Return sqlCon
	End Function

	Public Function getData(sql As String, params As List(Of SqlParameter)) As DataTable
		dataTable = New DataTable
		Dim machineName As String = Environment.MachineName
		Using sqlCon As New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
			Using sqlCommand As New SqlCommand(sql, sqlCon)
				If params IsNot Nothing Then
					If params.Count > 0 Then
						sqlCommand.Parameters.AddRange(params.ToArray())
					End If
				End If
				Using dataAdapter As New SqlDataAdapter(sqlCommand)
					dataAdapter.Fill(dataTable)
				End Using
			End Using
		End Using
		Return dataTable
	End Function

	Public Sub assignData(dgName As DataGridView, sql As String, params As List(Of SqlParameter))
		dgName.DataSource = getData(sql, params)
	End Sub

	Public Function checkExists(fieldName As String, tableName As String, value As String) As Boolean
		sql = "SELECT " + fieldName + " FROM " + tableName + " WHERE " + fieldName + "=@value"
		Dim params As New List(Of SqlParameter)()
		params.Add(New SqlParameter("@value", value))
		dataTable = getData(sql, params)
		Return dataTable.Rows.Count > 0
	End Function

	Public Sub log(userName As String, operation As String, status As String, details As String)
		sql = "INSERT INTO Loginfo (Tennguoidung, Hoatdong, Trangthai, thoigian, chitiet) VALUES (@userName, @operation, @status, GETDATE(), @details)"
		Dim params As New List(Of SqlParameter)()
		params.Add(New SqlParameter("@userName", userName))
		params.Add(New SqlParameter("@operation", operation))
		params.Add(New SqlParameter("@status", status))
		params.Add(New SqlParameter("@details", details))
		runSqlCommand(sql, params)
	End Sub
End Module
