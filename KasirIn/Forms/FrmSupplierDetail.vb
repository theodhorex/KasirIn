Imports MySql.Data.MySqlClient

Public Class FrmSupplierDetail
    Private idSupplier As Integer = 0
    Private isEditMode As Boolean = False

    Public Sub New()
        InitializeComponent()
        isEditMode = False
    End Sub

    Public Sub New(id As Integer)
        InitializeComponent()
        idSupplier = id
        isEditMode = True
    End Sub

    Private Sub FrmSupplierDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isEditMode Then
            Me.Text = "Edit Supplier"
            LoadSupplierData()
        Else
            Me.Text = "Tambah Supplier"
            GenerateKodeSupplier()
            chkAktif.Checked = True
        End If
    End Sub

    Private Sub GenerateKodeSupplier()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT COUNT(*) FROM tbl_supplier"
            Dim command As New MySqlCommand(query, connection)
            Dim count As Integer = CInt(command.ExecuteScalar())

            Dim kode As String = "SUP-" & (count + 1).ToString("000")
            txtKode.Text = kode

            connection.Close()

        Catch ex As Exception
            MsgBox("Error generating kode: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LoadSupplierData()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT kode_supplier, nama_supplier, nama_kontak, telepon, email, alamat, is_active " &
                "FROM tbl_supplier WHERE id_supplier = @id"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", idSupplier)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                txtKode.Text = If(reader("kode_supplier") Is Nothing, "", reader("kode_supplier").ToString())
                txtNama.Text = If(reader("nama_supplier") Is Nothing, "", reader("nama_supplier").ToString())
                txtKontak.Text = If(reader("nama_kontak") Is Nothing, "", reader("nama_kontak").ToString())
                txtTelepon.Text = If(reader("telepon") Is Nothing, "", reader("telepon").ToString())
                txtEmail.Text = If(reader("email") Is Nothing, "", reader("email").ToString())
                txtAlamat.Text = If(reader("alamat") Is Nothing, "", reader("alamat").ToString())
                chkAktif.Checked = If(reader("is_active") Is Nothing, True, CInt(reader("is_active")) = 1)
            End If

            reader.Close()
            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading supplier: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrEmpty(txtNama.Text.Trim()) Then
            MsgBox("Nama supplier tidak boleh kosong", MsgBoxStyle.Exclamation)
            txtNama.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtKode.Text.Trim()) Then
            MsgBox("Kode supplier tidak boleh kosong", MsgBoxStyle.Exclamation)
            txtKode.Focus()
            Return False
        End If

        If Not String.IsNullOrEmpty(txtEmail.Text.Trim()) Then
            If Not IsValidEmail(txtEmail.Text.Trim()) Then
                MsgBox("Format email tidak valid", MsgBoxStyle.Exclamation)
                txtEmail.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Private Function IsKodeUnique(kode As String) As Boolean
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return False

            Dim query As String = "SELECT COUNT(*) FROM tbl_supplier WHERE kode_supplier = @kode"
            If isEditMode Then
                query &= " AND id_supplier != @id"
            End If

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@kode", kode)
            If isEditMode Then
                command.Parameters.AddWithValue("@id", idSupplier)
            End If

            Dim count As Integer = CInt(command.ExecuteScalar())
            connection.Close()

            Return count = 0

        Catch ex As Exception
            MsgBox("Error checking kode: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Return

        If Not IsKodeUnique(txtKode.Text.Trim()) Then
            MsgBox("Kode supplier sudah digunakan", MsgBoxStyle.Exclamation)
            txtKode.Focus()
            Return
        End If

        If isEditMode Then
            UpdateSupplier()
        Else
            AddSupplier()
        End If
    End Sub

    Private Sub AddSupplier()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "INSERT INTO tbl_supplier (kode_supplier, nama_supplier, nama_kontak, telepon, email, alamat, is_active, created_at) " &
                "VALUES (@kode, @nama, @kontak, @telepon, @email, @alamat, @isActive, NOW())"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@kode", txtKode.Text.Trim())
            command.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
            command.Parameters.AddWithValue("@kontak", If(String.IsNullOrEmpty(txtKontak.Text), "", txtKontak.Text.Trim()))
            command.Parameters.AddWithValue("@telepon", If(String.IsNullOrEmpty(txtTelepon.Text), "", txtTelepon.Text.Trim()))
            command.Parameters.AddWithValue("@email", If(String.IsNullOrEmpty(txtEmail.Text), "", txtEmail.Text.Trim()))
            command.Parameters.AddWithValue("@alamat", If(String.IsNullOrEmpty(txtAlamat.Text), "", txtAlamat.Text.Trim()))
            command.Parameters.AddWithValue("@isActive", If(chkAktif.Checked, 1, 0))

            command.ExecuteNonQuery()
            connection.Close()

            MsgBox("Supplier berhasil ditambahkan", MsgBoxStyle.Information)
            Me.Close()

        Catch ex As Exception
            MsgBox("Error adding supplier: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub UpdateSupplier()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "UPDATE tbl_supplier SET kode_supplier=@kode, nama_supplier=@nama, " &
                "nama_kontak=@kontak, telepon=@telepon, email=@email, alamat=@alamat, is_active=@isActive " &
                "WHERE id_supplier=@id"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@kode", txtKode.Text.Trim())
            command.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
            command.Parameters.AddWithValue("@kontak", If(String.IsNullOrEmpty(txtKontak.Text), "", txtKontak.Text.Trim()))
            command.Parameters.AddWithValue("@telepon", If(String.IsNullOrEmpty(txtTelepon.Text), "", txtTelepon.Text.Trim()))
            command.Parameters.AddWithValue("@email", If(String.IsNullOrEmpty(txtEmail.Text), "", txtEmail.Text.Trim()))
            command.Parameters.AddWithValue("@alamat", If(String.IsNullOrEmpty(txtAlamat.Text), "", txtAlamat.Text.Trim()))
            command.Parameters.AddWithValue("@isActive", If(chkAktif.Checked, 1, 0))
            command.Parameters.AddWithValue("@id", idSupplier)

            command.ExecuteNonQuery()
            connection.Close()

            MsgBox("Supplier berhasil diperbarui", MsgBoxStyle.Information)
            Me.Close()

        Catch ex As Exception
            MsgBox("Error updating supplier: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class
