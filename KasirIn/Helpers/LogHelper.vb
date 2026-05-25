Imports MySql.Data.MySqlClient
Imports System.Net

Public Class LogHelper

    Public Shared Sub CatatLog(aksi As String, keterangan As String)
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim idUser As Integer = SessionHelper.UserId
            Dim ipAddress As String = GetIPAddress()

            Dim query As String = "INSERT INTO tbl_log_aktivitas (id_user, aksi, keterangan, ip_address, waktu) " &
                "VALUES (@idUser, @aksi, @keterangan, @ipAddress, NOW())"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@idUser", idUser)
            command.Parameters.AddWithValue("@aksi", aksi)
            command.Parameters.AddWithValue("@keterangan", keterangan)
            command.Parameters.AddWithValue("@ipAddress", ipAddress)

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Shared Function GetIPAddress() As String
        Try
            Dim hostName As String = Dns.GetHostName()
            Dim hostEntry As IPHostEntry = Dns.GetHostEntry(hostName)
            For Each ip In hostEntry.AddressList
                If ip.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                    Return ip.ToString()
                End If
            Next
        Catch
        End Try
        Return "localhost"
    End Function

End Class
