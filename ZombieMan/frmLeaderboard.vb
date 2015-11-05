Public Class frmLeaderboard

    Private Sub frmLeaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LeaderboardTableAdapter.Fill(Me.LeaderboardDataSet.Leaderboard)
    End Sub

    Private Sub btnLeaderboardReturntToGame_Click(sender As Object, e As EventArgs) Handles btnLeaderboardReturntToGame.Click
        Me.Close()
    End Sub
End Class