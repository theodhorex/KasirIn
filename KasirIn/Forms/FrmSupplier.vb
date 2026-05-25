Imports MySql.Data.MySqlClient

Public Class FrmSupplier
    Private Sub FrmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeGrid()
        LoadSupplier()
        AddHandler txtSearch.TextChanged, AddressOf txtSearch_TextChanged
        AddHandler chkNonaktif.CheckedChanged, AddressOf chkNonaktif_CheckedChanged
    End Sub

    Private Sub InitializeGrid()
        dgvSupplier.Columns.Clear()
        dgvSupplier.Columns.Add("IdSupplier", "ID")
        dgvSupplier.Columns.Add("KodeSupplier", "Kode")
        dgvSupplier.Columns.Add("NamaSupplier", "Nama Supplier")
        dgvSupplier.Columns.Add("NamaKontak", "Kontak")
        dgvSupplier.Columns.Add("Telepon", "Telepon")
        dgvSupplier.Columns.Add("Email", "Email")
        dgvSupplier.Columns.Add("IsActive", "Status")

        dgvSupplier.Columns(0).Visible = False
        dgvSupplier.Columns(1).Width = 80
        dgvSupplier.Columns(2).Width = 200
        dgvSupplier.Columns(3).Width = 120
        dgvSupplier.Columns(4).Width = 100
        dgvSupplier.Columns(5).Width = 150
        dgvSupplier.Columns(6).Width = 80
    End Sub

    Private Sub LoadSupplier()
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim showNonaktif As Boolean = chkNonaktif.Checked
            Dim query As String = "SELECT id_supplier, kode_supplier, nama_supplier, nama_kontak, telepon, email, is_active " &
                "FROM tbl_supplier "

            If Not showNonaktif Then
                query &= "WHERE is_active = 1 "
            End If

            query &= "ORDER BY nama_supplier"

            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvSupplier.Rows.Clear()

            Dim no As Integer = 1
            For Each row In table.Rows
                Dim idSupplier As Integer = CInt(row("id_supplier"))
                Dim kodeSupplier As String = row("kode_supplier").ToString()
                Dim namaSupplier As String = row("nama_supplier").ToString()
                Dim namaKontak As String = If(row("nama_kontak") Is Nothing, "", row("nama_kontak").ToString())
                Dim telepon As String = If(row("telepon") Is Nothing, "", row("telepon").ToString())
                Dim email As String = If(row("email") Is Nothing, "", row("email").ToString())
                Dim isActive As Integer = CInt(row("is_active"))

                Dim status As String = If(isActive = 1, "Aktif", "Nonaktif")
                dgvSupplier.Rows.Add(idSupplier, kodeSupplier, namaSupplier, namaKontak, telepon, email, status)

                If isActive = 0 Then
                    dgvSupplier.Rows(dgvSupplier.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Gray
                End If

                no += 1
            Next

            lblTotal.Text = "Total: " & table.Rows.Count & " supplier"
            connection.Close()

        Catch ex As Exception
            MsgBox("Error loading supplier: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim searchText As String = txtSearch.Text.Trim()
            Dim showNonaktif As Boolean = chkNonaktif.Checked

            Dim query As String = "SELECT id_supplier, kode_supplier, nama_supplier, nama_kontak, telepon, email, is_active " &
                "FROM tbl_supplier WHERE 1=1 "

            If Not showNonaktif Then
                query &= "AND is_active = 1 "
            End If

            If Not String.IsNullOrEmpty(searchText) Then
                query &= "AND (nama_supplier LIKE @search OR kode_supplier LIKE @search) "
            End If

            query &= "ORDER BY nama_supplier"

            Dim adapter As New MySqlDataAdapter(query, connection)
            If Not String.IsNullOrEmpty(searchText) Then
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & searchText & "%")
            End If

            Dim table As New DataTable()
            adapter.Fill(table)

            dgvSupplier.Rows.Clear()

            For Each row In table.Rows
                Dim idSupplier As Integer = CInt(row("id_supplier"))
                Dim kodeSupplier As String = row("kode_supplier").ToString()
                Dim namaSupplier As String = row("nama_supplier").ToString()
                Dim namaKontak As String = If(row("nama_kontak") Is Nothing, "", row("nama_kontak").ToString())
                Dim telepon As String = If(row("telepon") Is Nothing, "", row("telepon").ToString())
                Dim email As String = If(row("email") Is Nothing, "", row("email").ToString())
                Dim isActive As Integer = CInt(row("is_active"))

                Dim status As String = If(isActive = 1, "Aktif", "Nonaktif")
                dgvSupplier.Rows.Add(idSupplier, kodeSupplier, namaSupplier, namaKontak, telepon, email, status)

                If isActive = 0 Then
                    dgvSupplier.Rows(dgvSupplier.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

            lblTotal.Text = "Total: " & table.Rows.Count & " supplier"
            connection.Close()

        Catch ex As Exception
            MsgBox("Error searching supplier: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub chkNonaktif_CheckedChanged(sender As Object, e As EventArgs)
        LoadSupplier()
    End Sub

    Private Sub dgvSupplier_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSupplier.SelectionChanged
        Dim hasSelection As Boolean = (dgvSupplier.SelectedRows.Count > 0)
        btnEdit.Enabled = hasSelection
        btnNonaktif.Enabled = hasSelection
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim detailForm As New FrmSupplierDetail()
        detailForm.ShowDialog()
        LoadSupplier()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvSupplier.SelectedRows.Count = 0 Then Return

        Dim idSupplier As Integer = CInt(dgvSupplier.SelectedRows(0).Cells(0).Value)
        Dim detailForm As New FrmSupplierDetail(idSupplier)
        detailForm.ShowDialog()
        LoadSupplier()
    End Sub

    Private Sub btnNonaktif_Click(sender As Object, e As EventArgs) Handles btnNonaktif.Click
        If dgvSupplier.SelectedRows.Count = 0 Then Return

        Dim idSupplier As Integer = CInt(dgvSupplier.SelectedRows(0).Cells(0).Value)
        Dim namaSupplier As String = If(dgvSupplier.SelectedRows(0).Cells(2).Value Is Nothing, "", dgvSupplier.SelectedRows(0).Cells(2).Value.ToString())
        Dim isActive As String = If(dgvSupplier.SelectedRows(0).Cells(6).Value Is Nothing, "", dgvSupplier.SelectedRows(0).Cells(6).Value.ToString())

        Dim action As String = If(isActive = "Aktif", "nonaktifkan", "aktifkan")
        Dim result As DialogResult = MsgBox("Yakin ingin " & action & " supplier '" & namaSupplier & "'?", MsgBoxStyle.YesNo)

        If result = DialogResult.Yes Then
            ToggleSupplierStatus(idSupplier)
        End If
    End Sub

    Private Sub ToggleSupplierStatus(idSupplier As Integer)
        Try
            Dim connection As MySqlConnection = DBConnection.GetConnection()
            If connection Is Nothing Then Return

            Dim getNamaQuery As String = "SELECT nama_supplier, is_active FROM tbl_supplier WHERE id_supplier = @id"
            Dim getNamaCmd As New MySqlCommand(getNamaQuery, connection)
            getNamaCmd.Parameters.AddWithValue("@id", idSupplier)
            Dim reader As MySqlDataReader = getNamaCmd.ExecuteReader()
            Dim namaSupplier As String = ""
            Dim currentStatus As Integer = 0
            If reader.Read() Then
                namaSupplier = reader("nama_supplier").ToString()
                currentStatus = CInt(reader("is_active"))
            End If
            reader.Close()

            Dim query As String = "UPDATE tbl_supplier SET is_active = CASE WHEN is_active = 1 THEN 0 ELSE 1 END WHERE id_supplier = @id"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", idSupplier)
            command.ExecuteNonQuery()

            Dim newStatus As String = If(currentStatus = 1, "Nonaktif", "Aktif")
            LogHelper.CatatLog("Kelola Supplier", "Aksi: Toggle - " & namaSupplier & " menjadi " & newStatus)

            connection.Close()
            LoadSupplier()
            MsgBox("Status supplier berhasil diubah", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgvSupplier_DoubleClick(sender As Object, e As EventArgs) Handles dgvSupplier.DoubleClick
        If dgvSupplier.SelectedRows.Count > 0 Then
            btnEdit_Click(Nothing, Nothing)
        End If
    End Sub
End Class
