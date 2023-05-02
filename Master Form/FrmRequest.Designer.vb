<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRequest
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
        Me.NmBrgtxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtKembali = New System.Windows.Forms.Button()
        Me.BtHapus = New System.Windows.Forms.Button()
        Me.BtExit = New System.Windows.Forms.Button()
        Me.BtAdd = New System.Windows.Forms.Button()
        Me.KdBarangCmb = New System.Windows.Forms.ComboBox()
        Me.Hargatxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Qtytxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NoSOtxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NoReqtxt = New System.Windows.Forms.TextBox()
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.Statustxt = New System.Windows.Forms.TextBox()
        Me.BtRefresh = New System.Windows.Forms.Button()
        Me.CBNamasales = New System.Windows.Forms.ComboBox()
        Me.CBNamaCostumer = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NmBrgtxt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.BtKembali)
        Me.GroupBox1.Controls.Add(Me.BtHapus)
        Me.GroupBox1.Controls.Add(Me.BtExit)
        Me.GroupBox1.Controls.Add(Me.BtAdd)
        Me.GroupBox1.Controls.Add(Me.KdBarangCmb)
        Me.GroupBox1.Controls.Add(Me.Hargatxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Qtytxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.NoSOtxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'NmBrgtxt
        '
        Me.NmBrgtxt.Location = New System.Drawing.Point(290, 42)
        Me.NmBrgtxt.Name = "NmBrgtxt"
        Me.NmBrgtxt.Size = New System.Drawing.Size(306, 20)
        Me.NmBrgtxt.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(212, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Nama Barang"
        '
        'BtKembali
        '
        Me.BtKembali.Location = New System.Drawing.Point(440, 112)
        Me.BtKembali.Name = "BtKembali"
        Me.BtKembali.Size = New System.Drawing.Size(75, 23)
        Me.BtKembali.TabIndex = 12
        Me.BtKembali.Text = "Cancel"
        Me.BtKembali.UseVisualStyleBackColor = True
        '
        'BtHapus
        '
        Me.BtHapus.Location = New System.Drawing.Point(359, 112)
        Me.BtHapus.Name = "BtHapus"
        Me.BtHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtHapus.TabIndex = 13
        Me.BtHapus.Text = "Delete"
        Me.BtHapus.UseVisualStyleBackColor = True
        '
        'BtExit
        '
        Me.BtExit.Location = New System.Drawing.Point(521, 112)
        Me.BtExit.Name = "BtExit"
        Me.BtExit.Size = New System.Drawing.Size(75, 23)
        Me.BtExit.TabIndex = 15
        Me.BtExit.Text = "Exit"
        Me.BtExit.UseVisualStyleBackColor = True
        '
        'BtAdd
        '
        Me.BtAdd.Location = New System.Drawing.Point(192, 96)
        Me.BtAdd.Name = "BtAdd"
        Me.BtAdd.Size = New System.Drawing.Size(43, 23)
        Me.BtAdd.TabIndex = 4
        Me.BtAdd.Text = ">>"
        Me.BtAdd.UseVisualStyleBackColor = True
        '
        'KdBarangCmb
        '
        Me.KdBarangCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.KdBarangCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.KdBarangCmb.FormattingEnabled = True
        Me.KdBarangCmb.Location = New System.Drawing.Point(85, 45)
        Me.KdBarangCmb.MaxDropDownItems = 5
        Me.KdBarangCmb.Name = "KdBarangCmb"
        Me.KdBarangCmb.Size = New System.Drawing.Size(121, 21)
        Me.KdBarangCmb.TabIndex = 1
        '
        'Hargatxt
        '
        Me.Hargatxt.Location = New System.Drawing.Point(85, 98)
        Me.Hargatxt.Name = "Hargatxt"
        Me.Hargatxt.Size = New System.Drawing.Size(100, 20)
        Me.Hargatxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No SO"
        '
        'Qtytxt
        '
        Me.Qtytxt.Location = New System.Drawing.Point(85, 72)
        Me.Qtytxt.Name = "Qtytxt"
        Me.Qtytxt.Size = New System.Drawing.Size(59, 20)
        Me.Qtytxt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kode Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Harga"
        '
        'NoSOtxt
        '
        Me.NoSOtxt.Location = New System.Drawing.Point(85, 19)
        Me.NoSOtxt.Name = "NoSOtxt"
        Me.NoSOtxt.Size = New System.Drawing.Size(77, 20)
        Me.NoSOtxt.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Qty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(201, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nama Costumer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(219, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nama Sales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Request"
        '
        'NoReqtxt
        '
        Me.NoReqtxt.Location = New System.Drawing.Point(97, 12)
        Me.NoReqtxt.Multiline = True
        Me.NoReqtxt.Name = "NoReqtxt"
        Me.NoReqtxt.ReadOnly = True
        Me.NoReqtxt.Size = New System.Drawing.Size(100, 20)
        Me.NoReqtxt.TabIndex = 1
        '
        'DGView
        '
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Location = New System.Drawing.Point(12, 210)
        Me.DGView.Name = "DGView"
        Me.DGView.ReadOnly = True
        Me.DGView.Size = New System.Drawing.Size(602, 199)
        Me.DGView.TabIndex = 2
        '
        'Statustxt
        '
        Me.Statustxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Statustxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statustxt.ForeColor = System.Drawing.Color.Black
        Me.Statustxt.Location = New System.Drawing.Point(97, 38)
        Me.Statustxt.Name = "Statustxt"
        Me.Statustxt.ReadOnly = True
        Me.Statustxt.Size = New System.Drawing.Size(100, 22)
        Me.Statustxt.TabIndex = 3
        '
        'BtRefresh
        '
        Me.BtRefresh.Location = New System.Drawing.Point(540, 5)
        Me.BtRefresh.Name = "BtRefresh"
        Me.BtRefresh.Size = New System.Drawing.Size(75, 23)
        Me.BtRefresh.TabIndex = 4
        Me.BtRefresh.Text = "Refresh"
        Me.BtRefresh.UseVisualStyleBackColor = True
        '
        'CBNamasales
        '
        Me.CBNamasales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBNamasales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBNamasales.FormattingEnabled = True
        Me.CBNamasales.Location = New System.Drawing.Point(289, 12)
        Me.CBNamasales.Name = "CBNamasales"
        Me.CBNamasales.Size = New System.Drawing.Size(121, 21)
        Me.CBNamasales.TabIndex = 8
        '
        'CBNamaCostumer
        '
        Me.CBNamaCostumer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBNamaCostumer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBNamaCostumer.FormattingEnabled = True
        Me.CBNamaCostumer.Location = New System.Drawing.Point(289, 43)
        Me.CBNamaCostumer.Name = "CBNamaCostumer"
        Me.CBNamaCostumer.Size = New System.Drawing.Size(188, 21)
        Me.CBNamaCostumer.TabIndex = 9
        '
        'FrmRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 421)
        Me.Controls.Add(Me.CBNamaCostumer)
        Me.Controls.Add(Me.CBNamasales)
        Me.Controls.Add(Me.BtRefresh)
        Me.Controls.Add(Me.Statustxt)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.NoReqtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmRequest"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Request"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Hargatxt As System.Windows.Forms.TextBox
    Friend WithEvents Qtytxt As System.Windows.Forms.TextBox
    Friend WithEvents NoSOtxt As System.Windows.Forms.TextBox
    Friend WithEvents NoReqtxt As System.Windows.Forms.TextBox
    Friend WithEvents KdBarangCmb As System.Windows.Forms.ComboBox
    Friend WithEvents DGView As System.Windows.Forms.DataGridView
    Friend WithEvents BtExit As System.Windows.Forms.Button
    Friend WithEvents BtAdd As System.Windows.Forms.Button
    Friend WithEvents BtHapus As System.Windows.Forms.Button
    Friend WithEvents Statustxt As System.Windows.Forms.TextBox
    Friend WithEvents BtRefresh As System.Windows.Forms.Button
    Friend WithEvents BtKembali As System.Windows.Forms.Button
    Friend WithEvents CBNamasales As System.Windows.Forms.ComboBox
    Friend WithEvents CBNamaCostumer As System.Windows.Forms.ComboBox
    Friend WithEvents NmBrgtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
