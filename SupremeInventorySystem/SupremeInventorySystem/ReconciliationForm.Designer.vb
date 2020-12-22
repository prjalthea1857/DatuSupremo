<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReconciliationForm
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
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ItemNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RegisterDateTextBox = New System.Windows.Forms.TextBox()
        Me.QueueDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.AddToQueueButton = New System.Windows.Forms.Button()
        Me.TransactionModeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SaveTransactionButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DeviceTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Reconciliation"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(825, 53)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 14)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Register Item"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.PriceTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PriceTextBox.Location = New System.Drawing.Point(187, 366)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(154, 25)
        Me.PriceTextBox.TabIndex = 2
        Me.PriceTextBox.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(183, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 19)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Price"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.QuantityTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.QuantityTextBox.Location = New System.Drawing.Point(18, 366)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(154, 25)
        Me.QuantityTextBox.TabIndex = 55
        Me.QuantityTextBox.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(14, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 19)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(14, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Register Date"
        '
        'ItemNameComboBox
        '
        Me.ItemNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ItemNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ItemNameComboBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ItemNameComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ItemNameComboBox.FormattingEnabled = True
        Me.ItemNameComboBox.Location = New System.Drawing.Point(18, 146)
        Me.ItemNameComboBox.Name = "ItemNameComboBox"
        Me.ItemNameComboBox.Size = New System.Drawing.Size(323, 25)
        Me.ItemNameComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(14, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Item Name"
        '
        'RegisterDateTextBox
        '
        Me.RegisterDateTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.RegisterDateTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.RegisterDateTextBox.Location = New System.Drawing.Point(18, 311)
        Me.RegisterDateTextBox.Name = "RegisterDateTextBox"
        Me.RegisterDateTextBox.ReadOnly = True
        Me.RegisterDateTextBox.Size = New System.Drawing.Size(323, 25)
        Me.RegisterDateTextBox.TabIndex = 62
        Me.RegisterDateTextBox.TabStop = False
        '
        'QueueDataGridView
        '
        Me.QueueDataGridView.AllowUserToAddRows = False
        Me.QueueDataGridView.AllowUserToDeleteRows = False
        Me.QueueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QueueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.bookName, Me.quantity, Me.price})
        Me.QueueDataGridView.Location = New System.Drawing.Point(361, 124)
        Me.QueueDataGridView.MultiSelect = False
        Me.QueueDataGridView.Name = "QueueDataGridView"
        Me.QueueDataGridView.ReadOnly = True
        Me.QueueDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.QueueDataGridView.Size = New System.Drawing.Size(452, 267)
        Me.QueueDataGridView.TabIndex = 63
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'bookName
        '
        Me.bookName.HeaderText = "Item name"
        Me.bookName.Name = "bookName"
        Me.bookName.ReadOnly = True
        Me.bookName.Width = 200
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
        'RemoveButton
        '
        Me.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveButton.Enabled = False
        Me.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.RemoveButton.FlatAppearance.BorderSize = 2
        Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveButton.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.RemoveButton.ForeColor = System.Drawing.Color.Red
        Me.RemoveButton.Location = New System.Drawing.Point(738, 94)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 24)
        Me.RemoveButton.TabIndex = 64
        Me.RemoveButton.TabStop = False
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'AddToQueueButton
        '
        Me.AddToQueueButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddToQueueButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.AddToQueueButton.FlatAppearance.BorderSize = 2
        Me.AddToQueueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddToQueueButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AddToQueueButton.ForeColor = System.Drawing.Color.Red
        Me.AddToQueueButton.Location = New System.Drawing.Point(213, 406)
        Me.AddToQueueButton.Name = "AddToQueueButton"
        Me.AddToQueueButton.Size = New System.Drawing.Size(128, 28)
        Me.AddToQueueButton.TabIndex = 65
        Me.AddToQueueButton.Text = "Add To Queue"
        Me.AddToQueueButton.UseVisualStyleBackColor = True
        '
        'TransactionModeComboBox
        '
        Me.TransactionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TransactionModeComboBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TransactionModeComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.TransactionModeComboBox.FormattingEnabled = True
        Me.TransactionModeComboBox.Items.AddRange(New Object() {"Beginning Balance", "Purchases"})
        Me.TransactionModeComboBox.Location = New System.Drawing.Point(603, 59)
        Me.TransactionModeComboBox.Name = "TransactionModeComboBox"
        Me.TransactionModeComboBox.Size = New System.Drawing.Size(210, 25)
        Me.TransactionModeComboBox.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(451, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 19)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Mode of Transaction"
        '
        'SaveTransactionButton
        '
        Me.SaveTransactionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveTransactionButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.SaveTransactionButton.FlatAppearance.BorderSize = 2
        Me.SaveTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveTransactionButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.SaveTransactionButton.ForeColor = System.Drawing.Color.Red
        Me.SaveTransactionButton.Location = New System.Drawing.Point(654, 406)
        Me.SaveTransactionButton.Name = "SaveTransactionButton"
        Me.SaveTransactionButton.Size = New System.Drawing.Size(159, 28)
        Me.SaveTransactionButton.TabIndex = 68
        Me.SaveTransactionButton.Text = "Save Transaction"
        Me.SaveTransactionButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 2
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(520, 406)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(128, 28)
        Me.CloseButton.TabIndex = 69
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(14, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(14, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Device"
        '
        'DeviceTextBox
        '
        Me.DeviceTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DeviceTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.DeviceTextBox.Location = New System.Drawing.Point(18, 201)
        Me.DeviceTextBox.Name = "DeviceTextBox"
        Me.DeviceTextBox.ReadOnly = True
        Me.DeviceTextBox.Size = New System.Drawing.Size(323, 25)
        Me.DeviceTextBox.TabIndex = 73
        Me.DeviceTextBox.TabStop = False
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CategoryTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CategoryTextBox.Location = New System.Drawing.Point(18, 256)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.ReadOnly = True
        Me.CategoryTextBox.Size = New System.Drawing.Size(323, 25)
        Me.CategoryTextBox.TabIndex = 74
        Me.CategoryTextBox.TabStop = False
        '
        'ReconciliationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(825, 448)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(Me.DeviceTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SaveTransactionButton)
        Me.Controls.Add(Me.TransactionModeComboBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AddToQueueButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.QueueDataGridView)
        Me.Controls.Add(Me.RegisterDateTextBox)
        Me.Controls.Add(Me.ItemNameComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ReconciliationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reconciliation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ItemNameComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RegisterDateTextBox As TextBox
    Friend WithEvents QueueDataGridView As DataGridView
    Friend WithEvents RemoveButton As Button
    Friend WithEvents AddToQueueButton As Button
    Friend WithEvents TransactionModeComboBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SaveTransactionButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents bookName As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DeviceTextBox As TextBox
    Friend WithEvents CategoryTextBox As TextBox
End Class
