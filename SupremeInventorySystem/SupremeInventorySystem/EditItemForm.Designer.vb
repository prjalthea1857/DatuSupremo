﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditItemForm
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.UpdateItemButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DeviceComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.RegisterDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
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
        Me.Label1.Size = New System.Drawing.Size(116, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Edit Item"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 53)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 14)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Edit Item Information"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.PriceTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PriceTextBox.Location = New System.Drawing.Point(187, 351)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(154, 25)
        Me.PriceTextBox.TabIndex = 59
        Me.PriceTextBox.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(183, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 19)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Price"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.QuantityTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.QuantityTextBox.Location = New System.Drawing.Point(18, 351)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(154, 25)
        Me.QuantityTextBox.TabIndex = 57
        Me.QuantityTextBox.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(14, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 19)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Quantity"
        '
        'CloseButton
        '
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 2
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(187, 407)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(154, 32)
        Me.CloseButton.TabIndex = 55
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'UpdateItemButton
        '
        Me.UpdateItemButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateItemButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.UpdateItemButton.FlatAppearance.BorderSize = 2
        Me.UpdateItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateItemButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.UpdateItemButton.ForeColor = System.Drawing.Color.Red
        Me.UpdateItemButton.Location = New System.Drawing.Point(18, 407)
        Me.UpdateItemButton.Name = "UpdateItemButton"
        Me.UpdateItemButton.Size = New System.Drawing.Size(154, 32)
        Me.UpdateItemButton.TabIndex = 54
        Me.UpdateItemButton.Text = "Update"
        Me.UpdateItemButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(14, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Register Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(14, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Category"
        '
        'DeviceComboBox
        '
        Me.DeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeviceComboBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DeviceComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.DeviceComboBox.FormattingEnabled = True
        Me.DeviceComboBox.Items.AddRange(New Object() {"Phone", "Computer"})
        Me.DeviceComboBox.Location = New System.Drawing.Point(18, 186)
        Me.DeviceComboBox.Name = "DeviceComboBox"
        Me.DeviceComboBox.Size = New System.Drawing.Size(323, 25)
        Me.DeviceComboBox.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(14, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Device"
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ItemNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ItemNameTextBox.Location = New System.Drawing.Point(18, 131)
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(323, 25)
        Me.ItemNameTextBox.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(14, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Item Name"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.Enabled = False
        Me.CategoryComboBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CategoryComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(18, 241)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(323, 25)
        Me.CategoryComboBox.TabIndex = 61
        '
        'RegisterDateDateTimePicker
        '
        Me.RegisterDateDateTimePicker.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.RegisterDateDateTimePicker.Location = New System.Drawing.Point(18, 296)
        Me.RegisterDateDateTimePicker.Name = "RegisterDateDateTimePicker"
        Me.RegisterDateDateTimePicker.Size = New System.Drawing.Size(323, 25)
        Me.RegisterDateDateTimePicker.TabIndex = 62
        '
        'EditItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(361, 453)
        Me.Controls.Add(Me.RegisterDateDateTimePicker)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.UpdateItemButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DeviceComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ItemNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "EditItemForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Item"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CloseButton As Button
    Friend WithEvents UpdateItemButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DeviceComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ItemNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents RegisterDateDateTimePicker As DateTimePicker
End Class
