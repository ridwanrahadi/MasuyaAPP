<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKedatangan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DT = New System.Windows.Forms.DateTimePicker()
        Me.BtPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal"
        '
        'DT
        '
        Me.DT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT.Location = New System.Drawing.Point(64, 9)
        Me.DT.Name = "DT"
        Me.DT.Size = New System.Drawing.Size(119, 20)
        Me.DT.TabIndex = 1
        '
        'BtPrint
        '
        Me.BtPrint.Location = New System.Drawing.Point(108, 35)
        Me.BtPrint.Name = "BtPrint"
        Me.BtPrint.Size = New System.Drawing.Size(75, 23)
        Me.BtPrint.TabIndex = 2
        Me.BtPrint.Text = "Print"
        Me.BtPrint.UseVisualStyleBackColor = True
        '
        'FrmKedatangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 71)
        Me.Controls.Add(Me.BtPrint)
        Me.Controls.Add(Me.DT)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmKedatangan"
        Me.ShowIcon = False
        Me.Text = "Report Kedatangan Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DT As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtPrint As System.Windows.Forms.Button
End Class
