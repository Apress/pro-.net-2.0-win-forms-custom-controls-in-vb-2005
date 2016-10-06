<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprovedBitmapViewerTest
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
        Me.ImprovedBitmapViewer1 = New BitmapViewerControls.ImprovedBitmapViewer
        Me.SuspendLayout()
        '
        'ImprovedBitmapViewer1
        '
        Me.ImprovedBitmapViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImprovedBitmapViewer1.Border = 5
        Me.ImprovedBitmapViewer1.Dimension = 80
        Me.ImprovedBitmapViewer1.Location = New System.Drawing.Point(5, 12)
        Me.ImprovedBitmapViewer1.Name = "ImprovedBitmapViewer1"
        Me.ImprovedBitmapViewer1.Size = New System.Drawing.Size(493, 247)
        Me.ImprovedBitmapViewer1.Spacing = 10
        Me.ImprovedBitmapViewer1.TabIndex = 0
        '
        'ImprovedBitmapViewerTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 280)
        Me.Controls.Add(Me.ImprovedBitmapViewer1)
        Me.Name = "ImprovedBitmapViewerTest"
        Me.Text = "ImprovedBitmapViewerTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImprovedBitmapViewer1 As BitmapViewerControls.ImprovedBitmapViewer
End Class
