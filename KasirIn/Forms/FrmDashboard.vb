Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FrmDashboard
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SetupUI()
            ApplyRoleBasedVisibility()

            LoadSummaryCards()
            LoadTransaksiTerakhir()
            LoadStokMenipis()

            System.Windows.Forms.Application.DoEvents()

            Try
                LoadCharts()
            Catch chartEx As Exception
                System.Diagnostics.Debug.WriteLine("Chart Error: " & chartEx.Message & vbCrLf & chartEx.StackTrace)
            End Try
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Dashboard Load Error: " & ex.Message & vbCrLf & ex.StackTrace)
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

    Private Sub SetupUI()
        Try
            lblUserInfo.Text = "Halo, " & SessionHelper.NamaLengkap & " (" & SessionHelper.Role & ")"
            lblPageTitle.Text = "Beranda"
            SetActiveNavButton(btnBeranda)
        Catch ex As Exception
            MsgBox("Error in SetupUI: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ApplyRoleBasedVisibility()
        Try
            If SessionHelper.Role = "Kasir" Then
                btnSupplier.Visible = False
                btnLaporan.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Error in ApplyRoleBasedVisibility: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LoadCharts()
        Try
            ' Charts disabled temporarily - focus on data display
            ' LoadPenjualanChart()
            ' LoadTransaksiChart()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("LoadCharts Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadPenjualanChart()
        Dim connection As MySqlConnection = Nothing
        Try
            connection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            If chartPenjualan Is Nothing Then Return

            Dim query As String = "SELECT DATE(tanggal) as tgl, COALESCE(SUM(total_bayar), 0) as total FROM tbl_transaksi WHERE tanggal >= DATE_SUB(CURDATE(), INTERVAL 6 DAY) AND status = 'aktif' GROUP BY DATE(tanggal) ORDER BY tgl ASC"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            chartPenjualan.Series.Clear()
            chartPenjualan.ChartAreas.Clear()

            Dim chartArea As New ChartArea("ChartArea1")
            chartArea.BackColor = Color.White
            chartPenjualan.ChartAreas.Add(chartArea)

            Dim series As New Series("Penjualan")
            series.ChartType = SeriesChartType.Column
            series.Color = Color.FromArgb(37, 99, 235)
            series.IsValueShownAsLabel = True
            series.LabelFormat = "Rp #,##0"
            series.Font = New Font("Segoe UI", 8)

            Dim last7Days As New Dictionary(Of String, Decimal)
            For i As Integer = 6 To 0 Step -1
                Dim currentDate As DateTime = DateTime.Now.AddDays(-i)
                Dim dateStr As String = currentDate.ToString("dd/MM")
                last7Days(dateStr) = 0
            Next

            For Each row As DataRow In table.Rows
                Dim dateStr As String = CDate(row("tgl")).ToString("dd/MM")
                If last7Days.ContainsKey(dateStr) Then
                    last7Days(dateStr) = CDec(row("total"))
                End If
            Next

            For Each kvp In last7Days
                series.Points.AddXY(kvp.Key, kvp.Value)
            Next

            chartPenjualan.Series.Add(series)

            chartPenjualan.Legends.Clear()
            chartPenjualan.Titles.Clear()
            Dim title As New Title("Penjualan 7 Hari Terakhir")
            title.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            title.ForeColor = Color.FromArgb(31, 41, 55)
            chartPenjualan.Titles.Add(title)

            chartArea.AxisX.LabelStyle.Font = New Font("Segoe UI", 8)
            chartArea.AxisY.LabelStyle.Font = New Font("Segoe UI", 8)
            chartArea.AxisY.LabelStyle.Format = "Rp #,##0"

        Catch ex As Exception
            Throw New Exception("Error in LoadPenjualanChart: " & ex.Message, ex)
        Finally
            If connection IsNot Nothing Then
                Try
                    connection.Close()
                Catch
                End Try
            End If
        End Try
    End Sub

    Private Sub LoadTransaksiChart()
        Dim connection As MySqlConnection = Nothing
        Try
            connection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            If chartTransaksi Is Nothing Then Return

            Dim query As String = "SELECT DATE(tanggal) as tgl, COUNT(*) as jumlah FROM tbl_transaksi WHERE tanggal >= DATE_SUB(CURDATE(), INTERVAL 6 DAY) AND status = 'aktif' GROUP BY DATE(tanggal) ORDER BY tgl ASC"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            chartTransaksi.Series.Clear()
            chartTransaksi.ChartAreas.Clear()

            Dim chartArea As New ChartArea("ChartArea1")
            chartArea.BackColor = Color.White
            chartTransaksi.ChartAreas.Add(chartArea)

            Dim series As New Series("Transaksi")
            series.ChartType = SeriesChartType.Line
            series.Color = Color.FromArgb(16, 185, 129)
            series.BorderWidth = 3
            series.MarkerStyle = MarkerStyle.Circle
            series.MarkerSize = 8
            series.IsValueShownAsLabel = True
            series.LabelFormat = "#"
            series.Font = New Font("Segoe UI", 8)

            Dim last7Days As New Dictionary(Of String, Integer)
            For i As Integer = 6 To 0 Step -1
                Dim currentDate As DateTime = DateTime.Now.AddDays(-i)
                Dim dateStr As String = currentDate.ToString("dd/MM")
                last7Days(dateStr) = 0
            Next

            For Each row As DataRow In table.Rows
                Dim dateStr As String = CDate(row("tgl")).ToString("dd/MM")
                If last7Days.ContainsKey(dateStr) Then
                    last7Days(dateStr) = CInt(row("jumlah"))
                End If
            Next

            For Each kvp In last7Days
                series.Points.AddXY(kvp.Key, kvp.Value)
            Next

            chartTransaksi.Series.Add(series)

            chartTransaksi.Legends.Clear()
            chartTransaksi.Titles.Clear()
            Dim title As New Title("Jumlah Transaksi 7 Hari Terakhir")
            title.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            title.ForeColor = Color.FromArgb(31, 41, 55)
            chartTransaksi.Titles.Add(title)

            chartArea.AxisX.LabelStyle.Font = New Font("Segoe UI", 8)
            chartArea.AxisY.LabelStyle.Font = New Font("Segoe UI", 8)
            chartArea.AxisY.LabelStyle.Format = "#"

        Catch ex As Exception
            Throw New Exception("Error in LoadTransaksiChart: " & ex.Message, ex)
        Finally
            If connection IsNot Nothing Then
                Try
                    connection.Close()
                Catch
                End Try
            End If
        End Try
    End Sub

    Private Sub btnBeranda_Click(sender As Object, e As EventArgs) Handles btnBeranda.Click
        lblPageTitle.Text = "Beranda"
        pnlBeranda.Visible = True
        SetActiveNavButton(btnBeranda)
        Try
            LoadSummaryCards()
            LoadTransaksiTerakhir()
            LoadStokMenipis()
            System.Windows.Forms.Application.DoEvents()
            Try
                LoadCharts()
            Catch chartEx As Exception
                MsgBox("Warning: Chart loading failed: " & chartEx.Message, MsgBoxStyle.Exclamation)
            End Try
        Catch ex As Exception
            MsgBox("Error reloading dashboard: " & ex.Message, MsgBoxStyle.Critical)
        End Try
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
            LogHelper.CatatLog("Logout", "User " & SessionHelper.Username & " logout")
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
