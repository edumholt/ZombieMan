Public Class frmZombieMan

    Private Sub btnInstructions_Click() Handles btnInstructions.Click
        frmInstructions.Show()
    End Sub

    Private Sub btnNoThanks_Click() Handles btnNoThanks.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click() Handles btnStart.Click
        frmGame.Show()
        Me.Hide()
    End Sub

End Class
