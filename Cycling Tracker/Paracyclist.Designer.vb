<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paracyclist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Paracyclist))
        Me.lblLogIn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Option1 = New System.Windows.Forms.CheckBox()
        Me.Option2 = New System.Windows.Forms.CheckBox()
        Me.Option4 = New System.Windows.Forms.CheckBox()
        Me.Option3 = New System.Windows.Forms.CheckBox()
        Me.btnKeep = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLogIn
        '
        Me.lblLogIn.AutoSize = True
        Me.lblLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn.Location = New System.Drawing.Point(42, 23)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(192, 20)
        Me.lblLogIn.TabIndex = 98
        Me.lblLogIn.Text = "Paracyclist Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "What type of bike do you use? (Tick One)"
        '
        'Option1
        '
        Me.Option1.AutoSize = True
        Me.Option1.Location = New System.Drawing.Point(97, 81)
        Me.Option1.Margin = New System.Windows.Forms.Padding(2)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(61, 17)
        Me.Option1.TabIndex = 100
        Me.Option1.Text = "C1 - C5"
        Me.Option1.UseVisualStyleBackColor = True
        '
        'Option2
        '
        Me.Option2.AutoSize = True
        Me.Option2.Location = New System.Drawing.Point(97, 107)
        Me.Option2.Margin = New System.Windows.Forms.Padding(2)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(61, 17)
        Me.Option2.TabIndex = 101
        Me.Option2.Text = "T1 - T2"
        Me.Option2.UseVisualStyleBackColor = True
        '
        'Option4
        '
        Me.Option4.AutoSize = True
        Me.Option4.Location = New System.Drawing.Point(97, 160)
        Me.Option4.Margin = New System.Windows.Forms.Padding(2)
        Me.Option4.Name = "Option4"
        Me.Option4.Size = New System.Drawing.Size(33, 17)
        Me.Option4.TabIndex = 102
        Me.Option4.Text = "B"
        Me.Option4.UseVisualStyleBackColor = True
        '
        'Option3
        '
        Me.Option3.AutoSize = True
        Me.Option3.Location = New System.Drawing.Point(97, 133)
        Me.Option3.Margin = New System.Windows.Forms.Padding(2)
        Me.Option3.Name = "Option3"
        Me.Option3.Size = New System.Drawing.Size(63, 17)
        Me.Option3.TabIndex = 103
        Me.Option3.Text = "H1 - H5"
        Me.Option3.UseVisualStyleBackColor = True
        '
        'btnKeep
        '
        Me.btnKeep.Image = Global.Cycling_Tracker.My.Resources.Resources.Complete
        Me.btnKeep.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKeep.Location = New System.Drawing.Point(80, 201)
        Me.btnKeep.Name = "btnKeep"
        Me.btnKeep.Size = New System.Drawing.Size(92, 80)
        Me.btnKeep.TabIndex = 104
        Me.btnKeep.Text = "Submit"
        Me.btnKeep.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKeep.UseVisualStyleBackColor = True
        '
        'Paracyclist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnKeep)
        Me.Controls.Add(Me.Option3)
        Me.Controls.Add(Me.Option4)
        Me.Controls.Add(Me.Option2)
        Me.Controls.Add(Me.Option1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLogIn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Paracyclist"
        Me.Text = "Paracyclist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogIn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Option1 As CheckBox
    Friend WithEvents Option2 As CheckBox
    Friend WithEvents Option4 As CheckBox
    Friend WithEvents Option3 As CheckBox
    Friend WithEvents btnKeep As Button
End Class
