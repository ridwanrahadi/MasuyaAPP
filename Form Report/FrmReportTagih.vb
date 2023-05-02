Public Class FrmReportTagih

    Private Sub FrmReportTagih_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblTagih' table. You can move, or remove it, as needed.
        Me.tblTagihTableAdapter.Fill(Me.DataSet1.tblTagih)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class