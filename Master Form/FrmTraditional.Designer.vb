<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraditional
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBTempo = New System.Windows.Forms.RadioButton()
        Me.RBKirim = New System.Windows.Forms.RadioButton()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BTProses = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBTempo)
        Me.GroupBox1.Controls.Add(Me.RBKirim)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(823, 42)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'RBTempo
        '
        Me.RBTempo.AutoSize = True
        Me.RBTempo.Location = New System.Drawing.Point(475, 19)
        Me.RBTempo.Name = "RBTempo"
        Me.RBTempo.Size = New System.Drawing.Size(141, 17)
        Me.RBTempo.TabIndex = 1
        Me.RBTempo.TabStop = True
        Me.RBTempo.Text = "-1 Tanggal Jatuh Tempo"
        Me.RBTempo.UseVisualStyleBackColor = True
        '
        'RBKirim
        '
        Me.RBKirim.AutoSize = True
        Me.RBKirim.Location = New System.Drawing.Point(632, 19)
        Me.RBKirim.Name = "RBKirim"
        Me.RBKirim.Size = New System.Drawing.Size(171, 17)
        Me.RBKirim.TabIndex = 2
        Me.RBKirim.TabStop = True
        Me.RBKirim.Text = "14 Hari dari tanggal pengiriman"
        Me.RBKirim.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 87)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(823, 478)
        Me.DGV.TabIndex = 1
        '
        'BTProses
        '
        Me.BTProses.Location = New System.Drawing.Point(760, 58)
        Me.BTProses.Name = "BTProses"
        Me.BTProses.Size = New System.Drawing.Size(75, 23)
        Me.BTProses.TabIndex = 2
        Me.BTProses.Text = "Proses"
        Me.BTProses.UseVisualStyleBackColor = True
        '
        'FrmTraditional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 578)
        Me.Controls.Add(Me.BTProses)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmTraditional"
        Me.ShowIcon = False
        Me.Text = "Anilisis Piutang Traditional"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBTempo As System.Windows.Forms.RadioButton
    Friend WithEvents RBKirim As System.Windows.Forms.RadioButton
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents BTProses As System.Windows.Forms.Button
End Class
