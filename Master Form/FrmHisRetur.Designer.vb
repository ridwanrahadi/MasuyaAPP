<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHisRetur
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTAkhir = New System.Windows.Forms.DateTimePicker()
        Me.BtProses = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGVHisRetur = New System.Windows.Forms.DataGridView()
        Me.txtnmCust = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoBukti = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGVHisDetail = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVHisRetur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVHisDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start date"
        '
        'DTAwal
        '
        Me.DTAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTAwal.Location = New System.Drawing.Point(95, 15)
        Me.DTAwal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTAwal.Name = "DTAwal"
        Me.DTAwal.Size = New System.Drawing.Size(157, 22)
        Me.DTAwal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "End date"
        '
        'DTAkhir
        '
        Me.DTAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTAkhir.Location = New System.Drawing.Point(336, 15)
        Me.DTAkhir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTAkhir.Name = "DTAkhir"
        Me.DTAkhir.Size = New System.Drawing.Size(153, 22)
        Me.DTAkhir.TabIndex = 3
        '
        'BtProses
        '
        Me.BtProses.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtProses.Location = New System.Drawing.Point(499, 11)
        Me.BtProses.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtProses.Name = "BtProses"
        Me.BtProses.Size = New System.Drawing.Size(100, 28)
        Me.BtProses.TabIndex = 4
        Me.BtProses.Text = "Proses"
        Me.BtProses.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DGVHisRetur)
        Me.GroupBox1.Controls.Add(Me.txtnmCust)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNoBukti)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(872, 662)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 329)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Detail :"
        '
        'DGVHisRetur
        '
        Me.DGVHisRetur.AllowUserToAddRows = False
        Me.DGVHisRetur.AllowUserToDeleteRows = False
        Me.DGVHisRetur.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVHisRetur.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVHisRetur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHisRetur.Location = New System.Drawing.Point(12, 66)
        Me.DGVHisRetur.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVHisRetur.Name = "DGVHisRetur"
        Me.DGVHisRetur.ReadOnly = True
        Me.DGVHisRetur.Size = New System.Drawing.Size(852, 238)
        Me.DGVHisRetur.TabIndex = 6
        '
        'txtnmCust
        '
        Me.txtnmCust.Location = New System.Drawing.Point(341, 31)
        Me.txtnmCust.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnmCust.Name = "txtnmCust"
        Me.txtnmCust.Size = New System.Drawing.Size(284, 22)
        Me.txtnmCust.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nama Customer"
        '
        'txtNoBukti
        '
        Me.txtNoBukti.Location = New System.Drawing.Point(80, 31)
        Me.txtNoBukti.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoBukti.Name = "txtNoBukti"
        Me.txtNoBukti.Size = New System.Drawing.Size(132, 22)
        Me.txtNoBukti.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No Bukti"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(788, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGVHisDetail
        '
        Me.DGVHisDetail.AllowUserToAddRows = False
        Me.DGVHisDetail.AllowUserToDeleteRows = False
        Me.DGVHisDetail.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVHisDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVHisDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHisDetail.Location = New System.Drawing.Point(32, 400)
        Me.DGVHisDetail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVHisDetail.Name = "DGVHisDetail"
        Me.DGVHisDetail.ReadOnly = True
        Me.DGVHisDetail.Size = New System.Drawing.Size(852, 286)
        Me.DGVHisDetail.TabIndex = 7
        '
        'FrmHisRetur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(904, 730)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGVHisDetail)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtProses)
        Me.Controls.Add(Me.DTAkhir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTAwal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmHisRetur"
        Me.ShowIcon = False
        Me.Text = "Histori LPB"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVHisRetur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVHisDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtProses As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVHisRetur As System.Windows.Forms.DataGridView
    Friend WithEvents txtnmCust As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoBukti As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DGVHisDetail As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
