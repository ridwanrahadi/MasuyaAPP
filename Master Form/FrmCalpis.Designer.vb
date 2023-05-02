<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalpis
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoRef = New System.Windows.Forms.TextBox()
        Me.txtNmCust = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.DT = New System.Windows.Forms.DateTimePicker()
        Me.CbNmSales = New System.Windows.Forms.ComboBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BTBaru = New System.Windows.Forms.Button()
        Me.BTSimpan = New System.Windows.Forms.Button()
        Me.BTEdit = New System.Windows.Forms.Button()
        Me.BTHapus = New System.Windows.Forms.Button()
        Me.BTKembali = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Ref"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat Customer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(539, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Sales"
        '
        'txtNoRef
        '
        Me.txtNoRef.Location = New System.Drawing.Point(118, 10)
        Me.txtNoRef.Name = "txtNoRef"
        Me.txtNoRef.ReadOnly = True
        Me.txtNoRef.Size = New System.Drawing.Size(100, 20)
        Me.txtNoRef.TabIndex = 5
        '
        'txtNmCust
        '
        Me.txtNmCust.Location = New System.Drawing.Point(118, 34)
        Me.txtNmCust.Name = "txtNmCust"
        Me.txtNmCust.Size = New System.Drawing.Size(223, 20)
        Me.txtNmCust.TabIndex = 6
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(118, 59)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(223, 48)
        Me.txtAlamat.TabIndex = 7
        '
        'DT
        '
        Me.DT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT.Location = New System.Drawing.Point(118, 113)
        Me.DT.Name = "DT"
        Me.DT.Size = New System.Drawing.Size(144, 20)
        Me.DT.TabIndex = 8
        '
        'CbNmSales
        '
        Me.CbNmSales.FormattingEnabled = True
        Me.CbNmSales.Location = New System.Drawing.Point(609, 10)
        Me.CbNmSales.Name = "CbNmSales"
        Me.CbNmSales.Size = New System.Drawing.Size(121, 21)
        Me.CbNmSales.TabIndex = 9
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(19, 153)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(711, 197)
        Me.DGV.TabIndex = 10
        '
        'BTBaru
        '
        Me.BTBaru.Location = New System.Drawing.Point(350, 124)
        Me.BTBaru.Name = "BTBaru"
        Me.BTBaru.Size = New System.Drawing.Size(58, 23)
        Me.BTBaru.TabIndex = 11
        Me.BTBaru.Text = "Baru"
        Me.BTBaru.UseVisualStyleBackColor = True
        '
        'BTSimpan
        '
        Me.BTSimpan.Location = New System.Drawing.Point(431, 124)
        Me.BTSimpan.Name = "BTSimpan"
        Me.BTSimpan.Size = New System.Drawing.Size(58, 23)
        Me.BTSimpan.TabIndex = 12
        Me.BTSimpan.Text = "Simpan"
        Me.BTSimpan.UseVisualStyleBackColor = True
        '
        'BTEdit
        '
        Me.BTEdit.Location = New System.Drawing.Point(512, 124)
        Me.BTEdit.Name = "BTEdit"
        Me.BTEdit.Size = New System.Drawing.Size(58, 23)
        Me.BTEdit.TabIndex = 13
        Me.BTEdit.Text = "Edit"
        Me.BTEdit.UseVisualStyleBackColor = True
        '
        'BTHapus
        '
        Me.BTHapus.Location = New System.Drawing.Point(593, 124)
        Me.BTHapus.Name = "BTHapus"
        Me.BTHapus.Size = New System.Drawing.Size(59, 23)
        Me.BTHapus.TabIndex = 14
        Me.BTHapus.Text = "Hapus"
        Me.BTHapus.UseVisualStyleBackColor = True
        '
        'BTKembali
        '
        Me.BTKembali.Location = New System.Drawing.Point(674, 124)
        Me.BTKembali.Name = "BTKembali"
        Me.BTKembali.Size = New System.Drawing.Size(56, 23)
        Me.BTKembali.TabIndex = 15
        Me.BTKembali.Text = "Kembali"
        Me.BTKembali.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Total Qty"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(395, 356)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 20)
        Me.TextBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(600, 356)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 20)
        Me.TextBox2.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(526, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total Rupiah"
        '
        'FrmCalpis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 383)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTKembali)
        Me.Controls.Add(Me.BTHapus)
        Me.Controls.Add(Me.BTEdit)
        Me.Controls.Add(Me.BTSimpan)
        Me.Controls.Add(Me.BTBaru)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.CbNmSales)
        Me.Controls.Add(Me.DT)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNmCust)
        Me.Controls.Add(Me.txtNoRef)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmCalpis"
        Me.Text = "ForCalpis"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNoRef As System.Windows.Forms.TextBox
    Friend WithEvents txtNmCust As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents DT As System.Windows.Forms.DateTimePicker
    Friend WithEvents CbNmSales As System.Windows.Forms.ComboBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents BTBaru As System.Windows.Forms.Button
    Friend WithEvents BTSimpan As System.Windows.Forms.Button
    Friend WithEvents BTEdit As System.Windows.Forms.Button
    Friend WithEvents BTHapus As System.Windows.Forms.Button
    Friend WithEvents BTKembali As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
