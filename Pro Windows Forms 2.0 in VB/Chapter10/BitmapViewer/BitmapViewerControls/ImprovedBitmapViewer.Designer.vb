<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprovedBitmapViewer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlFlow = New System.Windows.Forms.FlowLayoutPanel
        Me.SuspendLayout()
        '
        'pnlFlow
        '
        Me.pnlFlow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFlow.AutoScroll = True
        Me.pnlFlow.Location = New System.Drawing.Point(3, 3)
        Me.pnlFlow.Name = "pnlFlow"
        Me.pnlFlow.Size = New System.Drawing.Size(487, 241)
        Me.pnlFlow.TabIndex = 1
        '
        'ImprovedBitmapViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlFlow)
        Me.Name = "ImprovedBitmapViewer"
        Me.Size = New System.Drawing.Size(493, 247)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlFlow As System.Windows.Forms.FlowLayoutPanel

End Class
