<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYahtzee
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYahtzee))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSixes = New System.Windows.Forms.Button()
        Me.btnFives = New System.Windows.Forms.Button()
        Me.btnFours = New System.Windows.Forms.Button()
        Me.btnThrees = New System.Windows.Forms.Button()
        Me.btnTwos = New System.Windows.Forms.Button()
        Me.btnAces = New System.Windows.Forms.Button()
        Me.txtTotalUpperSection = New System.Windows.Forms.TextBox()
        Me.txtUpperSectionBonus = New System.Windows.Forms.TextBox()
        Me.txtTotalScore = New System.Windows.Forms.TextBox()
        Me.txtSixes = New System.Windows.Forms.TextBox()
        Me.txtFives = New System.Windows.Forms.TextBox()
        Me.txtFours = New System.Windows.Forms.TextBox()
        Me.txtThrees = New System.Windows.Forms.TextBox()
        Me.txtTwos = New System.Windows.Forms.TextBox()
        Me.txtAces = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnChance = New System.Windows.Forms.Button()
        Me.btnYahtzee = New System.Windows.Forms.Button()
        Me.btnSeq5 = New System.Windows.Forms.Button()
        Me.btnSeq4 = New System.Windows.Forms.Button()
        Me.btnFullHouse = New System.Windows.Forms.Button()
        Me.btn4OAK = New System.Windows.Forms.Button()
        Me.btn3OAK = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalLowerScore = New System.Windows.Forms.TextBox()
        Me.txtYtzBonus = New System.Windows.Forms.TextBox()
        Me.txtChance = New System.Windows.Forms.TextBox()
        Me.txtYahtzee = New System.Windows.Forms.TextBox()
        Me.txtSeq5 = New System.Windows.Forms.TextBox()
        Me.txtSeq4 = New System.Windows.Forms.TextBox()
        Me.txtFullHouse = New System.Windows.Forms.TextBox()
        Me.txt4OAK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt3OAK = New System.Windows.Forms.TextBox()
        Me.chkRoll5 = New System.Windows.Forms.CheckBox()
        Me.chkRoll4 = New System.Windows.Forms.CheckBox()
        Me.chkRoll3 = New System.Windows.Forms.CheckBox()
        Me.chkRoll2 = New System.Windows.Forms.CheckBox()
        Me.chkRoll1 = New System.Windows.Forms.CheckBox()
        Me.btnRollEm = New System.Windows.Forms.Button()
        Me.pbxDie5 = New System.Windows.Forms.PictureBox()
        Me.pbxDie4 = New System.Windows.Forms.PictureBox()
        Me.pbxDie3 = New System.Windows.Forms.PictureBox()
        Me.pbxDie2 = New System.Windows.Forms.PictureBox()
        Me.pbxDie1 = New System.Windows.Forms.PictureBox()
        Me.imlDiceList = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGameNewGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHighScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGameQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpHowToPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrRoll = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTipAces = New System.Windows.Forms.ToolTip(Me.components)
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbxDie5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDie4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox1.Controls.Add(Me.btnSixes)
        Me.GroupBox1.Controls.Add(Me.btnFives)
        Me.GroupBox1.Controls.Add(Me.btnFours)
        Me.GroupBox1.Controls.Add(Me.btnThrees)
        Me.GroupBox1.Controls.Add(Me.btnTwos)
        Me.GroupBox1.Controls.Add(Me.btnAces)
        Me.GroupBox1.Controls.Add(Me.txtTotalUpperSection)
        Me.GroupBox1.Controls.Add(Me.txtUpperSectionBonus)
        Me.GroupBox1.Controls.Add(Me.txtTotalScore)
        Me.GroupBox1.Controls.Add(Me.txtSixes)
        Me.GroupBox1.Controls.Add(Me.txtFives)
        Me.GroupBox1.Controls.Add(Me.txtFours)
        Me.GroupBox1.Controls.Add(Me.txtThrees)
        Me.GroupBox1.Controls.Add(Me.txtTwos)
        Me.GroupBox1.Controls.Add(Me.txtAces)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(383, 383)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Upper Section"
        '
        'btnSixes
        '
        Me.btnSixes.Enabled = False
        Me.btnSixes.Location = New System.Drawing.Point(31, 239)
        Me.btnSixes.Name = "btnSixes"
        Me.btnSixes.Size = New System.Drawing.Size(87, 25)
        Me.btnSixes.TabIndex = 18
        Me.btnSixes.Text = "Sixes"
        Me.btnSixes.UseVisualStyleBackColor = True
        '
        'btnFives
        '
        Me.btnFives.Enabled = False
        Me.btnFives.Location = New System.Drawing.Point(31, 201)
        Me.btnFives.Name = "btnFives"
        Me.btnFives.Size = New System.Drawing.Size(87, 25)
        Me.btnFives.TabIndex = 17
        Me.btnFives.Text = "Fives"
        Me.btnFives.UseVisualStyleBackColor = True
        '
        'btnFours
        '
        Me.btnFours.Enabled = False
        Me.btnFours.Location = New System.Drawing.Point(31, 163)
        Me.btnFours.Name = "btnFours"
        Me.btnFours.Size = New System.Drawing.Size(87, 25)
        Me.btnFours.TabIndex = 16
        Me.btnFours.Text = "Fours"
        Me.btnFours.UseVisualStyleBackColor = True
        '
        'btnThrees
        '
        Me.btnThrees.Enabled = False
        Me.btnThrees.Location = New System.Drawing.Point(31, 122)
        Me.btnThrees.Name = "btnThrees"
        Me.btnThrees.Size = New System.Drawing.Size(87, 25)
        Me.btnThrees.TabIndex = 15
        Me.btnThrees.Text = "Threes"
        Me.btnThrees.UseVisualStyleBackColor = True
        '
        'btnTwos
        '
        Me.btnTwos.Enabled = False
        Me.btnTwos.Location = New System.Drawing.Point(31, 85)
        Me.btnTwos.Name = "btnTwos"
        Me.btnTwos.Size = New System.Drawing.Size(87, 25)
        Me.btnTwos.TabIndex = 14
        Me.btnTwos.Text = "Twos"
        Me.btnTwos.UseVisualStyleBackColor = True
        '
        'btnAces
        '
        Me.btnAces.Enabled = False
        Me.btnAces.Location = New System.Drawing.Point(31, 47)
        Me.btnAces.Name = "btnAces"
        Me.btnAces.Size = New System.Drawing.Size(87, 25)
        Me.btnAces.TabIndex = 13
        Me.btnAces.Text = "Aces"
        Me.btnAces.UseVisualStyleBackColor = True
        '
        'txtTotalUpperSection
        '
        Me.txtTotalUpperSection.Location = New System.Drawing.Point(212, 353)
        Me.txtTotalUpperSection.Name = "txtTotalUpperSection"
        Me.txtTotalUpperSection.ReadOnly = True
        Me.txtTotalUpperSection.Size = New System.Drawing.Size(116, 22)
        Me.txtTotalUpperSection.TabIndex = 12
        '
        'txtUpperSectionBonus
        '
        Me.txtUpperSectionBonus.Location = New System.Drawing.Point(212, 315)
        Me.txtUpperSectionBonus.Name = "txtUpperSectionBonus"
        Me.txtUpperSectionBonus.ReadOnly = True
        Me.txtUpperSectionBonus.Size = New System.Drawing.Size(116, 22)
        Me.txtUpperSectionBonus.TabIndex = 11
        '
        'txtTotalScore
        '
        Me.txtTotalScore.Location = New System.Drawing.Point(212, 277)
        Me.txtTotalScore.Name = "txtTotalScore"
        Me.txtTotalScore.ReadOnly = True
        Me.txtTotalScore.Size = New System.Drawing.Size(116, 22)
        Me.txtTotalScore.TabIndex = 10
        '
        'txtSixes
        '
        Me.txtSixes.Location = New System.Drawing.Point(212, 239)
        Me.txtSixes.Name = "txtSixes"
        Me.txtSixes.ReadOnly = True
        Me.txtSixes.Size = New System.Drawing.Size(116, 22)
        Me.txtSixes.TabIndex = 9
        '
        'txtFives
        '
        Me.txtFives.Location = New System.Drawing.Point(212, 201)
        Me.txtFives.Name = "txtFives"
        Me.txtFives.ReadOnly = True
        Me.txtFives.Size = New System.Drawing.Size(116, 22)
        Me.txtFives.TabIndex = 8
        '
        'txtFours
        '
        Me.txtFours.Location = New System.Drawing.Point(212, 163)
        Me.txtFours.Name = "txtFours"
        Me.txtFours.ReadOnly = True
        Me.txtFours.Size = New System.Drawing.Size(116, 22)
        Me.txtFours.TabIndex = 7
        '
        'txtThrees
        '
        Me.txtThrees.Location = New System.Drawing.Point(212, 125)
        Me.txtThrees.Name = "txtThrees"
        Me.txtThrees.ReadOnly = True
        Me.txtThrees.Size = New System.Drawing.Size(116, 22)
        Me.txtThrees.TabIndex = 6
        '
        'txtTwos
        '
        Me.txtTwos.Location = New System.Drawing.Point(212, 85)
        Me.txtTwos.Name = "txtTwos"
        Me.txtTwos.ReadOnly = True
        Me.txtTwos.Size = New System.Drawing.Size(116, 22)
        Me.txtTwos.TabIndex = 5
        '
        'txtAces
        '
        Me.txtAces.Location = New System.Drawing.Point(212, 48)
        Me.txtAces.Name = "txtAces"
        Me.txtAces.ReadOnly = True
        Me.txtAces.Size = New System.Drawing.Size(116, 22)
        Me.txtAces.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total of upper section: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bonus:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total score:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox2.Controls.Add(Me.btnChance)
        Me.GroupBox2.Controls.Add(Me.btnYahtzee)
        Me.GroupBox2.Controls.Add(Me.btnSeq5)
        Me.GroupBox2.Controls.Add(Me.btnSeq4)
        Me.GroupBox2.Controls.Add(Me.btnFullHouse)
        Me.GroupBox2.Controls.Add(Me.btn4OAK)
        Me.GroupBox2.Controls.Add(Me.btn3OAK)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtGrandTotal)
        Me.GroupBox2.Controls.Add(Me.txtTotalLowerScore)
        Me.GroupBox2.Controls.Add(Me.txtYtzBonus)
        Me.GroupBox2.Controls.Add(Me.txtChance)
        Me.GroupBox2.Controls.Add(Me.txtYahtzee)
        Me.GroupBox2.Controls.Add(Me.txtSeq5)
        Me.GroupBox2.Controls.Add(Me.txtSeq4)
        Me.GroupBox2.Controls.Add(Me.txtFullHouse)
        Me.GroupBox2.Controls.Add(Me.txt4OAK)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt3OAK)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(460, 47)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(369, 435)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lower Section"
        '
        'btnChance
        '
        Me.btnChance.Enabled = False
        Me.btnChance.Location = New System.Drawing.Point(14, 276)
        Me.btnChance.Name = "btnChance"
        Me.btnChance.Size = New System.Drawing.Size(131, 25)
        Me.btnChance.TabIndex = 23
        Me.btnChance.Text = "Chance"
        Me.btnChance.UseVisualStyleBackColor = True
        '
        'btnYahtzee
        '
        Me.btnYahtzee.Enabled = False
        Me.btnYahtzee.Location = New System.Drawing.Point(14, 238)
        Me.btnYahtzee.Name = "btnYahtzee"
        Me.btnYahtzee.Size = New System.Drawing.Size(131, 25)
        Me.btnYahtzee.TabIndex = 22
        Me.btnYahtzee.Text = "Yahtzee"
        Me.btnYahtzee.UseVisualStyleBackColor = True
        '
        'btnSeq5
        '
        Me.btnSeq5.Enabled = False
        Me.btnSeq5.Location = New System.Drawing.Point(14, 197)
        Me.btnSeq5.Name = "btnSeq5"
        Me.btnSeq5.Size = New System.Drawing.Size(131, 25)
        Me.btnSeq5.TabIndex = 21
        Me.btnSeq5.Text = "Sequence of 5"
        Me.btnSeq5.UseVisualStyleBackColor = True
        '
        'btnSeq4
        '
        Me.btnSeq4.Enabled = False
        Me.btnSeq4.Location = New System.Drawing.Point(14, 163)
        Me.btnSeq4.Name = "btnSeq4"
        Me.btnSeq4.Size = New System.Drawing.Size(131, 25)
        Me.btnSeq4.TabIndex = 20
        Me.btnSeq4.Text = "Sequence of 4"
        Me.btnSeq4.UseVisualStyleBackColor = True
        '
        'btnFullHouse
        '
        Me.btnFullHouse.Enabled = False
        Me.btnFullHouse.Location = New System.Drawing.Point(14, 126)
        Me.btnFullHouse.Name = "btnFullHouse"
        Me.btnFullHouse.Size = New System.Drawing.Size(131, 25)
        Me.btnFullHouse.TabIndex = 19
        Me.btnFullHouse.Text = "Full House"
        Me.btnFullHouse.UseVisualStyleBackColor = True
        '
        'btn4OAK
        '
        Me.btn4OAK.Enabled = False
        Me.btn4OAK.Location = New System.Drawing.Point(14, 84)
        Me.btn4OAK.Name = "btn4OAK"
        Me.btn4OAK.Size = New System.Drawing.Size(131, 25)
        Me.btn4OAK.TabIndex = 18
        Me.btn4OAK.Text = "4 of a kind"
        Me.btn4OAK.UseVisualStyleBackColor = True
        '
        'btn3OAK
        '
        Me.btn3OAK.Enabled = False
        Me.btn3OAK.Location = New System.Drawing.Point(14, 45)
        Me.btn3OAK.Name = "btn3OAK"
        Me.btn3OAK.Size = New System.Drawing.Size(131, 25)
        Me.btn3OAK.TabIndex = 17
        Me.btn3OAK.Text = "3 of a kind"
        Me.btn3OAK.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Grand Total: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Total of lower score: "
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Location = New System.Drawing.Point(198, 390)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(116, 22)
        Me.txtGrandTotal.TabIndex = 14
        '
        'txtTotalLowerScore
        '
        Me.txtTotalLowerScore.Location = New System.Drawing.Point(198, 352)
        Me.txtTotalLowerScore.Name = "txtTotalLowerScore"
        Me.txtTotalLowerScore.ReadOnly = True
        Me.txtTotalLowerScore.Size = New System.Drawing.Size(116, 22)
        Me.txtTotalLowerScore.TabIndex = 13
        '
        'txtYtzBonus
        '
        Me.txtYtzBonus.Location = New System.Drawing.Point(198, 314)
        Me.txtYtzBonus.Name = "txtYtzBonus"
        Me.txtYtzBonus.ReadOnly = True
        Me.txtYtzBonus.Size = New System.Drawing.Size(116, 22)
        Me.txtYtzBonus.TabIndex = 12
        '
        'txtChance
        '
        Me.txtChance.Location = New System.Drawing.Point(198, 276)
        Me.txtChance.Name = "txtChance"
        Me.txtChance.ReadOnly = True
        Me.txtChance.Size = New System.Drawing.Size(116, 22)
        Me.txtChance.TabIndex = 11
        '
        'txtYahtzee
        '
        Me.txtYahtzee.Location = New System.Drawing.Point(198, 238)
        Me.txtYahtzee.Name = "txtYahtzee"
        Me.txtYahtzee.ReadOnly = True
        Me.txtYahtzee.Size = New System.Drawing.Size(116, 22)
        Me.txtYahtzee.TabIndex = 10
        '
        'txtSeq5
        '
        Me.txtSeq5.Location = New System.Drawing.Point(198, 200)
        Me.txtSeq5.Name = "txtSeq5"
        Me.txtSeq5.ReadOnly = True
        Me.txtSeq5.Size = New System.Drawing.Size(116, 22)
        Me.txtSeq5.TabIndex = 9
        '
        'txtSeq4
        '
        Me.txtSeq4.Location = New System.Drawing.Point(198, 160)
        Me.txtSeq4.Name = "txtSeq4"
        Me.txtSeq4.ReadOnly = True
        Me.txtSeq4.Size = New System.Drawing.Size(116, 22)
        Me.txtSeq4.TabIndex = 8
        '
        'txtFullHouse
        '
        Me.txtFullHouse.Location = New System.Drawing.Point(198, 123)
        Me.txtFullHouse.Name = "txtFullHouse"
        Me.txtFullHouse.ReadOnly = True
        Me.txtFullHouse.Size = New System.Drawing.Size(116, 22)
        Me.txtFullHouse.TabIndex = 7
        '
        'txt4OAK
        '
        Me.txt4OAK.Location = New System.Drawing.Point(198, 85)
        Me.txt4OAK.Name = "txt4OAK"
        Me.txt4OAK.ReadOnly = True
        Me.txt4OAK.Size = New System.Drawing.Size(116, 22)
        Me.txt4OAK.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Yahtzee Bonus"
        '
        'txt3OAK
        '
        Me.txt3OAK.Location = New System.Drawing.Point(198, 47)
        Me.txt3OAK.Name = "txt3OAK"
        Me.txt3OAK.ReadOnly = True
        Me.txt3OAK.Size = New System.Drawing.Size(116, 22)
        Me.txt3OAK.TabIndex = 5
        '
        'chkRoll5
        '
        Me.chkRoll5.AutoSize = True
        Me.chkRoll5.BackColor = System.Drawing.Color.Red
        Me.chkRoll5.Checked = True
        Me.chkRoll5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRoll5.Enabled = False
        Me.chkRoll5.Location = New System.Drawing.Point(540, 574)
        Me.chkRoll5.Name = "chkRoll5"
        Me.chkRoll5.Size = New System.Drawing.Size(48, 19)
        Me.chkRoll5.TabIndex = 101
        Me.chkRoll5.Text = "Roll"
        Me.chkRoll5.UseVisualStyleBackColor = False
        '
        'chkRoll4
        '
        Me.chkRoll4.AutoSize = True
        Me.chkRoll4.BackColor = System.Drawing.Color.Red
        Me.chkRoll4.Checked = True
        Me.chkRoll4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRoll4.Enabled = False
        Me.chkRoll4.Location = New System.Drawing.Point(416, 574)
        Me.chkRoll4.Name = "chkRoll4"
        Me.chkRoll4.Size = New System.Drawing.Size(48, 19)
        Me.chkRoll4.TabIndex = 100
        Me.chkRoll4.Text = "Roll"
        Me.chkRoll4.UseVisualStyleBackColor = False
        '
        'chkRoll3
        '
        Me.chkRoll3.AutoSize = True
        Me.chkRoll3.BackColor = System.Drawing.Color.Red
        Me.chkRoll3.Checked = True
        Me.chkRoll3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRoll3.Enabled = False
        Me.chkRoll3.Location = New System.Drawing.Point(292, 574)
        Me.chkRoll3.Name = "chkRoll3"
        Me.chkRoll3.Size = New System.Drawing.Size(48, 19)
        Me.chkRoll3.TabIndex = 99
        Me.chkRoll3.Text = "Roll"
        Me.chkRoll3.UseVisualStyleBackColor = False
        '
        'chkRoll2
        '
        Me.chkRoll2.AutoSize = True
        Me.chkRoll2.BackColor = System.Drawing.Color.Red
        Me.chkRoll2.Checked = True
        Me.chkRoll2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRoll2.Enabled = False
        Me.chkRoll2.Location = New System.Drawing.Point(162, 574)
        Me.chkRoll2.Name = "chkRoll2"
        Me.chkRoll2.Size = New System.Drawing.Size(48, 19)
        Me.chkRoll2.TabIndex = 98
        Me.chkRoll2.Text = "Roll"
        Me.chkRoll2.UseVisualStyleBackColor = False
        '
        'chkRoll1
        '
        Me.chkRoll1.AutoSize = True
        Me.chkRoll1.BackColor = System.Drawing.Color.Red
        Me.chkRoll1.Checked = True
        Me.chkRoll1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRoll1.Enabled = False
        Me.chkRoll1.Location = New System.Drawing.Point(39, 574)
        Me.chkRoll1.Name = "chkRoll1"
        Me.chkRoll1.Size = New System.Drawing.Size(48, 19)
        Me.chkRoll1.TabIndex = 97
        Me.chkRoll1.Text = "Roll"
        Me.chkRoll1.UseVisualStyleBackColor = False
        '
        'btnRollEm
        '
        Me.btnRollEm.Location = New System.Drawing.Point(701, 508)
        Me.btnRollEm.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnRollEm.Name = "btnRollEm"
        Me.btnRollEm.Size = New System.Drawing.Size(114, 58)
        Me.btnRollEm.TabIndex = 96
        Me.btnRollEm.Text = "Roll Em"
        Me.btnRollEm.UseVisualStyleBackColor = True
        '
        'pbxDie5
        '
        Me.pbxDie5.BackColor = System.Drawing.Color.White
        Me.pbxDie5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxDie5.Location = New System.Drawing.Point(544, 508)
        Me.pbxDie5.Margin = New System.Windows.Forms.Padding(5)
        Me.pbxDie5.Name = "pbxDie5"
        Me.pbxDie5.Size = New System.Drawing.Size(100, 50)
        Me.pbxDie5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxDie5.TabIndex = 95
        Me.pbxDie5.TabStop = False
        '
        'pbxDie4
        '
        Me.pbxDie4.BackColor = System.Drawing.Color.White
        Me.pbxDie4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxDie4.Location = New System.Drawing.Point(418, 508)
        Me.pbxDie4.Margin = New System.Windows.Forms.Padding(5)
        Me.pbxDie4.Name = "pbxDie4"
        Me.pbxDie4.Size = New System.Drawing.Size(100, 50)
        Me.pbxDie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxDie4.TabIndex = 94
        Me.pbxDie4.TabStop = False
        '
        'pbxDie3
        '
        Me.pbxDie3.BackColor = System.Drawing.Color.White
        Me.pbxDie3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxDie3.Location = New System.Drawing.Point(292, 508)
        Me.pbxDie3.Margin = New System.Windows.Forms.Padding(5)
        Me.pbxDie3.Name = "pbxDie3"
        Me.pbxDie3.Size = New System.Drawing.Size(100, 50)
        Me.pbxDie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxDie3.TabIndex = 93
        Me.pbxDie3.TabStop = False
        '
        'pbxDie2
        '
        Me.pbxDie2.BackColor = System.Drawing.Color.White
        Me.pbxDie2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxDie2.Location = New System.Drawing.Point(166, 508)
        Me.pbxDie2.Margin = New System.Windows.Forms.Padding(5)
        Me.pbxDie2.Name = "pbxDie2"
        Me.pbxDie2.Size = New System.Drawing.Size(100, 50)
        Me.pbxDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxDie2.TabIndex = 92
        Me.pbxDie2.TabStop = False
        '
        'pbxDie1
        '
        Me.pbxDie1.BackColor = System.Drawing.Color.White
        Me.pbxDie1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxDie1.Location = New System.Drawing.Point(40, 508)
        Me.pbxDie1.Margin = New System.Windows.Forms.Padding(5)
        Me.pbxDie1.Name = "pbxDie1"
        Me.pbxDie1.Size = New System.Drawing.Size(100, 50)
        Me.pbxDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxDie1.TabIndex = 91
        Me.pbxDie1.TabStop = False
        '
        'imlDiceList
        '
        Me.imlDiceList.ImageStream = CType(resources.GetObject("imlDiceList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlDiceList.TransparentColor = System.Drawing.Color.Transparent
        Me.imlDiceList.Images.SetKeyName(0, "Die1.BMP")
        Me.imlDiceList.Images.SetKeyName(1, "Die2.BMP")
        Me.imlDiceList.Images.SetKeyName(2, "Die3.BMP")
        Me.imlDiceList.Images.SetKeyName(3, "Die4.BMP")
        Me.imlDiceList.Images.SetKeyName(4, "Die5.BMP")
        Me.imlDiceList.Images.SetKeyName(5, "Die6.BMP")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(869, 24)
        Me.MenuStrip1.TabIndex = 108
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGameNewGame, Me.UndoToolStripMenuItem, Me.ShowHighScoresToolStripMenuItem, Me.mnuGameQuit})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'mnuGameNewGame
        '
        Me.mnuGameNewGame.Name = "mnuGameNewGame"
        Me.mnuGameNewGame.Size = New System.Drawing.Size(169, 22)
        Me.mnuGameNewGame.Text = "New Game"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'ShowHighScoresToolStripMenuItem
        '
        Me.ShowHighScoresToolStripMenuItem.Name = "ShowHighScoresToolStripMenuItem"
        Me.ShowHighScoresToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ShowHighScoresToolStripMenuItem.Text = "Show High Scores"
        '
        'mnuGameQuit
        '
        Me.mnuGameQuit.Name = "mnuGameQuit"
        Me.mnuGameQuit.Size = New System.Drawing.Size(169, 22)
        Me.mnuGameQuit.Text = "Quit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpHowToPlay, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'mnuHelpHowToPlay
        '
        Me.mnuHelpHowToPlay.Name = "mnuHelpHowToPlay"
        Me.mnuHelpHowToPlay.Size = New System.Drawing.Size(138, 22)
        Me.mnuHelpHowToPlay.Text = "How to Play"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'tmrRoll
        '
        '
        'ToolTipAces
        '
        Me.ToolTipAces.AutoPopDelay = 5000
        Me.ToolTipAces.InitialDelay = 500
        Me.ToolTipAces.ReshowDelay = 500
        Me.ToolTipAces.ShowAlways = True
        Me.ToolTipAces.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'nameLabel
        '
        Me.nameLabel.BackColor = System.Drawing.Color.AliceBlue
        Me.nameLabel.Location = New System.Drawing.Point(166, 437)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(252, 66)
        Me.nameLabel.TabIndex = 109
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(81, 454)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 15)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "High Score"
        '
        'frmYahtzee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(869, 627)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.chkRoll5)
        Me.Controls.Add(Me.chkRoll4)
        Me.Controls.Add(Me.chkRoll3)
        Me.Controls.Add(Me.chkRoll2)
        Me.Controls.Add(Me.chkRoll1)
        Me.Controls.Add(Me.btnRollEm)
        Me.Controls.Add(Me.pbxDie5)
        Me.Controls.Add(Me.pbxDie4)
        Me.Controls.Add(Me.pbxDie3)
        Me.Controls.Add(Me.pbxDie2)
        Me.Controls.Add(Me.pbxDie1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmYahtzee"
        Me.Text = "Yahtzee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbxDie5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDie4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSixes As System.Windows.Forms.Button
    Friend WithEvents btnFives As System.Windows.Forms.Button
    Friend WithEvents btnFours As System.Windows.Forms.Button
    Friend WithEvents btnThrees As System.Windows.Forms.Button
    Friend WithEvents btnTwos As System.Windows.Forms.Button
    Friend WithEvents btnAces As System.Windows.Forms.Button
    Friend WithEvents txtTotalUpperSection As System.Windows.Forms.TextBox
    Friend WithEvents txtUpperSectionBonus As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalScore As System.Windows.Forms.TextBox
    Friend WithEvents txtSixes As System.Windows.Forms.TextBox
    Friend WithEvents txtFives As System.Windows.Forms.TextBox
    Friend WithEvents txtFours As System.Windows.Forms.TextBox
    Friend WithEvents txtThrees As System.Windows.Forms.TextBox
    Friend WithEvents txtTwos As System.Windows.Forms.TextBox
    Friend WithEvents txtAces As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnChance As System.Windows.Forms.Button
    Friend WithEvents btnYahtzee As System.Windows.Forms.Button
    Friend WithEvents btnSeq5 As System.Windows.Forms.Button
    Friend WithEvents btnSeq4 As System.Windows.Forms.Button
    Friend WithEvents btnFullHouse As System.Windows.Forms.Button
    Friend WithEvents btn4OAK As System.Windows.Forms.Button
    Friend WithEvents btn3OAK As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalLowerScore As System.Windows.Forms.TextBox
    Friend WithEvents txtYtzBonus As System.Windows.Forms.TextBox
    Friend WithEvents txtChance As System.Windows.Forms.TextBox
    Friend WithEvents txtYahtzee As System.Windows.Forms.TextBox
    Friend WithEvents txtSeq5 As System.Windows.Forms.TextBox
    Friend WithEvents txtSeq4 As System.Windows.Forms.TextBox
    Friend WithEvents txtFullHouse As System.Windows.Forms.TextBox
    Friend WithEvents txt4OAK As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt3OAK As System.Windows.Forms.TextBox
    Friend WithEvents chkRoll5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRoll4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRoll3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRoll2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRoll1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnRollEm As System.Windows.Forms.Button
    Friend WithEvents pbxDie5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxDie4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxDie3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxDie2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxDie1 As System.Windows.Forms.PictureBox
    Friend WithEvents imlDiceList As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGameNewGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowHighScoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGameQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpHowToPlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
    Friend WithEvents tmrRoll As System.Windows.Forms.Timer
    Friend WithEvents ToolTipAces As System.Windows.Forms.ToolTip
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
