<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionsForm
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RecordsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transactionNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cashtendered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.change = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recordDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewTransactionButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.RecordsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(153, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Transactions"
        '
        'CloseButton
        '
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 2
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(644, 401)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(128, 28)
        Me.CloseButton.TabIndex = 70
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 14)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "View Records"
        '
        'RecordsDataGridView
        '
        Me.RecordsDataGridView.AllowUserToAddRows = False
        Me.RecordsDataGridView.AllowUserToDeleteRows = False
        Me.RecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecordsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.transactionNumber, Me.total, Me.cashtendered, Me.change, Me.recordDate})
        Me.RecordsDataGridView.Location = New System.Drawing.Point(18, 113)
        Me.RecordsDataGridView.MultiSelect = False
        Me.RecordsDataGridView.Name = "RecordsDataGridView"
        Me.RecordsDataGridView.ReadOnly = True
        Me.RecordsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RecordsDataGridView.Size = New System.Drawing.Size(754, 282)
        Me.RecordsDataGridView.TabIndex = 72
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'transactionNumber
        '
        Me.transactionNumber.HeaderText = "Transaction Number"
        Me.transactionNumber.Name = "transactionNumber"
        Me.transactionNumber.ReadOnly = True
        Me.transactionNumber.Width = 150
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 90
        '
        'cashtendered
        '
        Me.cashtendered.HeaderText = "Cash Tendered"
        Me.cashtendered.Name = "cashtendered"
        Me.cashtendered.ReadOnly = True
        Me.cashtendered.Width = 150
        '
        'change
        '
        Me.change.HeaderText = "Change"
        Me.change.Name = "change"
        Me.change.ReadOnly = True
        Me.change.Width = 90
        '
        'recordDate
        '
        Me.recordDate.HeaderText = "Record Date"
        Me.recordDate.Name = "recordDate"
        Me.recordDate.ReadOnly = True
        Me.recordDate.Width = 180
        '
        'ViewTransactionButton
        '
        Me.ViewTransactionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ViewTransactionButton.Enabled = False
        Me.ViewTransactionButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ViewTransactionButton.FlatAppearance.BorderSize = 2
        Me.ViewTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTransactionButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ViewTransactionButton.ForeColor = System.Drawing.Color.Red
        Me.ViewTransactionButton.Location = New System.Drawing.Point(18, 401)
        Me.ViewTransactionButton.Name = "ViewTransactionButton"
        Me.ViewTransactionButton.Size = New System.Drawing.Size(137, 28)
        Me.ViewTransactionButton.TabIndex = 73
        Me.ViewTransactionButton.Text = "View Transaction"
        Me.ViewTransactionButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(784, 53)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TransactionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.ViewTransactionButton)
        Me.Controls.Add(Me.RecordsDataGridView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "TransactionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meow Meow Cellphone and Computer Shop"
        CType(Me.RecordsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents RecordsDataGridView As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents transactionNumber As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents cashtendered As DataGridViewTextBoxColumn
    Friend WithEvents change As DataGridViewTextBoxColumn
    Friend WithEvents recordDate As DataGridViewTextBoxColumn
    Friend WithEvents ViewTransactionButton As Button
End Class
