Public Class FrmReportLPB

    Private Sub FrmReportLPB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.LapPengembalianBarang' table. You can move, or remove it, as needed.
        Me.LapPengembalianBarangTableAdapter.Fill(Me.DataSet1.LapPengembalianBarang)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class