<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Me.btnCloseInstructions = New System.Windows.Forms.Button()
        Me.lblInstructions1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblInstructions3 = New System.Windows.Forms.Label()
        Me.lblInstructions4 = New System.Windows.Forms.Label()
        Me.lblInstructions2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCloseInstructions
        '
        Me.btnCloseInstructions.BackColor = System.Drawing.Color.AliceBlue
        Me.btnCloseInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseInstructions.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseInstructions.Location = New System.Drawing.Point(144, 368)
        Me.btnCloseInstructions.Name = "btnCloseInstructions"
        Me.btnCloseInstructions.Size = New System.Drawing.Size(80, 41)
        Me.btnCloseInstructions.TabIndex = 0
        Me.btnCloseInstructions.Text = "Close"
        Me.btnCloseInstructions.UseVisualStyleBackColor = False
        '
        'lblInstructions1
        '
        Me.lblInstructions1.BackColor = System.Drawing.Color.AliceBlue
        Me.lblInstructions1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions1.Location = New System.Drawing.Point(363, 12)
        Me.lblInstructions1.Name = "lblInstructions1"
        Me.lblInstructions1.Size = New System.Drawing.Size(242, 50)
        Me.lblInstructions1.TabIndex = 1
        Me.lblInstructions1.Text = "The game is simple...guess the word before Zombie Man disappears."
        Me.lblInstructions1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ZombieMan.My.Resources.Resources.ZombieMan1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(313, 339)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblInstructions3
        '
        Me.lblInstructions3.BackColor = System.Drawing.Color.AliceBlue
        Me.lblInstructions3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions3.Location = New System.Drawing.Point(363, 202)
        Me.lblInstructions3.Name = "lblInstructions3"
        Me.lblInstructions3.Size = New System.Drawing.Size(242, 75)
        Me.lblInstructions3.TabIndex = 3
        Me.lblInstructions3.Text = "You have 7 guesses. Each time you guess incorrectly, part of his face will be rem" & _
    "oved."
        Me.lblInstructions3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInstructions4
        '
        Me.lblInstructions4.BackColor = System.Drawing.Color.AliceBlue
        Me.lblInstructions4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions4.Location = New System.Drawing.Point(363, 302)
        Me.lblInstructions4.Name = "lblInstructions4"
        Me.lblInstructions4.Size = New System.Drawing.Size(242, 96)
        Me.lblInstructions4.TabIndex = 4
        Me.lblInstructions4.Text = "If you guess the word while at least part of his face is intact, you win! If his " & _
    "face disappears before you guess all the letters, you lose!"
        Me.lblInstructions4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInstructions2
        '
        Me.lblInstructions2.BackColor = System.Drawing.Color.AliceBlue
        Me.lblInstructions2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions2.Location = New System.Drawing.Point(363, 87)
        Me.lblInstructions2.Name = "lblInstructions2"
        Me.lblInstructions2.Size = New System.Drawing.Size(242, 90)
        Me.lblInstructions2.TabIndex = 5
        Me.lblInstructions2.Text = "First, select the difficulty level. Then click on the Generate Word button. A wor" & _
    "d of the appropriate level will be chosen randomly."
        Me.lblInstructions2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(649, 421)
        Me.Controls.Add(Me.lblInstructions2)
        Me.Controls.Add(Me.lblInstructions4)
        Me.Controls.Add(Me.lblInstructions3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblInstructions1)
        Me.Controls.Add(Me.btnCloseInstructions)
        Me.Name = "frmInstructions"
        Me.Text = "Zombie Man Instructions"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCloseInstructions As System.Windows.Forms.Button
    Friend WithEvents lblInstructions1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblInstructions3 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions4 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions2 As System.Windows.Forms.Label
End Class
