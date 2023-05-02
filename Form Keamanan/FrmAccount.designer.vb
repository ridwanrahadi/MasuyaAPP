<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccount
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Namatxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmblvlSO = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbdivisi = New System.Windows.Forms.ComboBox()
        Me.cmblevel = New System.Windows.Forms.ComboBox()
        Me.BtUpdate = New System.Windows.Forms.Button()
        Me.BtSimpan = New System.Windows.Forms.Button()
        Me.BtCancel = New System.Windows.Forms.Button()
        Me.Pswtxt = New System.Windows.Forms.TextBox()
        Me.Unametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ChkSO = New System.Windows.Forms.CheckBox()
        Me.SalesChk = New System.Windows.Forms.CheckBox()
        Me.PricipleChk = New System.Windows.Forms.CheckBox()
        Me.PrintPOChk = New System.Windows.Forms.CheckBox()
        Me.LostCustChk = New System.Windows.Forms.CheckBox()
        Me.LapBdChk = New System.Windows.Forms.CheckBox()
        Me.BukaChk = New System.Windows.Forms.CheckBox()
        Me.GudangChk = New System.Windows.Forms.CheckBox()
        Me.TagihanChk = New System.Windows.Forms.CheckBox()
        Me.TaxChk = New System.Windows.Forms.CheckBox()
        Me.InvChk = New System.Windows.Forms.CheckBox()
        Me.SpvChk = New System.Windows.Forms.CheckBox()
        Me.KlaimChk = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBUname = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 136)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(438, 228)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Namatxt)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cmblvlSO)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.cmbdivisi)
        Me.TabPage1.Controls.Add(Me.cmblevel)
        Me.TabPage1.Controls.Add(Me.BtUpdate)
        Me.TabPage1.Controls.Add(Me.BtSimpan)
        Me.TabPage1.Controls.Add(Me.BtCancel)
        Me.TabPage1.Controls.Add(Me.Pswtxt)
        Me.TabPage1.Controls.Add(Me.Unametxt)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(430, 202)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create Account"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Namatxt
        '
        Me.Namatxt.Location = New System.Drawing.Point(92, 60)
        Me.Namatxt.Name = "Namatxt"
        Me.Namatxt.Size = New System.Drawing.Size(189, 20)
        Me.Namatxt.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Nama Lengkap"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Level SO"
        '
        'cmblvlSO
        '
        Me.cmblvlSO.FormattingEnabled = True
        Me.cmblvlSO.Items.AddRange(New Object() {"Costing", "Invoicing", "Sales"})
        Me.cmblvlSO.Location = New System.Drawing.Point(92, 169)
        Me.cmblvlSO.Name = "cmblvlSO"
        Me.cmblvlSO.Size = New System.Drawing.Size(121, 21)
        Me.cmblvlSO.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Divisi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Level"
        '
        'cmbdivisi
        '
        Me.cmbdivisi.FormattingEnabled = True
        Me.cmbdivisi.Items.AddRange(New Object() {"FOOD", "RETAIL"})
        Me.cmbdivisi.Location = New System.Drawing.Point(92, 142)
        Me.cmbdivisi.Name = "cmbdivisi"
        Me.cmbdivisi.Size = New System.Drawing.Size(121, 21)
        Me.cmbdivisi.TabIndex = 21
        '
        'cmblevel
        '
        Me.cmblevel.FormattingEnabled = True
        Me.cmblevel.Items.AddRange(New Object() {"admin", "user"})
        Me.cmblevel.Location = New System.Drawing.Point(92, 115)
        Me.cmblevel.Name = "cmblevel"
        Me.cmblevel.Size = New System.Drawing.Size(121, 21)
        Me.cmblevel.TabIndex = 20
        '
        'BtUpdate
        '
        Me.BtUpdate.Location = New System.Drawing.Point(349, 168)
        Me.BtUpdate.Name = "BtUpdate"
        Me.BtUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtUpdate.TabIndex = 19
        Me.BtUpdate.Text = "Update"
        Me.BtUpdate.UseVisualStyleBackColor = True
        '
        'BtSimpan
        '
        Me.BtSimpan.Location = New System.Drawing.Point(349, 139)
        Me.BtSimpan.Name = "BtSimpan"
        Me.BtSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtSimpan.TabIndex = 18
        Me.BtSimpan.Text = "Save"
        Me.BtSimpan.UseVisualStyleBackColor = True
        '
        'BtCancel
        '
        Me.BtCancel.Location = New System.Drawing.Point(349, 110)
        Me.BtCancel.Name = "BtCancel"
        Me.BtCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtCancel.TabIndex = 5
        Me.BtCancel.Text = "Clear"
        Me.BtCancel.UseVisualStyleBackColor = True
        '
        'Pswtxt
        '
        Me.Pswtxt.Location = New System.Drawing.Point(92, 89)
        Me.Pswtxt.Name = "Pswtxt"
        Me.Pswtxt.Size = New System.Drawing.Size(189, 20)
        Me.Pswtxt.TabIndex = 1
        '
        'Unametxt
        '
        Me.Unametxt.Location = New System.Drawing.Point(92, 18)
        Me.Unametxt.Name = "Unametxt"
        Me.Unametxt.Size = New System.Drawing.Size(189, 20)
        Me.Unametxt.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ChkSO)
        Me.TabPage2.Controls.Add(Me.SalesChk)
        Me.TabPage2.Controls.Add(Me.PricipleChk)
        Me.TabPage2.Controls.Add(Me.PrintPOChk)
        Me.TabPage2.Controls.Add(Me.LostCustChk)
        Me.TabPage2.Controls.Add(Me.LapBdChk)
        Me.TabPage2.Controls.Add(Me.BukaChk)
        Me.TabPage2.Controls.Add(Me.GudangChk)
        Me.TabPage2.Controls.Add(Me.TagihanChk)
        Me.TabPage2.Controls.Add(Me.TaxChk)
        Me.TabPage2.Controls.Add(Me.InvChk)
        Me.TabPage2.Controls.Add(Me.SpvChk)
        Me.TabPage2.Controls.Add(Me.KlaimChk)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(430, 202)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Hak Akses"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ChkSO
        '
        Me.ChkSO.AutoSize = True
        Me.ChkSO.Location = New System.Drawing.Point(310, 98)
        Me.ChkSO.Name = "ChkSO"
        Me.ChkSO.Size = New System.Drawing.Size(107, 17)
        Me.ChkSO.TabIndex = 22
        Me.ChkSO.Text = "From Sales Order"
        Me.ChkSO.UseVisualStyleBackColor = True
        '
        'SalesChk
        '
        Me.SalesChk.AutoSize = True
        Me.SalesChk.Location = New System.Drawing.Point(310, 58)
        Me.SalesChk.Name = "SalesChk"
        Me.SalesChk.Size = New System.Drawing.Size(78, 17)
        Me.SalesChk.TabIndex = 21
        Me.SalesChk.Text = "From Sales"
        Me.SalesChk.UseVisualStyleBackColor = True
        '
        'PricipleChk
        '
        Me.PricipleChk.AutoSize = True
        Me.PricipleChk.Location = New System.Drawing.Point(310, 18)
        Me.PricipleChk.Name = "PricipleChk"
        Me.PricipleChk.Size = New System.Drawing.Size(92, 17)
        Me.PricipleChk.TabIndex = 20
        Me.PricipleChk.Text = "Form Principle"
        Me.PricipleChk.UseVisualStyleBackColor = True
        '
        'PrintPOChk
        '
        Me.PrintPOChk.AutoSize = True
        Me.PrintPOChk.Location = New System.Drawing.Point(175, 173)
        Me.PrintPOChk.Name = "PrintPOChk"
        Me.PrintPOChk.Size = New System.Drawing.Size(65, 17)
        Me.PrintPOChk.TabIndex = 19
        Me.PrintPOChk.Text = "Print PO"
        Me.PrintPOChk.UseVisualStyleBackColor = True
        '
        'LostCustChk
        '
        Me.LostCustChk.AutoSize = True
        Me.LostCustChk.Location = New System.Drawing.Point(27, 177)
        Me.LostCustChk.Name = "LostCustChk"
        Me.LostCustChk.Size = New System.Drawing.Size(119, 17)
        Me.LostCustChk.TabIndex = 18
        Me.LostCustChk.Text = "Form Lost Customer"
        Me.LostCustChk.UseVisualStyleBackColor = True
        '
        'LapBdChk
        '
        Me.LapBdChk.AutoSize = True
        Me.LapBdChk.Location = New System.Drawing.Point(175, 138)
        Me.LapBdChk.Name = "LapBdChk"
        Me.LapBdChk.Size = New System.Drawing.Size(109, 17)
        Me.LapBdChk.TabIndex = 15
        Me.LapBdChk.Text = "Form Laporan BD"
        Me.LapBdChk.UseVisualStyleBackColor = True
        '
        'BukaChk
        '
        Me.BukaChk.AutoSize = True
        Me.BukaChk.Location = New System.Drawing.Point(175, 98)
        Me.BukaChk.Name = "BukaChk"
        Me.BukaChk.Size = New System.Drawing.Size(109, 17)
        Me.BukaChk.TabIndex = 14
        Me.BukaChk.Text = "Form Buka Harga"
        Me.BukaChk.UseVisualStyleBackColor = True
        '
        'GudangChk
        '
        Me.GudangChk.AutoSize = True
        Me.GudangChk.Location = New System.Drawing.Point(175, 58)
        Me.GudangChk.Name = "GudangChk"
        Me.GudangChk.Size = New System.Drawing.Size(84, 17)
        Me.GudangChk.TabIndex = 13
        Me.GudangChk.Text = "Frm Gudang"
        Me.GudangChk.UseVisualStyleBackColor = True
        '
        'TagihanChk
        '
        Me.TagihanChk.AutoSize = True
        Me.TagihanChk.Location = New System.Drawing.Point(175, 18)
        Me.TagihanChk.Name = "TagihanChk"
        Me.TagihanChk.Size = New System.Drawing.Size(91, 17)
        Me.TagihanChk.TabIndex = 12
        Me.TagihanChk.Text = "Form Tagihan"
        Me.TagihanChk.UseVisualStyleBackColor = True
        '
        'TaxChk
        '
        Me.TaxChk.AutoSize = True
        Me.TaxChk.Location = New System.Drawing.Point(27, 138)
        Me.TaxChk.Name = "TaxChk"
        Me.TaxChk.Size = New System.Drawing.Size(70, 17)
        Me.TaxChk.TabIndex = 11
        Me.TaxChk.Text = "Form Tax"
        Me.TaxChk.UseVisualStyleBackColor = True
        '
        'InvChk
        '
        Me.InvChk.AutoSize = True
        Me.InvChk.Location = New System.Drawing.Point(27, 98)
        Me.InvChk.Name = "InvChk"
        Me.InvChk.Size = New System.Drawing.Size(96, 17)
        Me.InvChk.TabIndex = 10
        Me.InvChk.Text = "Form Inventory"
        Me.InvChk.UseVisualStyleBackColor = True
        '
        'SpvChk
        '
        Me.SpvChk.AutoSize = True
        Me.SpvChk.Location = New System.Drawing.Point(27, 58)
        Me.SpvChk.Name = "SpvChk"
        Me.SpvChk.Size = New System.Drawing.Size(73, 17)
        Me.SpvChk.TabIndex = 9
        Me.SpvChk.Text = "Form SPV"
        Me.SpvChk.UseVisualStyleBackColor = True
        '
        'KlaimChk
        '
        Me.KlaimChk.AutoSize = True
        Me.KlaimChk.Location = New System.Drawing.Point(27, 18)
        Me.KlaimChk.Name = "KlaimChk"
        Me.KlaimChk.Size = New System.Drawing.Size(77, 17)
        Me.KlaimChk.TabIndex = 8
        Me.KlaimChk.Text = "Form Klaim"
        Me.KlaimChk.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(461, 100)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.Lock_Icon_256
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 94)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "USERNAME :"
        '
        'CBUname
        '
        Me.CBUname.FormattingEnabled = True
        Me.CBUname.Location = New System.Drawing.Point(280, 109)
        Me.CBUname.Name = "CBUname"
        Me.CBUname.Size = New System.Drawing.Size(166, 21)
        Me.CBUname.TabIndex = 6
        '
        'FrmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 376)
        Me.Controls.Add(Me.CBUname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmAccount"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Register Akun"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BtCancel As System.Windows.Forms.Button
    Friend WithEvents Pswtxt As System.Windows.Forms.TextBox
    Friend WithEvents Unametxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBUname As System.Windows.Forms.ComboBox
    Friend WithEvents LapBdChk As System.Windows.Forms.CheckBox
    Friend WithEvents BukaChk As System.Windows.Forms.CheckBox
    Friend WithEvents GudangChk As System.Windows.Forms.CheckBox
    Friend WithEvents TagihanChk As System.Windows.Forms.CheckBox
    Friend WithEvents TaxChk As System.Windows.Forms.CheckBox
    Friend WithEvents InvChk As System.Windows.Forms.CheckBox
    Friend WithEvents SpvChk As System.Windows.Forms.CheckBox
    Friend WithEvents KlaimChk As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LostCustChk As System.Windows.Forms.CheckBox
    Friend WithEvents PrintPOChk As System.Windows.Forms.CheckBox
    Friend WithEvents PricipleChk As System.Windows.Forms.CheckBox
    Friend WithEvents SalesChk As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbdivisi As System.Windows.Forms.ComboBox
    Friend WithEvents cmblevel As System.Windows.Forms.ComboBox
    Friend WithEvents BtUpdate As System.Windows.Forms.Button
    Friend WithEvents BtSimpan As System.Windows.Forms.Button
    Friend WithEvents ChkSO As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmblvlSO As System.Windows.Forms.ComboBox
    Friend WithEvents Namatxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
