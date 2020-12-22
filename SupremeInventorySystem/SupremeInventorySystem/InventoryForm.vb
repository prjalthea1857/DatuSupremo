Imports System.Data.OleDb

Public Class InventoryForm

    Public Shared temp_dgvItems As New List(Of String())

    Public Shared sharedbooksDataGridView As DataGridView

    Dim _isDataGridViewInit As Boolean = False

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EditBookButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        DeleteBookButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        StockCardButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)

        sharedbooksDataGridView = BooksDataGridView

        cmbBxFilter.SelectedIndex = 0

        LoadInventory(cmbBxFilter.SelectedIndex)

        _isDataGridViewInit = True
    End Sub

    Private Sub InventoryForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        BooksDataGridView.ClearSelection()
    End Sub

    Private Sub AddBookButton_Click(sender As Object, e As EventArgs) Handles AddBookButton.Click
        If HasCategories() Then
            AddItemForm.ShowDialog()
        Else
            MessageBox.Show("Please add a category first to add a book.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub EditBookButton_Click(sender As Object, e As EventArgs) Handles EditBookButton.Click
        Dim inventoryID As Integer = BooksDataGridView.SelectedRows.Item(0).Cells().Item(0).Value

        Dim editBookForm As New EditItemForm
        editBookForm.inventoryID = inventoryID
        editBookForm.ShowDialog()

        BooksDataGridView.ClearSelection()
    End Sub

    Private Sub EditBookButton_EnabledChanged(sender As Object, e As EventArgs) Handles EditBookButton.EnabledChanged
        Dim btn As Button = DirectCast(sender, Button)
        If Not btn.Enabled Then
            EditBookButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        Else
            EditBookButton.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub DeleteBookButton_Click(sender As Object, e As EventArgs) Handles DeleteBookButton.Click
        Dim inventoryID As Integer = BooksDataGridView.SelectedRows.Item(0).Cells().Item(0).Value

        Dim result = MessageBox.Show("Are you sure that you want to delete this item?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim conn As New OleDbConnection(Singleton.ConnectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("DELETE FROM [inventory] WHERE ID = " & inventoryID & ";", conn)
            cmd.ExecuteNonQuery()
            conn.Close()

            LoadInventory(cmbBxFilter.SelectedIndex)

            MessageBox.Show("Item has been successfully deleted.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DeleteBookButton_EnabledChanged(sender As Object, e As EventArgs) Handles DeleteBookButton.EnabledChanged
        Dim btn As Button = DirectCast(sender, Button)
        If Not btn.Enabled Then
            DeleteBookButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        Else
            DeleteBookButton.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub cmbBxFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBxFilter.SelectedIndexChanged
        If cmbBxFilter.SelectedIndex < 0 Then
            cmbBxFilter.SelectedIndex = 0
        End If

        LoadInventory(cmbBxFilter.SelectedIndex)
    End Sub

    Private Sub StockCardButton_Click(sender As Object, e As EventArgs) Handles StockCardButton.Click
        Dim inventoryID As Integer = BooksDataGridView.SelectedRows(0).Cells(0).Value

        Dim stockCardForm As New StockCardForm
        stockCardForm.inventoryID = inventoryID
        stockCardForm.ShowDialog()
    End Sub

    Private Sub StockCardButton_EnabledChanged(sender As Object, e As EventArgs) Handles StockCardButton.EnabledChanged
        Dim btn As Button = DirectCast(sender, Button)
        If Not btn.Enabled Then
            StockCardButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
            StockCardButton.ForeColor = Color.FromArgb(51, 52, 59)
        Else
            StockCardButton.FlatAppearance.BorderColor = Color.Red
            StockCardButton.ForeColor = Color.Red
        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        SearchItem(textBox.Text)
    End Sub

    Private Sub BooksDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles BooksDataGridView.SelectionChanged
        If _isDataGridViewInit Then
            Dim dataGridView As DataGridView = DirectCast(sender, DataGridView)

            If dataGridView.SelectedRows.Count > 0 Then
                EditBookButton.Enabled = True
                DeleteBookButton.Enabled = True
                StockCardButton.Enabled = True
            Else
                EditBookButton.Enabled = False
                DeleteBookButton.Enabled = False
                StockCardButton.Enabled = False
            End If
        End If
    End Sub

    Private Sub BooksDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BooksDataGridView.CellDoubleClick
        Dim inventoryID As Integer = BooksDataGridView.SelectedRows.Item(0).Cells().Item(0).Value

        Dim editBookForm As New EditItemForm
        editBookForm.inventoryID = inventoryID
        editBookForm.ShowDialog()

        BooksDataGridView.ClearSelection()
    End Sub

    Private Sub SearchItem(item As String)
        BooksDataGridView.Rows.Clear()

        If item = "" Then
            For Each rowSearch As String() In temp_dgvItems
                BooksDataGridView.Rows.Add(rowSearch)
            Next
        Else
            Dim searchList As New List(Of String())

            For i As Integer = 0 To temp_dgvItems.Count - 1
                For j As Integer = 0 To temp_dgvItems(i).Length - 1
                    If temp_dgvItems(i)(j).ToString().ToLower().Contains(item.ToLower()) Then
                        searchList.Add(temp_dgvItems(i))
                        Exit For
                    End If
                Next
            Next

            If searchList.Count > 0 Then
                BooksDataGridView.Rows.Clear()

                For Each rowSearch As String() In searchList
                    BooksDataGridView.Rows.Add(rowSearch)
                Next
            End If
        End If
    End Sub

    Private Function HasCategories() As Boolean
        Dim count As Integer = 0

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [equipments];", conn)
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

    Public Shared Sub LoadInventory(filter As Integer)
        If filter < 0 Then
            filter = 0
        End If

        If sharedbooksDataGridView IsNot Nothing Then
            sharedbooksDataGridView.Rows.Clear()
        End If

        temp_dgvItems.Clear()

        Dim qry As String = String.Empty
        If filter = 1 Then
            qry &= "SELECT * FROM [inventory] WHERE [device] = 'Phone';"
        ElseIf filter = 2 Then
            qry &= "SELECT * FROM [inventory] WHERE [device] = 'Computer';"
        Else
            qry &= "SELECT * FROM [inventory]"
        End If

        Dim dt As New DataTable

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(qry, conn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()

        If dt.Rows.Count > 0 Then
            For Each drow As DataRow In dt.Rows
                Dim ID As String = drow.Item(0).ToString()
                Dim bookname As String = drow.Item(1).ToString()
                Dim device As String = drow.Item(2).ToString()
                Dim category As String = drow.Item(3).ToString()
                Dim publishedDate As String = drow.Item(4).ToString()
                Dim quantity As String = drow.Item(5).ToString()
                Dim price As String = drow.Item(6).ToString()

                Dim parameterRow As String() = {ID, bookname, device, category, publishedDate, quantity, price}

                If sharedbooksDataGridView IsNot Nothing Then
                    sharedbooksDataGridView.Rows.Add(parameterRow)
                End If

                temp_dgvItems.Add(parameterRow)
            Next
        End If

        If sharedbooksDataGridView IsNot Nothing Then
            sharedbooksDataGridView.ClearSelection()
        End If
    End Sub

End Class