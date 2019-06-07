<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Training
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Training))
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.ListSport = New System.Windows.Forms.ListBox()
        Me.LblHoursOf = New System.Windows.Forms.Label()
        Me.LblMilesTo = New System.Windows.Forms.Label()
        Me.TxtMilesTo = New System.Windows.Forms.TextBox()
        Me.LblHoursTo = New System.Windows.Forms.Label()
        Me.TxtHoursTo = New System.Windows.Forms.TextBox()
        Me.TrainingHours = New System.Windows.Forms.Label()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.LblTraining = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnDone
        '
        Me.BtnDone.Image = Global.Cycling_Tracker.My.Resources.Resources.Back
        Me.BtnDone.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDone.Location = New System.Drawing.Point(405, 374)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(92, 87)
        Me.BtnDone.TabIndex = 109
        Me.BtnDone.Text = "Done"
        Me.BtnDone.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDone.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Image = Global.Cycling_Tracker.My.Resources.Resources.Complete
        Me.BtnSubmit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSubmit.Location = New System.Drawing.Point(259, 374)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(92, 87)
        Me.BtnSubmit.TabIndex = 108
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'ListSport
        '
        Me.ListSport.FormattingEnabled = True
        Me.ListSport.Location = New System.Drawing.Point(269, 203)
        Me.ListSport.Name = "ListSport"
        Me.ListSport.Size = New System.Drawing.Size(218, 147)
        Me.ListSport.TabIndex = 117
        '
        'LblHoursOf
        '
        Me.LblHoursOf.AutoSize = True
        Me.LblHoursOf.Location = New System.Drawing.Point(331, 177)
        Me.LblHoursOf.Name = "LblHoursOf"
        Me.LblHoursOf.Size = New System.Drawing.Size(82, 13)
        Me.LblHoursOf.TabIndex = 116
        Me.LblHoursOf.Text = "Hours per sport:"
        '
        'LblMilesTo
        '
        Me.LblMilesTo.AutoSize = True
        Me.LblMilesTo.Location = New System.Drawing.Point(590, 177)
        Me.LblMilesTo.Name = "LblMilesTo"
        Me.LblMilesTo.Size = New System.Drawing.Size(92, 13)
        Me.LblMilesTo.TabIndex = 115
        Me.LblMilesTo.Text = "Miles to complete:"
        '
        'TxtMilesTo
        '
        Me.TxtMilesTo.Location = New System.Drawing.Point(522, 203)
        Me.TxtMilesTo.Multiline = True
        Me.TxtMilesTo.Name = "TxtMilesTo"
        Me.TxtMilesTo.ReadOnly = True
        Me.TxtMilesTo.Size = New System.Drawing.Size(218, 20)
        Me.TxtMilesTo.TabIndex = 114
        '
        'LblHoursTo
        '
        Me.LblHoursTo.AutoSize = True
        Me.LblHoursTo.Location = New System.Drawing.Point(54, 177)
        Me.LblHoursTo.Name = "LblHoursTo"
        Me.LblHoursTo.Size = New System.Drawing.Size(145, 13)
        Me.LblHoursTo.TabIndex = 113
        Me.LblHoursTo.Text = "Hours of training to complete:"
        '
        'TxtHoursTo
        '
        Me.TxtHoursTo.Location = New System.Drawing.Point(19, 203)
        Me.TxtHoursTo.Name = "TxtHoursTo"
        Me.TxtHoursTo.ReadOnly = True
        Me.TxtHoursTo.Size = New System.Drawing.Size(218, 20)
        Me.TxtHoursTo.TabIndex = 112
        '
        'TrainingHours
        '
        Me.TrainingHours.AutoSize = True
        Me.TrainingHours.Location = New System.Drawing.Point(304, 106)
        Me.TrainingHours.Name = "TrainingHours"
        Me.TrainingHours.Size = New System.Drawing.Size(138, 13)
        Me.TrainingHours.TabIndex = 111
        Me.TrainingHours.Text = "Hours of Training per week:"
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(269, 131)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(218, 20)
        Me.TxtInput.TabIndex = 107
        '
        'LblTraining
        '
        Me.LblTraining.AutoSize = True
        Me.LblTraining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraining.Location = New System.Drawing.Point(303, 58)
        Me.LblTraining.Name = "LblTraining"
        Me.LblTraining.Size = New System.Drawing.Size(152, 20)
        Me.LblTraining.TabIndex = 110
        Me.LblTraining.Text = "Training Schemes"
        '
        'Training
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(757, 463)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.ListSport)
        Me.Controls.Add(Me.LblHoursOf)
        Me.Controls.Add(Me.LblMilesTo)
        Me.Controls.Add(Me.TxtMilesTo)
        Me.Controls.Add(Me.LblHoursTo)
        Me.Controls.Add(Me.TxtHoursTo)
        Me.Controls.Add(Me.TrainingHours)
        Me.Controls.Add(Me.TxtInput)
        Me.Controls.Add(Me.LblTraining)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(773, 502)
        Me.MinimumSize = New System.Drawing.Size(773, 502)
        Me.Name = "Training"
        Me.Text = "Training"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDone As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents ListSport As ListBox
    Friend WithEvents LblHoursOf As Label
    Friend WithEvents LblMilesTo As Label
    Friend WithEvents TxtMilesTo As TextBox
    Friend WithEvents LblHoursTo As Label
    Friend WithEvents TxtHoursTo As TextBox
    Friend WithEvents TrainingHours As Label
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents LblTraining As Label
End Class
