Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FrmKasir
    Private cartItems As New List(Of CartItem)
    Private noTransaksiCounter As Integer = 0

    Private Class CartItem
        Public idProduk As Integer
        Public namaProduk As String
        Public hargaSatuan As Decimal
        Public qty As Integer
        Public diskonItem As Decimal
        Public stokTersedia As Integer
    End Class

    Private Class SearchResult
        Public id As Integer
        Public nama As String
        Public harga As Decimal
        Public stok As Integer
        Public satuan As String
    End Class

    Private Sub FrmKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeGrid()
        LoadProduk()
        GenerateNoTransaksi()
        UpdateTransactionInfo()
        txtBarcode.Focus()
    End Sub

    Private Sub InitializeGrid()
        dgvKeranjang.Columns.Clear()
        dgvKeranjang.Columns.Add("No", "No")
        dgvKeranjang.Columns.Add("NamaProduk", "Nama Produk")
        dgvKeranjang.Columns.Add("HargaSatuan", "Harga Satuan")
        dgvKeranjang.Columns.Add("Qty", "Qty")
        dgvKeranjang.Columns.Add("DiskonItem", "Diskon Item")
        dgvKeranjang.Columns.Add("Subtotal", "Subtotal")
        dgvKeranjang.Columns.Add("Hapus", "Hapus")

        dgvKeranjang.Columns(0).Width = 40
        dgvKeranjang.Columns(1).Width = 180
        dgvKeranjang.Columns(2).Width = 100
        dgvKeranjang.Columns(3).Width = 60
        dgvKeranjang.Columns(4).Width = 100
        dgvKeranjang.Columns(5).Width = 100
        dgvKeranjang.Columns(6).Width = 60

        dgvKeranjang.Columns(3).ReadOnly = False
        dgvKeranjang.Columns(4).ReadOnly = False
    End Sub

    Private Sub LoadProduk()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT id_produk, nama_produk, harga_jual, stok, satuan FROM tbl_produk WHERE is_active = 1 ORDER BY nama_produk"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvProduk.DataSource = table

            If dgvProduk.Columns.Count > 0 Then
                dgvProduk.Columns(0).HeaderText = "ID"
                dgvProduk.Columns(1).HeaderText = "Nama Produk"
                dgvProduk.Columns(2).HeaderText = "Harga"
                dgvProduk.Columns(3).HeaderText = "Stok"
                dgvProduk.Columns(4).HeaderText = "Satuan"

                dgvProduk.Columns(0).Width = 50
                dgvProduk.Columns(1).Width = 250
                dgvProduk.Columns(2).Width = 100
                dgvProduk.Columns(3).Width = 60
                dgvProduk.Columns(4).Width = 80
            End If

            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading produk: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub GenerateNoTransaksi()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim today As String = DateTime.Now.ToString("yyyyMMdd")
            Dim query As String = "SELECT COUNT(*) FROM tbl_transaksi WHERE DATE(tanggal) = CURDATE()"
            Dim command As New MySqlCommand(query, connection)
            noTransaksiCounter = CInt(command.ExecuteScalar()) + 1

            lblNoTransaksi.Text = "No. Transaksi: TRX-" & today & "-" & noTransaksiCounter.ToString("0000")
            connection.Close()

        Catch ex As Exception
            lblNoTransaksi.Text = "No. Transaksi: TRX-ERROR"
        End Try
    End Sub

    Private Sub UpdateTransactionInfo()
        lblTanggal.Text = "Tanggal: " & DateTime.Now.ToString("dd/MM/yyyy")
        lblWaktu.Text = "Waktu: " & DateTime.Now.ToString("HH:mm:ss")
        lblKasir.Text = "Kasir: " & SessionHelper.NamaLengkap
    End Sub

    Private Sub tmrWaktu_Tick(sender As Object, e As EventArgs) Handles tmrWaktu.Tick
        lblWaktu.Text = "Waktu: " & DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            SearchProduct()
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        SearchProduct()
    End Sub

    Private Sub SearchProduct()
        Dim input As String = txtBarcode.Text.Trim()

        If String.IsNullOrEmpty(input) Then
            MsgBox("Masukkan barcode atau nama produk", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim results As New List(Of SearchResult)

            Dim query As String = "SELECT id_produk, nama_produk, harga_jual, stok, satuan FROM tbl_produk " &
                "WHERE barcode = @input AND is_active = 1"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@input", input)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim result As New SearchResult With {
                        .id = CInt(reader("id_produk")),
                        .nama = reader("nama_produk").ToString(),
                        .harga = CDec(reader("harga_jual")),
                        .stok = CInt(reader("stok")),
                        .satuan = reader("satuan").ToString()
                    }
                    results.Add(result)
                End While
            End If

            reader.Close()

            If results.Count = 0 Then
                query = "SELECT id_produk, nama_produk, harga_jual, stok, satuan FROM tbl_produk " &
                    "WHERE nama_produk LIKE @input AND is_active = 1"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@input", "%" & input & "%")
                reader = command.ExecuteReader()

                While reader.Read()
                    Dim result As New SearchResult With {
                        .id = CInt(reader("id_produk")),
                        .nama = reader("nama_produk").ToString(),
                        .harga = CDec(reader("harga_jual")),
                        .stok = CInt(reader("stok")),
                        .satuan = reader("satuan").ToString()
                    }
                    results.Add(result)
                End While

                reader.Close()
            End If

            connection.Close()

            If results.Count = 0 Then
                MsgBox("Produk tidak ditemukan", MsgBoxStyle.Exclamation)
            ElseIf results.Count = 1 Then
                Dim result = results(0)
                If result.stok = 0 Then
                    MsgBox("Stok produk habis", MsgBoxStyle.Exclamation)
                Else
                    AddToCart(result.id, result.nama, result.harga, result.stok)
                    txtBarcode.Clear()
                    txtBarcode.Focus()
                End If
            Else
                cmbHasilCari.Items.Clear()
                For Each result In results
                    cmbHasilCari.Items.Add(result)
                Next
                cmbHasilCari.DisplayMember = "nama"
                cmbHasilCari.ValueMember = "id"
                cmbHasilCari.Visible = True
                cmbHasilCari.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error searching product: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmbHasilCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHasilCari.SelectedIndexChanged
        If cmbHasilCari.SelectedIndex >= 0 Then
            Dim selectedItem As SearchResult = CType(cmbHasilCari.SelectedItem, SearchResult)
            If selectedItem.stok = 0 Then
                MsgBox("Stok produk habis", MsgBoxStyle.Exclamation)
            Else
                AddToCart(selectedItem.id, selectedItem.nama, selectedItem.harga, selectedItem.stok)
                cmbHasilCari.Visible = False
                cmbHasilCari.Items.Clear()
                txtBarcode.Clear()
                txtBarcode.Focus()
            End If
        End If
    End Sub

    Private Sub AddToCart(idProduk As Integer, namaProduk As String, hargaSatuan As Decimal, stokTersedia As Integer)
        Dim existingItem = cartItems.FirstOrDefault(Function(x) x.idProduk = idProduk)

        If existingItem IsNot Nothing Then
            If existingItem.qty + 1 > stokTersedia Then
                MsgBox("Stok tidak cukup", MsgBoxStyle.Exclamation)
                Return
            End If
            existingItem.qty += 1
        Else
            cartItems.Add(New CartItem With {
                .idProduk = idProduk,
                .namaProduk = namaProduk,
                .hargaSatuan = hargaSatuan,
                .qty = 1,
                .diskonItem = 0,
                .stokTersedia = stokTersedia
            })
        End If

        RefreshCart()
    End Sub

    Private Sub RefreshCart()
        dgvKeranjang.Rows.Clear()

        Dim no As Integer = 1
        For Each item In cartItems
            Dim subtotal As Decimal = (item.hargaSatuan * item.qty) - item.diskonItem
            dgvKeranjang.Rows.Add(no, item.namaProduk, "Rp " & item.hargaSatuan.ToString("N0"), item.qty, "Rp " & item.diskonItem.ToString("N0"), "Rp " & subtotal.ToString("N0"), "Hapus")
            no += 1
        Next

        lblItemCount.Text = "Total Item: " & cartItems.Count & " produk"
        UpdatePaymentSummary()
        btnProses.Enabled = (cartItems.Count > 0)
    End Sub

    Private Sub UpdatePaymentSummary()
        Dim totalHarga As Decimal = 0
        For Each item In cartItems
            totalHarga += (item.hargaSatuan * item.qty) - item.diskonItem
        Next

        Dim diskonTotal As Decimal = If(IsNumeric(txtDiskonTotal.Text), CDec(txtDiskonTotal.Text), 0)
        Dim totalBayar As Decimal = totalHarga - diskonTotal
        Dim bayar As Decimal = If(IsNumeric(txtBayar.Text), CDec(txtBayar.Text), 0)
        Dim kembalian As Decimal = bayar - totalBayar

        lblTotalHarga.Text = "Total Harga: Rp " & totalHarga.ToString("N0")
        lblTotalBayar.Text = "Total Bayar: Rp " & totalBayar.ToString("N0")

        If kembalian < 0 Then
            lblKembalian.ForeColor = Color.FromArgb(220, 38, 38)
            lblKembalian.Text = "Kembalian: Rp " & Math.Abs(kembalian).ToString("N0") & " (Kurang)"
        Else
            lblKembalian.ForeColor = Color.FromArgb(34, 197, 94)
            lblKembalian.Text = "Kembalian: Rp " & kembalian.ToString("N0")
        End If
    End Sub

    Private Sub txtDiskonTotal_TextChanged(sender As Object, e As EventArgs) Handles txtDiskonTotal.TextChanged
        UpdatePaymentSummary()
    End Sub

    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.TextChanged
        UpdatePaymentSummary()
    End Sub

    Private Sub dgvKeranjang_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKeranjang.CellEndEdit
        If e.ColumnIndex = 3 Then
            If IsNumeric(dgvKeranjang.Rows(e.RowIndex).Cells(3).Value) Then
                Dim newQty As Integer = CInt(dgvKeranjang.Rows(e.RowIndex).Cells(3).Value)
                If newQty > 0 AndAlso newQty <= cartItems(e.RowIndex).stokTersedia Then
                    cartItems(e.RowIndex).qty = newQty
                    RefreshCart()
                Else
                    MsgBox("Qty tidak valid atau melebihi stok", MsgBoxStyle.Exclamation)
                    RefreshCart()
                End If
            End If
        ElseIf e.ColumnIndex = 4 Then
            If IsNumeric(dgvKeranjang.Rows(e.RowIndex).Cells(4).Value) Then
                Dim newDiskon As Decimal = CDec(dgvKeranjang.Rows(e.RowIndex).Cells(4).Value)
                cartItems(e.RowIndex).diskonItem = newDiskon
                RefreshCart()
            End If
        End If
    End Sub

    Private Sub dgvKeranjang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKeranjang.CellClick
        If e.ColumnIndex = 6 AndAlso e.RowIndex >= 0 Then
            cartItems.RemoveAt(e.RowIndex)
            RefreshCart()
        End If
    End Sub

    Private Sub dgvProduk_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim idProduk As Integer = CInt(dgvProduk.Rows(e.RowIndex).Cells(0).Value)
            Dim namaProduk As String = dgvProduk.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim hargaSatuan As Decimal = CDec(dgvProduk.Rows(e.RowIndex).Cells(2).Value)
            Dim stokTersedia As Integer = CInt(dgvProduk.Rows(e.RowIndex).Cells(3).Value)

            If stokTersedia = 0 Then
                MsgBox("Stok produk habis", MsgBoxStyle.Exclamation)
                Return
            End If

            AddToCart(idProduk, namaProduk, hargaSatuan, stokTersedia)
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If cartItems.Count > 0 Then
            Dim result As DialogResult = MsgBox("Batalkan transaksi ini?", MsgBoxStyle.YesNo)
            If result = DialogResult.Yes Then
                cartItems.Clear()
                RefreshCart()
                txtBarcode.Clear()
                txtBarcode.Focus()
            End If
        End If
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        cartItems.Clear()
        RefreshCart()
        GenerateNoTransaksi()
        txtDiskonTotal.Text = "0"
        txtBayar.Text = "0"
        txtBarcode.Clear()
        txtBarcode.Focus()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If Not ValidateTransaction() Then Return

        If SaveTransaction() Then
            ShowLowStockNotification()

            Dim noTransaksi As String = lblNoTransaksi.Text.Replace("No. Transaksi: ", "")

            Dim result As DialogResult = MsgBox("Transaksi " & noTransaksi & " berhasil! Cetak struk?", MsgBoxStyle.YesNo)
            If result = DialogResult.Yes Then
                ShowPrintOptions(noTransaksi)
            End If
            btnBaru_Click(Nothing, Nothing)
        End If
    End Sub

    Private Function ValidateTransaction() As Boolean
        If cartItems.Count = 0 Then
            MsgBox("Keranjang kosong", MsgBoxStyle.Exclamation)
            Return False
        End If

        If String.IsNullOrEmpty(txtBayar.Text) OrElse Not IsNumeric(txtBayar.Text) Then
            MsgBox("Uang bayar harus diisi", MsgBoxStyle.Exclamation)
            txtBayar.Focus()
            Return False
        End If

        Dim totalHarga As Decimal = 0
        For Each item In cartItems
            totalHarga += (item.hargaSatuan * item.qty) - item.diskonItem
        Next

        Dim diskonTotal As Decimal = If(IsNumeric(txtDiskonTotal.Text), CDec(txtDiskonTotal.Text), 0)
        Dim totalBayar As Decimal = totalHarga - diskonTotal
        Dim bayar As Decimal = CDec(txtBayar.Text)

        If bayar < totalBayar Then
            MsgBox("Uang bayar kurang", MsgBoxStyle.Exclamation)
            txtBayar.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function SaveTransaction() As Boolean
        Dim connection As MySqlConnection = DBConnection.GetConnection()
        If connection Is Nothing Then Return False

        Try
            Dim transaction As MySqlTransaction = connection.BeginTransaction()

            Try
                Dim noTransaksi As String = lblNoTransaksi.Text.Replace("No. Transaksi: ", "")
                Dim totalHarga As Decimal = 0
                For Each item In cartItems
                    totalHarga += (item.hargaSatuan * item.qty) - item.diskonItem
                Next

                Dim diskonTotal As Decimal = If(IsNumeric(txtDiskonTotal.Text), CDec(txtDiskonTotal.Text), 0)
                Dim totalBayar As Decimal = totalHarga - diskonTotal
                Dim bayar As Decimal = CDec(txtBayar.Text)
                Dim kembalian As Decimal = bayar - totalBayar

                Dim query As String = "INSERT INTO tbl_transaksi (no_transaksi, tanggal, total_harga, diskon_total, total_bayar, bayar, kembalian, id_user, status) " &
                    "VALUES (@noTransaksi, NOW(), @totalHarga, @diskonTotal, @totalBayar, @bayar, @kembalian, @idUser, 'aktif')"

                Dim command As New MySqlCommand(query, connection, transaction)
                command.Parameters.AddWithValue("@noTransaksi", noTransaksi)
                command.Parameters.AddWithValue("@totalHarga", totalHarga)
                command.Parameters.AddWithValue("@diskonTotal", diskonTotal)
                command.Parameters.AddWithValue("@totalBayar", totalBayar)
                command.Parameters.AddWithValue("@bayar", bayar)
                command.Parameters.AddWithValue("@kembalian", kembalian)
                command.Parameters.AddWithValue("@idUser", SessionHelper.UserId)

                command.ExecuteNonQuery()

                Dim idTransaksi As Integer = CInt(command.LastInsertedId)

                For Each item In cartItems
                    Dim detailQuery As String = "INSERT INTO tbl_detail_transaksi (id_transaksi, id_produk, nama_produk, harga_satuan, jumlah, diskon_item, subtotal) " &
                        "VALUES (@idTransaksi, @idProduk, @namaProduk, @hargaSatuan, @jumlah, @diskonItem, @subtotal)"

                    Dim detailCommand As New MySqlCommand(detailQuery, connection, transaction)
                    detailCommand.Parameters.AddWithValue("@idTransaksi", idTransaksi)
                    detailCommand.Parameters.AddWithValue("@idProduk", item.idProduk)
                    detailCommand.Parameters.AddWithValue("@namaProduk", item.namaProduk)
                    detailCommand.Parameters.AddWithValue("@hargaSatuan", item.hargaSatuan)
                    detailCommand.Parameters.AddWithValue("@jumlah", item.qty)
                    detailCommand.Parameters.AddWithValue("@diskonItem", item.diskonItem)
                    detailCommand.Parameters.AddWithValue("@subtotal", (item.hargaSatuan * item.qty) - item.diskonItem)

                    detailCommand.ExecuteNonQuery()

                    Dim updateStokQuery As String = "UPDATE tbl_produk SET stok = stok - @jumlah WHERE id_produk = @idProduk"
                    Dim updateStokCommand As New MySqlCommand(updateStokQuery, connection, transaction)
                    updateStokCommand.Parameters.AddWithValue("@jumlah", item.qty)
                    updateStokCommand.Parameters.AddWithValue("@idProduk", item.idProduk)
                    updateStokCommand.ExecuteNonQuery()
                Next

                transaction.Commit()
                Dim totalHargaCalc As Decimal = 0
                For Each item In cartItems
                    totalHargaCalc += (item.hargaSatuan * item.qty) - item.diskonItem
                Next
                Dim diskonTotalCalc As Decimal = If(IsNumeric(txtDiskonTotal.Text), CDec(txtDiskonTotal.Text), 0)
                Dim totalBayarCalc As Decimal = totalHargaCalc - diskonTotalCalc
                LogHelper.CatatLog("Transaksi", "Transaksi " & noTransaksi & " berhasil disimpan, total: Rp " & totalBayarCalc.ToString("N0"))
                MsgBox("Transaksi " & noTransaksi & " berhasil disimpan", MsgBoxStyle.Information)
                Return True

            Catch ex As Exception
                transaction.Rollback()
                MsgBox("Error saving transaction: " & ex.Message, MsgBoxStyle.Critical)
                Return False
            End Try

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Private Sub ShowLowStockNotification()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "SELECT nama_produk, stok, stok_minimum FROM tbl_produk " &
                "WHERE stok <= stok_minimum AND is_active = 1 LIMIT 10"

            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Dim message As String = "Produk dengan stok menipis:" & vbCrLf & vbCrLf
                For Each row In table.Rows
                    message &= "- " & row("nama_produk").ToString() & " (Stok: " & row("stok").ToString() & ")" & vbCrLf
                Next
                MsgBox(message, MsgBoxStyle.Information, "Notifikasi Stok Menipis")
            End If

            connection.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ShowPrintOptions(noTransaksi As String)
        Dim form As New Form()
        form.Text = "Pilih Metode Cetak"
        form.Width = 300
        form.Height = 150
        form.StartPosition = FormStartPosition.CenterParent
        form.FormBorderStyle = FormBorderStyle.FixedDialog
        form.MaximizeBox = False
        form.MinimizeBox = False

        Dim lblMsg As New Label()
        lblMsg.Text = "Pilih metode cetak struk:"
        lblMsg.Location = New Point(20, 20)
        lblMsg.AutoSize = True
        form.Controls.Add(lblMsg)

        Dim btnPrinter As New Button()
        btnPrinter.Text = "Cetak ke Printer"
        btnPrinter.Location = New Point(20, 50)
        btnPrinter.Width = 120
        btnPrinter.Height = 35
        AddHandler btnPrinter.Click, Sub(s, e)
                                         PrintStruk()
                                         form.Close()
                                     End Sub
        form.Controls.Add(btnPrinter)

        Dim btnPDF As New Button()
        btnPDF.Text = "Cetak ke PDF"
        btnPDF.Location = New Point(150, 50)
        btnPDF.Width = 120
        btnPDF.Height = 35
        AddHandler btnPDF.Click, Sub(s, e)
                                     PrintToPDF(noTransaksi)
                                     form.Close()
                                 End Sub
        form.Controls.Add(btnPDF)

        form.ShowDialog()
    End Sub

    Private Sub PrintToPDF(noTransaksi As String)
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PDF Files (*.pdf)|*.pdf"
            saveDialog.FileName = "Struk_" & noTransaksi.Replace("-", "_") & ".pdf"
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim doc As New Document(PageSize.A4)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New System.IO.FileStream(saveDialog.FileName, System.IO.FileMode.Create))
                doc.Open()

                Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD)
                Dim normalFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10)
                Dim smallFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9)

                doc.Add(New Paragraph("KasirIn", titleFont) With {.Alignment = Element.ALIGN_CENTER})
                doc.Add(New Paragraph("Sistem Kasir & Inventori", smallFont) With {.Alignment = Element.ALIGN_CENTER})
                doc.Add(New Paragraph(" "))
                doc.Add(New Paragraph("No. Transaksi: " & noTransaksi, normalFont))
                doc.Add(New Paragraph("Tanggal: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), normalFont))
                doc.Add(New Paragraph("Kasir: " & SessionHelper.NamaLengkap, normalFont))
                doc.Add(New Paragraph(" "))

                Dim table As New PdfPTable(4)
                table.WidthPercentage = 100
                table.SetWidths(New Single() {2, 3, 2, 2})

                Dim headerCell As New PdfPCell(New Phrase("Produk", smallFont)) With {.BackgroundColor = New BaseColor(200, 200, 200)}
                table.AddCell(headerCell)
                headerCell = New PdfPCell(New Phrase("Qty x Harga", smallFont)) With {.BackgroundColor = New BaseColor(200, 200, 200)}
                table.AddCell(headerCell)
                headerCell = New PdfPCell(New Phrase("Diskon", smallFont)) With {.BackgroundColor = New BaseColor(200, 200, 200)}
                table.AddCell(headerCell)
                headerCell = New PdfPCell(New Phrase("Subtotal", smallFont)) With {.BackgroundColor = New BaseColor(200, 200, 200)}
                table.AddCell(headerCell)

                For Each item In cartItems
                    Dim subtotal As Decimal = (item.hargaSatuan * item.qty) - item.diskonItem
                    table.AddCell(New PdfPCell(New Phrase(item.namaProduk, smallFont)))
                    table.AddCell(New PdfPCell(New Phrase(item.qty & " x Rp " & item.hargaSatuan.ToString("N0"), smallFont)))
                    table.AddCell(New PdfPCell(New Phrase("Rp " & item.diskonItem.ToString("N0"), smallFont)))
                    table.AddCell(New PdfPCell(New Phrase("Rp " & subtotal.ToString("N0"), smallFont)))
                Next

                doc.Add(table)
                doc.Add(New Paragraph(" "))

                Dim totalHargaCalc As Decimal = 0
                For Each item In cartItems
                    totalHargaCalc += (item.hargaSatuan * item.qty) - item.diskonItem
                Next
                Dim diskonTotal As Decimal = If(IsNumeric(txtDiskonTotal.Text), CDec(txtDiskonTotal.Text), 0)
                Dim totalBayar As Decimal = totalHargaCalc - diskonTotal
                Dim bayar As Decimal = CDec(txtBayar.Text)
                Dim kembalian As Decimal = bayar - totalBayar

                doc.Add(New Paragraph("Total Harga  : Rp " & totalHargaCalc.ToString("N0"), normalFont))
                doc.Add(New Paragraph("Diskon       : Rp " & diskonTotal.ToString("N0"), normalFont))
                doc.Add(New Paragraph("Total Bayar  : Rp " & totalBayar.ToString("N0"), normalFont))
                doc.Add(New Paragraph("Bayar        : Rp " & bayar.ToString("N0"), normalFont))
                doc.Add(New Paragraph("Kembalian    : Rp " & kembalian.ToString("N0"), normalFont))
                doc.Add(New Paragraph(" "))
                doc.Add(New Paragraph("Terima kasih sudah belanja!", smallFont) With {.Alignment = Element.ALIGN_CENTER})

                doc.Close()
                writer.Close()

                MsgBox("Struk berhasil disimpan ke: " & saveDialog.FileName, MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Error creating PDF: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub PrintStruk()
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
        Dim y As Single = 50
        Dim x As Single = 50

        Dim noTransaksi As String = lblNoTransaksi.Text.Replace("No. Transaksi: ", "")
        Dim tanggal As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim kasir As String = SessionHelper.NamaLengkap

        e.Graphics.DrawString("================================", font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("         KasirIn", font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("  Sistem Kasir & Inventori", font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("================================", font, Brushes.Black, x, y)
        y += 20

        e.Graphics.DrawString("No  : " & noTransaksi, font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("Tgl : " & tanggal, font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("Kasir: " & kasir, font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("--------------------------------", font, Brushes.Black, x, y)
        y += 20

        For Each item In cartItems
            Dim subtotal As Decimal = (item.hargaSatuan * item.qty) - item.diskonItem
            e.Graphics.DrawString(item.namaProduk, font, Brushes.Black, x, y)
            y += 20
            e.Graphics.DrawString("  " & item.qty & " x Rp " & item.hargaSatuan.ToString("N0") & " = Rp " & subtotal.ToString("N0"), font, Brushes.Black, x, y)
            y += 20
        Next

        e.Graphics.DrawString("--------------------------------", font, Brushes.Black, x, y)
        y += 20

        Dim totalHargaCalc As Decimal = 0
        For Each item In cartItems
            totalHargaCalc += (item.hargaSatuan * item.qty) - item.diskonItem
        Next
        Dim diskonTotal As Decimal = If(IsNumeric(txtDiskonTotal.Text), CDec(txtDiskonTotal.Text), 0)
        Dim totalBayar As Decimal = totalHargaCalc - diskonTotal
        Dim bayar As Decimal = CDec(txtBayar.Text)
        Dim kembalian As Decimal = bayar - totalBayar

        e.Graphics.DrawString("Total Harga : Rp " & totalHargaCalc.ToString("N0"), font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("Diskon      : Rp " & diskonTotal.ToString("N0"), font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("Total Bayar : Rp " & totalBayar.ToString("N0"), font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("Bayar       : Rp " & bayar.ToString("N0"), font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("Kembalian   : Rp " & kembalian.ToString("N0"), font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("--------------------------------", font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("  Terima kasih sudah belanja!", font, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("================================", font, Brushes.Black, x, y)

        e.HasMorePages = False
    End Sub
End Class

