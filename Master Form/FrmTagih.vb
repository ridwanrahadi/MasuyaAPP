Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class FrmTagih
    Public cmdbl As SqlCommandBuilder
    Public adap As SqlDataAdapter
    Public ds As DataSet
    Public con As SqlConnection
    Sub Cari1()
        Try
            Tabel = Proses.ExecuteQuery("Select  tblArTagih.NoBukti, tblCustomer.NmCust, tblArTagih.Total FROM tblArTagih INNER JOIN tblCustomer ON tblArTagih.KdCust = tblCustomer.KdCust  where tblArTagih.NoBukti='" & DGVKw.Rows(0).Cells(0).Value & "'")
            If Tabel.Rows.Count = 0 Then
                MsgBox("No KW tidak ditemukan...", MsgBoxStyle.Exclamation, "Konfirmasi")


            Else

            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Sub Cari2()
        Try
            Tabel = Proses.ExecuteQuery("Select  NoBukti,NmCust,Total,bayar from tblfak where NoBukti='" & DGVKw.Rows(0).Cells(0).Value & "'")
            If Tabel.Rows.Count = 0 Then
                MsgBox("No JL tidak ditemukan...", MsgBoxStyle.Exclamation, "Konfirmasi")

            Else

            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub


    Private Sub FrmTagih_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NmKolektxt.ReadOnly = True
        BtBaru.Enabled = True
        BtKembali.Enabled = False
        BtSimpan.Enabled = False
        BtEdit.Enabled = False
        NmKolektxt.Focus()
        DGVKw.ReadOnly = True

    End Sub

    Private Sub BtCari1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Call Cari1()

    End Sub
    Private Sub BtPrintKw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPrintKw.Click
        
        FrmReportTagih.tblTagihBindingSource.Filter = "(NoTran='" & NoTrans.Text & "')"
        FrmReportTagih.Show()

    End Sub

    Private Sub BtBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtBaru.Click
        NoTrans.Text = "Auto"
        NoTrans.ReadOnly = False
        DGVKw.DataSource = Nothing
        DGVKw.ColumnCount = 5
        DGVKw.Columns(0).Visible = False
        DGVKw.Columns(1).Visible = False
        DGVKw.Columns(2).HeaderText = "No Bukti"
        DGVKw.Columns(3).HeaderText = "Customer"
        DGVKw.Columns(4).HeaderText = "Total"
        KW.Checked = False
        JL.Checked = False
        NmKolektxt.Text = ""
        NmKolektxt.ReadOnly = False
        BtKembali.Enabled = True
        BtSimpan.Enabled = True
        BtBaru.Enabled = False
        BtEdit.Enabled = False
        DGVKw.ReadOnly = False
        DGVKw.Rows.Clear()
        NmKolektxt.Focus()
    End Sub

    Private Sub BtKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtKembali.Click
        NmKolektxt.Text = ""
        DGVKw.DataSource = Nothing
        DGVKw.ReadOnly = True
        BtBaru.Enabled = True
        BtSimpan.Enabled = False
        BtEdit.Enabled = False
        NoTrans.Text = ""
        NmKolektxt.Focus()
        DGVKw.ColumnCount = 0
    End Sub

    Private Sub BtSimpan_Click(sender As Object, e As EventArgs) Handles BtSimpan.Click
        Dim tanggal As String
        tanggal = Now.Date()
        If NmKolektxt.Text = "" Then
            MsgBox("Isi nama kolektor", MsgBoxStyle.Information, "Konfirmasi")
        Else
            Try
                NoTrans.Text = Kode.Generate("tblTagih", "NoTran")
                For baris As Integer = 0 To DGVKw.RowCount - 2
                    SQl = "insert into tblTagih Values('" & NoTrans.Text & "','" & DGVKw.Rows(baris).Cells(2).Value & "','" & DGVKw.Rows(baris).Cells(3).Value & "','" & DGVKw.Rows(baris).Cells(4).Value & "','" & NmKolektxt.Text & "','" & tanggal & "')"
                    Proses.ExecuteNonQuery(SQl)
                Next baris
                MsgBox("Data berhasil di simpan", MsgBoxStyle.Information, "Konfirmasi")
                NmKolektxt.ReadOnly = True
                NoTrans.ReadOnly = True
                DGVKw.ReadOnly = True
                BtBaru.Enabled = True
                BtSimpan.Enabled = False
                BtKembali.Enabled = False
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub

    Private Sub DGVKw_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVKw.CellEndEdit
        If KW.Checked Then
            If e.ColumnIndex = 2 Then
                Tabel = Proses.ExecuteQuery("Select  tblArTagih.NoBukti, tblCustomer.NmCust, tblArTagih.Total FROM tblArTagih INNER JOIN tblCustomer ON tblArTagih.KdCust = tblCustomer.KdCust  where tblArTagih.NoBukti='" & DGVKw.Rows(e.RowIndex).Cells(2).Value & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("No KW tidak ditemukan...", MsgBoxStyle.Exclamation, "Konfirmasi")
                    DGVKw.Rows(e.RowIndex).Cells(3).Value = ""
                    DGVKw.Rows(e.RowIndex).Cells(4).Value = ""
                Else
                    DGVKw.Rows(e.RowIndex).Cells(3).Value = Tabel(0).Item(1)
                    DGVKw.Rows(e.RowIndex).Cells(4).Value = Tabel(0).Item(2)
                    DGVKw.Rows(e.RowIndex).Cells(0).Value = NoTrans.Text
                End If
            End If
        ElseIf JL.Checked Then
            If e.ColumnIndex = 2 Then
                Tabel = Proses.ExecuteQuery("Select  NoBukti,NmCust,Total,bayar from tblfak where NoBukti='" & DGVKw.Rows(e.RowIndex).Cells(2).Value & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("No JL tidak ditemukan...", MsgBoxStyle.Exclamation, "Konfirmasi")
                    DGVKw.Rows(e.RowIndex).Cells(3).Value = ""
                    DGVKw.Rows(e.RowIndex).Cells(4).Value = ""
                Else
                    DGVKw.Rows(e.RowIndex).Cells(3).Value = Tabel(0).Item(1)
                    DGVKw.Rows(e.RowIndex).Cells(4).Value = Tabel(0).Item(2) - Tabel(0).Item(3)
                    DGVKw.Rows(e.RowIndex).Cells(0).Value = NoTrans.Text
                End If
            End If
        Else
            MsgBox("Pilih salah satu transaksi", MsgBoxStyle.Exclamation, "Konfirmasi")
            DGVKw.Rows(e.RowIndex).Cells(2).Value = ""
        End If
    End Sub


    Private Sub DGVKw_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGVKw.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub


    Private Sub BtEdit_Click(sender As Object, e As EventArgs) Handles BtEdit.Click

        Try
            If MsgBox("Yakin akan update", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pilihan") = MsgBoxResult.Yes Then
                cmdbl = New SqlCommandBuilder(adap)
                adap.Update(ds, "Detail")
                MsgBox("Update data berhasil dilakukan", MsgBoxStyle.Information, "Konfirmasi")
                NmKolektxt.ReadOnly = True
                NoTrans.ReadOnly = False
                DGVKw.ReadOnly = True
                BtBaru.Enabled = True
                BtSimpan.Enabled = False
                BtKembali.Enabled = False
                BtEdit.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        FrmHisTagihan.Show()
    End Sub

   
    Private Sub NoTrans_KeyDown(sender As Object, e As KeyEventArgs) Handles NoTrans.KeyDown
        If e.KeyCode = Keys.Enter Then
            DGVKw.ReadOnly = False
            ' Try
            'Tabel = Proses.ExecuteQuery("Select NoBukti,Customer,Total from tblTagih where NoTran='" & NoTrans.Text & "'")
            'DGVKw.DataSource = Tabel
            'DGVKw.Columns(0).HeaderText = "No Bukti"
            'DGVKw.Columns(1).HeaderText = "Nama Customer"
            'DGVKw.Columns(2).HeaderText = "Total"
            'Catch ex As Exception
            'MsgBox(ex.ToString())
            'End Try
            'BtSimpan.Enabled = False
            'BtKembali.Enabled = True
            'BtEdit.Enabled = True
            Try
                DGVKw.Columns.Clear()
                con = New SqlConnection
                con.ConnectionString = ("Persist Security Info=True;UID=SA;PWD=Shield@1945;Connect timeout=600;Initial Catalog='" & FrmUtama.DatabaseTextBox.Text & "';Data Source='" & FrmUtama.ServerTextBox.Text & "'")
                con.Open()
                adap = New SqlDataAdapter("Select NoTran,line,nobukti,customer,total from tblTagih where NoTran='" & NoTrans.Text & "'", con)
                ds = New System.Data.DataSet
                adap.Fill(ds, "Detail")
                DGVKw.DataSource = ds
                DGVKw.DataMember = "Detail"
                BtSimpan.Enabled = False
                BtKembali.Enabled = True
                BtEdit.Enabled = True
                DGVKw.Columns(2).HeaderText = "No Bukti"
                DGVKw.Columns(3).HeaderText = "Nama Customer"
                DGVKw.Columns(4).HeaderText = "Total"
                DGVKw.Columns(0).Visible = False
                DGVKw.Columns(1).Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            BtSimpan.Enabled = False
            BtKembali.Enabled = True
            BtEdit.Enabled = True
        End If
       
    End Sub

   
    
End Class