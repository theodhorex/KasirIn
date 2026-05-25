Imports MySql.Data.MySqlClient

Public Class DBConnection
    Private Shared ReadOnly ConnectionString As String = "Server=localhost;Database=db_kasirin;Uid=root;Pwd=;"

    Public Shared Function GetConnection() As MySqlConnection
        Try
            Dim connection As New MySqlConnection(ConnectionString)
            connection.Open()
            Return connection
        Catch ex As MySqlException
            MsgBox("Koneksi database gagal: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            Return Nothing
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Shared Function TestConnection() As Boolean
        Try
            Dim connection As MySqlConnection = GetConnection()
            If connection IsNot Nothing Then
                connection.Close()
                Console.WriteLine("Database connected successfully.")
                Return True
            End If
            Return False
        Catch ex As Exception
            Console.WriteLine("Connection test failed: " & ex.Message)
            Return False
        End Try
    End Function
End Class
