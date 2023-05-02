Public Class FrmKedatangan

    Private Sub BtPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPrint.Click

        Try

          
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
End Class