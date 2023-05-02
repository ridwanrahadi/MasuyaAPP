Public Class SelectedTax

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmTax.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmHisBeliNoFP.Show()
        Me.Hide()
    End Sub

    Private Sub BtExport_Click(sender As Object, e As EventArgs) Handles BtExport.Click
        FrmExportTax.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmIsiNoFP.Show()
    End Sub

    Private Sub btnnota_Click(sender As Object, e As EventArgs) Handles btnnota.Click
        FrmNotRet.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmNotRetBl.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmIsiFPBL.Show()
        Me.Hide()
    End Sub
End Class