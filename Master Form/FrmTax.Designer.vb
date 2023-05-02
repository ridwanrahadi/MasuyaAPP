<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTax
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
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.NfBarutxt = New System.Windows.Forms.TextBox()
        Me.NfLamatxt = New System.Windows.Forms.TextBox()
        Me.BtRubah = New System.Windows.Forms.Button()
        Me.NoJltxt = New System.Windows.Forms.TextBox()
        Me.BtCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtKeluar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTLama = New System.Windows.Forms.DateTimePicker()
        Me.DTBaru = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGView
        '
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Location = New System.Drawing.Point(16, 295)
        Me.DGView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGView.Name = "DGView"
        Me.DGView.Size = New System.Drawing.Size(597, 132)
        Me.DGView.TabIndex = 9
        '
        'NfBarutxt
        '
        Me.NfBarutxt.Location = New System.Drawing.Point(133, 230)
        Me.NfBarutxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NfBarutxt.Name = "NfBarutxt"
        Me.NfBarutxt.Size = New System.Drawing.Size(235, 22)
        Me.NfBarutxt.TabIndex = 5
        '
        'NfLamatxt
        '
        Me.NfLamatxt.Location = New System.Drawing.Point(133, 198)
        Me.NfLamatxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NfLamatxt.Name = "NfLamatxt"
        Me.NfLamatxt.Size = New System.Drawing.Size(235, 22)
        Me.NfLamatxt.TabIndex = 4
        '
        'BtRubah
        '
        Me.BtRubah.Location = New System.Drawing.Point(515, 164)
        Me.BtRubah.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtRubah.Name = "BtRubah"
        Me.BtRubah.Size = New System.Drawing.Size(100, 28)
        Me.BtRubah.TabIndex = 6
        Me.BtRubah.Text = "Rubah"
        Me.BtRubah.UseVisualStyleBackColor = True
        '
        'NoJltxt
        '
        Me.NoJltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoJltxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NoJltxt.Location = New System.Drawing.Point(133, 166)
        Me.NoJltxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NoJltxt.Name = "NoJltxt"
        Me.NoJltxt.Size = New System.Drawing.Size(133, 22)
        Me.NoJltxt.TabIndex = 3
        '
        'BtCancel
        '
        Me.BtCancel.Location = New System.Drawing.Point(515, 196)
        Me.BtCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtCancel.Name = "BtCancel"
        Me.BtCancel.Size = New System.Drawing.Size(100, 28)
        Me.BtCancel.TabIndex = 7
        Me.BtCancel.Text = "Cancel"
        Me.BtCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 234)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Faktur Baru"
        '
        'BtKeluar
        '
        Me.BtKeluar.Location = New System.Drawing.Point(515, 228)
        Me.BtKeluar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtKeluar.Name = "BtKeluar"
        Me.BtKeluar.Size = New System.Drawing.Size(100, 28)
        Me.BtKeluar.TabIndex = 8
        Me.BtKeluar.Text = "Keluar"
        Me.BtKeluar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 202)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Faktur Lama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 170)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No JL"
        '
        'DTLama
        '
        Me.DTLama.CustomFormat = "M/dd/yyyy"
        Me.DTLama.Enabled = False
        Me.DTLama.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTLama.Location = New System.Drawing.Point(377, 198)
        Me.DTLama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTLama.Name = "DTLama"
        Me.DTLama.Size = New System.Drawing.Size(128, 22)
        Me.DTLama.TabIndex = 10
        '
        'DTBaru
        '
        Me.DTBaru.CustomFormat = "M/dd/yyyy"
        Me.DTBaru.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTBaru.Location = New System.Drawing.Point(377, 230)
        Me.DTBaru.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTBaru.Name = "DTBaru"
        Me.DTBaru.Size = New System.Drawing.Size(128, 22)
        Me.DTBaru.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 159)
        Me.Panel1.TabIndex = 13
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.LOGOMASUYA2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(133, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(356, 146)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'FrmTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 443)
        Me.Controls.Add(Me.DTBaru)
        Me.Controls.Add(Me.DTLama)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.BtKeluar)
        Me.Controls.Add(Me.BtCancel)
        Me.Controls.Add(Me.BtRubah)
        Me.Controls.Add(Me.NfBarutxt)
        Me.Controls.Add(Me.NfLamatxt)
        Me.Controls.Add(Me.NoJltxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmTax"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Perubahan No Faktur"
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGView As System.Windows.Forms.DataGridView
    Friend WithEvents NfBarutxt As System.Windows.Forms.TextBox
    Friend WithEvents NfLamatxt As System.Windows.Forms.TextBox
    Friend WithEvents BtRubah As System.Windows.Forms.Button
    Friend WithEvents NoJltxt As System.Windows.Forms.TextBox
    Friend WithEvents BtCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtKeluar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTLama As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTBaru As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
