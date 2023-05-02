<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExtendGudang
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
        Me.BtKedatangan = New System.Windows.Forms.Button()
        Me.BtReture = New System.Windows.Forms.Button()
        Me.BtLapReture = New System.Windows.Forms.Button()
        Me.btnprintvalet = New System.Windows.Forms.Button()
        Me.btnRpb = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtKedatangan
        '
        Me.BtKedatangan.Location = New System.Drawing.Point(19, 24)
        Me.BtKedatangan.Name = "BtKedatangan"
        Me.BtKedatangan.Size = New System.Drawing.Size(75, 57)
        Me.BtKedatangan.TabIndex = 0
        Me.BtKedatangan.Text = "Kedatangan"
        Me.BtKedatangan.UseVisualStyleBackColor = True
        '
        'BtReture
        '
        Me.BtReture.Location = New System.Drawing.Point(100, 24)
        Me.BtReture.Name = "BtReture"
        Me.BtReture.Size = New System.Drawing.Size(75, 57)
        Me.BtReture.TabIndex = 1
        Me.BtReture.Text = "LPB"
        Me.BtReture.UseVisualStyleBackColor = True
        '
        'BtLapReture
        '
        Me.BtLapReture.Location = New System.Drawing.Point(182, 24)
        Me.BtLapReture.Name = "BtLapReture"
        Me.BtLapReture.Size = New System.Drawing.Size(75, 57)
        Me.BtLapReture.TabIndex = 2
        Me.BtLapReture.Text = "Laporan reture"
        Me.BtLapReture.UseVisualStyleBackColor = True
        '
        'btnprintvalet
        '
        Me.btnprintvalet.Location = New System.Drawing.Point(19, 87)
        Me.btnprintvalet.Name = "btnprintvalet"
        Me.btnprintvalet.Size = New System.Drawing.Size(156, 57)
        Me.btnprintvalet.TabIndex = 3
        Me.btnprintvalet.Text = "Print Label Valet Gudang"
        Me.btnprintvalet.UseVisualStyleBackColor = True
        '
        'btnRpb
        '
        Me.btnRpb.Location = New System.Drawing.Point(182, 87)
        Me.btnRpb.Name = "btnRpb"
        Me.btnRpb.Size = New System.Drawing.Size(75, 57)
        Me.btnRpb.TabIndex = 4
        Me.btnRpb.Text = "RPB"
        Me.btnRpb.UseVisualStyleBackColor = True
        '
        'FrmExtendGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 161)
        Me.Controls.Add(Me.btnRpb)
        Me.Controls.Add(Me.btnprintvalet)
        Me.Controls.Add(Me.BtLapReture)
        Me.Controls.Add(Me.BtReture)
        Me.Controls.Add(Me.BtKedatangan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmExtendGudang"
        Me.ShowIcon = False
        Me.Text = "Gudang"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtKedatangan As System.Windows.Forms.Button
    Friend WithEvents BtReture As System.Windows.Forms.Button
    Friend WithEvents BtLapReture As System.Windows.Forms.Button
    Friend WithEvents btnprintvalet As System.Windows.Forms.Button
    Friend WithEvents btnRpb As System.Windows.Forms.Button
End Class
