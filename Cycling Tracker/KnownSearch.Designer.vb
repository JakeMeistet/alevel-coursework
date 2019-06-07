<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KnownSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KnownSearch))
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DayOutput = New System.Windows.Forms.TextBox()
        Me.Day = New System.Windows.Forms.Label()
        Me.YearOutput = New System.Windows.Forms.TextBox()
        Me.Year = New System.Windows.Forms.Label()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.SearchInput = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnDone
        '
        Me.BtnDone.Image = Global.Cycling_Tracker.My.Resources.Resources.Back
        Me.BtnDone.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDone.Location = New System.Drawing.Point(220, 235)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(92, 81)
        Me.BtnDone.TabIndex = 83
        Me.BtnDone.Text = "Done"
        Me.BtnDone.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDone.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Image = Global.Cycling_Tracker.My.Resources.Resources.Search
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSearch.Location = New System.Drawing.Point(86, 235)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(92, 81)
        Me.BtnSearch.TabIndex = 82
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'DayOutput
        '
        Me.DayOutput.Location = New System.Drawing.Point(102, 197)
        Me.DayOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DayOutput.Name = "DayOutput"
        Me.DayOutput.ReadOnly = True
        Me.DayOutput.Size = New System.Drawing.Size(212, 20)
        Me.DayOutput.TabIndex = 88
        '
        'Day
        '
        Me.Day.AutoSize = True
        Me.Day.Location = New System.Drawing.Point(184, 174)
        Me.Day.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(34, 13)
        Me.Day.TabIndex = 87
        Me.Day.Text = "Days:"
        '
        'YearOutput
        '
        Me.YearOutput.Location = New System.Drawing.Point(102, 147)
        Me.YearOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.YearOutput.Name = "YearOutput"
        Me.YearOutput.ReadOnly = True
        Me.YearOutput.Size = New System.Drawing.Size(212, 20)
        Me.YearOutput.TabIndex = 86
        '
        'Year
        '
        Me.Year.AutoSize = True
        Me.Year.Location = New System.Drawing.Point(184, 125)
        Me.Year.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(32, 13)
        Me.Year.TabIndex = 85
        Me.Year.Text = "Year:"
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearch.Location = New System.Drawing.Point(170, 32)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(66, 20)
        Me.LblSearch.TabIndex = 84
        Me.LblSearch.Text = "Search"
        '
        'SearchInput
        '
        Me.SearchInput.Location = New System.Drawing.Point(102, 96)
        Me.SearchInput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchInput.Name = "SearchInput"
        Me.SearchInput.Size = New System.Drawing.Size(212, 20)
        Me.SearchInput.TabIndex = 80
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Location = New System.Drawing.Point(158, 76)
        Me.Search.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(89, 13)
        Me.Search.TabIndex = 81
        Me.Search.Text = "Surname Search:"
        '
        'KnownSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(399, 313)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.DayOutput)
        Me.Controls.Add(Me.Day)
        Me.Controls.Add(Me.YearOutput)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.LblSearch)
        Me.Controls.Add(Me.SearchInput)
        Me.Controls.Add(Me.Search)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(415, 352)
        Me.MinimumSize = New System.Drawing.Size(415, 352)
        Me.Name = "KnownSearch"
        Me.Text = "KnownSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDone As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents DayOutput As TextBox
    Friend WithEvents Day As Label
    Friend WithEvents YearOutput As TextBox
    Friend WithEvents Year As Label
    Friend WithEvents LblSearch As Label
    Friend WithEvents SearchInput As TextBox
    Friend WithEvents Search As Label
End Class
