<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZombieMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmZombieMan))
        Me.lblZombieMan = New System.Windows.Forms.Label()
        Me.gbxZombieMan = New System.Windows.Forms.GroupBox()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnNoThanks = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblGameDescription = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pbxZombieMain = New System.Windows.Forms.PictureBox()
        Me.gbxZombieMan.SuspendLayout()
        CType(Me.pbxZombieMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblZombieMan
        '
        Me.lblZombieMan.Font = New System.Drawing.Font("Showcard Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZombieMan.Location = New System.Drawing.Point(0, 53)
        Me.lblZombieMan.Name = "lblZombieMan"
        Me.lblZombieMan.Size = New System.Drawing.Size(734, 79)
        Me.lblZombieMan.TabIndex = 0
        Me.lblZombieMan.Text = "Zombie Man"
        Me.lblZombieMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxZombieMan
        '
        Me.gbxZombieMan.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbxZombieMan.Controls.Add(Me.btnInstructions)
        Me.gbxZombieMan.Controls.Add(Me.pbxZombieMain)
        Me.gbxZombieMan.Controls.Add(Me.btnNoThanks)
        Me.gbxZombieMan.Controls.Add(Me.btnStart)
        Me.gbxZombieMan.Controls.Add(Me.lblGameDescription)
        Me.gbxZombieMan.Controls.Add(Me.lblWelcome)
        Me.gbxZombieMan.Controls.Add(Me.lblZombieMan)
        Me.gbxZombieMan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbxZombieMan.Location = New System.Drawing.Point(44, 16)
        Me.gbxZombieMan.Name = "gbxZombieMan"
        Me.gbxZombieMan.Size = New System.Drawing.Size(734, 618)
        Me.gbxZombieMan.TabIndex = 1
        Me.gbxZombieMan.TabStop = False
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.AliceBlue
        Me.btnInstructions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnInstructions.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstructions.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.Location = New System.Drawing.Point(297, 557)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(116, 38)
        Me.btnInstructions.TabIndex = 6
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'btnNoThanks
        '
        Me.btnNoThanks.BackColor = System.Drawing.Color.AliceBlue
        Me.btnNoThanks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnNoThanks.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNoThanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNoThanks.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoThanks.Location = New System.Drawing.Point(459, 557)
        Me.btnNoThanks.Name = "btnNoThanks"
        Me.btnNoThanks.Size = New System.Drawing.Size(116, 38)
        Me.btnNoThanks.TabIndex = 4
        Me.btnNoThanks.Text = "No Thanks!"
        Me.btnNoThanks.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.AliceBlue
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(135, 557)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(116, 38)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Enter..."
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblGameDescription
        '
        Me.lblGameDescription.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameDescription.Location = New System.Drawing.Point(204, 508)
        Me.lblGameDescription.Name = "lblGameDescription"
        Me.lblGameDescription.Size = New System.Drawing.Size(321, 32)
        Me.lblGameDescription.TabIndex = 2
        Me.lblGameDescription.Text = "A Hangman-Style Game...With A Twist"
        Me.lblGameDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(0, 17)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(734, 48)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome To..."
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbxZombieMain
        '
        Me.pbxZombieMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxZombieMain.Image = CType(resources.GetObject("pbxZombieMain.Image"), System.Drawing.Image)
        Me.pbxZombieMain.Location = New System.Drawing.Point(204, 148)
        Me.pbxZombieMain.Name = "pbxZombieMain"
        Me.pbxZombieMain.Size = New System.Drawing.Size(321, 350)
        Me.pbxZombieMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxZombieMain.TabIndex = 5
        Me.pbxZombieMain.TabStop = False
        '
        'frmZombieMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(833, 646)
        Me.Controls.Add(Me.gbxZombieMan)
        Me.Name = "frmZombieMan"
        Me.Text = "Zombie Man"
        Me.gbxZombieMan.ResumeLayout(False)
        CType(Me.pbxZombieMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblZombieMan As System.Windows.Forms.Label
    Friend WithEvents gbxZombieMan As System.Windows.Forms.GroupBox
    Friend WithEvents btnNoThanks As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblGameDescription As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents pbxZombieMain As System.Windows.Forms.PictureBox
    Friend WithEvents btnInstructions As System.Windows.Forms.Button

End Class
