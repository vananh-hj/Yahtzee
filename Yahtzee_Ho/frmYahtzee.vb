Public Class frmYahtzee
    'define variables for die rolls
    Dim randNumber As New Random
    Dim RollCount As Integer = 0
    Dim DieValueArray(5) As Integer

    'define variables for sub-scores
    Dim TallyArray(6)
    Dim Max As Integer = 9
    Dim Zero As Integer
    Dim Sum As Integer

    'define upper section, lower section, total, and grandTotal scores
    Dim LowerSection As Integer = 0
    Dim UpperSection As Integer = 0 'includes bonus
    Dim TotalScore As Integer = 0
    Dim GrandTotal As Integer = 0

    'define upper section bonus 
    Dim UpperSectionBonus As Integer = 35

    'define round count
    Dim RoundCount As Integer

    Private Sub btnRollEm_Click(sender As Object, e As EventArgs) Handles btnRollEm.Click
        Dim checkboxArray As CheckBox() = {chkRoll1, chkRoll2, chkRoll3, chkRoll4, chkRoll5}

        'randomly roll selected die and change image accordingly
        For k = 0 To 4
            If checkboxArray(k).Checked Then
                DieValueArray(k) = randNumber.Next(6) + 1
                DiceImageChange(k)
            End If
        Next

        'Update button text / availability
        RollCount += 1
        If RollCount = 1 Then
            btnRollEm.Text = "Roll Em 1/3"
            EnableChkBoxes()
        ElseIf RollCount = 2 Then
            btnRollEm.Text = "Roll Em 2/3"
            EnableChkBoxes()
        ElseIf RollCount = 3 Then
            btnRollEm.Enabled = False
            EnableScoreButtons()
            EnableChkBoxes()
            CalcSum()
            CalcTally()
            CalcMax()
            CalcZero()
            btnRollEm.Text = "Must Score"
        End If
    End Sub

    Sub DiceImageChange(dieNum As Integer)
        Dim DieImageArray() As PictureBox = {pbxDie1, pbxDie2, pbxDie3, pbxDie4, pbxDie5}
        DieImageArray(dieNum).Image = imlDiceList.Images(DieValueArray(dieNum) - 1)
    End Sub

    Private Sub btnAces_Click(sender As Object, e As EventArgs) Handles btnAces.Click
        txtAces.Text = CStr(TallyArray(0))
        TotalScore += TallyArray(0)
        GrandTotal += TallyArray(0)
    End Sub

    Private Sub btnTwos_Click(sender As Object, e As EventArgs) Handles btnTwos.Click
        txtTwos.Text = CStr(2 * TallyArray(1))
        TotalScore += 2 * TallyArray(1)
        GrandTotal += 2 * TallyArray(1)
    End Sub

    Private Sub btnThrees_Click(sender As Object, e As EventArgs) Handles btnThrees.Click
        txtThrees.Text = CStr(3 * TallyArray(2))
        TotalScore += 3 * TallyArray(2)
        GrandTotal += 3 * TallyArray(2)
    End Sub

    Private Sub btnFours_Click(sender As Object, e As EventArgs) Handles btnFours.Click
        txtFours.Text = CStr(4 * TallyArray(3))
        TotalScore += 4 * TallyArray(3)
        GrandTotal += 4 * TallyArray(3)
    End Sub

    Private Sub btnFives_Click(sender As Object, e As EventArgs) Handles btnFives.Click
        txtFives.Text = CStr(5 * TallyArray(4))
        TotalScore += 5 * TallyArray(4)
        GrandTotal += 5 * TallyArray(4)
    End Sub

    Private Sub btnSixes_Click(sender As Object, e As EventArgs) Handles btnSixes.Click
        txtSixes.Text = CStr(6 * TallyArray(5))
        TotalScore += 6 * TallyArray(5)
        GrandTotal += 6 * TallyArray(5)
    End Sub

    Private Sub btn3OAK_Click(sender As Object, e As EventArgs) Handles btn3OAK.Click
        If Max >= 3 Then
            GrandTotal += Sum
            txt3OAK.Text = CStr(Sum)
        Else
            txt3OAK.Text = "0"
        End If
    End Sub

    Private Sub btn4OAK_Click(sender As Object, e As EventArgs) Handles btn4OAK.Click
        If Max >= 4 Then
            GrandTotal += Sum
            txt4OAK.Text = CStr(Sum)
        Else
            txt4OAK.Text = "0"
        End If
    End Sub

    Private Sub btnYahtzee_Click(sender As Object, e As EventArgs) Handles btnYahtzee.Click
        If Max = 5 Then
            GrandTotal += 50
            txtYahtzee.Text = "50"
        Else
            txtYahtzee.Text = "0"
        End If
    End Sub

    Private Sub btnFullHouse_Click(sender As Object, e As EventArgs) Handles btnFullHouse.Click
        If Max = 3 And Zero = 4 Then
            GrandTotal += 25
            txtFullHouse.Text = "25"
        Else
            txtFullHouse.Text = "0"
        End If
    End Sub

    Private Sub btnSeq4_Click(sender As Object, e As EventArgs) Handles btnSeq4.Click
        If (TallyArray(0) >= 1 And TallyArray(1) >= 1 And TallyArray(2) >= 1 And TallyArray(3) >= 1) Or
           (TallyArray(1) >= 1 And TallyArray(2) >= 1 And TallyArray(3) >= 1 And TallyArray(4) >= 1) Or
           (TallyArray(2) >= 1 And TallyArray(3) >= 1 And TallyArray(4) >= 1 And TallyArray(5) >= 1) Then
            GrandTotal += 30
            txtSeq4.Text = "30"
        Else
            txtSeq4.Text = "0"
        End If
    End Sub

    Private Sub btnSeq5_Click(sender As Object, e As EventArgs) Handles btnSeq5.Click
        If Max = 1 And (TallyArray(0) = 0 Or TallyArray(5) = 0) Then
            GrandTotal += 40
            txtSeq5.Text = "40"
        Else
            txtSeq5.Text = "0"
        End If
    End Sub

    Private Sub btnChance_Click(sender As Object, e As EventArgs) Handles btnChance.Click
        GrandTotal += Sum
        txtChance.Text = CStr(Sum)
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

    Sub EnableScoreButtons()
        btnAces.Enabled = True
        btnTwos.Enabled = True
        btnThrees.Enabled = True
        btnFours.Enabled = True
        btnFives.Enabled = True
        btnSixes.Enabled = True
        btn3OAK.Enabled = True
        btn4OAK.Enabled = True
        btnChance.Enabled = True
        btnFullHouse.Enabled = True
        btnSeq4.Enabled = True
        btnSeq5.Enabled = True
        btnYahtzee.Enabled = True
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

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub frmYahtzee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbxDie1.Image = imlDiceList.Images(0)
        pbxDie2.Image = imlDiceList.Images(0)
        pbxDie3.Image = imlDiceList.Images(0)
        pbxDie4.Image = imlDiceList.Images(0)
        pbxDie5.Image = imlDiceList.Images(0)
    End Sub

End Class
