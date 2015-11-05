<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoser
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
        Me.lblYouLose = New System.Windows.Forms.Label()
        Me.lblLoseText1 = New System.Windows.Forms.Label()
        Me.lblLoseText2 = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.btnLoseQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblYouLose
        '
        Me.lblYouLose.AutoSize = True
        Me.lblYouLose.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYouLose.ForeColor = System.Drawing.Color.Crimson
        Me.lblYouLose.Location = New System.Drawing.Point(181, 36)
        Me.lblYouLose.Name = "lblYouLose"
        Me.lblYouLose.Size = New System.Drawing.Size(175, 33)
        Me.lblYouLose.TabIndex = 0
        Me.lblYouLose.Text = "You Lose!!!"
        '
        'lblLoseText1
        '
        Me.lblLoseText1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoseText1.Location = New System.Drawing.Point(95, 113)
        Me.lblLoseText1.Name = "lblLoseText1"
        Me.lblLoseText1.Size = New System.Drawing.Size(346, 77)
        Me.lblLoseText1.TabIndex = 1
        Me.lblLoseText1.Text = "This is most unfortunate. You let Zombie Die. But, of course, he was already dead" & _
    ", wasn't he?"
        Me.lblLoseText1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLoseText2
        '
        Me.lblLoseText2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoseText2.Location = New System.Drawing.Point(95, 217)
        Me.lblLoseText2.Name = "lblLoseText2"
        Me.lblLoseText2.Size = New System.Drawing.Size(346, 98)
        Me.lblLoseText2.TabIndex = 2
        Me.lblLoseText2.Text = "If you'd like to take another shot, by all means do so. Otherwise, just chicken o" & _
    "ut and click the Quit button, quitter!"
        Me.lblLoseText2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayAgain.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAgain.Location = New System.Drawing.Point(88, 375)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(100, 42)
        Me.btnPlayAgain.TabIndex = 3
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'btnLoseQuit
        '
        Me.btnLoseQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoseQuit.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoseQuit.Location = New System.Drawing.Point(322, 375)
        Me.btnLoseQuit.Name = "btnLoseQuit"
        Me.btnLoseQuit.Size = New System.Drawing.Size(100, 42)
        Me.btnLoseQuit.TabIndex = 4
        Me.btnLoseQuit.Text = "Quit"
        Me.btnLoseQuit.UseVisualStyleBackColor = True
        '
        'frmLoser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(536, 472)
        Me.Controls.Add(Me.btnLoseQuit)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblLoseText2)
        Me.Controls.Add(Me.lblLoseText1)
        Me.Controls.Add(Me.lblYouLose)
        Me.Name = "frmLoser"
        Me.Text = "You Lose!!!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblYouLose As System.Windows.Forms.Label
    Friend WithEvents lblLoseText1 As System.Windows.Forms.Label
    Friend WithEvents lblLoseText2 As System.Windows.Forms.Label
    Friend WithEvents btnPlayAgain As System.Windows.Forms.Button
    Friend WithEvents btnLoseQuit As System.Windows.Forms.Button
End Class
