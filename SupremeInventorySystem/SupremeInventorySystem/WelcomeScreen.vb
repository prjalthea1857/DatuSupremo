Imports System.Threading

Public Class WelcomeScreen

    Dim ticks As Integer = 0

    Private Sub WelcomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingTimer.Start()
    End Sub

    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        ticks += 1

        If Not LoadingProgressBar.Value = LoadingProgressBar.Maximum Then
            LoadingProgressBar.PerformStep()
        Else
            LoadingProgressBar.Value = LoadingProgressBar.Maximum
        End If

        If ticks = 15 Then
            ticks = 0

            LoadingTimer.Stop()

            LoginForm.Show()
            Me.Hide()
        End If
    End Sub

End Class