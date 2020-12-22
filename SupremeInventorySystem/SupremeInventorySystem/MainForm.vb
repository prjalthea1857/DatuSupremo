Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class MainForm

    Dim _isLogout As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WelcomeToolStripLabel.Text = "Welcome, " & Singleton.FullName
        UserTypeToolStripStatusLabel.Text = Singleton.Privilege

        Dim childForm As New InventoryForm
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not _isLogout Then
            Application.Exit()
        End If
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        For Each form As Form In Me.MdiChildren
            form.Close()
        Next

        Dim childForm As New InventoryForm
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub ReconciliationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReconciliationToolStripMenuItem.Click
        If Not IsInventoryEmpty() Then
            ReconciliationForm.ShowDialog()
        Else
            MessageBox.Show("Please add an item to the inventory first before considering an reconciliation.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem.Click
        AccountsForm.ShowDialog()
    End Sub

    Private Sub ManageCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCategoriesToolStripMenuItem.Click
        ManageCategoriesForm.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
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

    Private Function IsInventoryEmpty() As Boolean
        Dim count As Integer

        Dim conn As New OleDbConnection(Singleton.ConnectionString)
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT COUNT(*) AS itemcount FROM [inventory];", conn)
        count = cmd.ExecuteScalar()
        conn.Close()

        Return count = 0
    End Function

End Class
