Public Class FrmCalpis
    Private Sub IsiSales()
        Tabel = Proses.ExecuteQuery("Select * from tblSalesPerson")
        CbNmSales.DataSource = Tabel
        CbNmSales.DisplayMember = "NmSales"
        CbNmSales.SelectedIndex = -1
    End Sub
    Sub Rapih()
        DGV.Columns(0).Width = 100
        DGV.Columns(1).Width = 200
        DGV.Columns(2).Width = 75
        DGV.Columns(3).Width = 100
        DGV.Columns(4).Width = 200
    End Sub
    Private Sub Pengaturan()
        Select Case Status
            Case True
                BTSimpan.Enabled = False
                BTKembali.Enabled = False
                BTEdit.Enabled = False
                BTHapus.Enabled = False
                BTBaru.Enabled = True
                DGV.ReadOnly = True
            Case False
                BTSimpan.Enabled = True
                BTKembali.Enabled = True
                BTEdit.Enabled = True
                BTHapus.Enabled = True
                BTBaru.Enabled = False
                DGV.ReadOnly = False
        End Select
    End Sub
    Private Sub BTBaru_Click(sender As Object, e As EventArgs) Handles BTBaru.Click
        Status = False
        DGV.ColumnCount = 5
        DGV.Columns(0).HeaderText = "Kode Barang"
        DGV.Columns(1).HeaderText = "Nama Barang"
        DGV.Columns(2).HeaderText = "Quantity"
        DGV.Columns(3).HeaderText = "Harga"
        DGV.Columns(4).HeaderText = "Keterangan"
        Rapih()
        Call Pengaturan()
        txtNmCust.Focus()
        txtNoRef.Text = Kode.Generate("tblCalpis", "NoRef")
    End Sub

    Private Sub FrmCalpis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Status = True
        IsiSales()
        Call Pengaturan()
    End Sub
End Class