Imports System.Data.OleDb

Public Class TransactionsForm

    Private Sub TransactionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewTransactionButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)

        LoadAllTransactions()
    End Sub

    Private Sub TransactionsForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RecordsDataGridView.ClearSelection()
    End Sub

    Private Sub ViewTransactionButton_EnabledChanged(sender As Object, e As EventArgs) Handles ViewTransactionButton.EnabledChanged
        Dim btn As Button = DirectCast(sender, Button)
        If Not btn.Enabled Then
            ViewTransactionButton.FlatAppearance.BorderColor = Color.FromArgb(51, 52, 59)
        Else
            ViewTransactionButton.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub

    Private Sub RecordsDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles RecordsDataGridView.SelectionChanged
        Dim dataGridView As DataGridView = DirectCast(sender, DataGridView)

        If dataGridView.SelectedRows.Count > 0 Then
            ViewTransactionButton.Enabled = True
        Else
            ViewTransactionButton.Enabled = False
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub LoadAllTransactions()
        RecordsDataGridView.Rows.Clear()

        Dim dt As New DataTable

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [transactions];", conn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()

        If dt.Rows.Count > 0 Then
            For Each drow As DataRow In dt.Rows
                Dim ID As String = drow.Item(0).ToString()
                Dim transactionNumber As String = drow.Item(1).ToString()
                Dim total As String = FormatCurrency(CDbl(drow.Item(2)))
                Dim cashtendered As String = FormatCurrency(CDbl(drow.Item(3)))
                Dim change As String = FormatCurrency(CDbl(drow.Item(4)))
                Dim recordDate As String = drow.Item(5).ToString()

                RecordsDataGridView.Rows.Add(ID, transactionNumber, total, cashtendered, change, recordDate)
            Next
        End If
    End Sub

    Private Sub ViewTransactionButton_Click(sender As Object, e As EventArgs) Handles ViewTransactionButton.Click
        Dim transactionID As Integer = RecordsDataGridView.SelectedRows(0).Cells(0).Value

        Dim viewTransactionsForm As New ViewTransactionsForm
        viewTransactionsForm.transactionID = transactionID
        viewTransactionsForm.ShowDialog()
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