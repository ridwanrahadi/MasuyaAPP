Public Class FrmStock
    Sub TampilDGVStockx()
        Tabel = Proses.ExecuteQuery("Select tblIvGstk.KdBrg,tblIvMst.NmBrg, tblIvGstk.Qty From tblIvGstk INNER JOIN tblIvMst ON tblIvGstk.KdBrg = tblIvMst.KdBrg INNER JOIN tblIvType ON tblIvMst.Type = tblIvType.KdType where tblIvType.NmType='" & FrmLaporan.CBType.Text & "' and tblIvGstk.KdGd = 'x' order by tblIvGstk.KdBrg")
        DGVStockx.DataSource = Tabel
        DGVStockx.Columns(0).Width = 70
        DGVStockx.Columns(1).Width = 275
        DGVStockx.Columns(2).Width = 80
    End Sub
    Sub TampilDGVStock()
        Tabel = Proses.ExecuteQuery("Select tblIvGstk.KdBrg,tblIvMst.NmBrg, tblIvGstk.Qty From tblIvGstk INNER JOIN tblIvMst ON tblIvGstk.KdBrg = tblIvMst.KdBrg INNER JOIN tblIvType ON tblIvMst.Type = tblIvType.KdType where tblIvType.NmType='" & FrmLaporan.CBType.Text & "' and tblIvGstk.KdGd = 'a' order by tblIvGstk.KdBrg")
        DGVStock.DataSource = Tabel
        DGVStock.Columns(0).Width = 70
        DGVStock.Columns(1).Width = 275
        DGVStock.Columns(2).Width = 80

    End Sub
    Private Sub FrmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = FrmLaporan.CBType.Text
        Call TampilDGVStock()
        Call TampilDGVStockx()
    End Sub
End Class