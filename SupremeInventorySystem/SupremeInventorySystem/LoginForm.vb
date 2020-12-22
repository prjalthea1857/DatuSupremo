Imports System.Data.OleDb

Public Class LoginForm

    Dim blockCounter As Integer = 1

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckBlockSystem() Then
            MessageBox.Show("This application is blocked for two minutes (2).", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If

        UserTypeComboBox.SelectedIndex = 0
    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub UsernameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If Not CheckBlockSystem() Then
            Login()
        Else
            MessageBox.Show("This application is blocked for two minutes (2).", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Login()
        If UsernameTextBox.Text = "" Then
            MessageBox.Show("Please enter your username", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If PasswordTextBox.Text = "" Then
            MessageBox.Show("Please enter your password", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim isExists As Boolean = False

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [accounts] WHERE [privilege] = '" & UserTypeComboBox.Text & "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            isExists = True

            If dr(2).ToString().Equals(UsernameTextBox.Text) Then
                If dr(3).ToString().Equals(PasswordTextBox.Text) Then

                    Singleton.SessionID = CInt(dr(0).ToString())
                    Singleton.FullName = dr(4).ToString()
                    Singleton.Privilege = dr(1).ToString()

                    If dr(1).ToString().Equals("Administrator") Or dr(1).ToString().Equals("Sales Clerk") Then
                        MainMenuForm.Show()
                    Else
                        SalesForm.Show()
                    End If

                    Me.Hide()
                    MessageBox.Show("Account has been successfully logged in.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    isExists = False
                End If
            Else
                isExists = False
            End If
        End While

        If Not isExists Then
            If (3 - blockCounter) = 0 Then
                BlockAccount()

                MessageBox.Show("Please wait for two minutes (2) to re-login again.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Application.Exit()
            Else
                MessageBox.Show("You have " & (3 - blockCounter).ToString() & " more times to open your account.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            blockCounter += 1
        End If

        conn.Close()

        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        UsernameTextBox.Focus()
    End Sub

    Private Sub BlockAccount()
        Dim dt As DateTime = DateTime.Now
        dt = dt.AddMinutes(2)

        Dim addedDateTime As String = dt.ToLongDateString() & " " & dt.ToLongTimeString()

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("UPDATE [settings] SET [blocktime] = '" & addedDateTime & "', [systemblock] = 'true' WHERE ID = 1", conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub UnblockSystem()
        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("UPDATE [settings] SET [blocktime] = '', [systemblock] = 'false' WHERE ID = 1;", conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Function CheckBlockSystem() As Boolean
        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [settings] WHERE [systemblock] = 'true';", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        While dr.Read()
            Dim dt_checktime As DateTime = DateTime.Parse(dr(1).ToString)

            If dt_checktime.Ticks > DateTime.Now.Ticks Then
                Return True
            Else
                UnblockSystem()
            End If
        End While

        conn.Close()

        Return False
    End Function

End Class
