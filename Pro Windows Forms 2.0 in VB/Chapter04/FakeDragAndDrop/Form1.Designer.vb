<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblDragger = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblDragger
        '
        Me.lblDragger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDragger.Image = CType(resources.GetObject("lblDragger.Image"), System.Drawing.Image)
        Me.lblDragger.Location = New System.Drawing.Point(110, 105)
        Me.lblDragger.Name = "lblDragger"
        Me.lblDragger.Size = New System.Drawing.Size(72, 56)
        Me.lblDragger.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.lblDragger)
        Me.Name = "Form1"
        Me.Text = "Fake Drag And Drop"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDragger As System.Windows.Forms.Label

End Class
