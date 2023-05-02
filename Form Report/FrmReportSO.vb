Public Class FrmReportSO

    Private Sub FrmReportSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Try
            Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
            Me.ReportViewer1.RefreshReport()
            FrmSalesOrder.ChkPrint.Checked = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try



    End Sub

   
End Class