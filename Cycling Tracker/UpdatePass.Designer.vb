<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatePass))
        Me.LblCheck = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.LblRepeat = New System.Windows.Forms.Label()
        Me.TxtRepeat = New System.Windows.Forms.TextBox()
        Me.LblNew = New System.Windows.Forms.Label()
        Me.TxtNew = New System.Windows.Forms.TextBox()
        Me.LblUpdatePass = New System.Windows.Forms.Label()
        Me.LblOld = New System.Windows.Forms.Label()
        Me.TxtOld = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblCheck
        '
        Me.LblCheck.AutoSize = True
        Me.LblCheck.ForeColor = System.Drawing.Color.Red
        Me.LblCheck.Location = New System.Drawing.Point(78, 282)
        Me.LblCheck.Name = "LblCheck"
        Me.LblCheck.Size = New System.Drawing.Size(143, 13)
        Me.LblCheck.TabIndex = 89
        Me.LblCheck.Text = "New passwords don't match!"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Image = Global.Cycling_Tracker.My.Resources.Resources.Complete
        Me.BtnSubmit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSubmit.Location = New System.Drawing.Point(96, 310)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(93, 89)
        Me.BtnSubmit.TabIndex = 85
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'LblRepeat
        '
        Me.LblRepeat.AutoSize = True
        Me.LblRepeat.Location = New System.Drawing.Point(91, 228)
        Me.LblRepeat.Name = "LblRepeat"
        Me.LblRepeat.Size = New System.Drawing.Size(119, 13)
        Me.LblRepeat.TabIndex = 88
        Me.LblRepeat.Text = "Repeat New Password:"
        '
        'TxtRepeat
        '
        Me.TxtRepeat.Location = New System.Drawing.Point(75, 250)
        Me.TxtRepeat.Multiline = True
        Me.TxtRepeat.Name = "TxtRepeat"
        Me.TxtRepeat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtRepeat.Size = New System.Drawing.Size(146, 20)
        Me.TxtRepeat.TabIndex = 84
        '
        'LblNew
        '
        Me.LblNew.AutoSize = True
        Me.LblNew.Location = New System.Drawing.Point(111, 165)
        Me.LblNew.Name = "LblNew"
        Me.LblNew.Size = New System.Drawing.Size(81, 13)
        Me.LblNew.TabIndex = 87
        Me.LblNew.Text = "New Password:"
        '
        'TxtNew
        '
        Me.TxtNew.Location = New System.Drawing.Point(75, 187)
        Me.TxtNew.Multiline = True
        Me.TxtNew.Name = "TxtNew"
        Me.TxtNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtNew.Size = New System.Drawing.Size(146, 20)
        Me.TxtNew.TabIndex = 82
        '
        'LblUpdatePass
        '
        Me.LblUpdatePass.AutoSize = True
        Me.LblUpdatePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUpdatePass.Location = New System.Drawing.Point(71, 41)
        Me.LblUpdatePass.Name = "LblUpdatePass"
        Me.LblUpdatePass.Size = New System.Drawing.Size(150, 20)
        Me.LblUpdatePass.TabIndex = 86
        Me.LblUpdatePass.Text = "Update Password"
        '
        'LblOld
        '
        Me.LblOld.AutoSize = True
        Me.LblOld.Location = New System.Drawing.Point(112, 100)
        Me.LblOld.Name = "LblOld"
        Me.LblOld.Size = New System.Drawing.Size(75, 13)
        Me.LblOld.TabIndex = 83
        Me.LblOld.Text = "Old Password:"
        '
        'TxtOld
        '
        Me.TxtOld.Location = New System.Drawing.Point(75, 122)
        Me.TxtOld.Multiline = True
        Me.TxtOld.Name = "TxtOld"
        Me.TxtOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtOld.Size = New System.Drawing.Size(146, 20)
        Me.TxtOld.TabIndex = 81
        '
        'UpdatePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(291, 396)
        Me.Controls.Add(Me.LblCheck)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LblRepeat)
        Me.Controls.Add(Me.TxtRepeat)
        Me.Controls.Add(Me.LblNew)
        Me.Controls.Add(Me.TxtNew)
        Me.Controls.Add(Me.LblUpdatePass)
        Me.Controls.Add(Me.LblOld)
        Me.Controls.Add(Me.TxtOld)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(307, 435)
        Me.MinimumSize = New System.Drawing.Size(307, 435)
        Me.Name = "UpdatePass"
        Me.Text = "UpdatePass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCheck As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents LblRepeat As Label
    Friend WithEvents TxtRepeat As TextBox
    Friend WithEvents LblNew As Label
    Friend WithEvents TxtNew As TextBox
    Friend WithEvents LblUpdatePass As Label
    Friend WithEvents LblOld As Label
    Friend WithEvents TxtOld As TextBox
End Class
