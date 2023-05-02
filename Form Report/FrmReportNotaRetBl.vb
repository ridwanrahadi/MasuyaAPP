Public Class FrmReportNotaRetBl


    Private Sub FrmReportNotaReture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet2.DataTable1)
        'TODO: This line of code loads data into the 'DataSet2.DataTable2' table. You can move, or remove it, as needed.
        Me.DataTable2TableAdapter.Fill(Me.DataSet2.DataTable2)
        Me.ReportViewer1.RefreshReport()


    End Sub



End Class