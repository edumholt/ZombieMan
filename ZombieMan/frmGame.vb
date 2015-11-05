Public Class frmGame

    Private selectedWord As String
    Private wArray() As Char = {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "}
    Private hasLetter As Boolean
    
    Private Sub btnGenerateWord_Click() Handles btnGenerateWord.Click

        ResetDisplay()

        If rbnEasy.Checked = True Then
            selectedWord = SelectEasyWord()
        ElseIf rbnMedium.Checked = True Then
            selectedWord = SelectMediumWord()
        ElseIf rbnHard.Checked = True Then
            selectedWord = SelectHardWord()
        End If

        wArray = selectedWord.ToCharArray()
        DisplayWord(wArray)

    End Sub

    Public Sub DisplayWord(wordArray As Array)
        ResetDisplay()
        If wordArray(0) = " " Then
            txt1.BackColor = Color.DimGray
        Else
            txt1.Text = wordArray(0)
            txt1.BackColor = Color.White
        End If

        If wordArray(1) = " " Then
            txt2.BackColor = Color.DimGray
        Else
            txt2.Text = wordArray(1)
            txt2.BackColor = Color.White
        End If

        If wordArray(2) = " " Then
            txt3.BackColor = Color.DimGray
        Else
            txt3.Text = wordArray(2)
            txt3.BackColor = Color.White
        End If

        If wordArray(3) = " " Then
            txt4.BackColor = Color.DimGray
        Else
            txt4.Text = wordArray(3)
            txt4.BackColor = Color.White
        End If

        If wordArray(4) = " " Then
            txt5.BackColor = Color.DimGray
        Else
            txt5.Text = wordArray(4)
            txt5.BackColor = Color.White
        End If

        If wordArray(5) = " " Then
            txt6.BackColor = Color.DimGray
        Else
            txt6.Text = wordArray(5)
            txt6.BackColor = Color.White
        End If

        If wordArray(6) = " " Then
            txt7.BackColor = Color.DimGray
        Else
            txt7.Text = wordArray(6)
            txt7.BackColor = Color.White
        End If

        If wordArray(7) = " " Then
            txt8.BackColor = Color.DimGray
        Else
            txt8.Text = wordArray(7)
            txt8.BackColor = Color.White
        End If

        If wordArray(8) = " " Then
            txt9.BackColor = Color.DimGray
        Else
            txt9.Text = wordArray(8)
            txt9.BackColor = Color.White
        End If

        If wordArray(9) = " " Then
            txt10.BackColor = Color.DimGray
        Else
            txt10.Text = wordArray(9)
            txt10.BackColor = Color.White
        End If

        If wordArray(10) = " " Then
            txt11.BackColor = Color.DimGray
        Else
            txt11.Text = wordArray(10)
            txt11.BackColor = Color.White
        End If

        If wordArray(11) = " " Then
            txt12.BackColor = Color.DimGray
        Else
            txt12.Text = wordArray(11)
            txt12.BackColor = Color.White
        End If

        If wordArray(12) = " " Then
            txt13.BackColor = Color.DimGray
        Else
            txt13.Text = wordArray(12)
            txt13.BackColor = Color.White
        End If
    End Sub

    Public Function SelectEasyWord() As String
        Dim word As String
        word = dgvEasy.Rows(0).Cells(0).Value
        Return word
    End Function

    Public Function SelectMediumWord() As String
        Dim word As String
        word = dgvMedium.Rows(0).Cells(0).Value
        Return word
    End Function

    Public Function SelectHardWord() As String
        Dim word As String
        word = dgvHard.Rows(0).Cells(0).Value
        Return word
    End Function

    Private Sub lblA_Click() Handles lblA.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "A" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblA.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblA.BackColor = Color.Black
        CheckForWin()

    End Sub

    Private Sub lblB_Click() Handles lblB.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "B" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblB.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblB.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblC_Click() Handles lblC.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "C" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblC.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblC.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblD_Click() Handles lblD.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "D" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblD.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblD.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblE_Click() Handles lblE.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "E" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblE.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblE.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblF_Click() Handles lblF.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "F" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblF.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblF.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblG_Click() Handles lblG.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "G" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblG.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblG.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblH_Click() Handles lblH.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "H" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblH.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblH.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblI_Click() Handles lblI.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "I" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblI.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblI.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblJ_Click() Handles lblJ.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "J" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblJ.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblJ.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblK_Click() Handles lblK.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "K" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblK.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblK.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblL_Click() Handles lblL.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "L" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblL.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblL.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblM_Click() Handles lblM.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "M" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblM.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblM.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblN_Click() Handles lblN.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "N" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblN.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblN.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblO_Click() Handles lblO.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "O" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblO.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblO.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblP_Click() Handles lblP.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "P" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblP.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblP.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblQ_Click() Handles lblQ.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "Q" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblQ.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblQ.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblR_Click() Handles lblR.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "R" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblR.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblR.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblS_Click() Handles lblS.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "S" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblS.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblS.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblT_Click() Handles lblT.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "T" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblT.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblT.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblU_Click() Handles lblU.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "U" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblU.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblU.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblV_Click() Handles lblV.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "V" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblV.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblV.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblW_Click() Handles lblW.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "W" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblW.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblW.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblX_Click() Handles lblX.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "X" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblX.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblX.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblY_Click() Handles lblY.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "Y" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblY.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblY.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub lblZ_Click() Handles lblZ.Click
        hasLetter = False
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.Text = "Z" Then
                txt.ForeColor = Color.Black
                txt.BackColor = Color.AliceBlue
                hasLetter = True
            End If
        Next
        If Not hasLetter And Not lblZ.BackColor = Color.Black Then
            ChangeImage()
        End If
        lblZ.BackColor = Color.Black
        CheckForWin()
    End Sub

    Private Sub btnQuit_Click() Handles btnQuit.Click
        Me.Close()
        frmZombieMan.Close()
    End Sub

    Private Sub ResetDisplay()
        Me.EasyTableAdapter.Fill(Me.DstEasy.Easy)
        Me.MediumTableAdapter.Fill(Me.DstMedium.Medium)
        Me.HardTableAdapter.Fill(Me.DstHard.Hard)

        pbxZombieGame.BackColor = Color.White
        pbxZombieGame.Image = My.Resources.ZombieMan1
        txtGuessesLeft.Text = "7"
        lblGuesses.Text = "Guesses Left:"
        For Each txt As TextBox In gbxWordToGuess.Controls
            txt.Text = " "
            txt.ForeColor = Color.White
        Next

        For Each lbl As Label In gbxLetterToChoose.Controls
            lbl.BackColor = Color.AliceBlue
        Next

    End Sub

    Private Sub ChangeImage()
        
        Select Case (pbxZombieGame.BackColor)
            Case Color.White
                pbxZombieGame.Image = My.Resources.ZombieMan2
                pbxZombieGame.BackColor = Color.GhostWhite
                txtGuessesLeft.Text = "6"
            Case Color.GhostWhite
                pbxZombieGame.Image = My.Resources.ZombieMan3
                pbxZombieGame.BackColor = Color.OldLace
                txtGuessesLeft.Text = "5"
            Case Color.OldLace
                pbxZombieGame.Image = My.Resources.ZombieMan4
                pbxZombieGame.BackColor = Color.Ivory
                txtGuessesLeft.Text = "4"
            Case Color.Ivory
                pbxZombieGame.Image = My.Resources.ZombieMan5
                pbxZombieGame.BackColor = Color.Snow
                txtGuessesLeft.Text = "3"
            Case Color.Snow
                pbxZombieGame.Image = My.Resources.ZombieMan6
                pbxZombieGame.BackColor = Color.WhiteSmoke
                txtGuessesLeft.Text = "2"
            Case Color.WhiteSmoke
                pbxZombieGame.Image = My.Resources.ZombieMan7
                pbxZombieGame.BackColor = Color.SeaShell
                txtGuessesLeft.Text = "1"
            Case Color.SeaShell
                pbxZombieGame.Image = My.Resources.ZombieMan8
                pbxZombieGame.BackColor = Color.Crimson
                lblGuesses.Text = "LOOSER!!"
                txtGuessesLeft.Text = ""
                frmLoser.Show()
        End Select

    End Sub

    Private Sub CheckForWin()
        Dim check As Boolean = True
        For Each txt As TextBox In gbxWordToGuess.Controls
            If txt.BackColor = Color.White Or txt.BackColor = Color.Gainsboro Then
                check = False
            End If
        Next

        If check Then
            frmWin.Show()
        End If
    End Sub

    Private Sub btnShowLeaderboard_Click(sender As Object, e As EventArgs) Handles btnShowLeaderboard.Click
        frmLeaderboard.Show()
    End Sub

End Class