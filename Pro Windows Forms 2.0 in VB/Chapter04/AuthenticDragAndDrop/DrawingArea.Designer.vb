<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrawingArea
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
        Me.picDrawingArea = New System.Windows.Forms.PictureBox
        CType(Me.picDrawingArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDrawingArea
        '
        Me.picDrawingArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picDrawingArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDrawingArea.Location = New System.Drawing.Point(6, 6)
        Me.picDrawingArea.Name = "picDrawingArea"
        Me.picDrawingArea.Size = New System.Drawing.Size(377, 270)
        Me.picDrawingArea.TabIndex = 3
        Me.picDrawingArea.TabStop = False
        '
        'DrawingArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 283)
        Me.Controls.Add(Me.picDrawingArea)
        Me.Name = "DrawingArea"
        Me.Text = "DrawingArea"
        CType(Me.picDrawingArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents picDrawingArea As System.Windows.Forms.PictureBox

End Class
