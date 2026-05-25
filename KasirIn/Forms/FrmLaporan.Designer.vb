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
        Me.SuspendLayout()

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

End Class
