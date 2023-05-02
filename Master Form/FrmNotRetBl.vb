Public Class FrmNotRetBl
    Dim disc, subtot, total, ppn As Decimal
    Dim tgl As String
    Dim edit As Boolean
    Private rowIndex As Integer = 0
    Sub IsiPpn()
        Dim prsppn As Integer
        Dim total, ppn As Double
        Try
            If txtPrsPpn.Text <> "" Then
                total = txttot.Text
                prsppn = Me.txtPrsPpn.Text
                ppn = (total * prsppn) / 100
                txtppn.Text = ppn
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub subtotal()
        'menjumlahkan subtotal dari datagrid
        Dim hitung As Decimal
        For baris As Integer = 0 To DataGridView1.RowCount - 1
            hitung = hitung + DataGridView1.Rows(baris).Cells(5).Value
        Next
        txtsub.Text = hitung
    End Sub
    Sub clear()
        txtPrsPpn.Text = 0
        txtalm1.Text = ""
        txtalm2.Text = ""
        txtalm3.Text = ""
        txtJL.Text = ""
        txtnofp.Text = ""
        txtnoret.Text = ""
        txtnpwp.Text = ""
        txtpkp.Text = ""
        txtppn.Text = 0
        txtsub.Text = 0
        txttot.Text = 0
        txtdisc.Text = 0
        DataGridView1.DataSource = ""
        BtnSave.Enabled = False
        BtnPrint.Enabled = False
        txtnoret.ReadOnly = False
        lblprint.Visible = False
        CkPrint.Checked = False
        btndelete.Enabled = False
        btnedit.Enabled = False
        edit = False
    End Sub

    Private Sub txtnoret_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnoret.KeyDown
        'Ambil 2 karakter dari kiri untuk memastikan transaksi yang diambil adalah reture
        Dim karakter As String
        karakter = Strings.Left(txtnoret.Text, 2)
        'ambil data reture
        If e.KeyCode = Keys.Enter Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT TblBeli.NoBukti,TblBeli.tgl, TblBeli.NoFP, TblBeli.TglFP, tblsupplier.NmPkp, tblsupplier.AlmFP1, tblsupplier.AlmFP2, tblsupplier.AlmFP3,tblsupplier.NoNpwp,TblBeli.NoPO FROM TblBeli INNER JOIN tblsupplier ON TblBeli.KdSup = tblsupplier.KdSup where nobukti='" & txtnoret.Text & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("Data tersebut tidak di temukan", MsgBoxStyle.Information, "Konfirmasi")
                ElseIf karakter <> "RB" Then
                    MsgBox("No Transaksi harus jenis reture", MsgBoxStyle.Exclamation, "Pesan")
                Else
                    With Tabel
                        txtpkp.Text = Tabel(0).Item("NmPkp")
                        If Tabel(0).Item("AlmFP1") Is DBNull.Value Then
                            txtalm1.Text = ""
                        Else
                            txtalm1.Text = Tabel(0).Item("AlmFP1")
                        End If
                        If Tabel(0).Item("AlmFP2") Is DBNull.Value Then
                            txtalm2.Text = ""
                        Else
                            txtalm2.Text = Tabel(0).Item("AlmFP2")
                        End If
                        If Tabel(0).Item("AlmFP3") Is DBNull.Value Then
                            txtalm3.Text = ""
                        Else
                            txtalm3.Text = Tabel(0).Item("AlmFP3")
                        End If

                        txtnpwp.Text = Tabel(0).Item("NoNPWP")
                        lblref.Text = Tabel(0).Item("noPo")
                        tgl = Tabel(0).Item("tgl")
                    End With
                    'ambil data reture detail
                    Tabel2 = Proses.ExecuteQuery("Select Kdbrg,NmBrg,Qty,Satuan,HrgNet,CAST(Qty * HrgNet AS DECIMAL(14, 2)) AS DPP from TblBelidtl where nobukti='" & txtnoret.Text & "'")
                    DataGridView1.DataSource = Tabel2
                    DataGridView1.Columns(1).Width = 250

                    Call subtotal()
                    subtot = txtsub.Text
                    disc = 0
                    txtdisc.Text = disc
                    total = subtot - disc
                    ppn = 0
                    txttot.Text = total
                    txtppn.Text = ppn
                End If
        Tabel = Proses.ExecuteQuery("select * from tblnotaret where noreture='" & txtnoret.Text & "'")
        If Tabel.Rows.Count > 0 Then
            lblprint.Visible = True
            BtnSave.Enabled = True
            BtnPrint.Enabled = True
            With Tabel.Rows(0)
                CkPrint.Checked = .Item("cetak")
            End With

        Else
            lblprint.Visible = False
            BtnSave.Enabled = True
            BtnPrint.Enabled = False
        End If

            Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        End If
    End Sub


    Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        'menjumlahkan saat row datagrid di delete
        Call subtotal()
    End Sub



    Private Sub txtsub_TextChanged(sender As Object, e As EventArgs) Handles txtsub.TextChanged
        'menjumlahkan saat textbox subtotal berubah value
        formatUang(txtsub)
        subtot = txtsub.Text
        disc = 0
        txtdisc.Text = disc
        total = subtot - disc
        txttot.Text = total
        Call IsiPpn()
    End Sub

    Private Sub txttot_TextChanged(sender As Object, e As EventArgs) Handles txttot.TextChanged
        formatUang(txttot)
    End Sub

    Private Sub txtppn_TextChanged(sender As Object, e As EventArgs) Handles txtppn.TextChanged
        formatUang(txtppn)
    End Sub


    Private Sub txtJL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJL.KeyDown
        'ambil no refensi JL
        If e.KeyCode = Keys.Enter Then
            Try
                Tabel = Proses.ExecuteQuery("Select * from TblBeli where nobukti='" & txtJL.Text & "'")
                With Tabel
                    txtnofp.Text = Tabel(0).Item("NoFP")
                    tglfp.Text = Tabel(0).Item("tglFp")
                End With
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

        End If


    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Call clear()
        edit = False
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        'menghilangkan titik koma pada number
        total = Replace(txttot.Text, ".", "")
        subtot = Replace(txtsub.Text, ".", "")
        ppn = Replace(txtppn.Text, ".", "")

        If edit = True Then
            'update data Nota Reture
            SQl = "update tblnotretbl set tanggal='" & tglbuat.Text & "',NoFP='" & txtnofp.Text & "',TglFp='" & tglfp.Text & "',NoJl='" & txtJL.Text & "',subtot='" & subtot & "',total='" & total & "',disc='" & disc & "',ppn='" & ppn & "' where noReture='" & txtnoret.Text & "'"
            Proses.ExecuteNonQuery(SQl)
            'update data detail Nota Reture
            For baris As Integer = 0 To DataGridView1.RowCount - 1
                Dim dgqty As Decimal = DataGridView1.Rows(baris).Cells(2).Value
                Dim dgharga As Double = DataGridView1.Rows(baris).Cells(4).Value
                Dim dgsubtot As Double = DataGridView1.Rows(baris).Cells(5).Value
                SQl = "update tblnotretbldtl set Qty='" & dgqty & "',harga='" & dgharga & "',subtotal='" & dgsubtot & "' where NoReture='" & txtnoret.Text & "' and Kdbrg='" & DataGridView1.Rows(baris).Cells(0).Value & "'"
                Proses.ExecuteNonQuery(SQl)
            Next baris
            BtnSave.Enabled = False
            ContextMenuStrip.Enabled = False
            BtnPrint.Enabled = True
            btndelete.Enabled = True
            btnedit.Enabled = True
            txtnoret.ReadOnly = True
            lblprint.Visible = True
            'update status cetak jadi false
            SQl = "Update tblnotretbl set cetak=0 where noreture='" & txtnoret.Text & "'"
            Proses.ExecuteNonQuery(SQl)
            CkPrint.Checked = False
            MsgBox("Data berhasil diupdate", MsgBoxStyle.Information, "Pesan")
        Else
            If txtJL.Text = "" Or txtnofp.Text = "" Then
                MsgBox("Masih ada kolom yang belum diisi", MsgBoxStyle.Exclamation, "Pesan")
            Else
                Try
                    Tabel = Proses.ExecuteQuery("select * from tblnotretbl where noreture='" & txtnoret.Text & "'")
                    If Tabel.Rows.Count > 0 Then
                        MsgBox("No Nota Reture tersebut sudah dibuat gunakan nomor lain", MsgBoxStyle.Information, "Pesan")
                    Else
                        'simpan data nota reture
                        SQl = "insert into tblnotretbl values ('" & txtnoret.Text & "','" & tglbuat.Text & "','" & txtpkp.Text & "','" & txtalm1.Text & "','" & txtalm2.Text & "','" & txtalm3.Text & "','" & txtnofp.Text & "','" & tglfp.Text & "','" & txtJL.Text & "','" & txtnpwp.Text & "','" & subtot & "','" & total & "','" & txtdisc.Text & "','" & ppn & "','0')"
                        Proses.ExecuteNonQuery(SQl)
                        'simpan data nota reture detail dari datagrid
                        For baris As Integer = 0 To DataGridView1.RowCount - 1
                            Dim dgqty As Decimal = DataGridView1.Rows(baris).Cells(2).Value
                            Dim dgharga As Double = DataGridView1.Rows(baris).Cells(4).Value
                            Dim dgsubtot As Double = DataGridView1.Rows(baris).Cells(5).Value
                            SQl = "Insert into tblnotretbldtl values('" & txtnoret.Text & "','" & DataGridView1.Rows(baris).Cells(0).Value & "','" & (DataGridView1.Rows(baris).Cells(1).Value) & "','" & dgqty & "','" & DataGridView1.Rows(baris).Cells(3).Value & "','" & dgharga & "','" & dgsubtot & "')"
                            Proses.ExecuteNonQuery(SQl)
                        Next baris
                        MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
                        BtnSave.Enabled = False
                        BtnPrint.Enabled = True
                        txtnoret.ReadOnly = True
                        lblprint.Visible = True

                    End If


                Catch ex As Exception
                    MsgBox(ex.ToString())
                    SQl = "Delete from tblnotretbl where NoReture='" & txtnoret.Text & "'"
                    ' Proses.ExecuteNonQuery(SQl)
                    SQl = "Delete from tblnotretbldtl where NoReture='" & txtnoret.Text & "'"
                    ' Proses.ExecuteNonQuery(SQl)
                End Try
            End If
        End If


    End Sub

    Private Sub FrmNotRet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip.Enabled = False
        btnedit.Enabled = False
        BtnSave.Enabled = False
        BtnPrint.Enabled = False
        lblprint.Visible = False
        btndelete.Enabled = False
        btnedit.Enabled = False
    End Sub
    Sub GetNotRetBL()
        'variable form pencarian nota reture
        Dim Value, Title, Pesan As String
        Title = "Find Nota Reture Beli"
        Pesan = "Input Nomor Reture Beli"
        'menampilkan form input untuk pencarian nota reture
        Dim IB As Object
        IB = InputBox(Pesan, Title)
        Try
            Tabel = Proses.ExecuteQuery("SELECT * from tblnotretBl where noreture='" & IB & "'")
            If Tabel.Rows.Count = 0 Then
                MsgBox("Data tersebut tidak di temukan", MsgBoxStyle.Information, "Konfirmasi")
            Else
                With Tabel
                    txtnoret.Text = Tabel(0).Item("Noreture")
                    txtpkp.Text = Tabel(0).Item("PKP")
                    txtalm1.Text = Tabel(0).Item("alm1")
                    txtalm2.Text = Tabel(0).Item("alm2")
                    txtalm3.Text = Tabel(0).Item("alm3")
                    txtnpwp.Text = Tabel(0).Item("npwp")
                    txtJL.Text = Tabel(0).Item("Nojl")
                    txtnofp.Text = Tabel(0).Item("nofp")
                    tglbuat.Text = Tabel(0).Item("tanggal")
                    tglfp.Text = Tabel(0).Item("tglfp")
                    txtsub.Text = Tabel(0).Item("subtot")
                    txtppn.Text = Tabel(0).Item("ppn")
                    CkPrint.Checked = Tabel(0).Item("cetak")
                End With
                'ambil data nota reture detail
                Tabel2 = Proses.ExecuteQuery("Select kdbrg,NmBrg,Qty,Satuan,harga,Subtotal from tblnotretbldtl where noreture='" & IB & "'")
                DataGridView1.DataSource = Tabel2
                DataGridView1.Columns(1).Width = 250
                'mengisih textbox subtotal
                subtot = txtsub.Text
                disc = 0
                txtdisc.Text = disc
                total = subtot - disc
                txttot.Text = total
                BtnSave.Enabled = False
                BtnPrint.Enabled = True
                txtnoret.ReadOnly = True
                lblprint.Visible = True
                btndelete.Enabled = True
                btnedit.Enabled = True

            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub txtnoret_KeyUp(sender As Object, e As KeyEventArgs) Handles txtnoret.KeyUp
        If e.KeyCode = Keys.F2 Then
            GetNotRetBL()
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        FrmReportNotaRetBl.DataTable2BindingSource.Filter = "(noreture='" & txtnoret.Text & "')"
        FrmReportNotaRetBl.Show()
        SQl = "Update tblnotretbl set cetak=1 where noreture='" & txtnoret.Text & "'"
        Proses.ExecuteNonQuery(SQl)
        CkPrint.Checked = True
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim qty, harga As Double
        qty = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        harga = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        'menjumlahkan subtotal saat edit qty di datagrid
        If e.ColumnIndex = 2 Then
            DataGridView1.Rows(e.RowIndex).Cells(5).Value = qty * harga
            Call subtotal()
        End If


    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        'kunci selain kolom qty
        DataGridView1.Rows(e.RowIndex).Cells(0).ReadOnly = True
        DataGridView1.Rows(e.RowIndex).Cells(1).ReadOnly = True
        DataGridView1.Rows(e.RowIndex).Cells(3).ReadOnly = True
        DataGridView1.Rows(e.RowIndex).Cells(4).ReadOnly = True
        DataGridView1.Rows(e.RowIndex).Cells(5).ReadOnly = True
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim result1 As DialogResult = MessageBox.Show("Yakin akan menghapus data?", _
             "Option", _
             MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result1 = DialogResult.Yes Then
                SQl = "Delete from tblnotretbl where NoReture='" & txtnoret.Text & "'"
                Proses.ExecuteNonQuery(SQl)
                SQl = "Delete from tblnotretbldtl where NoReture='" & txtnoret.Text & "'"
                Proses.ExecuteNonQuery(SQl)
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Pesan")

                Call clear()

            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmCariNotReture.Text = "Cari Nota Reture Beli"
        FrmCariNotReture.Show()
    End Sub

    Private Sub FrmNotRetBl_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmCariNotReture.Dispose()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        ContextMenuStrip.Enabled = True
        btndelete.Enabled = False
        BtnSave.Enabled = True
        BtnPrint.Enabled = False
        btnedit.Enabled = False
        edit = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmExportTaxRB.Text = "Form Nota Retur Beli - Export"
        FrmExportTaxRB.Show()
    End Sub


    Private Sub txtPrsPpn_TextChanged(sender As Object, e As EventArgs) Handles txtPrsPpn.TextChanged
        If txtPrsPpn.Text = "" Then
            txtPrsPpn.Text = 0
        Else
            Call IsiPpn()
        End If
    End Sub


    Private Sub DataGridView1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Me.DataGridView1.Rows(e.RowIndex).Selected = True
            Me.rowIndex = e.RowIndex
            Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(e.RowIndex).Cells(0)
            Me.ContextMenuStrip.Show(Me.DataGridView1, e.Location)
            ContextMenuStrip.Show(Cursor.Position)

        End If
    End Sub


    Private Sub ContextMenuStrip_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip.Click
        If Not Me.DataGridView1.Rows(Me.rowIndex).IsNewRow Then
            Dim result1 As DialogResult = MessageBox.Show("Yakin akan menghapus data : " & Me.DataGridView1.Rows(Me.rowIndex).Cells(0).Value, _
           "Option", _
           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result1 = DialogResult.Yes Then
                Try
                    If txtPrsPpn.Text = "" Then
                        MsgBox("Isi dulu kolom ppn !!!", MsgBoxStyle.Exclamation, "Confirm")
                        txtPrsPpn.Focus()
                        btndelete.Enabled = True
                        btnedit.Enabled = True
                        BtnSave.Enabled = False
                        BtnPrint.Enabled = True
                        ContextMenuStrip.Enabled = False
                    Else
                        SQl = "Delete from tblnotretBlDtl where NoReture='" & txtnoret.Text & "' and Kdbrg='" & Me.DataGridView1.Rows(Me.rowIndex).Cells(0).Value & "'"
                        Proses.ExecuteNonQuery(SQl)
                        DataGridView1.Rows.RemoveAt(Me.rowIndex)
                        Call subtotal()
                        BtnSave.PerformClick()
                    End If
                    
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End If


        End If
    End Sub


End Class