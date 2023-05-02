Public Class FrmHisBeliNoFP
    Private Sub BTProses_Click(sender As Object, e As EventArgs) Handles BTProses.Click
        If CBBulan.Text = "" Or txttahun.Text = "" Then
            MsgBox("Lengkapi data filter...", MsgBoxStyle.Exclamation, "Konfirmasi")
        Else
            Try
                Tabel = Proses.ExecuteQuery("SELECT NoBukti, KdSup, Total, NoFP, TglFP, Tgl, MONTH(Tgl) AS Bulan, YEAR(Tgl) AS Tahun from tblbeli where MONTH(Tgl)='" & CBBulan.Text & "' and YEAR(Tgl)='" & txttahun.Text & "' ")
                DGV.DataSource = Tabel
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub
End Class