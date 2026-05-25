<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierDetail
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.chkAktif = New System.Windows.Forms.CheckBox()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.lblKontak = New System.Windows.Forms.Label()
        Me.txtKontak = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.pnlForm.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        Me.pnlForm.Controls.Add(Me.chkAktif)
        Me.pnlForm.Controls.Add(Me.lblAlamat)
        Me.pnlForm.Controls.Add(Me.txtAlamat)
        Me.pnlForm.Controls.Add(Me.lblEmail)
        Me.pnlForm.Controls.Add(Me.txtEmail)
        Me.pnlForm.Controls.Add(Me.lblTelepon)
        Me.pnlForm.Controls.Add(Me.txtTelepon)
        Me.pnlForm.Controls.Add(Me.lblKontak)
        Me.pnlForm.Controls.Add(Me.txtKontak)
        Me.pnlForm.Controls.Add(Me.lblNama)
        Me.pnlForm.Controls.Add(Me.txtNama)
        Me.pnlForm.Controls.Add(Me.lblKode)
        Me.pnlForm.Controls.Add(Me.txtKode)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlForm.Size = New System.Drawing.Size(480, 500)
        Me.pnlForm.TabIndex = 0
        Me.chkAktif.AutoSize = True
        Me.chkAktif.Checked = True
        Me.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAktif.Location = New System.Drawing.Point(30, 420)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(80, 20)
        Me.chkAktif.TabIndex = 12
        Me.chkAktif.Text = "Aktif"
        Me.chkAktif.UseVisualStyleBackColor = True
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(30, 310)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(51, 15)
        Me.lblAlamat.TabIndex = 10
        Me.lblAlamat.Text = "Alamat"
        Me.txtAlamat.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAlamat.Location = New System.Drawing.Point(30, 330)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(420, 80)
        Me.txtAlamat.TabIndex = 11
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(30, 250)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 15)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email"
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.Location = New System.Drawing.Point(30, 270)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(420, 30)
        Me.txtEmail.TabIndex = 9
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Location = New System.Drawing.Point(30, 190)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(57, 15)
        Me.lblTelepon.TabIndex = 6
        Me.lblTelepon.Text = "Telepon"
        Me.txtTelepon.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTelepon.Location = New System.Drawing.Point(30, 210)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(420, 30)
        Me.txtTelepon.TabIndex = 7
        Me.lblKontak.AutoSize = True
        Me.lblKontak.Location = New System.Drawing.Point(30, 130)
        Me.lblKontak.Name = "lblKontak"
        Me.lblKontak.Size = New System.Drawing.Size(85, 15)
        Me.lblKontak.TabIndex = 4
        Me.lblKontak.Text = "Nama Kontak"
        Me.txtKontak.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtKontak.Location = New System.Drawing.Point(30, 150)
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.Size = New System.Drawing.Size(420, 30)
        Me.txtKontak.TabIndex = 5
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(30, 70)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(95, 15)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama Supplier *"
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNama.Location = New System.Drawing.Point(30, 90)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(420, 30)
        Me.txtNama.TabIndex = 3
        Me.lblKode.AutoSize = True
        Me.lblKode.Location = New System.Drawing.Point(30, 10)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(88, 15)
        Me.lblKode.TabIndex = 0
        Me.lblKode.Text = "Kode Supplier"
        Me.txtKode.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtKode.Location = New System.Drawing.Point(30, 30)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(420, 30)
        Me.txtKode.TabIndex = 1
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlButtons.Controls.Add(Me.btnBatal)
        Me.pnlButtons.Controls.Add(Me.btnSimpan)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 450)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(480, 50)
        Me.pnlButtons.TabIndex = 1
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(270, 10)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(180, 35)
        Me.btnBatal.TabIndex = 1
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(30, 10)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(180, 35)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 500)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.pnlButtons)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSupplierDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tambah Supplier"
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlForm As Panel
    Friend WithEvents chkAktif As CheckBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblTelepon As Label
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents lblKontak As Label
    Friend WithEvents txtKontak As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblKode As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button

End Class
