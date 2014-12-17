Imports System.IO
Public Class frmShowHighScores
    
    Private Sub frmShowHighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'define variables to display High Score sheet
        Dim readScoreFile As StreamReader
        Dim readScoreHistory As StreamReader
        Dim readplayerNameFile As StreamReader
        Dim HighScore As String
        Dim playerName As String
        Dim scoreHistory As String

        'open holdHighScore.txt to read what standing high score was
        readScoreFile = File.OpenText("holdHighScore.txt")
        'put score into variable
        HighScore = readScoreFile.ReadLine()
        'close file
        readScoreFile.Close()
        readScoreFile.Dispose()

        'open playerName.txt to read what player's name was
        readplayerNameFile = File.OpenText("playerName.txt")
        'put name into variable
        playerName = readplayerNameFile.ReadLine()
        'close file
        readplayerNameFile.Close()
        readplayerNameFile.Dispose()

        'print to output box
        lblCurrentHighScore.Text = "Top player: " & playerName & ": " & HighScore & " points"

        Try
            'open HighScore.txt to read appended history
            readScoreHistory = File.OpenText("HighScore.txt")

            'put score history into variable
            Do Until readScoreHistory.EndOfStream
                scoreHistory = readScoreHistory.ReadLine()
                'display in listbox
                lstHighScores.Items.Add(scoreHistory)
            Loop
            'close file
            readScoreFile.Close()
            readScoreFile.Dispose()
        Catch
            MessageBox.Show("Error in displaying High Score History.")
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        'clear listbox
        lstHighScores.Items.Clear()
    End Sub
End Class