<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.rbnEasy = New System.Windows.Forms.RadioButton()
        Me.rbnMedium = New System.Windows.Forms.RadioButton()
        Me.rbnHard = New System.Windows.Forms.RadioButton()
        Me.gbxDifficulty = New System.Windows.Forms.GroupBox()
        Me.btnGenerateWord = New System.Windows.Forms.Button()
        Me.gbxLetterToChoose = New System.Windows.Forms.GroupBox()
        Me.lblJ = New System.Windows.Forms.Label()
        Me.lblK = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblW = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblM = New System.Windows.Forms.Label()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.lblV = New System.Windows.Forms.Label()
        Me.lblU = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblQ = New System.Windows.Forms.Label()
        Me.lblP = New System.Windows.Forms.Label()
        Me.lblO = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblI = New System.Windows.Forms.Label()
        Me.lblH = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt8 = New System.Windows.Forms.TextBox()
        Me.txt7 = New System.Windows.Forms.TextBox()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt12 = New System.Windows.Forms.TextBox()
        Me.txt11 = New System.Windows.Forms.TextBox()
        Me.txt10 = New System.Windows.Forms.TextBox()
        Me.txt9 = New System.Windows.Forms.TextBox()
        Me.txt13 = New System.Windows.Forms.TextBox()
        Me.gbxWordToGuess = New System.Windows.Forms.GroupBox()
        Me.lblZombieMan = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblGuesses = New System.Windows.Forms.Label()
        Me.dgvEasy = New System.Windows.Forms.DataGridView()
        Me.WordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EasyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DstEasy = New ZombieMan.dstEasy()
        Me.EasyTableAdapter = New ZombieMan.dstEasyTableAdapters.EasyTableAdapter()
        Me.dgvMedium = New System.Windows.Forms.DataGridView()
        Me.WordDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MediumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DstMedium = New ZombieMan.dstMedium()
        Me.MediumTableAdapter = New ZombieMan.dstMediumTableAdapters.MediumTableAdapter()
        Me.dgvHard = New System.Windows.Forms.DataGridView()
        Me.WordDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DstHard = New ZombieMan.dstHard()
        Me.HardTableAdapter = New ZombieMan.dstHardTableAdapters.HardTableAdapter()
        Me.txtGuessesLeft = New System.Windows.Forms.TextBox()
        Me.pbxZombieGame = New System.Windows.Forms.PictureBox()
        Me.btnShowLeaderboard = New System.Windows.Forms.Button()
        Me.gbxDifficulty.SuspendLayout()
        Me.gbxLetterToChoose.SuspendLayout()
        Me.gbxWordToGuess.SuspendLayout()
        CType(Me.dgvEasy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EasyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DstEasy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMedium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DstMedium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DstHard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxZombieGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbnEasy
        '
        Me.rbnEasy.AutoSize = True
        Me.rbnEasy.Location = New System.Drawing.Point(6, 28)
        Me.rbnEasy.Name = "rbnEasy"
        Me.rbnEasy.Size = New System.Drawing.Size(64, 27)
        Me.rbnEasy.TabIndex = 1
        Me.rbnEasy.TabStop = True
        Me.rbnEasy.Text = "Easy"
        Me.rbnEasy.UseVisualStyleBackColor = True
        '
        'rbnMedium
        '
        Me.rbnMedium.AutoSize = True
        Me.rbnMedium.Location = New System.Drawing.Point(76, 27)
        Me.rbnMedium.Name = "rbnMedium"
        Me.rbnMedium.Size = New System.Drawing.Size(92, 27)
        Me.rbnMedium.TabIndex = 2
        Me.rbnMedium.TabStop = True
        Me.rbnMedium.Text = "Medium"
        Me.rbnMedium.UseVisualStyleBackColor = True
        '
        'rbnHard
        '
        Me.rbnHard.AutoSize = True
        Me.rbnHard.Location = New System.Drawing.Point(174, 28)
        Me.rbnHard.Name = "rbnHard"
        Me.rbnHard.Size = New System.Drawing.Size(66, 27)
        Me.rbnHard.TabIndex = 3
        Me.rbnHard.TabStop = True
        Me.rbnHard.Text = "Hard"
        Me.rbnHard.UseVisualStyleBackColor = True
        '
        'gbxDifficulty
        '
        Me.gbxDifficulty.Controls.Add(Me.rbnEasy)
        Me.gbxDifficulty.Controls.Add(Me.rbnHard)
        Me.gbxDifficulty.Controls.Add(Me.rbnMedium)
        Me.gbxDifficulty.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDifficulty.Location = New System.Drawing.Point(581, 111)
        Me.gbxDifficulty.Name = "gbxDifficulty"
        Me.gbxDifficulty.Size = New System.Drawing.Size(259, 70)
        Me.gbxDifficulty.TabIndex = 4
        Me.gbxDifficulty.TabStop = False
        Me.gbxDifficulty.Text = "Select Difficulty:"
        '
        'btnGenerateWord
        '
        Me.btnGenerateWord.BackColor = System.Drawing.Color.AliceBlue
        Me.btnGenerateWord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnGenerateWord.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGenerateWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateWord.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateWord.Location = New System.Drawing.Point(909, 126)
        Me.btnGenerateWord.Name = "btnGenerateWord"
        Me.btnGenerateWord.Size = New System.Drawing.Size(224, 50)
        Me.btnGenerateWord.TabIndex = 5
        Me.btnGenerateWord.Text = "Generate Word"
        Me.btnGenerateWord.UseVisualStyleBackColor = False
        '
        'gbxLetterToChoose
        '
        Me.gbxLetterToChoose.Controls.Add(Me.lblJ)
        Me.gbxLetterToChoose.Controls.Add(Me.lblK)
        Me.gbxLetterToChoose.Controls.Add(Me.lblL)
        Me.gbxLetterToChoose.Controls.Add(Me.lblX)
        Me.gbxLetterToChoose.Controls.Add(Me.lblW)
        Me.gbxLetterToChoose.Controls.Add(Me.lblY)
        Me.gbxLetterToChoose.Controls.Add(Me.lblM)
        Me.gbxLetterToChoose.Controls.Add(Me.lblZ)
        Me.gbxLetterToChoose.Controls.Add(Me.lblV)
        Me.gbxLetterToChoose.Controls.Add(Me.lblU)
        Me.gbxLetterToChoose.Controls.Add(Me.lblT)
        Me.gbxLetterToChoose.Controls.Add(Me.lblS)
        Me.gbxLetterToChoose.Controls.Add(Me.lblR)
        Me.gbxLetterToChoose.Controls.Add(Me.lblQ)
        Me.gbxLetterToChoose.Controls.Add(Me.lblP)
        Me.gbxLetterToChoose.Controls.Add(Me.lblO)
        Me.gbxLetterToChoose.Controls.Add(Me.lblN)
        Me.gbxLetterToChoose.Controls.Add(Me.lblI)
        Me.gbxLetterToChoose.Controls.Add(Me.lblH)
        Me.gbxLetterToChoose.Controls.Add(Me.lblG)
        Me.gbxLetterToChoose.Controls.Add(Me.lblF)
        Me.gbxLetterToChoose.Controls.Add(Me.lblE)
        Me.gbxLetterToChoose.Controls.Add(Me.lblD)
        Me.gbxLetterToChoose.Controls.Add(Me.lblC)
        Me.gbxLetterToChoose.Controls.Add(Me.lblB)
        Me.gbxLetterToChoose.Controls.Add(Me.lblA)
        Me.gbxLetterToChoose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbxLetterToChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbxLetterToChoose.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxLetterToChoose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbxLetterToChoose.Location = New System.Drawing.Point(581, 377)
        Me.gbxLetterToChoose.Name = "gbxLetterToChoose"
        Me.gbxLetterToChoose.Size = New System.Drawing.Size(608, 133)
        Me.gbxLetterToChoose.TabIndex = 6
        Me.gbxLetterToChoose.TabStop = False
        Me.gbxLetterToChoose.Text = "Letter Board"
        '
        'lblJ
        '
        Me.lblJ.BackColor = System.Drawing.Color.AliceBlue
        Me.lblJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblJ.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJ.Location = New System.Drawing.Point(420, 31)
        Me.lblJ.Name = "lblJ"
        Me.lblJ.Size = New System.Drawing.Size(40, 34)
        Me.lblJ.TabIndex = 32
        Me.lblJ.Text = "J"
        Me.lblJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblK
        '
        Me.lblK.BackColor = System.Drawing.Color.AliceBlue
        Me.lblK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblK.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblK.Location = New System.Drawing.Point(466, 31)
        Me.lblK.Name = "lblK"
        Me.lblK.Size = New System.Drawing.Size(40, 34)
        Me.lblK.TabIndex = 31
        Me.lblK.Text = "K"
        Me.lblK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblL
        '
        Me.lblL.BackColor = System.Drawing.Color.AliceBlue
        Me.lblL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblL.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL.Location = New System.Drawing.Point(512, 31)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(40, 34)
        Me.lblL.TabIndex = 29
        Me.lblL.Text = "L"
        Me.lblL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblX
        '
        Me.lblX.BackColor = System.Drawing.Color.AliceBlue
        Me.lblX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblX.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblX.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(466, 83)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(40, 34)
        Me.lblX.TabIndex = 28
        Me.lblX.Text = "X"
        Me.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblW
        '
        Me.lblW.BackColor = System.Drawing.Color.AliceBlue
        Me.lblW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblW.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblW.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblW.Location = New System.Drawing.Point(420, 83)
        Me.lblW.Name = "lblW"
        Me.lblW.Size = New System.Drawing.Size(40, 34)
        Me.lblW.TabIndex = 30
        Me.lblW.Text = "W"
        Me.lblW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblY
        '
        Me.lblY.BackColor = System.Drawing.Color.AliceBlue
        Me.lblY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblY.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.Location = New System.Drawing.Point(512, 83)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(40, 34)
        Me.lblY.TabIndex = 27
        Me.lblY.Text = "Y"
        Me.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblM
        '
        Me.lblM.BackColor = System.Drawing.Color.AliceBlue
        Me.lblM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblM.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblM.Location = New System.Drawing.Point(558, 31)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(40, 34)
        Me.lblM.TabIndex = 26
        Me.lblM.Text = "M"
        Me.lblM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblZ
        '
        Me.lblZ.BackColor = System.Drawing.Color.AliceBlue
        Me.lblZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblZ.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZ.Location = New System.Drawing.Point(558, 83)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(40, 34)
        Me.lblZ.TabIndex = 25
        Me.lblZ.Text = "Z"
        Me.lblZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblV
        '
        Me.lblV.BackColor = System.Drawing.Color.AliceBlue
        Me.lblV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblV.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblV.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV.Location = New System.Drawing.Point(374, 83)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(40, 34)
        Me.lblV.TabIndex = 24
        Me.lblV.Text = "V"
        Me.lblV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblU
        '
        Me.lblU.BackColor = System.Drawing.Color.AliceBlue
        Me.lblU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblU.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblU.Location = New System.Drawing.Point(328, 83)
        Me.lblU.Name = "lblU"
        Me.lblU.Size = New System.Drawing.Size(40, 34)
        Me.lblU.TabIndex = 23
        Me.lblU.Text = "U"
        Me.lblU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblT
        '
        Me.lblT.BackColor = System.Drawing.Color.AliceBlue
        Me.lblT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblT.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.Location = New System.Drawing.Point(282, 83)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(40, 34)
        Me.lblT.TabIndex = 22
        Me.lblT.Text = "T"
        Me.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblS
        '
        Me.lblS.BackColor = System.Drawing.Color.AliceBlue
        Me.lblS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblS.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.Location = New System.Drawing.Point(236, 83)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(40, 34)
        Me.lblS.TabIndex = 21
        Me.lblS.Text = "S"
        Me.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblR
        '
        Me.lblR.BackColor = System.Drawing.Color.AliceBlue
        Me.lblR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblR.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR.Location = New System.Drawing.Point(190, 83)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(40, 34)
        Me.lblR.TabIndex = 20
        Me.lblR.Text = "R"
        Me.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQ
        '
        Me.lblQ.BackColor = System.Drawing.Color.AliceBlue
        Me.lblQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblQ.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ.Location = New System.Drawing.Point(144, 83)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.Size = New System.Drawing.Size(40, 34)
        Me.lblQ.TabIndex = 19
        Me.lblQ.Text = "Q"
        Me.lblQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP
        '
        Me.lblP.BackColor = System.Drawing.Color.AliceBlue
        Me.lblP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblP.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP.Location = New System.Drawing.Point(98, 83)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(40, 34)
        Me.lblP.TabIndex = 18
        Me.lblP.Text = "P"
        Me.lblP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblO
        '
        Me.lblO.BackColor = System.Drawing.Color.AliceBlue
        Me.lblO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblO.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblO.Location = New System.Drawing.Point(52, 83)
        Me.lblO.Name = "lblO"
        Me.lblO.Size = New System.Drawing.Size(40, 34)
        Me.lblO.TabIndex = 17
        Me.lblO.Text = "O"
        Me.lblO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblN
        '
        Me.lblN.BackColor = System.Drawing.Color.AliceBlue
        Me.lblN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblN.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.Location = New System.Drawing.Point(6, 83)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(40, 34)
        Me.lblN.TabIndex = 16
        Me.lblN.Text = "N"
        Me.lblN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblI
        '
        Me.lblI.BackColor = System.Drawing.Color.AliceBlue
        Me.lblI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblI.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblI.Location = New System.Drawing.Point(374, 31)
        Me.lblI.Name = "lblI"
        Me.lblI.Size = New System.Drawing.Size(40, 34)
        Me.lblI.TabIndex = 15
        Me.lblI.Text = "I"
        Me.lblI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH
        '
        Me.lblH.BackColor = System.Drawing.Color.AliceBlue
        Me.lblH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblH.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblH.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblH.Location = New System.Drawing.Point(328, 31)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(40, 34)
        Me.lblH.TabIndex = 14
        Me.lblH.Text = "H"
        Me.lblH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblG
        '
        Me.lblG.BackColor = System.Drawing.Color.AliceBlue
        Me.lblG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblG.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblG.Location = New System.Drawing.Point(282, 31)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(40, 34)
        Me.lblG.TabIndex = 13
        Me.lblG.Text = "G"
        Me.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblF
        '
        Me.lblF.BackColor = System.Drawing.Color.AliceBlue
        Me.lblF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblF.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF.Location = New System.Drawing.Point(236, 31)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(40, 34)
        Me.lblF.TabIndex = 12
        Me.lblF.Text = "F"
        Me.lblF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblE
        '
        Me.lblE.BackColor = System.Drawing.Color.AliceBlue
        Me.lblE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblE.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE.Location = New System.Drawing.Point(190, 31)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(40, 34)
        Me.lblE.TabIndex = 11
        Me.lblE.Text = "E"
        Me.lblE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD
        '
        Me.lblD.BackColor = System.Drawing.Color.AliceBlue
        Me.lblD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblD.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(144, 31)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(40, 34)
        Me.lblD.TabIndex = 10
        Me.lblD.Text = "D"
        Me.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC
        '
        Me.lblC.BackColor = System.Drawing.Color.AliceBlue
        Me.lblC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblC.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(98, 31)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(40, 34)
        Me.lblC.TabIndex = 9
        Me.lblC.Text = "C"
        Me.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblB
        '
        Me.lblB.BackColor = System.Drawing.Color.AliceBlue
        Me.lblB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblB.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(52, 31)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(40, 34)
        Me.lblB.TabIndex = 8
        Me.lblB.Text = "B"
        Me.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblA
        '
        Me.lblA.BackColor = System.Drawing.Color.AliceBlue
        Me.lblA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblA.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(6, 31)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(40, 34)
        Me.lblA.TabIndex = 7
        Me.lblA.Text = "A"
        Me.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.Color.Gainsboro
        Me.txt1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.ForeColor = System.Drawing.Color.White
        Me.txt1.Location = New System.Drawing.Point(6, 39)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(40, 31)
        Me.txt1.TabIndex = 8
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.Color.Gainsboro
        Me.txt2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.ForeColor = System.Drawing.Color.White
        Me.txt2.Location = New System.Drawing.Point(52, 39)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(40, 31)
        Me.txt2.TabIndex = 9
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4
        '
        Me.txt4.BackColor = System.Drawing.Color.Gainsboro
        Me.txt4.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4.ForeColor = System.Drawing.Color.White
        Me.txt4.Location = New System.Drawing.Point(144, 39)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(40, 31)
        Me.txt4.TabIndex = 11
        Me.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3
        '
        Me.txt3.BackColor = System.Drawing.Color.Gainsboro
        Me.txt3.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.ForeColor = System.Drawing.Color.White
        Me.txt3.Location = New System.Drawing.Point(98, 39)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(40, 31)
        Me.txt3.TabIndex = 10
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt8
        '
        Me.txt8.BackColor = System.Drawing.Color.Gainsboro
        Me.txt8.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8.ForeColor = System.Drawing.Color.White
        Me.txt8.Location = New System.Drawing.Point(328, 39)
        Me.txt8.Name = "txt8"
        Me.txt8.Size = New System.Drawing.Size(40, 31)
        Me.txt8.TabIndex = 15
        Me.txt8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt7
        '
        Me.txt7.BackColor = System.Drawing.Color.Gainsboro
        Me.txt7.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7.ForeColor = System.Drawing.Color.White
        Me.txt7.Location = New System.Drawing.Point(282, 39)
        Me.txt7.Name = "txt7"
        Me.txt7.Size = New System.Drawing.Size(40, 31)
        Me.txt7.TabIndex = 14
        Me.txt7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6
        '
        Me.txt6.BackColor = System.Drawing.Color.Gainsboro
        Me.txt6.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6.ForeColor = System.Drawing.Color.White
        Me.txt6.Location = New System.Drawing.Point(236, 39)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(40, 31)
        Me.txt6.TabIndex = 13
        Me.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5
        '
        Me.txt5.BackColor = System.Drawing.Color.Gainsboro
        Me.txt5.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5.ForeColor = System.Drawing.Color.White
        Me.txt5.Location = New System.Drawing.Point(190, 39)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(40, 31)
        Me.txt5.TabIndex = 12
        Me.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt12
        '
        Me.txt12.BackColor = System.Drawing.Color.Gainsboro
        Me.txt12.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt12.ForeColor = System.Drawing.Color.White
        Me.txt12.Location = New System.Drawing.Point(512, 39)
        Me.txt12.Name = "txt12"
        Me.txt12.Size = New System.Drawing.Size(40, 31)
        Me.txt12.TabIndex = 19
        Me.txt12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt11
        '
        Me.txt11.BackColor = System.Drawing.Color.Gainsboro
        Me.txt11.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt11.ForeColor = System.Drawing.Color.White
        Me.txt11.Location = New System.Drawing.Point(466, 39)
        Me.txt11.Name = "txt11"
        Me.txt11.Size = New System.Drawing.Size(40, 31)
        Me.txt11.TabIndex = 18
        Me.txt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt10
        '
        Me.txt10.BackColor = System.Drawing.Color.Gainsboro
        Me.txt10.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt10.ForeColor = System.Drawing.Color.White
        Me.txt10.Location = New System.Drawing.Point(420, 39)
        Me.txt10.Name = "txt10"
        Me.txt10.Size = New System.Drawing.Size(40, 31)
        Me.txt10.TabIndex = 17
        Me.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt9
        '
        Me.txt9.BackColor = System.Drawing.Color.Gainsboro
        Me.txt9.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9.ForeColor = System.Drawing.Color.White
        Me.txt9.Location = New System.Drawing.Point(374, 39)
        Me.txt9.Name = "txt9"
        Me.txt9.Size = New System.Drawing.Size(40, 31)
        Me.txt9.TabIndex = 16
        Me.txt9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt13
        '
        Me.txt13.BackColor = System.Drawing.Color.Gainsboro
        Me.txt13.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt13.ForeColor = System.Drawing.Color.White
        Me.txt13.Location = New System.Drawing.Point(558, 39)
        Me.txt13.Name = "txt13"
        Me.txt13.Size = New System.Drawing.Size(40, 31)
        Me.txt13.TabIndex = 20
        Me.txt13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxWordToGuess
        '
        Me.gbxWordToGuess.Controls.Add(Me.txt5)
        Me.gbxWordToGuess.Controls.Add(Me.txt13)
        Me.gbxWordToGuess.Controls.Add(Me.txt1)
        Me.gbxWordToGuess.Controls.Add(Me.txt12)
        Me.gbxWordToGuess.Controls.Add(Me.txt2)
        Me.gbxWordToGuess.Controls.Add(Me.txt11)
        Me.gbxWordToGuess.Controls.Add(Me.txt3)
        Me.gbxWordToGuess.Controls.Add(Me.txt10)
        Me.gbxWordToGuess.Controls.Add(Me.txt4)
        Me.gbxWordToGuess.Controls.Add(Me.txt9)
        Me.gbxWordToGuess.Controls.Add(Me.txt6)
        Me.gbxWordToGuess.Controls.Add(Me.txt8)
        Me.gbxWordToGuess.Controls.Add(Me.txt7)
        Me.gbxWordToGuess.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxWordToGuess.Location = New System.Drawing.Point(581, 205)
        Me.gbxWordToGuess.Name = "gbxWordToGuess"
        Me.gbxWordToGuess.Size = New System.Drawing.Size(608, 98)
        Me.gbxWordToGuess.TabIndex = 21
        Me.gbxWordToGuess.TabStop = False
        Me.gbxWordToGuess.Text = "Guess  Me"
        '
        'lblZombieMan
        '
        Me.lblZombieMan.Font = New System.Drawing.Font("Showcard Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZombieMan.Location = New System.Drawing.Point(572, 13)
        Me.lblZombieMan.Name = "lblZombieMan"
        Me.lblZombieMan.Size = New System.Drawing.Size(608, 79)
        Me.lblZombieMan.TabIndex = 22
        Me.lblZombieMan.Text = "Zombie Man"
        Me.lblZombieMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.AliceBlue
        Me.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(1047, 548)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(132, 50)
        Me.btnQuit.TabIndex = 23
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblGuesses
        '
        Me.lblGuesses.AutoSize = True
        Me.lblGuesses.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuesses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblGuesses.Location = New System.Drawing.Point(587, 330)
        Me.lblGuesses.Name = "lblGuesses"
        Me.lblGuesses.Size = New System.Drawing.Size(142, 23)
        Me.lblGuesses.TabIndex = 24
        Me.lblGuesses.Text = "Guesses Left:"
        '
        'dgvEasy
        '
        Me.dgvEasy.AllowUserToAddRows = False
        Me.dgvEasy.AutoGenerateColumns = False
        Me.dgvEasy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEasy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WordDataGridViewTextBoxColumn})
        Me.dgvEasy.DataSource = Me.EasyBindingSource
        Me.dgvEasy.Location = New System.Drawing.Point(771, 548)
        Me.dgvEasy.Name = "dgvEasy"
        Me.dgvEasy.Size = New System.Drawing.Size(86, 50)
        Me.dgvEasy.TabIndex = 25
        Me.dgvEasy.Visible = False
        '
        'WordDataGridViewTextBoxColumn
        '
        Me.WordDataGridViewTextBoxColumn.DataPropertyName = "Word"
        Me.WordDataGridViewTextBoxColumn.HeaderText = "Word"
        Me.WordDataGridViewTextBoxColumn.Name = "WordDataGridViewTextBoxColumn"
        '
        'EasyBindingSource
        '
        Me.EasyBindingSource.DataMember = "Easy"
        Me.EasyBindingSource.DataSource = Me.DstEasy
        '
        'DstEasy
        '
        Me.DstEasy.DataSetName = "dstEasy"
        Me.DstEasy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EasyTableAdapter
        '
        Me.EasyTableAdapter.ClearBeforeFill = True
        '
        'dgvMedium
        '
        Me.dgvMedium.AllowUserToAddRows = False
        Me.dgvMedium.AutoGenerateColumns = False
        Me.dgvMedium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedium.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WordDataGridViewTextBoxColumn2})
        Me.dgvMedium.DataSource = Me.MediumBindingSource
        Me.dgvMedium.Location = New System.Drawing.Point(860, 548)
        Me.dgvMedium.Name = "dgvMedium"
        Me.dgvMedium.Size = New System.Drawing.Size(89, 50)
        Me.dgvMedium.TabIndex = 26
        Me.dgvMedium.Visible = False
        '
        'WordDataGridViewTextBoxColumn2
        '
        Me.WordDataGridViewTextBoxColumn2.DataPropertyName = "Word"
        Me.WordDataGridViewTextBoxColumn2.HeaderText = "Word"
        Me.WordDataGridViewTextBoxColumn2.Name = "WordDataGridViewTextBoxColumn2"
        '
        'MediumBindingSource
        '
        Me.MediumBindingSource.DataMember = "Medium"
        Me.MediumBindingSource.DataSource = Me.DstMedium
        '
        'DstMedium
        '
        Me.DstMedium.DataSetName = "dstMedium"
        Me.DstMedium.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MediumTableAdapter
        '
        Me.MediumTableAdapter.ClearBeforeFill = True
        '
        'dgvHard
        '
        Me.dgvHard.AllowUserToAddRows = False
        Me.dgvHard.AutoGenerateColumns = False
        Me.dgvHard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WordDataGridViewTextBoxColumn3})
        Me.dgvHard.DataSource = Me.HardBindingSource
        Me.dgvHard.Location = New System.Drawing.Point(955, 548)
        Me.dgvHard.Name = "dgvHard"
        Me.dgvHard.Size = New System.Drawing.Size(86, 50)
        Me.dgvHard.TabIndex = 27
        Me.dgvHard.Visible = False
        '
        'WordDataGridViewTextBoxColumn3
        '
        Me.WordDataGridViewTextBoxColumn3.DataPropertyName = "Word"
        Me.WordDataGridViewTextBoxColumn3.HeaderText = "Word"
        Me.WordDataGridViewTextBoxColumn3.Name = "WordDataGridViewTextBoxColumn3"
        '
        'HardBindingSource
        '
        Me.HardBindingSource.DataMember = "Hard"
        Me.HardBindingSource.DataSource = Me.DstHard
        '
        'DstHard
        '
        Me.DstHard.DataSetName = "dstHard"
        Me.DstHard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HardTableAdapter
        '
        Me.HardTableAdapter.ClearBeforeFill = True
        '
        'txtGuessesLeft
        '
        Me.txtGuessesLeft.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGuessesLeft.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuessesLeft.ForeColor = System.Drawing.Color.Crimson
        Me.txtGuessesLeft.Location = New System.Drawing.Point(735, 330)
        Me.txtGuessesLeft.Name = "txtGuessesLeft"
        Me.txtGuessesLeft.Size = New System.Drawing.Size(39, 24)
        Me.txtGuessesLeft.TabIndex = 28
        '
        'pbxZombieGame
        '
        Me.pbxZombieGame.BackColor = System.Drawing.Color.Transparent
        Me.pbxZombieGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxZombieGame.Image = CType(resources.GetObject("pbxZombieGame.Image"), System.Drawing.Image)
        Me.pbxZombieGame.InitialImage = Global.ZombieMan.My.Resources.Resources.ZombieMan1
        Me.pbxZombieGame.Location = New System.Drawing.Point(55, 13)
        Me.pbxZombieGame.Name = "pbxZombieGame"
        Me.pbxZombieGame.Size = New System.Drawing.Size(464, 605)
        Me.pbxZombieGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxZombieGame.TabIndex = 0
        Me.pbxZombieGame.TabStop = False
        '
        'btnShowLeaderboard
        '
        Me.btnShowLeaderboard.BackColor = System.Drawing.Color.AliceBlue
        Me.btnShowLeaderboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnShowLeaderboard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnShowLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowLeaderboard.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowLeaderboard.Location = New System.Drawing.Point(591, 548)
        Me.btnShowLeaderboard.Name = "btnShowLeaderboard"
        Me.btnShowLeaderboard.Size = New System.Drawing.Size(224, 50)
        Me.btnShowLeaderboard.TabIndex = 29
        Me.btnShowLeaderboard.Text = "Show Leaderboard"
        Me.btnShowLeaderboard.UseVisualStyleBackColor = False
        '
        'frmGame
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1231, 649)
        Me.Controls.Add(Me.btnShowLeaderboard)
        Me.Controls.Add(Me.txtGuessesLeft)
        Me.Controls.Add(Me.dgvHard)
        Me.Controls.Add(Me.dgvMedium)
        Me.Controls.Add(Me.dgvEasy)
        Me.Controls.Add(Me.lblGuesses)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblZombieMan)
        Me.Controls.Add(Me.gbxWordToGuess)
        Me.Controls.Add(Me.gbxLetterToChoose)
        Me.Controls.Add(Me.btnGenerateWord)
        Me.Controls.Add(Me.gbxDifficulty)
        Me.Controls.Add(Me.pbxZombieGame)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "frmGame"
        Me.Text = "Zombie Man"
        Me.gbxDifficulty.ResumeLayout(False)
        Me.gbxDifficulty.PerformLayout()
        Me.gbxLetterToChoose.ResumeLayout(False)
        Me.gbxWordToGuess.ResumeLayout(False)
        Me.gbxWordToGuess.PerformLayout()
        CType(Me.dgvEasy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EasyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DstEasy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMedium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DstMedium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DstHard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxZombieGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxZombieGame As System.Windows.Forms.PictureBox
    Friend WithEvents rbnEasy As System.Windows.Forms.RadioButton
    Friend WithEvents rbnMedium As System.Windows.Forms.RadioButton
    Friend WithEvents rbnHard As System.Windows.Forms.RadioButton
    Friend WithEvents gbxDifficulty As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerateWord As System.Windows.Forms.Button
    Friend WithEvents gbxLetterToChoose As System.Windows.Forms.GroupBox
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblJ As System.Windows.Forms.Label
    Friend WithEvents lblK As System.Windows.Forms.Label
    Friend WithEvents lblW As System.Windows.Forms.Label
    Friend WithEvents lblL As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblM As System.Windows.Forms.Label
    Friend WithEvents lblZ As System.Windows.Forms.Label
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents lblU As System.Windows.Forms.Label
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents lblS As System.Windows.Forms.Label
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents lblQ As System.Windows.Forms.Label
    Friend WithEvents lblP As System.Windows.Forms.Label
    Friend WithEvents lblO As System.Windows.Forms.Label
    Friend WithEvents lblN As System.Windows.Forms.Label
    Friend WithEvents lblI As System.Windows.Forms.Label
    Friend WithEvents lblH As System.Windows.Forms.Label
    Friend WithEvents lblG As System.Windows.Forms.Label
    Friend WithEvents lblF As System.Windows.Forms.Label
    Friend WithEvents lblE As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt8 As System.Windows.Forms.TextBox
    Friend WithEvents txt7 As System.Windows.Forms.TextBox
    Friend WithEvents txt6 As System.Windows.Forms.TextBox
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents txt12 As System.Windows.Forms.TextBox
    Friend WithEvents txt11 As System.Windows.Forms.TextBox
    Friend WithEvents txt10 As System.Windows.Forms.TextBox
    Friend WithEvents txt9 As System.Windows.Forms.TextBox
    Friend WithEvents txt13 As System.Windows.Forms.TextBox
    Friend WithEvents gbxWordToGuess As System.Windows.Forms.GroupBox
    Friend WithEvents lblZombieMan As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblGuesses As System.Windows.Forms.Label
    Friend WithEvents dgvEasy As System.Windows.Forms.DataGridView
    Friend WithEvents DstEasy As ZombieMan.dstEasy
    Friend WithEvents EasyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EasyTableAdapter As ZombieMan.dstEasyTableAdapters.EasyTableAdapter
    Friend WithEvents WordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WordDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvMedium As System.Windows.Forms.DataGridView
    Friend WithEvents DstMedium As ZombieMan.dstMedium
    Friend WithEvents MediumBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MediumTableAdapter As ZombieMan.dstMediumTableAdapters.MediumTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WordDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvHard As System.Windows.Forms.DataGridView
    Friend WithEvents DstHard As ZombieMan.dstHard
    Friend WithEvents HardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HardTableAdapter As ZombieMan.dstHardTableAdapters.HardTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WordDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtGuessesLeft As System.Windows.Forms.TextBox
    Friend WithEvents btnShowLeaderboard As System.Windows.Forms.Button
End Class
