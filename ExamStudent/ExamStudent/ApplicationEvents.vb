Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
	' The following events are available for MyApplication:
	' Startup: Raised when the application starts, before the startup form is created.
	' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
	' UnhandledException: Raised if the application encounters an unhandled exception.
	' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
	' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

	' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

	' Example:
	' Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
	'
	'   ' Setting the application-wide default Font:
	'   e.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
	'
	'   ' Setting the HighDpiMode for the Application:
	'   e.HighDpiMode = HighDpiMode.PerMonitorV2
	'
	'   ' If a splash dialog is used, this sets the minimum display time:
	'   e.MinimumSplashScreenDisplayTime = 4000
	' End Sub

	Partial Friend Class MyApplication
		Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
			' Kiểm tra database tồn tại
			Dim machineName As String = Environment.MachineName
			Dim connectionString As String = "Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;"
			Dim databaseName As String = "ExamDB"
			Dim except = False

			Using connection As New SqlConnection(connectionString)
				Try
					connection.Open()
					Dim command As New SqlCommand()
					command.Connection = connection
					command.CommandText = "IF DATABASEPROPERTYEX(@dbname, 'Version') IS NOT NULL SELECT 1 ELSE SELECT 0"
					command.Parameters.AddWithValue("@dbname", databaseName)

					Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

					If Not (result = 1) Then
						MessageBox.Show("Cơ sở dữ liệu không tồn tại. Chương trình sẽ thoát!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Stop)
						End
					End If
				Catch ex As Exception
					except = True
				End Try
			End Using

			If except Then
				machineName = Environment.MachineName & "\SQLEXPRESS"
				connectionString = "Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;"

				Using connection As New SqlConnection(connectionString)
					Try
						connection.Open()
						Dim command As New SqlCommand()
						command.Connection = connection
						command.CommandText = "IF DATABASEPROPERTYEX(@dbname, 'Version') IS NOT NULL SELECT 1 ELSE SELECT 0"
						command.Parameters.AddWithValue("@dbname", databaseName)

						Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

						If Not (result = 1) Then
							MessageBox.Show("Cơ sở dữ liệu không tồn tại. Chương trình sẽ thoát!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Stop)
							End
						End If
					Catch ex As Exception
						MessageBox.Show("Lỗi cơ sở dữ liệu!", "Exam Administrator", MessageBoxButtons.OK, MessageBoxIcon.Stop)
						Debug.WriteLine("==============================")
						Debug.WriteLine(ex.ToString)
						Debug.WriteLine("==============================")
						End
					End Try
				End Using
			End If
		End Sub
	End Class
End Namespace
