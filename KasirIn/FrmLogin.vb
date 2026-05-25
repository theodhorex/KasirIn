Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnLogin_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If ValidateInputs() Then
            PerformLogin()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        lblError.Visible = False
        lblError.Text = ""

        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            ShowError("Username tidak boleh kosong")
            txtUsername.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            ShowError("Password tidak boleh kosong")
            txtPassword.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub PerformLogin()
        Try
            btnLogin.Enabled = False
            btnLogin.Text = "Memproses..."

            Dim username As String = txtUsername.Text.Trim()
            Dim password As String = txtPassword.Text

            Dim hashedPassword As String = ComputeSHA256(password)

            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then
                ShowError("Gagal terhubung ke database")
                btnLogin.Enabled = True
                btnLogin.Text = "Login"
                Return
            End If

            Dim query As String = "SELECT id_user, username, nama_lengkap, role, is_active FROM tbl_user WHERE username = @username AND password = @password"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", hashedPassword)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                Dim isActive As Integer = reader("is_active")

                If isActive = 0 Then
                    ShowError("Akun ini tidak aktif")
                    txtPassword.Clear()
                Else
                    SessionHelper.UserId = reader("id_user")
                    SessionHelper.Username = reader("username")
                    SessionHelper.NamaLengkap = reader("nama_lengkap")
                    SessionHelper.Role = reader("role")

                    reader.Close()
                    connection.Close()
                    MsgBox("Login berhasil! Selamat datang, " & SessionHelper.NamaLengkap, MsgBoxStyle.Information, "Success")
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            Else
                ShowError("Username atau password salah")
                txtPassword.Clear()
            End If

            reader.Close()
            connection.Close()

        Catch ex As MySqlException
            ShowError("Database error: " & ex.Message)
        Catch ex As Exception
            ShowError("Error: " & ex.Message)
        Finally
            btnLogin.Enabled = True
            btnLogin.Text = "Login"
        End Try
    End Sub

    Private Function ComputeSHA256(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim builder As New StringBuilder()
            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub ShowError(message As String)
        lblError.Text = message
        lblError.Visible = True
    End Sub
End Class
