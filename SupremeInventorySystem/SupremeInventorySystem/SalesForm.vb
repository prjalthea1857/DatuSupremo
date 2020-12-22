Imports System.Data.OleDb

Public Class SalesForm

    Dim _isLogout As Boolean = False

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)

        TransactionDateTextBox.Text = DateTime.Now.ToString()

        ClearForm()
        LoadAllItems()
        InitNewTransactionNumber()
    End Sub

    Private Sub SalesForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not _isLogout Then
            Application.Exit()
        End If
    End Sub

    Private Sub ItemNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemNameComboBox.SelectedIndexChanged
        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)

        If comboBox.SelectedIndex > -1 Then
            Dim pair As KeyValuePair(Of Integer, String) = DirectCast(comboBox.SelectedItem, KeyValuePair(Of Integer, String))

            Dim inventoryID As Integer = pair.Key

            Dim qry As String = "SELECT * FROM [inventory] WHERE [ID] = " & inventoryID.ToString() & ";"

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

            QuantityTextBox.Focus()
        Else
            DeviceTextBox.Clear()
            CategoryTextBox.Clear()
            RegisterDateTextBox.Clear()
            QuantityTextBox.Text = "0"
            PriceTextBox.Text = "0.0"
        End If
    End Sub

    Private Sub BookNameComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ItemNameComboBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            QuantityTextBox.Focus()
        ElseIf e.KeyCode = Keys.F2 Then
            CashTenderedTextBox.Focus()
        ElseIf e.KeyCode = Keys.F8 Then
            StockListButton.PerformClick()
        End If
    End Sub

    Private Sub QuantityTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles QuantityTextBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            AddItemButton.PerformClick()
        ElseIf e.KeyCode = Keys.F8 Then
            StockListButton.PerformClick()
        End If
    End Sub

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        If ValidateFields() Then
            Dim pair As KeyValuePair(Of Integer, String) = DirectCast(ItemNameComboBox.SelectedItem, KeyValuePair(Of Integer, String))

            Dim bookID As Integer = pair.Key
            Dim bookName As String = pair.Value
            Dim quantity As Integer = QuantityTextBox.Text
            Dim price As String = PriceTextBox.Text
            Dim subtotal As String = FormatCurrency(price * quantity)

            If Not IsOnQueueList(bookID) Then
                QueueDataGridView.Rows.Add(bookID, bookName, quantity, price, subtotal)
            Else
                For Each dgvRow As DataGridViewRow In QueueDataGridView.Rows
                    If CInt(dgvRow.Cells(0).Value) = bookID Then
                        If (StockQuantityLimit(bookID) - CInt(dgvRow.Cells(2).Value)) > quantity Then
                            dgvRow.Cells(2).Value = CInt(dgvRow.Cells(2).Value) + quantity
                            dgvRow.Cells(4).Value = FormatCurrency(CDbl(dgvRow.Cells(3).Value) * CInt(dgvRow.Cells(2).Value))
                        Else
                            dgvRow.Cells(2).Value = StockQuantityLimit(bookID)
                            dgvRow.Cells(4).Value = FormatCurrency(CDbl(dgvRow.Cells(3).Value) * CInt(dgvRow.Cells(2).Value))
                        End If
                    End If
                Next
            End If

            ItemNameComboBox.SelectedIndex = -1
            QuantityTextBox.Text = "0"
            PriceTextBox.Text = "0.00"

            ItemNameComboBox.Focus()

            QueueDataGridView.ClearSelection()

            GetTotalPrice()
        End If
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        For Each row As DataGridViewRow In QueueDataGridView.SelectedRows
            QueueDataGridView.Rows.Remove(row)
        Next

        GetTotalPrice()
    End Sub

    Private Sub RemoveButton_EnabledChanged(sender As Object, e As EventArgs) Handles RemoveButton.EnabledChanged
        Dim btn As Button = DirectCast(sender, Button)
        If Not btn.Enabled Then
            RemoveButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        Else
            RemoveButton.FlatAppearance.BorderColor = Color.FromArgb(92, 184, 183)
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

    Private Sub CashTenderedTextBox_TextChanged(sender As Object, e As EventArgs) Handles CashTenderedTextBox.TextChanged
        If CashTenderedTextBox.Text <> "" And TotalTextBox.Text <> "" Then
            Dim change As Double = CashTenderedTextBox.Text - TotalTextBox.Text

            If change > 0 Then
                ChangeTextBox.Text = FormatCurrency(change)
            Else
                ChangeTextBox.Text = FormatCurrency(0.0)
            End If
        End If
    End Sub

    Private Sub CashTenderedTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CashTenderedTextBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F10 Then
            SaveTransactionsButton.PerformClick()
        ElseIf e.KeyCode = Keys.F8 Then
            StockListButton.PerformClick()
        End If
    End Sub

    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
        CashTenderedTextBox.Focus()
    End Sub

    Private Sub StockListButton_Click(sender As Object, e As EventArgs) Handles StockListButton.Click
        StockListForm.ShowDialog()
    End Sub

    Private Sub SaveTransactionsButton_Click(sender As Object, e As EventArgs) Handles SaveTransactionsButton.Click
        If QueueDataGridView.Rows.Count = 0 Then
            MessageBox.Show("Please add an item to the queue list.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If (CDbl(CashTenderedTextBox.Text) - CDbl(TotalTextBox.Text)) < 0 Then
            MessageBox.Show("Please enter valid cash value.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim recordDate As String = DateTime.Now.ToString()

        Dim qry As String = ""
        qry &= "INSERT INTO [transactions] ([transactionNumber], [total], [cashtendered], [change], [recordDate]) "
        qry &= "VALUES ('" & TransactionNumberLabel.Text & "', '" & TotalTextBox.Text.Replace(",", "") & "', '" & CashTenderedTextBox.Text.Replace(",", "") & "', '" & ChangeTextBox.Text.Replace(",", "") & "', '" & recordDate & "');"

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(qry, conn)
        cmd.ExecuteNonQuery()
        conn.Close()

        Dim transactionID As Integer = GetLatestTransactionID()

        For Each dgvRow As DataGridViewRow In QueueDataGridView.Rows
            Dim bookID As Integer = dgvRow.Cells(0).Value
            Dim quantity As Integer = dgvRow.Cells(2).Value
            Dim price As String = dgvRow.Cells(3).Value
            Dim subtotal As String = dgvRow.Cells(4).Value

            qry = ""
            qry &= "INSERT INTO [transactionlist] ([transactionID], [stockID], [quantity], [price], [subtotal]) "
            qry &= "VALUES (" & transactionID & ", " & bookID & ", '" & quantity & "', '" & price & "', '" & subtotal & "');"

            conn = New OleDbConnection(Singleton.ConnectionString)
            conn.Open()
            cmd = New OleDbCommand(qry, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Next

        For Each dgvRow As DataGridViewRow In QueueDataGridView.Rows
            Dim bookID As Integer = dgvRow.Cells(0).Value
            Dim quantity As Integer = dgvRow.Cells(2).Value
            Dim price As String = dgvRow.Cells(3).Value
            Dim subtotal As String = dgvRow.Cells(4).Value

            AddToStockCard(bookID, "Sales", price, quantity, recordDate)
        Next

        For Each drow As DataGridViewRow In QueueDataGridView.Rows
            Dim inventoryID As Integer = drow.Cells(0).Value

            CorrectBalance(inventoryID)

            Dim updatedPriceAndQuantity As KeyValuePair(Of Double, Integer) = GetUpdatePriceAndQuantity(inventoryID)

            Dim price As String = FormatCurrency(updatedPriceAndQuantity.Key)
            Dim quantity As String = CStr(updatedPriceAndQuantity.Value)

            conn = New OleDbConnection(Singleton.ConnectionString)
            conn.Open()
            cmd = New OleDbCommand("UPDATE [inventory] SET [quantity] = " & quantity & ", [price] = '" & price & "' WHERE [ID] = " & inventoryID & ";", conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Next

        MessageBox.Show("Transaction has been completed.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ClearForm()

        InitNewTransactionNumber()
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim result = MessageBox.Show("Are you sure that you want to logout?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            _isLogout = True

            For Each form As Form In Application.OpenForms
                If form.Name.Equals("LoginForm") Then
                    form.Show()
                    Exit For
                End If
            Next

            Me.Close()
        End If
    End Sub

    Private Sub ClearForm()
        ItemNameComboBox.SelectedIndex = -1
        DeviceTextBox.Clear()
        CategoryTextBox.Clear()
        RegisterDateTextBox.Clear()
        CashTenderedTextBox.Text = "0.00"
        TotalTextBox.Text = "0.00"
        ChangeTextBox.Text = "0.00"
        QueueDataGridView.Rows.Clear()
    End Sub

    Private Sub LoadAllItems()
        ItemNameComboBox.DataSource = Nothing

        Dim bookNameDictionary As New Dictionary(Of Integer, String)

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [inventory];", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            bookNameDictionary.Add(dr(0).ToString(), dr(1).ToString())
        End While

        conn.Close()

        If bookNameDictionary.Count > 0 Then
            ItemNameComboBox.DataSource = New BindingSource(bookNameDictionary, Nothing)
            ItemNameComboBox.DisplayMember = "Value"
            ItemNameComboBox.ValueMember = "Key"

            ItemNameComboBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub GetTotalPrice()
        Dim totalprice As Double = 0.0

        If QueueDataGridView.Rows.Count > 0 Then
            For Each dgvRow As DataGridViewRow In QueueDataGridView.Rows
                Dim price As Double = CDbl(dgvRow.Cells(4).Value)
                totalprice += price
            Next

            TotalTextBox.Text = FormatCurrency(totalprice)
        Else
            TotalTextBox.Text = FormatCurrency(0.0)
        End If
    End Sub

    Private Sub AddToStockCard(inventoryID As Integer, transactionType As String, priceRegistered As String, stockOut As Integer, recordDate As String)
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
            .AddWithValue("stockIn", "0")
            .AddWithValue("stockOut", stockOut)
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

    Private Sub InitNewTransactionNumber()
        Dim newID As Integer = 0

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [transactions] ORDER BY [ID] DESC;", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            newID = CInt(dr(0).ToString()) + 1
        End If

        conn.Close()

        If newID = 0 Then
            newID = 1
        End If

        TransactionNumberLabel.Text = newID.ToString("D8")
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

    Private Function ValidateFields() As Boolean
        If ItemNameComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Please select a book to add on list.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim pair As KeyValuePair(Of Integer, String) = DirectCast(ItemNameComboBox.SelectedItem, KeyValuePair(Of Integer, String))
        Dim bookID As Integer = pair.Key

        If Convert.ToInt32(QuantityTextBox.Text) = 0 Then
            MessageBox.Show("Please enter a quantity.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim limit As Integer = StockQuantityLimit(bookID)

        If limit = 0 Then
            MessageBox.Show("This item is out of stock.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            If Convert.ToInt32(QuantityTextBox.Text) > limit Then
                QuantityTextBox.Text = limit
            End If
        End If

        If Convert.ToDouble(PriceTextBox.Text) = 0.0 Then
            MessageBox.Show("Price must be included in the book.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function GetLatestTransactionID() As Integer
        Dim latestID As Integer = 0

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [transactions] ORDER BY [ID] DESC;", conn)
        latestID = CInt(cmd.ExecuteScalar())
        conn.Close()

        Return latestID
    End Function

    Private Function IsOnQueueList(bookId As Integer) As Boolean
        Dim onQueue As Boolean = False

        If QueueDataGridView.Rows.Count > 0 Then
            For Each dgvRow As DataGridViewRow In QueueDataGridView.Rows
                If CInt(dgvRow.Cells(0).Value) = bookId Then
                    onQueue = True
                End If
            Next
        End If

        Return onQueue
    End Function

    Private Function StockQuantityLimit(bookId As Integer) As Integer
        Dim currentQuantity As Integer = 0

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [inventory] WHERE [ID] = " & bookId & ";", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            currentQuantity = dr(4).ToString()
        End While

        conn.Close()

        Return currentQuantity
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

    Private Function CheckBookExists(bookName As String, category As String) As Boolean
        Dim isExists As Boolean = False

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [inventory];", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            Dim checkBookName As String = dr(1).ToString()
            Dim checkCategory As String = dr(2).ToString()

            If checkBookName.ToLower().Equals(bookName.ToLower()) And checkCategory.ToLower().Equals(category.ToLower()) Then
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