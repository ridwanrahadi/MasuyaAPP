<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportTaxReture
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
        Me.BtProses = New System.Windows.Forms.Button()
        Me.BtImport = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BtClear = New System.Windows.Forms.Button()
        Me.txtNoBukti = New System.Windows.Forms.TextBox()
        Me.DGV_DATA = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.RK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPWP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KD_JENIS_TRANSAKSI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FG_PENGGANTI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMOR_FAKTUR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TANGGAL_FAKTUR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TANGGAL_RETUR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMOR_DOKUMEN_RETUR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MASA_PAJAK_RETUR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAHUN_PAJAK_RETUR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NILAI_RETUR_DPP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NILAI_RETUR_PPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NILAI_RETUR_PPNBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_DATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtProses
        '
        Me.BtProses.Location = New System.Drawing.Point(161, 41)
        Me.BtProses.Name = "BtProses"
        Me.BtProses.Size = New System.Drawing.Size(75, 23)
        Me.BtProses.TabIndex = 12
        Me.BtProses.Text = "Proses"
        Me.BtProses.UseVisualStyleBackColor = True
        '
        'BtImport
        '
        Me.BtImport.Location = New System.Drawing.Point(161, 12)
        Me.BtImport.Name = "BtImport"
        Me.BtImport.Size = New System.Drawing.Size(75, 23)
        Me.BtImport.TabIndex = 11
        Me.BtImport.Text = "Import"
        Me.BtImport.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.ColumnHeadersVisible = False
        Me.DGV.Location = New System.Drawing.Point(12, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(143, 231)
        Me.DGV.TabIndex = 10
        '
        'BtClear
        '
        Me.BtClear.Location = New System.Drawing.Point(602, 246)
        Me.BtClear.Name = "BtClear"
        Me.BtClear.Size = New System.Drawing.Size(75, 23)
        Me.BtClear.TabIndex = 9
        Me.BtClear.Text = "Clear"
        Me.BtClear.UseVisualStyleBackColor = True
        '
        'txtNoBukti
        '
        Me.txtNoBukti.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoBukti.Location = New System.Drawing.Point(12, 249)
        Me.txtNoBukti.Name = "txtNoBukti"
        Me.txtNoBukti.Size = New System.Drawing.Size(100, 20)
        Me.txtNoBukti.TabIndex = 7
        '
        'DGV_DATA
        '
        Me.DGV_DATA.AllowUserToAddRows = False
        Me.DGV_DATA.AllowUserToDeleteRows = False
        Me.DGV_DATA.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DGV_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DATA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RK, Me.NPWP, Me.NAMA, Me.KD_JENIS_TRANSAKSI, Me.FG_PENGGANTI, Me.NOMOR_FAKTUR, Me.TANGGAL_FAKTUR, Me.TANGGAL_RETUR, Me.NOMOR_DOKUMEN_RETUR, Me.MASA_PAJAK_RETUR, Me.TAHUN_PAJAK_RETUR, Me.NILAI_RETUR_DPP, Me.NILAI_RETUR_PPN, Me.NILAI_RETUR_PPNBM})
        Me.DGV_DATA.Location = New System.Drawing.Point(12, 278)
        Me.DGV_DATA.Name = "DGV_DATA"
        Me.DGV_DATA.ReadOnly = True
        Me.DGV_DATA.Size = New System.Drawing.Size(666, 286)
        Me.DGV_DATA.TabIndex = 13
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RK
        '
        Me.RK.HeaderText = "RK"
        Me.RK.Name = "RK"
        Me.RK.ReadOnly = True
        '
        'NPWP
        '
        Me.NPWP.HeaderText = "NPWP"
        Me.NPWP.Name = "NPWP"
        Me.NPWP.ReadOnly = True
        '
        'NAMA
        '
        Me.NAMA.HeaderText = "NAMA"
        Me.NAMA.Name = "NAMA"
        Me.NAMA.ReadOnly = True
        '
        'KD_JENIS_TRANSAKSI
        '
        Me.KD_JENIS_TRANSAKSI.HeaderText = "KD_JENIS_TRANSAKSI"
        Me.KD_JENIS_TRANSAKSI.Name = "KD_JENIS_TRANSAKSI"
        Me.KD_JENIS_TRANSAKSI.ReadOnly = True
        '
        'FG_PENGGANTI
        '
        Me.FG_PENGGANTI.HeaderText = "FG_PENGGANTI"
        Me.FG_PENGGANTI.Name = "FG_PENGGANTI"
        Me.FG_PENGGANTI.ReadOnly = True
        '
        'NOMOR_FAKTUR
        '
        Me.NOMOR_FAKTUR.HeaderText = "NOMOR_FAKTUR"
        Me.NOMOR_FAKTUR.Name = "NOMOR_FAKTUR"
        Me.NOMOR_FAKTUR.ReadOnly = True
        '
        'TANGGAL_FAKTUR
        '
        Me.TANGGAL_FAKTUR.HeaderText = "TANGGAL_FAKTUR"
        Me.TANGGAL_FAKTUR.Name = "TANGGAL_FAKTUR"
        Me.TANGGAL_FAKTUR.ReadOnly = True
        '
        'TANGGAL_RETUR
        '
        Me.TANGGAL_RETUR.HeaderText = "TANGGAL_RETUR"
        Me.TANGGAL_RETUR.Name = "TANGGAL_RETUR"
        Me.TANGGAL_RETUR.ReadOnly = True
        '
        'NOMOR_DOKUMEN_RETUR
        '
        Me.NOMOR_DOKUMEN_RETUR.HeaderText = "NOMOR_DOKUMEN_RETUR"
        Me.NOMOR_DOKUMEN_RETUR.Name = "NOMOR_DOKUMEN_RETUR"
        Me.NOMOR_DOKUMEN_RETUR.ReadOnly = True
        '
        'MASA_PAJAK_RETUR
        '
        Me.MASA_PAJAK_RETUR.HeaderText = "MASA_PAJAK_RETUR"
        Me.MASA_PAJAK_RETUR.Name = "MASA_PAJAK_RETUR"
        Me.MASA_PAJAK_RETUR.ReadOnly = True
        '
        'TAHUN_PAJAK_RETUR
        '
        Me.TAHUN_PAJAK_RETUR.HeaderText = "TAHUN_PAJAK_RETUR"
        Me.TAHUN_PAJAK_RETUR.Name = "TAHUN_PAJAK_RETUR"
        Me.TAHUN_PAJAK_RETUR.ReadOnly = True
        '
        'NILAI_RETUR_DPP
        '
        Me.NILAI_RETUR_DPP.HeaderText = "NILAI_RETUR_DPP"
        Me.NILAI_RETUR_DPP.Name = "NILAI_RETUR_DPP"
        Me.NILAI_RETUR_DPP.ReadOnly = True
        '
        'NILAI_RETUR_PPN
        '
        Me.NILAI_RETUR_PPN.HeaderText = "NILAI_RETUR_PPN"
        Me.NILAI_RETUR_PPN.Name = "NILAI_RETUR_PPN"
        Me.NILAI_RETUR_PPN.ReadOnly = True
        '
        'NILAI_RETUR_PPNBM
        '
        Me.NILAI_RETUR_PPNBM.HeaderText = "NILAI_RETUR_PPNBM"
        Me.NILAI_RETUR_PPNBM.Name = "NILAI_RETUR_PPNBM"
        Me.NILAI_RETUR_PPNBM.ReadOnly = True
        '
        'FrmExportTaxReture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 576)
        Me.Controls.Add(Me.DGV_DATA)
        Me.Controls.Add(Me.BtProses)
        Me.Controls.Add(Me.BtImport)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BtClear)
        Me.Controls.Add(Me.txtNoBukti)
        Me.Name = "FrmExportTaxReture"
        Me.ShowIcon = False
        Me.Text = "Export Tax Reture"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_DATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtProses As System.Windows.Forms.Button
    Friend WithEvents BtImport As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents BtClear As System.Windows.Forms.Button
    Friend WithEvents txtNoBukti As System.Windows.Forms.TextBox
    Friend WithEvents DGV_DATA As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPWP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KD_JENIS_TRANSAKSI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FG_PENGGANTI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMOR_FAKTUR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TANGGAL_FAKTUR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TANGGAL_RETUR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMOR_DOKUMEN_RETUR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MASA_PAJAK_RETUR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TAHUN_PAJAK_RETUR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NILAI_RETUR_DPP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NILAI_RETUR_PPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NILAI_RETUR_PPNBM As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
