Public Class FrmReportLabel

    Private Sub FrmReportLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataLabel' table. You can move, or remove it, as needed.
        Dim QR_code As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Me.DataLabelTableAdapter.Fill(Me.DataSet1.DataLabel)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class