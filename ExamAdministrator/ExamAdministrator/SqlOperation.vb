Imports System
Imports System.Data
Imports System.Data.SqlClient
Module SqlOperation
	Public sqlCon As SqlClient.SqlConnection
	Public dataAdapter As SqlClient.SqlDataAdapter
	Public dataTable As DataTable
	Dim sqlCommand As SqlCommand
	Public sql As String

	Public Function runSqlCommand(sql As String) As Boolean
		On Error GoTo Ex
		sqlCommand = New SqlCommand(sql, sqlConnect())
		If sqlCon.State <> ConnectionState.Open Then sqlCon.Open()
		sqlCommand.ExecuteNonQuery()
		runSqlCommand = True
		Exit Function
Ex:
		runSqlCommand = False
	End Function

	Public Function sqlConnect() As SqlConnection
		Dim machineName As String = Environment.MachineName
		sqlCon = New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
		Return sqlCon
	End Function

	Public Function getData(sql As String) As DataTable
		dataAdapter = New SqlDataAdapter(sql, sqlConnect())
		dataTable = New DataTable
		dataAdapter.Fill(dataTable)
		Return dataTable
	End Function

	Public Sub assignData(dgName As DataGridView, sql As String)
		dgName.DataSource = getData(sql)
	End Sub
End Module
