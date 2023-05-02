
Public Class FrmPrintPO

    Private Sub BtPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPreview.Click
        If Potxt.Text = "" Then
            MsgBox("Nomor PO belum terisi", MsgBoxStyle.Exclamation, "Pesan")
        Else
            Try
                Tabel = Proses.ExecuteQuery("select nobukti from tblPO where nobukti='" & Potxt.Text & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("Nomor PO tersebut tidak ditemukan", MsgBoxStyle.Critical, "Pesan")
                Else
                    FrmReportPO.ViewPO2017BindingSource.Filter = "(NoBukti='" & Potxt.Text & "')"
                    FrmReportPO.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub BtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtExit.Click
        Me.Dispose()
    End Sub
End Class