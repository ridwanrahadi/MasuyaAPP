<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUtama))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtStatus = New System.Windows.Forms.Button()
        Me.BtBukaHarga = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelPass = New System.Windows.Forms.Label()
        Me.Unametxt = New System.Windows.Forms.TextBox()
        Me.Pswtxt = New System.Windows.Forms.TextBox()
        Me.BtLogin = New System.Windows.Forms.Button()
        Me.BtKeluar = New System.Windows.Forms.Button()
        Me.BtTax = New System.Windows.Forms.Button()
        Me.BtLaporan = New System.Windows.Forms.Button()
        Me.BtTagihan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtAccount = New System.Windows.Forms.Button()
        Me.BtLostCust = New System.Windows.Forms.Button()
        Me.BtPrintPO = New System.Windows.Forms.Button()
        Me.Btgudang = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtLapSales = New System.Windows.Forms.Button()
        Me.btnIvMst = New System.Windows.Forms.Button()
        Me.btnSO = New System.Windows.Forms.Button()
        Me.btnprinciple = New System.Windows.Forms.Button()
        Me.DbLocalDataSet = New Aplication_Helper.DbLocalDataSet()
        Me.TblLoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblLoginTableAdapter = New Aplication_Helper.DbLocalDataSetTableAdapters.TblLoginTableAdapter()
        Me.TableAdapterManager = New Aplication_Helper.DbLocalDataSetTableAdapters.TableAdapterManager()
        Me.TblLoginBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblLoginBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ServerTextBox = New System.Windows.Forms.TextBox()
        Me.DatabaseTextBox = New System.Windows.Forms.TextBox()
        Me.btnExpense = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DbLocalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLoginBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblLoginBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 410)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(666, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(628, 21)
        Me.ToolStripStatusLabel1.Text = "PT. MASUYA GRAHA TRIKENCANA Copyright © 2016 Team EDP Masuya Bandung Branch"
        '
        'BtStatus
        '
        Me.BtStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtStatus.Location = New System.Drawing.Point(15, 69)
        Me.BtStatus.Name = "BtStatus"
        Me.BtStatus.Size = New System.Drawing.Size(52, 51)
        Me.BtStatus.TabIndex = 4
        Me.BtStatus.Text = "Klaim"
        Me.BtStatus.UseVisualStyleBackColor = True
        '
        'BtBukaHarga
        '
        Me.BtBukaHarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtBukaHarga.Location = New System.Drawing.Point(562, 339)
        Me.BtBukaHarga.Name = "BtBukaHarga"
        Me.BtBukaHarga.Size = New System.Drawing.Size(84, 67)
        Me.BtBukaHarga.TabIndex = 5
        Me.BtBukaHarga.Text = "Buka Harga"
        Me.BtBukaHarga.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(471, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username :"
        '
        'LabelPass
        '
        Me.LabelPass.AutoSize = True
        Me.LabelPass.Location = New System.Drawing.Point(473, 50)
        Me.LabelPass.Name = "LabelPass"
        Me.LabelPass.Size = New System.Drawing.Size(59, 13)
        Me.LabelPass.TabIndex = 7
        Me.LabelPass.Text = "Password :"
        '
        'Unametxt
        '
        Me.Unametxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Unametxt.Location = New System.Drawing.Point(537, 12)
        Me.Unametxt.Name = "Unametxt"
        Me.Unametxt.Size = New System.Drawing.Size(100, 20)
        Me.Unametxt.TabIndex = 8
        '
        'Pswtxt
        '
        Me.Pswtxt.Location = New System.Drawing.Point(537, 47)
        Me.Pswtxt.Name = "Pswtxt"
        Me.Pswtxt.Size = New System.Drawing.Size(100, 20)
        Me.Pswtxt.TabIndex = 9
        Me.Pswtxt.UseSystemPasswordChar = True
        '
        'BtLogin
        '
        Me.BtLogin.Location = New System.Drawing.Point(562, 80)
        Me.BtLogin.Name = "BtLogin"
        Me.BtLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtLogin.TabIndex = 10
        Me.BtLogin.Text = "Login"
        Me.BtLogin.UseVisualStyleBackColor = True
        '
        'BtKeluar
        '
        Me.BtKeluar.Location = New System.Drawing.Point(562, 109)
        Me.BtKeluar.Name = "BtKeluar"
        Me.BtKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtKeluar.TabIndex = 11
        Me.BtKeluar.Text = "Logout"
        Me.BtKeluar.UseVisualStyleBackColor = True
        '
        'BtTax
        '
        Me.BtTax.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.dollar_icon1
        Me.BtTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtTax.Location = New System.Drawing.Point(15, 12)
        Me.BtTax.Name = "BtTax"
        Me.BtTax.Size = New System.Drawing.Size(52, 51)
        Me.BtTax.TabIndex = 12
        Me.BtTax.UseVisualStyleBackColor = True
        '
        'BtLaporan
        '
        Me.BtLaporan.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.computer
        Me.BtLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtLaporan.Location = New System.Drawing.Point(73, 12)
        Me.BtLaporan.Name = "BtLaporan"
        Me.BtLaporan.Size = New System.Drawing.Size(52, 51)
        Me.BtLaporan.TabIndex = 13
        Me.BtLaporan.UseVisualStyleBackColor = True
        '
        'BtTagihan
        '
        Me.BtTagihan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtTagihan.Location = New System.Drawing.Point(131, 69)
        Me.BtTagihan.Name = "BtTagihan"
        Me.BtTagihan.Size = New System.Drawing.Size(52, 51)
        Me.BtTagihan.TabIndex = 14
        Me.BtTagihan.Text = "KW"
        Me.BtTagihan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 389)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Database"
        '
        'BtAccount
        '
        Me.BtAccount.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.Lock_Icon_16
        Me.BtAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtAccount.Location = New System.Drawing.Point(339, 386)
        Me.BtAccount.Name = "BtAccount"
        Me.BtAccount.Size = New System.Drawing.Size(24, 20)
        Me.BtAccount.TabIndex = 20
        Me.BtAccount.UseVisualStyleBackColor = True
        '
        'BtLostCust
        '
        Me.BtLostCust.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.Other_Internet_Other_color_icon
        Me.BtLostCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtLostCust.Location = New System.Drawing.Point(305, 12)
        Me.BtLostCust.Name = "BtLostCust"
        Me.BtLostCust.Size = New System.Drawing.Size(52, 51)
        Me.BtLostCust.TabIndex = 21
        Me.BtLostCust.UseVisualStyleBackColor = True
        '
        'BtPrintPO
        '
        Me.BtPrintPO.Location = New System.Drawing.Point(73, 69)
        Me.BtPrintPO.Name = "BtPrintPO"
        Me.BtPrintPO.Size = New System.Drawing.Size(52, 51)
        Me.BtPrintPO.TabIndex = 22
        Me.BtPrintPO.Text = "Print PO"
        Me.BtPrintPO.UseVisualStyleBackColor = True
        '
        'Btgudang
        '
        Me.Btgudang.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.Truck_Transportation_512
        Me.Btgudang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btgudang.Location = New System.Drawing.Point(189, 12)
        Me.Btgudang.Name = "Btgudang"
        Me.Btgudang.Size = New System.Drawing.Size(52, 51)
        Me.Btgudang.TabIndex = 23
        Me.Btgudang.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(369, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Versi :"
        '
        'BtLapSales
        '
        Me.BtLapSales.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.Fraud_bukalapak
        Me.BtLapSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtLapSales.Location = New System.Drawing.Point(131, 12)
        Me.BtLapSales.Name = "BtLapSales"
        Me.BtLapSales.Size = New System.Drawing.Size(52, 51)
        Me.BtLapSales.TabIndex = 26
        Me.BtLapSales.UseVisualStyleBackColor = True
        '
        'btnIvMst
        '
        Me.btnIvMst.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.warehouse_inventory_icon_6
        Me.btnIvMst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIvMst.Location = New System.Drawing.Point(247, 12)
        Me.btnIvMst.Name = "btnIvMst"
        Me.btnIvMst.Size = New System.Drawing.Size(52, 51)
        Me.btnIvMst.TabIndex = 27
        Me.btnIvMst.UseVisualStyleBackColor = True
        '
        'btnSO
        '
        Me.btnSO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSO.Location = New System.Drawing.Point(562, 282)
        Me.btnSO.Name = "btnSO"
        Me.btnSO.Size = New System.Drawing.Size(84, 51)
        Me.btnSO.TabIndex = 28
        Me.btnSO.Text = "Sales Order"
        Me.btnSO.UseVisualStyleBackColor = True
        '
        'btnprinciple
        '
        Me.btnprinciple.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprinciple.Location = New System.Drawing.Point(189, 69)
        Me.btnprinciple.Name = "btnprinciple"
        Me.btnprinciple.Size = New System.Drawing.Size(52, 51)
        Me.btnprinciple.TabIndex = 29
        Me.btnprinciple.Text = "P"
        Me.btnprinciple.UseVisualStyleBackColor = True
        '
        'DbLocalDataSet
        '
        Me.DbLocalDataSet.DataSetName = "DbLocalDataSet"
        Me.DbLocalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblLoginBindingSource
        '
        Me.TblLoginBindingSource.DataMember = "TblLogin"
        Me.TblLoginBindingSource.DataSource = Me.DbLocalDataSet
        '
        'TblLoginTableAdapter
        '
        Me.TblLoginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TblLoginTableAdapter = Me.TblLoginTableAdapter
        Me.TableAdapterManager.UpdateOrder = Aplication_Helper.DbLocalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblLoginBindingNavigator
        '
        Me.TblLoginBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblLoginBindingNavigator.BindingSource = Me.TblLoginBindingSource
        Me.TblLoginBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblLoginBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblLoginBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblLoginBindingNavigatorSaveItem})
        Me.TblLoginBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblLoginBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblLoginBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblLoginBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblLoginBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblLoginBindingNavigator.Name = "TblLoginBindingNavigator"
        Me.TblLoginBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblLoginBindingNavigator.Size = New System.Drawing.Size(666, 25)
        Me.TblLoginBindingNavigator.TabIndex = 30
        Me.TblLoginBindingNavigator.Text = "BindingNavigator1"
        Me.TblLoginBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(47, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 29)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblLoginBindingNavigatorSaveItem
        '
        Me.TblLoginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblLoginBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblLoginBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblLoginBindingNavigatorSaveItem.Name = "TblLoginBindingNavigatorSaveItem"
        Me.TblLoginBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblLoginBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ServerTextBox
        '
        Me.ServerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLoginBindingSource, "server", True))
        Me.ServerTextBox.Location = New System.Drawing.Point(56, 386)
        Me.ServerTextBox.Name = "ServerTextBox"
        Me.ServerTextBox.Size = New System.Drawing.Size(112, 20)
        Me.ServerTextBox.TabIndex = 31
        Me.ServerTextBox.Text = "192.168.254.1"
        '
        'DatabaseTextBox
        '
        Me.DatabaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLoginBindingSource, "database", True))
        Me.DatabaseTextBox.Location = New System.Drawing.Point(233, 386)
        Me.DatabaseTextBox.Name = "DatabaseTextBox"
        Me.DatabaseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DatabaseTextBox.TabIndex = 32
        Me.DatabaseTextBox.Text = "mgtbdg2020"
        '
        'btnExpense
        '
        Me.btnExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExpense.Location = New System.Drawing.Point(562, 225)
        Me.btnExpense.Name = "btnExpense"
        Me.btnExpense.Size = New System.Drawing.Size(84, 51)
        Me.btnExpense.TabIndex = 33
        Me.btnExpense.Text = "Expense"
        Me.btnExpense.UseVisualStyleBackColor = True
        '
        'FrmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.Aplication_Helper.My.Resources.Resources.LOGOMASUYA2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(666, 436)
        Me.Controls.Add(Me.btnExpense)
        Me.Controls.Add(Me.DatabaseTextBox)
        Me.Controls.Add(Me.ServerTextBox)
        Me.Controls.Add(Me.TblLoginBindingNavigator)
        Me.Controls.Add(Me.btnprinciple)
        Me.Controls.Add(Me.btnSO)
        Me.Controls.Add(Me.btnIvMst)
        Me.Controls.Add(Me.BtLapSales)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btgudang)
        Me.Controls.Add(Me.BtPrintPO)
        Me.Controls.Add(Me.BtLostCust)
        Me.Controls.Add(Me.BtAccount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtTagihan)
        Me.Controls.Add(Me.BtLaporan)
        Me.Controls.Add(Me.BtTax)
        Me.Controls.Add(Me.BtKeluar)
        Me.Controls.Add(Me.BtLogin)
        Me.Controls.Add(Me.Pswtxt)
        Me.Controls.Add(Me.Unametxt)
        Me.Controls.Add(Me.LabelPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtBukaHarga)
        Me.Controls.Add(Me.BtStatus)
        Me.Controls.Add(Me.StatusStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PT. Masuya Graha Tri Kencana"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DbLocalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLoginBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblLoginBindingNavigator.ResumeLayout(False)
        Me.TblLoginBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BtStatus As System.Windows.Forms.Button
    Friend WithEvents BtBukaHarga As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelPass As System.Windows.Forms.Label
    Friend WithEvents Unametxt As System.Windows.Forms.TextBox
    Friend WithEvents Pswtxt As System.Windows.Forms.TextBox
    Friend WithEvents BtLogin As System.Windows.Forms.Button
    Friend WithEvents BtKeluar As System.Windows.Forms.Button
    Friend WithEvents BtTax As System.Windows.Forms.Button
    Friend WithEvents BtLaporan As System.Windows.Forms.Button
    Friend WithEvents BtTagihan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtAccount As System.Windows.Forms.Button
    Friend WithEvents BtLostCust As System.Windows.Forms.Button
    Friend WithEvents BtPrintPO As System.Windows.Forms.Button
    Friend WithEvents Btgudang As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtLapSales As System.Windows.Forms.Button
    Friend WithEvents btnIvMst As System.Windows.Forms.Button
    Friend WithEvents btnSO As System.Windows.Forms.Button
    Friend WithEvents btnprinciple As System.Windows.Forms.Button
    Friend WithEvents DbLocalDataSet As Aplication_Helper.DbLocalDataSet
    Friend WithEvents TblLoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblLoginTableAdapter As Aplication_Helper.DbLocalDataSetTableAdapters.TblLoginTableAdapter
    Friend WithEvents TableAdapterManager As Aplication_Helper.DbLocalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblLoginBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblLoginBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ServerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatabaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnExpense As System.Windows.Forms.Button

End Class
