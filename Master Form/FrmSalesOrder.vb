Imports System.Net

Public Class FrmSalesOrder
    Dim rowID As String
    Dim status As Boolean
    Dim so As Boolean
    Dim admin As Boolean
    Dim satuan As String
    Dim level As Integer
    Sub sendMessage()
        Dim URL As String

        URL = api


        Dim objWebRequest As Net.HttpWebRequest

        Dim objWebResponse As Net.HttpWebResponse

        Dim srReader As IO.StreamReader

        Dim strHTML As String

        objWebRequest = CType(Net.WebRequest.Create(URL), Net.HttpWebRequest)

        objWebRequest.Method = "POST"

        objWebRequest.ContentType = "application/json"

        objWebRequest.Credentials = CredentialCache.DefaultCredentials

        objWebRequest.Accept = "application/json"


        Dim response As HttpWebResponse

        Try
            response = objWebRequest.GetResponse()     ' gives exception on this line

            objWebResponse = CType(response, Net.HttpWebResponse)
            srReader = New IO.StreamReader(objWebResponse.GetResponseStream)

            strHTML = srReader.ReadToEnd

            objWebResponse.Close()
            objWebRequest.Abort()



        Catch ex As Exception

            Dim NoSo As String = txtNoSO.Text
            Dim Cust As String = txtNmCust.Text
            Dim Sales As String = lblNmSales.Text
            Dim pesan As String = "text=" + NoSo + " Customer :" + Cust + " Sales " + Sales + " " + txtket2.Text
            Dim Id As String = "-446222430&"
            Dim url2 As String = "https://api.telegram.org/bot917420710:AAGxew4S6ASps_nEcvLclsXhdPIhCthYi_c/sendMessage?chat_id=" + Id + pesan
            Process.Start(url2)

        End Try
    End Sub
    Sub otoritas()
        Tabel = Proses.ExecuteQuery("select * from tblpengguna where Username='" & FrmUtama.Unametxt.Text & "'")
        If Tabel.Rows(0).Item("LevelSODesktop") < 1 Then
            btnapp.Enabled = False
            btnreject.Enabled = False
            chkapp.Enabled = False
            chkre.Enabled = False
        End If
        If Tabel.Rows(0).Item("LevelSODesktop") > 0 Then
            admin = True
        Else
            admin = False
        End If
    End Sub
    Sub GetTotal()
        Dim subtot, disc, prsdisc, total As Decimal
        Tabel = Proses.ExecuteQuery("SELECT SUM(subtotal) AS Total FROM dbo.salesorder_item WHERE (no_so = '" & txtNoSO.Text & "')")
        subtot = Tabel.Rows(0).Item("Total")
        prsdisc = txtPrsDisc.Text
        disc = subtot * (prsdisc / 100)
        total = subtot - disc
        txtSubtotal.Text = FormatCurrency(subtot)
        txtDisc.Text = FormatCurrency(disc)
        txtTotal.Text = FormatCurrency(total)
    End Sub
    Sub GetdataItem()
        DataGridView2.DataSource = Nothing
        Tabel = Proses.ExecuteQuery("Select id,no_so,item_barang,harga,jumlah,satuan,disc,disc2,disc3,subtotal from salesorder_item where no_so='" & txtNoSO.Text & "'")
        DataGridView2.DataSource = Tabel
    End Sub
    Sub isiJualMin()
        Try
            For t As Integer = 0 To DataGridView2.Rows.Count - 1
                Tabel = Proses.ExecuteQuery("SELECT HrgJualMin FROM TblIvMst WHERE KdBrg = '" & Me.DataGridView2.Rows(t).Cells(2).Value & "'")

                If Tabel.Rows.Count > 0 Then
                    DataGridView2.Rows(t).Cells(10).Value = Tabel.Rows(0).Item(0)
                Else
                    DataGridView2.Rows(t).Cells(10).Value = ""
                End If
            Next
            Me.DataGridView2.Columns(10).DefaultCellStyle.Format = "N"
            Me.DataGridView2.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Sub isiHPP()
        Dim periode As String

        periode = Format(IIf(Month(lblTgl.Text) = 1, Year(lblTgl.Text) - 1, Year(lblTgl.Text)), "0000") & Format(IIf(Month(lblTgl.Text) = 1, 12, Month(lblTgl.Text) - 1), "00")

        Try
            ' For t As Integer = 0 To DataGridView2.Rows.Count - 1
            'Tabel = Proses.ExecuteQuery("SELECT HrgPokok FROM tblHrgPokok WHERE Periode='" & periode & "' and kdbrg='" & Me.DataGridView2.Rows(t).Cells(2).Value & "'")

            'If Tabel.Rows.Count > 0 Then
            'DataGridView2.Rows(t).Cells(10).Value = Tabel.Rows(0).Item(0)
            'Else
            'DataGridView2.Rows(t).Cells(10).Value = ""
            'End If
            'Next
            'Me.DataGridView2.Columns(10).DefaultCellStyle.Format = "N"
            'Me.DataGridView2.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Sub PengaturanDGV()

        Me.DataGridView2.Columns(2).HeaderText = "Kode Brg"
        Me.DataGridView2.Columns(3).HeaderText = "Harga"

        Me.DataGridView2.Columns(4).HeaderText = "Qty"
        Me.DataGridView2.Columns(5).HeaderText = "Satuan"
        Me.DataGridView2.Columns(9).HeaderText = "Sub Total"

        Me.DataGridView2.Columns(6).Width = 40
        Me.DataGridView2.Columns(7).Width = 40
        Me.DataGridView2.Columns(8).Width = 40

        Me.DataGridView2.Columns(3).DefaultCellStyle.Format = "N"
        Me.DataGridView2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView2.Columns(9).DefaultCellStyle.Format = "N"
        Me.DataGridView2.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        Me.DataGridView2.Columns(0).Visible = False
        Me.DataGridView2.Columns(1).Visible = False



        Me.DataGridView2.Columns.Add("HPP", "HrgJualMin")
        If level > 1 Then
            Me.DataGridView2.Columns(10).Visible = True
        Else
            Me.DataGridView2.Columns(10).Visible = False
        End If

        lblRow.Text = "Jumlah row : " & DataGridView2.RowCount
    End Sub
    Sub Open()
        Try
            Tabel = Proses.ExecuteQuery("Select * from salesorder where no_so='" & txtNoSO.Text & "'")
            If Tabel.Rows(0).Item("Proses") = True Then
                Me.BtnStat.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.Open_Lock_Icon_16
                btnapp.Enabled = True
                btnreject.Enabled = True

                status = True
                lblProses.Text = Tabel.Rows(0).Item("proses_by")
                lblProses.Visible = True
            Else
                Me.BtnStat.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.Lock_Icon_16
                btnapp.Enabled = False
                status = False
            End If
            If Tabel.Rows(0).Item("Approved") = True Then
                lblstat.Text = "APPROVED"
                lblstat.Visible = True
                chkapp.Checked = Tabel.Rows(0).Item("approved")
                so = True
            End If
            If Tabel.Rows(0).Item("batal") = True Then
                lblstat.Text = "BATAL"
                lblstat.Visible = True
                chkre.Checked = Tabel.Rows(0).Item("batal")
                so = True
            End If
            ChkPrint.Checked = Tabel.Rows(0).Item("printed")
            BtnAdd.Enabled = True
            btncancel.Enabled = False
            btnsim.Enabled = False
            btnUpdate.Enabled = False
            btndel.Enabled = False
            Call otoritas()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub FrmSalesOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabel = Proses.ExecuteQuery("select Username,LevelSODesktop from tblpengguna where Username='" & FrmUtama.Unametxt.Text & "'")
        level = Tabel.Rows(0).Item("LevelSODesktop")
        Call Open()
        Call PengaturanDGV()
        Call isiJualMin()
        'Call isiHPP()
        'Call GetTotal()
        txtSubtotal.Text = FormatCurrency(txtSubtotal.Text)
        txtDisc.Text = FormatCurrency(txtDisc.Text)
        txtTotal.Text = FormatCurrency(txtTotal.Text)
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

    End Sub

    Private Sub BtnStat_Click(sender As Object, e As EventArgs) Handles BtnStat.Click
        Dim jam As String
        jam = DateTime.Now
        If level < 1 Then
            MsgBox("Anda tidak mempunyai hak akses", MsgBoxStyle.Critical, "Konfirmasi")
        Else
            Tabel = Proses.ExecuteQuery("select proses from salesorder where no_so='" & txtNoSO.Text & "'")
            If Tabel.Rows(0).Item("proses") = True Then
                MsgBox("No Sales Order sedang di proses", MsgBoxStyle.Information, "Konfirmasi")
            Else
                Try
                    SQl = "update salesorder Set proses=1,proses_by='" & FrmUtama.Unametxt.Text & "',tgl_proses='" & jam & "' where no_so='" & txtNoSO.Text & "'"
                    Proses.ExecuteNonQuery(SQl)
                    MsgBox("Transaksi sudah bisa di proses", MsgBoxStyle.Information, "Konfirmasi")
                    Call Open()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            End If

        End If

    End Sub


    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView2.RowPrePaint
        Try
            For t As Integer = 0 To DataGridView2.Rows.Count - 1
                If Val(DataGridView2.Rows(t).Cells("harga").Value <= DataGridView2.Rows(t).Cells("HPP").Value) Then
                    DataGridView2.Rows(t).DefaultCellStyle.ForeColor = Color.Red
                End If
                If Val(DataGridView2.Rows(t).Cells("disc").Value > 0) Then
                    DataGridView2.Rows(t).Cells("disc").Style.BackColor = Color.LightSkyBlue
                End If
                If Val(DataGridView2.Rows(t).Cells("disc2").Value > 0) Then
                    DataGridView2.Rows(t).Cells("disc2").Style.BackColor = Color.LightSkyBlue
                End If
                If Val(DataGridView2.Rows(t).Cells("disc3").Value > 0) Then
                    DataGridView2.Rows(t).Cells("disc3").Style.BackColor = Color.LightSkyBlue
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim i As Integer
        i = Me.DataGridView2.CurrentRow.Index
        With DataGridView2.Rows.Item(i)

            Try
                Tabel = Proses.ExecuteQuery("SELECT TOP 5 TblFak.NoBukti,TblFak.JnsTrans, TblFak.KdCust, TblFakDtl.KdBrg, TblFakDtl.Hrg,TblFakDtl.PrsDisc,TblFakDtl.PrsDisc2,TblFakDtl.PrsDisc3 FROM TblFak INNER JOIN TblFakDtl ON TblFak.NoBukti = TblFakDtl.NoBukti WHERE (TblFak.KdCust = '" & txtKdCust.Text & "') AND (TblFakDtl.KdBrg = '" & .Cells(2).Value & "') AND (TblFak.JnsTrans = 'JL') ORDER BY TblFak.NoBukti DESC")

                ListView1.Items.Clear()
                For j As Integer = 0 To Tabel.Rows.Count - 1
                    With ListView1
                        .Items.Add(Tabel.Rows(j)("NoBukti"))
                        With .Items(.Items.Count - 1).SubItems
                            .Add(Tabel.Rows(j)("KdBrg"))
                            .Add(FormatCurrency(Tabel.Rows(j)("Hrg")))
                            .Add(Tabel.Rows(j)("PrsDisc"))
                            .Add(Tabel.Rows(j)("PrsDisc2"))
                            .Add(Tabel.Rows(j)("PrsDisc3"))
                        End With
                    End With
                Next

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End With
    End Sub



    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentDoubleClick
        If level < 1 Then
            MsgBox("Akses di tolak", MsgBoxStyle.Critical, "Konfirmasi")
        Else
            If status = True Then
                BtnAdd.Enabled = False
                btncancel.Enabled = True
                btnUpdate.Enabled = True
                btndel.Enabled = True
                txtPrsDisc.ReadOnly = False
                Dim i As Integer
                i = Me.DataGridView2.CurrentRow.Index
                With DataGridView2.Rows.Item(i)

                    Try
                        Dim harga, qty, disc, disc2, disc3 As Double
                        harga = Val(DataGridView2.Rows(i).Cells("Harga").Value)
                        qty = Val(DataGridView2.Rows(i).Cells("jumlah").Value)
                        disc = Val(DataGridView2.Rows(i).Cells("disc").Value)
                        disc2 = Val(DataGridView2.Rows(i).Cells("disc2").Value)
                        disc3 = Val(DataGridView2.Rows(i).Cells("disc3").Value)
                        rowID = Val(DataGridView2.Rows(i).Cells("id").Value)
                        txtkodebrg.Text = DataGridView2.Rows(i).Cells("item_barang").Value
                        txtHarga.Text = harga
                        txtQty.Text = qty
                        txtD1.Text = disc
                        txtD2.Text = disc2
                        txtD3.Text = disc3
                        If level < 2 Then
                            txtHarga.ReadOnly = True
                        Else
                            txtHarga.ReadOnly = False
                        End If

                        txtQty.ReadOnly = False
                        txtD1.ReadOnly = False
                        txtD2.ReadOnly = False
                        txtD3.ReadOnly = False
                        txtQty.Focus()
                    Catch ex As Exception
                        MsgBox(ex.ToString())
                    End Try
                End With
            Else
                MsgBox("Buka kunci terlebih dahulu untuk melakukan proses ini", MsgBoxStyle.Exclamation, "Pesan")
                BtnStat.Focus()
            End If
        End If



    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If admin = True Then
            Dim subtotal, prsdisc, disc, qty, harga, d1, d2, d3, total, grandtotal As Double
            harga = txtHarga.Text
            qty = txtQty.Text
            d1 = (txtQty.Text * harga) * (txtD1.Text / 100)
            d2 = (txtQty.Text * harga - d1) * (txtD2.Text / 100)
            d3 = (txtQty.Text * harga - d1 - d2) * (txtD3.Text / 100)
            total = (qty * harga) - d1 - d2 - d3

            If so = True Then
                MsgBox("Sales Order ini sudah di tutup", MsgBoxStyle.Critical)
            Else
                Try
                    'Update Data item harga dan qty 
                    SQl = "update salesorder_item Set harga='" & txtHarga.Text & "',disc='" & txtD1.Text & "',disc2='" & txtD2.Text & "',disc3='" & txtD3.Text & "',jumlah='" & txtQty.Text & "',subtotal='" & total & "' where id='" & rowID & "'"
                    Proses.ExecuteNonQuery(SQl)
                    'Update Data salesorder
                    Tabel = Proses.ExecuteQuery("SELECT SUM(subtotal) AS Total FROM dbo.salesorder_item WHERE (no_so = '" & txtNoSO.Text & "')")
                    subtotal = Tabel.Rows(0).Item("Total")
                    prsdisc = txtPrsDisc.Text
                    disc = subtotal * (prsdisc / 100)
                    grandtotal = subtotal - disc
                    SQl = "update salesorder Set grandtotal='" & grandtotal & "',prsdisc='" & prsdisc & "',disc='" & disc & "',subtotal='" & subtotal & "',keterangan2='" & txtket2.Text & "',no_po='" & txtNoPo.Text & "' where no_so='" & txtNoSO.Text & "'"
                    Proses.ExecuteNonQuery(SQl)
                    MsgBox("Update data sales Order berhasil", MsgBoxStyle.Information, "Konfirmasi")
                    'Bersihkan textbox
                    txtkodebrg.Text = ""
                    txtHarga.Text = "0"
                    txtQty.Text = "0"
                    txtD1.Text = "0"
                    txtD2.Text = "0"
                    txtD3.Text = "0"
                    'Kosongkan datagrid
                    DataGridView2.Columns.Clear()
                    'Isi / refresh form detail item
                    Call GetdataItem()
                    Call PengaturanDGV()
                    Call isiJualMin()
                    Call GetTotal()
                    btnUpdate.Enabled = False
                    btncancel.Enabled = False
                    BtnAdd.Enabled = True
                    txtHarga.ReadOnly = True
                    txtQty.ReadOnly = True
                    txtD1.ReadOnly = True
                    txtD2.ReadOnly = True
                    txtD3.ReadOnly = True
                    txtPrsDisc.ReadOnly = True
                    BtnAdd.Enabled = True
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            End If
        Else
            MsgBox("anda tidak punya otoritas", MsgBoxStyle.Critical)
        End If


    End Sub


    Private Sub btnapp_Click(sender As Object, e As EventArgs) Handles btnapp.Click
        Dim saldo, kredit, totalso, limit As Double
        If level < 2 Then
            MsgBox("Akses di tolak", MsgBoxStyle.Critical, "Konfirmasi")
        Else
            Try
                Tabel = Proses.ExecuteQuery("Select * from salesorder where no_so='" & txtNoSO.Text & "'")
                If Tabel.Rows(0).Item("batal") = True Then
                    MsgBox("Sales order ini sudah di Batalkan", MsgBoxStyle.Critical, "Konfirmasi")
                ElseIf Tabel.Rows(0).Item("approved") = True Then
                    MsgBox("Sales order ini sudah di approve", MsgBoxStyle.Critical, "Konfirmasi")
                Else
                    'cek kredit limit
                    Tabel = Proses.ExecuteQuery("Select * from tblCustomer where Kdcust  ='" & txtKdCust.Text & "'")
                    saldo = Tabel.Rows(0).Item("Saldo")
                    kredit = Tabel.Rows(0).Item("KreditLimit")
                    totalso = Replace(txtTotal.Text, ",", "") * 1.1
                    limit = kredit - saldo
                    If totalso > limit Then
                        MsgBox("Kredit limit hubungi akunting", MsgBoxStyle.Critical, "Konfirmasi")
                    Else
                        If txtPrsDisc.Text > 0 Then
                            Dim result As DialogResult = MessageBox.Show("Terdapat discount global, hitung kembali harga item barang dengan di kurangi persen discount global ! Klik Yes untuk melanjutkan Klik No untuk batal approve", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If result = DialogResult.Yes Then
                                SQl = "update salesorder Set approved=1 where no_so='" & txtNoSO.Text & "'"
                                Proses.ExecuteNonQuery(SQl)
                                MsgBox("Sales Order selesai di approve, silahkan cetak", MsgBoxStyle.Information, "Konfirmasi")
                                so = True
                                lblstat.Text = "APPROVED"
                                chkapp.Checked = True
                                lblstat.Visible = True
                            End If
                        Else
                            SQl = "update salesorder Set approved=1 where no_so='" & txtNoSO.Text & "'"
                            Proses.ExecuteNonQuery(SQl)
                            MsgBox("Sales Order selesai di approve, silahkan cetak", MsgBoxStyle.Information, "Konfirmasi")
                            so = True
                            lblstat.Text = "APPROVED"
                            chkapp.Checked = True
                            lblstat.Visible = True
                        End If
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

        End If




    End Sub



    Private Sub btnreject_Click(sender As Object, e As EventArgs) Handles btnreject.Click
        If level < 1 Then
            MsgBox("Akses di tolak", MsgBoxStyle.Critical, "Konfirmasi")
        Else
            Tabel = Proses.ExecuteQuery("Select * from salesorder where no_so='" & txtNoSO.Text & "'")
            If Tabel.Rows(0).Item("batal") = True Then
                MsgBox("Sales Order ini sudah status batal", MsgBoxStyle.Information, "Konfirmasi")
            Else
                If Tabel.Rows(0).Item("approved") = True Then
                    Dim result As DialogResult = MessageBox.Show("SO ini sudah approve apakah mau dibatalkan ?", "caption", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        Try

                            SQl = "update salesorder Set approved=0,batal=1,keterangan2='" & txtket2.Text & "' where no_so='" & txtNoSO.Text & "'"
                            Proses.ExecuteNonQuery(SQl)
                            MsgBox("Sales Order selesai di batalkan", MsgBoxStyle.Information, "Konfirmasi")
                            so = True
                            lblstat.Text = "BATAL"
                            lblstat.Visible = True
                            chkapp.Checked = False
                            chkre.Checked = True
                        Catch ex As Exception
                            MsgBox(ex.ToString())
                        End Try
                    ElseIf result = DialogResult.No Then
                        txtNoSO.Focus()

                    End If
                ElseIf Tabel.Rows(0).Item("approved") = False Then
                    Dim result As DialogResult = MessageBox.Show("SO ini apakah yakin akan dibatalkan ?", "caption", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        SQl = "update salesorder Set batal=1 where no_so='" & txtNoSO.Text & "'"
                        Proses.ExecuteNonQuery(SQl)
                        MsgBox("Sales Order selesai di batalkan", MsgBoxStyle.Information, "Konfirmasi")
                        so = True
                        lblstat.Text = "BATAL"
                        lblstat.Visible = True
                        chkre.Checked = True
                    ElseIf result = DialogResult.No Then
                        txtNoSO.Focus()
                    End If

                End If
            End If
        End If




    End Sub


    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        FrmReportSO.Dispose()
        Try
            Tabel = Proses.ExecuteQuery("select * from salesorder where no_so='" & txtNoSO.Text & "'")
            If Tabel.Rows(0).Item("batal") = True Then
                MessageBox.Show("SO ini dibatalkan", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf Tabel.Rows(0).Item("proses") = False Then
                Dim result As DialogResult = MessageBox.Show("SO ini belum diproses apakah lanjut print ?", "Konfirmasi", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    FrmReportSO.DataTable1BindingSource.Filter = "(no_so='" & txtNoSO.Text & "')"
                    FrmReportSO.Show()
                End If
            Else

                FrmReportSO.DataTable1BindingSource.Filter = "(no_so='" & txtNoSO.Text & "')"

                FrmReportSO.Show()
                SQl = "update salesorder Set printed=1 where no_so='" & txtNoSO.Text & "'"
                Proses.ExecuteNonQuery(SQl)
            End If

        Catch ex As Exception
            MessageBox.Show("Error :" + ex.ToString(), "Error Report,", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub





    Private Sub chkapp_Click(sender As Object, e As EventArgs) Handles chkapp.Click
        If level < 2 Then
            MsgBox("Anda tidak punya otoritas", MsgBoxStyle.Exclamation, "Pesan")
        Else
            Dim result As DialogResult = MessageBox.Show("Yakin untuk melakukan perubahan status SO ?", "Peringatan", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                SQl = "update salesorder Set approved='" & CInt(chkapp.Checked) * -1 & "' where no_so='" & txtNoSO.Text & "'"
                Proses.ExecuteNonQuery(SQl)



                If chkapp.Checked = True Then
                    lblstat.Text = "APPROVED"
                    lblstat.Visible = True
                    so = True
                Else
                    lblstat.Visible = False
                    so = False
                End If

            End If
            Tabel = Proses.ExecuteQuery("select approved from salesorder where no_so='" & txtNoSO.Text & "'")
            chkapp.Checked = Tabel.Rows(0).Item("approved")

        End If


    End Sub

    Private Sub DataGridView2_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DataGridView2.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If status = True Then
            If admin = True Then
                If so = True Then
                    MsgBox("Sales Order ini sudah di tutup", MsgBoxStyle.Critical)
                Else
                    txtkodebrg.ReadOnly = False
                    txtHarga.ReadOnly = False
                    txtQty.ReadOnly = False
                    txtD1.ReadOnly = False
                    txtD2.ReadOnly = False
                    txtD3.ReadOnly = False
                    txtkodebrg.Focus()
                    BtnAdd.Enabled = False
                    btncancel.Enabled = True
                    btnsim.Enabled = True
                    txtQty.Text = 0
                    txtHarga.Text = 0
                    txtD1.Text = 0
                    txtD2.Text = 0
                    txtD3.Text = 0
                End If
            Else
                MsgBox("Anda tidak punya hak akses", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("SO ini belum di proses", MsgBoxStyle.Critical)
            BtnStat.Focus()
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtkodebrg.Text = ""
        txtHarga.Text = "0"
        txtQty.Text = "0"
        txtD1.Text = "0"
        txtD2.Text = "0"
        txtD3.Text = "0"
        txtHarga.ReadOnly = True
        txtQty.ReadOnly = True
        txtD1.ReadOnly = True
        txtD2.ReadOnly = True
        txtD3.ReadOnly = True
        BtnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnsim.Enabled = False
        btncancel.Enabled = False
        btndel.Enabled = False
        txtkodebrg.ReadOnly = True
    End Sub

    Private Sub txtkodebrg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkodebrg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tabel = Proses.ExecuteQuery("select KdBrg,Satuan from tblIvMst where Kdbrg='" & txtkodebrg.Text & "'")
            If txtkodebrg.Text <> "" Then
                If Tabel.Rows.Count = 0 Then
                    MsgBox("kode barang tidak di temukan", MsgBoxStyle.Exclamation, "pesan")
                    txtkodebrg.Focus()
                Else
                    txtQty.Focus()
                    satuan = Tabel.Rows(0).Item("Satuan")
                End If
            End If
        End If
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtHarga.Focus()
        End If
    End Sub

    Private Sub txtHarga_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHarga.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtD1.Focus()
        End If
    End Sub

    Private Sub txtD1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtD1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtD2.Focus()
        End If
    End Sub

    Private Sub txtD2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtD2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtD3.Focus()
        End If
    End Sub

    Private Sub txtD3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtD3.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsim.Focus()
        End If
    End Sub

    Private Sub btnsim_Click(sender As Object, e As EventArgs) Handles btnsim.Click
        Dim subtotal, prsdisc, disc, qty, harga, d1, d2, d3, total, grandtotal As Double
        harga = txtHarga.Text
        qty = txtQty.Text
        d1 = (txtQty.Text * harga) * (txtD1.Text / 100)
        d2 = (txtQty.Text * harga - d1) * (txtD2.Text / 100)
        d3 = (txtQty.Text * harga - d1 - d2) * (txtD3.Text / 100)
        total = (qty * harga) - d1 - d2 - d3
        If txtkodebrg.Text = "" Then
            MsgBox("isi kode barang terlebih dahulu", MsgBoxStyle.Information, "pesan")
            txtkodebrg.Focus()
        Else
            Try
                'Add item salesorder
                SQl = "Insert into salesorder_item values('" & txtNoSO.Text & "','" & (txtkodebrg.Text) & "','" & harga & "','" & txtD1.Text & "','" & txtD2.Text & "','" & txtD3.Text & "','" & qty & "','" & total & "','" & satuan & "')"
                Proses.ExecuteNonQuery(SQl)
                'Update Data salesorder
                Tabel = Proses.ExecuteQuery("SELECT SUM(subtotal) AS Total FROM dbo.salesorder_item WHERE (no_so = '" & txtNoSO.Text & "')")
                subtotal = Tabel.Rows(0).Item("Total")
                prsdisc = txtPrsDisc.Text
                disc = subtotal * (prsdisc / 100)
                grandtotal = subtotal - disc
                SQl = "update salesorder Set grandtotal='" & grandtotal & "',prsdisc='" & prsdisc & "',disc='" & disc & "',subtotal='" & subtotal & "',keterangan2='" & txtket2.Text & "',no_po='" & txtNoPo.Text & "' where no_so='" & txtNoSO.Text & "'"
                Proses.ExecuteNonQuery(SQl)
                MsgBox("Update data sales Order berhasil", MsgBoxStyle.Information, "Konfirmasi")
                'Bersihkan textbox
                txtkodebrg.Text = ""
                txtHarga.Text = ""
                txtQty.Text = ""
                txtD1.Text = ""
                txtD2.Text = ""
                txtD3.Text = ""
                'Kosongkan datagrid
                DataGridView2.Columns.Clear()
                'Isi / refresh form detail item
                Call GetdataItem()
                Call PengaturanDGV()
                Call isiJualMin()
                Call GetTotal()
                btnsim.Enabled = False
                btncancel.Enabled = False
                BtnAdd.Enabled = True
                BtnAdd.Focus()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub
    Sub GetNoJL()
        Try
            Tabel = Proses.ExecuteQuery("select Nobukti from tblFak where NoSO='" & txtNoSO.Text & "'")
            If Tabel.Rows.Count > 0 Then
                txtNoBukti.Text = Tabel.Rows(0).Item("Nobukti")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnAddFk_Click(sender As Object, e As EventArgs) Handles btnAddFk.Click
        Try
            Tabel = Proses.ExecuteQuery("Select * from salesorder where no_so='" & txtNoSO.Text & "'")
            If Tabel.Rows(0).Item("approved") = True Then
                If txtNoBukti.Text = "" Then
                    GetNoJL()
                End If
                SQl = "update salesorder set NoBukti='" & txtNoBukti.Text & "',no_po='" & txtNoPo.Text & "',keterangan2='" & txtket2.Text & "' where no_so='" & txtNoSO.Text & "'"
                Proses.ExecuteNonQuery(SQl)
                If txtket2.Text = "" Then
                Else
                    Dim NoSo As String = txtNoSO.Text
                    Dim Cust As String = txtNmCust.Text
                    Dim Sales As String = lblNmSales.Text
                    Dim pesan As String = "text=" + NoSo + " Customer :" + Cust + " Sales " + Sales + " " + txtket2.Text
                    Dim Id As String = "-446222430&"
                    api = "https://api.telegram.org/bot917420710:AAGxew4S6ASps_nEcvLclsXhdPIhCthYi_c/sendMessage?chat_id=" + Id + pesan
                    Call sendMessage()
                    MsgBox("Notif terkirim", MsgBoxStyle.Information, "pesan")
                End If
                MsgBox("Berhasil diupdate", MsgBoxStyle.Information, "pesan")
            Else
                MsgBox("No SO ini belum selesai di proses/dibatalkan !!!", MsgBoxStyle.Information, "pesan")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


    End Sub

    Private Sub txtQty_Leave(sender As Object, e As EventArgs) Handles txtQty.Leave
        If txtQty.Text = "" Then
            txtQty.Text = 0
        End If
        If IsNumeric(txtQty.Text) Then
        Else
            MsgBox("isi dengan numeric", MsgBoxStyle.Exclamation, "pesan")
            txtQty.Text = 0
        End If
    End Sub

    Private Sub txtHarga_Leave(sender As Object, e As EventArgs) Handles txtHarga.Leave
        If txtHarga.Text = "" Then
            txtHarga.Text = 0
        End If
        If IsNumeric(txtHarga.Text) Then
        Else
            MsgBox("isi dengan numeric", MsgBoxStyle.Exclamation, "pesan")
            txtHarga.Text = 0
        End If
    End Sub

    Private Sub txtD1_Leave(sender As Object, e As EventArgs) Handles txtD1.Leave
        If txtD1.Text = "" Then
            txtD1.Text = 0
        End If
        If IsNumeric(txtQty.Text) Then
        Else
            MsgBox("isi dengan numeric", MsgBoxStyle.Exclamation, "pesan")
            txtD1.Text = 0
        End If
    End Sub

    Private Sub txtD2_Leave(sender As Object, e As EventArgs) Handles txtD2.Leave
        If txtD2.Text = "" Then
            txtD2.Text = 0
        End If
        If IsNumeric(txtQty.Text) Then
        Else
            MsgBox("isi dengan numeric", MsgBoxStyle.Exclamation, "pesan")
            txtD2.Text = 0
        End If
    End Sub

    Private Sub txtD3_Leave(sender As Object, e As EventArgs) Handles txtD3.Leave
        If txtD3.Text = "" Then
            txtD3.Text = 0
        End If
        If IsNumeric(txtQty.Text) Then
        Else
            MsgBox("isi dengan numeric", MsgBoxStyle.Exclamation, "pesan")
            txtD3.Text = 0
        End If
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If admin = True Then
            Dim subtotal, prsdisc, disc, qty, harga, d1, d2, d3, total, grandtotal As Double
            harga = txtHarga.Text
            qty = txtQty.Text
            d1 = (txtQty.Text * harga) * (txtD1.Text / 100)
            d2 = (txtQty.Text * harga - d1) * (txtD2.Text / 100)
            d3 = (txtQty.Text * harga - d1 - d2) * (txtD3.Text / 100)
            total = (qty * harga) - d1 - d2 - d3
            If so = True Then
                MsgBox("Sales Order ini sudah di tutup", MsgBoxStyle.Critical)
            Else
                Dim result As DialogResult = MessageBox.Show("Yakin akan menghapus item ini ?", "Peringatan", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Try
                        'Delete item
                        SQl = "delete from salesorder_item where id='" & rowID & "'"
                        Proses.ExecuteNonQuery(SQl)
                        'Update Data salesorder
                        Tabel = Proses.ExecuteQuery("SELECT SUM(subtotal) AS Total FROM dbo.salesorder_item WHERE (no_so = '" & txtNoSO.Text & "')")
                        subtotal = Tabel.Rows(0).Item("Total")
                        prsdisc = txtPrsDisc.Text
                        disc = subtotal * (prsdisc / 100)
                        grandtotal = subtotal - disc
                        SQl = "update salesorder Set grandtotal='" & grandtotal & "',prsdisc='" & prsdisc & "',disc='" & disc & "',subtotal='" & subtotal & "',keterangan2='" & txtket2.Text & "',no_po='" & txtNoPo.Text & "' where no_so='" & txtNoSO.Text & "'"
                        Proses.ExecuteNonQuery(SQl)
                        MsgBox("Delete data sales Order berhasil", MsgBoxStyle.Information, "Konfirmasi")
                        'Bersihkan textbox
                        txtkodebrg.Text = ""
                        txtHarga.Text = "0"
                        txtQty.Text = "0"
                        txtD1.Text = "0"
                        txtD2.Text = "0"
                        txtD3.Text = "0"
                        'Kosongkan datagrid
                        DataGridView2.Columns.Clear()
                        'Isi / refresh form detail item
                        Call GetdataItem()
                        Call PengaturanDGV()
                        Call isiJualMin()
                        Call GetTotal()
                        btndel.Enabled = False
                        btnUpdate.Enabled = False
                        btncancel.Enabled = False
                        BtnAdd.Enabled = True
                        txtHarga.ReadOnly = True
                        txtQty.ReadOnly = True
                        txtD1.ReadOnly = True
                        txtD2.ReadOnly = True
                        txtD3.ReadOnly = True
                        BtnAdd.Enabled = True
                    Catch ex As Exception
                        MsgBox(ex.ToString())
                    End Try
                End If

            End If
        Else
            MsgBox("anda tidak punya otoritas", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub chkre_Click(sender As Object, e As EventArgs) Handles chkre.Click
        If level < 1 Then
            MsgBox("Anda tidak punya otoritas", MsgBoxStyle.Exclamation, "Pesan")
        Else
            If chkre.Checked = True Then
            Else
                Dim result As DialogResult = MessageBox.Show("SO ini sudah batalkan yakin untuk melakukan perubahan status SO ?", "Peringatan", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then


                    SQl = "update salesorder Set batal='" & CInt(chkapp.Checked) * -1 & "' where no_so='" & txtNoSO.Text & "'"
                    Proses.ExecuteNonQuery(SQl)
                    lblstat.Visible = False
                    so = False


                End If
            End If

            Tabel = Proses.ExecuteQuery("select batal from salesorder where no_so='" & txtNoSO.Text & "'")
            chkre.Checked = Tabel.Rows(0).Item("batal")
        End If

    End Sub


    Private Sub txtPrsDisc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrsDisc.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrsDisc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrsDisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUpdate.Focus()
        End If
    End Sub
End Class