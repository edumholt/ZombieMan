<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeaderboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLeaderboard = New System.Windows.Forms.DataGridView()
        Me.LeaderboardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeaderboardDataSet = New ZombieMan.LeaderboardDataSet()
        Me.LeaderboardTableAdapter = New ZombieMan.LeaderboardDataSetTableAdapters.LeaderboardTableAdapter()
        Me.lblLeaderboard = New System.Windows.Forms.Label()
        Me.lblLeaderBoardZombieMan = New System.Windows.Forms.Label()
        Me.btnLeaderboardReturntToGame = New System.Windows.Forms.Button()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuessesLeftDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvLeaderboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaderboardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaderboardDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLeaderboard
        '
        Me.dgvLeaderboard.AllowUserToDeleteRows = False
        Me.dgvLeaderboard.AutoGenerateColumns = False
        Me.dgvLeaderboard.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLeaderboard.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeaderboard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.GuessesLeftDataGridViewTextBoxColumn})
        Me.dgvLeaderboard.DataSource = Me.LeaderboardBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLeaderboard.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLeaderboard.Location = New System.Drawing.Point(42, 127)
        Me.dgvLeaderboard.Name = "dgvLeaderboard"
        Me.dgvLeaderboard.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLeaderboard.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(2)
        Me.dgvLeaderboard.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLeaderboard.RowTemplate.Height = 26
        Me.dgvLeaderboard.RowTemplate.ReadOnly = True
        Me.dgvLeaderboard.Size = New System.Drawing.Size(301, 341)
        Me.dgvLeaderboard.TabIndex = 0
        '
        'LeaderboardBindingSource
        '
        Me.LeaderboardBindingSource.DataMember = "Leaderboard"
        Me.LeaderboardBindingSource.DataSource = Me.LeaderboardDataSet
        '
        'LeaderboardDataSet
        '
        Me.LeaderboardDataSet.DataSetName = "LeaderboardDataSet"
        Me.LeaderboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LeaderboardTableAdapter
        '
        Me.LeaderboardTableAdapter.ClearBeforeFill = True
        '
        'lblLeaderboard
        '
        Me.lblLeaderboard.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderboard.Location = New System.Drawing.Point(71, 83)
        Me.lblLeaderboard.Name = "lblLeaderboard"
        Me.lblLeaderboard.Size = New System.Drawing.Size(243, 23)
        Me.lblLeaderboard.TabIndex = 1
        Me.lblLeaderboard.Text = "Leaderboard"
        Me.lblLeaderboard.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLeaderBoardZombieMan
        '
        Me.lblLeaderBoardZombieMan.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderBoardZombieMan.Location = New System.Drawing.Point(71, 32)
        Me.lblLeaderBoardZombieMan.Name = "lblLeaderBoardZombieMan"
        Me.lblLeaderBoardZombieMan.Size = New System.Drawing.Size(243, 39)
        Me.lblLeaderBoardZombieMan.TabIndex = 2
        Me.lblLeaderBoardZombieMan.Text = "Zombie Man"
        Me.lblLeaderBoardZombieMan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLeaderboardReturntToGame
        '
        Me.btnLeaderboardReturntToGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeaderboardReturntToGame.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeaderboardReturntToGame.Location = New System.Drawing.Point(120, 498)
        Me.btnLeaderboardReturntToGame.Name = "btnLeaderboardReturntToGame"
        Me.btnLeaderboardReturntToGame.Size = New System.Drawing.Size(144, 32)
        Me.btnLeaderboardReturntToGame.TabIndex = 3
        Me.btnLeaderboardReturntToGame.Text = "Return To Game"
        Me.btnLeaderboardReturntToGame.UseVisualStyleBackColor = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 140
        '
        'GuessesLeftDataGridViewTextBoxColumn
        '
        Me.GuessesLeftDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.GuessesLeftDataGridViewTextBoxColumn.DataPropertyName = "GuessesLeft"
        Me.GuessesLeftDataGridViewTextBoxColumn.HeaderText = "Guesses Left"
        Me.GuessesLeftDataGridViewTextBoxColumn.Name = "GuessesLeftDataGridViewTextBoxColumn"
        Me.GuessesLeftDataGridViewTextBoxColumn.ReadOnly = True
        Me.GuessesLeftDataGridViewTextBoxColumn.Width = 118
        '
        'frmLeaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(384, 554)
        Me.Controls.Add(Me.btnLeaderboardReturntToGame)
        Me.Controls.Add(Me.lblLeaderBoardZombieMan)
        Me.Controls.Add(Me.lblLeaderboard)
        Me.Controls.Add(Me.dgvLeaderboard)
        Me.Name = "frmLeaderboard"
        Me.Text = "Leaderboard"
        CType(Me.dgvLeaderboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaderboardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaderboardDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvLeaderboard As System.Windows.Forms.DataGridView
    Friend WithEvents LeaderboardDataSet As ZombieMan.LeaderboardDataSet
    Friend WithEvents LeaderboardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LeaderboardTableAdapter As ZombieMan.LeaderboardDataSetTableAdapters.LeaderboardTableAdapter
    Friend WithEvents lblLeaderboard As System.Windows.Forms.Label
    Friend WithEvents lblLeaderBoardZombieMan As System.Windows.Forms.Label
    Friend WithEvents btnLeaderboardReturntToGame As System.Windows.Forms.Button
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuessesLeftDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
