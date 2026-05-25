<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKasir
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
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblItemCount = New System.Windows.Forms.Label()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.pnlProduk = New System.Windows.Forms.Panel()
        Me.dgvProduk = New System.Windows.Forms.DataGridView()
        Me.lblProduk = New System.Windows.Forms.Label()
        Me.pnlSearchBar = New System.Windows.Forms.Panel()
        Me.cmbHasilCari = New System.Windows.Forms.ComboBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.pnlPayment = New System.Windows.Forms.Panel()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.lblBayar = New System.Windows.Forms.Label()
        Me.lblTotalBayar = New System.Windows.Forms.Label()
        Me.txtDiskonTotal = New System.Windows.Forms.TextBox()
        Me.lblDiskonTotal = New System.Windows.Forms.Label()
        Me.lblTotalHarga = New System.Windows.Forms.Label()
        Me.pnlTransInfo = New System.Windows.Forms.Panel()
        Me.lblKasir = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblNoTransaksi = New System.Windows.Forms.Label()
        Me.tmrWaktu = New System.Windows.Forms.Timer(Me.components)
        Me.pnlLeft.SuspendLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProduk.SuspendLayout()
        Me.pnlSearchBar.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlPayment.SuspendLayout()
        Me.pnlTransInfo.SuspendLayout()
        Me.SuspendLayout()

        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.Controls.Add(Me.lblItemCount)
        Me.pnlLeft.Controls.Add(Me.dgvKeranjang)
        Me.pnlLeft.Controls.Add(Me.pnlProduk)
        Me.pnlLeft.Controls.Add(Me.pnlSearchBar)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(720, 700)
        Me.pnlLeft.TabIndex = 0

        Me.pnlSearchBar.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.pnlSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearchBar.Controls.Add(Me.cmbHasilCari)
        Me.pnlSearchBar.Controls.Add(Me.btnCari)
        Me.pnlSearchBar.Controls.Add(Me.txtBarcode)
        Me.pnlSearchBar.Controls.Add(Me.lblSearch)
        Me.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearchBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearchBar.Name = "pnlSearchBar"
        Me.pnlSearchBar.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlSearchBar.Size = New System.Drawing.Size(720, 100)
        Me.pnlSearchBar.TabIndex = 0

        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(15, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(130, 15)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Scan / Cari Produk"

        Me.txtBarcode.BackColor = System.Drawing.Color.White
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(15, 33)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.PlaceholderText = "Scan barcode atau ketik nama produk..."
        Me.txtBarcode.Size = New System.Drawing.Size(550, 25)
        Me.txtBarcode.TabIndex = 1

        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(575, 33)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(130, 25)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False

        Me.cmbHasilCari.BackColor = System.Drawing.Color.White
        Me.cmbHasilCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHasilCari.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHasilCari.FormattingEnabled = True
        Me.cmbHasilCari.Location = New System.Drawing.Point(15, 65)
        Me.cmbHasilCari.Name = "cmbHasilCari"
        Me.cmbHasilCari.Size = New System.Drawing.Size(690, 25)
        Me.cmbHasilCari.TabIndex = 3
        Me.cmbHasilCari.Visible = False

        Me.pnlProduk.BackColor = System.Drawing.Color.White
        Me.pnlProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProduk.Controls.Add(Me.dgvProduk)
        Me.pnlProduk.Controls.Add(Me.lblProduk)
        Me.pnlProduk.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlProduk.Location = New System.Drawing.Point(0, 100)
        Me.pnlProduk.Name = "pnlProduk"
        Me.pnlProduk.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlProduk.Size = New System.Drawing.Size(720, 200)
        Me.pnlProduk.TabIndex = 3

        Me.lblProduk.AutoSize = True
        Me.lblProduk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduk.Location = New System.Drawing.Point(15, 15)
        Me.lblProduk.Name = "lblProduk"
        Me.lblProduk.Size = New System.Drawing.Size(100, 15)
        Me.lblProduk.TabIndex = 0
        Me.lblProduk.Text = "Daftar Produk"

        Me.dgvProduk.AllowUserToAddRows = False
        Me.dgvProduk.AllowUserToDeleteRows = False
        Me.dgvProduk.BackgroundColor = System.Drawing.Color.White
        Me.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProduk.Location = New System.Drawing.Point(15, 35)
        Me.dgvProduk.Name = "dgvProduk"
        Me.dgvProduk.ReadOnly = True
        Me.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduk.Size = New System.Drawing.Size(690, 150)
        Me.dgvProduk.TabIndex = 1

        Me.dgvKeranjang.AllowUserToAddRows = False
        Me.dgvKeranjang.AllowUserToDeleteRows = False
        Me.dgvKeranjang.BackgroundColor = System.Drawing.Color.White
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKeranjang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvKeranjang.Location = New System.Drawing.Point(0, 300)
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKeranjang.Size = New System.Drawing.Size(720, 370)
        Me.dgvKeranjang.TabIndex = 1

        Me.lblItemCount.BackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(244, Byte), CType(246, Byte))
        Me.lblItemCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemCount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblItemCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCount.Location = New System.Drawing.Point(0, 670)
        Me.lblItemCount.Name = "lblItemCount"
        Me.lblItemCount.Padding = New System.Windows.Forms.Padding(15)
        Me.lblItemCount.Size = New System.Drawing.Size(720, 30)
        Me.lblItemCount.TabIndex = 2
        Me.lblItemCount.Text = "Total Item: 0 produk"

        Me.pnlRight.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.pnlRight.Controls.Add(Me.btnBaru)
        Me.pnlRight.Controls.Add(Me.btnBatal)
        Me.pnlRight.Controls.Add(Me.btnProses)
        Me.pnlRight.Controls.Add(Me.pnlPayment)
        Me.pnlRight.Controls.Add(Me.pnlTransInfo)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(720, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlRight.Size = New System.Drawing.Size(480, 700)
        Me.pnlRight.TabIndex = 1

        Me.pnlTransInfo.BackColor = System.Drawing.Color.White
        Me.pnlTransInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTransInfo.Controls.Add(Me.lblKasir)
        Me.pnlTransInfo.Controls.Add(Me.lblWaktu)
        Me.pnlTransInfo.Controls.Add(Me.lblTanggal)
        Me.pnlTransInfo.Controls.Add(Me.lblNoTransaksi)
        Me.pnlTransInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTransInfo.Location = New System.Drawing.Point(15, 15)
        Me.pnlTransInfo.Name = "pnlTransInfo"
        Me.pnlTransInfo.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlTransInfo.Size = New System.Drawing.Size(450, 120)
        Me.pnlTransInfo.TabIndex = 0

        Me.lblNoTransaksi.AutoSize = True
        Me.lblNoTransaksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoTransaksi.Location = New System.Drawing.Point(15, 15)
        Me.lblNoTransaksi.Name = "lblNoTransaksi"
        Me.lblNoTransaksi.Size = New System.Drawing.Size(150, 15)
        Me.lblNoTransaksi.TabIndex = 0
        Me.lblNoTransaksi.Text = "No. Transaksi: TRX-000000-0000"

        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(15, 35)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(100, 15)
        Me.lblTanggal.TabIndex = 1
        Me.lblTanggal.Text = "Tanggal: 23/05/2026"

        Me.lblWaktu.AutoSize = True
        Me.lblWaktu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaktu.Location = New System.Drawing.Point(15, 55)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(80, 15)
        Me.lblWaktu.TabIndex = 2
        Me.lblWaktu.Text = "Waktu: 00:00:00"

        Me.lblKasir.AutoSize = True
        Me.lblKasir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKasir.Location = New System.Drawing.Point(15, 75)
        Me.lblKasir.Name = "lblKasir"
        Me.lblKasir.Size = New System.Drawing.Size(100, 15)
        Me.lblKasir.TabIndex = 3
        Me.lblKasir.Text = "Kasir: Administrator"

        Me.pnlPayment.BackColor = System.Drawing.Color.White
        Me.pnlPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPayment.Controls.Add(Me.lblKembalian)
        Me.pnlPayment.Controls.Add(Me.txtBayar)
        Me.pnlPayment.Controls.Add(Me.lblBayar)
        Me.pnlPayment.Controls.Add(Me.lblTotalBayar)
        Me.pnlPayment.Controls.Add(Me.txtDiskonTotal)
        Me.pnlPayment.Controls.Add(Me.lblDiskonTotal)
        Me.pnlPayment.Controls.Add(Me.lblTotalHarga)
        Me.pnlPayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPayment.Location = New System.Drawing.Point(15, 135)
        Me.pnlPayment.Name = "pnlPayment"
        Me.pnlPayment.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlPayment.Size = New System.Drawing.Size(450, 280)
        Me.pnlPayment.TabIndex = 1

        Me.lblTotalHarga.AutoSize = True
        Me.lblTotalHarga.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHarga.Location = New System.Drawing.Point(15, 15)
        Me.lblTotalHarga.Name = "lblTotalHarga"
        Me.lblTotalHarga.Size = New System.Drawing.Size(180, 19)
        Me.lblTotalHarga.TabIndex = 0
        Me.lblTotalHarga.Text = "Total Harga: Rp 0"

        Me.lblDiskonTotal.AutoSize = True
        Me.lblDiskonTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiskonTotal.Location = New System.Drawing.Point(15, 50)
        Me.lblDiskonTotal.Name = "lblDiskonTotal"
        Me.lblDiskonTotal.Size = New System.Drawing.Size(95, 15)
        Me.lblDiskonTotal.TabIndex = 1
        Me.lblDiskonTotal.Text = "Diskon Transaksi"

        Me.txtDiskonTotal.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.txtDiskonTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiskonTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskonTotal.Location = New System.Drawing.Point(15, 68)
        Me.txtDiskonTotal.Name = "txtDiskonTotal"
        Me.txtDiskonTotal.Text = "0"
        Me.txtDiskonTotal.Size = New System.Drawing.Size(420, 25)
        Me.txtDiskonTotal.TabIndex = 2

        Me.lblTotalBayar.AutoSize = True
        Me.lblTotalBayar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBayar.ForeColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.lblTotalBayar.Location = New System.Drawing.Point(15, 105)
        Me.lblTotalBayar.Name = "lblTotalBayar"
        Me.lblTotalBayar.Size = New System.Drawing.Size(180, 19)
        Me.lblTotalBayar.TabIndex = 3
        Me.lblTotalBayar.Text = "Total Bayar: Rp 0"

        Me.lblBayar.AutoSize = True
        Me.lblBayar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBayar.Location = New System.Drawing.Point(15, 140)
        Me.lblBayar.Name = "lblBayar"
        Me.lblBayar.Size = New System.Drawing.Size(68, 15)
        Me.lblBayar.TabIndex = 4
        Me.lblBayar.Text = "Uang Bayar"

        Me.txtBayar.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.txtBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBayar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Location = New System.Drawing.Point(15, 158)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(420, 25)
        Me.txtBayar.TabIndex = 5
        Me.txtBayar.Text = "0"

        Me.lblKembalian.AutoSize = True
        Me.lblKembalian.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembalian.ForeColor = System.Drawing.Color.FromArgb(CType(34, Byte), CType(197, Byte), CType(94, Byte))
        Me.lblKembalian.Location = New System.Drawing.Point(15, 200)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(150, 19)
        Me.lblKembalian.TabIndex = 6
        Me.lblKembalian.Text = "Kembalian: Rp 0"

        Me.btnProses.BackColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.btnProses.Enabled = False
        Me.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProses.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.ForeColor = System.Drawing.Color.White
        Me.btnProses.Location = New System.Drawing.Point(15, 430)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(450, 50)
        Me.btnProses.TabIndex = 2
        Me.btnProses.Text = "Proses Transaksi"
        Me.btnProses.UseVisualStyleBackColor = False

        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(38, Byte), CType(38, Byte))
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(15, 490)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(215, 35)
        Me.btnBatal.TabIndex = 3
        Me.btnBatal.Text = "Batalkan"
        Me.btnBatal.UseVisualStyleBackColor = False

        Me.btnBaru.BackColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.btnBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaru.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaru.ForeColor = System.Drawing.Color.White
        Me.btnBaru.Location = New System.Drawing.Point(235, 490)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(230, 35)
        Me.btnBaru.TabIndex = 4
        Me.btnBaru.Text = "Transaksi Baru"
        Me.btnBaru.UseVisualStyleBackColor = False

        Me.tmrWaktu.Interval = 1000
        Me.tmrWaktu.Enabled = True

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Name = "FrmKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KasirIn — Transaksi Kasir"
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProduk.ResumeLayout(False)
        Me.pnlProduk.PerformLayout()
        Me.pnlSearchBar.ResumeLayout(False)
        Me.pnlSearchBar.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlPayment.ResumeLayout(False)
        Me.pnlPayment.PerformLayout()
        Me.pnlTransInfo.ResumeLayout(False)
        Me.pnlTransInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents lblItemCount As Label
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents pnlSearchBar As Panel
    Friend WithEvents cmbHasilCari As ComboBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents pnlRight As Panel
    Friend WithEvents btnBaru As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnProses As Button
    Friend WithEvents pnlPayment As Panel
    Friend WithEvents lblKembalian As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents lblBayar As Label
    Friend WithEvents lblTotalBayar As Label
    Friend WithEvents txtDiskonTotal As TextBox
    Friend WithEvents lblDiskonTotal As Label
    Friend WithEvents lblTotalHarga As Label
    Friend WithEvents pnlTransInfo As Panel
    Friend WithEvents lblKasir As Label
    Friend WithEvents lblWaktu As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblNoTransaksi As Label
    Friend WithEvents tmrWaktu As Timer
    Friend WithEvents pnlProduk As Panel
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents lblProduk As Label

End Class
