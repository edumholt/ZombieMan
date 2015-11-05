Public Class frmWin

    Private Sub btnWinQuit_Click(sender As Object, e As EventArgs) Handles btnWinQuit.Click
        Me.Close()
        frmZombieMan.Close()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnLeaderboard_Click(sender As Object, e As EventArgs) Handles btnLeaderboard.Click
        frmLeaderboardEntry.Show()
        Me.Close()
    End Sub
End Class