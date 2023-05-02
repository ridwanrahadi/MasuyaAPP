<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSales
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBCust = New System.Windows.Forms.ComboBox()
        Me.CBHari = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DivSalestxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NmSalestxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBcodesales = New System.Windows.Forms.ComboBox()
        Me.DGSales = New System.Windows.Forms.DataGridView()
        Me.BtSimpan = New System.Windows.Forms.Button()
        Me.BtKeluar = New System.Windows.Forms.Button()
        Me.BtHapus = New System.Windows.Forms.Button()
        Me.BtCancel = New System.Windows.Forms.Button()
        Me.BtView = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBCust)
        Me.GroupBox1.Controls.Add(Me.CBHari)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DivSalestxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NmSalestxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CBcodesales)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Input Data |"
        '
        'CBCust
        '
        Me.CBCust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBCust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCust.FormattingEnabled = True
        Me.CBCust.Location = New System.Drawing.Point(288, 49)
        Me.CBCust.Name = "CBCust"
        Me.CBCust.Size = New System.Drawing.Size(183, 21)
        Me.CBCust.TabIndex = 1
        '
        'CBHari
        '
        Me.CBHari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBHari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBHari.FormattingEnabled = True
        Me.CBHari.Items.AddRange(New Object() {"SENIN", "SELASA", "RABU", "KAMIS", "JUMAT", "SABTU"})
        Me.CBHari.Location = New System.Drawing.Point(288, 76)
        Me.CBHari.Name = "CBHari"
        Me.CBHari.Size = New System.Drawing.Size(100, 21)
        Me.CBHari.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nama Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Hari Kunjungan"
        '
        'DivSalestxt
        '
        Me.DivSalestxt.Location = New System.Drawing.Point(94, 75)
        Me.DivSalestxt.Name = "DivSalestxt"
        Me.DivSalestxt.Size = New System.Drawing.Size(100, 20)
        Me.DivSalestxt.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Divisi"
        '
        'NmSalestxt
        '
        Me.NmSalestxt.Location = New System.Drawing.Point(94, 49)
        Me.NmSalestxt.Name = "NmSalestxt"
        Me.NmSalestxt.Size = New System.Drawing.Size(100, 20)
        Me.NmSalestxt.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Sales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Code Sales"
        '
        'CBcodesales
        '
        Me.CBcodesales.FormattingEnabled = True
        Me.CBcodesales.Location = New System.Drawing.Point(94, 22)
        Me.CBcodesales.Name = "CBcodesales"
        Me.CBcodesales.Size = New System.Drawing.Size(59, 21)
        Me.CBcodesales.TabIndex = 0
        '
        'DGSales
        '
        Me.DGSales.AllowUserToAddRows = False
        Me.DGSales.AllowUserToDeleteRows = False
        Me.DGSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSales.Location = New System.Drawing.Point(12, 155)
        Me.DGSales.Name = "DGSales"
        Me.DGSales.ReadOnly = True
        Me.DGSales.Size = New System.Drawing.Size(477, 129)
        Me.DGSales.TabIndex = 9
        '
        'BtSimpan
        '
        Me.BtSimpan.Location = New System.Drawing.Point(173, 126)
        Me.BtSimpan.Name = "BtSimpan"
        Me.BtSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtSimpan.TabIndex = 3
        Me.BtSimpan.Text = "Simpan"
        Me.BtSimpan.UseVisualStyleBackColor = True
        '
        'BtKeluar
        '
        Me.BtKeluar.Location = New System.Drawing.Point(416, 126)
        Me.BtKeluar.Name = "BtKeluar"
        Me.BtKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtKeluar.TabIndex = 6
        Me.BtKeluar.Text = "Keluar"
        Me.BtKeluar.UseVisualStyleBackColor = True
        '
        'BtHapus
        '
        Me.BtHapus.Location = New System.Drawing.Point(254, 126)
        Me.BtHapus.Name = "BtHapus"
        Me.BtHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtHapus.TabIndex = 10
        Me.BtHapus.Text = "Hapus"
        Me.BtHapus.UseVisualStyleBackColor = True
        '
        'BtCancel
        '
        Me.BtCancel.Location = New System.Drawing.Point(335, 126)
        Me.BtCancel.Name = "BtCancel"
        Me.BtCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtCancel.TabIndex = 4
        Me.BtCancel.Text = "Cancel"
        Me.BtCancel.UseVisualStyleBackColor = True
        '
        'BtView
        '
        Me.BtView.Location = New System.Drawing.Point(12, 126)
        Me.BtView.Name = "BtView"
        Me.BtView.Size = New System.Drawing.Size(75, 23)
        Me.BtView.TabIndex = 11
        Me.BtView.Text = "View"
        Me.BtView.UseVisualStyleBackColor = True
        '
        'FrmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 298)
        Me.Controls.Add(Me.BtView)
        Me.Controls.Add(Me.BtHapus)
        Me.Controls.Add(Me.BtKeluar)
        Me.Controls.Add(Me.BtCancel)
        Me.Controls.Add(Me.BtSimpan)
        Me.Controls.Add(Me.DGSales)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmSales"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBHari As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NmSalestxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBcodesales As System.Windows.Forms.ComboBox
    Friend WithEvents DGSales As System.Windows.Forms.DataGridView
    Friend WithEvents BtSimpan As System.Windows.Forms.Button
    Friend WithEvents BtKeluar As System.Windows.Forms.Button
    Friend WithEvents CBCust As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DivSalestxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtHapus As System.Windows.Forms.Button
    Friend WithEvents BtCancel As System.Windows.Forms.Button
    Friend WithEvents BtView As System.Windows.Forms.Button
End Class
