<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminSearch))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.YearSearch = New System.Windows.Forms.TextBox()
        Me.MonthSearch = New System.Windows.Forms.TextBox()
        Me.CaloriesOutput = New System.Windows.Forms.TextBox()
        Me.Calories = New System.Windows.Forms.Label()
        Me.TimeOutput = New System.Windows.Forms.TextBox()
        Me.Time = New System.Windows.Forms.Label()
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DistanceOutput = New System.Windows.Forms.TextBox()
        Me.Distance = New System.Windows.Forms.Label()
        Me.SpeedOutput = New System.Windows.Forms.TextBox()
        Me.Speed = New System.Windows.Forms.Label()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.DaySearch = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(218, 139)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "ID Search:"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(144, 162)
        Me.TxtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(212, 20)
        Me.TxtID.TabIndex = 160
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 107)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 13)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "/"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 107)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "/"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(320, 91)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "yy"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "dd"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "mm"
        '
        'YearSearch
        '
        Me.YearSearch.Location = New System.Drawing.Point(306, 105)
        Me.YearSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.YearSearch.MaxLength = 2
        Me.YearSearch.Multiline = True
        Me.YearSearch.Name = "YearSearch"
        Me.YearSearch.Size = New System.Drawing.Size(49, 18)
        Me.YearSearch.TabIndex = 154
        '
        'MonthSearch
        '
        Me.MonthSearch.Location = New System.Drawing.Point(222, 105)
        Me.MonthSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MonthSearch.MaxLength = 2
        Me.MonthSearch.Multiline = True
        Me.MonthSearch.Name = "MonthSearch"
        Me.MonthSearch.Size = New System.Drawing.Size(49, 18)
        Me.MonthSearch.TabIndex = 153
        '
        'CaloriesOutput
        '
        Me.CaloriesOutput.Location = New System.Drawing.Point(254, 291)
        Me.CaloriesOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CaloriesOutput.Name = "CaloriesOutput"
        Me.CaloriesOutput.ReadOnly = True
        Me.CaloriesOutput.Size = New System.Drawing.Size(212, 20)
        Me.CaloriesOutput.TabIndex = 152
        '
        'Calories
        '
        Me.Calories.AutoSize = True
        Me.Calories.Location = New System.Drawing.Point(334, 269)
        Me.Calories.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Calories.Name = "Calories"
        Me.Calories.Size = New System.Drawing.Size(47, 13)
        Me.Calories.TabIndex = 151
        Me.Calories.Text = "Calories:"
        '
        'TimeOutput
        '
        Me.TimeOutput.Location = New System.Drawing.Point(28, 291)
        Me.TimeOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TimeOutput.Name = "TimeOutput"
        Me.TimeOutput.ReadOnly = True
        Me.TimeOutput.Size = New System.Drawing.Size(212, 20)
        Me.TimeOutput.TabIndex = 150
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Location = New System.Drawing.Point(110, 269)
        Me.Time.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(33, 13)
        Me.Time.TabIndex = 149
        Me.Time.Text = "Time:"
        '
        'BtnDone
        '
        Me.BtnDone.Image = Global.Cycling_Tracker.My.Resources.Resources.Back
        Me.BtnDone.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDone.Location = New System.Drawing.Point(270, 325)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(92, 83)
        Me.BtnDone.TabIndex = 148
        Me.BtnDone.Text = "Done"
        Me.BtnDone.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDone.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Image = Global.Cycling_Tracker.My.Resources.Resources.Search
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSearch.Location = New System.Drawing.Point(129, 325)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(92, 83)
        Me.BtnSearch.TabIndex = 147
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'DistanceOutput
        '
        Me.DistanceOutput.Location = New System.Drawing.Point(254, 235)
        Me.DistanceOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DistanceOutput.Name = "DistanceOutput"
        Me.DistanceOutput.ReadOnly = True
        Me.DistanceOutput.Size = New System.Drawing.Size(212, 20)
        Me.DistanceOutput.TabIndex = 146
        '
        'Distance
        '
        Me.Distance.AutoSize = True
        Me.Distance.Location = New System.Drawing.Point(334, 213)
        Me.Distance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Distance.Name = "Distance"
        Me.Distance.Size = New System.Drawing.Size(52, 13)
        Me.Distance.TabIndex = 145
        Me.Distance.Text = "Distance:"
        '
        'SpeedOutput
        '
        Me.SpeedOutput.Location = New System.Drawing.Point(28, 235)
        Me.SpeedOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SpeedOutput.Name = "SpeedOutput"
        Me.SpeedOutput.ReadOnly = True
        Me.SpeedOutput.Size = New System.Drawing.Size(212, 20)
        Me.SpeedOutput.TabIndex = 144
        '
        'Speed
        '
        Me.Speed.AutoSize = True
        Me.Speed.Location = New System.Drawing.Point(110, 213)
        Me.Speed.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Speed.Name = "Speed"
        Me.Speed.Size = New System.Drawing.Size(41, 13)
        Me.Speed.TabIndex = 143
        Me.Speed.Text = "Speed:"
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearch.Location = New System.Drawing.Point(212, 40)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(66, 20)
        Me.LblSearch.TabIndex = 142
        Me.LblSearch.Text = "Search"
        '
        'DaySearch
        '
        Me.DaySearch.Location = New System.Drawing.Point(144, 105)
        Me.DaySearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DaySearch.MaxLength = 2
        Me.DaySearch.Multiline = True
        Me.DaySearch.Name = "DaySearch"
        Me.DaySearch.Size = New System.Drawing.Size(49, 18)
        Me.DaySearch.TabIndex = 141
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Location = New System.Drawing.Point(212, 69)
        Me.Search.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(70, 13)
        Me.Search.TabIndex = 140
        Me.Search.Text = "Date Search:"
        '
        'AdminSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(493, 401)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.YearSearch)
        Me.Controls.Add(Me.MonthSearch)
        Me.Controls.Add(Me.CaloriesOutput)
        Me.Controls.Add(Me.Calories)
        Me.Controls.Add(Me.TimeOutput)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.DistanceOutput)
        Me.Controls.Add(Me.Distance)
        Me.Controls.Add(Me.SpeedOutput)
        Me.Controls.Add(Me.Speed)
        Me.Controls.Add(Me.LblSearch)
        Me.Controls.Add(Me.DaySearch)
        Me.Controls.Add(Me.Search)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(509, 440)
        Me.MinimumSize = New System.Drawing.Size(509, 440)
        Me.Name = "AdminSearch"
        Me.Text = "AdminSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents YearSearch As TextBox
    Friend WithEvents MonthSearch As TextBox
    Friend WithEvents CaloriesOutput As TextBox
    Friend WithEvents Calories As Label
    Friend WithEvents TimeOutput As TextBox
    Friend WithEvents Time As Label
    Friend WithEvents BtnDone As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents DistanceOutput As TextBox
    Friend WithEvents Distance As Label
    Friend WithEvents SpeedOutput As TextBox
    Friend WithEvents Speed As Label
    Friend WithEvents LblSearch As Label
    Friend WithEvents DaySearch As TextBox
    Friend WithEvents Search As Label
End Class
