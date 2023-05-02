Public Class FrmExtendLaporan
    Sub Pengaturan()
        DGVKet.Columns(0).Width = 75
        DGVKet.Columns(1).Width = 350
        DGVKet.Columns(2).Width = 335

    End Sub
    Private Sub FrmExtendLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Tabel = Proses.ExecuteQuery("Select NoJL,Keterangan,CetakNote from ViewKetJL where Suppliyer ='" & FrmLaporan.CBType.Text & "'and tanggal >= '" & FrmLaporan.TglAwal.Text & "'and tanggal <= '" & FrmLaporan.TglAkhir.Text & "' ")
            DGVKet.DataSource = Tabel
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        Call Pengaturan()
    End Sub
End Class