Imports MySql.Data.MySqlClient

Public Class FrmKategori
    Private currentSearch As String = ""
    Private isEditMode As Boolean = False
    Private currentIdKategori As Integer = 0

    Private Sub FrmKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKategori()
    End Sub

    Private Sub LoadKategori()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT k.id_kategori, k.nama_kategori, k.deskripsi, k.created_at, " &
                "COUNT(p.id_produk) AS jumlah_produk " &
                "FROM tbl_kategori k " &
                "LEFT JOIN tbl_produk p ON p.id_kategori = k.id_kategori AND p.is_active = 1 "

            If Not String.IsNullOrEmpty(currentSearch) Then
                query &= "WHERE k.nama_kategori LIKE @search "
            End If

            query &= "GROUP BY k.id_kategori ORDER BY k.nama_kategori"

            Dim adapter As New MySqlDataAdapter(query, connection)

            If Not String.IsNullOrEmpty(currentSearch) Then
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & currentSearch & "%")
            End If

            Dim table As New DataTable()
            adapter.Fill(table)

            dgvKategori.DataSource = table

            If dgvKategori.Columns.Count > 0 Then
                dgvKategori.Columns(0).Visible = False
                dgvKategori.Columns(1).HeaderText = "Nama Kategori"
                dgvKategori.Columns(2).HeaderText = "Deskripsi"
                dgvKategori.Columns(3).HeaderText = "Tanggal Dibuat"
                dgvKategori.Columns(4).HeaderText = "Jumlah Produk"

                dgvKategori.AutoResizeColumns()
            End If

            lblTotal.Text = "Total: " & table.Rows.Count & " kategori"
            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading kategori: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        currentSearch = txtSearch.Text.Trim()
        LoadKategori()
    End Sub

    Private Sub dgvKategori_SelectionChanged(sender As Object, e As EventArgs) Handles dgvKategori.SelectionChanged
        Dim hasSelection As Boolean = dgvKategori.SelectedRows.Count > 0
        btnEdit.Enabled = hasSelection
        btnHapus.Enabled = hasSelection
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        isEditMode = False
        currentIdKategori = 0
        ClearForm()
        pnlForm.Visible = True
        txtNama.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvKategori.SelectedRows.Count > 0 Then
            isEditMode = True
            currentIdKategori = If(dgvKategori.SelectedRows(0).Cells(0).Value Is Nothing, 0, CInt(dgvKategori.SelectedRows(0).Cells(0).Value))
            If currentIdKategori > 0 Then
                LoadFormData()
                pnlForm.Visible = True
                txtNama.Focus()
            End If
        End If
    End Sub

    Private Sub LoadFormData()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT nama_kategori, deskripsi FROM tbl_kategori WHERE id_kategori = @id"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", currentIdKategori)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                txtNama.Text = If(reader("nama_kategori") Is Nothing, "", reader("nama_kategori").ToString())
                txtDeskripsi.Text = If(reader("deskripsi") Is Nothing, "", reader("deskripsi").ToString())
            End If

            reader.Close()
            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading kategori: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ValidateInputs() Then
            If isEditMode Then
                UpdateKategori()
            Else
                AddKategori()
            End If
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MsgBox("Nama kategori tidak boleh kosong", MsgBoxStyle.Exclamation)
            txtNama.Focus()
            Return False
        End If

        If CheckNamaExists(txtNama.Text, currentIdKategori) Then
            MsgBox("Nama kategori sudah ada", MsgBoxStyle.Exclamation)
            txtNama.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function CheckNamaExists(nama As String, Optional excludeId As Integer = 0) As Boolean
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return False

            Dim query As String = "SELECT COUNT(*) FROM tbl_kategori WHERE nama_kategori = @nama"
            If excludeId > 0 Then
                query &= " AND id_kategori != @id"
            End If

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@nama", nama)
            If excludeId > 0 Then
                command.Parameters.AddWithValue("@id", excludeId)
            End If

            Dim count As Integer = CInt(command.ExecuteScalar())
            connection.Close()

            Return count > 0

        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub AddKategori()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "INSERT INTO tbl_kategori (nama_kategori, deskripsi, created_at) " &
                "VALUES (@nama, @deskripsi, NOW())"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@nama", txtNama.Text)
            command.Parameters.AddWithValue("@deskripsi", If(String.IsNullOrEmpty(txtDeskripsi.Text), "", txtDeskripsi.Text))

            command.ExecuteNonQuery()
            connection.Close()

            LogHelper.CatatLog("Kelola Kategori", "Aksi: Tambah - " & txtNama.Text)

            MsgBox("Kategori berhasil ditambahkan", MsgBoxStyle.Information)
            ClearForm()
            pnlForm.Visible = False
            LoadKategori()

        Catch ex As Exception
            MsgBox("Error adding kategori: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub UpdateKategori()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "UPDATE tbl_kategori SET nama_kategori=@nama, deskripsi=@deskripsi " &
                "WHERE id_kategori=@id"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@nama", txtNama.Text)
            command.Parameters.AddWithValue("@deskripsi", If(String.IsNullOrEmpty(txtDeskripsi.Text), "", txtDeskripsi.Text))
            command.Parameters.AddWithValue("@id", currentIdKategori)

            command.ExecuteNonQuery()
            connection.Close()

            LogHelper.CatatLog("Kelola Kategori", "Aksi: Edit - " & txtNama.Text)

            MsgBox("Kategori berhasil diperbarui", MsgBoxStyle.Information)
            ClearForm()
            pnlForm.Visible = False
            LoadKategori()

        Catch ex As Exception
            MsgBox("Error updating kategori: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvKategori.SelectedRows.Count > 0 Then
            Dim idKategori As Integer = If(dgvKategori.SelectedRows(0).Cells(0).Value Is Nothing, 0, CInt(dgvKategori.SelectedRows(0).Cells(0).Value))

            If idKategori <= 0 Then Return

            If CheckKategoriHasProducts(idKategori) Then
                MsgBox("Kategori masih memiliki produk aktif, tidak bisa dihapus", MsgBoxStyle.Exclamation)
                Return
            End If

            Dim result As DialogResult = MsgBox("Apakah Anda yakin ingin menghapus kategori ini?", MsgBoxStyle.YesNo, "Konfirmasi Hapus")
            If result = DialogResult.Yes Then
                DeleteKategori(idKategori)
            End If
        End If
    End Sub

    Private Function CheckKategoriHasProducts(idKategori As Integer) As Boolean
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return False

            Dim query As String = "SELECT COUNT(*) FROM tbl_produk WHERE id_kategori = @id AND is_active = 1"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", idKategori)

            Dim count As Integer = CInt(command.ExecuteScalar())
            connection.Close()

            Return count > 0

        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub DeleteKategori(idKategori As Integer)
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim getNamaQuery As String = "SELECT nama_kategori FROM tbl_kategori WHERE id_kategori = @id"
            Dim getNamaCmd As New MySqlCommand(getNamaQuery, connection)
            getNamaCmd.Parameters.AddWithValue("@id", idKategori)
            Dim namaKategori As String = getNamaCmd.ExecuteScalar().ToString()

            Dim query As String = "DELETE FROM tbl_kategori WHERE id_kategori = @id"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", idKategori)

            command.ExecuteNonQuery()

            LogHelper.CatatLog("Kelola Kategori", "Aksi: Hapus - " & namaKategori)

            connection.Close()

            MsgBox("Kategori berhasil dihapus", MsgBoxStyle.Information)
            LoadKategori()

        Catch ex As Exception
            MsgBox("Error deleting kategori: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
        pnlForm.Visible = False
    End Sub

    Private Sub ClearForm()
        txtNama.Clear()
        txtDeskripsi.Clear()
        isEditMode = False
        currentIdKategori = 0
    End Sub
End Class
