<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Weight = New System.Windows.Forms.TextBox()
        Me.Height1 = New System.Windows.Forms.TextBox()
        Me.DOB = New System.Windows.Forms.TextBox()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SName = New System.Windows.Forms.TextBox()
        Me.FName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnUpdatePass = New System.Windows.Forms.Button()
        Me.BtnUpdatePersonal = New System.Windows.Forms.Button()
        Me.BtnEquipment = New System.Windows.Forms.Button()
        Me.BtnPersonalTrainer = New System.Windows.Forms.Button()
        Me.BtnTrainingR = New System.Windows.Forms.Button()
        Me.BtnCharityStats = New System.Windows.Forms.Button()
        Me.BtnCyclistSearch = New System.Windows.Forms.Button()
        Me.BtnPTracking = New System.Windows.Forms.Button()
        Me.BtnLeaderboard = New System.Windows.Forms.Button()
        Me.BtnCharity = New System.Windows.Forms.Button()
        Me.BtnCycling = New System.Windows.Forms.Button()
        Me.TxtPara = New System.Windows.Forms.TextBox()
        Me.LblPara = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Weight
        '
        Me.Weight.Location = New System.Drawing.Point(120, 301)
        Me.Weight.Name = "Weight"
        Me.Weight.ReadOnly = True
        Me.Weight.Size = New System.Drawing.Size(130, 20)
        Me.Weight.TabIndex = 110
        Me.Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Height1
        '
        Me.Height1.Location = New System.Drawing.Point(120, 248)
        Me.Height1.Name = "Height1"
        Me.Height1.ReadOnly = True
        Me.Height1.Size = New System.Drawing.Size(130, 20)
        Me.Height1.TabIndex = 109
        Me.Height1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DOB
        '
        Me.DOB.Location = New System.Drawing.Point(120, 194)
        Me.DOB.Name = "DOB"
        Me.DOB.ReadOnly = True
        Me.DOB.Size = New System.Drawing.Size(130, 20)
        Me.DOB.TabIndex = 108
        Me.DOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(152, 51)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(47, 20)
        Me.LblUser.TabIndex = 107
        Me.LblUser.Text = "User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Weight:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Height:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(159, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 103
        '
        'SName
        '
        Me.SName.Location = New System.Drawing.Point(120, 140)
        Me.SName.Name = "SName"
        Me.SName.ReadOnly = True
        Me.SName.Size = New System.Drawing.Size(130, 20)
        Me.SName.TabIndex = 102
        Me.SName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FName
        '
        Me.FName.Location = New System.Drawing.Point(120, 92)
        Me.FName.Name = "FName"
        Me.FName.ReadOnly = True
        Me.FName.Size = New System.Drawing.Size(130, 20)
        Me.FName.TabIndex = 101
        Me.FName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Date of Birth:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Surname:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Forename:"
        '
        'BtnExit
        '
        Me.BtnExit.Image = Global.Cycling_Tracker.My.Resources.Resources.Sign_Out
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExit.Location = New System.Drawing.Point(728, 289)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(95, 104)
        Me.BtnExit.TabIndex = 97
        Me.BtnExit.Text = "Sign Out (F12)"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnUpdatePass
        '
        Me.BtnUpdatePass.Image = Global.Cycling_Tracker.My.Resources.Resources.Password
        Me.BtnUpdatePass.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUpdatePass.Location = New System.Drawing.Point(728, 163)
        Me.BtnUpdatePass.Name = "BtnUpdatePass"
        Me.BtnUpdatePass.Size = New System.Drawing.Size(95, 104)
        Me.BtnUpdatePass.TabIndex = 96
        Me.BtnUpdatePass.Text = "Update Password (F11)"
        Me.BtnUpdatePass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUpdatePass.UseVisualStyleBackColor = True
        '
        'BtnUpdatePersonal
        '
        Me.BtnUpdatePersonal.Image = Global.Cycling_Tracker.My.Resources.Resources.PersonalDetails
        Me.BtnUpdatePersonal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUpdatePersonal.Location = New System.Drawing.Point(728, 37)
        Me.BtnUpdatePersonal.Name = "BtnUpdatePersonal"
        Me.BtnUpdatePersonal.Size = New System.Drawing.Size(95, 105)
        Me.BtnUpdatePersonal.TabIndex = 95
        Me.BtnUpdatePersonal.Text = "Update Personal Details (F10)"
        Me.BtnUpdatePersonal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUpdatePersonal.UseVisualStyleBackColor = True
        '
        'BtnEquipment
        '
        Me.BtnEquipment.Image = Global.Cycling_Tracker.My.Resources.Resources.Equipment
        Me.BtnEquipment.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEquipment.Location = New System.Drawing.Point(591, 289)
        Me.BtnEquipment.Name = "BtnEquipment"
        Me.BtnEquipment.Size = New System.Drawing.Size(95, 104)
        Me.BtnEquipment.TabIndex = 94
        Me.BtnEquipment.Text = "Reccomended Cycling Equipment (F9)"
        Me.BtnEquipment.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEquipment.UseVisualStyleBackColor = True
        '
        'BtnPersonalTrainer
        '
        Me.BtnPersonalTrainer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPersonalTrainer.Image = Global.Cycling_Tracker.My.Resources.Resources.Personal_Trainer
        Me.BtnPersonalTrainer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPersonalTrainer.Location = New System.Drawing.Point(591, 163)
        Me.BtnPersonalTrainer.Name = "BtnPersonalTrainer"
        Me.BtnPersonalTrainer.Size = New System.Drawing.Size(95, 104)
        Me.BtnPersonalTrainer.TabIndex = 93
        Me.BtnPersonalTrainer.Text = "Personal Trainer Contacts (F8)"
        Me.BtnPersonalTrainer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPersonalTrainer.UseVisualStyleBackColor = True
        '
        'BtnTrainingR
        '
        Me.BtnTrainingR.Image = Global.Cycling_Tracker.My.Resources.Resources.Trainer
        Me.BtnTrainingR.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTrainingR.Location = New System.Drawing.Point(591, 37)
        Me.BtnTrainingR.Name = "BtnTrainingR"
        Me.BtnTrainingR.Size = New System.Drawing.Size(95, 105)
        Me.BtnTrainingR.TabIndex = 92
        Me.BtnTrainingR.Text = "Training Regime (F7)"
        Me.BtnTrainingR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTrainingR.UseVisualStyleBackColor = True
        '
        'BtnCharityStats
        '
        Me.BtnCharityStats.Image = Global.Cycling_Tracker.My.Resources.Resources.CharityStats
        Me.BtnCharityStats.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCharityStats.Location = New System.Drawing.Point(451, 289)
        Me.BtnCharityStats.Name = "BtnCharityStats"
        Me.BtnCharityStats.Size = New System.Drawing.Size(95, 104)
        Me.BtnCharityStats.TabIndex = 91
        Me.BtnCharityStats.Text = "Charity Statistics (F6)"
        Me.BtnCharityStats.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCharityStats.UseVisualStyleBackColor = True
        '
        'BtnCyclistSearch
        '
        Me.BtnCyclistSearch.Image = Global.Cycling_Tracker.My.Resources.Resources.Search
        Me.BtnCyclistSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCyclistSearch.Location = New System.Drawing.Point(311, 289)
        Me.BtnCyclistSearch.Name = "BtnCyclistSearch"
        Me.BtnCyclistSearch.Size = New System.Drawing.Size(95, 104)
        Me.BtnCyclistSearch.TabIndex = 88
        Me.BtnCyclistSearch.Text = "Search (F3)"
        Me.BtnCyclistSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCyclistSearch.UseVisualStyleBackColor = True
        '
        'BtnPTracking
        '
        Me.BtnPTracking.Image = Global.Cycling_Tracker.My.Resources.Resources.Tracking_11_48_48
        Me.BtnPTracking.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPTracking.Location = New System.Drawing.Point(451, 163)
        Me.BtnPTracking.Name = "BtnPTracking"
        Me.BtnPTracking.Size = New System.Drawing.Size(95, 104)
        Me.BtnPTracking.TabIndex = 90
        Me.BtnPTracking.Text = "Personal Tracking (F5)"
        Me.BtnPTracking.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPTracking.UseVisualStyleBackColor = True
        '
        'BtnLeaderboard
        '
        Me.BtnLeaderboard.Image = Global.Cycling_Tracker.My.Resources.Resources.Leaderboard
        Me.BtnLeaderboard.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLeaderboard.Location = New System.Drawing.Point(311, 163)
        Me.BtnLeaderboard.Name = "BtnLeaderboard"
        Me.BtnLeaderboard.Size = New System.Drawing.Size(95, 104)
        Me.BtnLeaderboard.TabIndex = 87
        Me.BtnLeaderboard.Text = "Personal Leaderboard (F2)"
        Me.BtnLeaderboard.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnLeaderboard.UseVisualStyleBackColor = True
        '
        'BtnCharity
        '
        Me.BtnCharity.Image = Global.Cycling_Tracker.My.Resources.Resources.Charity
        Me.BtnCharity.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCharity.Location = New System.Drawing.Point(451, 37)
        Me.BtnCharity.Name = "BtnCharity"
        Me.BtnCharity.Size = New System.Drawing.Size(95, 105)
        Me.BtnCharity.TabIndex = 89
        Me.BtnCharity.Text = "Input Charity Data (F4)"
        Me.BtnCharity.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCharity.UseVisualStyleBackColor = True
        '
        'BtnCycling
        '
        Me.BtnCycling.Image = Global.Cycling_Tracker.My.Resources.Resources.Cycling_Data
        Me.BtnCycling.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCycling.Location = New System.Drawing.Point(311, 37)
        Me.BtnCycling.Name = "BtnCycling"
        Me.BtnCycling.Size = New System.Drawing.Size(95, 105)
        Me.BtnCycling.TabIndex = 86
        Me.BtnCycling.Text = "Input Cycling Data (F1)"
        Me.BtnCycling.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCycling.UseVisualStyleBackColor = True
        '
        'TxtPara
        '
        Me.TxtPara.Location = New System.Drawing.Point(120, 346)
        Me.TxtPara.Name = "TxtPara"
        Me.TxtPara.ReadOnly = True
        Me.TxtPara.Size = New System.Drawing.Size(130, 20)
        Me.TxtPara.TabIndex = 112
        Me.TxtPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblPara
        '
        Me.LblPara.AutoSize = True
        Me.LblPara.Location = New System.Drawing.Point(53, 349)
        Me.LblPara.Name = "LblPara"
        Me.LblPara.Size = New System.Drawing.Size(61, 13)
        Me.LblPara.TabIndex = 111
        Me.LblPara.Text = "Paracyclist:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(881, 427)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtPara)
        Me.Controls.Add(Me.LblPara)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnUpdatePass)
        Me.Controls.Add(Me.BtnUpdatePersonal)
        Me.Controls.Add(Me.Weight)
        Me.Controls.Add(Me.Height1)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.BtnEquipment)
        Me.Controls.Add(Me.BtnPersonalTrainer)
        Me.Controls.Add(Me.BtnTrainingR)
        Me.Controls.Add(Me.BtnCharityStats)
        Me.Controls.Add(Me.BtnCyclistSearch)
        Me.Controls.Add(Me.BtnPTracking)
        Me.Controls.Add(Me.BtnLeaderboard)
        Me.Controls.Add(Me.BtnCharity)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SName)
        Me.Controls.Add(Me.FName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCycling)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(897, 466)
        Me.MinimumSize = New System.Drawing.Size(897, 466)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnUpdatePass As Button
    Friend WithEvents BtnUpdatePersonal As Button
    Friend WithEvents Weight As TextBox
    Friend WithEvents Height1 As TextBox
    Friend WithEvents DOB As TextBox
    Friend WithEvents BtnEquipment As Button
    Friend WithEvents BtnPersonalTrainer As Button
    Friend WithEvents BtnTrainingR As Button
    Friend WithEvents BtnCharityStats As Button
    Friend WithEvents BtnCyclistSearch As Button
    Friend WithEvents BtnPTracking As Button
    Friend WithEvents BtnLeaderboard As Button
    Friend WithEvents BtnCharity As Button
    Friend WithEvents LblUser As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SName As TextBox
    Friend WithEvents FName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCycling As Button
    Friend WithEvents TxtPara As TextBox
    Friend WithEvents LblPara As Label
End Class
