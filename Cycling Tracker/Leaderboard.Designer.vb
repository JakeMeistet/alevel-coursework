<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Leaderboard))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnRank = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnSpeed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDistance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnCalories = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblLBoard = New System.Windows.Forms.Label()
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnRank, Me.ColumnSpeed, Me.ColumnDistance, Me.ColumnTime, Me.ColumnCalories})
        Me.ListView1.Location = New System.Drawing.Point(50, 65)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(334, 318)
        Me.ListView1.TabIndex = 120
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnRank
        '
        Me.ColumnRank.Text = "Rank"
        Me.ColumnRank.Width = 51
        '
        'ColumnSpeed
        '
        Me.ColumnSpeed.Text = "Speed"
        Me.ColumnSpeed.Width = 63
        '
        'ColumnDistance
        '
        Me.ColumnDistance.Text = "Distance"
        Me.ColumnDistance.Width = 74
        '
        'ColumnTime
        '
        Me.ColumnTime.Text = "Time"
        Me.ColumnTime.Width = 65
        '
        'ColumnCalories
        '
        Me.ColumnCalories.Text = "Calories"
        Me.ColumnCalories.Width = 76
        '
        'LblLBoard
        '
        Me.LblLBoard.AutoSize = True
        Me.LblLBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLBoard.Location = New System.Drawing.Point(119, 30)
        Me.LblLBoard.Name = "LblLBoard"
        Me.LblLBoard.Size = New System.Drawing.Size(186, 20)
        Me.LblLBoard.TabIndex = 122
        Me.LblLBoard.Text = "Personal Leaderboard"
        '
        'BtnDone
        '
        Me.BtnDone.Image = Global.Cycling_Tracker.My.Resources.Resources.Back
        Me.BtnDone.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDone.Location = New System.Drawing.Point(532, 292)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(156, 91)
        Me.BtnDone.TabIndex = 121
        Me.BtnDone.Text = "Done"
        Me.BtnDone.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDone.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Cycling_Tracker.My.Resources.Resources.Calories
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.Location = New System.Drawing.Point(620, 177)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(156, 91)
        Me.Button4.TabIndex = 127
        Me.Button4.Text = "Sort by Calories"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Cycling_Tracker.My.Resources.Resources.Distance
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.Location = New System.Drawing.Point(620, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(156, 91)
        Me.Button3.TabIndex = 126
        Me.Button3.Text = "Sort by Distance"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Cycling_Tracker.My.Resources.Resources.Time
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.Location = New System.Drawing.Point(442, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 91)
        Me.Button2.TabIndex = 125
        Me.Button2.Text = "Sort by Time"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Cycling_Tracker.My.Resources.Resources.Speed2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Location = New System.Drawing.Point(442, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 91)
        Me.Button1.TabIndex = 124
        Me.Button1.Text = "Sort by Speed"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Leaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(818, 421)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.LblLBoard)
        Me.Controls.Add(Me.BtnDone)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(834, 460)
        Me.MinimumSize = New System.Drawing.Size(834, 460)
        Me.Name = "Leaderboard"
        Me.Text = "Leaderboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnRank As ColumnHeader
    Friend WithEvents ColumnSpeed As ColumnHeader
    Friend WithEvents ColumnDistance As ColumnHeader
    Friend WithEvents ColumnTime As ColumnHeader
    Friend WithEvents ColumnCalories As ColumnHeader
    Friend WithEvents LblLBoard As Label
    Friend WithEvents BtnDone As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
