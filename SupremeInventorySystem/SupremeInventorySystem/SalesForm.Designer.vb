<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PayButton = New System.Windows.Forms.Button()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.ItemNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CashTenderedTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.QueueDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ChangeTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TransactionNumberLabel = New System.Windows.Forms.Label()
        Me.AddItemButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.RegisterDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SaveTransactionsButton = New System.Windows.Forms.Button()
        Me.TransactionDateTextBox = New System.Windows.Forms.TextBox()
        Me.DeviceTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StockListButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Sales"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1008, 50)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 14)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "New Transaction"
        '
        'PayButton
        '
        Me.PayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PayButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.PayButton.FlatAppearance.BorderSize = 2
        Me.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PayButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.PayButton.ForeColor = System.Drawing.Color.Red
        Me.PayButton.Location = New System.Drawing.Point(0, 459)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(123, 52)
        Me.PayButton.TabIndex = 78
        Me.PayButton.Text = "Pay" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F2)"
        Me.PayButton.UseVisualStyleBackColor = True
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CategoryTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CategoryTextBox.Location = New System.Drawing.Point(18, 271)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.ReadOnly = True
        Me.CategoryTextBox.Size = New System.Drawing.Size(272, 25)
        Me.CategoryTextBox.TabIndex = 76
        Me.CategoryTextBox.TabStop = False
        '
        'ItemNameComboBox
        '
        Me.ItemNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ItemNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ItemNameComboBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ItemNameComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ItemNameComboBox.FormattingEnabled = True
        Me.ItemNameComboBox.Location = New System.Drawing.Point(18, 166)
        Me.ItemNameComboBox.Name = "ItemNameComboBox"
        Me.ItemNameComboBox.Size = New System.Drawing.Size(272, 25)
        Me.ItemNameComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(14, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Item Name"
        '
        'CashTenderedTextBox
        '
        Me.CashTenderedTextBox.Font = New System.Drawing.Font("Calibri", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CashTenderedTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CashTenderedTextBox.Location = New System.Drawing.Point(312, 223)
        Me.CashTenderedTextBox.Name = "CashTenderedTextBox"
        Me.CashTenderedTextBox.Size = New System.Drawing.Size(121, 33)
        Me.CashTenderedTextBox.TabIndex = 67
        Me.CashTenderedTextBox.Text = "0.00"
        Me.CashTenderedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(326, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 19)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Cash Tendered"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(14, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Category"
        '
        'RemoveButton
        '
        Me.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveButton.Enabled = False
        Me.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.RemoveButton.FlatAppearance.BorderSize = 2
        Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveButton.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.RemoveButton.ForeColor = System.Drawing.Color.Red
        Me.RemoveButton.Location = New System.Drawing.Point(921, 100)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 24)
        Me.RemoveButton.TabIndex = 80
        Me.RemoveButton.TabStop = False
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'QueueDataGridView
        '
        Me.QueueDataGridView.AllowUserToAddRows = False
        Me.QueueDataGridView.AllowUserToDeleteRows = False
        Me.QueueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QueueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.itemName, Me.quantity, Me.price, Me.subtotal})
        Me.QueueDataGridView.Location = New System.Drawing.Point(452, 130)
        Me.QueueDataGridView.MultiSelect = False
        Me.QueueDataGridView.Name = "QueueDataGridView"
        Me.QueueDataGridView.ReadOnly = True
        Me.QueueDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.QueueDataGridView.Size = New System.Drawing.Size(543, 315)
        Me.QueueDataGridView.TabIndex = 79
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'itemName
        '
        Me.itemName.HeaderText = "Item Name"
        Me.itemName.Name = "itemName"
        Me.itemName.ReadOnly = True
        Me.itemName.Width = 200
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 65
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Sub Total"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(610, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 19)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Transaction Date"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Red
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 459)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1007, 2)
        Me.PictureBox2.TabIndex = 83
        Me.PictureBox2.TabStop = False
        '
        'ChangeTextBox
        '
        Me.ChangeTextBox.Font = New System.Drawing.Font("Calibri", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ChangeTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ChangeTextBox.Location = New System.Drawing.Point(312, 286)
        Me.ChangeTextBox.Name = "ChangeTextBox"
        Me.ChangeTextBox.ReadOnly = True
        Me.ChangeTextBox.Size = New System.Drawing.Size(121, 33)
        Me.ChangeTextBox.TabIndex = 84
        Me.ChangeTextBox.Text = "0.00"
        Me.ChangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(374, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Change"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Font = New System.Drawing.Font("Calibri", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TotalTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.TotalTextBox.Location = New System.Drawing.Point(312, 159)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(121, 33)
        Me.TotalTextBox.TabIndex = 86
        Me.TotalTextBox.Text = "0.00"
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(391, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(14, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 19)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Transaction Number"
        '
        'TransactionNumberLabel
        '
        Me.TransactionNumberLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TransactionNumberLabel.Location = New System.Drawing.Point(14, 120)
        Me.TransactionNumberLabel.Name = "TransactionNumberLabel"
        Me.TransactionNumberLabel.Size = New System.Drawing.Size(98, 19)
        Me.TransactionNumberLabel.TabIndex = 90
        Me.TransactionNumberLabel.Text = "00000001"
        '
        'AddItemButton
        '
        Me.AddItemButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddItemButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.AddItemButton.FlatAppearance.BorderSize = 2
        Me.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddItemButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.AddItemButton.ForeColor = System.Drawing.Color.Red
        Me.AddItemButton.Location = New System.Drawing.Point(18, 418)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(272, 27)
        Me.AddItemButton.TabIndex = 3
        Me.AddItemButton.TabStop = False
        Me.AddItemButton.Text = "Add Item (ENTER)"
        Me.AddItemButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.LogoutButton.FlatAppearance.BorderSize = 2
        Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LogoutButton.ForeColor = System.Drawing.Color.Red
        Me.LogoutButton.Location = New System.Drawing.Point(885, 459)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(123, 52)
        Me.LogoutButton.TabIndex = 91
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'RegisterDateTextBox
        '
        Me.RegisterDateTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.RegisterDateTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.RegisterDateTextBox.Location = New System.Drawing.Point(18, 326)
        Me.RegisterDateTextBox.Name = "RegisterDateTextBox"
        Me.RegisterDateTextBox.ReadOnly = True
        Me.RegisterDateTextBox.Size = New System.Drawing.Size(272, 25)
        Me.RegisterDateTextBox.TabIndex = 95
        Me.RegisterDateTextBox.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(14, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 19)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Register Date"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.PriceTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PriceTextBox.Location = New System.Drawing.Point(157, 381)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(133, 25)
        Me.PriceTextBox.TabIndex = 96
        Me.PriceTextBox.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(153, 359)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 19)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Price"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.QuantityTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.QuantityTextBox.Location = New System.Drawing.Point(18, 381)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(119, 25)
        Me.QuantityTextBox.TabIndex = 2
        Me.QuantityTextBox.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(14, 359)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 19)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Quantity"
        '
        'SaveTransactionsButton
        '
        Me.SaveTransactionsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveTransactionsButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.SaveTransactionsButton.FlatAppearance.BorderSize = 2
        Me.SaveTransactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveTransactionsButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.SaveTransactionsButton.ForeColor = System.Drawing.Color.Red
        Me.SaveTransactionsButton.Location = New System.Drawing.Point(242, 459)
        Me.SaveTransactionsButton.Name = "SaveTransactionsButton"
        Me.SaveTransactionsButton.Size = New System.Drawing.Size(123, 52)
        Me.SaveTransactionsButton.TabIndex = 100
        Me.SaveTransactionsButton.Text = "Save Transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F10)"
        Me.SaveTransactionsButton.UseVisualStyleBackColor = True
        '
        'TransactionDateTextBox
        '
        Me.TransactionDateTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TransactionDateTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.TransactionDateTextBox.Location = New System.Drawing.Point(736, 62)
        Me.TransactionDateTextBox.Name = "TransactionDateTextBox"
        Me.TransactionDateTextBox.ReadOnly = True
        Me.TransactionDateTextBox.Size = New System.Drawing.Size(260, 25)
        Me.TransactionDateTextBox.TabIndex = 101
        Me.TransactionDateTextBox.TabStop = False
        '
        'DeviceTextBox
        '
        Me.DeviceTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DeviceTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.DeviceTextBox.Location = New System.Drawing.Point(18, 221)
        Me.DeviceTextBox.Name = "DeviceTextBox"
        Me.DeviceTextBox.ReadOnly = True
        Me.DeviceTextBox.Size = New System.Drawing.Size(272, 25)
        Me.DeviceTextBox.TabIndex = 103
        Me.DeviceTextBox.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(14, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 19)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Device"
        '
        'Button1
        '
        Me.StockListButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StockListButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.StockListButton.FlatAppearance.BorderSize = 2
        Me.StockListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StockListButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.StockListButton.ForeColor = System.Drawing.Color.Red
        Me.StockListButton.Location = New System.Drawing.Point(121, 459)
        Me.StockListButton.Name = "Button1"
        Me.StockListButton.Size = New System.Drawing.Size(123, 52)
        Me.StockListButton.TabIndex = 104
        Me.StockListButton.Text = "Stock List" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F8)"
        Me.StockListButton.UseVisualStyleBackColor = True
        '
        'SalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 511)
        Me.Controls.Add(Me.StockListButton)
        Me.Controls.Add(Me.DeviceTextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TransactionDateTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.RegisterDateTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.AddItemButton)
        Me.Controls.Add(Me.TransactionNumberLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ChangeTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.QueueDataGridView)
        Me.Controls.Add(Me.PayButton)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(Me.ItemNameComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CashTenderedTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.SaveTransactionsButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SalesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meow Meow Cellphone and Computer Shop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PayButton As Button
    Friend WithEvents CategoryTextBox As TextBox
    Friend WithEvents ItemNameComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CashTenderedTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RemoveButton As Button
    Friend WithEvents QueueDataGridView As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ChangeTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TransactionNumberLabel As Label
    Friend WithEvents AddItemButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents RegisterDateTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents SaveTransactionsButton As Button
    Friend WithEvents TransactionDateTextBox As TextBox
    Friend WithEvents DeviceTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents itemName As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents StockListButton As Button
End Class
