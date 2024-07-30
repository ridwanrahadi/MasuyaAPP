Imports System.Text
Imports System.Math
Imports Microsoft.Office.Interop
Public Class FrmExportTax
    Dim tanggalfp As Date
    Dim tanggalinv As Date
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
        Dim typefp, typefpGanti As String
        Dim baris, row As Integer
        Dim PpnSys As Double
        Dim sysinfo As DataTable
        If e.KeyCode = Keys.Enter Then
            row = 1
            Try
                sysinfo = Proses.ExecuteQuery("select PrsPpn from tblSysInfo")
                Tabel = Proses.ExecuteQuery("Select TblFak.Tgl,TblFak.Alm1,TblFak.Alm2,TblFak.Alm3, TblFak.NoFP, TblFak.TglFP,TblFak.KdCust,TblFak.ReceivedBy, tblCustomer.NoNpwp, TblFak.NmCust,tblCustomer.NmPkp, tblCustomer.NoKTP, tblCustomer.Kontak, tblCustomer.AlmFP1,tblCustomer.AlmFP2, tblCustomer.AlmFP3, tblCustomer.isNameEditable, tblCustomer.KdOutlet, TblFak.Subtotal - TblFak.Discount AS DPP, TblFak.Discount, TblFak.Ppn, TblFak.PrsPpn, TblFak.NoBukti,MONTH(TblFak.TglFP) AS bulan, YEAR(TblFak.TglFP) AS tahun,MONTH(TblFak.Tgl) AS bulanJL,YEAR(TblFak.Tgl) AS tahunJL,TblFak.JnsJualTax,tblFak.StampPBBS FROM  TblFak INNER JOIN tblCustomer ON TblFak.KdCust = tblCustomer.KdCust where nobukti='" & txtNoBukti.Text & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("Nomor bukti tersebut tidak ditemukan", MsgBoxStyle.Exclamation, "Konfirmasi")
                    txtNoBukti.Text = ""
                    txtNoBukti.Focus()
                ElseIf Tabel.Rows(0)("NoFP").ToString = "" Then
                    MsgBox("Nomor faktur pajak dengan No : " + txtNoBukti.Text + " belum terisi", MsgBoxStyle.Exclamation, "Konfirmasi")
                Else

                    For i As Integer = 0 To Tabel.Rows.Count - 1
                        'Menentukan PPN dari tblFak atau dari tblSysInfo
                        If Tabel.Rows(i)("jnsjualtax").ToString = "PBBS" Then
                            PpnSys = sysinfo.Rows(0).Item("PrsPpn")
                        Else
                            PpnSys = Tabel.Rows(i).Item("PrsPpn")
                        End If
                        With ListView1
                            .Items.Add("FK")
                            With .Items(.Items.Count - 1).SubItems
                                typefp = Tabel.Rows(i)("NoFP").ToString.Remove(2)
                                typefpGanti = Mid(Tabel.Rows(i)("NoFP").ToString, 3, 1)
                                '//Koreksi apabila ada kesalahan transaksi PPPN & PBBS
                                baris = ListView1.Items.Count - 1
                                If Tabel.Rows(i)("jnsjualtax").ToString = "PPPN" And typefp = "08" Then
                                    .Add("'" & "01")
                                    ListView1.Items(baris).BackColor = Color.Red
                                ElseIf Tabel.Rows(i)("jnsjualtax").ToString = "PBBS" And typefp = "01" Then
                                    .Add("'" & "08")
                                    ListView1.Items(baris).BackColor = Color.Red
                                Else
                                    .Add("'" & typefp)
                                End If
                                '//
                                .Add(typefpGanti)
                                .Add("'" & Tabel.Rows(i)("NoFP").ToString.Remove(0, 4).Replace(".", "").Replace("-", ""))
                                .Add(Tabel.Rows(i)("bulan"))
                                .Add(Tabel.Rows(i)("tahun"))
                                tanggalfp = Tabel.Rows(i)("tglFP")
                                .Add((Format(tanggalfp, "dd/MM/yyyy")))
                                '//Apabila cust tokuhai/walkin dan sample tampilkan nama customernya
                                If Tabel.Rows(i)("isNameEditable") = True And Tabel.Rows(i)("KdOutlet") <> "OL1" Then

                                    If Tabel.Rows(i)("ReceivedBy") = "" Then
                                        MsgBox("No Faktur = " + Tabel.Rows(i)("NoBukti") + " tidak terdapat no KTP", MsgBoxStyle.Exclamation, "Konfirmasi")
                                        ListView1.Items(baris).BackColor = Color.LightYellow
                                        .Add("KTP tidak ada")
                                    Else
                                        .Add("'" & Tabel.Rows(i)("ReceivedBy")) 'kolom bantuan untuk formula No KTP / NPWP
                                    End If
                                    .Add(Tabel.Rows(i)("NmCust"))
                                    .Add("Delete sebelum upload")
                                    .Add(Tabel.Rows(i)("Alm1") & " " & Tabel.Rows(i)("Alm2") & " " & Tabel.Rows(i)("Alm3"))
                                ElseIf Tabel.Rows(i)("KdOutlet") = "OL1" Then
                                    'Penjualan Online
                                    .Add("0") 'No NPWP di anggap 0
                                    .Add("0#PASPOR#NAMA#" & Tabel.Rows(i)("NmCust"))
                                    .Add(Tabel.Rows(i)("NmCust"))
                                    .Add(Tabel.Rows(i)("Alm1") & " " & Tabel.Rows(i)("Alm2") & " " & Tabel.Rows(i)("Alm3"))
                                    '//
                                ElseIf Tabel.Rows(i)("NoNpwp") = "" Or Tabel.Rows(i)("NoNpwp") = "0" Then 'Pemisah customer register PKP atau perorangan
                                    'Cust PKP / Perorangan
                                    .Add("'" & Tabel.Rows(i)("NoKTP"))
                                    .Add(Tabel.Rows(i)("Kontak"))
                                    .Add(Tabel.Rows(i)("NmPkp"))
                                    .Add(Tabel.Rows(i)("AlmFP1") & " " & Tabel.Rows(i)("AlmFP2") & " " & Tabel.Rows(i)("AlmFP3"))
                                Else
                                    'Cust PKP
                                    .Add("'" & Tabel.Rows(i)("NoNpwp")) 'kolom bantuan untuk formula No KTP / NPWP
                                    .Add(Tabel.Rows(i)("NmPkp"))
                                    tanggalinv = Tabel.Rows(i)("Tgl")
                                    If tanggalfp <> tanggalinv Then
                                        ListView1.Items(baris).BackColor = Color.Yellow
                                        .Add("tanggal FP DAN INV berbeda")
                                    Else
                                        .Add("")
                                    End If
                                    .Add(Tabel.Rows(i)("AlmFP1") & " " & Tabel.Rows(i)("AlmFP2") & " " & Tabel.Rows(i)("AlmFP3"))
                                End If
                                '.Add(Round(Val(Tabel.Rows(i)("DPP"))))
                                .Add(Int(Tabel.Rows(i)("DPP"))) '//Jumlah DPP
                                If typefp = "08" Then
                                    ' .Add(Round(Val(Tabel.Rows(i)("DPP") * PpnSys / 100))) '//Jumlah PPN 11%
                                    .Add(Int(Tabel.Rows(i)("DPP") * PpnSys / 100)) '//Jumlah PPN 11%
                                    .Add("0")
                                    If Not IsDBNull(Tabel.Rows(i)("StampPBBS")) Then
                                        .Add(Tabel.Rows(i)("StampPBBS"))
                                    Else
                                        .Add("Stempel Kosong")
                                        ListView1.Items(baris).BackColor = Color.Yellow
                                    End If
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                ElseIf typefp = "07" Then
                                    '.Add(Round(Val(Tabel.Rows(i)("Ppn")))) '// Jumlah PPN
                                    .Add(Int(Tabel.Rows(i)("DPP") * PpnSys / 100)) '//Jumlah PPN 11%
                                    .Add("0")
                                    .Add("1")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                Else
                                    '.Add(Round(Val(Tabel.Rows(i)("Ppn")))) '// Jumlah PPN
                                    .Add(Int(Tabel.Rows(i)("Ppn"))) '//Jumlah PPN
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                End If
                                .Add("3-" & Tabel.Rows(i)("NoBukti"))
                            End With
                        End With
                    Next
                    Tabel = Proses.ExecuteQuery("SELECT TblFak.NoBukti,MONTH(TblFak.Tgl) AS bulan,YEAR(TblFak.Tgl) AS tahun, TblFakDtl.KdBrg, TblFakDtl.NmBrg, TblFakDtl.Qty, TblFakDtl.HrgNet, TblFakDtl.Jumlah, TblFak.PrsDisc1,TblFak.PrsPpn FROM TblFak INNER JOIN TblFakDtl ON TblFak.NoBukti = TblFakDtl.NoBukti where TblFak.NoBukti='" & txtNoBukti.Text & "'")
                    For i As Integer = 0 To Tabel.Rows.Count - 1
                        With ListView1
                            .Items.Add("OF")
                            With .Items(.Items.Count - 1).SubItems
                                Dim discount, jumlahnet, ppn As Decimal
                                discount = Tabel.Rows(i)("jumlah") * (Tabel.Rows(i)("PrsDisc1") / 100)
                                'jumlahnet = Round(Val(Tabel.Rows(i)("jumlah") - discount))
                                jumlahnet = (Tabel.Rows(i)("jumlah") - discount)
                                ppn = jumlahnet * (PpnSys / 100)
                                .Add("1" & Tabel.Rows(i)("kdbrg"))
                                .Add(Tabel.Rows(i)("nmbrg"))
                                .Add(Tabel.Rows(i)("hrgnet"))
                                .Add(Tabel.Rows(i)("qty"))
                                '.Add(Round(Val(Tabel.Rows(i)("jumlah"))))
                                .Add(Tabel.Rows(i)("jumlah"))
                                .Add(discount) '// Jumlah Discount bawah
                                .Add(jumlahnet) '// Harga setelah discount
                                .Add(ppn) '//ppn harga net
                                .Add("Delete sebelum upload")
                                .Add("0")
                                .Add("0")
                                .Add("3-" & Tabel.Rows(i)("nobukti"))
                                .Add("")
                                .Add("")
                                .Add("")
                                .Add("")
                                .Add("")
                                .Add("")
                                .Add("")
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
        Dim typefp, typefpGanti As String
        Dim baris As Integer
        Dim PpnSys As Double
        Dim sysinfo As DataTable
        For r As Integer = 0 To DGV.RowCount - 1
            Try
                sysinfo = Proses.ExecuteQuery("select PrsPpn from tblSysInfo")
                Tabel = Proses.ExecuteQuery("Select TblFak.Tgl,TblFak.Alm1,TblFak.Alm2,TblFak.Alm3, TblFak.NoFP, TblFak.TglFP,TblFak.KdCust,TblFak.ReceivedBy, tblCustomer.NoNpwp, TblFak.NmCust,tblCustomer.NmPkp, tblCustomer.NoKTP, tblCustomer.Kontak, tblCustomer.AlmFP1,tblCustomer.AlmFP2, tblCustomer.AlmFP3, tblCustomer.isNameEditable, tblCustomer.KdOutlet, TblFak.Subtotal - TblFak.Discount AS DPP, TblFak.Discount, TblFak.Ppn, TblFak.PrsPpn, TblFak.NoBukti,MONTH(dbo.TblFak.TglFP) AS bulan, YEAR(dbo.TblFak.TglFP) AS tahun,MONTH(TblFak.Tgl) AS bulanJL,YEAR(TblFak.Tgl) AS tahunJL,TblFak.JnsJualTax,tblFak.StampPBBS FROM  TblFak INNER JOIN tblCustomer ON TblFak.KdCust = tblCustomer.KdCust where nobukti='" & DGV.Rows(r).Cells(0).Value & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("Data Nomor Transaksi= " & DGV.Rows(r).Cells(0).Value & " tidak ditemukan")
                    Me.DGV.Rows(r).DefaultCellStyle.BackColor = Color.Red
                ElseIf Tabel.Rows(0)("NoFP").ToString = "" Then
                    MsgBox("Nomor faktur pajak dengan No : " + DGV.Rows(r).Cells(0).Value + " belum terisi", MsgBoxStyle.Exclamation, "Konfirmasi")
                    Me.DGV.Rows(r).DefaultCellStyle.BackColor = Color.Red
                Else
                    For i As Integer = 0 To Tabel.Rows.Count - 1

                        'Menentukan PPN dari tblFak atau dari tblSysInfo
                        If Tabel.Rows(i)("jnsjualtax").ToString = "PBBS" Then
                            PpnSys = sysinfo.Rows(0).Item("PrsPpn")
                        Else
                            PpnSys = Tabel.Rows(i).Item("PrsPpn")
                        End If
                        With ListView1
                            .Items.Add("FK")
                            With .Items(.Items.Count - 1).SubItems
                                typefp = Tabel.Rows(i)("NoFP").ToString.Remove(2)
                                typefpGanti = Mid(Tabel.Rows(i)("NoFP").ToString, 3, 1)
                                '//Koreksi apabila ada kesalahan transaksi PPPN & PBBS
                                baris = ListView1.Items.Count - 1
                                If Tabel.Rows(i)("jnsjualtax").ToString = "PPPN" And typefp = "08" Then
                                    .Add("'" & "01")
                                    ListView1.Items(baris).BackColor = Color.Red
                                ElseIf Tabel.Rows(i)("jnsjualtax").ToString = "PBBS" And typefp = "01" Then
                                    .Add("'" & "08")
                                    ListView1.Items(baris).BackColor = Color.Red
                                Else
                                    .Add("'" & typefp)
                                End If
                                '//
                                .Add(typefpGanti)
                                .Add("'" & Tabel.Rows(i)("NoFP").ToString.Remove(0, 4).Replace(".", "").Replace("-", ""))
                                .Add(Tabel.Rows(i)("bulan"))
                                .Add(Tabel.Rows(i)("tahun"))
                                tanggalfp = Tabel.Rows(i)("tglFP")
                                .Add((Format(tanggalfp, "dd/MM/yyyy")))
                                '//Apabila cust tokuhai/walkin dan sample tampilkan nama customernya
                                If Tabel.Rows(i)("isNameEditable") = True And Tabel.Rows(i)("KdOutlet") <> "OL1" Then

                                    If Tabel.Rows(i)("ReceivedBy") = "" Then
                                        MsgBox("No Faktur = " + Tabel.Rows(i)("NoBukti") + " tidak terdapat no KTP", MsgBoxStyle.Exclamation, "Konfirmasi")
                                        ListView1.Items(baris).BackColor = Color.LightYellow
                                        .Add("KTP tidak ada")
                                    Else
                                        .Add("'" & Tabel.Rows(i)("ReceivedBy")) 'kolom bantuan untuk formula No KTP / NPWP
                                    End If
                                    .Add(Tabel.Rows(i)("NmCust"))
                                    .Add("Delete sebelum upload")
                                    .Add(Tabel.Rows(i)("Alm1") & " " & Tabel.Rows(i)("Alm2") & " " & Tabel.Rows(i)("Alm3"))
                                ElseIf Tabel.Rows(i)("KdOutlet") = "OL1" Then
                                    'Penjualan Online
                                    .Add("0") 'No NPWP di anggap 0
                                    .Add("0#PASPOR#NAMA#" & Tabel.Rows(i)("NmCust"))
                                    .Add(Tabel.Rows(i)("NmCust"))
                                    .Add(Tabel.Rows(i)("Alm1") & " " & Tabel.Rows(i)("Alm2") & " " & Tabel.Rows(i)("Alm3"))
                                    '//
                                ElseIf Tabel.Rows(i)("NoNpwp") = "" Or Tabel.Rows(i)("NoNpwp") = "0" Then 'Pemisah customer register PKP atau perorangan
                                    'Cust PKP / Perorangan
                                    .Add("'" & Tabel.Rows(i)("NoKTP"))
                                    .Add(Tabel.Rows(i)("Kontak"))
                                    .Add(Tabel.Rows(i)("NmPkp"))
                                    .Add(Tabel.Rows(i)("AlmFP1") & " " & Tabel.Rows(i)("AlmFP2") & " " & Tabel.Rows(i)("AlmFP3"))
                                Else
                                    'Cust PKP
                                    .Add("'" & Tabel.Rows(i)("NoNpwp")) 'kolom bantuan untuk formula No KTP / NPWP
                                    .Add(Tabel.Rows(i)("NmPkp"))
                                    tanggalinv = Tabel.Rows(i)("Tgl")
                                    If tanggalfp <> tanggalinv Then
                                        ListView1.Items(baris).BackColor = Color.Yellow
                                        .Add("tanggal FP DAN INV berbeda")
                                    Else
                                        .Add("")
                                    End If
                                    .Add(Tabel.Rows(i)("AlmFP1") & " " & Tabel.Rows(i)("AlmFP2") & " " & Tabel.Rows(i)("AlmFP3"))
                                End If
                                '.Add(Round(Val(Tabel.Rows(i)("DPP"))))
                                .Add(Int(Tabel.Rows(i)("DPP"))) '//Jumlah DPP
                                If typefp = "08" Then
                                    ' .Add(Round(Val(Tabel.Rows(i)("DPP") * PpnSys / 100))) '//Jumlah PPN 11%
                                    .Add(Int(Tabel.Rows(i)("DPP") * PpnSys / 100)) '//Jumlah PPN 11%
                                    .Add("0")
                                    If Not IsDBNull(Tabel.Rows(i)("StampPBBS")) Then
                                        .Add(Tabel.Rows(i)("StampPBBS"))
                                    Else
                                        .Add("Stempel Kosong")
                                        ListView1.Items(baris).BackColor = Color.Yellow
                                    End If
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                ElseIf typefp = "07" Then
                                    '.Add(Round(Val(Tabel.Rows(i)("Ppn")))) '// Jumlah PPN
                                    .Add(Int(Tabel.Rows(i)("DPP") * PpnSys / 100)) '//Jumlah PPN 11%
                                    .Add("0")
                                    .Add("1")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                Else
                                    '.Add(Round(Val(Tabel.Rows(i)("Ppn")))) '// Jumlah PPN
                                    .Add(Int(Tabel.Rows(i)("Ppn"))) '//Jumlah PPN
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                    .Add("0")
                                End If
                                .Add("3-" & Tabel.Rows(i)("NoBukti"))
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
                                Dim discount, jumlahnet, ppn As Decimal
                                discount = Tabel.Rows(i)("jumlah") * (Tabel.Rows(i)("PrsDisc1") / 100)
                                'jumlahnet = Round(Val(Tabel.Rows(i)("jumlah") - discount))
                                jumlahnet = (Tabel.Rows(i)("jumlah") - discount)
                                ppn = jumlahnet * (PpnSys / 100)
                                .Add("1" & Tabel.Rows(i)("kdbrg"))
                                .Add(Tabel.Rows(i)("nmbrg"))
                                .Add(Tabel.Rows(i)("hrgnet"))
                                .Add(Tabel.Rows(i)("qty"))
                                '.Add(Round(Val(Tabel.Rows(i)("jumlah"))))
                                .Add(Tabel.Rows(i)("jumlah"))
                                .Add(discount) '// Jumlah Discount bawah
                                .Add(jumlahnet) '// Harga setelah discount
                                .Add(ppn) '//ppn harga net
                                .Add("Delete sebelum upload")
                                .Add("0")
                                .Add("0")
                                .Add("3-" & Tabel.Rows(i)("nobukti"))
                                .Add("")
                                .Add("")
                                .Add("")
                                .Add("")
                                .Add("")
                                .Add("")
                                .Add("")
                            End With
                        End With
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Next
        MsgBox("Proses selesai", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

   
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Membuat dan menampilkan dialog untuk memilih lokasi dan nama file
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files|*.xlsx"
        saveFileDialog.Title = "Save an Excel File"
        saveFileDialog.FileName = "ExportedData.xlsx"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

            ' Buat objek Excel
            Dim excelApp As Excel.Application = New Excel.Application()
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
            Dim worksheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

            ' Menyiapkan array untuk data
            Dim rowCount As Integer = ListView1.Items.Count
            Dim colCount As Integer = ListView1.Columns.Count + 1
            Dim dataArray(rowCount, colCount - 1) As Object

            ' Mengisi header
            'For col As Integer = 0 To colCount - 1
            'dataArray(0, col) = ListView1.Columns(col).Text
            'Next

            ' Mengisi data
            For row As Integer = 1 To rowCount
                For col As Integer = 0 To colCount - 1
                    dataArray(row, col) = ListView1.Items(row - 1).SubItems(col).Text
                Next
            Next

            ' Menyalin array ke range Excel
            Dim startCell As Excel.Range = worksheet.Cells(1, 1)
            Dim endCell As Excel.Range = worksheet.Cells(rowCount + 1, colCount)
            Dim writeRange As Excel.Range = worksheet.Range(startCell, endCell)
            writeRange.Value2 = dataArray

            ' Tampilkan Excel dan tutup objek COM
            excelApp.Visible = True
            workbook.SaveAs(filePath)
            workbook.Close()
            excelApp.Quit()
            ' Lepaskan objek COM
            ReleaseObject(worksheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)

            MsgBox("Data berhasil diekspor ke " & filePath, MsgBoxStyle.Information, "Pesan")
        Else
            MessageBox.Show("Ekspor dibatalkan.")
        End If
    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


End Class