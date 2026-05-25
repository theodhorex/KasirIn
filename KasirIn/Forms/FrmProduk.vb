Imports MySql.Data.MySqlClient

Public Class FrmProduk
    Private currentSearch As String = ""
    Private currentKategoriFilter As Integer = 0

    Private Sub FrmProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKategori()
        LoadProduk()
    End Sub

    Private Sub LoadKategori()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT id_kategori, nama_kategori FROM tbl_kategori ORDER BY nama_kategori"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            cmbKategori.Items.Clear()
            cmbKategori.Items.Add(New With {.id_kategori = 0, .nama_kategori = "Semua Kategori"})

            For Each row As DataRow In table.Rows
                cmbKategori.Items.Add(New With {.id_kategori = row("id_kategori"), .nama_kategori = row("nama_kategori")})
            Next

            cmbKategori.DisplayMember = "nama_kategori"
            cmbKategori.ValueMember = "id_kategori"
            cmbKategori.SelectedIndex = 0

            connection.Close()
        Catch ex As Exception
            MsgBox("Error loading kategori: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LoadProduk()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT p.id_produk, p.barcode, p.nama_produk, k.nama_kategori, " &
                "p.harga_beli, p.harga_jual, p.stok, p.satuan, p.is_active, p.stok_minimum " &
                "FROM tbl_produk p " &
                "LEFT JOIN tbl_kategori k ON p.id_kategori = k.id_kategori " &
                "WHERE p.is_active = 1"

            If currentKategoriFilter > 0 Then
                query &= " AND p.id_kategori = @idKategori"
            End If

            If Not String.IsNullOrEmpty(currentSearch) Then
                query &= " AND (p.nama_produk LIKE @search OR p.barcode LIKE @search)"
            End If

            query &= " ORDER BY p.nama_produk"

            Dim adapter As New MySqlDataAdapter(query, connection)

            If currentKategoriFilter > 0 Then
                adapter.SelectCommand.Parameters.AddWithValue("@idKategori", currentKategoriFilter)
            End If

            If Not String.IsNullOrEmpty(currentSearch) Then
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & currentSearch & "%")
            End If

            Dim table As New DataTable()
            adapter.Fill(table)

            dgvProduk.DataSource = table

            If dgvProduk.Columns.Count > 0 Then
                dgvProduk.Columns(0).Visible = False
                dgvProduk.Columns(1).HeaderText = "Barcode"
                dgvProduk.Columns(2).HeaderText = "Nama Produk"
                dgvProduk.Columns(3).HeaderText = "Kategori"
                dgvProduk.Columns(4).HeaderText = "Harga Beli"
                dgvProduk.Columns(5).HeaderText = "Harga Jual"
                dgvProduk.Columns(6).HeaderText = "Stok"
                dgvProduk.Columns(7).HeaderText = "Satuan"
                dgvProduk.Columns(8).Visible = False
                dgvProduk.Columns(9).Visible = False

                For Each row As DataGridViewRow In dgvProduk.Rows
                    Dim stok As Integer = CInt(row.Cells(6).Value)
                    Dim stokMin As Integer = CInt(row.Cells(9).Value)
                    If stok <= stokMin Then
                        row.DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226)
                    End If
                Next
            End If

            lblTotal.Text = "Total: " & table.Rows.Count & " produk"
            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading produk: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        currentSearch = txtSearch.Text.Trim()
        LoadProduk()
    End Sub

    Private Sub cmbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKategori.SelectedIndexChanged
        If cmbKategori.SelectedItem IsNot Nothing Then
            currentKategoriFilter = CInt(CType(cmbKategori.SelectedItem, Object).GetType().GetProperty("id_kategori").GetValue(cmbKategori.SelectedItem))
            LoadProduk()
        End If
    End Sub

    Private Sub dgvProduk_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProduk.SelectionChanged
        Dim hasSelection As Boolean = dgvProduk.SelectedRows.Count > 0
        btnEdit.Enabled = hasSelection
        btnHapus.Enabled = hasSelection
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim detailForm As New FrmProdukDetail(0)
        If detailForm.ShowDialog() = DialogResult.OK Then
            LoadProduk()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvProduk.SelectedRows.Count > 0 Then
            Dim idProduk As Integer = If(dgvProduk.SelectedRows(0).Cells(0).Value Is Nothing, 0, CInt(dgvProduk.SelectedRows(0).Cells(0).Value))
            If idProduk > 0 Then
                Dim detailForm As New FrmProdukDetail(idProduk)
                If detailForm.ShowDialog() = DialogResult.OK Then
                    LoadProduk()
                End If
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvProduk.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MsgBox("Apakah Anda yakin ingin menghapus produk ini?", MsgBoxStyle.YesNo, "Konfirmasi Hapus")
            If result = DialogResult.Yes Then
                Dim idProduk As Integer = If(dgvProduk.SelectedRows(0).Cells(0).Value Is Nothing, 0, CInt(dgvProduk.SelectedRows(0).Cells(0).Value))
                If idProduk > 0 Then
                    DeleteProduk(idProduk)
                End If
            End If
        End If
    End Sub

    Private Sub DeleteProduk(idProduk As Integer)
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim getNamaQuery As String = "SELECT nama_produk FROM tbl_produk WHERE id_produk = @idProduk"
            Dim getNamaCmd As New MySqlCommand(getNamaQuery, connection)
            getNamaCmd.Parameters.AddWithValue("@idProduk", idProduk)
            Dim namaProduk As String = getNamaCmd.ExecuteScalar().ToString()

            Dim query As String = "UPDATE tbl_produk SET is_active = 0 WHERE id_produk = @idProduk"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@idProduk", idProduk)
            command.ExecuteNonQuery()

            LogHelper.CatatLog("Hapus Produk", "Produk dinonaktifkan: " & namaProduk)

            connection.Close()
            MsgBox("Produk berhasil dihapus", MsgBoxStyle.Information)
            LoadProduk()

        Catch ex As Exception
            MsgBox("Error deleting produk: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
