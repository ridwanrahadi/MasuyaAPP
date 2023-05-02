Public Class FrmDataSO
    Dim level As Integer
    Dim divisi As String
  
    Sub Pengaturandatagrid()



        Me.DataGridView1.Columns(0).HeaderText = "No SO"
        Me.DataGridView1.Columns(1).HeaderText = "No JL"
        Me.DataGridView1.Columns(2).HeaderText = "Sales code"
        Me.DataGridView1.Columns(3).HeaderText = "Tanggal"
        Me.DataGridView1.Columns(4).HeaderText = "Jam"
        Me.DataGridView1.Columns(4).DefaultCellStyle.Format = "HH:mm:ss"
        Me.DataGridView1.Columns(5).Visible = False
        Me.DataGridView1.Columns(6).HeaderText = "Nama Customer"
        Me.DataGridView1.Columns(7).HeaderText = "No PO"
        Me.DataGridView1.Columns(8).HeaderText = "Total SO"
        Me.DataGridView1.Columns(8).DefaultCellStyle.Format = "N"
        Me.DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(9).HeaderText = "Note Sales"
        Me.DataGridView1.Columns(10).HeaderText = "Aproved"
        Me.DataGridView1.Columns(11).HeaderText = "Keterangan"
        Me.DataGridView1.Columns(12).HeaderText = ""
        Me.DataGridView1.Columns(13).HeaderText = "Proses"
        Me.DataGridView1.Columns(12).Visible = False
        Me.DataGridView1.Columns(13).Visible = False
        Me.DataGridView1.Columns(10).Visible = False
        Me.DataGridView1.Columns(1).Frozen = True



    End Sub
 
    Private Sub FrmDataSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Tabel = Proses.ExecuteQuery("select * from tblPengguna where Username='" & FrmUtama.Unametxt.Text & "'")
            level = Tabel.Rows(0).Item("LevelSODesktop")
            divisi = Tabel.Rows(0).Item("divisi")
            If level > 0 Then
                Tabel = Proses.ExecuteQuery("SELECT salesorder.no_so, tblFak.NoBukti, salesorder.kd_user, salesorder.tgl_so, salesorder.jam, salesorder.kd_cust, tblCustomer.NmCust, salesorder.no_po, salesorder.grandtotal, salesorder.keterangan, salesorder.approved, salesorder.keterangan2, salesorder.batal, salesorder.proses,tblSalesPerson.DIVISI FROM salesorder INNER JOIN tblSalesPerson ON salesorder.kd_user = tblSalesPerson.KDSALES LEFT OUTER JOIN tblCustomer ON salesorder.kd_cust = tblCustomer.KdCust LEFT OUTER JOIN TblFak ON dbo.salesorder.no_so = TblFak.NoSO  where salesorder.tgl_so >= '" & DateTime1.Text & "' and salesorder.tgl_so <= '" & DateTime2.Text & "' ORDER By no_so DESC")
            Else
                Tabel = Proses.ExecuteQuery("SELECT salesorder.no_so, tblFak.NoBukti, salesorder.kd_user, salesorder.tgl_so, salesorder.jam, salesorder.kd_cust, tblCustomer.NmCust, salesorder.no_po, salesorder.grandtotal, salesorder.keterangan, salesorder.approved, salesorder.keterangan2, salesorder.batal, salesorder.proses,tblSalesPerson.DIVISI FROM salesorder INNER JOIN tblSalesPerson ON salesorder.kd_user = tblSalesPerson.KDSALES LEFT OUTER JOIN tblCustomer ON salesorder.kd_cust = tblCustomer.KdCust LEFT OUTER JOIN TblFak ON dbo.salesorder.no_so = TblFak.NoSO  where salesorder.tgl_so >= '" & DateTime1.Text & "' and salesorder.tgl_so <= '" & DateTime2.Text & "' and DIVISI='" & divisi & "' ORDER By no_so DESC")
            End If
            DataGridView1.DataSource = Tabel
            Call Pengaturandatagrid()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub ChkBatal_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBatal.CheckedChanged
        ChkApr.Checked = False
        ChkProses.Checked = False
        ChkBlmPros.Checked = False
        ChkBc.Checked = False
        txtkdsales.Text = ""
        txtNmCust.Text = ""
    End Sub

    Private Sub ChkApr_CheckedChanged(sender As Object, e As EventArgs) Handles ChkApr.CheckedChanged
        ChkBatal.Checked = False
        ChkBlmPros.Checked = False
        ChkBc.Checked = False
        ChkProses.Checked = False
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        Dim filter As String

        Try
            If ChkBatal.Checked = True And txtkdsales.Text = "" And txtNmCust.Text = "" Then
                filter = "salesorder.batal = 1 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "'"
            ElseIf ChkBatal.Checked = True And txtkdsales.Text.Trim.Length > 0 And txtNmCust.Text.Trim.Length > 0 Then
                filter = "salesorder.batal = 1 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and salesorder.kd_user like '%" & txtkdsales.Text & "%' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%'"
            ElseIf ChkBatal.Checked = True And txtkdsales.Text = "" Then
                filter = "salesorder.batal = 1 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%'"
            ElseIf ChkBatal.Checked = True And txtNmCust.Text = "" Then
                filter = "salesorder.batal = 1 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and salesorder.kd_user like '%" & txtkdsales.Text & "%'"



            ElseIf ChkApr.Checked = True And txtkdsales.Text = "" And txtNmCust.Text = "" Then
                filter = "salesorder.approved = 1 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "'"
            ElseIf ChkApr.Checked = True And txtkdsales.Text.Trim.Length > 0 And txtNmCust.Text.Trim.Length > 0 Then
                filter = "salesorder.approved = 1 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and salesorder.kd_user like '%" & txtkdsales.Text & "%' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%'"
            ElseIf ChkApr.Checked = True And txtkdsales.Text = "" Then
                filter = "salesorder.approved = 1 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%'"
            ElseIf ChkApr.Checked = True And txtNmCust.Text = "" Then
                filter = "salesorder.approved = 1 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and salesorder.kd_user like '%" & txtkdsales.Text & "%'"


            ElseIf ChkProses.Checked = True And txtkdsales.Text = "" And txtNmCust.Text = "" Then
                filter = "salesorder.proses = 1 and salesorder.approved = 0 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "'"
            ElseIf ChkProses.Checked = True And txtkdsales.Text.Trim.Length > 0 And txtNmCust.Text.Trim.Length > 0 Then
                filter = "salesorder.proses = 1 and salesorder.approved = 0 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and salesorder.kd_user like '%" & txtkdsales.Text & "%' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%'"
            ElseIf ChkProses.Checked = True And txtkdsales.Text = "" Then
                filter = "salesorder.proses = 1 salesorder.approved = 0 and and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%'"
            ElseIf ChkProses.Checked = True And txtNmCust.Text = "" Then
                filter = "salesorder.proses = 1 and salesorder.approved = 0 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and salesorder.kd_user like '%" & txtkdsales.Text & "%'"


            ElseIf ChkBlmPros.Checked = True And txtkdsales.Text = "" And txtNmCust.Text = "" Then
                filter = "salesorder.proses = 0 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "'"
            ElseIf ChkBlmPros.Checked = True And txtkdsales.Text.Trim.Length > 0 And txtNmCust.Text.Trim.Length > 0 Then
                filter = "salesorder.proses = 0 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and salesorder.kd_user like '%" & txtkdsales.Text & "%' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%'"
            ElseIf ChkBlmPros.Checked = True And txtkdsales.Text = "" Then
                filter = "salesorder.proses = 0 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%'"
            ElseIf ChkBlmPros.Checked = True And txtNmCust.Text = "" Then
                filter = "salesorder.proses = 0 and tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and salesorder.kd_user like '%" & txtkdsales.Text & "%'"

            ElseIf ChkBc.Checked = True And txtkdsales.Text = "" And txtNmCust.Text = "" Then
                filter = "salesorder.approved = 1 and tblFak.NoBukti is null and salesorder.tgl_so >= '" & DateTime1.Text & "' and salesorder.tgl_so <= '" & DateTime2.Text & "'"
            ElseIf ChkBc.Checked = True And txtkdsales.Text.Trim.Length > 0 And txtNmCust.Text.Trim.Length > 0 Then
                filter = "salesorder.approved = 1 and tblFak.NoBukti is null and salesorder.tgl_so >= '" & DateTime1.Text & "' and salesorder.tgl_so <= '" & DateTime2.Text & "' and salesorder.kd_user like '%" & txtkdsales.Text & "%' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%'"
            ElseIf ChkBc.Checked = True And txtkdsales.Text = "" Then
                filter = "salesorder.approved = 1 and tblFak.NoBukti is null and salesorder.tgl_so >= '" & DateTime1.Text & "' and salesorder.tgl_so <= '" & DateTime2.Text & "' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%'"
            ElseIf ChkBc.Checked = True And txtNmCust.Text = "" Then
                filter = "salesorder.approved = 1 and tblFak.NoBukti is null and salesorder.tgl_so >= '" & DateTime1.Text & "' and salesorder.tgl_so <= '" & DateTime2.Text & "' and salesorder.kd_user like '%" & txtkdsales.Text & "%'"


            ElseIf ChkBlmPros.Checked = False And ChkProses.Checked = False And ChkApr.Checked = False And ChkBatal.Checked = False And txtNmCust.Text.Trim.Length > 0 And txtkdsales.Text.Trim.Length > 0 Then
                filter = "tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%' and salesorder.kd_user like '%" & txtkdsales.Text & "%'"

            ElseIf ChkBlmPros.Checked = False And ChkProses.Checked = False And ChkApr.Checked = False And ChkBatal.Checked = False And txtkdsales.Text.Trim.Length > 0 Then
                filter = "tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and salesorder.kd_user like '%" & txtkdsales.Text & "%'"

            ElseIf ChkBlmPros.Checked = False And ChkProses.Checked = False And ChkApr.Checked = False And ChkBatal.Checked = False And txtNmCust.Text.Trim.Length > 0 Then
                filter = "tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "' and tblCustomer.NmCust like'%" & txtNmCust.Text & "%'"


            Else
                filter = "tgl_so >= '" & DateTime1.Text & "' and tgl_so <= '" & DateTime2.Text & "'"
            End If


            If level < 1 Then
                Tabel = Proses.ExecuteQuery("SELECT salesorder.no_so, tblFak.NoBukti, salesorder.kd_user, salesorder.tgl_so, salesorder.jam, salesorder.kd_cust, tblCustomer.NmCust, salesorder.no_po, salesorder.grandtotal, salesorder.keterangan, salesorder.approved, salesorder.keterangan2, salesorder.batal, salesorder.proses,tblSalesPerson.DIVISI FROM salesorder INNER JOIN tblSalesPerson ON salesorder.kd_user = tblSalesPerson.KDSALES LEFT OUTER JOIN tblCustomer ON salesorder.kd_cust = tblCustomer.KdCust LEFT OUTER JOIN TblFak ON dbo.salesorder.no_so = TblFak.NoSO  where " & filter & " and DIVISI='" & divisi & "' ORDER By no_so DESC")
            Else
                Tabel = Proses.ExecuteQuery("SELECT salesorder.no_so, tblFak.NoBukti, salesorder.kd_user, salesorder.tgl_so, salesorder.jam, salesorder.kd_cust, tblCustomer.NmCust, salesorder.no_po, salesorder.grandtotal, salesorder.keterangan, salesorder.approved, salesorder.keterangan2, salesorder.batal, salesorder.proses,tblSalesPerson.DIVISI FROM salesorder INNER JOIN tblSalesPerson ON salesorder.kd_user = tblSalesPerson.KDSALES LEFT OUTER JOIN tblCustomer ON salesorder.kd_cust = tblCustomer.KdCust LEFT OUTER JOIN TblFak ON dbo.salesorder.no_so = TblFak.NoSO  where " & filter & " ORDER By no_so DESC")
            End If
            DataGridView1.DataSource = Tabel



        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try



    End Sub


    Private Sub ChkBlmPros_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBlmPros.CheckedChanged
        ChkBatal.Checked = False
        ChkApr.Checked = False
        ChkBc.Checked = False
        ChkProses.Checked = False

    End Sub

    Private Sub ChkProses_CheckedChanged(sender As Object, e As EventArgs) Handles ChkProses.CheckedChanged
        ChkBlmPros.Checked = False
        ChkApr.Checked = False
        ChkBatal.Checked = False
        ChkBc.Checked = False
    End Sub

    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint

        Try
            For t As Integer = 0 To DataGridView1.Rows.Count - 1
                If Val(DataGridView1.Rows(t).Cells("Proses").Value = True And DataGridView1.Rows(t).Cells("Approved").Value = False And DataGridView1.Rows(t).Cells("Batal").Value = False) Then
                    DataGridView1.Rows(t).DefaultCellStyle.BackColor = Color.Yellow
                ElseIf Val(DataGridView1.Rows(t).Cells("Proses").Value = True And DataGridView1.Rows(t).Cells("Approved").Value = True And DataGridView1.Rows(t).Cells("Batal").Value = False) Then
                    DataGridView1.Rows(t).DefaultCellStyle.BackColor = Color.GreenYellow
                ElseIf Val(DataGridView1.Rows(t).Cells("Proses").Value = True And DataGridView1.Rows(t).Cells("Batal").Value = True) Then
                    DataGridView1.Rows(t).DefaultCellStyle.BackColor = Color.Tomato
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


    End Sub


    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        FrmSalesOrder.Dispose()
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)

            Try
                Tabel = Proses.ExecuteQuery("SELECT salesorder.no_so,tblFak.NoBukti,salesorder.no_po,salesorder.nm_cust,salesorder.alamat_kirim,salesorder.ktp, salesorder.tgl_so, salesorder.kd_cust, tblCustomer.NmCust, salesorder.kd_user, tblSalesPerson.NMSALES, salesorder.grandtotal, salesorder.PrsDisc, salesorder.Disc, salesorder.SubTotal, salesorder.keterangan,salesorder.keterangan2 FROM salesorder INNER JOIN tblCustomer ON salesorder.kd_cust = tblCustomer.KdCust LEFT OUTER JOIN tblSalesPerson ON salesorder.kd_user = tblSalesPerson.KDSALES LEFT OUTER JOIN TblFak ON dbo.salesorder.no_so = TblFak.NoSO where no_so='" & .Cells(0).Value & "'")
                FrmSalesOrder.txtNoSO.Text = Tabel.Rows(0).Item("no_so")
                FrmSalesOrder.lblTgl.Text = Tabel.Rows(0).Item("tgl_so")
                FrmSalesOrder.txtKdCust.Text = Tabel.Rows(0).Item("kd_cust")
                If Not IsDBNull(Tabel.Rows(0).Item("no_po")) Then
                    FrmSalesOrder.txtNoPo.Text = Tabel.Rows(0).Item("no_po")
                Else
                    FrmSalesOrder.txtNoPo.Text = ""
                End If
                If Not IsDBNull(Tabel.Rows(0).Item("NoBukti")) Then
                    FrmSalesOrder.txtNoBukti.Text = Tabel.Rows(0).Item("NoBukti")
                Else
                    FrmSalesOrder.txtNoBukti.Text = ""
                End If
                If Not IsDBNull(Tabel.Rows(0).Item("nm_cust")) Then
                    FrmSalesOrder.txtNmCust.Text = Tabel.Rows(0).Item("nm_cust")
                Else
                    FrmSalesOrder.txtNmCust.Text = ""
                End If
                FrmSalesOrder.lblKdSales.Text = Tabel.Rows(0).Item("kd_user")
                FrmSalesOrder.lblNmSales.Text = Tabel.Rows(0).Item("NMSALES")
                If Not IsDBNull(Tabel.Rows(0).Item("SubTotal")) Then
                    FrmSalesOrder.txtSubtotal.Text = Tabel.Rows(0).Item("SubTotal")
                Else
                    FrmSalesOrder.txtSubtotal.Text = 0
                End If
                If Not IsDBNull(Tabel.Rows(0).Item("PrsDisc")) Then
                    FrmSalesOrder.txtPrsDisc.Text = Tabel.Rows(0).Item("PrsDisc")
                Else
                    FrmSalesOrder.txtPrsDisc.Text = 0
                End If
                If Not IsDBNull(Tabel.Rows(0).Item("Disc")) Then
                    FrmSalesOrder.txtDisc.Text = Tabel.Rows(0).Item("Disc")
                Else
                    FrmSalesOrder.txtDisc.Text = 0
                End If
                FrmSalesOrder.txtTotal.Text = Tabel.Rows(0).Item("grandtotal")
                If Not IsDBNull(Tabel.Rows(0).Item("alamat_kirim")) Then
                    FrmSalesOrder.txtAlmkirim.Text = Tabel.Rows(0).Item("alamat_kirim")
                Else
                    FrmSalesOrder.txtAlmkirim.Text = ""
                End If
                If Not IsDBNull(Tabel.Rows(0).Item("ktp")) Then
                    FrmSalesOrder.txtktp.Text = Tabel.Rows(0).Item("ktp")
                Else
                    FrmSalesOrder.txtktp.Text = ""
                End If

                FrmSalesOrder.txtKet.Text = Tabel.Rows(0).Item("keterangan")
                FrmSalesOrder.txtket2.Text = Tabel.Rows(0).Item("keterangan2")
                Tabel = Proses.ExecuteQuery("Select id,no_so,item_barang,harga,jumlah,satuan,disc,disc2,disc3,subtotal from salesorder_item where no_so='" & .Cells(0).Value & "'")
                FrmSalesOrder.DataGridView2.DataSource = Tabel
                FrmSalesOrder.Show()
                FrmSalesOrder.Focus()

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End With


    End Sub

    Private Sub ChkBc_CheckedChanged(sender As Object, e As EventArgs)
        ChkBatal.Checked = False
        ChkApr.Checked = False
        ChkProses.Checked = False
    End Sub

    Private Sub ChkBc_CheckedChanged_1(sender As Object, e As EventArgs) Handles ChkBc.CheckedChanged
        ChkBatal.Checked = False
        ChkApr.Checked = False
        ChkProses.Checked = False
        ChkBlmPros.Checked = False
    End Sub

  
    Private Sub txtSO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSO.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                If divisi <> "admin" Then
                    Tabel = Proses.ExecuteQuery("SELECT salesorder.no_so, tblFak.NoBukti, salesorder.kd_user, salesorder.tgl_so, salesorder.jam, salesorder.kd_cust, tblCustomer.NmCust, salesorder.no_po, salesorder.grandtotal, salesorder.keterangan, salesorder.approved, salesorder.keterangan2, salesorder.batal, salesorder.proses,tblSalesPerson.DIVISI FROM salesorder INNER JOIN tblSalesPerson ON salesorder.kd_user = tblSalesPerson.KDSALES LEFT OUTER JOIN tblCustomer ON salesorder.kd_cust = tblCustomer.KdCust LEFT OUTER JOIN TblFak ON dbo.salesorder.no_so = TblFak.NoSO where no_so LIKE '%" & txtSO.Text & "%' and DIVISI='" & divisi & "' ORDER By no_so DESC")
                Else
                    Tabel = Proses.ExecuteQuery("SELECT salesorder.no_so, tblFak.NoBukti, salesorder.kd_user, salesorder.tgl_so, salesorder.jam, salesorder.kd_cust, tblCustomer.NmCust, salesorder.no_po, salesorder.grandtotal, salesorder.keterangan, salesorder.approved, salesorder.keterangan2, salesorder.batal, salesorder.proses,tblSalesPerson.DIVISI FROM salesorder INNER JOIN tblSalesPerson ON salesorder.kd_user = tblSalesPerson.KDSALES LEFT OUTER JOIN tblCustomer ON salesorder.kd_cust = tblCustomer.KdCust LEFT OUTER JOIN TblFak ON dbo.salesorder.no_so = TblFak.NoSO where no_so LIKE '%" & txtSO.Text & "%' ORDER By no_so DESC")
                End If
                DataGridView1.DataSource = Tabel


            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub txtJL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJL.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                If divisi <> "admin" Then
                    Tabel = Proses.ExecuteQuery("SELECT salesorder.no_so, tblFak.NoBukti, salesorder.kd_user, salesorder.tgl_so, salesorder.jam, salesorder.kd_cust, tblCustomer.NmCust, salesorder.no_po, salesorder.grandtotal, salesorder.keterangan, salesorder.approved, salesorder.keterangan2, salesorder.batal, salesorder.proses,tblSalesPerson.DIVISI FROM salesorder INNER JOIN tblSalesPerson ON salesorder.kd_user = tblSalesPerson.KDSALES LEFT OUTER JOIN tblCustomer ON salesorder.kd_cust = tblCustomer.KdCust LEFT OUTER JOIN TblFak ON dbo.salesorder.no_so = TblFak.NoSO where tblFak.NoBukti LIKE '%" & txtJL.Text & "%' and DIVISI='" & divisi & "' ORDER By no_so DESC")
                Else
                    Tabel = Proses.ExecuteQuery("SELECT salesorder.no_so, tblFak.NoBukti, salesorder.kd_user, salesorder.tgl_so, salesorder.jam, salesorder.kd_cust, tblCustomer.NmCust, salesorder.no_po, salesorder.grandtotal, salesorder.keterangan, salesorder.approved, salesorder.keterangan2, salesorder.batal, salesorder.proses,tblSalesPerson.DIVISI FROM salesorder INNER JOIN tblSalesPerson ON salesorder.kd_user = tblSalesPerson.KDSALES LEFT OUTER JOIN tblCustomer ON salesorder.kd_cust = tblCustomer.KdCust LEFT OUTER JOIN TblFak ON dbo.salesorder.no_so = TblFak.NoSO where tblFak.NoBukti LIKE '%" & txtJL.Text & "%' ORDER By no_so DESC")
                End If
                DataGridView1.DataSource = Tabel


            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub BtnTimbang_Click(sender As Object, e As EventArgs) Handles BtnTimbang.Click
        FrmTimbang.Show()
    End Sub

    Private Sub txtkdsales_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkdsales.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNmCust.Focus()
        End If
    End Sub

    Private Sub txtNmCust_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNmCust.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnProses.Focus()
        End If
    End Sub
End Class