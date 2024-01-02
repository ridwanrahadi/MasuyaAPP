<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLaporan
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.BTGp = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBSales = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbWil = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBKota = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DGLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Data Table"
        '
        'BtKeluar
        '
        Me.BtKeluar.Location = New System.Drawing.Point(1312, 50)
        Me.BtKeluar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtKeluar.Name = "BtKeluar"
        Me.BtKeluar.Size = New System.Drawing.Size(100, 28)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGLaporan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGLaporan.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGLaporan.Location = New System.Drawing.Point(20, 126)
        Me.DGLaporan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGLaporan.Name = "DGLaporan"
        Me.DGLaporan.ReadOnly = True
        Me.DGLaporan.Size = New System.Drawing.Size(1392, 407)
        Me.DGLaporan.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(880, 544)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total Include Rupiah"
        '
        'Totaltxt
        '
        Me.Totaltxt.Location = New System.Drawing.Point(1029, 540)
        Me.Totaltxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Totaltxt.Name = "Totaltxt"
        Me.Totaltxt.Size = New System.Drawing.Size(185, 22)
        Me.Totaltxt.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1224, 544)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Qty"
        '
        'TotalQtytxt
        '
        Me.TotalQtytxt.Location = New System.Drawing.Point(1299, 540)
        Me.TotalQtytxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TotalQtytxt.Name = "TotalQtytxt"
        Me.TotalQtytxt.Size = New System.Drawing.Size(112, 22)
        Me.TotalQtytxt.TabIndex = 14
        '
        'BtStock
        '
        Me.BtStock.Location = New System.Drawing.Point(1204, 50)
        Me.BtStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtStock.Name = "BtStock"
        Me.BtStock.Size = New System.Drawing.Size(100, 28)
        Me.BtStock.TabIndex = 15
        Me.BtStock.Text = "Stock"
        Me.BtStock.UseVisualStyleBackColor = True
        '
        'BtExport
        '
        Me.BtExport.Location = New System.Drawing.Point(1096, 50)
        Me.BtExport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtExport.Name = "BtExport"
        Me.BtExport.Size = New System.Drawing.Size(100, 28)
        Me.BtExport.TabIndex = 16
        Me.BtExport.Text = "Export"
        Me.BtExport.UseVisualStyleBackColor = True
        '
        'CBType
        '
        Me.CBType.FormattingEnabled = True
        Me.CBType.Location = New System.Drawing.Point(1139, 92)
        Me.CBType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBType.MaxLength = 40
        Me.CBType.Name = "CBType"
        Me.CBType.Size = New System.Drawing.Size(272, 24)
        Me.CBType.TabIndex = 24
        '
        'TglAkhir
        '
        Me.TglAkhir.CustomFormat = "M/dd/yyyy"
        Me.TglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglAkhir.Location = New System.Drawing.Point(1139, 18)
        Me.TglAkhir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TglAkhir.Name = "TglAkhir"
        Me.TglAkhir.Size = New System.Drawing.Size(164, 22)
        Me.TglAkhir.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1040, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Type Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(849, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Tanggal"
        '
        'BtCari
        '
        Me.BtCari.Location = New System.Drawing.Point(1312, 15)
        Me.BtCari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtCari.Name = "BtCari"
        Me.BtCari.Size = New System.Drawing.Size(100, 28)
        Me.BtCari.TabIndex = 23
        Me.BtCari.Text = "Proses"
        Me.BtCari.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1092, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "s / d"
        '
        'TglAwal
        '
        Me.TglAwal.CustomFormat = "M/dd/yyyy"
        Me.TglAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglAwal.Location = New System.Drawing.Point(919, 18)
        Me.TglAwal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TglAwal.Name = "TglAwal"
        Me.TglAwal.Size = New System.Drawing.Size(160, 22)
        Me.TglAwal.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(955, 50)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 28)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Keterangan JL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTGp
        '
        Me.BTGp.Location = New System.Drawing.Point(847, 50)
        Me.BTGp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTGp.Name = "BTGp"
        Me.BTGp.Size = New System.Drawing.Size(100, 28)
        Me.BTGp.TabIndex = 26
        Me.BTGp.Text = "Analisa GP"
        Me.BTGp.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(813, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Divisi Sales"
        '
        'CBSales
        '
        Me.CBSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSales.FormattingEnabled = True
        Me.CBSales.Items.AddRange(New Object() {"FOOD", "MODERN", "LOCAL"})
        Me.CBSales.Location = New System.Drawing.Point(903, 92)
        Me.CBSales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBSales.Name = "CBSales"
        Me.CBSales.Size = New System.Drawing.Size(128, 24)
        Me.CBSales.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(497, 96)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 17)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Sales Wilayah "
        '
        'CmbWil
        '
        Me.CmbWil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWil.FormattingEnabled = True
        Me.CmbWil.Items.AddRange(New Object() {"BANDUNG", "CIREBON", "LUAR KOTA"})
        Me.CmbWil.Location = New System.Drawing.Point(608, 92)
        Me.CmbWil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbWil.Name = "CmbWil"
        Me.CmbWil.Size = New System.Drawing.Size(196, 24)
        Me.CmbWil.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Wilayah"
        '
        'CBKota
        '
        Me.CBKota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBKota.Enabled = False
        Me.CBKota.FormattingEnabled = True
        Me.CBKota.Items.AddRange(New Object() {"BANDUNG", "CIREBON"})
        Me.CBKota.Location = New System.Drawing.Point(85, 26)
        Me.CBKota.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBKota.Name = "CBKota"
        Me.CBKota.Size = New System.Drawing.Size(352, 24)
        Me.CBKota.TabIndex = 32
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(445, 26)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(115, 21)
        Me.CheckBox1.TabIndex = 33
        Me.CheckBox1.Text = "Filter Wilayah"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 574)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CBKota)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CmbWil)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CBSales)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BTGp)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmLaporan"
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
    Friend WithEvents BTGp As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBSales As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbWil As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBKota As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
