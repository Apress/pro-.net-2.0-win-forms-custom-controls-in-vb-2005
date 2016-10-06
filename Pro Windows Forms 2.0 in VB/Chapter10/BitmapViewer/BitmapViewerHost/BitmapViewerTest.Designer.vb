<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BitmapViewerTest
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
        Me.BitmapViewer1 = New BitmapViewerControls.BitmapViewer
        Me.SuspendLayout()
        '
        'BitmapViewer1
        '
        Me.BitmapViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BitmapViewer1.Border = 5
        Me.BitmapViewer1.Dimension = 80
        Me.BitmapViewer1.Directory = Nothing
        Me.BitmapViewer1.Location = New System.Drawing.Point(9, 12)
        Me.BitmapViewer1.Name = "BitmapViewer1"
        Me.BitmapViewer1.Size = New System.Drawing.Size(426, 267)
        Me.BitmapViewer1.Spacing = 10
        Me.BitmapViewer1.TabIndex = 0
        '
        'BitmapViewerTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 308)
        Me.Controls.Add(Me.BitmapViewer1)
        Me.Name = "BitmapViewerTest"
        Me.Text = "BitmapViewerTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BitmapViewer1 As BitmapViewerControls.BitmapViewer
End Class
