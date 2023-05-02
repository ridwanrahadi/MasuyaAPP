<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalesOrder
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
        Me.components = New System.ComponentModel.Container()
        Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BtnStat = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtkodebrg = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblstat = New System.Windows.Forms.Label()
        Me.lblProses = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkapp = New System.Windows.Forms.CheckBox()
        Me.ChkPrint = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoSO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblKdSales = New System.Windows.Forms.Label()
        Me.lblNmSales = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKdCust = New System.Windows.Forms.TextBox()
        Me.txtNmCust = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKet = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtket2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAlmkirim = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtktp = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtNoPo = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnAddFk = New System.Windows.Forms.Button()
        Me.txtNoBukti = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtD1 = New System.Windows.Forms.TextBox()
        Me.txtD2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtD3 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsim = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.chkre = New System.Windows.Forms.CheckBox()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnreject = New System.Windows.Forms.Button()
        Me.btnapp = New System.Windows.Forms.Button()
        Me.chtimbang = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDisc = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtPrsDisc = New System.Windows.Forms.TextBox()
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = "No Faktur"
        ColumnHeader1.Width = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Kode Barang :"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(112, 301)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(87, 20)
        Me.txtQty.TabIndex = 8
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(112, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Qty Barang :"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(205, 301)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(100, 20)
        Me.txtHarga.TabIndex = 9
        Me.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(202, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Harga :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRow)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(631, 171)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Barang"
        '
        'lblRow
        '
        Me.lblRow.AutoSize = True
        Me.lblRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow.Location = New System.Drawing.Point(7, 151)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(29, 13)
        Me.lblRow.TabIndex = 31
        Me.lblRow.Text = "Row"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.Location = New System.Drawing.Point(10, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(615, 129)
        Me.DataGridView2.TabIndex = 21
        '
        'BtnStat
        '
        Me.BtnStat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStat.Location = New System.Drawing.Point(320, 5)
        Me.BtnStat.Name = "BtnStat"
        Me.BtnStat.Size = New System.Drawing.Size(34, 23)
        Me.BtnStat.TabIndex = 0
        Me.BtnStat.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(22, 559)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(393, 90)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Kode Brg"
        Me.ColumnHeader2.Width = 86
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Harga"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 111
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Disc1"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Disc2"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Disc3"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(297, 543)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "List history harga jual"
        '
        'txtkodebrg
        '
        Me.txtkodebrg.Location = New System.Drawing.Point(21, 301)
        Me.txtkodebrg.Name = "txtkodebrg"
        Me.txtkodebrg.ReadOnly = True
        Me.txtkodebrg.Size = New System.Drawing.Size(85, 20)
        Me.txtkodebrg.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(466, 555)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Disc :"
        '
        'lblstat
        '
        Me.lblstat.AutoSize = True
        Me.lblstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstat.ForeColor = System.Drawing.Color.Red
        Me.lblstat.Location = New System.Drawing.Point(512, 5)
        Me.lblstat.Name = "lblstat"
        Me.lblstat.Size = New System.Drawing.Size(59, 20)
        Me.lblstat.TabIndex = 18
        Me.lblstat.Text = "status"
        Me.lblstat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblstat.Visible = False
        '
        'lblProses
        '
        Me.lblProses.AutoSize = True
        Me.lblProses.Font = New System.Drawing.Font("Swis721 Blk BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProses.ForeColor = System.Drawing.Color.Black
        Me.lblProses.Location = New System.Drawing.Point(83, 12)
        Me.lblProses.Name = "lblProses"
        Me.lblProses.Size = New System.Drawing.Size(60, 16)
        Me.lblProses.TabIndex = 19
        Me.lblProses.Text = "Proses"
        Me.lblProses.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 17)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Cek by :"
        '
        'chkapp
        '
        Me.chkapp.Location = New System.Drawing.Point(497, 604)
        Me.chkapp.Name = "chkapp"
        Me.chkapp.Size = New System.Drawing.Size(72, 17)
        Me.chkapp.TabIndex = 20
        Me.chkapp.Text = "Approved"
        Me.chkapp.UseVisualStyleBackColor = True
        '
        'ChkPrint
        '
        Me.ChkPrint.AutoCheck = False
        Me.ChkPrint.Location = New System.Drawing.Point(497, 627)
        Me.ChkPrint.Name = "ChkPrint"
        Me.ChkPrint.Size = New System.Drawing.Size(72, 17)
        Me.ChkPrint.TabIndex = 21
        Me.ChkPrint.Text = "Print"
        Me.ChkPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No SO :"
        '
        'txtNoSO
        '
        Me.txtNoSO.BackColor = System.Drawing.SystemColors.Info
        Me.txtNoSO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSO.Location = New System.Drawing.Point(100, 16)
        Me.txtNoSO.Name = "txtNoSO"
        Me.txtNoSO.ReadOnly = True
        Me.txtNoSO.Size = New System.Drawing.Size(116, 24)
        Me.txtNoSO.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode Sales :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Sales :"
        '
        'lblKdSales
        '
        Me.lblKdSales.AutoSize = True
        Me.lblKdSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKdSales.Location = New System.Drawing.Point(325, 92)
        Me.lblKdSales.Name = "lblKdSales"
        Me.lblKdSales.Size = New System.Drawing.Size(13, 17)
        Me.lblKdSales.TabIndex = 4
        Me.lblKdSales.Text = "-"
        '
        'lblNmSales
        '
        Me.lblNmSales.AutoSize = True
        Me.lblNmSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNmSales.Location = New System.Drawing.Point(325, 116)
        Me.lblNmSales.Name = "lblNmSales"
        Me.lblNmSales.Size = New System.Drawing.Size(13, 17)
        Me.lblNmSales.TabIndex = 5
        Me.lblNmSales.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(252, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tanggal :"
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTgl.Location = New System.Drawing.Point(325, 21)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(13, 17)
        Me.lblTgl.TabIndex = 7
        Me.lblTgl.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(239, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Kode Cust :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(235, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nama Cust :"
        '
        'txtKdCust
        '
        Me.txtKdCust.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKdCust.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdCust.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKdCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdCust.Location = New System.Drawing.Point(325, 46)
        Me.txtKdCust.Name = "txtKdCust"
        Me.txtKdCust.ReadOnly = True
        Me.txtKdCust.Size = New System.Drawing.Size(115, 16)
        Me.txtKdCust.TabIndex = 10
        '
        'txtNmCust
        '
        Me.txtNmCust.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNmCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmCust.Location = New System.Drawing.Point(325, 67)
        Me.txtNmCust.Name = "txtNmCust"
        Me.txtNmCust.ReadOnly = True
        Me.txtNmCust.Size = New System.Drawing.Size(295, 16)
        Me.txtNmCust.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Keterangan Dari Sales :"
        '
        'txtKet
        '
        Me.txtKet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKet.Location = New System.Drawing.Point(181, 196)
        Me.txtKet.Name = "txtKet"
        Me.txtKet.ReadOnly = True
        Me.txtKet.Size = New System.Drawing.Size(444, 22)
        Me.txtKet.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Keterangan Akunting :"
        '
        'txtket2
        '
        Me.txtket2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtket2.Location = New System.Drawing.Point(181, 225)
        Me.txtket2.Name = "txtket2"
        Me.txtket2.Size = New System.Drawing.Size(444, 22)
        Me.txtket2.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(226, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 17)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Alamat Kirim :"
        '
        'txtAlmkirim
        '
        Me.txtAlmkirim.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlmkirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlmkirim.Location = New System.Drawing.Point(325, 136)
        Me.txtAlmkirim.Multiline = True
        Me.txtAlmkirim.Name = "txtAlmkirim"
        Me.txtAlmkirim.ReadOnly = True
        Me.txtAlmkirim.Size = New System.Drawing.Size(295, 32)
        Me.txtAlmkirim.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(255, 174)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 17)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "No KTP :"
        '
        'txtktp
        '
        Me.txtktp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtktp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtktp.Location = New System.Drawing.Point(326, 174)
        Me.txtktp.Name = "txtktp"
        Me.txtktp.ReadOnly = True
        Me.txtktp.Size = New System.Drawing.Size(295, 16)
        Me.txtktp.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txtNoPo)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.btnAddFk)
        Me.GroupBox1.Controls.Add(Me.txtNoBukti)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtktp)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtAlmkirim)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtket2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtKet)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtNmCust)
        Me.GroupBox1.Controls.Add(Me.txtKdCust)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblTgl)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblNmSales)
        Me.GroupBox1.Controls.Add(Me.lblKdSales)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNoSO)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 252)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(10, 141)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(106, 17)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "update No PO :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 116)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(162, 17)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Send notif ket Akunting /"
        '
        'txtNoPo
        '
        Me.txtNoPo.Location = New System.Drawing.Point(100, 45)
        Me.txtNoPo.Name = "txtNoPo"
        Me.txtNoPo.Size = New System.Drawing.Size(116, 20)
        Me.txtNoPo.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(33, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 17)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "No PO :"
        '
        'btnAddFk
        '
        Me.btnAddFk.Location = New System.Drawing.Point(122, 136)
        Me.btnAddFk.Name = "btnAddFk"
        Me.btnAddFk.Size = New System.Drawing.Size(74, 27)
        Me.btnAddFk.TabIndex = 4
        Me.btnAddFk.Text = "Send"
        Me.btnAddFk.UseVisualStyleBackColor = True
        '
        'txtNoBukti
        '
        Me.txtNoBukti.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtNoBukti.Location = New System.Drawing.Point(99, 87)
        Me.txtNoBukti.Name = "txtNoBukti"
        Me.txtNoBukti.ReadOnly = True
        Me.txtNoBukti.Size = New System.Drawing.Size(116, 20)
        Me.txtNoBukti.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(37, 88)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 17)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "No JL :"
        '
        'txtD1
        '
        Me.txtD1.Location = New System.Drawing.Point(311, 301)
        Me.txtD1.Name = "txtD1"
        Me.txtD1.ReadOnly = True
        Me.txtD1.Size = New System.Drawing.Size(43, 20)
        Me.txtD1.TabIndex = 10
        Me.txtD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtD2
        '
        Me.txtD2.Location = New System.Drawing.Point(360, 301)
        Me.txtD2.Name = "txtD2"
        Me.txtD2.ReadOnly = True
        Me.txtD2.Size = New System.Drawing.Size(43, 20)
        Me.txtD2.TabIndex = 11
        Me.txtD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(360, 285)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Disc 2 :"
        '
        'txtD3
        '
        Me.txtD3.Location = New System.Drawing.Point(409, 301)
        Me.txtD3.Name = "txtD3"
        Me.txtD3.ReadOnly = True
        Me.txtD3.Size = New System.Drawing.Size(43, 20)
        Me.txtD3.TabIndex = 12
        Me.txtD3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(409, 285)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Disc 3 :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(311, 285)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Disc 1 :"
        '
        'btndel
        '
        Me.btndel.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.delete
        Me.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(608, 288)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(29, 35)
        Me.btndel.TabIndex = 17
        Me.ToolTip.SetToolTip(Me.btndel, "Delete Button")
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.refresh
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(575, 288)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(29, 35)
        Me.btnUpdate.TabIndex = 16
        Me.ToolTip.SetToolTip(Me.btnUpdate, "Update Button")
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.back
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(542, 288)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(29, 35)
        Me.btncancel.TabIndex = 15
        Me.ToolTip.SetToolTip(Me.btncancel, "Cancel Button")
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsim
        '
        Me.btnsim.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.diskette
        Me.btnsim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsim.Location = New System.Drawing.Point(509, 288)
        Me.btnsim.Name = "btnsim"
        Me.btnsim.Size = New System.Drawing.Size(29, 35)
        Me.btnsim.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.btnsim, "Save Button")
        Me.btnsim.UseVisualStyleBackColor = True
        '
        'ToolTip
        '
        Me.ToolTip.ToolTipTitle = "Tooltip"
        '
        'BtnAdd
        '
        Me.BtnAdd.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.plus
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(476, 288)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(29, 35)
        Me.BtnAdd.TabIndex = 13
        Me.ToolTip.SetToolTip(Me.BtnAdd, "Add Button")
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'chkre
        '
        Me.chkre.Location = New System.Drawing.Point(575, 604)
        Me.chkre.Name = "chkre"
        Me.chkre.Size = New System.Drawing.Size(72, 17)
        Me.chkre.TabIndex = 33
        Me.chkre.Text = "Reject"
        Me.chkre.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.print
        Me.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprint.Location = New System.Drawing.Point(144, 501)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(55, 49)
        Me.btnprint.TabIndex = 20
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnreject
        '
        Me.btnreject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnreject.Location = New System.Drawing.Point(83, 501)
        Me.btnreject.Name = "btnreject"
        Me.btnreject.Size = New System.Drawing.Size(55, 49)
        Me.btnreject.TabIndex = 19
        Me.btnreject.Text = "Reject / Batal"
        Me.btnreject.UseVisualStyleBackColor = True
        '
        'btnapp
        '
        Me.btnapp.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.done_1779319_1512595
        Me.btnapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnapp.Location = New System.Drawing.Point(22, 501)
        Me.btnapp.Name = "btnapp"
        Me.btnapp.Size = New System.Drawing.Size(55, 49)
        Me.btnapp.TabIndex = 18
        Me.btnapp.UseVisualStyleBackColor = True
        '
        'chtimbang
        '
        Me.chtimbang.Location = New System.Drawing.Point(575, 627)
        Me.chtimbang.Name = "chtimbang"
        Me.chtimbang.Size = New System.Drawing.Size(72, 17)
        Me.chtimbang.TabIndex = 34
        Me.chtimbang.Text = "Timbangan"
        Me.chtimbang.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(444, 504)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "SubTotal :"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(506, 501)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(137, 20)
        Me.txtSubtotal.TabIndex = 38
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(430, 530)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 13)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Persen Disc :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(444, 581)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(55, 13)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "Total SO :"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(506, 578)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(137, 20)
        Me.txtTotal.TabIndex = 41
        '
        'txtDisc
        '
        Me.txtDisc.BackColor = System.Drawing.SystemColors.Info
        Me.txtDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc.Location = New System.Drawing.Point(506, 552)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.ReadOnly = True
        Me.txtDisc.Size = New System.Drawing.Size(137, 20)
        Me.txtDisc.TabIndex = 42
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(544, 528)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(20, 17)
        Me.Label25.TabIndex = 44
        Me.Label25.Text = "%"
        '
        'txtPrsDisc
        '
        Me.txtPrsDisc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPrsDisc.Location = New System.Drawing.Point(506, 525)
        Me.txtPrsDisc.Name = "txtPrsDisc"
        Me.txtPrsDisc.ReadOnly = True
        Me.txtPrsDisc.Size = New System.Drawing.Size(32, 20)
        Me.txtPrsDisc.TabIndex = 45
        '
        'FrmSalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(653, 662)
        Me.Controls.Add(Me.txtPrsDisc)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtDisc)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.chtimbang)
        Me.Controls.Add(Me.chkre)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.txtD3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtD2)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtD1)
        Me.Controls.Add(Me.btnsim)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.chkapp)
        Me.Controls.Add(Me.ChkPrint)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblProses)
        Me.Controls.Add(Me.BtnStat)
        Me.Controls.Add(Me.lblstat)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnreject)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtkodebrg)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnapp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmSalesOrder"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Sales Order"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnStat As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnapp As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnreject As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents txtkodebrg As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblstat As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblProses As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkapp As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPrint As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoSO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblKdSales As System.Windows.Forms.Label
    Friend WithEvents lblNmSales As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTgl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKdCust As System.Windows.Forms.TextBox
    Friend WithEvents txtNmCust As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKet As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtket2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAlmkirim As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtktp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsim As System.Windows.Forms.Button
    Friend WithEvents txtD1 As System.Windows.Forms.TextBox
    Friend WithEvents txtD2 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtD3 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnAddFk As System.Windows.Forms.Button
    Friend WithEvents txtNoBukti As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPo As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblRow As System.Windows.Forms.Label
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents chkre As System.Windows.Forms.CheckBox
    Friend WithEvents chtimbang As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDisc As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtPrsDisc As System.Windows.Forms.TextBox
End Class
