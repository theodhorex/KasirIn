<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPengeluaran
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
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.dtpFilterSampai = New System.Windows.Forms.DateTimePicker()
        Me.lblFilterSampai = New System.Windows.Forms.Label()
        Me.dtpFilterDari = New System.Windows.Forms.DateTimePicker()
        Me.lblFilterDari = New System.Windows.Forms.Label()
        Me.dgvPengeluaran = New System.Windows.Forms.DataGridView()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.lblKategori = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.pnlFilter.SuspendLayout()
        CType(Me.dgvPengeluaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForm.SuspendLayout()
        Me.SuspendLayout()

        Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFilter.Controls.Add(Me.btnTampilkan)
        Me.pnlFilter.Controls.Add(Me.dtpFilterSampai)
        Me.pnlFilter.Controls.Add(Me.lblFilterSampai)
        Me.pnlFilter.Controls.Add(Me.dtpFilterDari)
        Me.pnlFilter.Controls.Add(Me.lblFilterDari)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlFilter.Size = New System.Drawing.Size(800, 60)
        Me.pnlFilter.TabIndex = 0

        Me.lblFilterDari.AutoSize = True
        Me.lblFilterDari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFilterDari.Location = New System.Drawing.Point(10, 20)
        Me.lblFilterDari.Name = "lblFilterDari"
        Me.lblFilterDari.Size = New System.Drawing.Size(30, 15)
        Me.lblFilterDari.TabIndex = 0
        Me.lblFilterDari.Text = "Dari:"

        Me.dtpFilterDari.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFilterDari.Location = New System.Drawing.Point(45, 18)
        Me.dtpFilterDari.Name = "dtpFilterDari"
        Me.dtpFilterDari.Size = New System.Drawing.Size(120, 20)
        Me.dtpFilterDari.TabIndex = 1

        Me.lblFilterSampai.AutoSize = True
        Me.lblFilterSampai.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFilterSampai.Location = New System.Drawing.Point(180, 20)
        Me.lblFilterSampai.Name = "lblFilterSampai"
        Me.lblFilterSampai.Size = New System.Drawing.Size(50, 15)
        Me.lblFilterSampai.TabIndex = 2
        Me.lblFilterSampai.Text = "Sampai:"

        Me.dtpFilterSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFilterSampai.Location = New System.Drawing.Point(235, 18)
        Me.dtpFilterSampai.Name = "dtpFilterSampai"
        Me.dtpFilterSampai.Size = New System.Drawing.Size(120, 20)
        Me.dtpFilterSampai.TabIndex = 3

        Me.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.btnTampilkan.FlatAppearance.BorderSize = 0
        Me.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTampilkan.ForeColor = System.Drawing.Color.White
        Me.btnTampilkan.Location = New System.Drawing.Point(370, 15)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(80, 28)
        Me.btnTampilkan.TabIndex = 4
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = False

        Me.dgvPengeluaran.AllowUserToAddRows = False
        Me.dgvPengeluaran.AllowUserToDeleteRows = False
        Me.dgvPengeluaran.BackgroundColor = System.Drawing.Color.White
        Me.dgvPengeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPengeluaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPengeluaran.Location = New System.Drawing.Point(0, 60)
        Me.dgvPengeluaran.Name = "dgvPengeluaran"
        Me.dgvPengeluaran.ReadOnly = True
        Me.dgvPengeluaran.Size = New System.Drawing.Size(800, 340)
        Me.dgvPengeluaran.TabIndex = 1

        Me.pnlForm.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlForm.Controls.Add(Me.btnBatal)
        Me.pnlForm.Controls.Add(Me.btnSimpan)
        Me.pnlForm.Controls.Add(Me.btnHapus)
        Me.pnlForm.Controls.Add(Me.btnEdit)
        Me.pnlForm.Controls.Add(Me.btnTambah)
        Me.pnlForm.Controls.Add(Me.txtJumlah)
        Me.pnlForm.Controls.Add(Me.lblJumlah)
        Me.pnlForm.Controls.Add(Me.txtKeterangan)
        Me.pnlForm.Controls.Add(Me.lblKeterangan)
        Me.pnlForm.Controls.Add(Me.cmbKategori)
        Me.pnlForm.Controls.Add(Me.lblKategori)
        Me.pnlForm.Controls.Add(Me.dtpTanggal)
        Me.pnlForm.Controls.Add(Me.lblTanggal)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlForm.Location = New System.Drawing.Point(0, 400)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlForm.Size = New System.Drawing.Size(800, 100)
        Me.pnlForm.TabIndex = 2

        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTanggal.Location = New System.Drawing.Point(10, 15)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(50, 15)
        Me.lblTanggal.TabIndex = 0
        Me.lblTanggal.Text = "Tanggal:"

        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTanggal.Location = New System.Drawing.Point(65, 13)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(100, 20)
        Me.dtpTanggal.TabIndex = 1

        Me.lblKategori.AutoSize = True
        Me.lblKategori.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKategori.Location = New System.Drawing.Point(180, 15)
        Me.lblKategori.Name = "lblKategori"
        Me.lblKategori.Size = New System.Drawing.Size(60, 15)
        Me.lblKategori.TabIndex = 2
        Me.lblKategori.Text = "Kategori:"

        Me.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKategori.Location = New System.Drawing.Point(245, 13)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(110, 21)
        Me.cmbKategori.TabIndex = 3

        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKeterangan.Location = New System.Drawing.Point(370, 15)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(70, 15)
        Me.lblKeterangan.TabIndex = 4
        Me.lblKeterangan.Text = "Keterangan:"

        Me.txtKeterangan.Location = New System.Drawing.Point(445, 13)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(150, 20)
        Me.txtKeterangan.TabIndex = 5

        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblJumlah.Location = New System.Drawing.Point(10, 45)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(50, 15)
        Me.lblJumlah.TabIndex = 6
        Me.lblJumlah.Text = "Jumlah:"

        Me.txtJumlah.Location = New System.Drawing.Point(65, 43)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(100, 20)
        Me.txtJumlah.TabIndex = 7

        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(34, Byte), CType(197, Byte), CType(94, Byte))
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(180, 43)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(70, 28)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False

        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(130, Byte), CType(246, Byte))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(255, 43)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(70, 28)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False

        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(38, Byte), CType(38, Byte))
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(330, 43)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(70, 28)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False

        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(445, 43)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(70, 28)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(107, Byte), CType(114, Byte), CType(128, Byte))
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(520, 43)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(70, 28)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.dgvPengeluaran)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.pnlFilter)
        Me.Name = "FrmPengeluaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KasirIn — Kelola Pengeluaran"
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        CType(Me.dgvPengeluaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFilter As Panel
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents dtpFilterSampai As DateTimePicker
    Friend WithEvents lblFilterSampai As Label
    Friend WithEvents dtpFilterDari As DateTimePicker
    Friend WithEvents lblFilterDari As Label
    Friend WithEvents dgvPengeluaran As DataGridView
    Friend WithEvents pnlForm As Panel
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents lblJumlah As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents lblKategori As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents lblTanggal As Label

End Class
