Public Class FrmLapReture
    Sub Pengaturan_DGV()
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(8).Visible = False
    End Sub
    Private Sub FrmLapReture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Tabel = Proses.ExecuteQuery("Select * from TblIvType")
            CbType.DataSource = Tabel
            CbType.ValueMember = "NmType"
            CbType.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


    End Sub
    Private Sub BtProses_Click(sender As Object, e As EventArgs) Handles BtProses.Click
        If CbType.Text = "" Then
            DataGridView1.DataSource = ""
        Else
            Try
                Tabel = Proses.ExecuteQuery("SELECT PenjDetailIncPpn.Tgl,PenjDetailIncPpn.NmCust, PenjDetailIncPpn.KdCust,PenjDetailIncPpn.JnsTrans, tblSalesPerson.NMSALES, PenjDetailIncPpn.NoBukti, PenjDetailIncPpn.NmBrg, PenjDetailIncPpn.Qty,PenjDetailIncPpn.NmType,TblFak.Ket2 FROM  PenjDetailIncPpn INNER JOIN tblSalesPerson ON PenjDetailIncPpn.KdSales = tblSalesPerson.KDSALES INNER JOIN TblFak ON PenjDetailIncPpn.NoBukti = TblFak.NoBukti where PenjDetailIncPpn.JnsTrans = 'RJ' and NmType='" & CbType.Text & "' and PenjDetailIncPpn.tgl>='" & Dt1.Text & "' and PenjDetailIncPpn.tgl<='" & Dt2.Text & "' order by PenjDetailIncPpn.tgl asc")
                DataGridView1.DataSource = Tabel
                Call Pengaturan_DGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
       
    End Sub
End Class