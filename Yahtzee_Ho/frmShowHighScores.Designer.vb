<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowHighScores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstHighScores = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCurrentHighScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstHighScores
        '
        Me.lstHighScores.FormattingEnabled = True
        Me.lstHighScores.ItemHeight = 20
        Me.lstHighScores.Location = New System.Drawing.Point(200, 120)
        Me.lstHighScores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstHighScores.Name = "lstHighScores"
        Me.lstHighScores.Size = New System.Drawing.Size(378, 204)
        Me.lstHighScores.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(24, 39)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 22)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Current High Score:"
        '
        'lblCurrentHighScore
        '
        Me.lblCurrentHighScore.BackColor = System.Drawing.Color.AliceBlue
        Me.lblCurrentHighScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentHighScore.Location = New System.Drawing.Point(200, 39)
        Me.lblCurrentHighScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentHighScore.Name = "lblCurrentHighScore"
        Me.lblCurrentHighScore.Size = New System.Drawing.Size(378, 58)
        Me.lblCurrentHighScore.TabIndex = 112
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(24, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 25)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "High Score History:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(200, 352)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(162, 31)
        Me.btnClose.TabIndex = 114
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmShowHighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 402)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCurrentHighScore)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstHighScores)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmShowHighScores"
        Me.Text = "High Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstHighScores As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentHighScore As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
