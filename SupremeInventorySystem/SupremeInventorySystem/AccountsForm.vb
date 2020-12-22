Imports System.Data.OleDb

Public Class AccountsForm

    Private Sub AccountsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowAccountInfo()
    End Sub

    Private Sub SaveAccountButton_Click(sender As Object, e As EventArgs) Handles SaveAccountButton.Click
        If ValidateFields() Then
            Dim username As String = UsernameTextBox.Text
            Dim password As String = PasswordTextBox.Text
            Dim fullname As String = FullNameTextBox.Text
            Dim address As String = AddressTextBox.Text
            Dim gender As String = GenderComboBox.Text
            Dim contactNumber As String = ContactNumberTextBox.Text
            Dim email As String = EmailAddressTextBox.Text

            Dim qry As String = ""
            qry &= "UPDATE [accounts] SET "
            qry &= "[username] = '" & username & "', "
            qry &= "[password] = '" & password & "', "
            qry &= "[fullname] = '" & fullname & "', "
            qry &= "[address] = '" & address & "', "
            qry &= "[gender] = '" & gender & "', "
            qry &= "[contactnumber] = '" & contactNumber & "', "
            qry &= "[email] = '" & email & "' "
            qry &= "WHERE [ID] = " & Singleton.SessionID.ToString() & ";"

            Dim conn As New OleDbConnection(Singleton.ConnectionString)
            conn.Open()
            Dim cmd As New OleDbCommand(qry, conn)
            cmd.ExecuteNonQuery()
            conn.Close()

            MainForm.WelcomeToolStripLabel.Text = "Welcome, " & fullname

            MessageBox.Show("Account has been successfully updated.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ShowAccountInfo()
        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM [accounts] WHERE ID = " & Singleton.SessionID.ToString() & ";", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            UsernameTextBox.Text = dr(2).ToString()
            PasswordTextBox.Text = dr(3).ToString()
            FullNameTextBox.Text = dr(4).ToString()
            AddressTextBox.Text = dr(5).ToString()
            GenderComboBox.Text = dr(6).ToString()
            ContactNumberTextBox.Text = dr(7).ToString()
            EmailAddressTextBox.Text = dr(8).ToString()
        End If

        conn.Close()
    End Sub

    Private Function ValidateFields() As Boolean
        If UsernameTextBox.Text = "" Then
            MessageBox.Show("Please input a username.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If PasswordTextBox.Text = "" Then
            MessageBox.Show("Please input a password.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If FullNameTextBox.Text = "" Then
            MessageBox.Show("Please input your full name.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If AddressTextBox.Text = "" Then
            MessageBox.Show("Please input your address.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If ContactNumberTextBox.Text = "" Then
            MessageBox.Show("Please input your contact number.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If EmailAddressTextBox.Text = "" Then
            MessageBox.Show("Please input your email address.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return True
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class