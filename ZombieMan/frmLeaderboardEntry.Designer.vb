<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeaderboardEntry
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtGuessesLeft = New System.Windows.Forms.TextBox()
        Me.btnSaveLeaderboardEntry = New System.Windows.Forms.Button()
        Me.dgvLeaderboardEntry = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuessesLeftDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaderboardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DstLeaderBoardEntryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DstLeaderBoardEntry = New ZombieMan.dstLeaderBoardEntry()
        Me.LeaderboardTableAdapter = New ZombieMan.dstLeaderBoardEntryTableAdapters.LeaderboardTableAdapter()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGuessesLeft = New System.Windows.Forms.Label()
        Me.lblLeaderboard = New System.Windows.Forms.Label()
        CType(Me.dgvLeaderboardEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaderboardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DstLeaderBoardEntryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DstLeaderBoardEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(69, 131)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 27)
        Me.txtName.TabIndex = 0
        '
        'txtGuessesLeft
        '
        Me.txtGuessesLeft.BackColor = System.Drawing.Color.AliceBlue
        Me.txtGuessesLeft.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGuessesLeft.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuessesLeft.Location = New System.Drawing.Point(109, 214)
        Me.txtGuessesLeft.Name = "txtGuessesLeft"
        Me.txtGuessesLeft.Size = New System.Drawing.Size(28, 20)
        Me.txtGuessesLeft.TabIndex = 1
        '
        'btnSaveLeaderboardEntry
        '
        Me.btnSaveLeaderboardEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveLeaderboardEntry.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveLeaderboardEntry.Location = New System.Drawing.Point(69, 256)
        Me.btnSaveLeaderboardEntry.Name = "btnSaveLeaderboardEntry"
        Me.btnSaveLeaderboardEntry.Size = New System.Drawing.Size(100, 35)
        Me.btnSaveLeaderboardEntry.TabIndex = 2
        Me.btnSaveLeaderboardEntry.Text = "Save Entry"
        Me.btnSaveLeaderboardEntry.UseVisualStyleBackColor = True
        '
        'dgvLeaderboardEntry
        '
        Me.dgvLeaderboardEntry.AllowUserToDeleteRows = False
        Me.dgvLeaderboardEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLeaderboardEntry.AutoGenerateColumns = False
        Me.dgvLeaderboardEntry.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvLeaderboardEntry.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLeaderboardEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeaderboardEntry.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.GuessesLeftDataGridViewTextBoxColumn})
        Me.dgvLeaderboardEntry.DataSource = Me.LeaderboardBindingSource
        Me.dgvLeaderboardEntry.Location = New System.Drawing.Point(226, 72)
        Me.dgvLeaderboardEntry.Name = "dgvLeaderboardEntry"
        Me.dgvLeaderboardEntry.ReadOnly = True
        Me.dgvLeaderboardEntry.RowHeadersVisible = False
        Me.dgvLeaderboardEntry.Size = New System.Drawing.Size(217, 312)
        Me.dgvLeaderboardEntry.TabIndex = 3
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MaxInputLength = 50
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 120
        '
        'GuessesLeftDataGridViewTextBoxColumn
        '
        Me.GuessesLeftDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.GuessesLeftDataGridViewTextBoxColumn.DataPropertyName = "GuessesLeft"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Crimson
        Me.GuessesLeftDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.GuessesLeftDataGridViewTextBoxColumn.HeaderText = "Guesses Left"
        Me.GuessesLeftDataGridViewTextBoxColumn.MaxInputLength = 10
        Me.GuessesLeftDataGridViewTextBoxColumn.Name = "GuessesLeftDataGridViewTextBoxColumn"
        Me.GuessesLeftDataGridViewTextBoxColumn.ReadOnly = True
        Me.GuessesLeftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GuessesLeftDataGridViewTextBoxColumn.Width = 94
        '
        'LeaderboardBindingSource
        '
        Me.LeaderboardBindingSource.DataMember = "Leaderboard"
        Me.LeaderboardBindingSource.DataSource = Me.DstLeaderBoardEntryBindingSource
        '
        'DstLeaderBoardEntryBindingSource
        '
        Me.DstLeaderBoardEntryBindingSource.DataSource = Me.DstLeaderBoardEntry
        Me.DstLeaderBoardEntryBindingSource.Position = 0
        '
        'DstLeaderBoardEntry
        '
        Me.DstLeaderBoardEntry.DataSetName = "dstLeaderBoardEntry"
        Me.DstLeaderBoardEntry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LeaderboardTableAdapter
        '
        Me.LeaderboardTableAdapter.ClearBeforeFill = True
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(82, 95)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(74, 23)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name:"
        '
        'lblGuessesLeft
        '
        Me.lblGuessesLeft.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuessesLeft.Location = New System.Drawing.Point(61, 177)
        Me.lblGuessesLeft.Name = "lblGuessesLeft"
        Me.lblGuessesLeft.Size = New System.Drawing.Size(116, 23)
        Me.lblGuessesLeft.TabIndex = 5
        Me.lblGuessesLeft.Text = "Guesses Left:"
        '
        'lblLeaderboard
        '
        Me.lblLeaderboard.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderboard.Location = New System.Drawing.Point(226, 36)
        Me.lblLeaderboard.Name = "lblLeaderboard"
        Me.lblLeaderboard.Size = New System.Drawing.Size(141, 23)
        Me.lblLeaderboard.TabIndex = 6
        Me.lblLeaderboard.Text = "Leaderboard"
        '
        'frmLeaderboardEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(493, 396)
        Me.Controls.Add(Me.lblLeaderboard)
        Me.Controls.Add(Me.lblGuessesLeft)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.dgvLeaderboardEntry)
        Me.Controls.Add(Me.btnSaveLeaderboardEntry)
        Me.Controls.Add(Me.txtGuessesLeft)
        Me.Controls.Add(Me.txtName)
        Me.Name = "frmLeaderboardEntry"
        Me.Text = "Leaderboard Entry"
        CType(Me.dgvLeaderboardEntry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaderboardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DstLeaderBoardEntryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DstLeaderBoardEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtGuessesLeft As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveLeaderboardEntry As System.Windows.Forms.Button
    Friend WithEvents dgvLeaderboardEntry As System.Windows.Forms.DataGridView
    Friend WithEvents DstLeaderBoardEntryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DstLeaderBoardEntry As ZombieMan.dstLeaderBoardEntry
    Friend WithEvents LeaderboardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LeaderboardTableAdapter As ZombieMan.dstLeaderBoardEntryTableAdapters.LeaderboardTableAdapter
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblGuessesLeft As System.Windows.Forms.Label
    Friend WithEvents lblLeaderboard As System.Windows.Forms.Label
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuessesLeftDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
