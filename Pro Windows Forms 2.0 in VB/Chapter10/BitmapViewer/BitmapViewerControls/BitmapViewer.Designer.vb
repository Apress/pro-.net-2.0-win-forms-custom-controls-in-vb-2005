<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BitmapViewer
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.pnlPictures = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'pnlPictures
        '
        Me.pnlPictures.AutoScroll = True
        Me.pnlPictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPictures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPictures.Location = New System.Drawing.Point(0, 0)
        Me.pnlPictures.Name = "pnlPictures"
        Me.pnlPictures.Size = New System.Drawing.Size(459, 253)
        Me.pnlPictures.TabIndex = 2
        '
        'BitmapViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlPictures)
        Me.Name = "BitmapViewer"
        Me.Size = New System.Drawing.Size(459, 253)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPictures As System.Windows.Forms.Panel

End Class
