Imports System.Data.OleDb

Public Class ManageCategoriesForm

    Dim selectedCategory As KeyValuePair(Of Integer, String) = Nothing

    Dim _isListBoxInit As Boolean = False
    Dim _selectIndex As Integer = -1

    Private Sub ManageCategoriesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EditSavePhoneCategoryButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        DeleteCancelPhoneCategoryButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)

        EditSaveComputerCategoryButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        DeleteCancelComputerCategoryButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)

        EditSavePhoneCategoryButton.Enabled = False
        DeleteCancelPhoneCategoryButton.Enabled = False

        EditSaveComputerCategoryButton.Enabled = False
        DeleteCancelComputerCategoryButton.Enabled = False

        ClearForm()
        ShowAllPhoneCategories()
        ShowAllComputerCategories()

        _isListBoxInit = True
    End Sub

#Region "Tab1_Phone"

    Private Sub AddPhoneButton_Click(sender As Object, e As EventArgs) Handles AddPhoneButton.Click
        If NewPhoneCategoryTextBox.Text <> "" Then
            Dim newCategory As String = NewPhoneCategoryTextBox.Text

            Dim conn As New OleDbConnection(Singleton.ConnectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO [categories] ([device], [category]) VALUES ('" & tbCtrlType.SelectedTab.Text & "', '" & newCategory & "');", conn)
            cmd.ExecuteNonQuery()
            conn.Close()

            ShowAllPhoneCategories()

            NewPhoneCategoryTextBox.Clear()
            PhoneCategoriesListBox.SelectedIndex = -1
            PhoneCategoryTextBox.Clear()

            MessageBox.Show("Category has been added to the system.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please enter a category.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub PhoneCategoriesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PhoneCategoriesListBox.SelectedIndexChanged
        If _isListBoxInit Then
            Dim listBox As ListBox = DirectCast(sender, ListBox)

            If listBox.SelectedItems.Count > 0 Then
                If listBox.SelectedIndex > -1 Then
                    selectedCategory = DirectCast(listBox.SelectedItem, KeyValuePair(Of Integer, String))

                    PhoneCategoryTextBox.Text = selectedCategory.Value
                    EditSavePhoneCategoryButton.Enabled = True
                    DeleteCancelPhoneCategoryButton.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub EditSavePhoneCategoryButton_EnabledChanged(sender As Object, e As EventArgs) Handles EditSavePhoneCategoryButton.EnabledChanged
        Dim btn As Button = DirectCast(sender, Button)
        If Not btn.Enabled Then
            EditSavePhoneCategoryButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        Else
            EditSavePhoneCategoryButton.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub DeleteCancelPhoneCategoryButton_EnabledChanged(sender As Object, e As EventArgs) Handles DeleteCancelPhoneCategoryButton.EnabledChanged
        Dim btn As Button = DirectCast(sender, Button)
        If Not btn.Enabled Then
            DeleteCancelPhoneCategoryButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        Else
            DeleteCancelPhoneCategoryButton.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub EditSavePhoneCategoryButton_Click(sender As Object, e As EventArgs) Handles EditSavePhoneCategoryButton.Click
        Dim editSaveButton As Button = DirectCast(sender, Button)

        If editSaveButton.Text = "Edit" Then
            PhoneCategoryTextBox.ReadOnly = False

            EditSavePhoneCategoryButton.Text = "Save"
            DeleteCancelPhoneCategoryButton.Text = "Cancel"

            _selectIndex = PhoneCategoriesListBox.SelectedIndex
        ElseIf editSaveButton.Text = "Save" Then
            Dim categoryID As Integer = selectedCategory.Key
            Dim newCategory As String = PhoneCategoryTextBox.Text

            Dim conn As New OleDbConnection(Singleton.ConnectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("UPDATE [categories] SET category = '" & newCategory & "' WHERE ID = " & categoryID.ToString() & ";", conn)
            cmd.ExecuteNonQuery()
            conn.Close()

            ShowAllPhoneCategories()

            InventoryForm.LoadInventory(InventoryForm.cmbBxFilter.SelectedIndex)

            PhoneCategoriesListBox.SelectedIndex = _selectIndex

            _selectIndex = -1

            MessageBox.Show("Category has been edited.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            PhoneCategoryTextBox.ReadOnly = True

            EditSavePhoneCategoryButton.Text = "Edit"
            DeleteCancelPhoneCategoryButton.Text = "Delete"
        End If
    End Sub

    Private Sub DeleteCancelPhoneCategoryButton_Click(sender As Object, e As EventArgs) Handles DeleteCancelPhoneCategoryButton.Click
        Dim deleteCancelButton As Button = DirectCast(sender, Button)

        If deleteCancelButton.Text = "Delete" Then
            Dim categoryID As Integer = selectedCategory.Key

            If Not IsCategoryOnUse(categoryID) Then
                Dim result = MessageBox.Show("Are you sure that you want to delete this category?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Dim conn As New OleDbConnection(Singleton.ConnectionString)
                    conn.Open()
                    Dim cmd As New OleDbCommand("DELETE FROM [categories] WHERE [ID] = " & categoryID.ToString() & ";", conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    ShowAllPhoneCategories()

                    PhoneCategoryTextBox.Clear()
                    PhoneCategoriesListBox.SelectedIndex = -1

                    EditSavePhoneCategoryButton.Enabled = False
                    DeleteCancelPhoneCategoryButton.Enabled = False

                    MessageBox.Show("Category has been deleted.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Unable to delete due to category in used in inventory.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf deleteCancelButton.Text = "Cancel" Then
            PhoneCategoryTextBox.ReadOnly = True

            EditSavePhoneCategoryButton.Text = "Edit"
            DeleteCancelPhoneCategoryButton.Text = "Delete"

            PhoneCategoryTextBox.Text = selectedCategory.Value
        End If
    End Sub

#End Region

#Region "Tab2_Computer"

    Private Sub AddComputerButton_Click(sender As Object, e As EventArgs) Handles AddComputerButton.Click
        If NewComputerCategoryTextBox.Text <> "" Then
            Dim newCategory As String = NewComputerCategoryTextBox.Text

            Dim conn As New OleDbConnection(Singleton.ConnectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO [categories] ([device], [category]) VALUES ('" & tbCtrlType.SelectedTab.Text & "', '" & newCategory & "');", conn)
            cmd.ExecuteNonQuery()
            conn.Close()

            ShowAllComputerCategories()

            NewComputerCategoryTextBox.Clear()
            ComputerCategoriesListBox.SelectedIndex = -1
            ComputerCategoryTextBox.Clear()

            MessageBox.Show("Category has been added to the system.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please enter a category.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ComputerCategoriesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComputerCategoriesListBox.SelectedIndexChanged
        If _isListBoxInit Then
            Dim listBox As ListBox = DirectCast(sender, ListBox)

            If listBox.SelectedItems.Count > 0 Then
                If listBox.SelectedIndex > -1 Then
                    selectedCategory = DirectCast(listBox.SelectedItem, KeyValuePair(Of Integer, String))

                    ComputerCategoryTextBox.Text = selectedCategory.Value
                    EditSaveComputerCategoryButton.Enabled = True
                    DeleteCancelComputerCategoryButton.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub EditSaveComputerCategoryButton_EnabledChanged(sender As Object, e As EventArgs) Handles EditSaveComputerCategoryButton.EnabledChanged
        Dim btn As Button = DirectCast(sender, Button)
        If Not btn.Enabled Then
            EditSaveComputerCategoryButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        Else
            EditSaveComputerCategoryButton.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub DeleteCancelComputerCategoryButton_EnabledChanged(sender As Object, e As EventArgs) Handles DeleteCancelComputerCategoryButton.EnabledChanged
        Dim btn As Button = DirectCast(sender, Button)
        If Not btn.Enabled Then
            DeleteCancelComputerCategoryButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        Else
            DeleteCancelComputerCategoryButton.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub EditSaveComputerCategoryButton_Click(sender As Object, e As EventArgs) Handles EditSaveComputerCategoryButton.Click
        Dim editSaveButton As Button = DirectCast(sender, Button)

        If editSaveButton.Text = "Edit" Then
            ComputerCategoryTextBox.ReadOnly = False

            EditSaveComputerCategoryButton.Text = "Save"
            DeleteCancelComputerCategoryButton.Text = "Cancel"

            _selectIndex = ComputerCategoriesListBox.SelectedIndex
        ElseIf editSaveButton.Text = "Save" Then
            Dim categoryID As Integer = selectedCategory.Key
            Dim newCategory As String = ComputerCategoryTextBox.Text

            Dim conn As New OleDbConnection(Singleton.ConnectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("UPDATE [categories] SET category = '" & newCategory & "' WHERE ID = " & categoryID.ToString() & ";", conn)
            cmd.ExecuteNonQuery()
            conn.Close()

            ShowAllComputerCategories()

            InventoryForm.LoadInventory(InventoryForm.cmbBxFilter.SelectedIndex)

            ComputerCategoriesListBox.SelectedIndex = _selectIndex

            _selectIndex = -1

            MessageBox.Show("Category has been edited.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ComputerCategoryTextBox.ReadOnly = True

            EditSaveComputerCategoryButton.Text = "Edit"
            DeleteCancelComputerCategoryButton.Text = "Delete"
        End If
    End Sub

    Private Sub DeleteCancelComputerCategoryButton_Click(sender As Object, e As EventArgs) Handles DeleteCancelComputerCategoryButton.Click
        Dim deleteCancelButton As Button = DirectCast(sender, Button)

        If deleteCancelButton.Text = "Delete" Then
            Dim categoryID As Integer = selectedCategory.Key

            If Not IsCategoryOnUse(categoryID) Then
                Dim result = MessageBox.Show("Are you sure that you want to delete this category?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Dim conn As New OleDbConnection(Singleton.ConnectionString)
                    conn.Open()
                    Dim cmd As New OleDbCommand("DELETE FROM [categories] WHERE [ID] = " & categoryID.ToString() & ";", conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    ShowAllComputerCategories()

                    ComputerCategoryTextBox.Clear()
                    ComputerCategoriesListBox.SelectedIndex = -1

                    EditSaveComputerCategoryButton.Enabled = False
                    DeleteCancelComputerCategoryButton.Enabled = False

                    MessageBox.Show("Category has been deleted.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Unable to delete due to category in used in inventory.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf deleteCancelButton.Text = "Cancel" Then
            ComputerCategoryTextBox.ReadOnly = True

            EditSaveComputerCategoryButton.Text = "Edit"
            DeleteCancelComputerCategoryButton.Text = "Delete"

            ComputerCategoryTextBox.Text = selectedCategory.Value
        End If
    End Sub

#End Region

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ClearForm()
        NewPhoneCategoryTextBox.Clear()
        PhoneCategoryTextBox.Clear()
        NewComputerCategoryTextBox.Clear()
        ComputerCategoryTextBox.Clear()
    End Sub

    Private Sub ShowAllPhoneCategories()
        PhoneCategoriesListBox.DataSource = Nothing

        Dim categoryDictionary As New Dictionary(Of Integer, String)

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [equipments] WHERE [device] = 'Phone';", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            categoryDictionary.Add(dr(0).ToString(), dr(2).ToString())
        End While

        conn.Close()

        If categoryDictionary.Count > 0 Then
            PhoneCategoriesListBox.DataSource = New BindingSource(categoryDictionary, Nothing)
            PhoneCategoriesListBox.DisplayMember = "Value"
            PhoneCategoriesListBox.ValueMember = "Key"

            PhoneCategoriesListBox.ClearSelected()
            PhoneCategoriesListBox.SelectedIndex = -1

            PhoneCategoryTextBox.Clear()
            EditSavePhoneCategoryButton.Enabled = False
            DeleteCancelPhoneCategoryButton.Enabled = False
        End If
    End Sub

    Private Sub ShowAllComputerCategories()
        ComputerCategoriesListBox.DataSource = Nothing

        Dim categoryDictionary As New Dictionary(Of Integer, String)

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [equipments] WHERE [device] = 'Computer';", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            categoryDictionary.Add(dr(0).ToString(), dr(2).ToString())
        End While

        conn.Close()

        If categoryDictionary.Count > 0 Then
            ComputerCategoriesListBox.DataSource = New BindingSource(categoryDictionary, Nothing)
            ComputerCategoriesListBox.DisplayMember = "Value"
            ComputerCategoriesListBox.ValueMember = "Key"

            ComputerCategoriesListBox.ClearSelected()
            ComputerCategoriesListBox.SelectedIndex = -1

            ComputerCategoryTextBox.Clear()
            EditSaveComputerCategoryButton.Enabled = False
            DeleteCancelComputerCategoryButton.Enabled = False
        End If
    End Sub

    Private Function IsCategoryOnUse(categoryID As Integer) As Boolean
        Dim count As Integer = 0

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [inventory] WHERE [category] = " & categoryID.ToString() & ";", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            count += 1
        End While

        conn.Close()

        If count > 0 Then
            Return True
        End If

        Return False
    End Function

End Class