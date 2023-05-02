Public Class FrmSelKlaim

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmKlaim.Show()
        Me.Dispose()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmPelunasanKlaim.Show()
        Me.Dispose()
    End Sub
End Class