<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPelunasanKlaim
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
        Me.txtNoLunas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbakun = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbklaim = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txtselisih = New System.Windows.Forms.TextBox()
        Me.btnbaru = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDesk = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtket = New System.Windows.Forms.TextBox()
        Me.lblakun = New System.Windows.Forms.Label()
        Me.cbsup = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Pelunasan"
        '
        'txtNoLunas
        '
        Me.txtNoLunas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoLunas.Location = New System.Drawing.Point(92, 19)
        Me.txtNoLunas.Name = "txtNoLunas"
        Me.txtNoLunas.Size = New System.Drawing.Size(199, 20)
        Me.txtNoLunas.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No Klaim"
        '
        'cbakun
        '
        Me.cbakun.FormattingEnabled = True
        Me.cbakun.Location = New System.Drawing.Point(92, 135)
        Me.cbakun.Name = "cbakun"
        Me.cbakun.Size = New System.Drawing.Size(199, 21)
        Me.cbakun.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tanggal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(92, 109)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'cbklaim
        '
        Me.cbklaim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbklaim.FormattingEnabled = True
        Me.cbklaim.Location = New System.Drawing.Point(93, 184)
        Me.cbklaim.Name = "cbklaim"
        Me.cbklaim.Size = New System.Drawing.Size(199, 21)
        Me.cbklaim.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Account"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(172, 331)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(119, 20)
        Me.txttotal.TabIndex = 11
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(172, 357)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(119, 20)
        Me.txtbayar.TabIndex = 6
        '
        'txtselisih
        '
        Me.txtselisih.Location = New System.Drawing.Point(172, 383)
        Me.txtselisih.Name = "txtselisih"
        Me.txtselisih.ReadOnly = True
        Me.txtselisih.Size = New System.Drawing.Size(119, 20)
        Me.txtselisih.TabIndex = 7
        '
        'btnbaru
        '
        Me.btnbaru.Location = New System.Drawing.Point(12, 421)
        Me.btnbaru.Name = "btnbaru"
        Me.btnbaru.Size = New System.Drawing.Size(43, 23)
        Me.btnbaru.TabIndex = 14
        Me.btnbaru.Text = "Baru"
        Me.btnbaru.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(61, 421)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(55, 23)
        Me.btnsimpan.TabIndex = 8
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(122, 421)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(56, 23)
        Me.btnubah.TabIndex = 16
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(184, 421)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(56, 23)
        Me.btnhapus.TabIndex = 17
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(246, 421)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(45, 23)
        Me.btnclear.TabIndex = 18
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(132, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(132, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(132, 386)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Selisih"
        '
        'txtDesk
        '
        Me.txtDesk.Location = New System.Drawing.Point(15, 211)
        Me.txtDesk.Multiline = True
        Me.txtDesk.Name = "txtDesk"
        Me.txtDesk.ReadOnly = True
        Me.txtDesk.Size = New System.Drawing.Size(277, 61)
        Me.txtDesk.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Keterangan"
        '
        'txtket
        '
        Me.txtket.Location = New System.Drawing.Point(93, 278)
        Me.txtket.Name = "txtket"
        Me.txtket.Size = New System.Drawing.Size(199, 20)
        Me.txtket.TabIndex = 5
        '
        'lblakun
        '
        Me.lblakun.AutoSize = True
        Me.lblakun.Location = New System.Drawing.Point(89, 159)
        Me.lblakun.Name = "lblakun"
        Me.lblakun.Size = New System.Drawing.Size(10, 13)
        Me.lblakun.TabIndex = 25
        Me.lblakun.Text = "-"
        '
        'cbsup
        '
        Me.cbsup.FormattingEnabled = True
        Me.cbsup.Location = New System.Drawing.Point(92, 54)
        Me.cbsup.Name = "cbsup"
        Me.cbsup.Size = New System.Drawing.Size(199, 21)
        Me.cbsup.TabIndex = 1
        '
        'FrmPelunasanKlaim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 456)
        Me.Controls.Add(Me.cbsup)
        Me.Controls.Add(Me.lblakun)
        Me.Controls.Add(Me.txtket)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDesk)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnbaru)
        Me.Controls.Add(Me.txtselisih)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbklaim)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbakun)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoLunas)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FrmPelunasanKlaim"
        Me.ShowIcon = False
        Me.Text = "Pelunasan klaim"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoLunas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbakun As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbklaim As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents txtselisih As System.Windows.Forms.TextBox
    Friend WithEvents btnbaru As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDesk As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtket As System.Windows.Forms.TextBox
    Friend WithEvents lblakun As System.Windows.Forms.Label
    Friend WithEvents cbsup As System.Windows.Forms.ComboBox
End Class
