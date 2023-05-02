<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRetur
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKdCust = New System.Windows.Forms.TextBox()
        Me.BtCari = New System.Windows.Forms.Button()
        Me.DTTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtCust = New System.Windows.Forms.TextBox()
        Me.CBCust = New System.Windows.Forms.ComboBox()
        Me.txtNoBukti = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNoFak = New System.Windows.Forms.TextBox()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtDriver = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BtBaru = New System.Windows.Forms.Button()
        Me.BtSimpan = New System.Windows.Forms.Button()
        Me.BtEdit = New System.Windows.Forms.Button()
        Me.BtHapus = New System.Windows.Forms.Button()
        Me.BtKembali = New System.Windows.Forms.Button()
        Me.BtKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Bukti :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Customer :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Customer :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKdCust)
        Me.GroupBox1.Controls.Add(Me.BtCari)
        Me.GroupBox1.Controls.Add(Me.DTTanggal)
        Me.GroupBox1.Controls.Add(Me.txtCust)
        Me.GroupBox1.Controls.Add(Me.CBCust)
        Me.GroupBox1.Controls.Add(Me.txtNoBukti)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtKdCust
        '
        Me.txtKdCust.Location = New System.Drawing.Point(100, 46)
        Me.txtKdCust.Name = "txtKdCust"
        Me.txtKdCust.Size = New System.Drawing.Size(100, 20)
        Me.txtKdCust.TabIndex = 17
        '
        'BtCari
        '
        Me.BtCari.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.Fraud_bukalapak
        Me.BtCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtCari.Location = New System.Drawing.Point(206, 17)
        Me.BtCari.Name = "BtCari"
        Me.BtCari.Size = New System.Drawing.Size(28, 23)
        Me.BtCari.TabIndex = 16
        Me.BtCari.UseVisualStyleBackColor = True
        '
        'DTTanggal
        '
        Me.DTTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTanggal.Location = New System.Drawing.Point(298, 19)
        Me.DTTanggal.Name = "DTTanggal"
        Me.DTTanggal.Size = New System.Drawing.Size(126, 20)
        Me.DTTanggal.TabIndex = 4
        '
        'txtCust
        '
        Me.txtCust.Location = New System.Drawing.Point(100, 72)
        Me.txtCust.Name = "txtCust"
        Me.txtCust.Size = New System.Drawing.Size(324, 20)
        Me.txtCust.TabIndex = 3
        '
        'CBCust
        '
        Me.CBCust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBCust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBCust.FormattingEnabled = True
        Me.CBCust.Location = New System.Drawing.Point(298, 45)
        Me.CBCust.Name = "CBCust"
        Me.CBCust.Size = New System.Drawing.Size(100, 21)
        Me.CBCust.TabIndex = 2
        Me.CBCust.Visible = False
        '
        'txtNoBukti
        '
        Me.txtNoBukti.Location = New System.Drawing.Point(100, 19)
        Me.txtNoBukti.Name = "txtNoBukti"
        Me.txtNoBukti.ReadOnly = True
        Me.txtNoBukti.Size = New System.Drawing.Size(100, 20)
        Me.txtNoBukti.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNoFak)
        Me.GroupBox2.Controls.Add(Me.txtSales)
        Me.GroupBox2.Controls.Add(Me.txtDriver)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(471, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 105)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'txtNoFak
        '
        Me.txtNoFak.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoFak.Location = New System.Drawing.Point(93, 19)
        Me.txtNoFak.Name = "txtNoFak"
        Me.txtNoFak.Size = New System.Drawing.Size(85, 20)
        Me.txtNoFak.TabIndex = 6
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(93, 45)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(150, 20)
        Me.txtSales.TabIndex = 7
        '
        'txtDriver
        '
        Me.txtDriver.Location = New System.Drawing.Point(93, 72)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(150, 20)
        Me.txtDriver.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "NO FAKTUR :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "SALES :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "DRIVER :"
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 123)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(708, 224)
        Me.DGV.TabIndex = 9
        '
        'BtBaru
        '
        Me.BtBaru.Location = New System.Drawing.Point(240, 353)
        Me.BtBaru.Name = "BtBaru"
        Me.BtBaru.Size = New System.Drawing.Size(75, 23)
        Me.BtBaru.TabIndex = 10
        Me.BtBaru.Text = "Baru"
        Me.BtBaru.UseVisualStyleBackColor = True
        '
        'BtSimpan
        '
        Me.BtSimpan.Location = New System.Drawing.Point(321, 353)
        Me.BtSimpan.Name = "BtSimpan"
        Me.BtSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtSimpan.TabIndex = 11
        Me.BtSimpan.Text = "Simpan"
        Me.BtSimpan.UseVisualStyleBackColor = True
        '
        'BtEdit
        '
        Me.BtEdit.Location = New System.Drawing.Point(402, 353)
        Me.BtEdit.Name = "BtEdit"
        Me.BtEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtEdit.TabIndex = 12
        Me.BtEdit.Text = "Edit"
        Me.BtEdit.UseVisualStyleBackColor = True
        '
        'BtHapus
        '
        Me.BtHapus.Location = New System.Drawing.Point(483, 353)
        Me.BtHapus.Name = "BtHapus"
        Me.BtHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtHapus.TabIndex = 13
        Me.BtHapus.Text = "Hapus"
        Me.BtHapus.UseVisualStyleBackColor = True
        '
        'BtKembali
        '
        Me.BtKembali.Location = New System.Drawing.Point(564, 353)
        Me.BtKembali.Name = "BtKembali"
        Me.BtKembali.Size = New System.Drawing.Size(75, 23)
        Me.BtKembali.TabIndex = 14
        Me.BtKembali.Text = "Kembali"
        Me.BtKembali.UseVisualStyleBackColor = True
        '
        'BtKeluar
        '
        Me.BtKeluar.Location = New System.Drawing.Point(645, 353)
        Me.BtKeluar.Name = "BtKeluar"
        Me.BtKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtKeluar.TabIndex = 15
        Me.BtKeluar.Text = "Keluar"
        Me.BtKeluar.UseVisualStyleBackColor = True
        '
        'FrmRetur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 389)
        Me.Controls.Add(Me.BtKeluar)
        Me.Controls.Add(Me.BtKembali)
        Me.Controls.Add(Me.BtHapus)
        Me.Controls.Add(Me.BtEdit)
        Me.Controls.Add(Me.BtSimpan)
        Me.Controls.Add(Me.BtBaru)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmRetur"
        Me.ShowIcon = False
        Me.Text = "Form Laporan Pengembalian Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtCari As System.Windows.Forms.Button
    Friend WithEvents DTTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCust As System.Windows.Forms.TextBox
    Friend WithEvents CBCust As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoBukti As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoFak As System.Windows.Forms.TextBox
    Friend WithEvents txtSales As System.Windows.Forms.TextBox
    Friend WithEvents txtDriver As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents BtBaru As System.Windows.Forms.Button
    Friend WithEvents BtSimpan As System.Windows.Forms.Button
    Friend WithEvents BtEdit As System.Windows.Forms.Button
    Friend WithEvents BtHapus As System.Windows.Forms.Button
    Friend WithEvents BtKembali As System.Windows.Forms.Button
    Friend WithEvents BtKeluar As System.Windows.Forms.Button
    Friend WithEvents txtKdCust As System.Windows.Forms.TextBox
End Class
