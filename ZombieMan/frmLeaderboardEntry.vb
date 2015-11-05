Public Class frmLeaderboardEntry

    Private Sub frmLeaderboardEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LeaderboardTableAdapter.Fill(Me.DstLeaderBoardEntry.Leaderboard)
        txtGuessesLeft.Text = frmGame.txtGuessesLeft.Text

    End Sub

    Private Sub btnSaveLeaderboardEntry_Click(sender As Object, e As EventArgs) Handles btnSaveLeaderboardEntry.Click
        Try
            Me.LeaderboardTableAdapter.Insert(CStr(txtName.Text), CInt(txtGuessesLeft.Text))
            Me.LeaderboardTableAdapter.Fill(DstLeaderBoardEntry.Leaderboard)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Input Error")
        End Try

        frmLeaderboard.Show()
        Me.Close()
    End Sub
End Class