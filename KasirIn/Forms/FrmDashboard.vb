Imports MySql.Data.MySqlClient

Public Class FrmDashboard
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SessionHelper.UserId = 0 Then
            Dim loginForm As New FrmLogin()
            loginForm.ShowDialog()
            If SessionHelper.UserId = 0 Then
                Me.Close()
                Return
            End If
        End If

        SetupUI()
        ApplyRoleBasedVisibility()
        LoadDashboardData()
    End Sub

    Private Sub SetupUI()
        lblUserInfo.Text = "Halo, " & SessionHelper.NamaLengkap & " (" & SessionHelper.Role & ")"
        lblPageTitle.Text = "Beranda"
        SetActiveNavButton(btnBeranda)
    End Sub

    Private Sub ApplyRoleBasedVisibility()
        If SessionHelper.Role = "Kasir" Then
            btnSupplier.Visible = False
            btnLaporan.Visible = False
        End If
    End Sub

    Private Sub LoadDashboardData()
        Try
            LoadSummaryCards()
            LoadTransaksiTerakhir()
            LoadStokMenipis()
        Catch ex As Exception
            MsgBox("Error loading dashboard: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LoadSummaryCards()
        Dim connection As MySqlConnection = DBConnection.GetConnection()
        If connection Is Nothing Then Return

        Try
            Dim totalPenjualan As Decimal = 0
            Dim jumlahTransaksi As Integer = 0
            Dim totalProdukAktif As Integer = 0
            Dim stokMenipis As Integer = 0

            Dim query1 As String = "SELECT COALESCE(SUM(total_bayar), 0) as total FROM tbl_transaksi WHERE DATE(tanggal) = CURDATE() AND status = 'aktif'"
            Dim cmd1 As New MySqlCommand(query1, connection)
            Dim result1 = cmd1.ExecuteScalar()
            If result1 IsNot Nothing Then
                totalPenjualan = CDec(result1)
            End If

            Dim query2 As String = "SELECT COUNT(*) as jumlah FROM tbl_transaksi WHERE DATE(tanggal) = CURDATE() AND status = 'aktif'"
            Dim cmd2 As New MySqlCommand(query2, connection)
            Dim result2 = cmd2.ExecuteScalar()
            If result2 IsNot Nothing Then
                jumlahTransaksi = CInt(result2)
            End If

            Dim query3 As String = "SELECT COUNT(*) as jumlah FROM tbl_produk WHERE is_active = 1"
            Dim cmd3 As New MySqlCommand(query3, connection)
            Dim result3 = cmd3.ExecuteScalar()
            If result3 IsNot Nothing Then
                totalProdukAktif = CInt(result3)
            End If

            Dim query4 As String = "SELECT COUNT(*) as jumlah FROM tbl_produk WHERE stok <= stok_minimum AND is_active = 1"
            Dim cmd4 As New MySqlCommand(query4, connection)
            Dim result4 = cmd4.ExecuteScalar()
            If result4 IsNot Nothing Then
                stokMenipis = CInt(result4)
            End If

            lblPenjualanHariIni1.Text = "Rp " & totalPenjualan.ToString("N0")
            lblTransaksiHariIni1.Text = jumlahTransaksi.ToString()
            lblProdukAktif1.Text = totalProdukAktif.ToString()
            lblStokMenipis1.Text = stokMenipis.ToString()

        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub LoadTransaksiTerakhir()
        Dim connection As MySqlConnection = DBConnection.GetConnection()
        If connection Is Nothing Then Return

        Try
            Dim query As String = "SELECT no_transaksi, tanggal, total_bayar, status FROM tbl_transaksi ORDER BY tanggal DESC LIMIT 5"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvTransaksiTerakhir.DataSource = table
            dgvTransaksiTerakhir.Columns(0).HeaderText = "No. Transaksi"
            dgvTransaksiTerakhir.Columns(1).HeaderText = "Tanggal"
            dgvTransaksiTerakhir.Columns(2).HeaderText = "Total"
            dgvTransaksiTerakhir.Columns(3).HeaderText = "Status"

            dgvTransaksiTerakhir.AutoResizeColumns()

        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub LoadStokMenipis()
        Dim connection As MySqlConnection = DBConnection.GetConnection()
        If connection Is Nothing Then Return

        Try
            Dim query As String = "SELECT nama_produk, stok, stok_minimum, satuan FROM tbl_produk WHERE stok <= stok_minimum AND is_active = 1 ORDER BY stok ASC"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvStokMenipis.DataSource = table
            dgvStokMenipis.Columns(0).HeaderText = "Nama Produk"
            dgvStokMenipis.Columns(1).HeaderText = "Stok"
            dgvStokMenipis.Columns(2).HeaderText = "Min"
            dgvStokMenipis.Columns(3).HeaderText = "Satuan"

            dgvStokMenipis.AutoResizeColumns()

        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnBeranda_Click(sender As Object, e As EventArgs) Handles btnBeranda.Click
        lblPageTitle.Text = "Beranda"
        pnlBeranda.Visible = True
        SetActiveNavButton(btnBeranda)
        LoadDashboardData()
    End Sub

    Private Sub btnKasir_Click(sender As Object, e As EventArgs) Handles btnKasir.Click
        lblPageTitle.Text = "Kasir"
        SetActiveNavButton(btnKasir)
        Dim kasirForm As New FrmKasir()
        kasirForm.ShowDialog()
    End Sub

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        lblPageTitle.Text = "Produk"
        SetActiveNavButton(btnProduk)
        Dim produkForm As New FrmProduk()
        produkForm.ShowDialog()
    End Sub

    Private Sub btnKategori_Click(sender As Object, e As EventArgs) Handles btnKategori.Click
        lblPageTitle.Text = "Kategori"
        SetActiveNavButton(btnKategori)
        Dim kategoriForm As New FrmKategori()
        kategoriForm.ShowDialog()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        lblPageTitle.Text = "Supplier"
        SetActiveNavButton(btnSupplier)
        Dim supplierForm As New FrmSupplier()
        supplierForm.ShowDialog()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        lblPageTitle.Text = "Laporan"
        SetActiveNavButton(btnLaporan)
        Dim laporanForm As New FrmLaporan()
        laporanForm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MsgBox("Apakah Anda yakin ingin logout?", MsgBoxStyle.YesNo, "Confirm Logout")
        If result = DialogResult.Yes Then
            SessionHelper.ClearSession()
            Dim loginForm As New FrmLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub SetActiveNavButton(activeButton As Button)
        btnBeranda.BackColor = Color.FromArgb(30, 58, 95)
        btnKasir.BackColor = Color.FromArgb(30, 58, 95)
        btnProduk.BackColor = Color.FromArgb(30, 58, 95)
        btnKategori.BackColor = Color.FromArgb(30, 58, 95)
        btnSupplier.BackColor = Color.FromArgb(30, 58, 95)
        btnLaporan.BackColor = Color.FromArgb(30, 58, 95)

        activeButton.BackColor = Color.FromArgb(37, 99, 235)
    End Sub
End Class
