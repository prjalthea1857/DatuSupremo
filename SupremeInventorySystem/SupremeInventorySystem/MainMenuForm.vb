Public Class MainMenuForm

    Dim _isLogout As Boolean = False

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Singleton.Privilege = "Administrator" Then
            TransactionsButton.Visible = True
        Else
            TransactionsButton.Visible = False
        End If
    End Sub

    Private Sub MainMenuForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not _isLogout Then
            Application.Exit()
        End If
    End Sub

    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
        InventoryForm.ShowDialog()
    End Sub

    Private Sub ReconciliationButton_Click(sender As Object, e As EventArgs) Handles ReconciliationButton.Click
        ReconciliationForm.ShowDialog()
    End Sub

    Private Sub AccountsButton_Click(sender As Object, e As EventArgs) Handles AccountsButton.Click
        AccountsForm.ShowDialog()
    End Sub

    Private Sub CategoriesButton_Click(sender As Object, e As EventArgs) Handles CategoriesButton.Click
        ManageCategoriesForm.ShowDialog()
    End Sub

    Private Sub TransactionsButton_Click(sender As Object, e As EventArgs) Handles TransactionsButton.Click
        TransactionsForm.ShowDialog()
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

End Class