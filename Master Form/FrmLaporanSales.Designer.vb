<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLaporanSales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtKeluar = New System.Windows.Forms.Button()
        Me.DGLaporan = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Totaltxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TotalQtytxt = New System.Windows.Forms.TextBox()
        Me.BtStock = New System.Windows.Forms.Button()
        Me.BtExport = New System.Windows.Forms.Button()
        Me.CBType = New System.Windows.Forms.ComboBox()
        Me.TglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtCari = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TglAwal = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBSales = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBKodeSales = New System.Windows.Forms.ComboBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LabelProses = New System.Windows.Forms.Label()
        Me.LabelCount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttotalppn = New System.Windows.Forms.TextBox()
        CType(Me.DGLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Data Table"
        '
        'BtKeluar
        '
        Me.BtKeluar.Location = New System.Drawing.Point(984, 41)
        Me.BtKeluar.Name = "BtKeluar"
        Me.BtKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtKeluar.TabIndex = 8
        Me.BtKeluar.Text = "Exit"
        Me.BtKeluar.UseVisualStyleBackColor = True
        '
        'DGLaporan
        '
        Me.DGLaporan.AllowUserToAddRows = False
        Me.DGLaporan.AllowUserToDeleteRows = False
        Me.DGLaporan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGLaporan.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGLaporan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGLaporan.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGLaporan.Location = New System.Drawing.Point(15, 70)
        Me.DGLaporan.Name = "DGLaporan"
        Me.DGLaporan.ReadOnly = True
        Me.DGLaporan.Size = New System.Drawing.Size(1044, 338)
        Me.DGLaporan.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(485, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total Exc PPN"
        '
        'Totaltxt
        '
        Me.Totaltxt.Location = New System.Drawing.Point(568, 414)
        Me.Totaltxt.Name = "Totaltxt"
        Me.Totaltxt.Size = New System.Drawing.Size(115, 20)
        Me.Totaltxt.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(918, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Qty"
        '
        'TotalQtytxt
        '
        Me.TotalQtytxt.Location = New System.Drawing.Point(974, 414)
        Me.TotalQtytxt.Name = "TotalQtytxt"
        Me.TotalQtytxt.Size = New System.Drawing.Size(85, 20)
        Me.TotalQtytxt.TabIndex = 14
        '
        'BtStock
        '
        Me.BtStock.Location = New System.Drawing.Point(903, 41)
        Me.BtStock.Name = "BtStock"
        Me.BtStock.Size = New System.Drawing.Size(75, 23)
        Me.BtStock.TabIndex = 15
        Me.BtStock.Text = "Stock"
        Me.BtStock.UseVisualStyleBackColor = True
        '
        'BtExport
        '
        Me.BtExport.Location = New System.Drawing.Point(822, 41)
        Me.BtExport.Name = "BtExport"
        Me.BtExport.Size = New System.Drawing.Size(75, 23)
        Me.BtExport.TabIndex = 16
        Me.BtExport.Text = "Export"
        Me.BtExport.UseVisualStyleBackColor = True
        '
        'CBType
        '
        Me.CBType.FormattingEnabled = True
        Me.CBType.Location = New System.Drawing.Point(280, 18)
        Me.CBType.MaxLength = 40
        Me.CBType.Name = "CBType"
        Me.CBType.Size = New System.Drawing.Size(305, 21)
        Me.CBType.TabIndex = 24
        '
        'TglAkhir
        '
        Me.TglAkhir.CustomFormat = "M/dd/yyyy"
        Me.TglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglAkhir.Location = New System.Drawing.Point(854, 15)
        Me.TglAkhir.Name = "TglAkhir"
        Me.TglAkhir.Size = New System.Drawing.Size(124, 20)
        Me.TglAkhir.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Type Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(637, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Tanggal"
        '
        'BtCari
        '
        Me.BtCari.Location = New System.Drawing.Point(984, 12)
        Me.BtCari.Name = "BtCari"
        Me.BtCari.Size = New System.Drawing.Size(75, 23)
        Me.BtCari.TabIndex = 23
        Me.BtCari.Text = "Proses"
        Me.BtCari.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(819, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "s / d"
        '
        'TglAwal
        '
        Me.TglAwal.CustomFormat = "M/dd/yyyy"
        Me.TglAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglAwal.Location = New System.Drawing.Point(689, 15)
        Me.TglAwal.Name = "TglAwal"
        Me.TglAwal.Size = New System.Drawing.Size(121, 20)
        Me.TglAwal.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(716, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Keterangan JL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Divisi Sales"
        '
        'CBSales
        '
        Me.CBSales.FormattingEnabled = True
        Me.CBSales.Location = New System.Drawing.Point(79, 18)
        Me.CBSales.Name = "CBSales"
        Me.CBSales.Size = New System.Drawing.Size(121, 21)
        Me.CBSales.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(213, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Kode Sales"
        '
        'CBKodeSales
        '
        Me.CBKodeSales.FormattingEnabled = True
        Me.CBKodeSales.Location = New System.Drawing.Point(280, 45)
        Me.CBKodeSales.MaxLength = 40
        Me.CBKodeSales.Name = "CBKodeSales"
        Me.CBKodeSales.Size = New System.Drawing.Size(55, 21)
        Me.CBKodeSales.TabIndex = 30
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 414)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(156, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 31
        '
        'LabelProses
        '
        Me.LabelProses.AutoSize = True
        Me.LabelProses.Location = New System.Drawing.Point(213, 418)
        Me.LabelProses.Name = "LabelProses"
        Me.LabelProses.Size = New System.Drawing.Size(39, 13)
        Me.LabelProses.TabIndex = 32
        Me.LabelProses.Text = "Label9"
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.Location = New System.Drawing.Point(290, 417)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(45, 13)
        Me.LabelCount.TabIndex = 33
        Me.LabelCount.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(689, 418)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Total Inc PPN"
        '
        'txttotalppn
        '
        Me.txttotalppn.Location = New System.Drawing.Point(779, 414)
        Me.txttotalppn.Name = "txttotalppn"
        Me.txttotalppn.Size = New System.Drawing.Size(118, 20)
        Me.txttotalppn.TabIndex = 35
        '
        'FrmLaporanSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 445)
        Me.Controls.Add(Me.txttotalppn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabelCount)
        Me.Controls.Add(Me.LabelProses)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.CBKodeSales)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CBSales)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBType)
        Me.Controls.Add(Me.TglAkhir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtCari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TglAwal)
        Me.Controls.Add(Me.BtExport)
        Me.Controls.Add(Me.BtStock)
        Me.Controls.Add(Me.TotalQtytxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Totaltxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGLaporan)
        Me.Controls.Add(Me.BtKeluar)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmLaporanSales"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Laporan"
        CType(Me.DGLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtKeluar As System.Windows.Forms.Button
    Friend WithEvents DGLaporan As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Totaltxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TotalQtytxt As System.Windows.Forms.TextBox
    Friend WithEvents BtStock As System.Windows.Forms.Button
    Friend WithEvents BtExport As System.Windows.Forms.Button
    Friend WithEvents CBType As System.Windows.Forms.ComboBox
    Friend WithEvents TglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtCari As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBSales As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBKodeSales As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LabelProses As System.Windows.Forms.Label
    Friend WithEvents LabelCount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttotalppn As System.Windows.Forms.TextBox
End Class
