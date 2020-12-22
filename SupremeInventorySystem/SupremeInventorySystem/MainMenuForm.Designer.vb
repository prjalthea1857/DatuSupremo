<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuForm
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
        Me.InventoryButton = New System.Windows.Forms.Button()
        Me.ReconciliationButton = New System.Windows.Forms.Button()
        Me.AccountsButton = New System.Windows.Forms.Button()
        Me.CategoriesButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.TransactionsButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Main Menu"
        '
        'InventoryButton
        '
        Me.InventoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InventoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.InventoryButton.FlatAppearance.BorderSize = 2
        Me.InventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryButton.Font = New System.Drawing.Font("Calibri Light", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.InventoryButton.ForeColor = System.Drawing.Color.Red
        Me.InventoryButton.Location = New System.Drawing.Point(16, 70)
        Me.InventoryButton.Name = "InventoryButton"
        Me.InventoryButton.Size = New System.Drawing.Size(285, 45)
        Me.InventoryButton.TabIndex = 8
        Me.InventoryButton.Text = "Inventory"
        Me.InventoryButton.UseVisualStyleBackColor = True
        '
        'ReconciliationButton
        '
        Me.ReconciliationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReconciliationButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ReconciliationButton.FlatAppearance.BorderSize = 2
        Me.ReconciliationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReconciliationButton.Font = New System.Drawing.Font("Calibri Light", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.ReconciliationButton.ForeColor = System.Drawing.Color.Red
        Me.ReconciliationButton.Location = New System.Drawing.Point(16, 126)
        Me.ReconciliationButton.Name = "ReconciliationButton"
        Me.ReconciliationButton.Size = New System.Drawing.Size(285, 45)
        Me.ReconciliationButton.TabIndex = 9
        Me.ReconciliationButton.Text = "Reconciliation"
        Me.ReconciliationButton.UseVisualStyleBackColor = True
        '
        'AccountsButton
        '
        Me.AccountsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AccountsButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.AccountsButton.FlatAppearance.BorderSize = 2
        Me.AccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountsButton.Font = New System.Drawing.Font("Calibri Light", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.AccountsButton.ForeColor = System.Drawing.Color.Red
        Me.AccountsButton.Location = New System.Drawing.Point(16, 182)
        Me.AccountsButton.Name = "AccountsButton"
        Me.AccountsButton.Size = New System.Drawing.Size(285, 45)
        Me.AccountsButton.TabIndex = 10
        Me.AccountsButton.Text = "Accounts"
        Me.AccountsButton.UseVisualStyleBackColor = True
        '
        'CategoriesButton
        '
        Me.CategoriesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CategoriesButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.CategoriesButton.FlatAppearance.BorderSize = 2
        Me.CategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CategoriesButton.Font = New System.Drawing.Font("Calibri Light", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CategoriesButton.ForeColor = System.Drawing.Color.Red
        Me.CategoriesButton.Location = New System.Drawing.Point(16, 238)
        Me.CategoriesButton.Name = "CategoriesButton"
        Me.CategoriesButton.Size = New System.Drawing.Size(285, 45)
        Me.CategoriesButton.TabIndex = 11
        Me.CategoriesButton.Text = "Categories"
        Me.CategoriesButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.LogoutButton.FlatAppearance.BorderSize = 2
        Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutButton.Font = New System.Drawing.Font("Calibri Light", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.LogoutButton.ForeColor = System.Drawing.Color.Red
        Me.LogoutButton.Location = New System.Drawing.Point(16, 393)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(285, 45)
        Me.LogoutButton.TabIndex = 12
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'TransactionsButton
        '
        Me.TransactionsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransactionsButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.TransactionsButton.FlatAppearance.BorderSize = 2
        Me.TransactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionsButton.Font = New System.Drawing.Font("Calibri Light", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.TransactionsButton.ForeColor = System.Drawing.Color.Red
        Me.TransactionsButton.Location = New System.Drawing.Point(16, 294)
        Me.TransactionsButton.Name = "TransactionsButton"
        Me.TransactionsButton.Size = New System.Drawing.Size(285, 45)
        Me.TransactionsButton.TabIndex = 13
        Me.TransactionsButton.Text = "Transactions"
        Me.TransactionsButton.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(16, 383)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(285, 1)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 53)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(316, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TransactionsButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.CategoriesButton)
        Me.Controls.Add(Me.AccountsButton)
        Me.Controls.Add(Me.ReconciliationButton)
        Me.Controls.Add(Me.InventoryButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meow Meow Cellphone and Computer Shop"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents InventoryButton As Button
    Friend WithEvents ReconciliationButton As Button
    Friend WithEvents AccountsButton As Button
    Friend WithEvents CategoriesButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents TransactionsButton As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
