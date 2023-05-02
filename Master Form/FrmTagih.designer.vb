<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTagih
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
        Me.DGVKw = New System.Windows.Forms.DataGridView()
        Me.BtSimpan = New System.Windows.Forms.Button()
        Me.NoTrans = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtPrintKw = New System.Windows.Forms.Button()
        Me.BtKembali = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NmKolektxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KW = New System.Windows.Forms.RadioButton()
        Me.JL = New System.Windows.Forms.RadioButton()
        Me.BtAnalis = New System.Windows.Forms.Button()
        Me.BtEdit = New System.Windows.Forms.Button()
        Me.BtBaru = New System.Windows.Forms.Button()
        Me.BtnHistory = New System.Windows.Forms.Button()
        CType(Me.DGVKw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVKw
        '
        Me.DGVKw.AllowUserToOrderColumns = True
        Me.DGVKw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVKw.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGVKw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVKw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVKw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVKw.Location = New System.Drawing.Point(6, 19)
        Me.DGVKw.Name = "DGVKw"
        Me.DGVKw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVKw.Size = New System.Drawing.Size(416, 339)
        Me.DGVKw.TabIndex = 3
        '
        'BtSimpan
        '
        Me.BtSimpan.Location = New System.Drawing.Point(284, 450)
        Me.BtSimpan.Name = "BtSimpan"
        Me.BtSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtSimpan.TabIndex = 6
        Me.BtSimpan.Text = "Simpan"
        Me.BtSimpan.UseVisualStyleBackColor = True
        '
        'NoTrans
        '
        Me.NoTrans.Location = New System.Drawing.Point(343, 12)
        Me.NoTrans.Name = "NoTrans"
        Me.NoTrans.Size = New System.Drawing.Size(87, 20)
        Me.NoTrans.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGVKw)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 364)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'BtPrintKw
        '
        Me.BtPrintKw.Location = New System.Drawing.Point(12, 450)
        Me.BtPrintKw.Name = "BtPrintKw"
        Me.BtPrintKw.Size = New System.Drawing.Size(75, 23)
        Me.BtPrintKw.TabIndex = 17
        Me.BtPrintKw.Text = "Print "
        Me.BtPrintKw.UseVisualStyleBackColor = True
        '
        'BtKembali
        '
        Me.BtKembali.Location = New System.Drawing.Point(365, 450)
        Me.BtKembali.Name = "BtKembali"
        Me.BtKembali.Size = New System.Drawing.Size(75, 23)
        Me.BtKembali.TabIndex = 18
        Me.BtKembali.Text = "Kembali"
        Me.BtKembali.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Nama Kolektor :"
        '
        'NmKolektxt
        '
        Me.NmKolektxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NmKolektxt.Location = New System.Drawing.Point(109, 12)
        Me.NmKolektxt.Name = "NmKolektxt"
        Me.NmKolektxt.Size = New System.Drawing.Size(159, 20)
        Me.NmKolektxt.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(296, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "No Ref"
        '
        'KW
        '
        Me.KW.AutoSize = True
        Me.KW.Location = New System.Drawing.Point(23, 57)
        Me.KW.Name = "KW"
        Me.KW.Size = New System.Drawing.Size(70, 17)
        Me.KW.TabIndex = 22
        Me.KW.TabStop = True
        Me.KW.Text = "Input KW"
        Me.KW.UseVisualStyleBackColor = True
        '
        'JL
        '
        Me.JL.AutoSize = True
        Me.JL.Location = New System.Drawing.Point(156, 57)
        Me.JL.Name = "JL"
        Me.JL.Size = New System.Drawing.Size(63, 17)
        Me.JL.TabIndex = 23
        Me.JL.TabStop = True
        Me.JL.Text = "Input JL"
        Me.JL.UseVisualStyleBackColor = True
        '
        'BtAnalis
        '
        Me.BtAnalis.Location = New System.Drawing.Point(332, 57)
        Me.BtAnalis.Name = "BtAnalis"
        Me.BtAnalis.Size = New System.Drawing.Size(98, 23)
        Me.BtAnalis.TabIndex = 24
        Me.BtAnalis.Text = "Analisis Piutang"
        Me.BtAnalis.UseVisualStyleBackColor = True
        '
        'BtEdit
        '
        Me.BtEdit.Location = New System.Drawing.Point(122, 450)
        Me.BtEdit.Name = "BtEdit"
        Me.BtEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtEdit.TabIndex = 25
        Me.BtEdit.Text = "Edit"
        Me.BtEdit.UseVisualStyleBackColor = True
        '
        'BtBaru
        '
        Me.BtBaru.Location = New System.Drawing.Point(203, 450)
        Me.BtBaru.Name = "BtBaru"
        Me.BtBaru.Size = New System.Drawing.Size(75, 23)
        Me.BtBaru.TabIndex = 16
        Me.BtBaru.Text = "Baru"
        Me.BtBaru.UseVisualStyleBackColor = True
        '
        'BtnHistory
        '
        Me.BtnHistory.Location = New System.Drawing.Point(239, 57)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(87, 23)
        Me.BtnHistory.TabIndex = 26
        Me.BtnHistory.Text = "History tagihan"
        Me.BtnHistory.UseVisualStyleBackColor = True
        '
        'FrmTagih
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 481)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.BtEdit)
        Me.Controls.Add(Me.BtAnalis)
        Me.Controls.Add(Me.JL)
        Me.Controls.Add(Me.KW)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NmKolektxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NoTrans)
        Me.Controls.Add(Me.BtKembali)
        Me.Controls.Add(Me.BtSimpan)
        Me.Controls.Add(Me.BtBaru)
        Me.Controls.Add(Me.BtPrintKw)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmTagih"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tagihan"
        CType(Me.DGVKw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVKw As System.Windows.Forms.DataGridView
    Friend WithEvents BtSimpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtPrintKw As System.Windows.Forms.Button
    Friend WithEvents NoTrans As System.Windows.Forms.TextBox
    Friend WithEvents BtKembali As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NmKolektxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KW As System.Windows.Forms.RadioButton
    Friend WithEvents JL As System.Windows.Forms.RadioButton
    Friend WithEvents BtAnalis As System.Windows.Forms.Button
    Friend WithEvents BtEdit As System.Windows.Forms.Button
    Friend WithEvents BtBaru As System.Windows.Forms.Button
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
End Class
