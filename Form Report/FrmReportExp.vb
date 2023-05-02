Public Class FrmReportExp

    Private Sub FrmReportExp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet4.TblExpanse' table. You can move, or remove it, as needed.
        Me.TblExpanseTableAdapter.Fill(Me.DataSet4.TblExpanse)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class