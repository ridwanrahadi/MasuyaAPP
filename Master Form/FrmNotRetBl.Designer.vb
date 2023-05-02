<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotRetBl
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tglbuat = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtJL = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblref = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnpwp = New System.Windows.Forms.TextBox()
        Me.txtalm3 = New System.Windows.Forms.TextBox()
        Me.txtalm2 = New System.Windows.Forms.TextBox()
        Me.txtalm1 = New System.Windows.Forms.TextBox()
        Me.txtpkp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tglfp = New System.Windows.Forms.DateTimePicker()
        Me.txtnofp = New System.Windows.Forms.TextBox()
        Me.txtnoret = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtsub = New System.Windows.Forms.TextBox()
        Me.txtdisc = New System.Windows.Forms.TextBox()
        Me.txttot = New System.Windows.Forms.TextBox()
        Me.txtppn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.lblprint = New System.Windows.Forms.Label()
        Me.CkPrint = New System.Windows.Forms.CheckBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPrsPpn = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tglbuat)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtJL)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblref)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtnpwp)
        Me.GroupBox1.Controls.Add(Me.txtalm3)
        Me.GroupBox1.Controls.Add(Me.txtalm2)
        Me.GroupBox1.Controls.Add(Me.txtalm1)
        Me.GroupBox1.Controls.Add(Me.txtpkp)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tglfp)
        Me.GroupBox1.Controls.Add(Me.txtnofp)
        Me.GroupBox1.Controls.Add(Me.txtnoret)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tglbuat
        '
        Me.tglbuat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglbuat.Location = New System.Drawing.Point(120, 73)
        Me.tglbuat.Name = "tglbuat"
        Me.tglbuat.Size = New System.Drawing.Size(100, 20)
        Me.tglbuat.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Tgl Buat Nota Reture"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 20)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtJL
        '
        Me.txtJL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJL.Location = New System.Drawing.Point(229, 103)
        Me.txtJL.Name = "txtJL"
        Me.txtJL.Size = New System.Drawing.Size(100, 20)
        Me.txtJL.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(188, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "No BL"
        '
        'lblref
        '
        Me.lblref.AutoSize = True
        Me.lblref.Location = New System.Drawing.Point(79, 132)
        Me.lblref.Name = "lblref"
        Me.lblref.Size = New System.Drawing.Size(10, 13)
        Me.lblref.TabIndex = 17
        Me.lblref.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "No Ref"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(407, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "NPWP"
        '
        'txtnpwp
        '
        Me.txtnpwp.Location = New System.Drawing.Point(481, 125)
        Me.txtnpwp.Name = "txtnpwp"
        Me.txtnpwp.Size = New System.Drawing.Size(270, 20)
        Me.txtnpwp.TabIndex = 14
        '
        'txtalm3
        '
        Me.txtalm3.Location = New System.Drawing.Point(481, 99)
        Me.txtalm3.Name = "txtalm3"
        Me.txtalm3.Size = New System.Drawing.Size(270, 20)
        Me.txtalm3.TabIndex = 13
        '
        'txtalm2
        '
        Me.txtalm2.Location = New System.Drawing.Point(481, 73)
        Me.txtalm2.Name = "txtalm2"
        Me.txtalm2.Size = New System.Drawing.Size(270, 20)
        Me.txtalm2.TabIndex = 12
        '
        'txtalm1
        '
        Me.txtalm1.Location = New System.Drawing.Point(481, 47)
        Me.txtalm1.Name = "txtalm1"
        Me.txtalm1.Size = New System.Drawing.Size(270, 20)
        Me.txtalm1.TabIndex = 11
        '
        'txtpkp
        '
        Me.txtpkp.Location = New System.Drawing.Point(481, 13)
        Me.txtpkp.Name = "txtpkp"
        Me.txtpkp.Size = New System.Drawing.Size(270, 20)
        Me.txtpkp.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(407, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(407, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kepada PKP"
        '
        'tglfp
        '
        Me.tglfp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglfp.Location = New System.Drawing.Point(82, 103)
        Me.tglfp.Name = "tglfp"
        Me.tglfp.Size = New System.Drawing.Size(100, 20)
        Me.tglfp.TabIndex = 7
        '
        'txtnofp
        '
        Me.txtnofp.Location = New System.Drawing.Point(82, 47)
        Me.txtnofp.Name = "txtnofp"
        Me.txtnofp.Size = New System.Drawing.Size(177, 20)
        Me.txtnofp.TabIndex = 6
        '
        'txtnoret
        '
        Me.txtnoret.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnoret.Location = New System.Drawing.Point(82, 13)
        Me.txtnoret.Name = "txtnoret"
        Me.txtnoret.Size = New System.Drawing.Size(100, 20)
        Me.txtnoret.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tgl FP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Atas No. FP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No Reture"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(757, 166)
        Me.DataGridView1.TabIndex = 1
        '
        'txtsub
        '
        Me.txtsub.Location = New System.Drawing.Point(647, 346)
        Me.txtsub.Name = "txtsub"
        Me.txtsub.ReadOnly = True
        Me.txtsub.Size = New System.Drawing.Size(122, 20)
        Me.txtsub.TabIndex = 16
        '
        'txtdisc
        '
        Me.txtdisc.Location = New System.Drawing.Point(647, 372)
        Me.txtdisc.Name = "txtdisc"
        Me.txtdisc.Size = New System.Drawing.Size(122, 20)
        Me.txtdisc.TabIndex = 17
        '
        'txttot
        '
        Me.txttot.Location = New System.Drawing.Point(647, 398)
        Me.txttot.Name = "txttot"
        Me.txttot.ReadOnly = True
        Me.txttot.Size = New System.Drawing.Size(122, 20)
        Me.txttot.TabIndex = 18
        '
        'txtppn
        '
        Me.txtppn.Location = New System.Drawing.Point(647, 445)
        Me.txtppn.Name = "txtppn"
        Me.txtppn.ReadOnly = True
        Me.txtppn.Size = New System.Drawing.Size(122, 20)
        Me.txtppn.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(573, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Sub Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(573, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Discount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(573, 401)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(573, 448)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Ppn"
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(12, 427)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 23
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(93, 427)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 24
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(174, 427)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrint.TabIndex = 25
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'lblprint
        '
        Me.lblprint.AutoSize = True
        Me.lblprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprint.Location = New System.Drawing.Point(450, 405)
        Me.lblprint.Name = "lblprint"
        Me.lblprint.Size = New System.Drawing.Size(87, 13)
        Me.lblprint.TabIndex = 20
        Me.lblprint.Text = "Ready to print"
        '
        'CkPrint
        '
        Me.CkPrint.AutoCheck = False
        Me.CkPrint.AutoSize = True
        Me.CkPrint.Location = New System.Drawing.Point(453, 428)
        Me.CkPrint.Name = "CkPrint"
        Me.CkPrint.Size = New System.Drawing.Size(73, 17)
        Me.CkPrint.TabIndex = 26
        Me.CkPrint.Text = "Ter Cetak"
        Me.CkPrint.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(255, 427)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 27
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(336, 427)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 28
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 456)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Export Nota Retur Beli"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(573, 423)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "PrsPpn"
        '
        'txtPrsPpn
        '
        Me.txtPrsPpn.Location = New System.Drawing.Point(647, 421)
        Me.txtPrsPpn.Name = "txtPrsPpn"
        Me.txtPrsPpn.Size = New System.Drawing.Size(37, 20)
        Me.txtPrsPpn.TabIndex = 32
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteDataToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(159, 30)
        '
        'DeleteDataToolStripMenuItem
        '
        Me.DeleteDataToolStripMenuItem.Name = "DeleteDataToolStripMenuItem"
        Me.DeleteDataToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.DeleteDataToolStripMenuItem.Text = "Delete data"
        '
        'FrmNotRetBl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(781, 485)
        Me.Controls.Add(Me.txtPrsPpn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.CkPrint)
        Me.Controls.Add(Me.lblprint)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtppn)
        Me.Controls.Add(Me.txttot)
        Me.Controls.Add(Me.txtdisc)
        Me.Controls.Add(Me.txtsub)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmNotRetBl"
        Me.ShowIcon = False
        Me.Text = "Form Nota Reture Beli"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblref As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnpwp As System.Windows.Forms.TextBox
    Friend WithEvents txtalm3 As System.Windows.Forms.TextBox
    Friend WithEvents txtalm2 As System.Windows.Forms.TextBox
    Friend WithEvents txtalm1 As System.Windows.Forms.TextBox
    Friend WithEvents txtpkp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tglfp As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnofp As System.Windows.Forms.TextBox
    Friend WithEvents txtnoret As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtsub As System.Windows.Forms.TextBox
    Friend WithEvents txtdisc As System.Windows.Forms.TextBox
    Friend WithEvents txttot As System.Windows.Forms.TextBox
    Friend WithEvents txtppn As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents txtJL As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblprint As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CkPrint As System.Windows.Forms.CheckBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents tglbuat As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPrsPpn As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
