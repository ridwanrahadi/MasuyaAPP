<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalesView
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
        Me.BtKeluar = New System.Windows.Forms.Button()
        Me.BtSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NmSalestxt = New System.Windows.Forms.TextBox()
        Me.CBhari = New System.Windows.Forms.ComboBox()
        Me.CBCodeSales = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtKeluar)
        Me.GroupBox1.Controls.Add(Me.BtSearch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NmSalestxt)
        Me.GroupBox1.Controls.Add(Me.CBhari)
        Me.GroupBox1.Controls.Add(Me.CBCodeSales)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 102)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Search |"
        '
        'BtKeluar
        '
        Me.BtKeluar.Location = New System.Drawing.Point(396, 71)
        Me.BtKeluar.Name = "BtKeluar"
        Me.BtKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtKeluar.TabIndex = 4
        Me.BtKeluar.Text = "Exit"
        Me.BtKeluar.UseVisualStyleBackColor = True
        '
        'BtSearch
        '
        Me.BtSearch.Location = New System.Drawing.Point(315, 71)
        Me.BtSearch.Name = "BtSearch"
        Me.BtSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtSearch.TabIndex = 3
        Me.BtSearch.Text = "Search"
        Me.BtSearch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hari"
        '
        'NmSalestxt
        '
        Me.NmSalestxt.Location = New System.Drawing.Point(213, 26)
        Me.NmSalestxt.Name = "NmSalestxt"
        Me.NmSalestxt.Size = New System.Drawing.Size(100, 20)
        Me.NmSalestxt.TabIndex = 2
        '
        'CBhari
        '
        Me.CBhari.FormattingEnabled = True
        Me.CBhari.Items.AddRange(New Object() {"SENIN", "SELASA", "RABU", "KAMIS", "JUMAT", "SABTU"})
        Me.CBhari.Location = New System.Drawing.Point(351, 26)
        Me.CBhari.Name = "CBhari"
        Me.CBhari.Size = New System.Drawing.Size(120, 21)
        Me.CBhari.TabIndex = 1
        '
        'CBCodeSales
        '
        Me.CBCodeSales.FormattingEnabled = True
        Me.CBCodeSales.Location = New System.Drawing.Point(73, 26)
        Me.CBCodeSales.Name = "CBCodeSales"
        Me.CBCodeSales.Size = New System.Drawing.Size(53, 21)
        Me.CBCodeSales.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kode Sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Sales"
        '
        'DGView
        '
        Me.DGView.AllowUserToAddRows = False
        Me.DGView.AllowUserToDeleteRows = False
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Location = New System.Drawing.Point(12, 120)
        Me.DGView.Name = "DGView"
        Me.DGView.ReadOnly = True
        Me.DGView.Size = New System.Drawing.Size(477, 129)
        Me.DGView.TabIndex = 1
        '
        'FrmSalesView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 260)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmSalesView"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Sales Kunjungan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGView As System.Windows.Forms.DataGridView
    Friend WithEvents BtKeluar As System.Windows.Forms.Button
    Friend WithEvents BtSearch As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NmSalestxt As System.Windows.Forms.TextBox
    Friend WithEvents CBhari As System.Windows.Forms.ComboBox
    Friend WithEvents CBCodeSales As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
