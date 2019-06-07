<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Equipment))
        Me.LblEquipment = New System.Windows.Forms.Label()
        Me.BtnBike = New System.Windows.Forms.Button()
        Me.BtnClothing = New System.Windows.Forms.Button()
        Me.BtnMaintainence = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblEquipment
        '
        Me.LblEquipment.AutoSize = True
        Me.LblEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEquipment.Location = New System.Drawing.Point(153, 47)
        Me.LblEquipment.Name = "LblEquipment"
        Me.LblEquipment.Size = New System.Drawing.Size(95, 20)
        Me.LblEquipment.TabIndex = 83
        Me.LblEquipment.Text = "Equipment"
        '
        'BtnBike
        '
        Me.BtnBike.Image = Global.Cycling_Tracker.My.Resources.Resources.Bike
        Me.BtnBike.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBike.Location = New System.Drawing.Point(279, 95)
        Me.BtnBike.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnBike.Name = "BtnBike"
        Me.BtnBike.Size = New System.Drawing.Size(88, 88)
        Me.BtnBike.TabIndex = 82
        Me.BtnBike.Text = "Bikes"
        Me.BtnBike.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBike.UseVisualStyleBackColor = True
        '
        'BtnClothing
        '
        Me.BtnClothing.Image = Global.Cycling_Tracker.My.Resources.Resources.Clothing
        Me.BtnClothing.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClothing.Location = New System.Drawing.Point(157, 95)
        Me.BtnClothing.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnClothing.Name = "BtnClothing"
        Me.BtnClothing.Size = New System.Drawing.Size(88, 88)
        Me.BtnClothing.TabIndex = 81
        Me.BtnClothing.Text = "Clothing"
        Me.BtnClothing.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClothing.UseVisualStyleBackColor = True
        '
        'BtnMaintainence
        '
        Me.BtnMaintainence.Image = Global.Cycling_Tracker.My.Resources.Resources.Maintainence
        Me.BtnMaintainence.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMaintainence.Location = New System.Drawing.Point(34, 95)
        Me.BtnMaintainence.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnMaintainence.Name = "BtnMaintainence"
        Me.BtnMaintainence.Size = New System.Drawing.Size(88, 88)
        Me.BtnMaintainence.TabIndex = 80
        Me.BtnMaintainence.Text = "Maintainence"
        Me.BtnMaintainence.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMaintainence.UseVisualStyleBackColor = True
        '
        'Equipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(400, 216)
        Me.Controls.Add(Me.LblEquipment)
        Me.Controls.Add(Me.BtnBike)
        Me.Controls.Add(Me.BtnClothing)
        Me.Controls.Add(Me.BtnMaintainence)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(416, 255)
        Me.MinimumSize = New System.Drawing.Size(416, 255)
        Me.Name = "Equipment"
        Me.Text = "Equipment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblEquipment As Label
    Friend WithEvents BtnBike As Button
    Friend WithEvents BtnClothing As Button
    Friend WithEvents BtnMaintainence As Button
End Class
