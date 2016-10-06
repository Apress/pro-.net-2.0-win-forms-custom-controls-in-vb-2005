<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OwnerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label
        Me.cmdReleaseOwnership = New System.Windows.Forms.Button
        Me.cmdAddOwnership = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(38, 37)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(216, 80)
        Me.label1.TabIndex = 10
        Me.label1.Text = "To test form ownership, try minimizing this form when the second form is owned. T" & _
            "hen try, minimizing it when the second form is not owned."
        '
        'cmdReleaseOwnership
        '
        Me.cmdReleaseOwnership.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdReleaseOwnership.Location = New System.Drawing.Point(150, 197)
        Me.cmdReleaseOwnership.Name = "cmdReleaseOwnership"
        Me.cmdReleaseOwnership.Size = New System.Drawing.Size(128, 32)
        Me.cmdReleaseOwnership.TabIndex = 9
        Me.cmdReleaseOwnership.Text = "Remove Ownership"
        '
        'cmdAddOwnership
        '
        Me.cmdAddOwnership.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdAddOwnership.Location = New System.Drawing.Point(14, 197)
        Me.cmdAddOwnership.Name = "cmdAddOwnership"
        Me.cmdAddOwnership.Size = New System.Drawing.Size(120, 32)
        Me.cmdAddOwnership.TabIndex = 8
        Me.cmdAddOwnership.Text = "Set Ownership"
        '
        'OwnerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cmdReleaseOwnership)
        Me.Controls.Add(Me.cmdAddOwnership)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "OwnerForm"
        Me.Text = "Owner"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cmdReleaseOwnership As System.Windows.Forms.Button
    Private WithEvents cmdAddOwnership As System.Windows.Forms.Button

End Class
