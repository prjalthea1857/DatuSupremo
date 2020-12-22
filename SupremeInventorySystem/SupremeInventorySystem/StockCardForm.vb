Imports System.Data.OleDb

Public Class StockCardForm

    Public inventoryID As Integer = 0

    Private Sub StockCardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowBookInfo()
        ShowStockCard()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ShowBookInfo()
        Dim qry As String = "SELECT * FROM [inventory] WHERE ID = " & inventoryID & ";"

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(qry, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            BookNameLabel.Text = dr(1).ToString()
            DeviceLabel.Text = dr(2).ToString()
            CategoryLabel.Text = dr(3).ToString()
            PublishedDateLabel.Text = dr(6).ToString()
            TotalBalanceLabel.Text = dr(4).ToString()
        End While

        conn.Close()
    End Sub

    Private Sub ShowStockCard()
        StockCardDataGridView.Rows.Clear()

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [stockcard] WHERE [inventoryID] = " & inventoryID & " ORDER BY [recordDate] ASC;", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            Dim recordDate As String = Date.Parse(dr(7)).ToString()
            Dim transactionMode As String = dr(2).ToString()
            Dim price As String = dr(3).ToString()
            Dim stockIn As String = dr(4).ToString()
            Dim stockOut As String = dr(5).ToString()
            Dim balance As String = dr(6).ToString()

            Dim parameterRow As String() = {recordDate, transactionMode, price, stockIn, stockOut, balance}

            StockCardDataGridView.Rows.Add(parameterRow)
        End While

        conn.Close()
    End Sub

End Class