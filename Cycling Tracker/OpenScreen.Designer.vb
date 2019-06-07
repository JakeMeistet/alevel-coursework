<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenScreen))
        Me.InvalidPass = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PasswordRegister = New System.Windows.Forms.TextBox()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SurnameRegister = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ForenameRegister = New System.Windows.Forms.TextBox()
        Me.Register = New System.Windows.Forms.Label()
        Me.lblLogIn = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordLogIn = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnLogIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InvalidPass
        '
        Me.InvalidPass.AutoSize = True
        Me.InvalidPass.ForeColor = System.Drawing.Color.Red
        Me.InvalidPass.Location = New System.Drawing.Point(169, 185)
        Me.InvalidPass.Name = "InvalidPass"
        Me.InvalidPass.Size = New System.Drawing.Size(87, 13)
        Me.InvalidPass.TabIndex = 44
        Me.InvalidPass.Text = "Invalid Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(100, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(123, 111)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(176, 20)
        Me.TxtID.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Password"
        '
        'PasswordRegister
        '
        Me.PasswordRegister.Location = New System.Drawing.Point(123, 373)
        Me.PasswordRegister.Name = "PasswordRegister"
        Me.PasswordRegister.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordRegister.Size = New System.Drawing.Size(176, 20)
        Me.PasswordRegister.TabIndex = 6
        '
        'BtnRegister
        '
        Me.BtnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnRegister.Image = Global.Cycling_Tracker.My.Resources.Resources.Register
        Me.BtnRegister.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRegister.Location = New System.Drawing.Point(343, 305)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(94, 88)
        Me.BtnRegister.TabIndex = 7
        Me.BtnRegister.Text = "Register (F3)"
        Me.BtnRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Surname"
        '
        'SurnameRegister
        '
        Me.SurnameRegister.Location = New System.Drawing.Point(123, 330)
        Me.SurnameRegister.Name = "SurnameRegister"
        Me.SurnameRegister.Size = New System.Drawing.Size(176, 20)
        Me.SurnameRegister.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Forename"
        '
        'ForenameRegister
        '
        Me.ForenameRegister.Location = New System.Drawing.Point(123, 284)
        Me.ForenameRegister.Name = "ForenameRegister"
        Me.ForenameRegister.Size = New System.Drawing.Size(176, 20)
        Me.ForenameRegister.TabIndex = 3
        '
        'Register
        '
        Me.Register.AutoSize = True
        Me.Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register.Location = New System.Drawing.Point(168, 242)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(77, 20)
        Me.Register.TabIndex = 38
        Me.Register.Text = "Register"
        '
        'lblLogIn
        '
        Me.lblLogIn.AutoSize = True
        Me.lblLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn.Location = New System.Drawing.Point(174, 75)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(60, 20)
        Me.lblLogIn.TabIndex = 32
        Me.lblLogIn.Text = "Log In"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Password"
        '
        'PasswordLogIn
        '
        Me.PasswordLogIn.Location = New System.Drawing.Point(123, 160)
        Me.PasswordLogIn.Name = "PasswordLogIn"
        Me.PasswordLogIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordLogIn.Size = New System.Drawing.Size(176, 20)
        Me.PasswordLogIn.TabIndex = 1
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.Image = Global.Cycling_Tracker.My.Resources.Resources._Exit
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExit.Location = New System.Drawing.Point(343, 195)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 88)
        Me.BtnExit.TabIndex = 8
        Me.BtnExit.Text = "Exit (F2)"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnLogIn
        '
        Me.BtnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnLogIn.Image = Global.Cycling_Tracker.My.Resources.Resources.Login
        Me.BtnLogIn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLogIn.Location = New System.Drawing.Point(343, 84)
        Me.BtnLogIn.Name = "BtnLogIn"
        Me.BtnLogIn.Size = New System.Drawing.Size(94, 88)
        Me.BtnLogIn.TabIndex = 2
        Me.BtnLogIn.Text = "Log In (F1)"
        Me.BtnLogIn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnLogIn.UseVisualStyleBackColor = True
        '
        'OpenScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.InvalidPass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PasswordRegister)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SurnameRegister)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ForenameRegister)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.BtnLogIn)
        Me.Controls.Add(Me.lblLogIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordLogIn)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(490, 480)
        Me.MinimumSize = New System.Drawing.Size(490, 480)
        Me.Name = "OpenScreen"
        Me.Text = "OpenScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InvalidPass As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PasswordRegister As TextBox
    Friend WithEvents BtnRegister As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents SurnameRegister As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ForenameRegister As TextBox
    Friend WithEvents Register As Label
    Friend WithEvents BtnLogIn As Button
    Friend WithEvents lblLogIn As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordLogIn As TextBox
    Friend WithEvents BtnExit As Button
End Class
