Public Class FrmTimbang
    Dim divisi As String
    Sub Pengaturangrid2()
        Me.DataGridView1.Columns(1).Frozen = True
        Me.DataGridView1.Columns(2).HeaderText = "Kode Sales"
        Me.DataGridView1.Columns(5).HeaderText = "Kode Barang"
        Me.DataGridView1.Columns(3).HeaderText = "Tanggal"
        Me.DataGridView1.Columns(4).HeaderText = "Jam"
        Me.DataGridView1.Columns(4).DefaultCellStyle.Format = "HH:mm:ss"
        Me.DataGridView1.Columns(6).DefaultCellStyle.Format = "N"
        Me.DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(7).HeaderText = "Qty"
        Me.DataGridView1.Columns(7).DefaultCellStyle.Format = "N"
        Me.DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(9).HeaderText = "Kode Customer"
        Me.DataGridView1.Columns(10).HeaderText = "Nama Customer"
        Me.DataGridView1.Columns(11).HeaderText = "Alamat Kirim"
        Me.DataGridView1.Columns(12).HeaderText = "Note Sales"
        Me.DataGridView1.Columns(13).HeaderText = "Keterangan Akunting"
        Me.DataGridView1.Columns(14).Visible = False
        Me.DataGridView1.Columns(15).Visible = False
        Me.DataGridView1.Columns(16).Visible = False
    End Sub
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Try
            Tabel = Proses.ExecuteQuery("select * from tblPengguna where Username='" & FrmUtama.Unametxt.Text & "'")
            divisi = Tabel.Rows(0).Item("LevelSODesktop")
            If divisi < 1 Then
                Tabel = Proses.ExecuteQuery("SELECT * from SoKiloan where SoKiloan.tgl_so >= '" & DateTime1.Text & "' and SoKiloan.tgl_so <= '" & DateTime2.Text & "' and DIVISI='" & divisi & "' ORDER By SoKiloan.no_so DESC")
            Else
                Tabel = Proses.ExecuteQuery("SELECT * from SoKiloan where SoKiloan.tgl_so >= '" & DateTime1.Text & "' and SoKiloan.tgl_so <= '" & DateTime2.Text & "' ORDER By SoKiloan.no_so DESC")
            End If
            DataGridView1.DataSource = Tabel
            Call Pengaturangrid2()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
        Try
            For t As Integer = 0 To DataGridView1.Rows.Count - 1
                If Val(DataGridView1.Rows(t).Cells("Proses").Value = True And DataGridView1.Rows(t).Cells("Approved").Value = False And DataGridView1.Rows(t).Cells("Batal").Value = False) Then
                    DataGridView1.Rows(t).DefaultCellStyle.BackColor = Color.Yellow
                ElseIf Val(DataGridView1.Rows(t).Cells("Proses").Value = True And DataGridView1.Rows(t).Cells("Approved").Value = True And DataGridView1.Rows(t).Cells("Batal").Value = False) Then
                    DataGridView1.Rows(t).DefaultCellStyle.BackColor = Color.GreenYellow
                ElseIf Val(DataGridView1.Rows(t).Cells("Proses").Value = True And DataGridView1.Rows(t).Cells("Batal").Value = True) Then
                    DataGridView1.Rows(t).DefaultCellStyle.BackColor = Color.Violet
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
                Tabel = Proses.ExecuteQuery("SELECT salesorder.no_so,salesorder.NoBukti,salesorder.no_po,salesorder.nm_cust,salesorder.alamat_kirim,salesorder.ktp, salesorder.tgl_so, salesorder.kd_cust, tblCustomer.NmCust, salesorder.kd_user, tblSalesPerson.NMSALES, salesorder.grandtotal, salesorder.prsdisc, salesorder.disc, salesorder.subtotal, salesorder.keterangan,salesorder.keterangan2 FROM salesorder INNER JOIN tblCustomer ON salesorder.kd_cust = tblCustomer.KdCust LEFT OUTER JOIN tblSalesPerson ON salesorder.kd_user = tblSalesPerson.KDSALES where no_so='" & .Cells(0).Value & "'")
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
                FrmSalesOrder.txtSubtotal.Text = Tabel.Rows(0).Item("SubTotal")
                FrmSalesOrder.txtPrsDisc.Text = Tabel.Rows(0).Item("PrsDisc")
                FrmSalesOrder.txtDisc.Text = Tabel.Rows(0).Item("Disc")
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
End Class