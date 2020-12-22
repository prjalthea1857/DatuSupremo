<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BooksDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddBookButton = New System.Windows.Forms.Button()
        Me.EditBookButton = New System.Windows.Forms.Button()
        Me.DeleteBookButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StockCardButton = New System.Windows.Forms.Button()
        Me.cmbBxFilter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.device = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1009, 53)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventory"
        '
        'BooksDataGridView
        '
        Me.BooksDataGridView.AllowUserToAddRows = False
        Me.BooksDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BooksDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.stockName, Me.device, Me.category, Me.quantity, Me.price})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BooksDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.BooksDataGridView.Location = New System.Drawing.Point(18, 101)
        Me.BooksDataGridView.MultiSelect = False
        Me.BooksDataGridView.Name = "BooksDataGridView"
        Me.BooksDataGridView.ReadOnly = True
        Me.BooksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BooksDataGridView.Size = New System.Drawing.Size(971, 432)
        Me.BooksDataGridView.TabIndex = 2
        '
        'AddBookButton
        '
        Me.AddBookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddBookButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.AddBookButton.FlatAppearance.BorderSize = 2
        Me.AddBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBookButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AddBookButton.ForeColor = System.Drawing.Color.Red
        Me.AddBookButton.Location = New System.Drawing.Point(18, 67)
        Me.AddBookButton.Name = "AddBookButton"
        Me.AddBookButton.Size = New System.Drawing.Size(115, 28)
        Me.AddBookButton.TabIndex = 7
        Me.AddBookButton.Text = "Add Item"
        Me.AddBookButton.UseVisualStyleBackColor = True
        '
        'EditBookButton
        '
        Me.EditBookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditBookButton.Enabled = False
        Me.EditBookButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.EditBookButton.FlatAppearance.BorderSize = 2
        Me.EditBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBookButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.EditBookButton.ForeColor = System.Drawing.Color.Red
        Me.EditBookButton.Location = New System.Drawing.Point(139, 67)
        Me.EditBookButton.Name = "EditBookButton"
        Me.EditBookButton.Size = New System.Drawing.Size(115, 28)
        Me.EditBookButton.TabIndex = 8
        Me.EditBookButton.Text = "Edit Item"
        Me.EditBookButton.UseVisualStyleBackColor = True
        '
        'DeleteBookButton
        '
        Me.DeleteBookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteBookButton.Enabled = False
        Me.DeleteBookButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.DeleteBookButton.FlatAppearance.BorderSize = 2
        Me.DeleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBookButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.DeleteBookButton.ForeColor = System.Drawing.Color.Red
        Me.DeleteBookButton.Location = New System.Drawing.Point(260, 67)
        Me.DeleteBookButton.Name = "DeleteBookButton"
        Me.DeleteBookButton.Size = New System.Drawing.Size(115, 28)
        Me.DeleteBookButton.TabIndex = 9
        Me.DeleteBookButton.Text = "Delete Item"
        Me.DeleteBookButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(814, 67)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(175, 25)
        Me.SearchTextBox.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(754, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Search"
        '
        'StockCardButton
        '
        Me.StockCardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StockCardButton.Enabled = False
        Me.StockCardButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.StockCardButton.FlatAppearance.BorderSize = 2
        Me.StockCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StockCardButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.StockCardButton.ForeColor = System.Drawing.Color.Red
        Me.StockCardButton.Location = New System.Drawing.Point(629, 67)
        Me.StockCardButton.Name = "StockCardButton"
        Me.StockCardButton.Size = New System.Drawing.Size(115, 28)
        Me.StockCardButton.TabIndex = 13
        Me.StockCardButton.Text = "Stock Card"
        Me.StockCardButton.UseVisualStyleBackColor = True
        '
        'cmbBxFilter
        '
        Me.cmbBxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBxFilter.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbBxFilter.FormattingEnabled = True
        Me.cmbBxFilter.Items.AddRange(New Object() {"All", "Phone", "Computer"})
        Me.cmbBxFilter.Location = New System.Drawing.Point(497, 68)
        Me.cmbBxFilter.Name = "cmbBxFilter"
        Me.cmbBxFilter.Size = New System.Drawing.Size(121, 25)
        Me.cmbBxFilter.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(449, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Filter:"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'stockName
        '
        Me.stockName.HeaderText = "Stock Name"
        Me.stockName.Name = "stockName"
        Me.stockName.ReadOnly = True
        Me.stockName.Width = 350
        '
        'device
        '
        Me.device.HeaderText = "Device"
        Me.device.Name = "device"
        Me.device.ReadOnly = True
        Me.device.Width = 120
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        Me.category.Width = 150
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 90
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Width = 150
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 555)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbBxFilter)
        Me.Controls.Add(Me.StockCardButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.DeleteBookButton)
        Me.Controls.Add(Me.EditBookButton)
        Me.Controls.Add(Me.AddBookButton)
        Me.Controls.Add(Me.BooksDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Hub"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddBookButton As Button
    Friend WithEvents EditBookButton As Button
    Friend WithEvents DeleteBookButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BooksDataGridView As DataGridView
    Friend WithEvents StockCardButton As Button
    Friend WithEvents Label3 As Label
    Public WithEvents cmbBxFilter As ComboBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents stockName As DataGridViewTextBoxColumn
    Friend WithEvents device As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
End Class
