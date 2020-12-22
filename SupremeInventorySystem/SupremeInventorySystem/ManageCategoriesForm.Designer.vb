<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageCategoriesForm
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PhoneCategoriesListBox = New System.Windows.Forms.ListBox()
        Me.NewPhoneCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddPhoneButton = New System.Windows.Forms.Button()
        Me.PhoneCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EditSavePhoneCategoryButton = New System.Windows.Forms.Button()
        Me.DeleteCancelPhoneCategoryButton = New System.Windows.Forms.Button()
        Me.tbCtrlType = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DeleteCancelComputerCategoryButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EditSaveComputerCategoryButton = New System.Windows.Forms.Button()
        Me.ComputerCategoriesListBox = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NewComputerCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.ComputerCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.AddComputerButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCtrlType.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(135, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Categories"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(607, 50)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 2
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(481, 394)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(115, 28)
        Me.CloseButton.TabIndex = 25
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "New Category"
        '
        'PhoneCategoriesListBox
        '
        Me.PhoneCategoriesListBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.PhoneCategoriesListBox.FormattingEnabled = True
        Me.PhoneCategoriesListBox.ItemHeight = 17
        Me.PhoneCategoriesListBox.Location = New System.Drawing.Point(13, 85)
        Me.PhoneCategoriesListBox.Name = "PhoneCategoriesListBox"
        Me.PhoneCategoriesListBox.Size = New System.Drawing.Size(200, 208)
        Me.PhoneCategoriesListBox.TabIndex = 27
        '
        'NewPhoneCategoryTextBox
        '
        Me.NewPhoneCategoryTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.NewPhoneCategoryTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.NewPhoneCategoryTextBox.Location = New System.Drawing.Point(13, 54)
        Me.NewPhoneCategoryTextBox.Name = "NewPhoneCategoryTextBox"
        Me.NewPhoneCategoryTextBox.Size = New System.Drawing.Size(143, 25)
        Me.NewPhoneCategoryTextBox.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 14)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Phone Category List"
        '
        'AddPhoneButton
        '
        Me.AddPhoneButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddPhoneButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.AddPhoneButton.FlatAppearance.BorderSize = 2
        Me.AddPhoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddPhoneButton.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.AddPhoneButton.ForeColor = System.Drawing.Color.Red
        Me.AddPhoneButton.Location = New System.Drawing.Point(162, 54)
        Me.AddPhoneButton.Name = "AddPhoneButton"
        Me.AddPhoneButton.Size = New System.Drawing.Size(51, 24)
        Me.AddPhoneButton.TabIndex = 32
        Me.AddPhoneButton.Text = "Add"
        Me.AddPhoneButton.UseVisualStyleBackColor = True
        '
        'PhoneCategoryTextBox
        '
        Me.PhoneCategoryTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.PhoneCategoryTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PhoneCategoryTextBox.Location = New System.Drawing.Point(238, 79)
        Me.PhoneCategoryTextBox.Name = "PhoneCategoryTextBox"
        Me.PhoneCategoryTextBox.ReadOnly = True
        Me.PhoneCategoryTextBox.Size = New System.Drawing.Size(212, 25)
        Me.PhoneCategoryTextBox.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(234, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "View Category"
        '
        'EditSavePhoneCategoryButton
        '
        Me.EditSavePhoneCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditSavePhoneCategoryButton.Enabled = False
        Me.EditSavePhoneCategoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.EditSavePhoneCategoryButton.FlatAppearance.BorderSize = 2
        Me.EditSavePhoneCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditSavePhoneCategoryButton.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.EditSavePhoneCategoryButton.ForeColor = System.Drawing.Color.Red
        Me.EditSavePhoneCategoryButton.Location = New System.Drawing.Point(238, 110)
        Me.EditSavePhoneCategoryButton.Name = "EditSavePhoneCategoryButton"
        Me.EditSavePhoneCategoryButton.Size = New System.Drawing.Size(65, 24)
        Me.EditSavePhoneCategoryButton.TabIndex = 36
        Me.EditSavePhoneCategoryButton.Text = "Edit"
        Me.EditSavePhoneCategoryButton.UseVisualStyleBackColor = True
        '
        'DeleteCancelPhoneCategoryButton
        '
        Me.DeleteCancelPhoneCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteCancelPhoneCategoryButton.Enabled = False
        Me.DeleteCancelPhoneCategoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.DeleteCancelPhoneCategoryButton.FlatAppearance.BorderSize = 2
        Me.DeleteCancelPhoneCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteCancelPhoneCategoryButton.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.DeleteCancelPhoneCategoryButton.ForeColor = System.Drawing.Color.Red
        Me.DeleteCancelPhoneCategoryButton.Location = New System.Drawing.Point(309, 110)
        Me.DeleteCancelPhoneCategoryButton.Name = "DeleteCancelPhoneCategoryButton"
        Me.DeleteCancelPhoneCategoryButton.Size = New System.Drawing.Size(62, 24)
        Me.DeleteCancelPhoneCategoryButton.TabIndex = 37
        Me.DeleteCancelPhoneCategoryButton.Text = "Delete"
        Me.DeleteCancelPhoneCategoryButton.UseVisualStyleBackColor = True
        '
        'tbCtrlType
        '
        Me.tbCtrlType.Controls.Add(Me.TabPage1)
        Me.tbCtrlType.Controls.Add(Me.TabPage2)
        Me.tbCtrlType.Location = New System.Drawing.Point(12, 62)
        Me.tbCtrlType.Name = "tbCtrlType"
        Me.tbCtrlType.SelectedIndex = 0
        Me.tbCtrlType.Size = New System.Drawing.Size(584, 326)
        Me.tbCtrlType.TabIndex = 38
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.DeleteCancelPhoneCategoryButton)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.EditSavePhoneCategoryButton)
        Me.TabPage1.Controls.Add(Me.PhoneCategoriesListBox)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.NewPhoneCategoryTextBox)
        Me.TabPage1.Controls.Add(Me.PhoneCategoryTextBox)
        Me.TabPage1.Controls.Add(Me.AddPhoneButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(576, 300)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Phone"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.DeleteCancelComputerCategoryButton)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.EditSaveComputerCategoryButton)
        Me.TabPage2.Controls.Add(Me.ComputerCategoriesListBox)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.NewComputerCategoryTextBox)
        Me.TabPage2.Controls.Add(Me.ComputerCategoryTextBox)
        Me.TabPage2.Controls.Add(Me.AddComputerButton)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(576, 300)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Computer"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 14)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Computer Category List"
        '
        'DeleteCancelComputerCategoryButton
        '
        Me.DeleteCancelComputerCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteCancelComputerCategoryButton.Enabled = False
        Me.DeleteCancelComputerCategoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.DeleteCancelComputerCategoryButton.FlatAppearance.BorderSize = 2
        Me.DeleteCancelComputerCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteCancelComputerCategoryButton.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.DeleteCancelComputerCategoryButton.ForeColor = System.Drawing.Color.Red
        Me.DeleteCancelComputerCategoryButton.Location = New System.Drawing.Point(309, 110)
        Me.DeleteCancelComputerCategoryButton.Name = "DeleteCancelComputerCategoryButton"
        Me.DeleteCancelComputerCategoryButton.Size = New System.Drawing.Size(62, 24)
        Me.DeleteCancelComputerCategoryButton.TabIndex = 46
        Me.DeleteCancelComputerCategoryButton.Text = "Delete"
        Me.DeleteCancelComputerCategoryButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(9, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "New Category"
        '
        'EditSaveComputerCategoryButton
        '
        Me.EditSaveComputerCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditSaveComputerCategoryButton.Enabled = False
        Me.EditSaveComputerCategoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.EditSaveComputerCategoryButton.FlatAppearance.BorderSize = 2
        Me.EditSaveComputerCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditSaveComputerCategoryButton.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.EditSaveComputerCategoryButton.ForeColor = System.Drawing.Color.Red
        Me.EditSaveComputerCategoryButton.Location = New System.Drawing.Point(238, 110)
        Me.EditSaveComputerCategoryButton.Name = "EditSaveComputerCategoryButton"
        Me.EditSaveComputerCategoryButton.Size = New System.Drawing.Size(65, 24)
        Me.EditSaveComputerCategoryButton.TabIndex = 45
        Me.EditSaveComputerCategoryButton.Text = "Edit"
        Me.EditSaveComputerCategoryButton.UseVisualStyleBackColor = True
        '
        'ComputerCategoriesListBox
        '
        Me.ComputerCategoriesListBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ComputerCategoriesListBox.FormattingEnabled = True
        Me.ComputerCategoriesListBox.ItemHeight = 17
        Me.ComputerCategoriesListBox.Location = New System.Drawing.Point(13, 85)
        Me.ComputerCategoriesListBox.Name = "ComputerCategoriesListBox"
        Me.ComputerCategoriesListBox.Size = New System.Drawing.Size(200, 208)
        Me.ComputerCategoriesListBox.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(234, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "View Category"
        '
        'NewComputerCategoryTextBox
        '
        Me.NewComputerCategoryTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.NewComputerCategoryTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.NewComputerCategoryTextBox.Location = New System.Drawing.Point(13, 54)
        Me.NewComputerCategoryTextBox.Name = "NewComputerCategoryTextBox"
        Me.NewComputerCategoryTextBox.Size = New System.Drawing.Size(143, 25)
        Me.NewComputerCategoryTextBox.TabIndex = 40
        '
        'ComputerCategoryTextBox
        '
        Me.ComputerCategoryTextBox.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ComputerCategoryTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ComputerCategoryTextBox.Location = New System.Drawing.Point(238, 79)
        Me.ComputerCategoryTextBox.Name = "ComputerCategoryTextBox"
        Me.ComputerCategoryTextBox.ReadOnly = True
        Me.ComputerCategoryTextBox.Size = New System.Drawing.Size(212, 25)
        Me.ComputerCategoryTextBox.TabIndex = 43
        '
        'AddComputerButton
        '
        Me.AddComputerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddComputerButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.AddComputerButton.FlatAppearance.BorderSize = 2
        Me.AddComputerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddComputerButton.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.AddComputerButton.ForeColor = System.Drawing.Color.Red
        Me.AddComputerButton.Location = New System.Drawing.Point(162, 54)
        Me.AddComputerButton.Name = "AddComputerButton"
        Me.AddComputerButton.Size = New System.Drawing.Size(51, 24)
        Me.AddComputerButton.TabIndex = 42
        Me.AddComputerButton.Text = "Add"
        Me.AddComputerButton.UseVisualStyleBackColor = True
        '
        'ManageCategoriesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(608, 434)
        Me.Controls.Add(Me.tbCtrlType)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ManageCategoriesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Categories"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCtrlType.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PhoneCategoriesListBox As ListBox
    Friend WithEvents NewPhoneCategoryTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AddPhoneButton As Button
    Friend WithEvents PhoneCategoryTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EditSavePhoneCategoryButton As Button
    Friend WithEvents DeleteCancelPhoneCategoryButton As Button
    Friend WithEvents tbCtrlType As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents DeleteCancelComputerCategoryButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents EditSaveComputerCategoryButton As Button
    Friend WithEvents ComputerCategoriesListBox As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NewComputerCategoryTextBox As TextBox
    Friend WithEvents ComputerCategoryTextBox As TextBox
    Friend WithEvents AddComputerButton As Button
End Class
