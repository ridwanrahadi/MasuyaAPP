Public Class FrmExtendGudang

    Private Sub BtKedatangan_Click(sender As Object, e As EventArgs) Handles BtKedatangan.Click
        FrmKedatangan.Show()
        Me.Hide()
    End Sub

    Private Sub BtReture_Click(sender As Object, e As EventArgs) Handles BtReture.Click
        FrmRetur.Show()
        Me.Hide()
    End Sub

    Private Sub BtLapReture_Click(sender As Object, e As EventArgs) Handles BtLapReture.Click
        FrmLapReture.Show()
        Me.Hide()
    End Sub
    Private Sub btnprintvalet_Click(sender As Object, e As EventArgs) Handles btnprintvalet.Click
        FrmLabelValet.Show()
        Me.Hide()
    End Sub

    Private Sub btnRpb_Click(sender As Object, e As EventArgs) Handles btnRpb.Click
        FrmRPB.Show()
        Me.Hide()
    End Sub
End Class