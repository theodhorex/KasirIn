Imports MySql.Data.MySqlClient

Public Class FrmPengeluaran
    Private currentIdPengeluaran As Integer = 0
    Private isEditMode As Boolean = False

    Private Sub FrmPengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFilterDari.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        dtpFilterSampai.Value = DateTime.Now

        LoadKategori()
        LoadPengeluaran()
    End Sub

    Private Sub LoadKategori()
        cmbKategori.Items.Clear()
        cmbKategori.Items.Add("Listrik")
        cmbKategori.Items.Add("Sewa")
        cmbKategori.Items.Add("Gaji")
        cmbKategori.Items.Add("Kebersihan")
        cmbKategori.Items.Add("Lain-lain")
        cmbKategori.SelectedIndex = 0
    End Sub

    Private Sub LoadPengeluaran()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim dari As String = dtpFilterDari.Value.ToString("yyyy-MM-dd")
            Dim sampai As String = dtpFilterSampai.Value.ToString("yyyy-MM-dd")

            Dim query As String = "SELECT id_pengeluaran, tanggal, kategori, keterangan, jumlah " &
                "FROM tbl_pengeluaran " &
                "WHERE tanggal BETWEEN @dari AND @sampai " &
                "ORDER BY tanggal DESC"

            Dim adapter As New MySqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@dari", dari)
            adapter.SelectCommand.Parameters.AddWithValue("@sampai", sampai)

            Dim table As New DataTable()
            adapter.Fill(table)

            dgvPengeluaran.DataSource = table

            If dgvPengeluaran.Columns.Count > 0 Then
                dgvPengeluaran.Columns(0).Visible = False
                dgvPengeluaran.Columns(1).HeaderText = "Tanggal"
                dgvPengeluaran.Columns(2).HeaderText = "Kategori"
                dgvPengeluaran.Columns(3).HeaderText = "Keterangan"
                dgvPengeluaran.Columns(4).HeaderText = "Jumlah"

                dgvPengeluaran.AutoResizeColumns()
            End If

            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading pengeluaran: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        LoadPengeluaran()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ResetForm()
        isEditMode = False
        currentIdPengeluaran = 0
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvPengeluaran.SelectedRows.Count = 0 Then
            MsgBox("Pilih pengeluaran yang akan diedit", MsgBoxStyle.Information)
            Return
        End If

        currentIdPengeluaran = If(dgvPengeluaran.SelectedRows(0).Cells(0).Value Is Nothing, 0, CInt(dgvPengeluaran.SelectedRows(0).Cells(0).Value))
        If currentIdPengeluaran = 0 Then Return

        isEditMode = True
        dtpTanggal.Value = CDate(dgvPengeluaran.SelectedRows(0).Cells(1).Value)
        cmbKategori.SelectedItem = dgvPengeluaran.SelectedRows(0).Cells(2).Value.ToString()
        txtKeterangan.Text = If(dgvPengeluaran.SelectedRows(0).Cells(3).Value Is Nothing, "", dgvPengeluaran.SelectedRows(0).Cells(3).Value.ToString())
        txtJumlah.Text = dgvPengeluaran.SelectedRows(0).Cells(4).Value.ToString()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvPengeluaran.SelectedRows.Count = 0 Then
            MsgBox("Pilih pengeluaran yang akan dihapus", MsgBoxStyle.Information)
            Return
        End If

        currentIdPengeluaran = If(dgvPengeluaran.SelectedRows(0).Cells(0).Value Is Nothing, 0, CInt(dgvPengeluaran.SelectedRows(0).Cells(0).Value))
        If currentIdPengeluaran = 0 Then Return

        Dim result As DialogResult = MsgBox("Yakin ingin menghapus pengeluaran ini?", MsgBoxStyle.YesNo, "Konfirmasi")
        If result = DialogResult.Yes Then
            DeletePengeluaran(currentIdPengeluaran)
            LoadPengeluaran()
            ResetForm()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Return

        If isEditMode Then
            UpdatePengeluaran()
        Else
            InsertPengeluaran()
        End If

        LoadPengeluaran()
        ResetForm()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ResetForm()
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(txtKeterangan.Text) Then
            MsgBox("Keterangan harus diisi", MsgBoxStyle.Information)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtJumlah.Text) Then
            MsgBox("Jumlah harus diisi", MsgBoxStyle.Information)
            Return False
        End If

        If Not IsNumeric(txtJumlah.Text) Then
            MsgBox("Jumlah harus berupa angka", MsgBoxStyle.Information)
            Return False
        End If

        Return True
    End Function

    Private Sub InsertPengeluaran()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "INSERT INTO tbl_pengeluaran (tanggal, kategori, keterangan, jumlah, id_user, created_at) " &
                "VALUES (@tanggal, @kategori, @keterangan, @jumlah, @idUser, NOW())"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@kategori", cmbKategori.SelectedItem.ToString())
            command.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
            command.Parameters.AddWithValue("@jumlah", CDec(txtJumlah.Text))
            command.Parameters.AddWithValue("@idUser", SessionHelper.UserId)

            command.ExecuteNonQuery()
            connection.Close()

            MsgBox("Pengeluaran berhasil ditambahkan", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub UpdatePengeluaran()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "UPDATE tbl_pengeluaran SET tanggal=@tanggal, kategori=@kategori, " &
                "keterangan=@keterangan, jumlah=@jumlah WHERE id_pengeluaran=@id"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@kategori", cmbKategori.SelectedItem.ToString())
            command.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
            command.Parameters.AddWithValue("@jumlah", CDec(txtJumlah.Text))
            command.Parameters.AddWithValue("@id", currentIdPengeluaran)

            command.ExecuteNonQuery()
            connection.Close()

            MsgBox("Pengeluaran berhasil diperbarui", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub DeletePengeluaran(id As Integer)
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim query As String = "DELETE FROM tbl_pengeluaran WHERE id_pengeluaran=@id"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", id)

            command.ExecuteNonQuery()
            connection.Close()

            MsgBox("Pengeluaran berhasil dihapus", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ResetForm()
        currentIdPengeluaran = 0
        isEditMode = False
        dtpTanggal.Value = DateTime.Now
        cmbKategori.SelectedIndex = 0
        txtKeterangan.Text = ""
        txtJumlah.Text = ""
    End Sub

    Private Function IsNumeric(value As String) As Boolean
        Dim result As Decimal
        Return Decimal.TryParse(value, result)
    End Function
End Class
