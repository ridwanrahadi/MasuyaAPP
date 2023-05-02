<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintPO
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
        Me.Potxt = New System.Windows.Forms.TextBox()
        Me.BtPreview = New System.Windows.Forms.Button()
        Me.BtExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No PO :"
        '
        'Potxt
        '
        Me.Potxt.Location = New System.Drawing.Point(63, 6)
        Me.Potxt.Name = "Potxt"
        Me.Potxt.Size = New System.Drawing.Size(100, 20)
        Me.Potxt.TabIndex = 1
        '
        'BtPreview
        '
        Me.BtPreview.Location = New System.Drawing.Point(178, 4)
        Me.BtPreview.Name = "BtPreview"
        Me.BtPreview.Size = New System.Drawing.Size(75, 23)
        Me.BtPreview.TabIndex = 2
        Me.BtPreview.Text = "Preview"
        Me.BtPreview.UseVisualStyleBackColor = True
        '
        'BtExit
        '
        Me.BtExit.Location = New System.Drawing.Point(178, 33)
        Me.BtExit.Name = "BtExit"
        Me.BtExit.Size = New System.Drawing.Size(75, 23)
        Me.BtExit.TabIndex = 3
        Me.BtExit.Text = "Exit"
        Me.BtExit.UseVisualStyleBackColor = True
        '
        'FrmPrintPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 71)
        Me.Controls.Add(Me.BtExit)
        Me.Controls.Add(Me.BtPreview)
        Me.Controls.Add(Me.Potxt)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmPrintPO"
        Me.ShowIcon = False
        Me.Text = "Print PO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Potxt As System.Windows.Forms.TextBox
    Friend WithEvents BtPreview As System.Windows.Forms.Button
    Friend WithEvents BtExit As System.Windows.Forms.Button
End Class
