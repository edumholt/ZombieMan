Public Class frmLoser

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        Me.Close()
    End Sub

    Private Sub btnLoseQuit_Click(sender As Object, e As EventArgs) Handles btnLoseQuit.Click
        Me.Close()
        frmZombieMan.Close()
    End Sub
End Class