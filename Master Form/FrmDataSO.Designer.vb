<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataSO
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTime1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTime2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkBatal = New System.Windows.Forms.CheckBox()
        Me.ChkApr = New System.Windows.Forms.CheckBox()
        Me.ChkProses = New System.Windows.Forms.CheckBox()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.txtNmCust = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkdsales = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkBlmPros = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSO = New System.Windows.Forms.TextBox()
        Me.txtJL = New System.Windows.Forms.TextBox()
        Me.ChkBc = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnTimbang = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScrollMargin = New System.Drawing.Size(4, 4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.DateTime1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.DateTime2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(348, 35)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal "
        '
        'DateTime1
        '
        Me.DateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime1.Location = New System.Drawing.Point(58, 3)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(124, 20)
        Me.DateTime1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To"
        '
        'DateTime2
        '
        Me.DateTime2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime2.Location = New System.Drawing.Point(214, 3)
        Me.DateTime2.Name = "DateTime2"
        Me.DateTime2.Size = New System.Drawing.Size(124, 20)
        Me.DateTime2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 303)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| List Data |"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(894, 278)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkBatal)
        Me.GroupBox2.Controls.Add(Me.ChkApr)
        Me.GroupBox2.Controls.Add(Me.ChkProses)
        Me.GroupBox2.Controls.Add(Me.btnProses)
        Me.GroupBox2.Controls.Add(Me.txtNmCust)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtkdsales)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(912, 50)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'ChkBatal
        '
        Me.ChkBatal.AutoSize = True
        Me.ChkBatal.Location = New System.Drawing.Point(697, 18)
        Me.ChkBatal.Name = "ChkBatal"
        Me.ChkBatal.Size = New System.Drawing.Size(50, 17)
        Me.ChkBatal.TabIndex = 9
        Me.ChkBatal.Text = "Batal"
        Me.ChkBatal.UseVisualStyleBackColor = True
        '
        'ChkApr
        '
        Me.ChkApr.AutoSize = True
        Me.ChkApr.Location = New System.Drawing.Point(753, 18)
        Me.ChkApr.Name = "ChkApr"
        Me.ChkApr.Size = New System.Drawing.Size(66, 17)
        Me.ChkApr.TabIndex = 7
        Me.ChkApr.Text = "Aproved"
        Me.ChkApr.UseVisualStyleBackColor = True
        '
        'ChkProses
        '
        Me.ChkProses.AutoSize = True
        Me.ChkProses.Location = New System.Drawing.Point(633, 18)
        Me.ChkProses.Name = "ChkProses"
        Me.ChkProses.Size = New System.Drawing.Size(58, 17)
        Me.ChkProses.TabIndex = 3
        Me.ChkProses.Text = "Proses"
        Me.ChkProses.UseVisualStyleBackColor = True
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(825, 14)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 23)
        Me.btnProses.TabIndex = 6
        Me.btnProses.Text = "GO !"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'txtNmCust
        '
        Me.txtNmCust.Location = New System.Drawing.Point(238, 16)
        Me.txtNmCust.Name = "txtNmCust"
        Me.txtNmCust.Size = New System.Drawing.Size(100, 20)
        Me.txtNmCust.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Customer"
        '
        'txtkdsales
        '
        Me.txtkdsales.Location = New System.Drawing.Point(73, 16)
        Me.txtkdsales.Name = "txtkdsales"
        Me.txtkdsales.Size = New System.Drawing.Size(71, 20)
        Me.txtkdsales.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kode Sales"
        '
        'ChkBlmPros
        '
        Me.ChkBlmPros.AutoSize = True
        Me.ChkBlmPros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBlmPros.Location = New System.Drawing.Point(802, 32)
        Me.ChkBlmPros.Name = "ChkBlmPros"
        Me.ChkBlmPros.Size = New System.Drawing.Size(122, 17)
        Me.ChkBlmPros.TabIndex = 10
        Me.ChkBlmPros.Text = "BELUM PROSES"
        Me.ChkBlmPros.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(561, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Find By No SO :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(742, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Find By No JL :"
        '
        'txtSO
        '
        Me.txtSO.Location = New System.Drawing.Point(650, 122)
        Me.txtSO.Name = "txtSO"
        Me.txtSO.Size = New System.Drawing.Size(86, 20)
        Me.txtSO.TabIndex = 10
        '
        'txtJL
        '
        Me.txtJL.Location = New System.Drawing.Point(826, 122)
        Me.txtJL.Name = "txtJL"
        Me.txtJL.Size = New System.Drawing.Size(86, 20)
        Me.txtJL.TabIndex = 12
        '
        'ChkBc
        '
        Me.ChkBc.AutoSize = True
        Me.ChkBc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBc.Location = New System.Drawing.Point(674, 32)
        Me.ChkBc.Name = "ChkBc"
        Me.ChkBc.Size = New System.Drawing.Size(112, 17)
        Me.ChkBc.TabIndex = 13
        Me.ChkBc.Text = "BELUM CETAK"
        Me.ChkBc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(438, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "On Key Enter =>"
        '
        'BtnTimbang
        '
        Me.BtnTimbang.Location = New System.Drawing.Point(12, 110)
        Me.BtnTimbang.Name = "BtnTimbang"
        Me.BtnTimbang.Size = New System.Drawing.Size(120, 23)
        Me.BtnTimbang.TabIndex = 10
        Me.BtnTimbang.Text = "Cek Barang Timbang"
        Me.BtnTimbang.UseVisualStyleBackColor = True
        '
        'FrmDataSO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(930, 453)
        Me.Controls.Add(Me.BtnTimbang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ChkBc)
        Me.Controls.Add(Me.txtJL)
        Me.Controls.Add(Me.txtSO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ChkBlmPros)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.MaximizeBox = False
        Me.Name = "FrmDataSO"
        Me.ShowIcon = False
        Me.Text = " Form Data Sales Order"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTime1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTime2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents txtNmCust As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtkdsales As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkProses As System.Windows.Forms.CheckBox
    Friend WithEvents ChkApr As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBatal As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBlmPros As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSO As System.Windows.Forms.TextBox
    Friend WithEvents txtJL As System.Windows.Forms.TextBox
    Friend WithEvents ChkBc As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnTimbang As System.Windows.Forms.Button
End Class
