Imports System
Imports System.IO
Imports System.Reflection

Public Class frmYahtzee
    'define variables for die rolls
    Dim randNumber As New Random
    Dim RollCount As Integer = 0
    Dim DieValueArray(5) As Integer

    'define variables for sub-scores
    Dim TallyArray(6)
    Dim Max As Integer
    Dim Zero As Integer
    Dim Sum As Integer

    'define upper section, lower section, total, and grandTotal scores
    Dim LowerSection As Integer = 0
    Dim UpperSection As Integer = 0 'includes bonus
    Dim TotalScore As Integer = 0
    Dim GrandTotal As Integer = 0

    'define upper section bonus 
    Dim UpperSectionBonus As Integer = 35

    'define variables for High Score sheet
    Dim GameIsOver As Boolean = False
    Dim playerName As String = ""
    Dim writeScoreHoldFile As StreamWriter
    Dim writeNameFile As StreamWriter
    Dim readScoreFile As StreamReader
    Dim writeScoreHistoryFile As StreamWriter
    Dim HighScore As Integer
    Dim FileNum As Integer

    'define variables to track what has been scored
    Dim acesScored As Boolean = False
    Dim twosScored As Boolean = False
    Dim threesScored As Boolean = False
    Dim foursScored As Boolean = False
    Dim fivesScored As Boolean = False
    Dim sixesScored As Boolean = False
    Dim threeOAKScored As Boolean = False
    Dim fourOAKScored As Boolean = False
    Dim fourSeqScored As Boolean = False
    Dim fiveSeqScored As Boolean = False
    Dim fullHouseScored As Boolean = False
    Dim chanceScored As Boolean = False
    Dim yahtzeeScored As Boolean = False

    Private Sub btnRollEm_Click(sender As Object, e As EventArgs) Handles btnRollEm.Click
        Dim checkboxArray As CheckBox() = {chkRoll1, chkRoll2, chkRoll3, chkRoll4, chkRoll5}

        'randomly roll selected die and change image accordingly
        For j = 0 To 10
            For k = 0 To 4
                If checkboxArray(k).Checked Then
                    DieValueArray(k) = randNumber.Next(6) + 1
                    DiceImageChange(k)
                End If
            Next
            System.Threading.Thread.Sleep(100)
        Next
        'Update button text / availability
        RollCount += 1
        CalcSum()
        CalcTally()
        CalcMax()
        CalcZero()

        If RollCount = 1 Then
            EnableScoreButtons()
            btnRollEm.Text = "Roll! (2)"
            EnableChkBoxes()
        ElseIf RollCount = 2 Then
            btnRollEm.Text = "Roll! (1)"
            EnableChkBoxes()
        ElseIf RollCount = 3 Then
            btnRollEm.Enabled = False
            btnRollEm.Text = "Must Score"
        End If
    End Sub

    Sub DiceImageChange(dieNum As Integer)
        Dim DieImageArray() As PictureBox = {pbxDie1, pbxDie2, pbxDie3, pbxDie4, pbxDie5}
        DieImageArray(dieNum).Image = imlDiceList.Images(DieValueArray(dieNum) - 1)
        DieImageArray(dieNum).Refresh()
    End Sub

    Private Sub btnAces_Click(sender As Object, e As EventArgs) Handles btnAces.Click
        acesScored = True
        txtAces.Text = CStr(TallyArray(0))
        UpperSection += TallyArray(0)
        TotalScore += TallyArray(0)
        GrandTotal += TallyArray(0)
        ResetTallyAndRollCount()
    End Sub

    Private Sub btnTwos_Click(sender As Object, e As EventArgs) Handles btnTwos.Click
        twosScored = True
        txtTwos.Text = CStr(2 * TallyArray(1))
        UpperSection += 2 * TallyArray(1)
        TotalScore += 2 * TallyArray(1)
        GrandTotal += 2 * TallyArray(1)
        ResetTallyAndRollCount()
    End Sub

    Private Sub btnThrees_Click(sender As Object, e As EventArgs) Handles btnThrees.Click
        threesScored = True
        txtThrees.Text = CStr(3 * TallyArray(2))
        UpperSection += 3 * TallyArray(2)
        TotalScore += 3 * TallyArray(2)
        GrandTotal += 3 * TallyArray(2)
        ResetTallyAndRollCount()
    End Sub

    Private Sub btnFours_Click(sender As Object, e As EventArgs) Handles btnFours.Click
        foursScored = True
        txtFours.Text = CStr(4 * TallyArray(3))
        UpperSection += 4 * TallyArray(3)
        TotalScore += 4 * TallyArray(3)
        GrandTotal += 4 * TallyArray(3)
        ResetTallyAndRollCount()
    End Sub

    Private Sub btnFives_Click(sender As Object, e As EventArgs) Handles btnFives.Click
        fivesScored = True
        txtFives.Text = CStr(5 * TallyArray(4))
        UpperSection += (5 * TallyArray(4))
        TotalScore += (5 * TallyArray(4))
        GrandTotal += (5 * TallyArray(4))
        ResetTallyAndRollCount()
    End Sub

    Private Sub btnSixes_Click(sender As Object, e As EventArgs) Handles btnSixes.Click
        sixesScored = True
        txtSixes.Text = CStr(6 * TallyArray(5))
        UpperSection += 6 * TallyArray(5)
        TotalScore += 6 * TallyArray(5)
        GrandTotal += 6 * TallyArray(5)
        ResetTallyAndRollCount()
    End Sub

    Private Sub btn3OAK_Click(sender As Object, e As EventArgs) Handles btn3OAK.Click
        threeOAKScored = True
        If Max >= 3 Then
            LowerSection += Sum
            GrandTotal += Sum
            txt3OAK.Text = CStr(Sum)
        Else
            txt3OAK.Text = "0"
        End If
        ResetTallyAndRollCount()
    End Sub

    Private Sub btn4OAK_Click(sender As Object, e As EventArgs) Handles btn4OAK.Click
        fourOAKScored = True
        If Max >= 4 Then
            LowerSection += Sum
            GrandTotal += Sum
            txt4OAK.Text = CStr(Sum)
        Else
            txt4OAK.Text = "0"
        End If
        ResetTallyAndRollCount()
    End Sub

    Private Sub btnYahtzee_Click(sender As Object, e As EventArgs) Handles btnYahtzee.Click
        yahtzeeScored = True
        If Max = 5 Then
            LowerSection += 50
            GrandTotal += 50
            txtYahtzee.Text = "50"
        Else
            txtYahtzee.Text = "0"
        End If
        ResetTallyAndRollCount()
    End Sub

    Private Sub btnFullHouse_Click(sender As Object, e As EventArgs) Handles btnFullHouse.Click
        fullHouseScored = True
        If Max = 3 And Zero = 4 Then
            LowerSection += 25
            GrandTotal += 25
            txtFullHouse.Text = "25"
        Else
            txtFullHouse.Text = "0"
        End If
        ResetTallyAndRollCount()
    End Sub

    Private Sub btnSeq4_Click(sender As Object, e As EventArgs) Handles btnSeq4.Click
        fourSeqScored = True
        If (TallyArray(0) >= 1 And TallyArray(1) >= 1 And TallyArray(2) >= 1 And TallyArray(3) >= 1) Or
           (TallyArray(1) >= 1 And TallyArray(2) >= 1 And TallyArray(3) >= 1 And TallyArray(4) >= 1) Or
           (TallyArray(2) >= 1 And TallyArray(3) >= 1 And TallyArray(4) >= 1 And TallyArray(5) >= 1) Then
            LowerSection += 30
            GrandTotal += 30
            txtSeq4.Text = "30"
        Else
            txtSeq4.Text = "0"
        End If
        ResetTallyAndRollCount()
    End Sub

    Private Sub btnSeq5_Click(sender As Object, e As EventArgs) Handles btnSeq5.Click
        fiveSeqScored = True
        If Max = 1 And (TallyArray(0) = 0 Or TallyArray(5) = 0) Then
            LowerSection += 40
            GrandTotal += 40
            txtSeq5.Text = "40"
        Else
            txtSeq5.Text = "0"
        End If
        ResetTallyAndRollCount()
    End Sub

    Private Sub btnChance_Click(sender As Object, e As EventArgs) Handles btnChance.Click
        chanceScored = True
        DisableScoreButtons()
        LowerSection += Sum
        GrandTotal += Sum
        txtChance.Text = CStr(Sum)
        ResetTallyAndRollCount()
    End Sub

    Sub BonusPointsAdds()
        'Check to see if Yahtzee bonus applies
        If (txtYahtzee.Text = "50") And Max = 5 Then
            txtYtzBonus.Text = "100"
            LowerSection += 100
        End If
        ' Check to see if UpperSection >= 63 points to add one time 35 bonus
        If UpperSection >= 63 And txtUpperSectionBonus.Text = "" Then
            txtUpperSectionBonus.Text = "35"
            UpperSection += UpperSectionBonus
        End If
    End Sub

    Sub CalcTally()
        For k = 0 To 5
            TallyArray(k) = 0
        Next
        For k = 0 To 4
            TallyArray(DieValueArray(k) - 1) += 1
        Next
    End Sub

    Sub CalcSum()
        Sum = 0
        For k = 0 To 4
            Sum += DieValueArray(k)
        Next
    End Sub

    Sub CalcMax()
        Max = 0
        For k = 0 To 5
            If TallyArray(k) > Max Then
                Max = TallyArray(k)
            End If
        Next
    End Sub

    Sub CalcZero()
        Zero = 0
        For k = 0 To 5
            If TallyArray(k) = 0 Then Zero += 1
        Next
    End Sub

    Sub ResetTallyAndRollCount()
        RollCount = 0
        DisableChkBoxes()
        DisableScoreButtons()
        btnRollEm.Text = "Roll! (3)"
        btnRollEm.Enabled = True
        BonusPointsAdds()
        txtTotalUpperSection.Text = CStr(UpperSection)
        txtTotalLowerScore.Text = CStr(LowerSection)
        txtTotalScore.Text = CStr(TotalScore)
        txtGrandTotal.Text = CStr(GrandTotal)
    End Sub
    Sub HighScoreCheck()
        'scoreHoldFile = File.CreateText("holdHighScore.txt")
        'nameFile = File.CreateText("playerName.txt")
        'used the 2 lines of codes above to create file holdHighScore.txt and playerName.txt then disabled them
        
        If GameIsOver Then
            'open holdHighScore.txt to read what standing high score was
            readScoreFile = File.OpenText("holdHighScore.txt")
            'put score into variable
            HighScore = readScoreFile.ReadLine()
            'close file
            readScoreFile.Close()
            'unlock/release resources to prevent error
            readScoreFile.Dispose()

            If GrandTotal > HighScore Then
                HighScore = GrandTotal

                'get player's name
                playerName = InputBox("High Score! Enter your name: ", "It's a High Score!")

                'Open and append score information to HighScore.txt file
                writeScoreHistoryFile = File.AppendText("HighScore.txt")
                writeScoreHistoryFile.WriteLine()
                writeScoreHistoryFile.Write(playerName & "   " & HighScore & " points    " & DateTime.Now)
                writeScoreHistoryFile.Close()
                writeScoreHistoryFile.Dispose()

                'Open file to write/hold player's name playerName.txt file
                writeNameFile = File.CreateText("playerName.txt")
                'write score
                writeNameFile.WriteLine(playerName)
                'close playerName.txt
                writeNameFile.Close()
                'unlock file/release to prevent errors
                writeNameFile.Dispose()

                'open file to write/hold standing high score in holdHighScore.txt file
                writeScoreHoldFile = File.CreateText("holdHighScore.txt")
                'write score
                writeScoreHoldFile.WriteLine(HighScore)
                ' close holdHighScore.txt
                writeScoreHoldFile.Close()
                'unlock file/release resources to prevent errors
                writeScoreHoldFile.Dispose()

                nameLabel.Text = "Top player: " & playerName & ": " & HighScore & " points"
            End If
        End If
    End Sub

    Sub EnableScoreButtons()
        btnAces.Enabled = Not acesScored
        btnTwos.Enabled = Not twosScored
        btnThrees.Enabled = Not threesScored
        btnFours.Enabled = Not foursScored
        btnFives.Enabled = Not fivesScored
        btnSixes.Enabled = Not sixesScored
        btn3OAK.Enabled = Not threeOAKScored
        btn4OAK.Enabled = Not fourOAKScored
        btnChance.Enabled = Not chanceScored
        btnFullHouse.Enabled = Not fullHouseScored
        btnSeq4.Enabled = Not fourSeqScored
        btnSeq5.Enabled = Not fiveSeqScored
        btnYahtzee.Enabled = Not yahtzeeScored

        If acesScored And twosScored And threesScored And
            foursScored And fivesScored And sixesScored And
            threeOAKScored And fourOAKScored And fourSeqScored And
            fiveSeqScored And fullHouseScored And chanceScored And
            yahtzeeScored Then
            ResetTallyAndRollCount()
            'HighScoreRecord()
            MessageBox.Show("Game Over")
            'flag that game is over so that sub (under timer) HighScore can check for high score
            GameIsOver = True
            HighScoreCheck()

        End If
    End Sub

    Sub DisableScoreButtons()
        btnAces.Enabled = False
        btnTwos.Enabled = False
        btnThrees.Enabled = False
        btnFours.Enabled = False
        btnFives.Enabled = False
        btnSixes.Enabled = False
        btn3OAK.Enabled = False
        btn4OAK.Enabled = False
        btnChance.Enabled = False
        btnFullHouse.Enabled = False
        btnSeq4.Enabled = False
        btnSeq5.Enabled = False
        btnYahtzee.Enabled = False
    End Sub

    Sub DisableChkBoxes()
        chkRoll1.Enabled = False
        chkRoll2.Enabled = False
        chkRoll3.Enabled = False
        chkRoll4.Enabled = False
        chkRoll5.Enabled = False

        chkRoll1.Checked = True
        chkRoll2.Checked = True
        chkRoll3.Checked = True
        chkRoll4.Checked = True
        chkRoll5.Checked = True
    End Sub

    Sub EnableChkBoxes()
        chkRoll1.Enabled = True
        chkRoll2.Enabled = True
        chkRoll3.Enabled = True
        chkRoll4.Enabled = True
        chkRoll5.Enabled = True
    End Sub

    Private Sub frmYahtzee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'High Score text file
        Dim FileNum As Integer = FreeFile()
        'tmrRoll.Start()
        pbxDie1.Image = imlDiceList.Images(0)
        pbxDie2.Image = imlDiceList.Images(0)
        pbxDie3.Image = imlDiceList.Images(0)
        pbxDie4.Image = imlDiceList.Images(0)
        pbxDie5.Image = imlDiceList.Images(0)
    End Sub

    Private Sub HowToPlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuHelpHowToPlay.Click
        'Show window displaying frmRules with RTFTextBox
        frmRules.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrRoll.Tick
        
    End Sub

    Private Sub ToolTipAces_Popup(sender As Object, e As PopupEventArgs) Handles ToolTipAces.Popup
        Dim ToolTipAces As New ToolTip()
        ToolTipAces.SetToolTip(btnAces, "hi")
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuGameNewGame.Click
        'clear out old game and prepare for new game
        'Array to clear out output boxes
        'Define array
        Dim outputTextBoxes As TextBox() = {txtAces, txtTwos, txtThrees, txtFours, txtFives, txtFours,
                                         txtFives, txtSixes, txt3OAK, txt4OAK, txtFullHouse, txtGrandTotal, txtUpperSectionBonus,
                                         txtSeq4, txtSeq5, txtYahtzee, txtChance, txtTotalLowerScore,
                                        txtTotalScore, txtYtzBonus, txtTotalUpperSection}

        For k = 0 To outputTextBoxes.Length - 1
            outputTextBoxes(k).Text() = ""
        Next
        'Zero out counters
        RollCount = 0
        'Zero out all scores kept
        TotalScore = 0
        Max = 0
        Zero = 0
        UpperSection = 0
        LowerSection = 0
        GrandTotal = 0
        'disable all roll checkboxes and have them checked to roll
        DisableChkBoxes()
        DisableScoreButtons()
        'clear out scored button memory
        acesScored = False
        twosScored = False
        threesScored = False
        foursScored = False
        fivesScored = False
        sixesScored = False
        threeOAKScored = False
        fourOAKScored = False
        chanceScored = False
        fullHouseScored = False
        fourSeqScored = False
        fiveSeqScored = False
        yahtzeeScored = False
        ' Declare array variable to reset dice images to 1
        Dim DieImageArray() As PictureBox = {pbxDie1, pbxDie2, pbxDie3, pbxDie4, pbxDie5}
        For dieNum = 0 To 4
            DieImageArray(dieNum).Image = imlDiceList.Images(0)
        Next
    End Sub

    Private Sub mnuGameQuit_Click(sender As Object, e As EventArgs) Handles mnuGameQuit.Click
        Me.Close()
    End Sub

    Private Sub ShowHighScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowHighScoresToolStripMenuItem.Click
        'opens Show High Scores window
        frmShowHighScores.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Dim frmAbout As New AboutForm
        'open About window
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnAces_MouseHover(sender As Object, e As EventArgs) Handles btnAces.MouseHover
        txtAces.ForeColor = Color.DarkBlue
        txtAces.Text = CStr(TallyArray(0))
    End Sub

    Private Sub btnAces_MouseLeave(sender As Object, e As EventArgs) Handles btnAces.MouseLeave
        'acesScored = False
        txtAces.Text = ""
        txtAces.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub btnTwos_MouseHover(sender As Object, e As EventArgs) Handles btnTwos.MouseHover
        txtTwos.Text = CStr(2 * TallyArray(1))
    End Sub

    Private Sub btnTwos_MouseLeave(sender As Object, e As EventArgs) Handles btnTwos.MouseLeave
        txtTwos.Text = ""
    End Sub

    Private Sub btnThrees_MouseHover(sender As Object, e As EventArgs) Handles btnThrees.MouseHover
        txtThrees.Text = CStr(3 * TallyArray(2))
    End Sub

    Private Sub btnThrees_MouseLeave(sender As Object, e As EventArgs) Handles btnThrees.MouseLeave
        txtThrees.Text = ""
    End Sub

    Private Sub btnFours_MouseHover(sender As Object, e As EventArgs) Handles btnFours.MouseHover
        txtFours.Text = CStr(4 * TallyArray(3))
    End Sub

    Private Sub btnFours_MouseLeave(sender As Object, e As EventArgs) Handles btnFours.MouseLeave
        txtFours.Text = ""
    End Sub

    Private Sub btnFives_MouseHover(sender As Object, e As EventArgs) Handles btnFives.MouseHover
        txtFives.Text = CStr(5 * TallyArray(4))
    End Sub

    Private Sub btnFives_MouseLeave(sender As Object, e As EventArgs) Handles btnFives.MouseLeave
        txtFives.Text = ""
    End Sub

    Private Sub btnSixes_MouseHover(sender As Object, e As EventArgs) Handles btnSixes.MouseHover
        txtSixes.Text = CStr(6 * TallyArray(5))
    End Sub

    Private Sub btnSixes_MouseLeave(sender As Object, e As EventArgs) Handles btnSixes.MouseLeave
        txtSixes.Text = ""
    End Sub

    Private Sub btn3OAK_MouseHover(sender As Object, e As EventArgs) Handles btn3OAK.MouseHover
        If Max >= 3 Then
            LowerSection += Sum
            GrandTotal += Sum
            txt3OAK.Text = CStr(Sum)
        Else
            txt3OAK.Text = "0"
        End If
    End Sub

    Private Sub btn3OAK_MouseLeave(sender As Object, e As EventArgs) Handles btn3OAK.MouseLeave
        txt3OAK.Text = ""
    End Sub

    Private Sub btn4OAK_MouseHover(sender As Object, e As EventArgs) Handles btn4OAK.MouseHover
        If Max >= 4 Then
            LowerSection += Sum
            GrandTotal += Sum
            txt4OAK.Text = CStr(Sum)
        Else
            txt4OAK.Text = "0"
        End If
    End Sub

    Private Sub btn4OAK_MouseLeave(sender As Object, e As EventArgs) Handles btn4OAK.MouseLeave
        txt4OAK.Text = ""
    End Sub

    Private Sub btnFullHouse_MouseHover(sender As Object, e As EventArgs) Handles btnFullHouse.MouseHover
        If Max = 3 And Zero = 4 Then
            LowerSection += 25
            GrandTotal += 25
            txtFullHouse.Text = "25"
        Else
            txtFullHouse.Text = "0"
        End If
    End Sub

    Private Sub btnFullHouse_MouseLeave(sender As Object, e As EventArgs) Handles btnFullHouse.MouseLeave
        txtFullHouse.Text = ""
    End Sub

    Private Sub btnSeq4_MouseHover(sender As Object, e As EventArgs) Handles btnSeq4.MouseHover
        If (TallyArray(0) >= 1 And TallyArray(1) >= 1 And TallyArray(2) >= 1 And TallyArray(3) >= 1) Or
           (TallyArray(1) >= 1 And TallyArray(2) >= 1 And TallyArray(3) >= 1 And TallyArray(4) >= 1) Or
           (TallyArray(2) >= 1 And TallyArray(3) >= 1 And TallyArray(4) >= 1 And TallyArray(5) >= 1) Then
            LowerSection += 30
            GrandTotal += 30
            txtSeq4.Text = "30"
        Else
            txtSeq4.Text = "0"
        End If
    End Sub

    Private Sub btnSeq4_MouseLeave(sender As Object, e As EventArgs) Handles btnSeq4.MouseLeave
        txtSeq4.Text = ""
    End Sub

    Private Sub btnSeq5_MouseHover(sender As Object, e As EventArgs) Handles btnSeq5.MouseHover
        If Max = 1 And (TallyArray(0) = 0 Or TallyArray(5) = 0) Then
            txtSeq5.Text = "40"
        Else
            txtSeq5.Text = "0"
        End If
    End Sub

    Private Sub btnSeq5_MouseLeave(sender As Object, e As EventArgs) Handles btnSeq5.MouseLeave
        txtSeq5.Text = ""
    End Sub

    Private Sub btnYahtzee_MouseHover(sender As Object, e As EventArgs) Handles btnYahtzee.MouseHover
        If Max = 5 Then
            LowerSection += 50
            GrandTotal += 50
            txtYahtzee.Text = "50"
        Else
            txtYahtzee.Text = "0"
        End If
    End Sub

    Private Sub btnYahtzee_MouseLeave(sender As Object, e As EventArgs) Handles btnYahtzee.MouseLeave
        txtYahtzee.Text = ""
    End Sub

    Private Sub btnChance_MouseHover(sender As Object, e As EventArgs) Handles btnChance.MouseHover
        txtChance.Text = CStr(Sum)
    End Sub

    Private Sub btnChance_MouseLeave(sender As Object, e As EventArgs) Handles btnChance.MouseLeave
        txtChance.Text = ""
    End Sub
End Class
