<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalTrainer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonalTrainer))
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TrainerEmail = New System.Windows.Forms.TextBox()
        Me.LabelMobile = New System.Windows.Forms.Label()
        Me.TrainerMob = New System.Windows.Forms.TextBox()
        Me.LabelQual = New System.Windows.Forms.Label()
        Me.TrainerQual = New System.Windows.Forms.TextBox()
        Me.LabelLocation = New System.Windows.Forms.Label()
        Me.TrainerLoc = New System.Windows.Forms.TextBox()
        Me.LblTrainer = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.TrainerName = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnDone
        '
        Me.BtnDone.Image = Global.Cycling_Tracker.My.Resources.Resources.Back
        Me.BtnDone.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDone.Location = New System.Drawing.Point(226, 280)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(92, 86)
        Me.BtnDone.TabIndex = 16
        Me.BtnDone.Text = "Done"
        Me.BtnDone.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDone.UseVisualStyleBackColor = True
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(58, 228)
        Me.LabelEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(35, 13)
        Me.LabelEmail.TabIndex = 26
        Me.LabelEmail.Text = "Email:"
        '
        'TrainerEmail
        '
        Me.TrainerEmail.Location = New System.Drawing.Point(111, 227)
        Me.TrainerEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TrainerEmail.Name = "TrainerEmail"
        Me.TrainerEmail.ReadOnly = True
        Me.TrainerEmail.Size = New System.Drawing.Size(199, 20)
        Me.TrainerEmail.TabIndex = 25
        '
        'LabelMobile
        '
        Me.LabelMobile.AutoSize = True
        Me.LabelMobile.Location = New System.Drawing.Point(52, 195)
        Me.LabelMobile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMobile.Name = "LabelMobile"
        Me.LabelMobile.Size = New System.Drawing.Size(41, 13)
        Me.LabelMobile.TabIndex = 24
        Me.LabelMobile.Text = "Mobile:"
        '
        'TrainerMob
        '
        Me.TrainerMob.Location = New System.Drawing.Point(111, 195)
        Me.TrainerMob.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TrainerMob.Name = "TrainerMob"
        Me.TrainerMob.ReadOnly = True
        Me.TrainerMob.Size = New System.Drawing.Size(199, 20)
        Me.TrainerMob.TabIndex = 23
        '
        'LabelQual
        '
        Me.LabelQual.AutoSize = True
        Me.LabelQual.Location = New System.Drawing.Point(19, 165)
        Me.LabelQual.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelQual.Name = "LabelQual"
        Me.LabelQual.Size = New System.Drawing.Size(73, 13)
        Me.LabelQual.TabIndex = 22
        Me.LabelQual.Text = "Qualifications:"
        '
        'TrainerQual
        '
        Me.TrainerQual.Location = New System.Drawing.Point(111, 162)
        Me.TrainerQual.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TrainerQual.Name = "TrainerQual"
        Me.TrainerQual.ReadOnly = True
        Me.TrainerQual.Size = New System.Drawing.Size(199, 20)
        Me.TrainerQual.TabIndex = 21
        '
        'LabelLocation
        '
        Me.LabelLocation.AutoSize = True
        Me.LabelLocation.Location = New System.Drawing.Point(43, 129)
        Me.LabelLocation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLocation.Name = "LabelLocation"
        Me.LabelLocation.Size = New System.Drawing.Size(51, 13)
        Me.LabelLocation.TabIndex = 20
        Me.LabelLocation.Text = "Location:"
        '
        'TrainerLoc
        '
        Me.TrainerLoc.Location = New System.Drawing.Point(111, 129)
        Me.TrainerLoc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TrainerLoc.Name = "TrainerLoc"
        Me.TrainerLoc.ReadOnly = True
        Me.TrainerLoc.Size = New System.Drawing.Size(199, 20)
        Me.TrainerLoc.TabIndex = 19
        '
        'LblTrainer
        '
        Me.LblTrainer.AutoSize = True
        Me.LblTrainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTrainer.Location = New System.Drawing.Point(138, 47)
        Me.LblTrainer.Name = "LblTrainer"
        Me.LblTrainer.Size = New System.Drawing.Size(140, 20)
        Me.LblTrainer.TabIndex = 18
        Me.LblTrainer.Text = "Personal Trainer"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(56, 97)
        Me.LabelName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(38, 13)
        Me.LabelName.TabIndex = 17
        Me.LabelName.Text = "Name:"
        '
        'TrainerName
        '
        Me.TrainerName.Location = New System.Drawing.Point(111, 96)
        Me.TrainerName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TrainerName.Name = "TrainerName"
        Me.TrainerName.ReadOnly = True
        Me.TrainerName.Size = New System.Drawing.Size(199, 20)
        Me.TrainerName.TabIndex = 15
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Cycling_Tracker.My.Resources.Resources.Refresh
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.Location = New System.Drawing.Point(92, 280)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(92, 86)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'PersonalTrainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(376, 373)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.TrainerEmail)
        Me.Controls.Add(Me.LabelMobile)
        Me.Controls.Add(Me.TrainerMob)
        Me.Controls.Add(Me.LabelQual)
        Me.Controls.Add(Me.TrainerQual)
        Me.Controls.Add(Me.LabelLocation)
        Me.Controls.Add(Me.TrainerLoc)
        Me.Controls.Add(Me.LblTrainer)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.TrainerName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(392, 412)
        Me.MinimumSize = New System.Drawing.Size(392, 412)
        Me.Name = "PersonalTrainer"
        Me.Text = "PersonalTrainer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDone As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TrainerEmail As TextBox
    Friend WithEvents LabelMobile As Label
    Friend WithEvents TrainerMob As TextBox
    Friend WithEvents LabelQual As Label
    Friend WithEvents TrainerQual As TextBox
    Friend WithEvents LabelLocation As Label
    Friend WithEvents TrainerLoc As TextBox
    Friend WithEvents LblTrainer As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents TrainerName As TextBox
End Class
