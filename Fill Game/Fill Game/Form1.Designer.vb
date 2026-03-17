<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FillGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cell00 = New Button()
        cell01 = New Button()
        cell02 = New Button()
        cell03 = New Button()
        cell12 = New Button()
        cell11 = New Button()
        cell10 = New Button()
        cell23 = New Button()
        cell22 = New Button()
        cell20 = New Button()
        cell33 = New Button()
        cell32 = New Button()
        cell31 = New Button()
        cell30 = New Button()
        restartBtn = New Button()
        SuspendLayout()
        ' 
        ' cell00
        ' 
        cell00.BackColor = Color.Silver
        cell00.FlatStyle = FlatStyle.Flat
        cell00.Location = New Point(12, 12)
        cell00.Name = "cell00"
        cell00.Size = New Size(80, 80)
        cell00.TabIndex = 0
        cell00.UseVisualStyleBackColor = False
        ' 
        ' cell01
        ' 
        cell01.BackColor = Color.Silver
        cell01.FlatStyle = FlatStyle.Flat
        cell01.Location = New Point(98, 12)
        cell01.Name = "cell01"
        cell01.Size = New Size(80, 80)
        cell01.TabIndex = 1
        cell01.UseVisualStyleBackColor = False
        ' 
        ' cell02
        ' 
        cell02.BackColor = Color.Silver
        cell02.FlatStyle = FlatStyle.Flat
        cell02.Location = New Point(184, 12)
        cell02.Name = "cell02"
        cell02.Size = New Size(80, 80)
        cell02.TabIndex = 2
        cell02.UseVisualStyleBackColor = False
        ' 
        ' cell03
        ' 
        cell03.BackColor = Color.Silver
        cell03.FlatStyle = FlatStyle.Flat
        cell03.Location = New Point(270, 12)
        cell03.Name = "cell03"
        cell03.Size = New Size(80, 80)
        cell03.TabIndex = 3
        cell03.UseVisualStyleBackColor = False
        ' 
        ' cell12
        ' 
        cell12.BackColor = Color.Silver
        cell12.FlatStyle = FlatStyle.Flat
        cell12.Location = New Point(184, 98)
        cell12.Name = "cell12"
        cell12.Size = New Size(80, 80)
        cell12.TabIndex = 6
        cell12.UseVisualStyleBackColor = False
        ' 
        ' cell11
        ' 
        cell11.BackColor = Color.Silver
        cell11.FlatStyle = FlatStyle.Flat
        cell11.Location = New Point(98, 98)
        cell11.Name = "cell11"
        cell11.Size = New Size(80, 80)
        cell11.TabIndex = 5
        cell11.UseVisualStyleBackColor = False
        ' 
        ' cell10
        ' 
        cell10.BackColor = Color.Silver
        cell10.FlatStyle = FlatStyle.Flat
        cell10.Location = New Point(12, 98)
        cell10.Name = "cell10"
        cell10.Size = New Size(80, 80)
        cell10.TabIndex = 4
        cell10.UseVisualStyleBackColor = False
        ' 
        ' cell23
        ' 
        cell23.BackColor = Color.Silver
        cell23.FlatStyle = FlatStyle.Flat
        cell23.Location = New Point(270, 184)
        cell23.Name = "cell23"
        cell23.Size = New Size(80, 80)
        cell23.TabIndex = 9
        cell23.UseVisualStyleBackColor = False
        ' 
        ' cell22
        ' 
        cell22.BackColor = Color.Magenta
        cell22.FlatStyle = FlatStyle.Flat
        cell22.Location = New Point(184, 184)
        cell22.Name = "cell22"
        cell22.Size = New Size(80, 80)
        cell22.TabIndex = 8
        cell22.UseVisualStyleBackColor = False
        ' 
        ' cell20
        ' 
        cell20.BackColor = Color.Silver
        cell20.FlatStyle = FlatStyle.Flat
        cell20.Location = New Point(12, 184)
        cell20.Name = "cell20"
        cell20.Size = New Size(80, 80)
        cell20.TabIndex = 7
        cell20.UseVisualStyleBackColor = False
        ' 
        ' cell33
        ' 
        cell33.BackColor = Color.Silver
        cell33.FlatStyle = FlatStyle.Flat
        cell33.Location = New Point(270, 270)
        cell33.Name = "cell33"
        cell33.Size = New Size(80, 80)
        cell33.TabIndex = 13
        cell33.UseVisualStyleBackColor = False
        ' 
        ' cell32
        ' 
        cell32.BackColor = Color.Silver
        cell32.FlatStyle = FlatStyle.Flat
        cell32.Location = New Point(184, 270)
        cell32.Name = "cell32"
        cell32.Size = New Size(80, 80)
        cell32.TabIndex = 12
        cell32.UseVisualStyleBackColor = False
        ' 
        ' cell31
        ' 
        cell31.BackColor = Color.Silver
        cell31.FlatStyle = FlatStyle.Flat
        cell31.Location = New Point(98, 270)
        cell31.Name = "cell31"
        cell31.Size = New Size(80, 80)
        cell31.TabIndex = 11
        cell31.UseVisualStyleBackColor = False
        ' 
        ' cell30
        ' 
        cell30.BackColor = Color.Silver
        cell30.FlatStyle = FlatStyle.Flat
        cell30.Location = New Point(12, 270)
        cell30.Name = "cell30"
        cell30.Size = New Size(80, 80)
        cell30.TabIndex = 10
        cell30.UseVisualStyleBackColor = False
        ' 
        ' restartBtn
        ' 
        restartBtn.BackColor = SystemColors.Control
        restartBtn.FlatStyle = FlatStyle.Flat
        restartBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        restartBtn.Location = New Point(367, 131)
        restartBtn.Name = "restartBtn"
        restartBtn.Size = New Size(100, 100)
        restartBtn.TabIndex = 14
        restartBtn.Text = "Restart"
        restartBtn.UseVisualStyleBackColor = False
        ' 
        ' FillGame
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(485, 364)
        Controls.Add(restartBtn)
        Controls.Add(cell33)
        Controls.Add(cell32)
        Controls.Add(cell31)
        Controls.Add(cell30)
        Controls.Add(cell23)
        Controls.Add(cell22)
        Controls.Add(cell20)
        Controls.Add(cell12)
        Controls.Add(cell11)
        Controls.Add(cell10)
        Controls.Add(cell03)
        Controls.Add(cell02)
        Controls.Add(cell01)
        Controls.Add(cell00)
        Name = "FillGame"
        Text = "Fill Game"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cell00 As Button
    Friend WithEvents cell01 As Button
    Friend WithEvents cell02 As Button
    Friend WithEvents cell03 As Button
    Friend WithEvents cell12 As Button
    Friend WithEvents cell11 As Button
    Friend WithEvents cell10 As Button
    Friend WithEvents cell23 As Button
    Friend WithEvents cell22 As Button
    Friend WithEvents cell20 As Button
    Friend WithEvents cell33 As Button
    Friend WithEvents cell32 As Button
    Friend WithEvents cell31 As Button
    Friend WithEvents cell30 As Button
    Friend WithEvents restartBtn As Button

End Class
