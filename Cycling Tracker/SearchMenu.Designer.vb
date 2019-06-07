<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchMenu))
        Me.InvalidPass = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblAdmin = New System.Windows.Forms.Label()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.BtnAdmin = New System.Windows.Forms.Button()
        Me.BtnKnown = New System.Windows.Forms.Button()
        Me.BtnOther = New System.Windows.Forms.Button()
        Me.BtnPersonal = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InvalidPass
        '
        Me.InvalidPass.AutoSize = True
        Me.InvalidPass.ForeColor = System.Drawing.Color.Red
        Me.InvalidPass.Location = New System.Drawing.Point(168, 227)
        Me.InvalidPass.Name = "InvalidPass"
        Me.InvalidPass.Size = New System.Drawing.Size(87, 13)
        Me.InvalidPass.TabIndex = 88
        Me.InvalidPass.Text = "Invalid Password"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(189, 64)
        Me.LblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(56, 13)
        Me.LblPassword.TabIndex = 87
        Me.LblPassword.Text = "Password:"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(90, 95)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtPassword.Size = New System.Drawing.Size(264, 20)
        Me.TxtPassword.TabIndex = 83
        '
        'LblAdmin
        '
        Me.LblAdmin.AutoSize = True
        Me.LblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdmin.Location = New System.Drawing.Point(165, 22)
        Me.LblAdmin.Name = "LblAdmin"
        Me.LblAdmin.Size = New System.Drawing.Size(108, 20)
        Me.LblAdmin.TabIndex = 86
        Me.LblAdmin.Text = "Admin Login"
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearch.Location = New System.Drawing.Point(182, 42)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(66, 20)
        Me.LblSearch.TabIndex = 85
        Me.LblSearch.Text = "Search"
        '
        'BtnAdmin
        '
        Me.BtnAdmin.Image = Global.Cycling_Tracker.My.Resources.Resources.Admin
        Me.BtnAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdmin.Location = New System.Drawing.Point(109, 129)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.Size = New System.Drawing.Size(88, 85)
        Me.BtnAdmin.TabIndex = 84
        Me.BtnAdmin.Text = "Login"
        Me.BtnAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAdmin.UseVisualStyleBackColor = True
        '
        'BtnKnown
        '
        Me.BtnKnown.Image = Global.Cycling_Tracker.My.Resources.Resources.Search_Known
        Me.BtnKnown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKnown.Location = New System.Drawing.Point(291, 88)
        Me.BtnKnown.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnKnown.Name = "BtnKnown"
        Me.BtnKnown.Size = New System.Drawing.Size(88, 137)
        Me.BtnKnown.TabIndex = 82
        Me.BtnKnown.Text = "Search known cyclist's LEJOG/ JOGLE data (F3)"
        Me.BtnKnown.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnKnown.UseVisualStyleBackColor = True
        '
        'BtnOther
        '
        Me.BtnOther.Image = Global.Cycling_Tracker.My.Resources.Resources.Search_Other
        Me.BtnOther.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnOther.Location = New System.Drawing.Point(169, 88)
        Me.BtnOther.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnOther.Name = "BtnOther"
        Me.BtnOther.Size = New System.Drawing.Size(88, 137)
        Me.BtnOther.TabIndex = 81
        Me.BtnOther.Text = "Search another user's cycing data (requires password) (f2)"
        Me.BtnOther.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnOther.UseVisualStyleBackColor = True
        '
        'BtnPersonal
        '
        Me.BtnPersonal.Image = Global.Cycling_Tracker.My.Resources.Resources.SearchMe
        Me.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPersonal.Location = New System.Drawing.Point(45, 88)
        Me.BtnPersonal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnPersonal.Name = "BtnPersonal"
        Me.BtnPersonal.Size = New System.Drawing.Size(88, 137)
        Me.BtnPersonal.TabIndex = 80
        Me.BtnPersonal.Text = "Search  personal cycling data (F1)"
        Me.BtnPersonal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPersonal.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Image = Global.Cycling_Tracker.My.Resources.Resources.Back
        Me.BtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBack.Location = New System.Drawing.Point(231, 129)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(88, 85)
        Me.BtnBack.TabIndex = 89
        Me.BtnBack.Text = "Back"
        Me.BtnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'SearchMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 229)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.InvalidPass)
        Me.Controls.Add(Me.BtnAdmin)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblAdmin)
        Me.Controls.Add(Me.LblSearch)
        Me.Controls.Add(Me.BtnKnown)
        Me.Controls.Add(Me.BtnOther)
        Me.Controls.Add(Me.BtnPersonal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(435, 268)
        Me.MinimumSize = New System.Drawing.Size(435, 268)
        Me.Name = "SearchMenu"
        Me.Text = "SearchMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InvalidPass As Label
    Friend WithEvents BtnAdmin As Button
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblAdmin As Label
    Friend WithEvents LblSearch As Label
    Friend WithEvents BtnKnown As Button
    Friend WithEvents BtnOther As Button
    Friend WithEvents BtnPersonal As Button
    Friend WithEvents BtnBack As Button
End Class
