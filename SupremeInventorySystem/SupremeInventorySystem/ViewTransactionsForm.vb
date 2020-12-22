Imports System.Data.OleDb

Public Class ViewTransactionsForm

    Public transactionID As Integer = 0

    Private Sub ViewTransactionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewTransactionInfo()
        ListAllTransaction()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ViewTransactionInfo()
        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [transactions] WHERE [ID] = " & transactionID & ";", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            TransactionNumberLabel.Text = dr(1).ToString()
            TotalLabel.Text = FormatCurrency(CDbl(dr(2)))
            CashTenderedLabel.Text = FormatCurrency(CDbl(dr(3)))
            ChangeLabel.Text = FormatCurrency(CDbl(dr(4)))
            RecordDateLabel.Text = dr(5).ToString()
        End If

        conn.Close()
    End Sub

    Private Sub ListAllTransaction()
        QueueDataGridView.Rows.Clear()

        Dim qry As String = ""
        qry &= "SELECT "
        qry &= "[inventory].[itemname] AS itemname, "
        qry &= "[transactionlist].[quantity] AS quantity, "
        qry &= "[transactionlist].[price] AS price, "
        qry &= "[transactionlist].[subtotal] AS subtotal "
        qry &= "FROM [transactionlist] "
        qry &= "INNER JOIN [inventory] ON [transactionlist].[stockID] = [inventory].[ID] "
        qry &= "WHERE [transactionID] = " & transactionID & ";"

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand(qry, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            Dim bookname As String = dr(0).ToString()
            Dim quantity As String = dr(1).ToString()
            Dim price As String = FormatCurrency(CDbl(dr(2)))
            Dim subtotal As String = FormatCurrency(CDbl(dr(3)))

            QueueDataGridView.Rows.Add(bookname, quantity, price, subtotal)
        End While

        conn.Close()
    End Sub

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