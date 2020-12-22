Imports System.Data.OleDb

Public Class ReconciliationForm

    Dim itemNameDictionary As New Dictionary(Of Integer, String)
    Dim reserveDictionary As New Dictionary(Of Integer, String)

    Private Sub ReconciliationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)

        ClearForm()
        InitializeItems()
        LoadAllItems()
    End Sub

    Private Sub ReconciliationForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        QueueDataGridView.ClearSelection()
    End Sub

    Private Sub BookNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemNameComboBox.SelectedIndexChanged
        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)

        If comboBox.SelectedIndex > -1 Then
            Dim pair As KeyValuePair(Of Integer, String) = DirectCast(comboBox.SelectedItem, KeyValuePair(Of Integer, String))

            Dim inventoryID As Integer = pair.Key

            Dim qry As String = "SELECT * FROM [inventory] WHERE ID = " & inventoryID.ToString() & ";"

            Dim conn As New OleDbConnection(Singleton.ConnectionString)
            conn.Open()
            Dim cmd As New OleDbCommand(qry, conn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()

            While dr.Read()
                Dim device As String = dr(2).ToString()
                Dim category As String = dr(3).ToString()
                Dim registerDate As String = dr(6).ToString()
                Dim price As String = FormatCurrency(CDbl(dr(5).ToString()))

                DeviceTextBox.Text = device
                CategoryTextBox.Text = category
                RegisterDateTextBox.Text = registerDate
                PriceTextBox.Text = price
            End While

            conn.Close()
        Else
            DeviceTextBox.Clear()
            CategoryTextBox.Clear()
            RegisterDateTextBox.Clear()
            QuantityTextBox.Text = "0"
            PriceTextBox.Text = "0.00"
        End If
    End Sub

    Private Sub BookNameComboBox_TextChanged(sender As Object, e As EventArgs) Handles ItemNameComboBox.TextChanged
        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)

        If comboBox.Text = "" Then
            DeviceTextBox.Clear()
            CategoryTextBox.Clear()
            RegisterDateTextBox.Clear()
            QuantityTextBox.Text = "0"
            PriceTextBox.Text = "0.0"
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

    Private Sub AddToQueueButton_Click(sender As Object, e As EventArgs) Handles AddToQueueButton.Click
        If ValidateFields() Then
            Dim pair As KeyValuePair(Of Integer, String) = DirectCast(ItemNameComboBox.SelectedItem, KeyValuePair(Of Integer, String))

            Dim bookID As Integer = pair.Key
            Dim bookName As String = pair.Value
            Dim quantity As Integer = QuantityTextBox.Text
            Dim price As String = PriceTextBox.Text

            QueueDataGridView.Rows.Add(bookID, bookName, quantity, price)

            LoadAllItems()

            ItemNameComboBox.SelectedIndex = -1
            QuantityTextBox.Text = "0"
            PriceTextBox.Text = "0.00"
        End If
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        For Each row As DataGridViewRow In QueueDataGridView.SelectedRows
            QueueDataGridView.Rows.Remove(row)
        Next

        LoadAllItems()
    End Sub

    Private Sub RemoveButton_EnabledChanged(sender As Object, e As EventArgs) Handles RemoveButton.EnabledChanged
        Dim btn As Button = DirectCast(sender, Button)
        If Not btn.Enabled Then
            RemoveButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        Else
            RemoveButton.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub QueueDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles QueueDataGridView.SelectionChanged
        Dim dataGridView As DataGridView = DirectCast(sender, DataGridView)

        If dataGridView.SelectedRows.Count > 0 Then
            RemoveButton.Enabled = True
        Else
            RemoveButton.Enabled = False
        End If
    End Sub

    Private Sub SaveTransactionButton_Click(sender As Object, e As EventArgs) Handles SaveTransactionButton.Click
        If QueueDataGridView.Rows.Count > 0 Then
            Dim recordDate As String = DateTime.Now.ToString()

            For Each drow As DataGridViewRow In QueueDataGridView.Rows
                Dim inventoryID As Integer = drow.Cells(0).Value
                Dim quantity As Integer = drow.Cells(2).Value
                Dim price As String = drow.Cells(3).Value

                AddToStockCard(inventoryID, TransactionModeComboBox.Text, price, quantity, recordDate)
            Next

            For Each drow As DataGridViewRow In QueueDataGridView.Rows
                Dim inventoryID As Integer = drow.Cells(0).Value

                CorrectBalance(inventoryID)

                Dim updatedPriceAndQuantity As KeyValuePair(Of Double, Integer) = GetUpdatePriceAndQuantity(inventoryID)

                Dim price As String = FormatCurrency(updatedPriceAndQuantity.Key)
                Dim quantity As String = CStr(updatedPriceAndQuantity.Value)

                Dim conn As New OleDbConnection(Singleton.ConnectionString)
                conn.Open()
                Dim cmd As New OleDbCommand("UPDATE [inventory] SET [quantity] = " & quantity & ", [price] = '" & price & "' WHERE [ID] = " & inventoryID & ";", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            Next

            InventoryForm.LoadInventory(InventoryForm.cmbBxFilter.SelectedIndex)

            MessageBox.Show("Inventory has been updated.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Please add an item to the queue list.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Function ValidateFields() As Boolean
        If ItemNameComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Please select a book to add on list.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Convert.ToInt32(QuantityTextBox.Text) = 0 Then
            MessageBox.Show("Please enter a quantity.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Convert.ToDouble(PriceTextBox.Text) = 0.0 Then
            MessageBox.Show("Please enter a price.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub ClearForm()
        itemNameDictionary.Clear()
        reserveDictionary.Clear()

        TransactionModeComboBox.SelectedIndex = 0
        ItemNameComboBox.SelectedIndex = -1
        DeviceTextBox.Clear()
        CategoryTextBox.Clear()
        RegisterDateTextBox.Clear()
        QuantityTextBox.Text = "0"
        PriceTextBox.Text = "0.00"
        QueueDataGridView.Rows.Clear()
    End Sub

    Private Sub InitializeItems()
        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [inventory];", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            reserveDictionary.Add(dr(0).ToString(), dr(1).ToString())
        End While

        conn.Close()
    End Sub

    Private Sub LoadAllItems()
        ItemNameComboBox.DataSource = Nothing

        itemNameDictionary.Clear()

        Dim lst As New List(Of Integer)

        If QueueDataGridView.Rows.Count > 0 Then
            For Each pair As KeyValuePair(Of Integer, String) In reserveDictionary
                Dim itemID As Integer = pair.Key

                lst.Add(itemID)
            Next

            For Each dgvRow As DataGridViewRow In QueueDataGridView.Rows
                Dim itemID As Integer = CInt(dgvRow.Cells.Item(0).Value)

                lst.Add(itemID)
            Next

            FilterList(lst)

            For Each keys As Integer In lst
                For Each pair As KeyValuePair(Of Integer, String) In reserveDictionary
                    Dim itemID As Integer = pair.Key
                    Dim itemName As String = pair.Value

                    If keys = itemID Then
                        itemNameDictionary.Add(itemID, itemName)
                    End If
                Next
            Next
        Else
            For Each pair As KeyValuePair(Of Integer, String) In reserveDictionary
                Dim itemID As Integer = pair.Key
                Dim itemName As String = pair.Value

                itemNameDictionary.Add(itemID, itemName)
            Next
        End If

        If itemNameDictionary.Count > 0 Then
            ItemNameComboBox.DataSource = New BindingSource(itemNameDictionary, Nothing)
            ItemNameComboBox.DisplayMember = "Value"
            ItemNameComboBox.ValueMember = "Key"

            ItemNameComboBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub AddToStockCard(inventoryID As Integer, transactionType As String, priceRegistered As String, stockIn As Integer, recordDate As String)
        Dim qry As String = ""
        qry &= "INSERT INTO [stockcard] ([inventoryID], [transactionType], [priceRegistered], [stockIn], [stockOut], [balance], [recordDate]) "
        qry &= "VALUES (?, ?, ?, ?, ?, ?, ?);"

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(qry, conn)
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("inventoryID", inventoryID)
            .AddWithValue("transactionType", transactionType)
            .AddWithValue("priceRegistered", priceRegistered)
            .AddWithValue("stockIn", stockIn)
            .AddWithValue("stockOut", "0")
            .AddWithValue("balance", "0")
            .AddWithValue("recordDate", recordDate)
        End With
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub CorrectBalance(inventoryID As Integer)
        Dim totalBalance As Integer = 0

        Dim dt As New DataTable

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [stockcard] WHERE [inventoryID] = " & inventoryID & " ORDER BY [recordDate] ASC;", conn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Dim id As Integer = row.Item(0).ToString()
                Dim transactionType As String = row.Item(2).ToString()
                Dim stockIn As Integer = row.Item(4).ToString()
                Dim stockOut As Integer = row.Item(5).ToString()
                Dim balance As Integer = row.Item(6).ToString()

                If transactionType.Equals("Beginning Balance") Then
                    totalBalance = stockIn

                    Dim conn1 As New OleDbConnection(Singleton.ConnectionString)
                    conn1.Open()
                    Dim cmd1 As New OleDbCommand("UPDATE [stockcard] SET [balance] = " & totalBalance & " WHERE [ID] = " & id & ";", conn1)
                    cmd1.ExecuteNonQuery()
                    conn1.Close()
                ElseIf transactionType.Equals("Purchases") Then
                    totalBalance += stockIn

                    Dim conn1 As New OleDbConnection(Singleton.ConnectionString)
                    conn1.Open()
                    Dim cmd1 As New OleDbCommand("UPDATE [stockcard] SET [balance] = " & totalBalance & " WHERE [ID] = " & id & ";", conn1)
                    cmd1.ExecuteNonQuery()
                    conn1.Close()
                ElseIf transactionType.Equals("Sales") Then
                    totalBalance -= stockOut

                    Dim conn1 As New OleDbConnection(Singleton.ConnectionString)
                    conn1.Open()
                    Dim cmd1 As New OleDbCommand("UPDATE [stockcard] SET [balance] = " & totalBalance & " WHERE [ID] = " & id & ";", conn1)
                    cmd1.ExecuteNonQuery()
                    conn1.Close()
                End If
            Next
        End If

        conn.Close()
    End Sub

    Private Function GetUpdatePriceAndQuantity(inventoryID As Integer) As KeyValuePair(Of Double, Integer)
        Dim pair As KeyValuePair(Of Double, Integer) = Nothing

        Dim dt As New DataTable

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [stockcard] WHERE [inventoryID] = " & inventoryID & " ORDER BY [recordDate] DESC;", conn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()

        If dt.Rows.Count > 0 Then
            Dim price As Double = CDbl(dt.Rows(0).Item(3))
            Dim quantity As Integer = CInt(dt.Rows(0).Item(6))

            pair = New KeyValuePair(Of Double, Integer)(price, quantity)
        End If

        Return pair
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

    Private Sub FilterList(lst As List(Of Integer))
        Dim toDeleteList As New List(Of Integer)

        For i = 0 To lst.Count - 1
            For j = 0 To lst.Count - 1
                If Not i = j Then
                    If lst(i) = lst(j) Then
                        If Not toDeleteList.Contains(lst(j)) Then
                            toDeleteList.Add(lst(j))
                        End If

                        Exit For
                    End If
                End If
            Next
        Next

        For repeat = 1 To 2
            For Each val As Integer In toDeleteList
                lst.RemoveAt(lst.IndexOf(val))
            Next
        Next
    End Sub

End Class