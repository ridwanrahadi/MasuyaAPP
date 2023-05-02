Imports System.Text
Imports System.Math
Public Class FrmExportTax
    
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
        Dim tanggalfp As Date
        Dim typefp As String
        Dim baris As Integer
        If e.KeyCode = Keys.Enter Then
            Try
                Tabel = Proses.ExecuteQuery("Select TblFak.Tgl,TblFak.Alm1,TblFak.Alm2,TblFak.Alm3, TblFak.NoFP, TblFak.TglFP,TblFak.KdCust,TblFak.ReceivedBy, tblCustomer.NoNpwp, TblFak.NmCust,tblCustomer.NmPkp, tblCustomer.NoKTP, tblCustomer.AlmFP1,tblCustomer.AlmFP2, tblCustomer.AlmFP3, TblFak.Subtotal - TblFak.Discount AS DPP, TblFak.Discount, TblFak.Ppn, TblFak.NoBukti,MONTH(TblFak.TglFP) AS bulan, YEAR(TblFak.TglFP) AS tahun,MONTH(TblFak.Tgl) AS bulanJL,YEAR(TblFak.Tgl) AS tahunJL,TblFak.JnsJualTax,tblFak.StampPBBS FROM  TblFak INNER JOIN tblCustomer ON TblFak.KdCust = tblCustomer.KdCust where nobukti='" & txtNoBukti.Text & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("Nomor bukti tersebut tidak ditemukan", MsgBoxStyle.Exclamation, "Konfirmasi")
                    txtNoBukti.Focus()
                ElseIf Tabel.Rows(0)("NoFP").ToString = "" Then
                    MsgBox("Nomor faktur pajak dengan No : " + txtNoBukti.Text + " belum terisi", MsgBoxStyle.Exclamation, "Konfirmasi")
                Else
                    For i As Integer = 0 To Tabel.Rows.Count - 1
                        With ListView1
                            .Items.Add("FK")
                            With .Items(.Items.Count - 1).SubItems
                                typefp = Tabel.Rows(i)("NoFP").ToString.Remove(2)
                                '//Koreksi apabila ada kesalahan transaksi PPPN & PBBS
                                baris = ListView1.Items.Count - 1
                                If Tabel.Rows(i)("jnsjualtax").ToString = "PPPN" And typefp = "08" Then
                                    .Add("01")
                                    ListView1.Items(baris).BackColor = Color.Red
                                ElseIf Tabel.Rows(i)("jnsjualtax").ToString = "PBBS" And typefp = "01" Then
                                    .Add("08")
                                    ListView1.Items(baris).BackColor = Color.Red
                                Else
                                    .Add(typefp)
                                End If
                                '//
                                .Add("0")
                                .Add(Tabel.Rows(i)("NoFP").ToString.Remove(0, 4).Replace(".", "").Replace("-", ""))
                                .Add(Tabel.Rows(i)("bulan"))
                                .Add(Tabel.Rows(i)("tahun"))
                                tanggalfp = Tabel.Rows(i)("tglFP")
                                .Add((Format(tanggalfp, "dd/MM/yyyy")))
                                .Add(Tabel.Rows(i)("NoNpwp"))
                                '//Apabila cust tokuhai/walkin dan sample tampilkan nama customernya
                                If Tabel.Rows(i)("KdCust") = "WALKIN" Or Tabel.Rows(i)("KdCust") = "SAMPLEMT" Or Tabel.Rows(i)("KdCust") = "SAMPLEFS" Or Tabel.Rows(i)("KdCust") = "SAMPLEGT" Or Tabel.Rows(i)("KdCust") = "SAMPLE" Or Tabel.Rows(i)("KdCust") = "TOKU" Or Tabel.Rows(i)("KdCust") = "BLIOL" Then
                                    .Add(Tabel.Rows(i)("ReceivedBy") & "#NIK#NAMA#" & Tabel.Rows(i)("NmCust")) '//Penggabungan No Refer KTP Customer TOKU
                                    .Add(Tabel.Rows(i)("NmCust"))
                                    .Add(Tabel.Rows(i)("Alm1") & " " & Tabel.Rows(i)("Alm2") & " " & Tabel.Rows(i)("Alm3"))
                                    If Tabel.Rows(i)("ReceivedBy") = "" Then
                                        MsgBox("No Faktur = " + Tabel.Rows(i)("NoBukti") + " tidak terdapat no KTP", MsgBoxStyle.Exclamation, "Konfirmasi")
                                        ListView1.Items(baris).BackColor = Color.LightYellow
                                    End If
                                    '//

                                ElseIf Tabel.Rows(i)("NoNpwp") = "" Then
                                    .Add(Tabel.Rows(i)("NoKTP") & "#NIK#NAMA#" & Tabel.Rows(i)("NmPkp")) '//Penggabungan No Refer KTP Customer teregister
                                    .Add(Tabel.Rows(i)("NmPkp"))
                                    .Add(Tabel.Rows(i)("AlmFP1") & " " & Tabel.Rows(i)("AlmFP2") & " " & Tabel.Rows(i)("AlmFP3"))
                                Else
                                    .Add(Tabel.Rows(i)("NmPkp"))
                                    .Add("Delete after edit")
                                    .Add(Tabel.Rows(i)("AlmFP1") & " " & Tabel.Rows(i)("AlmFP2") & " " & Tabel.Rows(i)("AlmFP3"))
                                End If
                                '//
                                .Add(Int(Tabel.Rows(i)("DPP")))
                                If typefp = "08" Then
                                    If (Tabel.Rows(i)("bulanJL")) < 4 And (Tabel.Rows(i)("tahunJL")) = 2022 Then
                                        .Add(Int(Tabel.Rows(i)("DPP") * 0.1)) '//Jumlah PPN 10%
                                    Else
                                        .Add(Int(Tabel.Rows(i)("DPP") * 0.11)) '//Jumlah PPN 11%
                                    End If
                                    .Add("0")
                                    If Not IsDBNull(Tabel.Rows(i)("StampPBBS")) Then
                                        .Add(Tabel.Rows(i)("StampPBBS"))
                                    Else
                                        .Add("Stempel Kosong")
                                    End If
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                ElseIf typefp = "07" Then
                                    .Add(Int(Tabel.Rows(i)("Ppn"))) '// Jumlah PPN
                                    .Add("0")
                                    .Add("1")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                Else
                                    .Add(Int(Tabel.Rows(i)("Ppn"))) '// Jumlah PPN
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                End If
                                .Add("3-" & Tabel.Rows(i)("nobukti"))
                            End With
                        End With
                    Next
                    Tabel = Proses.ExecuteQuery("SELECT TblFak.NoBukti,MONTH(TblFak.Tgl) AS bulan,YEAR(TblFak.Tgl) AS tahun, TblFakDtl.KdBrg, TblFakDtl.NmBrg, TblFakDtl.Qty, TblFakDtl.HrgNet, TblFakDtl.Jumlah, TblFak.PrsDisc1,TblFak.PrsPpn FROM TblFak INNER JOIN TblFakDtl ON TblFak.NoBukti = TblFakDtl.NoBukti where TblFak.NoBukti='" & txtNoBukti.Text & "'")
                    For i As Integer = 0 To Tabel.Rows.Count - 1
                        With ListView1
                            .Items.Add("OF")
                            With .Items(.Items.Count - 1).SubItems
                                Dim discount, hrgnet, ppn As Decimal
                                discount = Tabel.Rows(i)("jumlah") * (Tabel.Rows(i)("PrsDisc1") / 100)
                                hrgnet = Tabel.Rows(i)("jumlah") - discount
                                If (Tabel.Rows(i)("bulan")) < 4 And (Tabel.Rows(i)("tahun")) = 2022 Then
                                    ppn = Round(Val(hrgnet) * 0.1, 2)
                                Else
                                    ppn = Round(Val(hrgnet) * 0.11, 2)
                                End If
                                .Add("1" & Tabel.Rows(i)("kdbrg"))
                                .Add(Tabel.Rows(i)("nmbrg"))
                                .Add(Tabel.Rows(i)("hrgnet"))
                                .Add(Tabel.Rows(i)("qty"))
                                .Add(Tabel.Rows(i)("jumlah"))
                                .Add(discount) '// Jumlah Discount bawah
                                .Add(hrgnet) '// Harga setelah discount
                                .Add(ppn) '//ppn harga net
                                .Add("Delete sebelum upload")
                                .Add("0")
                                .Add("0")
                                .Add("3-" & Tabel.Rows(i)("nobukti"))
                            End With
                        End With
                    Next
                End If
                txtNoBukti.Text = ""
                txtNoBukti.Focus()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub



    Private Sub BtCopy_Click(sender As Object, e As EventArgs) Handles BtCopy.Click
        For i As Integer = 0 To ListView1.Items.Count - 1
            Me.ListView1.Items(i).Selected = True
        Next
        Clipboard.Clear() ' empty the clipboard
        Dim build As New System.Text.StringBuilder, row As New List(Of String)

        For Each item As ListViewItem In ListView1.SelectedItems
            For Each subitems As ListViewItem.ListViewSubItem In item.SubItems
                row.Add(subitems.Text)
            Next
            build.AppendLine(String.Join(vbTab, row.ToArray))
            row.Clear()
        Next
        Clipboard.SetText(build.ToString)
        MsgBox("Copy berhasil dilakukan", MsgBoxStyle.Information, "Konfirmasi")
    End Sub
    Private Sub BtClear_Click(sender As Object, e As EventArgs) Handles BtClear.Click
        If MsgBox("Apakah anda yakin akan membersihkan data list ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pilihan") = MsgBoxResult.Yes Then
            ListView1.Items.Clear()
        End If

    End Sub

    Private Sub BtImport_Click(sender As Object, e As EventArgs) Handles BtImport.Click
        Call openfile()
    End Sub

    Private Sub BtProses_Click(sender As Object, e As EventArgs) Handles BtProses.Click
        Dim tanggalfp As Date
        Dim typefp As String
        Dim baris As Integer
        For r As Integer = 0 To DGV.RowCount - 1
            Try
                Tabel = Proses.ExecuteQuery("Select TblFak.Tgl,TblFak.Alm1,TblFak.Alm2,TblFak.Alm3, TblFak.NoFP, TblFak.TglFP,TblFak.KdCust,TblFak.ReceivedBy, tblCustomer.NoNpwp, TblFak.NmCust,tblCustomer.NmPkp, tblCustomer.NoKTP, tblCustomer.AlmFP1,tblCustomer.AlmFP2, tblCustomer.AlmFP3, TblFak.Subtotal - TblFak.Discount AS DPP, TblFak.Discount, TblFak.Ppn, TblFak.NoBukti,MONTH(dbo.TblFak.TglFP) AS bulan, YEAR(dbo.TblFak.TglFP) AS tahun,MONTH(TblFak.Tgl) AS bulanJL,YEAR(TblFak.Tgl) AS tahunJL,TblFak.JnsJualTax,tblFak.StampPBBS FROM  TblFak INNER JOIN tblCustomer ON TblFak.KdCust = tblCustomer.KdCust where nobukti='" & DGV.Rows(r).Cells(0).Value & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("Data Nomor Transaksi= " & DGV.Rows(r).Cells(0).Value & " tidak ditemukan")
                    Me.DGV.Rows(r).DefaultCellStyle.BackColor = Color.Red
                ElseIf Tabel.Rows(0)("NoFP").ToString = "" Then
                    MsgBox("Nomor faktur pajak dengan No : " + DGV.Rows(r).Cells(0).Value + " belum terisi", MsgBoxStyle.Exclamation, "Konfirmasi")
                    Me.DGV.Rows(r).DefaultCellStyle.BackColor = Color.Red
                Else
                    For i As Integer = 0 To Tabel.Rows.Count - 1
                        With ListView1
                            .Items.Add("FK")
                            With .Items(.Items.Count - 1).SubItems
                                typefp = Tabel.Rows(i)("NoFP").ToString.Remove(2)
                                '//Koreksi apabila ada kesalahan transaksi PPPN & PBBS
                                baris = ListView1.Items.Count - 1
                                If Tabel.Rows(i)("jnsjualtax").ToString = "PPPN" And typefp = "08" Then
                                    .Add("01")
                                    ListView1.Items(baris).BackColor = Color.Red
                                ElseIf Tabel.Rows(i)("jnsjualtax").ToString = "PBBS" And typefp = "01" Then
                                    .Add("08")
                                    ListView1.Items(baris).BackColor = Color.Red
                                Else
                                    .Add(typefp)
                                End If
                                '//
                                .Add("0")
                                .Add(Tabel.Rows(i)("NoFP").ToString.Remove(0, 4).Replace(".", "").Replace("-", ""))
                                .Add(Tabel.Rows(i)("bulan"))
                                .Add(Tabel.Rows(i)("tahun"))
                                tanggalfp = Tabel.Rows(i)("tglFP")
                                .Add((Format(tanggalfp, "dd/MM/yyyy")))
                                .Add(Tabel.Rows(i)("NoNpwp"))
                                '//Apabila cust tokuhai/walkin dan sample tampilkan nama customernya
                                If Tabel.Rows(i)("KdCust") = "WALKIN" Or Tabel.Rows(i)("KdCust") = "SAMPLEMT" Or Tabel.Rows(i)("KdCust") = "SAMPLEFS" Or Tabel.Rows(i)("KdCust") = "SAMPLEGT" Or Tabel.Rows(i)("KdCust") = "SAMPLE" Or Tabel.Rows(i)("KdCust") = "TOKU" Or Tabel.Rows(i)("KdCust") = "BLIOL" Then
                                    .Add(Tabel.Rows(i)("ReceivedBy") & "#NIK#NAMA#" & Tabel.Rows(i)("NmCust")) '//Penggabungan No Refer KTP Customer TOKU
                                    .Add(Tabel.Rows(i)("NmCust"))
                                    .Add(Tabel.Rows(i)("Alm1") & " " & Tabel.Rows(i)("Alm2") & " " & Tabel.Rows(i)("Alm3"))
                                    If Tabel.Rows(i)("ReceivedBy") = "" Then
                                        MsgBox("No Faktur = " + Tabel.Rows(i)("NoBukti") + " tidak terdapat no KTP", MsgBoxStyle.Exclamation, "Konfirmasi")
                                        ListView1.Items(baris).BackColor = Color.LightYellow
                                    End If
                                    '//
                                ElseIf Tabel.Rows(i)("NoNpwp") = "" Then
                                    .Add(Tabel.Rows(i)("NoKTP") & "#NIK#NAMA#" & Tabel.Rows(i)("NmPkp")) '//Penggabukan No Refer KTP Customer teregister
                                    .Add(Tabel.Rows(i)("NmPkp"))
                                    .Add(Tabel.Rows(i)("AlmFP1") & " " & Tabel.Rows(i)("AlmFP2") & " " & Tabel.Rows(i)("AlmFP3"))
                                Else
                                    .Add(Tabel.Rows(i)("NmPkp"))
                                    .Add("Delete after edit")
                                    .Add(Tabel.Rows(i)("AlmFP1") & " " & Tabel.Rows(i)("AlmFP2") & " " & Tabel.Rows(i)("AlmFP3"))
                                End If
                                '//
                                .Add(Int(Tabel.Rows(i)("DPP")))
                                If typefp = "08" Then
                                    If (Tabel.Rows(i)("bulanJL")) < 4 And (Tabel.Rows(i)("tahunJL")) = 2022 Then
                                        .Add(Int(Tabel.Rows(i)("DPP") * 0.1)) '//Jumlah PPN 10%
                                    Else
                                        .Add(Int(Tabel.Rows(i)("DPP") * 0.11)) '//Jumlah PPN 11%
                                    End If
                                    .Add("0")
                                    If Not IsDBNull(Tabel.Rows(i)("StampPBBS")) Then
                                        .Add(Tabel.Rows(i)("StampPBBS"))
                                    Else
                                        .Add("Stempel Kosong")
                                    End If
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                ElseIf typefp = "07" Then
                                    .Add(Int(Tabel.Rows(i)("Ppn"))) '//Jumlah PPN
                                    .Add("0")
                                    .Add("1")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                Else
                                    .Add(Int(Tabel.Rows(i)("Ppn"))) '//Jumlah PPN
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                End If
                                .Add("3-" & Tabel.Rows(i)("nobukti"))
                            End With
                        End With
                    Next
                    Tabel = Proses.ExecuteQuery("SELECT TblFak.NoBukti,MONTH(TblFak.Tgl) AS bulan,YEAR(TblFak.Tgl) AS tahun, TblFakDtl.KdBrg, TblFakDtl.NmBrg, TblFakDtl.Qty, TblFakDtl.HrgNet, TblFakDtl.Jumlah, TblFak.PrsDisc1,TblFak.PrsPpn FROM TblFak INNER JOIN TblFakDtl ON TblFak.NoBukti = TblFakDtl.NoBukti where TblFak.NoBukti='" & DGV.Rows(r).Cells(0).Value & "'")
                    Dim bulan, tahun As Integer
                    bulan = (Tabel.Rows(0)("bulan"))
                    tahun = (Tabel.Rows(0)("tahun"))
                    For i As Integer = 0 To Tabel.Rows.Count - 1
                        With ListView1
                            .Items.Add("OF")
                            With .Items(.Items.Count - 1).SubItems
                                Dim discount, hrgnet, ppn As Decimal
                                discount = Tabel.Rows(i)("jumlah") * (Tabel.Rows(i)("PrsDisc1") / 100)
                                hrgnet = Tabel.Rows(i)("jumlah") - discount
                                If bulan < 4 And tahun = 2022 Then
                                    ppn = Round(Val(hrgnet) * 0.1, 2)
                                Else
                                    ppn = Round(Val(hrgnet) * 0.11, 2)
                                End If
                                .Add("1" & Tabel.Rows(i)("kdbrg"))
                                .Add(Tabel.Rows(i)("nmbrg"))
                                .Add(Tabel.Rows(i)("hrgnet"))
                                .Add(Tabel.Rows(i)("qty"))
                                .Add(Tabel.Rows(i)("jumlah"))
                                .Add(discount) '// Jumlah Discount bawah
                                .Add(hrgnet) '// Harga setelah discount
                                .Add(ppn) '//ppn harga net
                                .Add("Delete sebelum upload")
                                .Add("0")
                                .Add("0")
                                .Add("3-" & Tabel.Rows(i)("nobukti"))
                            End With
                        End With
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Next
        MsgBox("Proses berhasil & Selamat untuk anda, Jangan lupa cuci kaki", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

   
End Class