Imports System.Data.OleDb

Public Class StockListForm

    Dim temp_listItems As New List(Of Tuple(Of String, Integer))

    Private Sub StockListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStockList()
    End Sub

    Private Sub StockListForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        SearchItem(textBox.Text)
    End Sub

    Private Sub LoadStockList()
        StockListView.Clear()

        StockListView.Columns.Add("Item Name", 250, HorizontalAlignment.Left)
        StockListView.Columns.Add("Quantity", 80, HorizontalAlignment.Left)

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [inventory] ORDER BY [itemname] ASC;", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            Dim itemName As String = dr(1).ToString()
            Dim quantity As String = dr(4).ToString()

            StockListView.Items.Add(New ListViewItem(New String() {itemName, quantity}))

            temp_listItems.Add(New Tuple(Of String, Integer)(itemName, quantity))
        End While

        conn.Close()
    End Sub

    Private Sub SearchItem(item As String)
        StockListView.Items.Clear()

        If item = "" Then
            For Each rowSearch As Tuple(Of String, Integer) In temp_listItems
                StockListView.Items.Add(New ListViewItem(New String() {rowSearch.Item1, rowSearch.Item2}))
            Next
        Else
            Dim searchList As New List(Of Tuple(Of String, Integer))

            For i As Integer = 0 To temp_listItems.Count - 1
                If temp_listItems(i).Item1.ToLower().Contains(item.ToLower()) Then
                    searchList.Add(temp_listItems(i))
                End If
            Next

            If searchList.Count > 0 Then
                StockListView.Items.Clear()

                For Each rowSearch As Tuple(Of String, Integer) In searchList
                    StockListView.Items.Add(New ListViewItem(New String() {rowSearch.Item1, rowSearch.Item2}))
                Next
            End If
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class