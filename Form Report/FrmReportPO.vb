Public Class FrmReportPO



    Private Sub FrmReportPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DataSet2.ViewPO2017' table. You can move, or remove it, as needed.
        Try
            Me.ViewPO2017TableAdapter.Fill(Me.DataSet2.ViewPO2017)
            Me.ReportPO.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        
    End Sub

  
End Class