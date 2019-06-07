<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharityInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharityInformation))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LblTGift = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TxtTotalG = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.LblPercentage = New System.Windows.Forms.Label()
        Me.LblAGiftAid = New System.Windows.Forms.Label()
        Me.LblARaised = New System.Windows.Forms.Label()
        Me.TxtPercentage = New System.Windows.Forms.TextBox()
        Me.TxtARaised = New System.Windows.Forms.TextBox()
        Me.TxtAGiftAid = New System.Windows.Forms.TextBox()
        Me.LblCharityInfo = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.ToRaise = New System.Windows.Forms.Label()
        Me.TxtToRaise = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(254, 124)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(464, 355)
        Me.ListBox1.TabIndex = 148
        '
        'LblTGift
        '
        Me.LblTGift.AutoSize = True
        Me.LblTGift.Location = New System.Drawing.Point(63, 406)
        Me.LblTGift.Name = "LblTGift"
        Me.LblTGift.Size = New System.Drawing.Size(71, 13)
        Me.LblTGift.TabIndex = 154
        Me.LblTGift.Text = "Total Gift Aid:"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(64, 350)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(70, 13)
        Me.LblTotal.TabIndex = 153
        Me.LblTotal.Text = "Total Raised:"
        '
        'TxtTotalG
        '
        Me.TxtTotalG.Location = New System.Drawing.Point(21, 422)
        Me.TxtTotalG.Name = "TxtTotalG"
        Me.TxtTotalG.ReadOnly = True
        Me.TxtTotalG.Size = New System.Drawing.Size(153, 20)
        Me.TxtTotalG.TabIndex = 147
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(21, 366)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(153, 20)
        Me.TxtTotal.TabIndex = 146
        '
        'BtnDone
        '
        Me.BtnDone.Image = Global.Cycling_Tracker.My.Resources.Resources.Back
        Me.BtnDone.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDone.Location = New System.Drawing.Point(43, 456)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(99, 82)
        Me.BtnDone.TabIndex = 140
        Me.BtnDone.Text = "Done"
        Me.BtnDone.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDone.UseVisualStyleBackColor = True
        '
        'LblPercentage
        '
        Me.LblPercentage.AutoSize = True
        Me.LblPercentage.Location = New System.Drawing.Point(31, 295)
        Me.LblPercentage.Name = "LblPercentage"
        Me.LblPercentage.Size = New System.Drawing.Size(136, 13)
        Me.LblPercentage.TabIndex = 152
        Me.LblPercentage.Text = "Percentage of recent goal: "
        '
        'LblAGiftAid
        '
        Me.LblAGiftAid.AutoSize = True
        Me.LblAGiftAid.Location = New System.Drawing.Point(53, 239)
        Me.LblAGiftAid.Name = "LblAGiftAid"
        Me.LblAGiftAid.Size = New System.Drawing.Size(84, 13)
        Me.LblAGiftAid.TabIndex = 151
        Me.LblAGiftAid.Text = "Average GiftAid:"
        '
        'LblARaised
        '
        Me.LblARaised.AutoSize = True
        Me.LblARaised.Location = New System.Drawing.Point(51, 183)
        Me.LblARaised.Name = "LblARaised"
        Me.LblARaised.Size = New System.Drawing.Size(86, 13)
        Me.LblARaised.TabIndex = 150
        Me.LblARaised.Text = "Average Raised:"
        '
        'TxtPercentage
        '
        Me.TxtPercentage.Location = New System.Drawing.Point(21, 311)
        Me.TxtPercentage.Name = "TxtPercentage"
        Me.TxtPercentage.ReadOnly = True
        Me.TxtPercentage.Size = New System.Drawing.Size(153, 20)
        Me.TxtPercentage.TabIndex = 145
        '
        'TxtARaised
        '
        Me.TxtARaised.Location = New System.Drawing.Point(21, 199)
        Me.TxtARaised.Name = "TxtARaised"
        Me.TxtARaised.ReadOnly = True
        Me.TxtARaised.Size = New System.Drawing.Size(153, 20)
        Me.TxtARaised.TabIndex = 141
        '
        'TxtAGiftAid
        '
        Me.TxtAGiftAid.Location = New System.Drawing.Point(21, 255)
        Me.TxtAGiftAid.Name = "TxtAGiftAid"
        Me.TxtAGiftAid.ReadOnly = True
        Me.TxtAGiftAid.Size = New System.Drawing.Size(153, 20)
        Me.TxtAGiftAid.TabIndex = 143
        '
        'LblCharityInfo
        '
        Me.LblCharityInfo.AutoSize = True
        Me.LblCharityInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCharityInfo.Location = New System.Drawing.Point(310, 62)
        Me.LblCharityInfo.Name = "LblCharityInfo"
        Me.LblCharityInfo.Size = New System.Drawing.Size(162, 20)
        Me.LblCharityInfo.TabIndex = 149
        Me.LblCharityInfo.Text = "Charity Information"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(86, 73)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(21, 13)
        Me.LblID.TabIndex = 142
        Me.LblID.Text = "ID:"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(21, 89)
        Me.TxtID.Multiline = True
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(154, 20)
        Me.TxtID.TabIndex = 144
        '
        'ToRaise
        '
        Me.ToRaise.AutoSize = True
        Me.ToRaise.Location = New System.Drawing.Point(27, 127)
        Me.ToRaise.Name = "ToRaise"
        Me.ToRaise.Size = New System.Drawing.Size(147, 13)
        Me.ToRaise.TabIndex = 156
        Me.ToRaise.Text = "Money to raise of recent goal:"
        '
        'TxtToRaise
        '
        Me.TxtToRaise.Location = New System.Drawing.Point(21, 143)
        Me.TxtToRaise.Name = "TxtToRaise"
        Me.TxtToRaise.ReadOnly = True
        Me.TxtToRaise.Size = New System.Drawing.Size(153, 20)
        Me.TxtToRaise.TabIndex = 155
        '
        'CharityInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(737, 535)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LblTGift)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.TxtTotalG)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.LblPercentage)
        Me.Controls.Add(Me.LblAGiftAid)
        Me.Controls.Add(Me.LblARaised)
        Me.Controls.Add(Me.TxtPercentage)
        Me.Controls.Add(Me.TxtARaised)
        Me.Controls.Add(Me.TxtAGiftAid)
        Me.Controls.Add(Me.LblCharityInfo)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.ToRaise)
        Me.Controls.Add(Me.TxtToRaise)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(753, 591)
        Me.MinimumSize = New System.Drawing.Size(753, 558)
        Me.Name = "CharityInformation"
        Me.Text = "CharityInformation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LblTGift As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents TxtTotalG As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents BtnDone As Button
    Friend WithEvents LblPercentage As Label
    Friend WithEvents LblAGiftAid As Label
    Friend WithEvents LblARaised As Label
    Friend WithEvents TxtPercentage As TextBox
    Friend WithEvents TxtARaised As TextBox
    Friend WithEvents TxtAGiftAid As TextBox
    Friend WithEvents LblCharityInfo As Label
    Friend WithEvents LblID As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents ToRaise As Label
    Friend WithEvents TxtToRaise As TextBox
End Class
