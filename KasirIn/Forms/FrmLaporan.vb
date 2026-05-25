Imports MySql.Data.MySqlClient

Public Class FrmLaporan
    Private Sub FrmLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDari.Value = DateTime.Today
        dtpSampai.Value = DateTime.Today
        dtpVoidDari.Value = DateTime.Today
        dtpVoidSampai.Value = DateTime.Today

        LoadKategori()
        LoadLaporanPenjualan()
        LoadLaporanStok()
        LoadLaporanVoid()

        btnVoid.Visible = (SessionHelper.Role = "Admin")
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
            For Each row In table.Rows
                cmbKategori.Items.Add(row)
            Next

            cmbKategori.DisplayMember = "nama_kategori"
            cmbKategori.ValueMember = "id_kategori"
            cmbKategori.SelectedIndex = 0

            connection.Close()
        Catch ex As Exception
            MsgBox("Error loading kategori: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LoadLaporanPenjualan()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim dari As String = dtpDari.Value.ToString("yyyy-MM-dd")
            Dim sampai As String = dtpSampai.Value.ToString("yyyy-MM-dd")

            Dim query As String = "SELECT t.id_transaksi, t.no_transaksi, t.tanggal, u.nama_lengkap AS kasir, " &
                "t.total_harga, t.diskon_total, t.total_bayar, t.status " &
                "FROM tbl_transaksi t " &
                "JOIN tbl_user u ON t.id_user = u.id_user " &
                "WHERE DATE(t.tanggal) BETWEEN @dari AND @sampai " &
                "ORDER BY t.tanggal DESC"

            Dim adapter As New MySqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@dari", dari)
            adapter.SelectCommand.Parameters.AddWithValue("@sampai", sampai)

            Dim table As New DataTable()
            adapter.Fill(table)

            dgvLaporan.DataSource = table

            If dgvLaporan.Columns.Count > 0 Then
                dgvLaporan.Columns(0).Visible = False
                dgvLaporan.Columns(1).HeaderText = "No. Transaksi"
                dgvLaporan.Columns(2).HeaderText = "Tanggal"
                dgvLaporan.Columns(3).HeaderText = "Kasir"
                dgvLaporan.Columns(4).HeaderText = "Total Harga"
                dgvLaporan.Columns(5).HeaderText = "Diskon"
                dgvLaporan.Columns(6).HeaderText = "Total Bayar"
                dgvLaporan.Columns(7).HeaderText = "Status"

                dgvLaporan.AutoResizeColumns()
            End If

            LoadSummaryPenjualan(dari, sampai)
            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading laporan penjualan: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LoadSummaryPenjualan(dari As String, sampai As String)
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT " &
                "COUNT(*) AS total_transaksi, " &
                "COALESCE(SUM(total_bayar), 0) AS total_pendapatan, " &
                "COALESCE(SUM(diskon_total), 0) AS total_diskon, " &
                "COALESCE(AVG(total_bayar), 0) AS rata_rata " &
                "FROM tbl_transaksi " &
                "WHERE DATE(tanggal) BETWEEN @dari AND @sampai AND status = 'aktif'"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@dari", dari)
            command.Parameters.AddWithValue("@sampai", sampai)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                Dim totalTransaksi As Integer = CInt(reader("total_transaksi"))
                Dim totalPendapatan As Decimal = CDec(reader("total_pendapatan"))
                Dim totalDiskon As Decimal = CDec(reader("total_diskon"))
                Dim rataRata As Decimal = CDec(reader("rata_rata"))

                lblTotalTransaksi.Text = "Total Transaksi: " & totalTransaksi
                lblTotalPendapatan.Text = "Total Pendapatan: Rp " & totalPendapatan.ToString("N0")
                lblTotalDiskon.Text = "Total Diskon: Rp " & totalDiskon.ToString("N0")
                lblRataRata.Text = "Rata-rata Transaksi: Rp " & rataRata.ToString("N0")
            End If

            reader.Close()
            connection.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadLaporanStok()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT p.id_produk, p.barcode, p.nama_produk, k.nama_kategori, " &
                "p.stok, p.stok_minimum, p.harga_beli, p.harga_jual, " &
                "(p.stok * p.harga_beli) AS nilai_stok, " &
                "CASE " &
                "  WHEN p.stok = 0 THEN 'Habis' " &
                "  WHEN p.stok <= p.stok_minimum THEN 'Menipis' " &
                "  ELSE 'Normal' " &
                "END AS status_stok " &
                "FROM tbl_produk p " &
                "LEFT JOIN tbl_kategori k ON p.id_kategori = k.id_kategori " &
                "WHERE p.is_active = 1 " &
                "ORDER BY p.stok ASC"

            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvStok.DataSource = table

            If dgvStok.Columns.Count > 0 Then
                dgvStok.Columns(0).Visible = False
                dgvStok.Columns(1).HeaderText = "Barcode"
                dgvStok.Columns(2).HeaderText = "Nama Produk"
                dgvStok.Columns(3).HeaderText = "Kategori"
                dgvStok.Columns(4).HeaderText = "Stok"
                dgvStok.Columns(5).HeaderText = "Stok Min"
                dgvStok.Columns(6).HeaderText = "Harga Beli"
                dgvStok.Columns(7).HeaderText = "Harga Jual"
                dgvStok.Columns(8).HeaderText = "Nilai Stok"
                dgvStok.Columns(9).HeaderText = "Status"

                dgvStok.AutoResizeColumns()

                For i = 0 To dgvStok.Rows.Count - 1
                    Dim statusStok As String = dgvStok.Rows(i).Cells(9).Value.ToString()
                    If statusStok = "Habis" Then
                        dgvStok.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226)
                    ElseIf statusStok = "Menipis" Then
                        dgvStok.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 243, 224)
                    End If
                Next
            End If

            LoadSummaryStok()
            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading laporan stok: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LoadSummaryStok()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query1 As String = "SELECT COUNT(*) FROM tbl_produk WHERE is_active = 1"
            Dim command1 As New MySqlCommand(query1, connection)
            Dim totalProduk As Integer = CInt(command1.ExecuteScalar())

            Dim query2 As String = "SELECT COALESCE(SUM(stok * harga_beli), 0) FROM tbl_produk WHERE is_active = 1"
            Dim command2 As New MySqlCommand(query2, connection)
            Dim totalNilai As Decimal = CDec(command2.ExecuteScalar())

            Dim query3 As String = "SELECT COUNT(*) FROM tbl_produk WHERE stok <= stok_minimum AND is_active = 1"
            Dim command3 As New MySqlCommand(query3, connection)
            Dim stokMenipis As Integer = CInt(command3.ExecuteScalar())

            lblSummaryStok.Text = "Total Produk: " & totalProduk & " | Total Nilai Inventori: Rp " & totalNilai.ToString("N0") & " | Stok Menipis: " & stokMenipis

            connection.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadLaporanVoid()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim dari As String = dtpVoidDari.Value.ToString("yyyy-MM-dd")
            Dim sampai As String = dtpVoidSampai.Value.ToString("yyyy-MM-dd")

            Dim query As String = "SELECT t.id_transaksi, t.no_transaksi, t.tanggal, t.total_bayar, " &
                "u.nama_lengkap AS kasir, t.status " &
                "FROM tbl_transaksi t " &
                "JOIN tbl_user u ON t.id_user = u.id_user " &
                "WHERE DATE(t.tanggal) BETWEEN @dari AND @sampai " &
                "ORDER BY t.tanggal DESC"

            Dim adapter As New MySqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@dari", dari)
            adapter.SelectCommand.Parameters.AddWithValue("@sampai", sampai)

            Dim table As New DataTable()
            adapter.Fill(table)

            dgvVoid.DataSource = table

            If dgvVoid.Columns.Count > 0 Then
                dgvVoid.Columns(0).Visible = False
                dgvVoid.Columns(1).HeaderText = "No. Transaksi"
                dgvVoid.Columns(2).HeaderText = "Tanggal"
                dgvVoid.Columns(3).HeaderText = "Total Bayar"
                dgvVoid.Columns(4).HeaderText = "Kasir"
                dgvVoid.Columns(5).HeaderText = "Status"

                dgvVoid.AutoResizeColumns()
            End If

            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading laporan void: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        LoadLaporanPenjualan()
    End Sub

    Private Sub dgvLaporan_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLaporan.SelectionChanged
        If dgvLaporan.SelectedRows.Count > 0 Then
            Dim idTransaksi As Integer = If(dgvLaporan.SelectedRows(0).Cells(0).Value Is Nothing, 0, CInt(dgvLaporan.SelectedRows(0).Cells(0).Value))
            Dim noTransaksi As String = If(dgvLaporan.SelectedRows(0).Cells(1).Value Is Nothing, "", dgvLaporan.SelectedRows(0).Cells(1).Value.ToString())
            If idTransaksi > 0 Then
                LoadDetailTransaksi(idTransaksi, noTransaksi)
            End If
        End If
    End Sub

    Private Sub LoadDetailTransaksi(idTransaksi As Integer, noTransaksi As String)
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT nama_produk, harga_satuan, jumlah, diskon_item, subtotal " &
                "FROM tbl_detail_transaksi " &
                "WHERE id_transaksi = @idTransaksi"

            Dim adapter As New MySqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@idTransaksi", idTransaksi)

            Dim table As New DataTable()
            adapter.Fill(table)

            dgvDetail.DataSource = table

            If dgvDetail.Columns.Count > 0 Then
                dgvDetail.Columns(0).HeaderText = "Nama Produk"
                dgvDetail.Columns(1).HeaderText = "Harga Satuan"
                dgvDetail.Columns(2).HeaderText = "Qty"
                dgvDetail.Columns(3).HeaderText = "Diskon Item"
                dgvDetail.Columns(4).HeaderText = "Subtotal"

                dgvDetail.AutoResizeColumns()
            End If

            lblDetail.Text = "Detail Transaksi: " & noTransaksi
            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading detail: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnTampilkanStok_Click(sender As Object, e As EventArgs) Handles btnTampilkanStok.Click
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim idKategori As Integer = 0
            If cmbKategori.SelectedValue IsNot Nothing Then
                idKategori = CInt(cmbKategori.SelectedValue)
            End If
            Dim showMenipis As Boolean = chkStokMenipis.Checked

            Dim query As String = "SELECT p.id_produk, p.barcode, p.nama_produk, k.nama_kategori, " &
                "p.stok, p.stok_minimum, p.harga_beli, p.harga_jual, " &
                "(p.stok * p.harga_beli) AS nilai_stok, " &
                "CASE " &
                "  WHEN p.stok = 0 THEN 'Habis' " &
                "  WHEN p.stok <= p.stok_minimum THEN 'Menipis' " &
                "  ELSE 'Normal' " &
                "END AS status_stok " &
                "FROM tbl_produk p " &
                "LEFT JOIN tbl_kategori k ON p.id_kategori = k.id_kategori " &
                "WHERE p.is_active = 1 "

            If idKategori > 0 Then
                query &= "AND p.id_kategori = @idKategori "
            End If

            If showMenipis Then
                query &= "AND (p.stok = 0 OR p.stok <= p.stok_minimum) "
            End If

            query &= "ORDER BY p.stok ASC"

            Dim adapter As New MySqlDataAdapter(query, connection)
            If idKategori > 0 Then
                adapter.SelectCommand.Parameters.AddWithValue("@idKategori", idKategori)
            End If

            Dim table As New DataTable()
            adapter.Fill(table)

            dgvStok.DataSource = table

            If dgvStok.Columns.Count > 0 Then
                dgvStok.Columns(0).Visible = False
                dgvStok.Columns(1).HeaderText = "Barcode"
                dgvStok.Columns(2).HeaderText = "Nama Produk"
                dgvStok.Columns(3).HeaderText = "Kategori"
                dgvStok.Columns(4).HeaderText = "Stok"
                dgvStok.Columns(5).HeaderText = "Stok Min"
                dgvStok.Columns(6).HeaderText = "Harga Beli"
                dgvStok.Columns(7).HeaderText = "Harga Jual"
                dgvStok.Columns(8).HeaderText = "Nilai Stok"
                dgvStok.Columns(9).HeaderText = "Status"

                dgvStok.AutoResizeColumns()

                For i = 0 To dgvStok.Rows.Count - 1
                    Dim statusStok As String = dgvStok.Rows(i).Cells(9).Value.ToString()
                    If statusStok = "Habis" Then
                        dgvStok.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226)
                    ElseIf statusStok = "Menipis" Then
                        dgvStok.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 243, 224)
                    End If
                Next
            End If

            LoadSummaryStok()
            connection.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnTampilkanVoid_Click(sender As Object, e As EventArgs) Handles btnTampilkanVoid.Click
        LoadLaporanVoid()
    End Sub

    Private Sub dgvVoid_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVoid.SelectionChanged
        If dgvVoid.SelectedRows.Count > 0 Then
            Dim status As String = dgvVoid.SelectedRows(0).Cells(5).Value.ToString()
            btnVoid.Enabled = (status = "aktif")
        Else
            btnVoid.Enabled = False
        End If
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        If dgvVoid.SelectedRows.Count = 0 Then Return

        Dim idTransaksi As Integer = If(dgvVoid.SelectedRows(0).Cells(0).Value Is Nothing, 0, CInt(dgvVoid.SelectedRows(0).Cells(0).Value))
        Dim noTransaksi As String = If(dgvVoid.SelectedRows(0).Cells(1).Value Is Nothing, "", dgvVoid.SelectedRows(0).Cells(1).Value.ToString())

        If idTransaksi <= 0 Then Return

        Dim result As DialogResult = MsgBox("Yakin ingin membatalkan transaksi " & noTransaksi & "?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then Return

        Dim alasan As String = InputBox("Masukkan alasan void transaksi:", "Void Transaksi")
        If String.IsNullOrEmpty(alasan) Then Return

        VoidTransaksi(idTransaksi, alasan)
    End Sub

    Private Sub VoidTransaksi(idTransaksi As Integer, alasan As String)
        Dim connection As MySqlConnection = DBConnection.GetConnection()
        If connection Is Nothing Then Return

        Try
            Dim transaction As MySqlTransaction = connection.BeginTransaction()

            Try
                Dim updateQuery As String = "UPDATE tbl_transaksi SET status = 'void' WHERE id_transaksi = @id"
                Dim updateCommand As New MySqlCommand(updateQuery, connection, transaction)
                updateCommand.Parameters.AddWithValue("@id", idTransaksi)
                updateCommand.ExecuteNonQuery()

                Dim voidQuery As String = "INSERT INTO tbl_void_transaksi (id_transaksi, alasan, waktu_void, id_user) " &
                    "VALUES (@idTransaksi, @alasan, NOW(), @idUser)"
                Dim voidCommand As New MySqlCommand(voidQuery, connection, transaction)
                voidCommand.Parameters.AddWithValue("@idTransaksi", idTransaksi)
                voidCommand.Parameters.AddWithValue("@alasan", alasan)
                voidCommand.Parameters.AddWithValue("@idUser", SessionHelper.UserId)
                voidCommand.ExecuteNonQuery()

                Dim detailQuery As String = "SELECT id_produk, jumlah FROM tbl_detail_transaksi WHERE id_transaksi = @id"
                Dim detailCommand As New MySqlCommand(detailQuery, connection, transaction)
                detailCommand.Parameters.AddWithValue("@id", idTransaksi)
                Dim reader As MySqlDataReader = detailCommand.ExecuteReader()

                While reader.Read()
                    Dim idProduk As Integer = CInt(reader("id_produk"))
                    Dim jumlah As Integer = CInt(reader("jumlah"))

                    Dim restoreQuery As String = "UPDATE tbl_produk SET stok = stok + @jumlah WHERE id_produk = @idProduk"
                    Dim restoreCommand As New MySqlCommand(restoreQuery, connection, transaction)
                    restoreCommand.Parameters.AddWithValue("@jumlah", jumlah)
                    restoreCommand.Parameters.AddWithValue("@idProduk", idProduk)
                    restoreCommand.ExecuteNonQuery()
                End While

                reader.Close()
                transaction.Commit()

                MsgBox("Transaksi berhasil dibatalkan", MsgBoxStyle.Information)
                LoadLaporanVoid()

            Catch ex As Exception
                transaction.Rollback()
                MsgBox("Error void transaksi: " & ex.Message, MsgBoxStyle.Critical)
            End Try

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportToCSV(dgvLaporan, "Laporan_Penjualan")
    End Sub

    Private Sub btnExportStok_Click(sender As Object, e As EventArgs) Handles btnExportStok.Click
        ExportToCSV(dgvStok, "Laporan_Stok")
    End Sub

    Private Sub ExportToCSV(dgv As DataGridView, fileName As String)
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV Files (*.csv)|*.csv"
            saveDialog.FileName = fileName & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using writer As New System.IO.StreamWriter(saveDialog.FileName)
                    Dim headers As New List(Of String)
                    For Each column In dgv.Columns
                        If Not column.Visible Then Continue For
                        headers.Add(column.HeaderText)
                    Next
                    writer.WriteLine(String.Join(",", headers))

                    For Each row In dgv.Rows
                        Dim values As New List(Of String)
                        For Each cell In row.Cells
                            If Not dgv.Columns(cell.ColumnIndex).Visible Then Continue For
                            values.Add(If(cell.Value Is Nothing, "", cell.Value.ToString()))
                        Next
                        writer.WriteLine(String.Join(",", values))
                    Next
                End Using

                MsgBox("Data berhasil diekspor ke: " & saveDialog.FileName, MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Error export: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintLaporan()
    End Sub

    Private Sub PrintLaporan()
        Try
            Dim printDoc As New Printing.PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage
            printDoc.Print()
        Catch ex As Exception
            MsgBox("Error printing: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim font As New System.Drawing.Font("Courier New", 10)
        Dim boldFont As New System.Drawing.Font("Courier New", 10, System.Drawing.FontStyle.Bold)
        Dim y As Single = 50
        Dim x As Single = 50

        e.Graphics.DrawString("KasirIn - Laporan Penjualan", boldFont, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("Periode: " & dtpDari.Value.ToString("dd/MM/yyyy") & " - " & dtpSampai.Value.ToString("dd/MM/yyyy"), font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("================================", font, Brushes.Black, x, y)
        y += 20

        e.Graphics.DrawString(lblTotalTransaksi.Text, font, Brushes.Black, x, y)
        y += 15
        e.Graphics.DrawString(lblTotalPendapatan.Text, font, Brushes.Black, x, y)
        y += 15
        e.Graphics.DrawString(lblTotalDiskon.Text, font, Brushes.Black, x, y)
        y += 15
        e.Graphics.DrawString(lblRataRata.Text, font, Brushes.Black, x, y)
        y += 20

        e.Graphics.DrawString("================================", font, Brushes.Black, x, y)
        y += 20

        For Each row In dgvLaporan.Rows
            If y > 700 Then
                e.HasMorePages = True
                Exit Sub
            End If

            Dim noTransaksi As String = row.Cells(1).Value.ToString()
            Dim tanggal As String = row.Cells(2).Value.ToString()
            Dim totalBayar As String = "Rp " & CDec(row.Cells(6).Value).ToString("N0")

            e.Graphics.DrawString(noTransaksi & " | " & tanggal & " | " & totalBayar, font, Brushes.Black, x, y)
            y += 15
        Next

        e.HasMorePages = False
    End Sub
End Class
