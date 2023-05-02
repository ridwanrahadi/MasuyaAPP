<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIsiFPBL
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoBL = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.DtFP = New System.Windows.Forms.DateTimePicker()
        Me.DtSPM = New System.Windows.Forms.DateTimePicker()
        Me.txtNoFP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No BL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl FP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tgl SPM"
        '
        'txtNoBL
        '
        Me.txtNoBL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoBL.Location = New System.Drawing.Point(92, 12)
        Me.txtNoBL.Name = "txtNoBL"
        Me.txtNoBL.Size = New System.Drawing.Size(110, 20)
        Me.txtNoBL.TabIndex = 3
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(142, 130)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 7
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(223, 130)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'DtFP
        '
        Me.DtFP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFP.Location = New System.Drawing.Point(92, 64)
        Me.DtFP.Name = "DtFP"
        Me.DtFP.Size = New System.Drawing.Size(110, 20)
        Me.DtFP.TabIndex = 9
        '
        'DtSPM
        '
        Me.DtSPM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtSPM.Location = New System.Drawing.Point(92, 90)
        Me.DtSPM.Name = "DtSPM"
        Me.DtSPM.Size = New System.Drawing.Size(110, 20)
        Me.DtSPM.TabIndex = 10
        '
        'txtNoFP
        '
        Me.txtNoFP.Location = New System.Drawing.Point(92, 38)
        Me.txtNoFP.Name = "txtNoFP"
        Me.txtNoFP.Size = New System.Drawing.Size(156, 20)
        Me.txtNoFP.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "No FP"
        '
        'FrmIsiFPBL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 165)
        Me.Controls.Add(Me.txtNoFP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DtSPM)
        Me.Controls.Add(Me.DtFP)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.txtNoBL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "FrmIsiFPBL"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Isi FP Pembelian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoBL As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents DtFP As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtSPM As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoFP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
