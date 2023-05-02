<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportLPB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New Aplication_Helper.DataSet1()
        Me.LapPengembalianBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LapPengembalianBarangTableAdapter = New Aplication_Helper.DataSet1TableAdapters.LapPengembalianBarangTableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LapPengembalianBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ReportLPB"
        ReportDataSource1.Value = Me.LapPengembalianBarangBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Aplication_Helper.rptLPB.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(945, 452)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LapPengembalianBarangBindingSource
        '
        Me.LapPengembalianBarangBindingSource.DataMember = "LapPengembalianBarang"
        Me.LapPengembalianBarangBindingSource.DataSource = Me.DataSet1
        '
        'LapPengembalianBarangTableAdapter
        '
        Me.LapPengembalianBarangTableAdapter.ClearBeforeFill = True
        '
        'FrmReportLPB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 452)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReportLPB"
        Me.Text = "Form Report LPB"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LapPengembalianBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LapPengembalianBarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Aplication_Helper.DataSet1
    Friend WithEvents LapPengembalianBarangTableAdapter As Aplication_Helper.DataSet1TableAdapters.LapPengembalianBarangTableAdapter
End Class
