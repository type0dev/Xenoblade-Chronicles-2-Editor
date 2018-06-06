<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Credits
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thanks to ScciresM, ktemkin, Jan4v, Nwert for making homebrew possible"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "x43x61x69 for template used to find these values"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Brought to you by Type_0_Dev/madhatter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "winglery28 for the structure"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "The whole ReSwitch Team community"
        '
        'Credits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 225)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Credits"
        Me.Text = "Credits"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
