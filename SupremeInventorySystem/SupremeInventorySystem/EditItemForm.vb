Imports System.Data.OleDb

Public Class EditItemForm

    Public inventoryID As Integer = 0

    Dim tmpBookName As String = ""

    Private Sub EditItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloseButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)

        RegisterDateDateTimePicker.Value = DateTime.Now

        ClearForm()
        LoadBookInfo()

        If Singleton.Privilege.Equals("Administrator") Then
            QuantityTextBox.ReadOnly = False
            PriceTextBox.ReadOnly = False
        ElseIf Singleton.Privilege.Equals("Sales Clerk") Then
            QuantityTextBox.ReadOnly = True
            PriceTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub DeviceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeviceComboBox.SelectedIndexChanged
        If CategoryComboBox.Enabled = False Then
            CategoryComboBox.Enabled = True
        End If

        Dim cmbBx As ComboBox = DirectCast(sender, ComboBox)

        Dim categoryList As New List(Of String)

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [equipments] WHERE [device] = '" & cmbBx.Text & "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            categoryList.Add(dr(2).ToString())
        End While

        conn.Close()

        CategoryComboBox.Items.Clear()
        For Each cat As String In categoryList
            CategoryComboBox.Items.Add(cat)
        Next
        If CategoryComboBox.Items.Count > 0 Then
            CategoryComboBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub QuantityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuantityTextBox.KeyPress
        If IsCharSymbolAndFilterDot(e.KeyChar, QuantityTextBox.Text) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PriceTextBox.KeyPress
        If IsCharSymbolAndFilterDot(e.KeyChar, PriceTextBox.Text) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PriceTextBox_Leave(sender As Object, e As EventArgs) Handles PriceTextBox.Leave
        If PriceTextBox.Text <> "" Then
            PriceTextBox.Text = FormatCurrency(PriceTextBox.Text)
        End If
    End Sub

    Private Sub UpdateItemButton_Click(sender As Object, e As EventArgs) Handles UpdateItemButton.Click
        If ValidateFields() Then
            Dim itemName As String = ItemNameTextBox.Text
            Dim device As String = DeviceComboBox.Text
            Dim category As String = CategoryComboBox.Text
            Dim quantity As String = QuantityTextBox.Text
            Dim price As String = PriceTextBox.Text
            Dim registerDate As String = RegisterDateDateTimePicker.Value.Date.ToShortDateString()

            If Not tmpBookName = itemName Then
                If Not CheckItemExists(itemName, device, category) Then
                    Dim qry As String = ""
                    qry &= "UPDATE [inventory] SET "
                    qry &= "[itemname] = ?, "
                    qry &= "[device] = ?, "
                    qry &= "[category] = ?, "
                    qry &= "[registerDate] = ?, "
                    qry &= "[quantity] = ?, "
                    qry &= "[price] = ? "
                    qry &= "WHERE [ID] = ?;"

                    Dim conn As New OleDbConnection(Singleton.ConnectionString)
                    conn.Open()
                    Dim cmd As New OleDbCommand(qry, conn)
                    cmd.CommandType = CommandType.Text
                    With cmd.Parameters
                        .AddWithValue("itemname", itemName)
                        .AddWithValue("device", device)
                        .AddWithValue("category", category)
                        .AddWithValue("registerDate", registerDate)
                        .AddWithValue("quantity", quantity)
                        .AddWithValue("price", price)
                        .AddWithValue("ID", inventoryID)
                    End With
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    InventoryForm.LoadInventory(InventoryForm.cmbBxFilter.SelectedIndex)

                    MessageBox.Show("Item has been updated to the system.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("This item is already exists in the system.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                Dim qry As String = ""
                qry &= "UPDATE [inventory] SET "
                qry &= "[itemname] = ?, "
                qry &= "[device] = ?, "
                qry &= "[category] = ?, "
                qry &= "[registerDate] = ?, "
                qry &= "[quantity] = ?, "
                qry &= "[price] = ? "
                qry &= "WHERE [ID] = ?;"

                Dim conn As New OleDbConnection(Singleton.ConnectionString)
                conn.Open()
                Dim cmd As New OleDbCommand(qry, conn)
                cmd.CommandType = CommandType.Text
                With cmd.Parameters
                    .AddWithValue("itemname", itemName)
                    .AddWithValue("device", device)
                    .AddWithValue("category", category)
                    .AddWithValue("registerDate", registerDate)
                    .AddWithValue("quantity", quantity)
                    .AddWithValue("price", price)
                    .AddWithValue("ID", inventoryID)
                End With
                cmd.ExecuteNonQuery()
                conn.Close()

                InventoryForm.LoadInventory(InventoryForm.cmbBxFilter.SelectedIndex)

                MessageBox.Show("Item has been updated to the system.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ClearForm()
        ItemNameTextBox.Text = ""
        RegisterDateDateTimePicker.Value = DateTime.Now
        QuantityTextBox.Text = "0"
        PriceTextBox.Text = "0.00"
    End Sub

    Private Sub LoadBookInfo()
        Dim qry As String = "SELECT * FROM [inventory] WHERE ID = " & inventoryID.ToString() & ";"

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(qry, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            ItemNameTextBox.Text = dr(1).ToString()
            DeviceComboBox.Text = dr(2).ToString()
            CategoryComboBox.Text = dr(3).ToString()
            QuantityTextBox.Text = dr(4).ToString()
            PriceTextBox.Text = dr(5).ToString()
            RegisterDateDateTimePicker.Value = DateTime.Parse(dr(6).ToString())

            tmpBookName = dr(1).ToString()
        End While

        conn.Close()
    End Sub

    Private Sub LoadCategories()
        DeviceComboBox.DataSource = Nothing

        Dim categoryDictionary As New Dictionary(Of Integer, String)

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM categories;", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            categoryDictionary.Add(dr(0).ToString(), dr(1).ToString())
        End While

        conn.Close()

        If categoryDictionary.Count > 0 Then
            DeviceComboBox.DataSource = New BindingSource(categoryDictionary, Nothing)
            DeviceComboBox.DisplayMember = "Value"
            DeviceComboBox.ValueMember = "Key"

            DeviceComboBox.SelectedIndex = -1
        End If
    End Sub

    Private Function ValidateFields() As Boolean
        If ItemNameTextBox.Text = "" Then
            MessageBox.Show("Please enter a book name.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If DeviceComboBox.SelectedIndex < 0 Then
            MessageBox.Show("Please select a device.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If CategoryComboBox.SelectedIndex < 0 Then
            MessageBox.Show("Please enter a category.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function FormatCurrency(value As Double) As String
        Return FormatNumberComma(String.Format("{0:0.00}", value))
    End Function

    Private Function FormatNumberComma(value As String) As String
        Dim counter As Integer = 0

        Dim constructedNumber As String = ""

        Dim arrVal() As String = value.Split(".")

        Dim endDecimal As String = "." & arrVal(1)

        Dim i As Integer = arrVal(0).Length - 1
        While i + 1 > 0
            constructedNumber = arrVal(0)(i) + constructedNumber
            counter += 1

            If counter = 3 AndAlso i <> 0 Then
                constructedNumber = "," & constructedNumber
                counter = 0
            End If

            i -= 1
        End While

        Return constructedNumber & endDecimal
    End Function

    Private Function CheckItemExists(bookName As String, device As String, category As String) As Boolean
        Dim isExists As Boolean = False

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [inventory];", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            Dim checkBookName As String = dr(1).ToString()
            Dim checkDevice As String = dr(2).ToString()
            Dim checkCategory As String = dr(3).ToString()

            If checkBookName.ToLower().Equals(bookName.ToLower()) And checkDevice.ToLower().Equals(device.ToLower()) And checkCategory.ToLower().Equals(category.ToLower()) Then
                isExists = True
                Exit While
            End If
        End While

        conn.Close()

        Return isExists
    End Function

    Private Function IsCharSymbolAndFilterDot(keyChar As Char, value As String) As Boolean
        If keyChar.ToString().Equals(".") Then
            Return (Not DotCount(value) = 0)
        End If

        Return Char.IsLetter(keyChar) Or Char.IsSymbol(keyChar) Or Char.IsPunctuation(keyChar) And Not Char.IsControl(keyChar)
    End Function

    Private Function DotCount(value As String) As Integer
        Dim count As Integer = 0

        For Each c As Char In value
            If c.ToString().Equals(".") Then
                count += 1
            End If
        Next

        Return count
    End Function

End Class