<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWin))
        Me.lblYouWin = New System.Windows.Forms.Label()
        Me.lblWinText = New System.Windows.Forms.Label()
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.btnLeaderboard = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnWinQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblYouWin
        '
        Me.lblYouWin.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYouWin.ForeColor = System.Drawing.Color.Crimson
        Me.lblYouWin.Location = New System.Drawing.Point(120, 36)
        Me.lblYouWin.Name = "lblYouWin"
        Me.lblYouWin.Size = New System.Drawing.Size(201, 35)
        Me.lblYouWin.TabIndex = 0
        Me.lblYouWin.Text = "You Did It!!!"
        '
        'lblWinText
        '
        Me.lblWinText.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWinText.Location = New System.Drawing.Point(53, 111)
        Me.lblWinText.Name = "lblWinText"
        Me.lblWinText.Size = New System.Drawing.Size(330, 152)
        Me.lblWinText.TabIndex = 1
        Me.lblWinText.Text = resources.GetString("lblWinText.Text")
        Me.lblWinText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblThanks
        '
        Me.lblThanks.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThanks.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblThanks.Location = New System.Drawing.Point(57, 263)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(326, 70)
        Me.lblThanks.TabIndex = 2
        Me.lblThanks.Text = "Thanks for playing Zombie Man!"
        Me.lblThanks.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLeaderboard
        '
        Me.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeaderboard.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeaderboard.Location = New System.Drawing.Point(13, 362)
        Me.btnLeaderboard.Name = "btnLeaderboard"
        Me.btnLeaderboard.Size = New System.Drawing.Size(126, 40)
        Me.btnLeaderboard.TabIndex = 3
        Me.btnLeaderboard.Text = "Leaderboard"
        Me.btnLeaderboard.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(157, 362)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(126, 40)
        Me.btnReturn.TabIndex = 4
        Me.btnReturn.Text = "Return to Game"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnWinQuit
        '
        Me.btnWinQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWinQuit.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWinQuit.Location = New System.Drawing.Point(301, 362)
        Me.btnWinQuit.Name = "btnWinQuit"
        Me.btnWinQuit.Size = New System.Drawing.Size(126, 40)
        Me.btnWinQuit.TabIndex = 5
        Me.btnWinQuit.Text = "Quit"
        Me.btnWinQuit.UseVisualStyleBackColor = True
        '
        'frmWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 427)
        Me.Controls.Add(Me.btnWinQuit)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnLeaderboard)
        Me.Controls.Add(Me.lblThanks)
        Me.Controls.Add(Me.lblWinText)
        Me.Controls.Add(Me.lblYouWin)
        Me.Name = "frmWin"
        Me.Text = "We have a winner!!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblYouWin As System.Windows.Forms.Label
    Friend WithEvents lblWinText As System.Windows.Forms.Label
    Friend WithEvents lblThanks As System.Windows.Forms.Label
    Friend WithEvents btnLeaderboard As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnWinQuit As System.Windows.Forms.Button
End Class
