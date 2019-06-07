<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputCharity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputCharity))
        Me.GiftAid = New System.Windows.Forms.TextBox()
        Me.Raised = New System.Windows.Forms.TextBox()
        Me.Goal = New System.Windows.Forms.TextBox()
        Me.CharityName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblInputCharity = New System.Windows.Forms.Label()
        Me.btnKeep = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GiftAid
        '
        Me.GiftAid.Location = New System.Drawing.Point(152, 187)
        Me.GiftAid.Name = "GiftAid"
        Me.GiftAid.Size = New System.Drawing.Size(130, 20)
        Me.GiftAid.TabIndex = 88
        Me.GiftAid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Raised
        '
        Me.Raised.Location = New System.Drawing.Point(152, 147)
        Me.Raised.Name = "Raised"
        Me.Raised.Size = New System.Drawing.Size(130, 20)
        Me.Raised.TabIndex = 87
        Me.Raised.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Goal
        '
        Me.Goal.Location = New System.Drawing.Point(152, 107)
        Me.Goal.Name = "Goal"
        Me.Goal.Size = New System.Drawing.Size(130, 20)
        Me.Goal.TabIndex = 86
        Me.Goal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CharityName
        '
        Me.CharityName.Location = New System.Drawing.Point(152, 70)
        Me.CharityName.Name = "CharityName"
        Me.CharityName.Size = New System.Drawing.Size(130, 20)
        Me.CharityName.TabIndex = 85
        Me.CharityName.Text = "Input ID if editing a charity"
        Me.CharityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Gift Aid: £"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Raised: £"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Goal: £"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Charity name/ID:"
        '
        'LblInputCharity
        '
        Me.LblInputCharity.AutoSize = True
        Me.LblInputCharity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInputCharity.Location = New System.Drawing.Point(73, 26)
        Me.LblInputCharity.Name = "LblInputCharity"
        Me.LblInputCharity.Size = New System.Drawing.Size(209, 20)
        Me.LblInputCharity.TabIndex = 96
        Me.LblInputCharity.Text = "Input Charity Information"
        '
        'btnKeep
        '
        Me.btnKeep.Image = Global.Cycling_Tracker.My.Resources.Resources.Complete
        Me.btnKeep.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKeep.Location = New System.Drawing.Point(140, 230)
        Me.btnKeep.Name = "btnKeep"
        Me.btnKeep.Size = New System.Drawing.Size(92, 84)
        Me.btnKeep.TabIndex = 89
        Me.btnKeep.Text = "Submit"
        Me.btnKeep.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKeep.UseVisualStyleBackColor = True
        '
        'InputCharity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(338, 310)
        Me.Controls.Add(Me.LblInputCharity)
        Me.Controls.Add(Me.btnKeep)
        Me.Controls.Add(Me.GiftAid)
        Me.Controls.Add(Me.Raised)
        Me.Controls.Add(Me.Goal)
        Me.Controls.Add(Me.CharityName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(354, 349)
        Me.MinimumSize = New System.Drawing.Size(354, 349)
        Me.Name = "InputCharity"
        Me.Text = "InputCharity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKeep As Button
    Friend WithEvents GiftAid As TextBox
    Friend WithEvents Raised As TextBox
    Friend WithEvents Goal As TextBox
    Friend WithEvents CharityName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblInputCharity As Label
End Class
