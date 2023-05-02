<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportPO
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
        Me.ViewPO2017BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New Aplication_Helper.DataSet2()
        Me.ReportPO = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ViewPO2017TableAdapter = New Aplication_Helper.DataSet2TableAdapters.ViewPO2017TableAdapter()
        CType(Me.ViewPO2017BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewPO2017BindingSource
        '
        Me.ViewPO2017BindingSource.DataMember = "ViewPO2017"
        Me.ViewPO2017BindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportPO
        '
        Me.ReportPO.AutoSize = True
        Me.ReportPO.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetPO"
        ReportDataSource1.Value = Me.ViewPO2017BindingSource
        Me.ReportPO.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportPO.LocalReport.ReportEmbeddedResource = "Aplication_Helper.ReportPO.rdlc"
        Me.ReportPO.Location = New System.Drawing.Point(0, 0)
        Me.ReportPO.Name = "ReportPO"
        Me.ReportPO.Size = New System.Drawing.Size(1338, 742)
        Me.ReportPO.TabIndex = 0
        '
        'ViewPO2017TableAdapter
        '
        Me.ViewPO2017TableAdapter.ClearBeforeFill = True
        '
        'FrmReportPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 742)
        Me.Controls.Add(Me.ReportPO)
        Me.Name = "FrmReportPO"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Purchase Order"
        CType(Me.ViewPO2017BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportPO As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ViewPO2017BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2 As Aplication_Helper.DataSet2
    Friend WithEvents ViewPO2017TableAdapter As Aplication_Helper.DataSet2TableAdapters.ViewPO2017TableAdapter
End Class
