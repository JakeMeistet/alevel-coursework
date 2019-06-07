<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InputCycling
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputCycling))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Year = New System.Windows.Forms.TextBox()
        Me.Month = New System.Windows.Forms.TextBox()
        Me.Day = New System.Windows.Forms.TextBox()
        Me.FName = New System.Windows.Forms.TextBox()
        Me.btnKeep = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Calories = New System.Windows.Forms.TextBox()
        Me.Time = New System.Windows.Forms.TextBox()
        Me.Distance = New System.Windows.Forms.TextBox()
        Me.Speed = New System.Windows.Forms.TextBox()
        Me.SName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblInputCycling = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(74, 312)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "Day:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(257, 292)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 13)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "yy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(207, 292)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "mm"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(161, 292)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 13)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "dd"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(235, 312)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 13)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "/"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(188, 312)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(12, 13)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "/"
        '
        'Year
        '
        Me.Year.Location = New System.Drawing.Point(250, 308)
        Me.Year.MaxLength = 2
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(30, 20)
        Me.Year.TabIndex = 93
        Me.Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Month
        '
        Me.Month.Location = New System.Drawing.Point(202, 308)
        Me.Month.MaxLength = 2
        Me.Month.Name = "Month"
        Me.Month.Size = New System.Drawing.Size(30, 20)
        Me.Month.TabIndex = 92
        Me.Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Day
        '
        Me.Day.Location = New System.Drawing.Point(155, 308)
        Me.Day.MaxLength = 2
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(30, 20)
        Me.Day.TabIndex = 91
        Me.Day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FName
        '
        Me.FName.Location = New System.Drawing.Point(155, 55)
        Me.FName.Name = "FName"
        Me.FName.ReadOnly = True
        Me.FName.Size = New System.Drawing.Size(130, 20)
        Me.FName.TabIndex = 90
        Me.FName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnKeep
        '
        Me.btnKeep.Image = Global.Cycling_Tracker.My.Resources.Resources.Complete
        Me.btnKeep.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKeep.Location = New System.Drawing.Point(155, 353)
        Me.btnKeep.Name = "btnKeep"
        Me.btnKeep.Size = New System.Drawing.Size(92, 87)
        Me.btnKeep.TabIndex = 83
        Me.btnKeep.Text = "Submit"
        Me.btnKeep.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKeep.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(268, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "kCal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(268, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Mins"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(268, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Miles"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "M/pH"
        '
        'Calories
        '
        Me.Calories.Location = New System.Drawing.Point(155, 258)
        Me.Calories.Name = "Calories"
        Me.Calories.Size = New System.Drawing.Size(107, 20)
        Me.Calories.TabIndex = 81
        Me.Calories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Time
        '
        Me.Time.Location = New System.Drawing.Point(155, 215)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(107, 20)
        Me.Time.TabIndex = 79
        Me.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Distance
        '
        Me.Distance.Location = New System.Drawing.Point(155, 175)
        Me.Distance.Name = "Distance"
        Me.Distance.Size = New System.Drawing.Size(107, 20)
        Me.Distance.TabIndex = 76
        Me.Distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Speed
        '
        Me.Speed.Location = New System.Drawing.Point(155, 132)
        Me.Speed.Name = "Speed"
        Me.Speed.Size = New System.Drawing.Size(107, 20)
        Me.Speed.TabIndex = 75
        Me.Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SName
        '
        Me.SName.Location = New System.Drawing.Point(155, 95)
        Me.SName.Name = "SName"
        Me.SName.ReadOnly = True
        Me.SName.Size = New System.Drawing.Size(130, 20)
        Me.SName.TabIndex = 85
        Me.SName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Calories Burnt:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Distance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Speed:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Surname:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Forename:"
        '
        'LblInputCycling
        '
        Me.LblInputCycling.AutoSize = True
        Me.LblInputCycling.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInputCycling.Location = New System.Drawing.Point(93, 21)
        Me.LblInputCycling.Name = "LblInputCycling"
        Me.LblInputCycling.Size = New System.Drawing.Size(210, 20)
        Me.LblInputCycling.TabIndex = 100
        Me.LblInputCycling.Text = "Input Cycling Information"
        '
        'InputCycling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(368, 456)
        Me.Controls.Add(Me.LblInputCycling)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.Month)
        Me.Controls.Add(Me.Day)
        Me.Controls.Add(Me.FName)
        Me.Controls.Add(Me.btnKeep)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Calories)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Distance)
        Me.Controls.Add(Me.Speed)
        Me.Controls.Add(Me.SName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(384, 495)
        Me.MinimumSize = New System.Drawing.Size(384, 495)
        Me.Name = "InputCycling"
        Me.Text = "InputCycling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Year As TextBox
    Friend WithEvents Month As TextBox
    Friend WithEvents Day As TextBox
    Friend WithEvents FName As TextBox
    Friend WithEvents btnKeep As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Calories As TextBox
    Friend WithEvents Time As TextBox
    Friend WithEvents Distance As TextBox
    Friend WithEvents Speed As TextBox
    Friend WithEvents SName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblInputCycling As Label
End Class
