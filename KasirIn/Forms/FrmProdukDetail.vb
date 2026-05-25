Imports MySql.Data.MySqlClient

Public Class FrmProdukDetail
    Private idProduk As Integer = 0
    Private isEditMode As Boolean = False

    Public Sub New(id As Integer)
        InitializeComponent()
        idProduk = id
        isEditMode = (id > 0)
    End Sub

    Private Sub FrmProdukDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKategori()
        LoadSatuan()

        If isEditMode Then
            Me.Text = "Edit Produk"
            LoadProdukData()
        Else
            Me.Text = "Tambah Produk"
            cmbSatuan.SelectedIndex = 0
            cmbKategori.SelectedIndex = 0
        End If
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
            For Each row As DataRow In table.Rows
                cmbKategori.Items.Add(New With {.id_kategori = row("id_kategori"), .nama_kategori = row("nama_kategori")})
            Next

            cmbKategori.DisplayMember = "nama_kategori"
            cmbKategori.ValueMember = "id_kategori"

            connection.Close()
        Catch ex As Exception
            MsgBox("Error loading kategori: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LoadSatuan()
        cmbSatuan.Items.Clear()
        cmbSatuan.Items.AddRange(New String() {"Pcs", "Kg", "Liter", "Lusin", "Dus"})
        cmbSatuan.SelectedIndex = 0
    End Sub

    Private Sub LoadProdukData()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT * FROM tbl_produk WHERE id_produk = @idProduk"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@idProduk", idProduk)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                txtBarcode.Text = If(reader("barcode") Is Nothing, "", reader("barcode").ToString())
                txtNama.Text = If(reader("nama_produk") Is Nothing, "", reader("nama_produk").ToString())
                txtHargaBeli.Text = If(reader("harga_beli") Is Nothing, "0", reader("harga_beli").ToString())
                txtHargaJual.Text = If(reader("harga_jual") Is Nothing, "0", reader("harga_jual").ToString())
                txtStok.Text = If(reader("stok") Is Nothing, "0", reader("stok").ToString())
                txtStokMin.Text = If(reader("stok_minimum") Is Nothing, "0", reader("stok_minimum").ToString())
                txtKeterangan.Text = If(reader("keterangan") Is Nothing, "", reader("keterangan").ToString())
                chkAktif.Checked = If(reader("is_active") Is Nothing, True, CBool(reader("is_active")))

                Dim idKategori As Integer = If(reader("id_kategori") Is Nothing, 0, CInt(reader("id_kategori")))
                For i As Integer = 0 To cmbKategori.Items.Count - 1
                    If CInt(CType(cmbKategori.Items(i), Object).GetType().GetProperty("id_kategori").GetValue(cmbKategori.Items(i))) = idKategori Then
                        cmbKategori.SelectedIndex = i
                        Exit For
                    End If
                Next

                Dim satuan As String = If(reader("satuan") Is Nothing, "", reader("satuan").ToString())
                If Not String.IsNullOrEmpty(satuan) Then
                    cmbSatuan.SelectedItem = satuan
                End If
            End If

            reader.Close()
            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading produk: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ValidateInputs() Then
            If isEditMode Then
                UpdateProduk()
            Else
                AddProduk()
            End If
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MsgBox("Nama produk tidak boleh kosong", MsgBoxStyle.Exclamation)
            txtNama.Focus()
            Return False
        End If

        If cmbKategori.SelectedIndex < 0 Then
            MsgBox("Pilih kategori", MsgBoxStyle.Exclamation)
            cmbKategori.Focus()
            Return False
        End If

        If Not IsNumeric(txtHargaBeli.Text) OrElse CDec(txtHargaBeli.Text) <= 0 Then
            MsgBox("Harga beli harus angka dan lebih dari 0", MsgBoxStyle.Exclamation)
            txtHargaBeli.Focus()
            Return False
        End If

        If Not IsNumeric(txtHargaJual.Text) OrElse CDec(txtHargaJual.Text) <= 0 Then
            MsgBox("Harga jual harus angka dan lebih dari 0", MsgBoxStyle.Exclamation)
            txtHargaJual.Focus()
            Return False
        End If

        If Not IsNumeric(txtStok.Text) OrElse CInt(txtStok.Text) < 0 Then
            MsgBox("Stok harus angka dan tidak boleh negatif", MsgBoxStyle.Exclamation)
            txtStok.Focus()
            Return False
        End If

        If Not IsNumeric(txtStokMin.Text) OrElse CInt(txtStokMin.Text) < 0 Then
            MsgBox("Stok minimum harus angka dan tidak boleh negatif", MsgBoxStyle.Exclamation)
            txtStokMin.Focus()
            Return False
        End If

        If cmbSatuan.SelectedIndex < 0 Then
            MsgBox("Pilih satuan", MsgBoxStyle.Exclamation)
            cmbSatuan.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub AddProduk()
        Try
            If Not String.IsNullOrEmpty(txtBarcode.Text) AndAlso CheckBarcodeExists(txtBarcode.Text) Then
                MsgBox("Barcode sudah terdaftar", MsgBoxStyle.Exclamation)
                txtBarcode.Focus()
                Return
            End If

            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "INSERT INTO tbl_produk (barcode, nama_produk, id_kategori, harga_beli, harga_jual, " &
                "stok, stok_minimum, satuan, keterangan, is_active, created_at) " &
                "VALUES (@barcode, @nama, @idKategori, @hargaBeli, @hargaJual, @stok, @stokMin, @satuan, @keterangan, 1, NOW())"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@barcode", If(String.IsNullOrEmpty(txtBarcode.Text), "", txtBarcode.Text))
            command.Parameters.AddWithValue("@nama", txtNama.Text)
            command.Parameters.AddWithValue("@idKategori", CInt(CType(cmbKategori.SelectedItem, Object).GetType().GetProperty("id_kategori").GetValue(cmbKategori.SelectedItem)))
            command.Parameters.AddWithValue("@hargaBeli", CDec(txtHargaBeli.Text))
            command.Parameters.AddWithValue("@hargaJual", CDec(txtHargaJual.Text))
            command.Parameters.AddWithValue("@stok", CInt(txtStok.Text))
            command.Parameters.AddWithValue("@stokMin", CInt(txtStokMin.Text))
            command.Parameters.AddWithValue("@satuan", cmbSatuan.SelectedItem.ToString())
            command.Parameters.AddWithValue("@keterangan", If(String.IsNullOrEmpty(txtKeterangan.Text), "", txtKeterangan.Text))

            command.ExecuteNonQuery()
            connection.Close()

            MsgBox("Produk berhasil ditambahkan", MsgBoxStyle.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox("Error adding produk: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub UpdateProduk()
        Try
            If Not String.IsNullOrEmpty(txtBarcode.Text) AndAlso CheckBarcodeExists(txtBarcode.Text, idProduk) Then
                MsgBox("Barcode sudah terdaftar", MsgBoxStyle.Exclamation)
                txtBarcode.Focus()
                Return
            End If

            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "UPDATE tbl_produk SET barcode=@barcode, nama_produk=@nama, id_kategori=@idKategori, " &
                "harga_beli=@hargaBeli, harga_jual=@hargaJual, stok=@stok, stok_minimum=@stokMin, satuan=@satuan, " &
                "keterangan=@keterangan, is_active=@isActive, updated_at=NOW() WHERE id_produk=@idProduk"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@barcode", If(String.IsNullOrEmpty(txtBarcode.Text), "", txtBarcode.Text))
            command.Parameters.AddWithValue("@nama", txtNama.Text)
            command.Parameters.AddWithValue("@idKategori", CInt(CType(cmbKategori.SelectedItem, Object).GetType().GetProperty("id_kategori").GetValue(cmbKategori.SelectedItem)))
            command.Parameters.AddWithValue("@hargaBeli", CDec(txtHargaBeli.Text))
            command.Parameters.AddWithValue("@hargaJual", CDec(txtHargaJual.Text))
            command.Parameters.AddWithValue("@stok", CInt(txtStok.Text))
            command.Parameters.AddWithValue("@stokMin", CInt(txtStokMin.Text))
            command.Parameters.AddWithValue("@satuan", cmbSatuan.SelectedItem.ToString())
            command.Parameters.AddWithValue("@keterangan", If(String.IsNullOrEmpty(txtKeterangan.Text), "", txtKeterangan.Text))
            command.Parameters.AddWithValue("@isActive", If(chkAktif.Checked, 1, 0))
            command.Parameters.AddWithValue("@idProduk", idProduk)

            command.ExecuteNonQuery()
            connection.Close()

            MsgBox("Produk berhasil diperbarui", MsgBoxStyle.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox("Error updating produk: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function CheckBarcodeExists(barcode As String, Optional excludeId As Integer = 0) As Boolean
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return False

            Dim query As String = "SELECT COUNT(*) FROM tbl_produk WHERE barcode = @barcode"
            If excludeId > 0 Then
                query &= " AND id_produk != @idProduk"
            End If

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@barcode", barcode)
            If excludeId > 0 Then
                command.Parameters.AddWithValue("@idProduk", excludeId)
            End If

            Dim count As Integer = CInt(command.ExecuteScalar())
            connection.Close()

            Return count > 0

        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function IsNumeric(value As String) As Boolean
        Return Decimal.TryParse(value, Nothing)
    End Function
End Class
