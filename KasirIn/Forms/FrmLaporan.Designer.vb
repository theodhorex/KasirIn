<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLaporan
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabPenjualan = New System.Windows.Forms.TabPage()
        Me.pnlDetail = New System.Windows.Forms.Panel()
        Me.dgvDetail = New System.Windows.Forms.DataGridView()
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.lblRataRata = New System.Windows.Forms.Label()
        Me.lblTotalDiskon = New System.Windows.Forms.Label()
        Me.lblTotalPendapatan = New System.Windows.Forms.Label()
        Me.lblTotalTransaksi = New System.Windows.Forms.Label()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.dtpSampai = New System.Windows.Forms.DateTimePicker()
        Me.lblSampai = New System.Windows.Forms.Label()
        Me.dtpDari = New System.Windows.Forms.DateTimePicker()
        Me.lblDari = New System.Windows.Forms.Label()
        Me.tabStok = New System.Windows.Forms.TabPage()
        Me.lblSummaryStok = New System.Windows.Forms.Label()
        Me.dgvStok = New System.Windows.Forms.DataGridView()
        Me.pnlFilterStok = New System.Windows.Forms.Panel()
        Me.btnExportStok = New System.Windows.Forms.Button()
        Me.btnTampilkanStok = New System.Windows.Forms.Button()
        Me.chkStokMenipis = New System.Windows.Forms.CheckBox()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.lblKategori = New System.Windows.Forms.Label()
        Me.tabVoid = New System.Windows.Forms.TabPage()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.dgvVoid = New System.Windows.Forms.DataGridView()
        Me.pnlFilterVoid = New System.Windows.Forms.Panel()
        Me.btnTampilkanVoid = New System.Windows.Forms.Button()
        Me.dtpVoidSampai = New System.Windows.Forms.DateTimePicker()
        Me.lblVoidSampai = New System.Windows.Forms.Label()
        Me.dtpVoidDari = New System.Windows.Forms.DateTimePicker()
        Me.lblVoidDari = New System.Windows.Forms.Label()
        Me.tabNeraca = New System.Windows.Forms.TabPage()
        Me.pnlNeracaFilter = New System.Windows.Forms.Panel()
        Me.btnPrintNeraca = New System.Windows.Forms.Button()
        Me.btnExportNeraca = New System.Windows.Forms.Button()
        Me.btnHitungNeraca = New System.Windows.Forms.Button()
        Me.dtpNeracaSampai = New System.Windows.Forms.DateTimePicker()
        Me.lblNeracaSampai = New System.Windows.Forms.Label()
        Me.dtpNeracaDari = New System.Windows.Forms.DateTimePicker()
        Me.lblNeracaDari = New System.Windows.Forms.Label()
        Me.pnlNeracaContent = New System.Windows.Forms.Panel()
        Me.lblNeracaVoidSub = New System.Windows.Forms.Label()
        Me.lblNeracaVoid = New System.Windows.Forms.Label()
        Me.pnlNeracaCard6 = New System.Windows.Forms.Panel()
        Me.lblNeracaLabaBersih = New System.Windows.Forms.Label()
        Me.pnlNeracaCard5 = New System.Windows.Forms.Panel()
        Me.lblNeracaPengeluaran = New System.Windows.Forms.Label()
        Me.btnKelolaPengeluaran = New System.Windows.Forms.Button()
        Me.pnlNeracaCard4 = New System.Windows.Forms.Panel()
        Me.lblNeracaLabaKotorSub = New System.Windows.Forms.Label()
        Me.lblNeracaLabaKotor = New System.Windows.Forms.Label()
        Me.pnlNeracaCard3 = New System.Windows.Forms.Panel()
        Me.lblNeracaHPPSub = New System.Windows.Forms.Label()
        Me.lblNeracaHPP = New System.Windows.Forms.Label()
        Me.pnlNeracaCard2 = New System.Windows.Forms.Panel()
        Me.lblNeracaPendapatanSub = New System.Windows.Forms.Label()
        Me.lblNeracaPendapatan = New System.Windows.Forms.Label()
        Me.pnlNeracaCard1 = New System.Windows.Forms.Panel()
        Me.tabLog = New System.Windows.Forms.TabPage()
        Me.pnlLogFilter = New System.Windows.Forms.Panel()
        Me.btnExportLog = New System.Windows.Forms.Button()
        Me.btnTampilkanLog = New System.Windows.Forms.Button()
        Me.cmbFilterAksi = New System.Windows.Forms.ComboBox()
        Me.lblFilterAksi = New System.Windows.Forms.Label()
        Me.dtpLogSampai = New System.Windows.Forms.DateTimePicker()
        Me.lblLogSampai = New System.Windows.Forms.Label()
        Me.dtpLogDari = New System.Windows.Forms.DateTimePicker()
        Me.lblLogDari = New System.Windows.Forms.Label()
        Me.dgvLog = New System.Windows.Forms.DataGridView()
        Me.lblLogSummary = New System.Windows.Forms.Label()
        Me.tabControl.SuspendLayout()
        Me.tabPenjualan.SuspendLayout()
        Me.pnlDetail.SuspendLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSummary.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.tabStok.SuspendLayout()
        CType(Me.dgvStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilterStok.SuspendLayout()
        Me.tabVoid.SuspendLayout()
        CType(Me.dgvVoid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilterVoid.SuspendLayout()
        Me.SuspendLayout()

        Me.tabControl.Controls.Add(Me.tabPenjualan)
        Me.tabControl.Controls.Add(Me.tabStok)
        Me.tabControl.Controls.Add(Me.tabVoid)
        Me.tabControl.Controls.Add(Me.tabNeraca)
        Me.tabControl.Controls.Add(Me.tabLog)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(1100, 680)
        Me.tabControl.TabIndex = 0

        Me.tabPenjualan.Controls.Add(Me.pnlDetail)
        Me.tabPenjualan.Controls.Add(Me.dgvLaporan)
        Me.tabPenjualan.Controls.Add(Me.pnlSummary)
        Me.tabPenjualan.Controls.Add(Me.pnlFilter)
        Me.tabPenjualan.Location = New System.Drawing.Point(4, 24)
        Me.tabPenjualan.Name = "tabPenjualan"
        Me.tabPenjualan.Padding = New System.Windows.Forms.Padding(10)
        Me.tabPenjualan.Size = New System.Drawing.Size(1092, 652)
        Me.tabPenjualan.TabIndex = 0
        Me.tabPenjualan.Text = "Laporan Penjualan"
        Me.tabPenjualan.UseVisualStyleBackColor = True

        Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFilter.Controls.Add(Me.btnPrint)
        Me.pnlFilter.Controls.Add(Me.btnExportExcel)
        Me.pnlFilter.Controls.Add(Me.btnTampilkan)
        Me.pnlFilter.Controls.Add(Me.dtpSampai)
        Me.pnlFilter.Controls.Add(Me.lblSampai)
        Me.pnlFilter.Controls.Add(Me.dtpDari)
        Me.pnlFilter.Controls.Add(Me.lblDari)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(10, 10)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlFilter.Size = New System.Drawing.Size(1072, 70)
        Me.pnlFilter.TabIndex = 0

        Me.lblDari.AutoSize = True
        Me.lblDari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDari.Location = New System.Drawing.Point(15, 15)
        Me.lblDari.Name = "lblDari"
        Me.lblDari.Size = New System.Drawing.Size(70, 15)
        Me.lblDari.TabIndex = 0
        Me.lblDari.Text = "Dari Tanggal"

        Me.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDari.Location = New System.Drawing.Point(15, 33)
        Me.dtpDari.Name = "dtpDari"
        Me.dtpDari.Size = New System.Drawing.Size(120, 23)
        Me.dtpDari.TabIndex = 1

        Me.lblSampai.AutoSize = True
        Me.lblSampai.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSampai.Location = New System.Drawing.Point(150, 15)
        Me.lblSampai.Name = "lblSampai"
        Me.lblSampai.Size = New System.Drawing.Size(85, 15)
        Me.lblSampai.TabIndex = 2
        Me.lblSampai.Text = "Sampai Tanggal"

        Me.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpSampai.Location = New System.Drawing.Point(150, 33)
        Me.dtpSampai.Name = "dtpSampai"
        Me.dtpSampai.Size = New System.Drawing.Size(120, 23)
        Me.dtpSampai.TabIndex = 3

        Me.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTampilkan.ForeColor = System.Drawing.Color.White
        Me.btnTampilkan.Location = New System.Drawing.Point(285, 33)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(90, 23)
        Me.btnTampilkan.TabIndex = 4
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = False

        Me.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(CType(34, Byte), CType(197, Byte), CType(94, Byte))
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportExcel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExportExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportExcel.Location = New System.Drawing.Point(385, 33)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(100, 23)
        Me.btnExportExcel.TabIndex = 5
        Me.btnExportExcel.Text = "Export Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False

        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(495, 33)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 23)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False

        Me.pnlSummary.BackColor = System.Drawing.Color.White
        Me.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSummary.Controls.Add(Me.lblRataRata)
        Me.pnlSummary.Controls.Add(Me.lblTotalDiskon)
        Me.pnlSummary.Controls.Add(Me.lblTotalPendapatan)
        Me.pnlSummary.Controls.Add(Me.lblTotalTransaksi)
        Me.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSummary.Location = New System.Drawing.Point(10, 80)
        Me.pnlSummary.Name = "pnlSummary"
        Me.pnlSummary.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlSummary.Size = New System.Drawing.Size(1072, 80)
        Me.pnlSummary.TabIndex = 1

        Me.lblTotalTransaksi.AutoSize = True
        Me.lblTotalTransaksi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalTransaksi.Location = New System.Drawing.Point(15, 15)
        Me.lblTotalTransaksi.Name = "lblTotalTransaksi"
        Me.lblTotalTransaksi.Size = New System.Drawing.Size(150, 15)
        Me.lblTotalTransaksi.TabIndex = 0
        Me.lblTotalTransaksi.Text = "Total Transaksi: 0"

        Me.lblTotalPendapatan.AutoSize = True
        Me.lblTotalPendapatan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalPendapatan.Location = New System.Drawing.Point(15, 35)
        Me.lblTotalPendapatan.Name = "lblTotalPendapatan"
        Me.lblTotalPendapatan.Size = New System.Drawing.Size(180, 15)
        Me.lblTotalPendapatan.TabIndex = 1
        Me.lblTotalPendapatan.Text = "Total Pendapatan: Rp 0"

        Me.lblTotalDiskon.AutoSize = True
        Me.lblTotalDiskon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalDiskon.Location = New System.Drawing.Point(400, 15)
        Me.lblTotalDiskon.Name = "lblTotalDiskon"
        Me.lblTotalDiskon.Size = New System.Drawing.Size(150, 15)
        Me.lblTotalDiskon.TabIndex = 2
        Me.lblTotalDiskon.Text = "Total Diskon: Rp 0"

        Me.lblRataRata.AutoSize = True
        Me.lblRataRata.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRataRata.Location = New System.Drawing.Point(400, 35)
        Me.lblRataRata.Name = "lblRataRata"
        Me.lblRataRata.Size = New System.Drawing.Size(180, 15)
        Me.lblRataRata.TabIndex = 3
        Me.lblRataRata.Text = "Rata-rata Transaksi: Rp 0"

        Me.dgvLaporan.AllowUserToAddRows = False
        Me.dgvLaporan.AllowUserToDeleteRows = False
        Me.dgvLaporan.BackgroundColor = System.Drawing.Color.White
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLaporan.Location = New System.Drawing.Point(10, 160)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.ReadOnly = True
        Me.dgvLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLaporan.Size = New System.Drawing.Size(1072, 312)
        Me.dgvLaporan.TabIndex = 2

        Me.pnlDetail.BackColor = System.Drawing.Color.White
        Me.pnlDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDetail.Controls.Add(Me.dgvDetail)
        Me.pnlDetail.Controls.Add(Me.lblDetail)
        Me.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDetail.Location = New System.Drawing.Point(10, 472)
        Me.pnlDetail.Name = "pnlDetail"
        Me.pnlDetail.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlDetail.Size = New System.Drawing.Size(1072, 170)
        Me.pnlDetail.TabIndex = 3

        Me.lblDetail.AutoSize = True
        Me.lblDetail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetail.Location = New System.Drawing.Point(10, 10)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(150, 15)
        Me.lblDetail.TabIndex = 0
        Me.lblDetail.Text = "Detail Transaksi: -"

        Me.dgvDetail.AllowUserToAddRows = False
        Me.dgvDetail.AllowUserToDeleteRows = False
        Me.dgvDetail.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetail.Location = New System.Drawing.Point(10, 30)
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.ReadOnly = True
        Me.dgvDetail.Size = New System.Drawing.Size(1052, 130)
        Me.dgvDetail.TabIndex = 1

        Me.tabStok.Controls.Add(Me.lblSummaryStok)
        Me.tabStok.Controls.Add(Me.dgvStok)
        Me.tabStok.Controls.Add(Me.pnlFilterStok)
        Me.tabStok.Location = New System.Drawing.Point(4, 24)
        Me.tabStok.Name = "tabStok"
        Me.tabStok.Padding = New System.Windows.Forms.Padding(10)
        Me.tabStok.Size = New System.Drawing.Size(1092, 652)
        Me.tabStok.TabIndex = 1
        Me.tabStok.Text = "Laporan Stok & Inventori"
        Me.tabStok.UseVisualStyleBackColor = True

        Me.pnlFilterStok.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.pnlFilterStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFilterStok.Controls.Add(Me.btnExportStok)
        Me.pnlFilterStok.Controls.Add(Me.btnTampilkanStok)
        Me.pnlFilterStok.Controls.Add(Me.chkStokMenipis)
        Me.pnlFilterStok.Controls.Add(Me.cmbKategori)
        Me.pnlFilterStok.Controls.Add(Me.lblKategori)
        Me.pnlFilterStok.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterStok.Location = New System.Drawing.Point(10, 10)
        Me.pnlFilterStok.Name = "pnlFilterStok"
        Me.pnlFilterStok.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlFilterStok.Size = New System.Drawing.Size(1072, 70)
        Me.pnlFilterStok.TabIndex = 0

        Me.lblKategori.AutoSize = True
        Me.lblKategori.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKategori.Location = New System.Drawing.Point(15, 15)
        Me.lblKategori.Name = "lblKategori"
        Me.lblKategori.Size = New System.Drawing.Size(50, 15)
        Me.lblKategori.TabIndex = 0
        Me.lblKategori.Text = "Kategori"

        Me.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(15, 33)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(150, 23)
        Me.cmbKategori.TabIndex = 1

        Me.chkStokMenipis.AutoSize = True
        Me.chkStokMenipis.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkStokMenipis.Location = New System.Drawing.Point(180, 35)
        Me.chkStokMenipis.Name = "chkStokMenipis"
        Me.chkStokMenipis.Size = New System.Drawing.Size(150, 19)
        Me.chkStokMenipis.TabIndex = 2
        Me.chkStokMenipis.Text = "Tampilkan hanya stok menipis"
        Me.chkStokMenipis.UseVisualStyleBackColor = True

        Me.btnTampilkanStok.BackColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.btnTampilkanStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkanStok.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTampilkanStok.ForeColor = System.Drawing.Color.White
        Me.btnTampilkanStok.Location = New System.Drawing.Point(350, 33)
        Me.btnTampilkanStok.Name = "btnTampilkanStok"
        Me.btnTampilkanStok.Size = New System.Drawing.Size(90, 23)
        Me.btnTampilkanStok.TabIndex = 3
        Me.btnTampilkanStok.Text = "Tampilkan"
        Me.btnTampilkanStok.UseVisualStyleBackColor = False

        Me.btnExportStok.BackColor = System.Drawing.Color.FromArgb(CType(34, Byte), CType(197, Byte), CType(94, Byte))
        Me.btnExportStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportStok.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExportStok.ForeColor = System.Drawing.Color.White
        Me.btnExportStok.Location = New System.Drawing.Point(450, 33)
        Me.btnExportStok.Name = "btnExportStok"
        Me.btnExportStok.Size = New System.Drawing.Size(100, 23)
        Me.btnExportStok.TabIndex = 4
        Me.btnExportStok.Text = "Export Excel"
        Me.btnExportStok.UseVisualStyleBackColor = False

        Me.dgvStok.AllowUserToAddRows = False
        Me.dgvStok.AllowUserToDeleteRows = False
        Me.dgvStok.BackgroundColor = System.Drawing.Color.White
        Me.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStok.Location = New System.Drawing.Point(10, 80)
        Me.dgvStok.Name = "dgvStok"
        Me.dgvStok.ReadOnly = True
        Me.dgvStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStok.Size = New System.Drawing.Size(1072, 562)
        Me.dgvStok.TabIndex = 1

        Me.lblSummaryStok.BackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(244, Byte), CType(246, Byte))
        Me.lblSummaryStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSummaryStok.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSummaryStok.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSummaryStok.Location = New System.Drawing.Point(10, 642)
        Me.lblSummaryStok.Name = "lblSummaryStok"
        Me.lblSummaryStok.Padding = New System.Windows.Forms.Padding(10)
        Me.lblSummaryStok.Size = New System.Drawing.Size(1072, 30)
        Me.lblSummaryStok.TabIndex = 2
        Me.lblSummaryStok.Text = "Total Produk: 0 | Total Nilai Inventori: Rp 0 | Stok Menipis: 0"

        Me.tabVoid.Controls.Add(Me.btnVoid)
        Me.tabVoid.Controls.Add(Me.dgvVoid)
        Me.tabVoid.Controls.Add(Me.pnlFilterVoid)
        Me.tabVoid.Location = New System.Drawing.Point(4, 24)
        Me.tabVoid.Name = "tabVoid"
        Me.tabVoid.Padding = New System.Windows.Forms.Padding(10)
        Me.tabVoid.Size = New System.Drawing.Size(1092, 652)
        Me.tabVoid.TabIndex = 2
        Me.tabVoid.Text = "Void Transaksi"
        Me.tabVoid.UseVisualStyleBackColor = True

        Me.pnlFilterVoid.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.pnlFilterVoid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFilterVoid.Controls.Add(Me.btnTampilkanVoid)
        Me.pnlFilterVoid.Controls.Add(Me.dtpVoidSampai)
        Me.pnlFilterVoid.Controls.Add(Me.lblVoidSampai)
        Me.pnlFilterVoid.Controls.Add(Me.dtpVoidDari)
        Me.pnlFilterVoid.Controls.Add(Me.lblVoidDari)
        Me.pnlFilterVoid.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterVoid.Location = New System.Drawing.Point(10, 10)
        Me.pnlFilterVoid.Name = "pnlFilterVoid"
        Me.pnlFilterVoid.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlFilterVoid.Size = New System.Drawing.Size(1072, 70)
        Me.pnlFilterVoid.TabIndex = 0

        Me.lblVoidDari.AutoSize = True
        Me.lblVoidDari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblVoidDari.Location = New System.Drawing.Point(15, 15)
        Me.lblVoidDari.Name = "lblVoidDari"
        Me.lblVoidDari.Size = New System.Drawing.Size(70, 15)
        Me.lblVoidDari.TabIndex = 0
        Me.lblVoidDari.Text = "Dari Tanggal"

        Me.dtpVoidDari.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpVoidDari.Location = New System.Drawing.Point(15, 33)
        Me.dtpVoidDari.Name = "dtpVoidDari"
        Me.dtpVoidDari.Size = New System.Drawing.Size(120, 23)
        Me.dtpVoidDari.TabIndex = 1

        Me.lblVoidSampai.AutoSize = True
        Me.lblVoidSampai.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblVoidSampai.Location = New System.Drawing.Point(150, 15)
        Me.lblVoidSampai.Name = "lblVoidSampai"
        Me.lblVoidSampai.Size = New System.Drawing.Size(85, 15)
        Me.lblVoidSampai.TabIndex = 2
        Me.lblVoidSampai.Text = "Sampai Tanggal"

        Me.dtpVoidSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpVoidSampai.Location = New System.Drawing.Point(150, 33)
        Me.dtpVoidSampai.Name = "dtpVoidSampai"
        Me.dtpVoidSampai.Size = New System.Drawing.Size(120, 23)
        Me.dtpVoidSampai.TabIndex = 3

        Me.btnTampilkanVoid.BackColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.btnTampilkanVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkanVoid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTampilkanVoid.ForeColor = System.Drawing.Color.White
        Me.btnTampilkanVoid.Location = New System.Drawing.Point(285, 33)
        Me.btnTampilkanVoid.Name = "btnTampilkanVoid"
        Me.btnTampilkanVoid.Size = New System.Drawing.Size(90, 23)
        Me.btnTampilkanVoid.TabIndex = 4
        Me.btnTampilkanVoid.Text = "Tampilkan"
        Me.btnTampilkanVoid.UseVisualStyleBackColor = False

        Me.dgvVoid.AllowUserToAddRows = False
        Me.dgvVoid.AllowUserToDeleteRows = False
        Me.dgvVoid.BackgroundColor = System.Drawing.Color.White
        Me.dgvVoid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVoid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVoid.Location = New System.Drawing.Point(10, 80)
        Me.dgvVoid.Name = "dgvVoid"
        Me.dgvVoid.ReadOnly = True
        Me.dgvVoid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVoid.Size = New System.Drawing.Size(1062, 512)
        Me.dgvVoid.TabIndex = 1

        Me.btnVoid.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(38, Byte), CType(38, Byte))
        Me.btnVoid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnVoid.Enabled = False
        Me.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnVoid.ForeColor = System.Drawing.Color.White
        Me.btnVoid.Location = New System.Drawing.Point(10, 592)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(1072, 50)
        Me.btnVoid.TabIndex = 2
        Me.btnVoid.Text = "Void Transaksi"
        Me.btnVoid.UseVisualStyleBackColor = False
        Me.btnVoid.Visible = False

        Me.tabNeraca.Controls.Add(Me.pnlNeracaContent)
        Me.tabNeraca.Controls.Add(Me.pnlNeracaFilter)
        Me.tabNeraca.Location = New System.Drawing.Point(4, 24)
        Me.tabNeraca.Name = "tabNeraca"
        Me.tabNeraca.Padding = New System.Windows.Forms.Padding(10)
        Me.tabNeraca.Size = New System.Drawing.Size(1092, 652)
        Me.tabNeraca.TabIndex = 3
        Me.tabNeraca.Text = "Neraca Keuangan"
        Me.tabNeraca.UseVisualStyleBackColor = True

        Me.pnlNeracaFilter.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.pnlNeracaFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNeracaFilter.Controls.Add(Me.btnPrintNeraca)
        Me.pnlNeracaFilter.Controls.Add(Me.btnExportNeraca)
        Me.pnlNeracaFilter.Controls.Add(Me.btnHitungNeraca)
        Me.pnlNeracaFilter.Controls.Add(Me.dtpNeracaSampai)
        Me.pnlNeracaFilter.Controls.Add(Me.lblNeracaSampai)
        Me.pnlNeracaFilter.Controls.Add(Me.dtpNeracaDari)
        Me.pnlNeracaFilter.Controls.Add(Me.lblNeracaDari)
        Me.pnlNeracaFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNeracaFilter.Location = New System.Drawing.Point(10, 10)
        Me.pnlNeracaFilter.Name = "pnlNeracaFilter"
        Me.pnlNeracaFilter.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlNeracaFilter.Size = New System.Drawing.Size(1072, 70)
        Me.pnlNeracaFilter.TabIndex = 0

        Me.lblNeracaDari.AutoSize = True
        Me.lblNeracaDari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNeracaDari.Location = New System.Drawing.Point(15, 15)
        Me.lblNeracaDari.Name = "lblNeracaDari"
        Me.lblNeracaDari.Size = New System.Drawing.Size(70, 15)
        Me.lblNeracaDari.TabIndex = 0
        Me.lblNeracaDari.Text = "Dari Tanggal"

        Me.dtpNeracaDari.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpNeracaDari.Location = New System.Drawing.Point(15, 33)
        Me.dtpNeracaDari.Name = "dtpNeracaDari"
        Me.dtpNeracaDari.Size = New System.Drawing.Size(120, 23)
        Me.dtpNeracaDari.TabIndex = 1

        Me.lblNeracaSampai.AutoSize = True
        Me.lblNeracaSampai.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNeracaSampai.Location = New System.Drawing.Point(150, 15)
        Me.lblNeracaSampai.Name = "lblNeracaSampai"
        Me.lblNeracaSampai.Size = New System.Drawing.Size(85, 15)
        Me.lblNeracaSampai.TabIndex = 2
        Me.lblNeracaSampai.Text = "Sampai Tanggal"

        Me.dtpNeracaSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpNeracaSampai.Location = New System.Drawing.Point(150, 33)
        Me.dtpNeracaSampai.Name = "dtpNeracaSampai"
        Me.dtpNeracaSampai.Size = New System.Drawing.Size(120, 23)
        Me.dtpNeracaSampai.TabIndex = 3

        Me.btnHitungNeraca.BackColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.btnHitungNeraca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitungNeraca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHitungNeraca.ForeColor = System.Drawing.Color.White
        Me.btnHitungNeraca.Location = New System.Drawing.Point(285, 33)
        Me.btnHitungNeraca.Name = "btnHitungNeraca"
        Me.btnHitungNeraca.Size = New System.Drawing.Size(90, 23)
        Me.btnHitungNeraca.TabIndex = 4
        Me.btnHitungNeraca.Text = "Hitung"
        Me.btnHitungNeraca.UseVisualStyleBackColor = False

        Me.btnExportNeraca.BackColor = System.Drawing.Color.FromArgb(CType(34, Byte), CType(197, Byte), CType(94, Byte))
        Me.btnExportNeraca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportNeraca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExportNeraca.ForeColor = System.Drawing.Color.White
        Me.btnExportNeraca.Location = New System.Drawing.Point(385, 33)
        Me.btnExportNeraca.Name = "btnExportNeraca"
        Me.btnExportNeraca.Size = New System.Drawing.Size(100, 23)
        Me.btnExportNeraca.TabIndex = 5
        Me.btnExportNeraca.Text = "Export Excel"
        Me.btnExportNeraca.UseVisualStyleBackColor = False

        Me.btnPrintNeraca.BackColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.btnPrintNeraca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintNeraca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintNeraca.ForeColor = System.Drawing.Color.White
        Me.btnPrintNeraca.Location = New System.Drawing.Point(495, 33)
        Me.btnPrintNeraca.Name = "btnPrintNeraca"
        Me.btnPrintNeraca.Size = New System.Drawing.Size(80, 23)
        Me.btnPrintNeraca.TabIndex = 6
        Me.btnPrintNeraca.Text = "Print"
        Me.btnPrintNeraca.UseVisualStyleBackColor = False

        Me.pnlNeracaContent.AutoScroll = True
        Me.pnlNeracaContent.BackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(244, Byte), CType(246, Byte))
        Me.pnlNeracaContent.Controls.Add(Me.pnlNeracaCard6)
        Me.pnlNeracaContent.Controls.Add(Me.pnlNeracaCard5)
        Me.pnlNeracaContent.Controls.Add(Me.pnlNeracaCard4)
        Me.pnlNeracaContent.Controls.Add(Me.pnlNeracaCard3)
        Me.pnlNeracaContent.Controls.Add(Me.pnlNeracaCard2)
        Me.pnlNeracaContent.Controls.Add(Me.pnlNeracaCard1)
        Me.pnlNeracaContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNeracaContent.Location = New System.Drawing.Point(10, 80)
        Me.pnlNeracaContent.Name = "pnlNeracaContent"
        Me.pnlNeracaContent.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlNeracaContent.Size = New System.Drawing.Size(1072, 562)
        Me.pnlNeracaContent.TabIndex = 1

        Me.pnlNeracaCard1.BackColor = System.Drawing.Color.White
        Me.pnlNeracaCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNeracaCard1.Location = New System.Drawing.Point(15, 15)
        Me.pnlNeracaCard1.Name = "pnlNeracaCard1"
        Me.pnlNeracaCard1.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlNeracaCard1.Size = New System.Drawing.Size(1042, 70)
        Me.pnlNeracaCard1.TabIndex = 0

        Dim lblCard1Title As New Label()
        lblCard1Title.AutoSize = True
        lblCard1Title.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        lblCard1Title.Location = New System.Drawing.Point(15, 10)
        lblCard1Title.Name = "lblCard1Title"
        lblCard1Title.Text = "Total Pendapatan Kotor"
        Me.pnlNeracaCard1.Controls.Add(lblCard1Title)

        Me.lblNeracaPendapatan.AutoSize = True
        Me.lblNeracaPendapatan.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblNeracaPendapatan.ForeColor = System.Drawing.Color.FromArgb(CType(34, Byte), CType(197, Byte), CType(94, Byte))
        Me.lblNeracaPendapatan.Location = New System.Drawing.Point(15, 28)
        Me.lblNeracaPendapatan.Name = "lblNeracaPendapatan"
        Me.lblNeracaPendapatan.Text = "Rp 0"
        Me.pnlNeracaCard1.Controls.Add(Me.lblNeracaPendapatan)

        Me.lblNeracaPendapatanSub.AutoSize = True
        Me.lblNeracaPendapatanSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNeracaPendapatanSub.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.lblNeracaPendapatanSub.Location = New System.Drawing.Point(200, 35)
        Me.lblNeracaPendapatanSub.Name = "lblNeracaPendapatanSub"
        Me.lblNeracaPendapatanSub.Text = "0 transaksi"
        Me.pnlNeracaCard1.Controls.Add(Me.lblNeracaPendapatanSub)

        Me.pnlNeracaCard2.BackColor = System.Drawing.Color.White
        Me.pnlNeracaCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNeracaCard2.Location = New System.Drawing.Point(15, 95)
        Me.pnlNeracaCard2.Name = "pnlNeracaCard2"
        Me.pnlNeracaCard2.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlNeracaCard2.Size = New System.Drawing.Size(1042, 70)
        Me.pnlNeracaCard2.TabIndex = 1

        Dim lblCard2Title As New Label()
        lblCard2Title.AutoSize = True
        lblCard2Title.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        lblCard2Title.Location = New System.Drawing.Point(15, 10)
        lblCard2Title.Name = "lblCard2Title"
        lblCard2Title.Text = "Harga Pokok Penjualan (HPP)"
        Me.pnlNeracaCard2.Controls.Add(lblCard2Title)

        Me.lblNeracaHPP.AutoSize = True
        Me.lblNeracaHPP.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblNeracaHPP.ForeColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(115, Byte), CType(22, Byte))
        Me.lblNeracaHPP.Location = New System.Drawing.Point(15, 28)
        Me.lblNeracaHPP.Name = "lblNeracaHPP"
        Me.lblNeracaHPP.Text = "Rp 0"
        Me.pnlNeracaCard2.Controls.Add(Me.lblNeracaHPP)

        Me.lblNeracaHPPSub.AutoSize = True
        Me.lblNeracaHPPSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNeracaHPPSub.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.lblNeracaHPPSub.Location = New System.Drawing.Point(200, 35)
        Me.lblNeracaHPPSub.Name = "lblNeracaHPPSub"
        Me.lblNeracaHPPSub.Text = "Dari transaksi aktif"
        Me.pnlNeracaCard2.Controls.Add(Me.lblNeracaHPPSub)

        Me.pnlNeracaCard3.BackColor = System.Drawing.Color.White
        Me.pnlNeracaCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNeracaCard3.Location = New System.Drawing.Point(15, 175)
        Me.pnlNeracaCard3.Name = "pnlNeracaCard3"
        Me.pnlNeracaCard3.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlNeracaCard3.Size = New System.Drawing.Size(1042, 70)
        Me.pnlNeracaCard3.TabIndex = 2

        Dim lblCard3Title As New Label()
        lblCard3Title.AutoSize = True
        lblCard3Title.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        lblCard3Title.Location = New System.Drawing.Point(15, 10)
        lblCard3Title.Name = "lblCard3Title"
        lblCard3Title.Text = "Laba Kotor"
        Me.pnlNeracaCard3.Controls.Add(lblCard3Title)

        Me.lblNeracaLabaKotor.AutoSize = True
        Me.lblNeracaLabaKotor.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblNeracaLabaKotor.ForeColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.lblNeracaLabaKotor.Location = New System.Drawing.Point(15, 28)
        Me.lblNeracaLabaKotor.Name = "lblNeracaLabaKotor"
        Me.lblNeracaLabaKotor.Text = "Rp 0"
        Me.pnlNeracaCard3.Controls.Add(Me.lblNeracaLabaKotor)

        Me.lblNeracaLabaKotorSub.AutoSize = True
        Me.lblNeracaLabaKotorSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNeracaLabaKotorSub.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.lblNeracaLabaKotorSub.Location = New System.Drawing.Point(200, 35)
        Me.lblNeracaLabaKotorSub.Name = "lblNeracaLabaKotorSub"
        Me.lblNeracaLabaKotorSub.Text = "Pendapatan - HPP"
        Me.pnlNeracaCard3.Controls.Add(Me.lblNeracaLabaKotorSub)

        Me.pnlNeracaCard4.BackColor = System.Drawing.Color.White
        Me.pnlNeracaCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNeracaCard4.Location = New System.Drawing.Point(15, 255)
        Me.pnlNeracaCard4.Name = "pnlNeracaCard4"
        Me.pnlNeracaCard4.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlNeracaCard4.Size = New System.Drawing.Size(1042, 70)
        Me.pnlNeracaCard4.TabIndex = 3

        Dim lblCard4Title As New Label()
        lblCard4Title.AutoSize = True
        lblCard4Title.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        lblCard4Title.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        lblCard4Title.Location = New System.Drawing.Point(15, 10)
        lblCard4Title.Name = "lblCard4Title"
        lblCard4Title.Text = "Total Pengeluaran Operasional"
        Me.pnlNeracaCard4.Controls.Add(lblCard4Title)

        Me.lblNeracaPengeluaran.AutoSize = True
        Me.lblNeracaPengeluaran.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblNeracaPengeluaran.ForeColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(38, Byte), CType(38, Byte))
        Me.lblNeracaPengeluaran.Location = New System.Drawing.Point(15, 28)
        Me.lblNeracaPengeluaran.Name = "lblNeracaPengeluaran"
        Me.lblNeracaPengeluaran.Text = "Rp 0"
        Me.pnlNeracaCard4.Controls.Add(Me.lblNeracaPengeluaran)

        Me.btnKelolaPengeluaran.BackColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.btnKelolaPengeluaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKelolaPengeluaran.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnKelolaPengeluaran.ForeColor = System.Drawing.Color.White
        Me.btnKelolaPengeluaran.Location = New System.Drawing.Point(200, 35)
        Me.btnKelolaPengeluaran.Name = "btnKelolaPengeluaran"
        Me.btnKelolaPengeluaran.Size = New System.Drawing.Size(120, 23)
        Me.btnKelolaPengeluaran.TabIndex = 0
        Me.btnKelolaPengeluaran.Text = "Kelola Pengeluaran"
        Me.btnKelolaPengeluaran.UseVisualStyleBackColor = False
        Me.pnlNeracaCard4.Controls.Add(Me.btnKelolaPengeluaran)

        Me.pnlNeracaCard5.BackColor = System.Drawing.Color.White
        Me.pnlNeracaCard5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNeracaCard5.Location = New System.Drawing.Point(15, 335)
        Me.pnlNeracaCard5.Name = "pnlNeracaCard5"
        Me.pnlNeracaCard5.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlNeracaCard5.Size = New System.Drawing.Size(1042, 70)
        Me.pnlNeracaCard5.TabIndex = 4

        Dim lblCard5Title As New Label()
        lblCard5Title.AutoSize = True
        lblCard5Title.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        lblCard5Title.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        lblCard5Title.Location = New System.Drawing.Point(15, 10)
        lblCard5Title.Name = "lblCard5Title"
        lblCard5Title.Text = "Laba Bersih"
        Me.pnlNeracaCard5.Controls.Add(lblCard5Title)

        Me.lblNeracaLabaBersih.AutoSize = True
        Me.lblNeracaLabaBersih.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblNeracaLabaBersih.ForeColor = System.Drawing.Color.FromArgb(CType(34, Byte), CType(197, Byte), CType(94, Byte))
        Me.lblNeracaLabaBersih.Location = New System.Drawing.Point(15, 25)
        Me.lblNeracaLabaBersih.Name = "lblNeracaLabaBersih"
        Me.lblNeracaLabaBersih.Text = "Rp 0"
        Me.pnlNeracaCard5.Controls.Add(Me.lblNeracaLabaBersih)

        Me.pnlNeracaCard6.BackColor = System.Drawing.Color.White
        Me.pnlNeracaCard6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNeracaCard6.Location = New System.Drawing.Point(15, 415)
        Me.pnlNeracaCard6.Name = "pnlNeracaCard6"
        Me.pnlNeracaCard6.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlNeracaCard6.Size = New System.Drawing.Size(1042, 70)
        Me.pnlNeracaCard6.TabIndex = 5

        Dim lblCard6Title As New Label()
        lblCard6Title.AutoSize = True
        lblCard6Title.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        lblCard6Title.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        lblCard6Title.Location = New System.Drawing.Point(15, 10)
        lblCard6Title.Name = "lblCard6Title"
        lblCard6Title.Text = "Total Void / Retur"
        Me.pnlNeracaCard6.Controls.Add(lblCard6Title)

        Me.lblNeracaVoid.AutoSize = True
        Me.lblNeracaVoid.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblNeracaVoid.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.lblNeracaVoid.Location = New System.Drawing.Point(15, 28)
        Me.lblNeracaVoid.Name = "lblNeracaVoid"
        Me.lblNeracaVoid.Text = "Rp 0"
        Me.pnlNeracaCard6.Controls.Add(Me.lblNeracaVoid)

        Me.lblNeracaVoidSub.AutoSize = True
        Me.lblNeracaVoidSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNeracaVoidSub.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.lblNeracaVoidSub.Location = New System.Drawing.Point(200, 35)
        Me.lblNeracaVoidSub.Name = "lblNeracaVoidSub"
        Me.lblNeracaVoidSub.Text = "Informasi tambahan"
        Me.pnlNeracaCard6.Controls.Add(Me.lblNeracaVoidSub)

        Me.tabLog.Controls.Add(Me.lblLogSummary)
        Me.tabLog.Controls.Add(Me.dgvLog)
        Me.tabLog.Controls.Add(Me.pnlLogFilter)
        Me.tabLog.Location = New System.Drawing.Point(4, 24)
        Me.tabLog.Name = "tabLog"
        Me.tabLog.Padding = New System.Windows.Forms.Padding(10)
        Me.tabLog.Size = New System.Drawing.Size(1092, 652)
        Me.tabLog.TabIndex = 4
        Me.tabLog.Text = "Log Aktivitas"
        Me.tabLog.UseVisualStyleBackColor = True

        Me.pnlLogFilter.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.pnlLogFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLogFilter.Controls.Add(Me.btnExportLog)
        Me.pnlLogFilter.Controls.Add(Me.btnTampilkanLog)
        Me.pnlLogFilter.Controls.Add(Me.cmbFilterAksi)
        Me.pnlLogFilter.Controls.Add(Me.lblFilterAksi)
        Me.pnlLogFilter.Controls.Add(Me.dtpLogSampai)
        Me.pnlLogFilter.Controls.Add(Me.lblLogSampai)
        Me.pnlLogFilter.Controls.Add(Me.dtpLogDari)
        Me.pnlLogFilter.Controls.Add(Me.lblLogDari)
        Me.pnlLogFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogFilter.Location = New System.Drawing.Point(10, 10)
        Me.pnlLogFilter.Name = "pnlLogFilter"
        Me.pnlLogFilter.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlLogFilter.Size = New System.Drawing.Size(1072, 70)
        Me.pnlLogFilter.TabIndex = 0

        Me.lblLogDari.AutoSize = True
        Me.lblLogDari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLogDari.Location = New System.Drawing.Point(15, 15)
        Me.lblLogDari.Name = "lblLogDari"
        Me.lblLogDari.Size = New System.Drawing.Size(70, 15)
        Me.lblLogDari.TabIndex = 0
        Me.lblLogDari.Text = "Dari Tanggal"

        Me.dtpLogDari.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpLogDari.Location = New System.Drawing.Point(15, 33)
        Me.dtpLogDari.Name = "dtpLogDari"
        Me.dtpLogDari.Size = New System.Drawing.Size(120, 23)
        Me.dtpLogDari.TabIndex = 1

        Me.lblLogSampai.AutoSize = True
        Me.lblLogSampai.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLogSampai.Location = New System.Drawing.Point(150, 15)
        Me.lblLogSampai.Name = "lblLogSampai"
        Me.lblLogSampai.Size = New System.Drawing.Size(85, 15)
        Me.lblLogSampai.TabIndex = 2
        Me.lblLogSampai.Text = "Sampai Tanggal"

        Me.dtpLogSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpLogSampai.Location = New System.Drawing.Point(150, 33)
        Me.dtpLogSampai.Name = "dtpLogSampai"
        Me.dtpLogSampai.Size = New System.Drawing.Size(120, 23)
        Me.dtpLogSampai.TabIndex = 3

        Me.lblFilterAksi.AutoSize = True
        Me.lblFilterAksi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFilterAksi.Location = New System.Drawing.Point(285, 15)
        Me.lblFilterAksi.Name = "lblFilterAksi"
        Me.lblFilterAksi.Size = New System.Drawing.Size(30, 15)
        Me.lblFilterAksi.TabIndex = 4
        Me.lblFilterAksi.Text = "Aksi"

        Me.cmbFilterAksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterAksi.FormattingEnabled = True
        Me.cmbFilterAksi.Location = New System.Drawing.Point(285, 33)
        Me.cmbFilterAksi.Name = "cmbFilterAksi"
        Me.cmbFilterAksi.Size = New System.Drawing.Size(150, 23)
        Me.cmbFilterAksi.TabIndex = 5

        Me.btnTampilkanLog.BackColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.btnTampilkanLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkanLog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTampilkanLog.ForeColor = System.Drawing.Color.White
        Me.btnTampilkanLog.Location = New System.Drawing.Point(450, 33)
        Me.btnTampilkanLog.Name = "btnTampilkanLog"
        Me.btnTampilkanLog.Size = New System.Drawing.Size(90, 23)
        Me.btnTampilkanLog.TabIndex = 6
        Me.btnTampilkanLog.Text = "Tampilkan"
        Me.btnTampilkanLog.UseVisualStyleBackColor = False

        Me.btnExportLog.BackColor = System.Drawing.Color.FromArgb(CType(34, Byte), CType(197, Byte), CType(94, Byte))
        Me.btnExportLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportLog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExportLog.ForeColor = System.Drawing.Color.White
        Me.btnExportLog.Location = New System.Drawing.Point(550, 33)
        Me.btnExportLog.Name = "btnExportLog"
        Me.btnExportLog.Size = New System.Drawing.Size(100, 23)
        Me.btnExportLog.TabIndex = 7
        Me.btnExportLog.Text = "Export Excel"
        Me.btnExportLog.UseVisualStyleBackColor = False

        Me.dgvLog.AllowUserToAddRows = False
        Me.dgvLog.AllowUserToDeleteRows = False
        Me.dgvLog.BackgroundColor = System.Drawing.Color.White
        Me.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLog.Location = New System.Drawing.Point(10, 80)
        Me.dgvLog.Name = "dgvLog"
        Me.dgvLog.ReadOnly = True
        Me.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLog.Size = New System.Drawing.Size(1072, 542)
        Me.dgvLog.TabIndex = 1

        Me.lblLogSummary.BackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(244, Byte), CType(246, Byte))
        Me.lblLogSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLogSummary.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLogSummary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLogSummary.Location = New System.Drawing.Point(10, 622)
        Me.lblLogSummary.Name = "lblLogSummary"
        Me.lblLogSummary.Padding = New System.Windows.Forms.Padding(10)
        Me.lblLogSummary.Size = New System.Drawing.Size(1072, 30)
        Me.lblLogSummary.TabIndex = 2
        Me.lblLogSummary.Text = "Total Log: 0"

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 680)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "FrmLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KasirIn — Laporan"
        Me.tabControl.ResumeLayout(False)
        Me.tabPenjualan.ResumeLayout(False)
        Me.pnlDetail.ResumeLayout(False)
        Me.pnlDetail.PerformLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSummary.ResumeLayout(False)
        Me.pnlSummary.PerformLayout()
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.tabStok.ResumeLayout(False)
        CType(Me.dgvStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilterStok.ResumeLayout(False)
        Me.pnlFilterStok.PerformLayout()
        Me.tabVoid.ResumeLayout(False)
        CType(Me.dgvVoid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilterVoid.ResumeLayout(False)
        Me.pnlFilterVoid.PerformLayout()
        Me.tabNeraca.ResumeLayout(False)
        Me.pnlNeracaFilter.ResumeLayout(False)
        Me.pnlNeracaFilter.PerformLayout()
        Me.pnlNeracaContent.ResumeLayout(False)
        Me.pnlNeracaContent.PerformLayout()
        Me.tabLog.ResumeLayout(False)
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogFilter.ResumeLayout(False)
        Me.pnlLogFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabPenjualan As TabPage
    Friend WithEvents tabStok As TabPage
    Friend WithEvents tabVoid As TabPage
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents lblDari As Label
    Friend WithEvents dtpDari As DateTimePicker
    Friend WithEvents lblSampai As Label
    Friend WithEvents dtpSampai As DateTimePicker
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblTotalTransaksi As Label
    Friend WithEvents lblTotalPendapatan As Label
    Friend WithEvents lblTotalDiskon As Label
    Friend WithEvents lblRataRata As Label
    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents pnlDetail As Panel
    Friend WithEvents lblDetail As Label
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents pnlFilterStok As Panel
    Friend WithEvents lblKategori As Label
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents chkStokMenipis As CheckBox
    Friend WithEvents btnTampilkanStok As Button
    Friend WithEvents btnExportStok As Button
    Friend WithEvents dgvStok As DataGridView
    Friend WithEvents lblSummaryStok As Label
    Friend WithEvents pnlFilterVoid As Panel
    Friend WithEvents lblVoidDari As Label
    Friend WithEvents dtpVoidDari As DateTimePicker
    Friend WithEvents lblVoidSampai As Label
    Friend WithEvents dtpVoidSampai As DateTimePicker
    Friend WithEvents btnTampilkanVoid As Button
    Friend WithEvents dgvVoid As DataGridView
    Friend WithEvents btnVoid As Button
    Friend WithEvents tabNeraca As TabPage
    Friend WithEvents pnlNeracaFilter As Panel
    Friend WithEvents btnPrintNeraca As Button
    Friend WithEvents btnExportNeraca As Button
    Friend WithEvents btnHitungNeraca As Button
    Friend WithEvents dtpNeracaSampai As DateTimePicker
    Friend WithEvents lblNeracaSampai As Label
    Friend WithEvents dtpNeracaDari As DateTimePicker
    Friend WithEvents lblNeracaDari As Label
    Friend WithEvents pnlNeracaContent As Panel
    Friend WithEvents pnlNeracaCard1 As Panel
    Friend WithEvents lblNeracaPendapatan As Label
    Friend WithEvents lblNeracaPendapatanSub As Label
    Friend WithEvents pnlNeracaCard2 As Panel
    Friend WithEvents lblNeracaHPP As Label
    Friend WithEvents lblNeracaHPPSub As Label
    Friend WithEvents pnlNeracaCard3 As Panel
    Friend WithEvents lblNeracaLabaKotor As Label
    Friend WithEvents lblNeracaLabaKotorSub As Label
    Friend WithEvents pnlNeracaCard4 As Panel
    Friend WithEvents lblNeracaPengeluaran As Label
    Friend WithEvents btnKelolaPengeluaran As Button
    Friend WithEvents pnlNeracaCard5 As Panel
    Friend WithEvents lblNeracaLabaBersih As Label
    Friend WithEvents pnlNeracaCard6 As Panel
    Friend WithEvents lblNeracaVoid As Label
    Friend WithEvents lblNeracaVoidSub As Label
    Friend WithEvents tabLog As TabPage
    Friend WithEvents pnlLogFilter As Panel
    Friend WithEvents btnExportLog As Button
    Friend WithEvents btnTampilkanLog As Button
    Friend WithEvents cmbFilterAksi As ComboBox
    Friend WithEvents lblFilterAksi As Label
    Friend WithEvents dtpLogSampai As DateTimePicker
    Friend WithEvents lblLogSampai As Label
    Friend WithEvents dtpLogDari As DateTimePicker
    Friend WithEvents lblLogDari As Label
    Friend WithEvents dgvLog As DataGridView
    Friend WithEvents lblLogSummary As Label

End Class
