<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProdukDetail
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
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblKategori = New System.Windows.Forms.Label()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.lblHargaBeli = New System.Windows.Forms.Label()
        Me.txtHargaBeli = New System.Windows.Forms.TextBox()
        Me.lblHargaJual = New System.Windows.Forms.Label()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.lblStokMin = New System.Windows.Forms.Label()
        Me.txtStokMin = New System.Windows.Forms.TextBox()
        Me.lblSatuan = New System.Windows.Forms.Label()
        Me.cmbSatuan = New System.Windows.Forms.ComboBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.chkAktif = New System.Windows.Forms.CheckBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarcode.Location = New System.Drawing.Point(20, 20)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(54, 15)
        Me.lblBarcode.TabIndex = 0
        Me.lblBarcode.Text = "Barcode"

        Me.txtBarcode.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(20, 38)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(440, 25)
        Me.txtBarcode.TabIndex = 1

        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(20, 70)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(85, 15)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama Produk *"

        Me.txtNama.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(20, 88)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(440, 25)
        Me.txtNama.TabIndex = 3

        Me.lblKategori.AutoSize = True
        Me.lblKategori.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKategori.Location = New System.Drawing.Point(20, 120)
        Me.lblKategori.Name = "lblKategori"
        Me.lblKategori.Size = New System.Drawing.Size(68, 15)
        Me.lblKategori.TabIndex = 4
        Me.lblKategori.Text = "Kategori *"

        Me.cmbKategori.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKategori.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(20, 138)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(440, 25)
        Me.cmbKategori.TabIndex = 5

        Me.lblHargaBeli.AutoSize = True
        Me.lblHargaBeli.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHargaBeli.Location = New System.Drawing.Point(20, 170)
        Me.lblHargaBeli.Name = "lblHargaBeli"
        Me.lblHargaBeli.Size = New System.Drawing.Size(84, 15)
        Me.lblHargaBeli.TabIndex = 6
        Me.lblHargaBeli.Text = "Harga Beli *"

        Me.txtHargaBeli.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.txtHargaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHargaBeli.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaBeli.Location = New System.Drawing.Point(20, 188)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.Size = New System.Drawing.Size(210, 25)
        Me.txtHargaBeli.TabIndex = 7

        Me.lblHargaJual.AutoSize = True
        Me.lblHargaJual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHargaJual.Location = New System.Drawing.Point(250, 170)
        Me.lblHargaJual.Name = "lblHargaJual"
        Me.lblHargaJual.Size = New System.Drawing.Size(88, 15)
        Me.lblHargaJual.TabIndex = 8
        Me.lblHargaJual.Text = "Harga Jual *"

        Me.txtHargaJual.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.txtHargaJual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHargaJual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaJual.Location = New System.Drawing.Point(250, 188)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(210, 25)
        Me.txtHargaJual.TabIndex = 9

        Me.lblStok.AutoSize = True
        Me.lblStok.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStok.Location = New System.Drawing.Point(20, 220)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(49, 15)
        Me.lblStok.TabIndex = 10
        Me.lblStok.Text = "Stok *"

        Me.txtStok.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStok.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(20, 238)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(210, 25)
        Me.txtStok.TabIndex = 11

        Me.lblStokMin.AutoSize = True
        Me.lblStokMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokMin.Location = New System.Drawing.Point(250, 220)
        Me.lblStokMin.Name = "lblStokMin"
        Me.lblStokMin.Size = New System.Drawing.Size(104, 15)
        Me.lblStokMin.TabIndex = 12
        Me.lblStokMin.Text = "Stok Minimum *"

        Me.txtStokMin.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.txtStokMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStokMin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStokMin.Location = New System.Drawing.Point(250, 238)
        Me.txtStokMin.Name = "txtStokMin"
        Me.txtStokMin.Text = "5"
        Me.txtStokMin.Size = New System.Drawing.Size(210, 25)
        Me.txtStokMin.TabIndex = 13

        Me.lblSatuan.AutoSize = True
        Me.lblSatuan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSatuan.Location = New System.Drawing.Point(20, 270)
        Me.lblSatuan.Name = "lblSatuan"
        Me.lblSatuan.Size = New System.Drawing.Size(59, 15)
        Me.lblSatuan.TabIndex = 14
        Me.lblSatuan.Text = "Satuan *"

        Me.cmbSatuan.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.cmbSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSatuan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSatuan.FormattingEnabled = True
        Me.cmbSatuan.Items.AddRange(New Object() {"Pcs", "Kg", "Liter", "Lusin", "Dus"})
        Me.cmbSatuan.Location = New System.Drawing.Point(20, 288)
        Me.cmbSatuan.Name = "cmbSatuan"
        Me.cmbSatuan.Size = New System.Drawing.Size(440, 25)
        Me.cmbSatuan.TabIndex = 15

        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.Location = New System.Drawing.Point(20, 320)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(72, 15)
        Me.lblKeterangan.TabIndex = 16
        Me.lblKeterangan.Text = "Keterangan"

        Me.txtKeterangan.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(250, Byte), CType(251, Byte))
        Me.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeterangan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Location = New System.Drawing.Point(20, 338)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(440, 60)
        Me.txtKeterangan.TabIndex = 17

        Me.chkAktif.AutoSize = True
        Me.chkAktif.Checked = True
        Me.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAktif.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAktif.Location = New System.Drawing.Point(20, 410)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(98, 19)
        Me.chkAktif.TabIndex = 18
        Me.chkAktif.Text = "Produk Aktif"
        Me.chkAktif.UseVisualStyleBackColor = True

        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(37, Byte), CType(99, Byte), CType(235, Byte))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(320, 450)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(140, 35)
        Me.btnSimpan.TabIndex = 19
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(229, Byte), CType(231, Byte), CType(235, Byte))
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(CType(31, Byte), CType(41, Byte), CType(55, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(20, 450)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(140, 35)
        Me.btnBatal.TabIndex = 20
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 500)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.chkAktif)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.cmbSatuan)
        Me.Controls.Add(Me.lblSatuan)
        Me.Controls.Add(Me.txtStokMin)
        Me.Controls.Add(Me.lblStokMin)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.lblStok)
        Me.Controls.Add(Me.txtHargaJual)
        Me.Controls.Add(Me.lblHargaJual)
        Me.Controls.Add(Me.txtHargaBeli)
        Me.Controls.Add(Me.lblHargaBeli)
        Me.Controls.Add(Me.cmbKategori)
        Me.Controls.Add(Me.lblKategori)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.lblBarcode)
        Me.Name = "FrmProdukDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tambah Produk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBarcode As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblKategori As Label
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents lblHargaBeli As Label
    Friend WithEvents txtHargaBeli As TextBox
    Friend WithEvents lblHargaJual As Label
    Friend WithEvents txtHargaJual As TextBox
    Friend WithEvents lblStok As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents lblStokMin As Label
    Friend WithEvents txtStokMin As TextBox
    Friend WithEvents lblSatuan As Label
    Friend WithEvents cmbSatuan As ComboBox
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents chkAktif As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button

End Class
