<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpense
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.RichTextBox()
        Me.txtpaidBy = New System.Windows.Forms.TextBox()
        Me.txtNoref = New System.Windows.Forms.TextBox()
        Me.cmbPay = New System.Windows.Forms.ComboBox()
        Me.txtpaidTo = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.cmbexpanse = New System.Windows.Forms.ComboBox()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSaveUpdate = New System.Windows.Forms.Button()
        Me.LblT = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.txtpaidBy)
        Me.GroupBox1.Controls.Add(Me.txtNoref)
        Me.GroupBox1.Controls.Add(Me.cmbPay)
        Me.GroupBox1.Controls.Add(Me.txtpaidTo)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.cmbexpanse)
        Me.GroupBox1.Controls.Add(Me.DateTime)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(747, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Expense Details"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(424, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Remarks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(430, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Paid By"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(410, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Payment ref"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Pay Mode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Paid To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Expense Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(479, 126)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(246, 96)
        Me.txtRemarks.TabIndex = 7
        Me.txtRemarks.Text = ""
        '
        'txtpaidBy
        '
        Me.txtpaidBy.Location = New System.Drawing.Point(479, 82)
        Me.txtpaidBy.Name = "txtpaidBy"
        Me.txtpaidBy.Size = New System.Drawing.Size(246, 20)
        Me.txtpaidBy.TabIndex = 6
        '
        'txtNoref
        '
        Me.txtNoref.Location = New System.Drawing.Point(479, 45)
        Me.txtNoref.Name = "txtNoref"
        Me.txtNoref.Size = New System.Drawing.Size(246, 20)
        Me.txtNoref.TabIndex = 5
        '
        'cmbPay
        '
        Me.cmbPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPay.FormattingEnabled = True
        Me.cmbPay.Items.AddRange(New Object() {"CASH", "Draft", "BCA", "DANAMON"})
        Me.cmbPay.Location = New System.Drawing.Point(120, 203)
        Me.cmbPay.Name = "cmbPay"
        Me.cmbPay.Size = New System.Drawing.Size(200, 21)
        Me.cmbPay.TabIndex = 4
        '
        'txtpaidTo
        '
        Me.txtpaidTo.Location = New System.Drawing.Point(120, 163)
        Me.txtpaidTo.Name = "txtpaidTo"
        Me.txtpaidTo.Size = New System.Drawing.Size(200, 20)
        Me.txtpaidTo.TabIndex = 3
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(120, 123)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(200, 20)
        Me.txtamount.TabIndex = 2
        '
        'cmbexpanse
        '
        Me.cmbexpanse.FormattingEnabled = True
        Me.cmbexpanse.Location = New System.Drawing.Point(120, 82)
        Me.cmbexpanse.Name = "cmbexpanse"
        Me.cmbexpanse.Size = New System.Drawing.Size(200, 21)
        Me.cmbexpanse.TabIndex = 1
        '
        'DateTime
        '
        Me.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime.Location = New System.Drawing.Point(120, 42)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(200, 20)
        Me.DateTime.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnPrint.Location = New System.Drawing.Point(559, 294)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(119, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Save + Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSaveUpdate
        '
        Me.btnSaveUpdate.Location = New System.Drawing.Point(684, 294)
        Me.btnSaveUpdate.Name = "btnSaveUpdate"
        Me.btnSaveUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveUpdate.TabIndex = 2
        Me.btnSaveUpdate.Text = "Save"
        Me.btnSaveUpdate.UseVisualStyleBackColor = True
        '
        'LblT
        '
        Me.LblT.AutoSize = True
        Me.LblT.Location = New System.Drawing.Point(71, 271)
        Me.LblT.Name = "LblT"
        Me.LblT.Size = New System.Drawing.Size(39, 13)
        Me.LblT.TabIndex = 3
        Me.LblT.Text = "Label9"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Terbilang :"
        '
        'frmExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 325)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblT)
        Me.Controls.Add(Me.btnSaveUpdate)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmExpense"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Expense"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents txtpaidBy As System.Windows.Forms.TextBox
    Friend WithEvents txtNoref As System.Windows.Forms.TextBox
    Friend WithEvents cmbPay As System.Windows.Forms.ComboBox
    Friend WithEvents txtpaidTo As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents cmbexpanse As System.Windows.Forms.ComboBox
    Friend WithEvents DateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSaveUpdate As System.Windows.Forms.Button
    Friend WithEvents LblT As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
