<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XC2MainForm
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
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.SaveAsFileBtn = New System.Windows.Forms.Button()
        Me.OpenFileBtn = New System.Windows.Forms.Button()
        Me.MiniGame = New System.Windows.Forms.Button()
        Me.ArtsWP = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MiniGameEditor = New XC2Editor.XC2FieldTypeEditor()
        Me.DriverEditor = New XC2Editor.XC2FieldTypeEditor()
        Me.ArtWeaponPointEditor = New XC2Editor.XC2FieldTypeEditor()
        Me.BladeEditor = New XC2Editor.XC2FieldTypeEditor()
        Me.CoreEditor = New XC2Editor.XC2FieldTypeEditor()
        Me.PlayerInfoEditor = New XC2Editor.XC2FieldTypeEditor()
        Me.SuspendLayout()
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(95, 417)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(76, 30)
        Me.SaveBtn.TabIndex = 15
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'SaveAsFileBtn
        '
        Me.SaveAsFileBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAsFileBtn.Location = New System.Drawing.Point(177, 417)
        Me.SaveAsFileBtn.Name = "SaveAsFileBtn"
        Me.SaveAsFileBtn.Size = New System.Drawing.Size(76, 30)
        Me.SaveAsFileBtn.TabIndex = 14
        Me.SaveAsFileBtn.Text = "Save As..."
        Me.SaveAsFileBtn.UseVisualStyleBackColor = True
        '
        'OpenFileBtn
        '
        Me.OpenFileBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenFileBtn.Location = New System.Drawing.Point(12, 417)
        Me.OpenFileBtn.Name = "OpenFileBtn"
        Me.OpenFileBtn.Size = New System.Drawing.Size(77, 30)
        Me.OpenFileBtn.TabIndex = 13
        Me.OpenFileBtn.Text = "Open"
        Me.OpenFileBtn.UseVisualStyleBackColor = True
        '
        'MiniGame
        '
        Me.MiniGame.Location = New System.Drawing.Point(435, 57)
        Me.MiniGame.Name = "MiniGame"
        Me.MiniGame.Size = New System.Drawing.Size(108, 30)
        Me.MiniGame.TabIndex = 20
        Me.MiniGame.Text = "MiniGame"
        Me.MiniGame.UseVisualStyleBackColor = True
        '
        'ArtsWP
        '
        Me.ArtsWP.Location = New System.Drawing.Point(435, 21)
        Me.ArtsWP.Name = "ArtsWP"
        Me.ArtsWP.Size = New System.Drawing.Size(108, 30)
        Me.ArtsWP.TabIndex = 21
        Me.ArtsWP.Text = "Art Weapon Points"
        Me.ArtsWP.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(435, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 30)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Cores"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SkillLevel - Max = 5"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(435, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 31)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Credits"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MiniGameEditor
        '
        Me.MiniGameEditor.CanEdit = False
        Me.MiniGameEditor.CurrentValue = Nothing
        Me.MiniGameEditor.DataSource = Nothing
        Me.MiniGameEditor.FieldTypeLabel = Nothing
        Me.MiniGameEditor.FieldValueLabel = "Value"
        Me.MiniGameEditor.Location = New System.Drawing.Point(12, 111)
        Me.MiniGameEditor.Name = "MiniGameEditor"
        Me.MiniGameEditor.Size = New System.Drawing.Size(391, 93)
        Me.MiniGameEditor.TabIndex = 22
        Me.MiniGameEditor.Visible = False
        '
        'DriverEditor
        '
        Me.DriverEditor.CanEdit = False
        Me.DriverEditor.CurrentValue = Nothing
        Me.DriverEditor.DataSource = Nothing
        Me.DriverEditor.FieldTypeLabel = Nothing
        Me.DriverEditor.FieldValueLabel = "Value"
        Me.DriverEditor.Location = New System.Drawing.Point(12, 210)
        Me.DriverEditor.Name = "DriverEditor"
        Me.DriverEditor.Size = New System.Drawing.Size(391, 93)
        Me.DriverEditor.TabIndex = 19
        '
        'ArtWeaponPointEditor
        '
        Me.ArtWeaponPointEditor.CanEdit = False
        Me.ArtWeaponPointEditor.CurrentValue = Nothing
        Me.ArtWeaponPointEditor.DataSource = Nothing
        Me.ArtWeaponPointEditor.FieldTypeLabel = Nothing
        Me.ArtWeaponPointEditor.FieldValueLabel = "Value"
        Me.ArtWeaponPointEditor.Location = New System.Drawing.Point(12, 111)
        Me.ArtWeaponPointEditor.Name = "ArtWeaponPointEditor"
        Me.ArtWeaponPointEditor.Size = New System.Drawing.Size(391, 93)
        Me.ArtWeaponPointEditor.TabIndex = 18
        Me.ArtWeaponPointEditor.Visible = False
        '
        'BladeEditor
        '
        Me.BladeEditor.CanEdit = False
        Me.BladeEditor.CurrentValue = Nothing
        Me.BladeEditor.DataSource = Nothing
        Me.BladeEditor.FieldTypeLabel = Nothing
        Me.BladeEditor.FieldValueLabel = "Value"
        Me.BladeEditor.Location = New System.Drawing.Point(12, 309)
        Me.BladeEditor.Name = "BladeEditor"
        Me.BladeEditor.Size = New System.Drawing.Size(391, 93)
        Me.BladeEditor.TabIndex = 18
        '
        'CoreEditor
        '
        Me.CoreEditor.CanEdit = False
        Me.CoreEditor.CurrentValue = Nothing
        Me.CoreEditor.DataSource = Nothing
        Me.CoreEditor.FieldTypeLabel = Nothing
        Me.CoreEditor.FieldValueLabel = "Value"
        Me.CoreEditor.Location = New System.Drawing.Point(12, 111)
        Me.CoreEditor.Name = "CoreEditor"
        Me.CoreEditor.Size = New System.Drawing.Size(391, 93)
        Me.CoreEditor.TabIndex = 17
        '
        'PlayerInfoEditor
        '
        Me.PlayerInfoEditor.CanEdit = False
        Me.PlayerInfoEditor.CurrentValue = Nothing
        Me.PlayerInfoEditor.DataSource = Nothing
        Me.PlayerInfoEditor.FieldTypeLabel = Nothing
        Me.PlayerInfoEditor.FieldValueLabel = "Value"
        Me.PlayerInfoEditor.Location = New System.Drawing.Point(12, 12)
        Me.PlayerInfoEditor.Name = "PlayerInfoEditor"
        Me.PlayerInfoEditor.Size = New System.Drawing.Size(391, 93)
        Me.PlayerInfoEditor.TabIndex = 16
        '
        'XC2MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 460)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MiniGameEditor)
        Me.Controls.Add(Me.ArtsWP)
        Me.Controls.Add(Me.MiniGame)
        Me.Controls.Add(Me.DriverEditor)
        Me.Controls.Add(Me.ArtWeaponPointEditor)
        Me.Controls.Add(Me.BladeEditor)
        Me.Controls.Add(Me.CoreEditor)
        Me.Controls.Add(Me.PlayerInfoEditor)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.SaveAsFileBtn)
        Me.Controls.Add(Me.OpenFileBtn)
        Me.Name = "XC2MainForm"
        Me.Text = "XC2 Save Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BladeEditor As XC2FieldTypeEditor
    Friend WithEvents CoreEditor As XC2FieldTypeEditor
    Friend WithEvents PlayerInfoEditor As XC2FieldTypeEditor
    Friend WithEvents SaveBtn As Button
    Friend WithEvents SaveAsFileBtn As Button
    Friend WithEvents OpenFileBtn As Button
    Friend WithEvents DriverEditor As XC2FieldTypeEditor
    Friend WithEvents ArtWeaponPointEditor As XC2FieldTypeEditor
    Friend WithEvents MiniGame As Button
    Friend WithEvents ArtsWP As Button
    Friend WithEvents MiniGameEditor As XC2FieldTypeEditor
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
