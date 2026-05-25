<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnKategori = New System.Windows.Forms.Button()
        Me.btnProduk = New System.Windows.Forms.Button()
        Me.btnKasir = New System.Windows.Forms.Button()
        Me.btnBeranda = New System.Windows.Forms.Button()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlBeranda = New System.Windows.Forms.Panel()
        Me.pnlBottomSection = New System.Windows.Forms.Panel()
        Me.pnlStokMenipis = New System.Windows.Forms.Panel()
        Me.dgvStokMenipis = New System.Windows.Forms.DataGridView()
        Me.lblStokMenipis = New System.Windows.Forms.Label()
        Me.pnlTransaksiTerakhir = New System.Windows.Forms.Panel()
        Me.dgvTransaksiTerakhir = New System.Windows.Forms.DataGridView()
        Me.lblTransaksiTerakhir = New System.Windows.Forms.Label()
        Me.pnlCards = New System.Windows.Forms.Panel()
        Me.cardStokMenipis = New System.Windows.Forms.Panel()
        Me.lblStokMenipis2 = New System.Windows.Forms.Label()
        Me.lblStokMenipis1 = New System.Windows.Forms.Label()
        Me.cardProdukAktif = New System.Windows.Forms.Panel()
        Me.lblProdukAktif2 = New System.Windows.Forms.Label()
        Me.lblProdukAktif1 = New System.Windows.Forms.Label()
        Me.cardTransaksiHariIni = New System.Windows.Forms.Panel()
        Me.lblTransaksiHariIni2 = New System.Windows.Forms.Label()
        Me.lblTransaksiHariIni1 = New System.Windows.Forms.Label()
        Me.cardPenjualanHariIni = New System.Windows.Forms.Panel()
        Me.lblPenjualanHariIni2 = New System.Windows.Forms.Label()
        Me.lblPenjualanHariIni1 = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlBeranda.SuspendLayout()
        Me.pnlBottomSection.SuspendLayout()
        Me.pnlStokMenipis.SuspendLayout()
        CType(Me.dgvStokMenipis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTransaksiTerakhir.SuspendLayout()
        CType(Me.dgvTransaksiTerakhir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCards.SuspendLayout()
        Me.cardStokMenipis.SuspendLayout()
        Me.cardProdukAktif.SuspendLayout()
        Me.cardTransaksiHariIni.SuspendLayout()
        Me.cardPenjualanHariIni.SuspendLayout()
        Me.SuspendLayout()

        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(30, Byte), CType(58, Byte), CType(95, Byte))
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnLaporan)
        Me.pnlSidebar.Controls.Add(Me.btnSupplier)
        Me.pnlSidebar.Controls.Add(Me.btnKategori)
        Me.pnlSidebar.Controls.Add(Me.btnProduk)
        Me.pnlSidebar.Controls.Add(Me.btnKasir)
        Me.pnlSidebar.Controls.Add(Me.btnBeranda)
        Me.pnlSidebar.Controls.Add(Me.lblAppName)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 720)
        Me.pnlSidebar.TabIndex = 0

        Me.lblAppName.AutoSize = True
        Me.lblAppName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.ForeColor = System.Drawing.Color.White
        Me.lblAppName.Location = New System.Drawing.Point(15, 20)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(80, 25)
        Me.lblAppName.TabIndex = 0
        Me.lblAppName.Text = "KasirIn"

        Me.btnBeranda.BackColor = System.Drawing.Color.FromArgb(CType(30, Byte), CType(58, Byte), CType(95, Byte))
        Me.btnBeranda.FlatAppearance.BorderSize = 0
        Me.btnBeranda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeranda.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeranda.ForeColor = System.Drawing.Color.White
        Me.btnBeranda.Location = New System.Drawing.Point(0, 70)
        Me.btnBeranda.Name = "btnBeranda"
        Me.btnBeranda.Size = New System.Drawing.Size(220, 45)
        Me.btnBeranda.TabIndex = 1
        Me.btnBeranda.Text = "📊 Beranda"
        Me.btnBeranda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBeranda.UseVisualStyleBackColor = False

        Me.btnKasir.BackColor = System.Drawing.Color.FromArgb(CType(30, Byte), CType(58, Byte), CType(95, Byte))
        Me.btnKasir.FlatAppearance.BorderSize = 0
        Me.btnKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKasir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKasir.ForeColor = System.Drawing.Color.White
        Me.btnKasir.Location = New System.Drawing.Point(0, 115)
        Me.btnKasir.Name = "btnKasir"
        Me.btnKasir.Size = New System.Drawing.Size(220, 45)
        Me.btnKasir.TabIndex = 2
        Me.btnKasir.Text = "💳 Kasir"
        Me.btnKasir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKasir.UseVisualStyleBackColor = False

        Me.btnProduk.BackColor = System.Drawing.Color.FromArgb(CType(30, Byte), CType(58, Byte), CType(95, Byte))
        Me.btnProduk.FlatAppearance.BorderSize = 0
        Me.btnProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduk.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduk.ForeColor = System.Drawing.Color.White
        Me.btnProduk.Location = New System.Drawing.Point(0, 160)
        Me.btnProduk.Name = "btnProduk"
        Me.btnProduk.Size = New System.Drawing.Size(220, 45)
        Me.btnProduk.TabIndex = 3
        Me.btnProduk.Text = "📦 Produk"
        Me.btnProduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduk.UseVisualStyleBackColor = False

        Me.btnKategori.BackColor = System.Drawing.Color.FromArgb(CType(30, Byte), CType(58, Byte), CType(95, Byte))
        Me.btnKategori.FlatAppearance.BorderSize = 0
        Me.btnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKategori.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKategori.ForeColor = System.Drawing.Color.White
        Me.btnKategori.Location = New System.Drawing.Point(0, 205)
        Me.btnKategori.Name = "btnKategori"
        Me.btnKategori.Size = New System.Drawing.Size(220, 45)
        Me.btnKategori.TabIndex = 4
        Me.btnKategori.Text = "🏷️ Kategori"
        Me.btnKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKategori.UseVisualStyleBackColor = False

        Me.btnSupplier.BackColor = System.Drawing.Color.FromArgb(CType(30, Byte), CType(58, Byte), CType(95, Byte))
        Me.btnSupplier.FlatAppearance.BorderSize = 0
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.ForeColor = System.Drawing.Color.White
        Me.btnSupplier.Location = New System.Drawing.Point(0, 250)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(220, 45)
        Me.btnSupplier.TabIndex = 5
        Me.btnSupplier.Text = "🚚 Supplier"
        Me.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupplier.UseVisualStyleBackColor = False

        Me.btnLaporan.BackColor = System.Drawing.Color.FromArgb(CType(30, Byte), CType(58, Byte), CType(95, Byte))
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.Color.White
        Me.btnLaporan.Location = New System.Drawing.Point(0, 295)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(220, 45)
        Me.btnLaporan.TabIndex = 6
        Me.btnLaporan.Text = "📄 Laporan"
        Me.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.UseVisualStyleBackColor = False

        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(30, Byte), CType(58, Byte), CType(95, Byte))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 675)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(220, 45)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "🚪 Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False

        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Controls.Add(Me.lblUserInfo)
        Me.pnlHeader.Controls.Add(Me.lblPageTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(220, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1060, 60)
        Me.pnlHeader.TabIndex = 1

        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(31, Byte), CType(41, Byte), CType(55, Byte))
        Me.lblPageTitle.Location = New System.Drawing.Point(20, 18)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(80, 25)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Beranda"

        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.lblUserInfo.Location = New System.Drawing.Point(800, 20)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(100, 15)
        Me.lblUserInfo.TabIndex = 1
        Me.lblUserInfo.Text = "Halo, Administrator"

        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(244, Byte), CType(246, Byte))
        Me.pnlContent.Controls.Add(Me.pnlBeranda)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(220, 60)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1060, 660)
        Me.pnlContent.TabIndex = 2

        Me.pnlBeranda.Controls.Add(Me.pnlBottomSection)
        Me.pnlBeranda.Controls.Add(Me.pnlCards)
        Me.pnlBeranda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBeranda.Location = New System.Drawing.Point(0, 0)
        Me.pnlBeranda.Name = "pnlBeranda"
        Me.pnlBeranda.Size = New System.Drawing.Size(1060, 660)
        Me.pnlBeranda.TabIndex = 0

        Me.pnlCards.Controls.Add(Me.cardStokMenipis)
        Me.pnlCards.Controls.Add(Me.cardProdukAktif)
        Me.pnlCards.Controls.Add(Me.cardTransaksiHariIni)
        Me.pnlCards.Controls.Add(Me.cardPenjualanHariIni)
        Me.pnlCards.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCards.Location = New System.Drawing.Point(0, 0)
        Me.pnlCards.Name = "pnlCards"
        Me.pnlCards.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlCards.Size = New System.Drawing.Size(1060, 150)
        Me.pnlCards.TabIndex = 0

        Me.cardPenjualanHariIni.BackColor = System.Drawing.Color.White
        Me.cardPenjualanHariIni.Controls.Add(Me.lblPenjualanHariIni2)
        Me.cardPenjualanHariIni.Controls.Add(Me.lblPenjualanHariIni1)
        Me.cardPenjualanHariIni.Location = New System.Drawing.Point(15, 15)
        Me.cardPenjualanHariIni.Name = "cardPenjualanHariIni"
        Me.cardPenjualanHariIni.Size = New System.Drawing.Size(240, 120)
        Me.cardPenjualanHariIni.TabIndex = 0

        Me.lblPenjualanHariIni1.AutoSize = True
        Me.lblPenjualanHariIni1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenjualanHariIni1.ForeColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.lblPenjualanHariIni1.Location = New System.Drawing.Point(15, 15)
        Me.lblPenjualanHariIni1.Name = "lblPenjualanHariIni1"
        Me.lblPenjualanHariIni1.Size = New System.Drawing.Size(60, 45)
        Me.lblPenjualanHariIni1.TabIndex = 0
        Me.lblPenjualanHariIni1.Text = "Rp 0"

        Me.lblPenjualanHariIni2.AutoSize = True
        Me.lblPenjualanHariIni2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenjualanHariIni2.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.lblPenjualanHariIni2.Location = New System.Drawing.Point(15, 65)
        Me.lblPenjualanHariIni2.Name = "lblPenjualanHariIni2"
        Me.lblPenjualanHariIni2.Size = New System.Drawing.Size(130, 15)
        Me.lblPenjualanHariIni2.TabIndex = 1
        Me.lblPenjualanHariIni2.Text = "Total Penjualan Hari Ini"

        Me.cardTransaksiHariIni.BackColor = System.Drawing.Color.White
        Me.cardTransaksiHariIni.Controls.Add(Me.lblTransaksiHariIni2)
        Me.cardTransaksiHariIni.Controls.Add(Me.lblTransaksiHariIni1)
        Me.cardTransaksiHariIni.Location = New System.Drawing.Point(275, 15)
        Me.cardTransaksiHariIni.Name = "cardTransaksiHariIni"
        Me.cardTransaksiHariIni.Size = New System.Drawing.Size(240, 120)
        Me.cardTransaksiHariIni.TabIndex = 1

        Me.lblTransaksiHariIni1.AutoSize = True
        Me.lblTransaksiHariIni1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksiHariIni1.ForeColor = System.Drawing.Color.FromArgb(CType(34, Byte), CType(197, Byte), CType(94, Byte))
        Me.lblTransaksiHariIni1.Location = New System.Drawing.Point(15, 15)
        Me.lblTransaksiHariIni1.Name = "lblTransaksiHariIni1"
        Me.lblTransaksiHariIni1.Size = New System.Drawing.Size(30, 45)
        Me.lblTransaksiHariIni1.TabIndex = 0
        Me.lblTransaksiHariIni1.Text = "0"

        Me.lblTransaksiHariIni2.AutoSize = True
        Me.lblTransaksiHariIni2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksiHariIni2.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.lblTransaksiHariIni2.Location = New System.Drawing.Point(15, 65)
        Me.lblTransaksiHariIni2.Name = "lblTransaksiHariIni2"
        Me.lblTransaksiHariIni2.Size = New System.Drawing.Size(140, 15)
        Me.lblTransaksiHariIni2.TabIndex = 1
        Me.lblTransaksiHariIni2.Text = "Jumlah Transaksi Hari Ini"

        Me.cardProdukAktif.BackColor = System.Drawing.Color.White
        Me.cardProdukAktif.Controls.Add(Me.lblProdukAktif2)
        Me.cardProdukAktif.Controls.Add(Me.lblProdukAktif1)
        Me.cardProdukAktif.Location = New System.Drawing.Point(535, 15)
        Me.cardProdukAktif.Name = "cardProdukAktif"
        Me.cardProdukAktif.Size = New System.Drawing.Size(240, 120)
        Me.cardProdukAktif.TabIndex = 2

        Me.lblProdukAktif1.AutoSize = True
        Me.lblProdukAktif1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdukAktif1.ForeColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(85, Byte), CType(247, Byte))
        Me.lblProdukAktif1.Location = New System.Drawing.Point(15, 15)
        Me.lblProdukAktif1.Name = "lblProdukAktif1"
        Me.lblProdukAktif1.Size = New System.Drawing.Size(30, 45)
        Me.lblProdukAktif1.TabIndex = 0
        Me.lblProdukAktif1.Text = "0"

        Me.lblProdukAktif2.AutoSize = True
        Me.lblProdukAktif2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdukAktif2.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.lblProdukAktif2.Location = New System.Drawing.Point(15, 65)
        Me.lblProdukAktif2.Name = "lblProdukAktif2"
        Me.lblProdukAktif2.Size = New System.Drawing.Size(110, 15)
        Me.lblProdukAktif2.TabIndex = 1
        Me.lblProdukAktif2.Text = "Total Produk Aktif"

        Me.cardStokMenipis.BackColor = System.Drawing.Color.White
        Me.cardStokMenipis.Controls.Add(Me.lblStokMenipis2)
        Me.cardStokMenipis.Controls.Add(Me.lblStokMenipis1)
        Me.cardStokMenipis.Location = New System.Drawing.Point(795, 15)
        Me.cardStokMenipis.Name = "cardStokMenipis"
        Me.cardStokMenipis.Size = New System.Drawing.Size(240, 120)
        Me.cardStokMenipis.TabIndex = 3

        Me.lblStokMenipis1.AutoSize = True
        Me.lblStokMenipis1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokMenipis1.ForeColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(38, Byte), CType(38, Byte))
        Me.lblStokMenipis1.Location = New System.Drawing.Point(15, 15)
        Me.lblStokMenipis1.Name = "lblStokMenipis1"
        Me.lblStokMenipis1.Size = New System.Drawing.Size(30, 45)
        Me.lblStokMenipis1.TabIndex = 0
        Me.lblStokMenipis1.Text = "0"

        Me.lblStokMenipis2.AutoSize = True
        Me.lblStokMenipis2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokMenipis2.ForeColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.lblStokMenipis2.Location = New System.Drawing.Point(15, 65)
        Me.lblStokMenipis2.Name = "lblStokMenipis2"
        Me.lblStokMenipis2.Size = New System.Drawing.Size(110, 15)
        Me.lblStokMenipis2.TabIndex = 1
        Me.lblStokMenipis2.Text = "Stok Menipis"

        Me.pnlBottomSection.Controls.Add(Me.pnlStokMenipis)
        Me.pnlBottomSection.Controls.Add(Me.pnlTransaksiTerakhir)
        Me.pnlBottomSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBottomSection.Location = New System.Drawing.Point(0, 150)
        Me.pnlBottomSection.Name = "pnlBottomSection"
        Me.pnlBottomSection.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlBottomSection.Size = New System.Drawing.Size(1060, 510)
        Me.pnlBottomSection.TabIndex = 1

        Me.pnlTransaksiTerakhir.BackColor = System.Drawing.Color.White
        Me.pnlTransaksiTerakhir.Controls.Add(Me.dgvTransaksiTerakhir)
        Me.pnlTransaksiTerakhir.Controls.Add(Me.lblTransaksiTerakhir)
        Me.pnlTransaksiTerakhir.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTransaksiTerakhir.Location = New System.Drawing.Point(15, 15)
        Me.pnlTransaksiTerakhir.Name = "pnlTransaksiTerakhir"
        Me.pnlTransaksiTerakhir.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlTransaksiTerakhir.Size = New System.Drawing.Size(515, 480)
        Me.pnlTransaksiTerakhir.TabIndex = 0

        Me.lblTransaksiTerakhir.AutoSize = True
        Me.lblTransaksiTerakhir.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksiTerakhir.ForeColor = System.Drawing.Color.FromArgb(CType(31, Byte), CType(41, Byte), CType(55, Byte))
        Me.lblTransaksiTerakhir.Location = New System.Drawing.Point(15, 15)
        Me.lblTransaksiTerakhir.Name = "lblTransaksiTerakhir"
        Me.lblTransaksiTerakhir.Size = New System.Drawing.Size(130, 20)
        Me.lblTransaksiTerakhir.TabIndex = 0
        Me.lblTransaksiTerakhir.Text = "Transaksi Terakhir"

        Me.dgvTransaksiTerakhir.AllowUserToAddRows = False
        Me.dgvTransaksiTerakhir.AllowUserToDeleteRows = False
        Me.dgvTransaksiTerakhir.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransaksiTerakhir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksiTerakhir.Location = New System.Drawing.Point(15, 40)
        Me.dgvTransaksiTerakhir.Name = "dgvTransaksiTerakhir"
        Me.dgvTransaksiTerakhir.ReadOnly = True
        Me.dgvTransaksiTerakhir.Size = New System.Drawing.Size(485, 425)
        Me.dgvTransaksiTerakhir.TabIndex = 1

        Me.pnlStokMenipis.BackColor = System.Drawing.Color.White
        Me.pnlStokMenipis.Controls.Add(Me.dgvStokMenipis)
        Me.pnlStokMenipis.Controls.Add(Me.lblStokMenipis)
        Me.pnlStokMenipis.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlStokMenipis.Location = New System.Drawing.Point(530, 15)
        Me.pnlStokMenipis.Name = "pnlStokMenipis"
        Me.pnlStokMenipis.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlStokMenipis.Size = New System.Drawing.Size(515, 480)
        Me.pnlStokMenipis.TabIndex = 1

        Me.lblStokMenipis.AutoSize = True
        Me.lblStokMenipis.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokMenipis.ForeColor = System.Drawing.Color.FromArgb(CType(31, Byte), CType(41, Byte), CType(55, Byte))
        Me.lblStokMenipis.Location = New System.Drawing.Point(15, 15)
        Me.lblStokMenipis.Name = "lblStokMenipis"
        Me.lblStokMenipis.Size = New System.Drawing.Size(130, 20)
        Me.lblStokMenipis.TabIndex = 0
        Me.lblStokMenipis.Text = "Produk Stok Menipis"

        Me.dgvStokMenipis.AllowUserToAddRows = False
        Me.dgvStokMenipis.AllowUserToDeleteRows = False
        Me.dgvStokMenipis.BackgroundColor = System.Drawing.Color.White
        Me.dgvStokMenipis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStokMenipis.Location = New System.Drawing.Point(15, 40)
        Me.dgvStokMenipis.Name = "dgvStokMenipis"
        Me.dgvStokMenipis.ReadOnly = True
        Me.dgvStokMenipis.Size = New System.Drawing.Size(485, 425)
        Me.dgvStokMenipis.TabIndex = 1

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSidebar)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KasirIn - Dashboard"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlBeranda.ResumeLayout(False)
        Me.pnlBottomSection.ResumeLayout(False)
        Me.pnlStokMenipis.ResumeLayout(False)
        Me.pnlStokMenipis.PerformLayout()
        CType(Me.dgvStokMenipis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTransaksiTerakhir.ResumeLayout(False)
        Me.pnlTransaksiTerakhir.PerformLayout()
        CType(Me.dgvTransaksiTerakhir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCards.ResumeLayout(False)
        Me.cardStokMenipis.ResumeLayout(False)
        Me.cardStokMenipis.PerformLayout()
        Me.cardProdukAktif.ResumeLayout(False)
        Me.cardProdukAktif.PerformLayout()
        Me.cardTransaksiHariIni.ResumeLayout(False)
        Me.cardTransaksiHariIni.PerformLayout()
        Me.cardPenjualanHariIni.ResumeLayout(False)
        Me.cardPenjualanHariIni.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblAppName As Label
    Friend WithEvents btnBeranda As Button
    Friend WithEvents btnKasir As Button
    Friend WithEvents btnProduk As Button
    Friend WithEvents btnKategori As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents lblUserInfo As Label
    Friend WithEvents pnlBeranda As Panel
    Friend WithEvents pnlCards As Panel
    Friend WithEvents cardPenjualanHariIni As Panel
    Friend WithEvents lblPenjualanHariIni1 As Label
    Friend WithEvents lblPenjualanHariIni2 As Label
    Friend WithEvents cardTransaksiHariIni As Panel
    Friend WithEvents lblTransaksiHariIni1 As Label
    Friend WithEvents lblTransaksiHariIni2 As Label
    Friend WithEvents cardProdukAktif As Panel
    Friend WithEvents lblProdukAktif1 As Label
    Friend WithEvents lblProdukAktif2 As Label
    Friend WithEvents cardStokMenipis As Panel
    Friend WithEvents lblStokMenipis1 As Label
    Friend WithEvents lblStokMenipis2 As Label
    Friend WithEvents pnlBottomSection As Panel
    Friend WithEvents pnlTransaksiTerakhir As Panel
    Friend WithEvents lblTransaksiTerakhir As Label
    Friend WithEvents dgvTransaksiTerakhir As DataGridView
    Friend WithEvents pnlStokMenipis As Panel
    Friend WithEvents lblStokMenipis As Label
    Friend WithEvents dgvStokMenipis As DataGridView

End Class
