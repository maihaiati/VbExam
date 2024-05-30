Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Module QuickAction
	Public sqlCon As SqlClient.SqlConnection
	Public dataAdapter As SqlClient.SqlDataAdapter
	Public dataTable As DataTable
	Dim sqlCommand As SqlCommand
	Public sql As String
	Dim machineName As String = Environment.MachineName

	Public Function runSqlCommand(sql As String, params As List(Of SqlParameter)) As Boolean
		Try
			Using sqlCon As New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
				Using sqlCommand As New SqlCommand(sql, sqlCon)
					If params IsNot Nothing AndAlso params.Count > 0 Then
						For Each param As SqlParameter In params
							' Tạo bản sao của SqlParameter
							Dim newParam As New SqlParameter(param.ParameterName, param.SqlDbType) With {
							.Value = param.Value,
							.Direction = param.Direction,
							.IsNullable = param.IsNullable,
							.Size = param.Size,
							.Precision = param.Precision,
							.Scale = param.Scale
						}
							sqlCommand.Parameters.Add(newParam)
						Next
					End If
					If sqlCon.State <> ConnectionState.Open Then sqlCon.Open()
					sqlCommand.ExecuteNonQuery()
					Return True
				End Using
			End Using
		Catch ex As Exception
			Debug.WriteLine("====================================")
			Debug.WriteLine(sql)
			Debug.WriteLine("====================================")
			Debug.WriteLine(ex.ToString())
			Return False
		End Try
	End Function

	Public Function getData(sql As String, params As List(Of SqlParameter)) As DataTable
		Dim dataTable As New DataTable()
		Using sqlCon As New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
			Using sqlCommand As New SqlCommand(sql, sqlCon)
				If params IsNot Nothing AndAlso params.Count > 0 Then
					For Each param As SqlParameter In params
						' Tạo bản sao của SqlParameter
						Dim newParam As New SqlParameter(param.ParameterName, param.SqlDbType) With {
						.Value = param.Value,
						.Direction = param.Direction,
						.IsNullable = param.IsNullable,
						.Size = param.Size,
						.Precision = param.Precision,
						.Scale = param.Scale
					}
						sqlCommand.Parameters.Add(newParam)
					Next
				End If
				Try
					Using dataAdapter As New SqlDataAdapter(sqlCommand)
						dataAdapter.Fill(dataTable)
					End Using
				Catch ex As Exception
					MessageBox.Show("Đã xảy ra lỗi không xác định!", "Exam Student", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Debug.WriteLine("==========================================")
					Debug.WriteLine(ex.ToString)
					Debug.WriteLine("==========================================")
				End Try
			End Using
		End Using
		Return dataTable
	End Function

	Public Sub assignData(dgName As DataGridView, sql As String, params As List(Of SqlParameter))
		dgName.DataSource = getData(sql, params)
	End Sub

	Public Function checkExists(fieldName As String, tableName As String, value As String) As Boolean
		sql = "SELECT " + fieldName + " FROM " + tableName + " WHERE " + fieldName + "= @value"
		Dim params As New List(Of SqlParameter)
		params.Add(New SqlParameter("@value", value))
		dataTable = getData(sql, params)
		Return dataTable.Rows.Count > 0
	End Function

	Public Sub log(userName As String, operation As String, status As String, details As String)
		sql = "INSERT INTO Loginfo (Tennguoidung, Hoatdong, Trangthai, thoigian, chitiet) VALUES (@userName, @operation, @status, GETDATE(), @details)"
		Dim params As New List(Of SqlParameter)
		params.Add(New SqlParameter("@userName", userName))
		params.Add(New SqlParameter("@operation", operation))
		params.Add(New SqlParameter("@status", status))
		params.Add(New SqlParameter("@details", details))
		runSqlCommand(sql, params)
	End Sub

	Public Function HashPasswordWithSalt(password As String, salt As String) As String
		Dim saltedPassword As String = password & salt

		Using sha256 As SHA256 = SHA256.Create()
			Dim hashBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword))
			Dim hash As New StringBuilder()
			For Each b As Byte In hashBytes
				hash.Append(b.ToString("x2"))
			Next
			Return hash.ToString()
		End Using
	End Function

	Public Function GenerateSalt(length As Integer) As String
		Dim saltBytes(length - 1) As Byte
		RandomNumberGenerator.Fill(saltBytes)
		Dim salt As String = Convert.ToBase64String(saltBytes)
		Return salt
	End Function

	' Hàm chuyển đổi từ mảng byte sang đối tượng Image
	Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
		Using ms As New MemoryStream(byteArray)
			Return Image.FromStream(ms)
		End Using
	End Function

	' Hàm chuyển đổi từ đối tượng Image sang mảng byte
	Function ImageToByteArray(ByVal image As Image) As Byte()
		Using ms As New MemoryStream()
			image.Save(ms, image.RawFormat)
			Return ms.ToArray()
		End Using
	End Function

	' Hàm tải ảnh từ hộp thoại tệp và hiển thị trong PictureBox
	Function LoadImage(picture As PictureBox) As Byte()
		Using ofd As New OpenFileDialog()
			ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
			If ofd.ShowDialog() = DialogResult.OK Then
				Dim img As Image = Image.FromFile(ofd.FileName)
				picture.Image = img
				Return ImageToByteArray(img)
			End If
		End Using
		Return Nothing
	End Function

	' Hàm lấy dữ liệu ảnh từ cơ sở dữ liệu
	Function GetUserImageFromDatabase(ByVal userId As String, ByVal isTeacher As Boolean) As Byte()
		Dim imageData As Byte() = Nothing
		Dim sql As String

		If isTeacher Then
			sql = "SELECT image FROM Giangvien WHERE Magv = @Magv"
		Else
			sql = "SELECT image FROM Sinhvien WHERE Masv = @Masv"
		End If

		Using conn As New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
			Using cmd As New SqlCommand(sql, conn)
				cmd.Parameters.AddWithValue(If(isTeacher, "@Magv", "@Masv"), userId)
				conn.Open()
				Dim reader As SqlDataReader = cmd.ExecuteReader()
				If reader.Read() Then
					If Not IsDBNull(reader("image")) Then
						imageData = CType(reader("image"), Byte())
					End If
				End If
			End Using
		End Using
		Return imageData
	End Function

	Function GetQuestionImageFromDatabase(ByVal maAnh As String) As Byte()
		Dim imageData As Byte() = Nothing

		sql = "SELECT image FROM ImageData WHERE Maanh = @MaAnh"

		Using conn As New SqlConnection("Data Source=" + machineName + ";Initial Catalog=ExamDB;Integrated Security=True;")
			Using cmd As New SqlCommand(sql, conn)
				cmd.Parameters.AddWithValue("@MaAnh", maAnh)
				conn.Open()
				Dim reader As SqlDataReader = cmd.ExecuteReader()
				If reader.Read() Then
					If Not IsDBNull(reader("image")) Then
						imageData = CType(reader("image"), Byte())
					End If
				End If
			End Using
		End Using
		Return imageData
	End Function
End Module
