Imports System.Data.SqlClient
Public Class PullImage
    Private Sub PullImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Thông tin kết nối SQL Server
        Dim connectionString As String = "Data Source=M2-Desktop;Initial Catalog=ExamDB;Integrated Security=True"

        ' Tạo kết nối
        Using connection As New SqlConnection(connectionString)
            ' Mở kết nối
            connection.Open()

            ' Truy vấn dữ liệu ảnh
            Dim query As String = "SELECT ImageName, ImageData FROM Images WHERE ImageID = @ImageID"
            Dim imageID As Integer = 1 ' ID của ảnh cần lấy

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ImageID", imageID)

                ' Đọc dữ liệu ảnh từ cơ sở dữ liệu
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim imageName As String = reader.GetString(0)
                        Dim imageData As Byte() = DirectCast(reader("ImageData"), Byte())

                        ' Gọi hàm để lưu ảnh ra tệp
                        SaveImageToFile(imageName, imageData)
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub SaveImageToFile(imageName As String, imageData As Byte())
        Dim filePath As String = "D:\TaiLieu\" & imageName ' Đường dẫn tệp ảnh đích

        ' Lưu dữ liệu ảnh ra tệp
        System.IO.File.WriteAllBytes(filePath, imageData)
        Debug.WriteLine("Image saved to " & filePath)
    End Sub
End Class