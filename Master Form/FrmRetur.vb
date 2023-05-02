Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmRetur
    Public cmdbl As SqlCommandBuilder
    Public adap As SqlDataAdapter
    Public ds As DataSet
    Public con As SqlConnection
    Sub pengaturanDGVFrmRetur()
        DGV.Columns(0).Visible = False
        DGV.Columns(1).Visible = False
        DGV.Columns(2).Width = 90
        DGV.Columns(3).Width = 250
        DGV.Columns(4).Width = 70
        DGV.Columns(5).Width = 70
        DGV.Columns(6).Width = 90
        DGV.Columns(7).Width = 100
        DGV.Columns(8).Width = 100
        BtBaru.Enabled = False
        BtSimpan.Enabled = False
        BtKeluar.Enabled = True
        BtEdit.Enabled = True
        BtCari.Enabled = True
        BtHapus.Enabled = True
        BtKembali.Enabled = True
        DGV.ReadOnly = True
        CBCust.Enabled = False
        txtCust.Enabled = False
        txtNoFak.Enabled = False
        txtDriver.Enabled = False
        txtSales.Enabled = False
        DTTanggal.Enabled = False
    End Sub
    Sub PengaturanDGV()
        DGV.Columns(0).Visible = False
        DGV.Columns(1).Visible = False
        DGV.Columns(2).Width = 90
        DGV.Columns(3).Width = 250
        DGV.Columns(4).Width = 70
        DGV.Columns(5).Width = 70
        DGV.Columns(6).Width = 90
        DGV.Columns(7).Width = 100
        DGV.Columns(8).Width = 100
    End Sub
    Sub Bersih()
        txtCust.Text = ""
        txtKdCust.Text = ""
        txtNoFak.Text = ""
        txtNoBukti.Text = ""
        txtDriver.Text = ""
        txtSales.Text = ""
        DGV.DataSource = Nothing
        'CBCust.SelectedIndex = -1
    End Sub
    Sub Pengaturan()
        Select Case Status
            Case True
                BtBaru.Enabled = True
                BtSimpan.Enabled = False
                BtKeluar.Enabled = True
                BtEdit.Enabled = False
                BtCari.Enabled = True
                BtHapus.Enabled = False
                BtKembali.Enabled = False
                DGV.ReadOnly = True
                CBCust.Enabled = False
                txtKdCust.Enabled = False
                txtCust.Enabled = False
                txtNoFak.Enabled = False
                txtDriver.Enabled = False
                txtSales.Enabled = False
                DTTanggal.Enabled = False
            Case False
                BtBaru.Enabled = False
                BtSimpan.Enabled = True
                BtKeluar.Enabled = False
                BtEdit.Enabled = False
                BtCari.Enabled = False
                BtHapus.Enabled = False
                BtKembali.Enabled = True
                DGV.ReadOnly = False
                CBCust.Enabled = True
                txtKdCust.Enabled = False
                txtCust.Enabled = False
                txtNoFak.Enabled = True
                txtDriver.Enabled = True
                txtSales.Enabled = True
                DTTanggal.Enabled = True
        End Select
    End Sub
    ' Sub isicust()
    '    Tabel = Proses.ExecuteQuery("Select * from tblcustomer")
    '   CBCust.DataSource = Tabel
    '  CBCust.DisplayMember = "KdCust"
    ' CBCust.SelectedIndex = -1
    ' End Sub
    Private Sub FrmRetur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Status = True
        Call Pengaturan()
        ' Call isicust()
    End Sub

    Private Sub BtBaru_Click(sender As Object, e As EventArgs) Handles BtBaru.Click
        Status = False
        edit = False
        Call Pengaturan()
        Call Bersih()
        txtNoBukti.Text = "--Auto--"
        DGV.ColumnCount = 9
        DGV.Columns(0).HeaderText = "Line"
        DGV.Columns(1).HeaderText = "NoBukti"
        DGV.Columns(2).HeaderText = "Kode Brg"
        DGV.Columns(3).HeaderText = "Nama barang"
        DGV.Columns(4).HeaderText = "Quantity"
        DGV.Columns(5).HeaderText = "Packing"
        DGV.Columns(6).HeaderText = "Kondisi"
        DGV.Columns(7).HeaderText = "Keterangan"
        DGV.Columns(8).HeaderText = "Keterangan2"
        Call PengaturanDGV()
        txtNoFak.Focus()
    End Sub

    Private Sub BtKembali_Click(sender As Object, e As EventArgs) Handles BtKembali.Click
        Status = True
        edit = False
        Call Pengaturan()
        Call Bersih()
        DGV.Columns.Clear()
    End Sub

    Private Sub BtKeluar_Click(sender As Object, e As EventArgs) Handles BtKeluar.Click
        Me.Dispose()
        FrmHisRetur.Dispose()
    End Sub

    Private Sub CBCust_KeyDown(sender As Object, e As KeyEventArgs) Handles CBCust.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNoFak.Focus()
        End If
    End Sub

    Private Sub CBCust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCust.SelectedIndexChanged
        Try
            Tabel = Proses.ExecuteQuery("Select * from tblCustomer where KdCust = '" & CBCust.Text & "'")
            If Tabel.Rows.Count = 0 Then
                txtCust.Text = ""
            Else
                txtCust.Text = Tabel.Rows(0).Item(1)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub txtNoFak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoFak.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSales.Focus()
        End If
    End Sub

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDriver.Focus()
        End If
    End Sub

    Private Sub txtDriver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDriver.KeyPress
        If e.KeyChar = Chr(13) Then
            DGV.Focus()
        End If
    End Sub


    Private Sub DGV_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub

    Private Sub DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        Try
            If e.ColumnIndex = 2 Then
                Tabel = Proses.ExecuteQuery("Select NoBukti,KdBrg,Nmbrg,Satuan from tblFakDtl where KdBrg='" & DGV.Rows(e.RowIndex).Cells(2).Value & "' and NoBukti ='" & txtNoFak.Text & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("Kode Barang tidak ditemukan pada No Bukti :" + txtNoFak.Text, MsgBoxStyle.Exclamation, "Konfirmasi")
                    DGV.Rows(e.RowIndex).Cells(2).Value = ""
                    DGV.Rows(e.RowIndex).Cells(3).Value = ""
                    DGV.Rows(e.RowIndex).Cells(4).Value = ""
                    DGV.Rows(e.RowIndex).Cells(5).Value = ""
                    DGV.Rows(e.RowIndex).Cells(6).Value = ""
                    DGV.Rows(e.RowIndex).Cells(7).Value = ""
                    DGV.Rows(e.RowIndex).Cells(8).Value = ""
                Else
                    DGV.Rows(e.RowIndex).Cells(1).Value = txtNoBukti.Text
                    DGV.Rows(e.RowIndex).Cells(3).Value = Tabel(0).Item(2)
                    DGV.Rows(e.RowIndex).Cells(5).Value = Tabel(0).Item(3)
                End If
            End If
            If e.ColumnIndex = 6 Then
                Tabel = Proses.ExecuteQuery("Select * from tblKetLpb where KdLpb='" & DGV.Rows(e.RowIndex).Cells(6).Value & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("Kode keterangan tidak tersedia...", MsgBoxStyle.Exclamation, "Konfirmasi")
                    DGV.Rows(e.RowIndex).Cells(7).Value = ""
                Else
                    DGV.Rows(e.RowIndex).Cells(7).Value = Tabel(0).Item(1)
                End If
            End If

            DGV.Rows(e.RowIndex).Cells(3).ReadOnly = True
            DGV.Rows(e.RowIndex).Cells(5).ReadOnly = True
            DGV.Rows(e.RowIndex).Cells(7).ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub BtSimpan_Click(sender As Object, e As EventArgs) Handles BtSimpan.Click
        edit = False
        Tabel = Proses.ExecuteQuery("Select * from tblGdRetur where NoBukti ='" & txtNoBukti.Text & "'")
        If Tabel.Rows.Count = 0 Then
            If txtNoFak.Text = "" Then
                MsgBox("Input No Faktur", MsgBoxStyle.Information, "Pesan")
            Else
                txtNoBukti.Text = Kode.Generate("tblGdRetur", "NoBukti")
                Try
                    SQl = "Insert into tblGdRetur values('" & txtNoBukti.Text & "','" & txtKdCust.Text & "','" & rep(txtCust.Text) & "','" & DTTanggal.Text & "','" & txtNoFak.Text & "','" & txtSales.Text & "','" & txtDriver.Text & "')"
                    Proses.ExecuteNonQuery(SQl)
                    For baris As Integer = 0 To DGV.RowCount - 2
                        SQl = "Insert into tblGdReturDetail values('" & txtNoBukti.Text & "','" & DGV.Rows(baris).Cells(2).Value & "','" & rep(DGV.Rows(baris).Cells(3).Value) & "','" & DGV.Rows(baris).Cells(4).Value & "','" & DGV.Rows(baris).Cells(5).Value & "','" & DGV.Rows(baris).Cells(6).Value & "','" & DGV.Rows(baris).Cells(7).Value & "','" & DGV.Rows(baris).Cells(8).Value & "')"
                        Proses.ExecuteNonQuery(SQl)
                    Next baris
                    MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
                    Status = True
                    Call Pengaturan()
                    Call Bersih()
                    DGV.Columns.Clear()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                    SQl = "Delete from tblGdRetur where NoBukti='" & txtNoBukti.Text & "'"
                    Proses.ExecuteNonQuery(SQl)
                    SQl = "Delete from tblGdReturDetail where NoBukti='" & txtNoBukti.Text & "'"
                    Proses.ExecuteNonQuery(SQl)
                End Try
            End If
        Else
            Try
                If MsgBox("Yakin akan update", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pilihan") = MsgBoxResult.Yes Then
                    SQl = "update tblGdRetur set KdCust='" & txtKdCust.Text & "',NmCust='" & txtCust.Text & "',tanggal='" & DTTanggal.Text & "',NoFaktur='" & txtNoFak.Text & "',Sales='" & txtSales.Text & "',Driver='" & txtDriver.Text & "' where NoBukti='" & txtNoBukti.Text & "'"
                    Proses.ExecuteNonQuery(SQl)
                    'Proses penyimpanan detail transaksi dengan SqlCommandBuilder
                    cmdbl = New SqlCommandBuilder(adap)
                    adap.Update(ds, "Detail")
                    MsgBox("Update data berhasil dilakukan", MsgBoxStyle.Information, "Konfirmasi")
                    Status = True
                    edit = False
                    Call Pengaturan()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub BtCari_Click(sender As Object, e As EventArgs) Handles BtCari.Click
        FrmHisRetur.Show()
        FrmHisRetur.Focus()
    End Sub

    Private Sub BtEdit_Click(sender As Object, e As EventArgs) Handles BtEdit.Click
        Status = False
        Call Pengaturan()
    End Sub

    Private Sub BtHapus_Click(sender As Object, e As EventArgs) Handles BtHapus.Click
        Try
            SQl = "delete from tblGdRetur where nobukti='" & txtNoBukti.Text & "'"
            Proses.ExecuteNonQuery(SQl)
            SQl = "delete from tblGdReturDetail where nobukti='" & txtNoBukti.Text & "'"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Hapus berhasil...", MsgBoxStyle.Information, "Konfirmasi")
            edit = False
            Status = True
            Call Pengaturan()
            Call Bersih()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub txtNoBukti_TextChanged(sender As Object, e As EventArgs) Handles txtNoBukti.TextChanged
        Select Case edit
            Case True
                Try
                    DGV.Columns.Clear()
                    con = New SqlConnection
                    con.ConnectionString = ("Persist Security Info=True;UID=SA;PWD=;Connect timeout=600;Initial Catalog='" & FrmUtama.DatabaseTextBox.Text & "';Data Source='" & FrmUtama.ServerTextBox.Text & "'")
                    con.Open()
                    adap = New SqlDataAdapter("Select Line,NoBukti,KdBrg,NmBrg,Qty,Satuan,Kondisi,Keterangan,Keterangan2 from tblGdReturDetail where NoBukti='" & txtNoBukti.Text & "'", con)
                    ds = New System.Data.DataSet
                    adap.Fill(ds, "Detail")
                    DGV.DataSource = ds
                    DGV.DataMember = "Detail"
                    Call pengaturanDGVFrmRetur()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            Case False
                DTTanggal.Focus()
        End Select
    End Sub

    Private Sub txtNoFak_Leave(sender As Object, e As EventArgs) Handles txtNoFak.Leave

        Try
            If txtNoFak.Text = "" Then
                MsgBox("Kolom no faktur harus di isi", MsgBoxStyle.Information, "Pesan")
            Else
                Tabel = Proses.ExecuteQuery("SELECT TblFak.NoBukti, TblFak.KdCust, TblFak.NmCust, tblSalesPerson.NMSALES, tblRekapKirim.Supir FROM tblRekapKirim INNER JOIN tblRekapKirimInvoices ON tblRekapKirim.NoBukti = tblRekapKirimInvoices.NoBukti RIGHT OUTER JOIN TblFak INNER JOIN tblSalesPerson ON TblFak.KdSales = tblSalesPerson.KDSALES ON tblRekapKirimInvoices.NoFaktur = TblFak.NoBukti where Tblfak.NoBukti ='" & txtNoFak.Text & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("No faktur tidak ditemukan", MsgBoxStyle.Information, "Konfirmasi")
                    txtKdCust.Text = ""
                    txtCust.Text = ""
                    txtSales.Text = ""
                    txtDriver.Text = ""
                    txtNoFak.Focus()
                Else
                    txtKdCust.Text = Tabel.Rows(0).Item(1)
                    txtCust.Text = Tabel.Rows(0).Item(2)
                    txtSales.Text = Tabel.Rows(0).Item(3)
                    txtDriver.Text = Tabel.Rows(0).Item(4)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class