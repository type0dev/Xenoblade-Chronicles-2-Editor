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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XC2MainForm))
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.SaveAsFileBtn = New System.Windows.Forms.Button()
        Me.OpenFileBtn = New System.Windows.Forms.Button()
        Me.MiniGameButton = New System.Windows.Forms.Button()
        Me.ArtsWPButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CreditsButton = New System.Windows.Forms.Button()
        Me.DriversButton = New System.Windows.Forms.Button()
        Me.BladeButton = New System.Windows.Forms.Button()
        Me.WeaponCPButton = New System.Windows.Forms.Button()
        Me.WeaponCPEditor = New XC2Editor.XC2FieldTypeEditor()
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
        Me.SaveBtn.Location = New System.Drawing.Point(95, 206)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(76, 30)
        Me.SaveBtn.TabIndex = 15
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'SaveAsFileBtn
        '
        Me.SaveAsFileBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAsFileBtn.Location = New System.Drawing.Point(177, 206)
        Me.SaveAsFileBtn.Name = "SaveAsFileBtn"
        Me.SaveAsFileBtn.Size = New System.Drawing.Size(76, 30)
        Me.SaveAsFileBtn.TabIndex = 14
        Me.SaveAsFileBtn.Text = "Save As..."
        Me.SaveAsFileBtn.UseVisualStyleBackColor = True
        '
        'OpenFileBtn
        '
        Me.OpenFileBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenFileBtn.Location = New System.Drawing.Point(12, 206)
        Me.OpenFileBtn.Name = "OpenFileBtn"
        Me.OpenFileBtn.Size = New System.Drawing.Size(77, 30)
        Me.OpenFileBtn.TabIndex = 13
        Me.OpenFileBtn.Text = "Open"
        Me.OpenFileBtn.UseVisualStyleBackColor = True
        '
        'MiniGameButton
        '
        Me.MiniGameButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MiniGameButton.Location = New System.Drawing.Point(435, 119)
        Me.MiniGameButton.Name = "MiniGameButton"
        Me.MiniGameButton.Size = New System.Drawing.Size(108, 30)
        Me.MiniGameButton.TabIndex = 20
        Me.MiniGameButton.Text = "MiniGame"
        Me.MiniGameButton.UseVisualStyleBackColor = False
        '
        'ArtsWPButton
        '
        Me.ArtsWPButton.Location = New System.Drawing.Point(435, 83)
        Me.ArtsWPButton.Name = "ArtsWPButton"
        Me.ArtsWPButton.Size = New System.Drawing.Size(108, 30)
        Me.ArtsWPButton.TabIndex = 21
        Me.ArtsWPButton.Text = "Art Weapon Points"
        Me.ArtsWPButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SkillLevel - Max = 5"
        '
        'CreditsButton
        '
        Me.CreditsButton.Location = New System.Drawing.Point(435, 206)
        Me.CreditsButton.Name = "CreditsButton"
        Me.CreditsButton.Size = New System.Drawing.Size(108, 31)
        Me.CreditsButton.TabIndex = 25
        Me.CreditsButton.Text = "Credits"
        Me.CreditsButton.UseVisualStyleBackColor = True
        '
        'DriversButton
        '
        Me.DriversButton.Location = New System.Drawing.Point(435, 11)
        Me.DriversButton.Name = "DriversButton"
        Me.DriversButton.Size = New System.Drawing.Size(108, 30)
        Me.DriversButton.TabIndex = 26
        Me.DriversButton.Text = "Drivers"
        Me.DriversButton.UseVisualStyleBackColor = True
        '
        'BladeButton
        '
        Me.BladeButton.Location = New System.Drawing.Point(435, 47)
        Me.BladeButton.Name = "BladeButton"
        Me.BladeButton.Size = New System.Drawing.Size(108, 30)
        Me.BladeButton.TabIndex = 26
        Me.BladeButton.Text = "Blades"
        Me.BladeButton.UseVisualStyleBackColor = True
        '
        'WeaponCPButton
        '
        Me.WeaponCPButton.Location = New System.Drawing.Point(435, 156)
        Me.WeaponCPButton.Name = "WeaponCPButton"
        Me.WeaponCPButton.Size = New System.Drawing.Size(108, 34)
        Me.WeaponCPButton.TabIndex = 28
        Me.WeaponCPButton.Text = "Weapon Chips"
        Me.WeaponCPButton.UseVisualStyleBackColor = True
        '
        'WeaponCPEditor
        '
        Me.WeaponCPEditor.CanEdit = False
        Me.WeaponCPEditor.CurrentValue = Nothing
        Me.WeaponCPEditor.DataSource = Nothing
        Me.WeaponCPEditor.FieldTypeLabel = Nothing
        Me.WeaponCPEditor.FieldValueLabel = "Value"
        Me.WeaponCPEditor.Location = New System.Drawing.Point(12, 111)
        Me.WeaponCPEditor.Name = "WeaponCPEditor"
        Me.WeaponCPEditor.Size = New System.Drawing.Size(391, 93)
        Me.WeaponCPEditor.TabIndex = 27
        Me.WeaponCPEditor.Visible = False
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
        Me.DriverEditor.Location = New System.Drawing.Point(12, 111)
        Me.DriverEditor.Name = "DriverEditor"
        Me.DriverEditor.Size = New System.Drawing.Size(391, 93)
        Me.DriverEditor.TabIndex = 19
        Me.DriverEditor.Visible = False
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
        Me.BladeEditor.Location = New System.Drawing.Point(12, 111)
        Me.BladeEditor.Name = "BladeEditor"
        Me.BladeEditor.Size = New System.Drawing.Size(391, 93)
        Me.BladeEditor.TabIndex = 18
        Me.BladeEditor.Visible = False
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
        Me.ClientSize = New System.Drawing.Size(550, 246)
        Me.Controls.Add(Me.WeaponCPButton)
        Me.Controls.Add(Me.WeaponCPEditor)
        Me.Controls.Add(Me.BladeButton)
        Me.Controls.Add(Me.DriversButton)
        Me.Controls.Add(Me.CreditsButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MiniGameEditor)
        Me.Controls.Add(Me.ArtsWPButton)
        Me.Controls.Add(Me.MiniGameButton)
        Me.Controls.Add(Me.DriverEditor)
        Me.Controls.Add(Me.ArtWeaponPointEditor)
        Me.Controls.Add(Me.BladeEditor)
        Me.Controls.Add(Me.CoreEditor)
        Me.Controls.Add(Me.PlayerInfoEditor)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.SaveAsFileBtn)
        Me.Controls.Add(Me.OpenFileBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents MiniGameButton As Button
    Friend WithEvents ArtsWPButton As Button
    Friend WithEvents MiniGameEditor As XC2FieldTypeEditor
    Friend WithEvents Label1 As Label
    Friend WithEvents CreditsButton As Button
    Friend WithEvents DriversButton As Button
    Friend WithEvents BladeButton As Button
    Friend WithEvents WeaponCPEditor As XC2FieldTypeEditor
    Friend WithEvents WeaponCPButton As Button
End Class
