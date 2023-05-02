Public Class FrmExportTaxRB
    Sub openfile()
        Dim filename As String

        With Me.OpenFileDialog1   'untuk mengatur properti pada picture Box

            .Filter = "All File(*.*)|*.*|(*.xlsx)|*.xlsx" ' jenis file yang ‘ditampilkan

            .FilterIndex = 2  'mengatur jenis file default

            .InitialDirectory = "D:\" ' inisial direktori

            .Multiselect = False ' untuk mengatur boleh tidaknya pengambilan ‘lebih dari 1 file

            .DefaultExt = "xlsx"    ' ekstensi default

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                filename = .FileName
                '//Import data dari file excel
                Try
                    Dim MyConnection As System.Data.OleDb.OleDbConnection
                    Dim DtSet As System.Data.DataSet
                    Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
                    MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & filename & "';Extended Properties=Excel 8.0;")
                    MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
                    MyCommand.TableMappings.Add("Table", "Net-informations.com")
                    DtSet = New System.Data.DataSet
                    MyCommand.Fill(DtSet)
                    DGV.DataSource = DtSet.Tables(0)
                    MyConnection.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
                '//
            Else
                MsgBox("Import file dibatalkan", MsgBoxStyle.Information, "Konfirmasi")

            End If
           


        End With
    End Sub
 

    Private Sub txtNoBukti_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNoBukti.KeyDown
        Dim npwp, pkp, kdJenis, FG, NoFP, tglfak, noretur, tglretur, bln, tahun, dpp, ppn, ppnbm As String

        If e.KeyCode = Keys.Enter Then
            If Me.txtNoBukti.Text = "" Then
                MsgBox("Kolom Belum terisi", MsgBoxStyle.Exclamation, "Pesan")
            Else
                Try
                    Tabel = Proses.ExecuteQuery("SELECT Npwp, PKP, NoFp, TglFp, NoReture, tanggal, MONTH(tanggal) AS bulan, YEAR(tanggal) AS tahun, total, ppn FROM TblnotretBL where NoReture = '" & txtNoBukti.Text & "'")
                    If Tabel.Rows.Count = 0 Then
                        MsgBox("Data tidak ditemukan", MsgBoxStyle.Critical, "Konfirmasi")
                    Else
                        With Tabel
                            npwp = Tabel(0).Item("Npwp").ToString.Replace(".", "").Replace("-", "")
                            pkp = Tabel(0).Item("PKP")
                            kdJenis = Tabel(0).Item("NoFp").ToString.Remove(2)
                            FG = Mid(Tabel(0).Item("NoFp").ToString, 3, 1)
                            NoFP = Tabel(0).Item("NoFp").ToString.Remove(0, 4).Replace(".", "").Replace("-", "")
                            tglfak = Tabel(0).Item("TglFp")
                            noretur = Tabel(0).Item("NoReture")
                            tglretur = Tabel(0).Item("Tanggal")
                            bln = Tabel(0).Item("bulan")
                            tahun = Tabel(0).Item("tahun")
                            dpp = Tabel(0).Item("total").ToString.Replace("-", "")
                            ppn = Tabel(0).Item("ppn").ToString.Replace("-", "")
                            ppnbm = "0"
                        End With
                        DGV_DATA.Rows.Add("RM", npwp, pkp, kdJenis, FG, NoFP, tglfak, "1", noretur, tglretur, bln, tahun, dpp, ppn, ppnbm)

                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString())

                End Try

            End If
        End If
    End Sub

    Private Sub BtImport_Click(sender As Object, e As EventArgs) Handles BtImport.Click
        Call openfile()
    End Sub

    Private Sub BtProses_Click(sender As Object, e As EventArgs) Handles BtProses.Click
        Dim npwp, pkp, kdJenis, FG, NoFP, tglfak, noretur, tglretur, bln, tahun, dpp, ppn, ppnbm As String
        For r As Integer = 0 To DGV.RowCount - 1
            Try
                Try
                    Tabel = Proses.ExecuteQuery("SELECT Npwp, PKP, NoFp, TglFp, NoReture, tanggal, MONTH(tanggal) AS bulan, YEAR(tanggal) AS tahun, total, ppn FROM TblnotretBL where NoReture = '" & DGV.Rows(r).Cells(0).Value & "'")
                    If Tabel.Rows.Count = 0 Then
                        DGV_DATA.Rows.Add("RM", "0", "0", "0", "0", "0", "0", "0", DGV.Rows(r).Cells(0).Value, "0", "0", "0", "0", "0", "0")
                    Else
                        With Tabel
                            NPWP = Tabel(0).Item("Npwp").ToString.Replace(".", "").Replace("-", "")
                            pkp = Tabel(0).Item("PKP")
                            kdJenis = Tabel(0).Item("NoFp").ToString.Remove(2)
                            FG = Mid(Tabel(0).Item("NoFp").ToString, 3, 1)
                            NoFP = Tabel(0).Item("NoFp").ToString.Remove(0, 4).Replace(".", "").Replace("-", "")
                            tglfak = Tabel(0).Item("TglFp")
                            noretur = Tabel(0).Item("NoReture")
                            tglretur = Tabel(0).Item("Tanggal")
                            bln = Tabel(0).Item("bulan")
                            tahun = Tabel(0).Item("tahun")
                            dpp = Tabel(0).Item("total").ToString.Replace("-", "")
                            ppn = Tabel(0).Item("ppn").ToString.Replace("-", "")
                            ppnbm = "0"
                        End With
                        DGV_DATA.Rows.Add("RM", npwp, pkp, kdJenis, FG, NoFP, tglfak, "1", noretur, tglretur, bln, tahun, dpp, ppn, ppnbm)
                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            Catch ex As Exception

            End Try
        Next
        MsgBox("Selesai", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub BtClear_Click(sender As Object, e As EventArgs) Handles BtClear.Click
        DGV_DATA.Rows.Clear()
    End Sub

    Private Sub FrmExportTaxRB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Text = "Form Nota Retur Beli - Export" Then
            txtNoBukti.Text = FrmNotRetBl.txtnoret.Text
        End If
    End Sub
End Class