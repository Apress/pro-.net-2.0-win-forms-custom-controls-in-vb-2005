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
        Me.components = New System.ComponentModel.Container
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.chkDoubleBuffer = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 10
        '
        'chkDoubleBuffer
        '
        Me.chkDoubleBuffer.BackColor = System.Drawing.Color.PaleTurquoise
        Me.chkDoubleBuffer.Location = New System.Drawing.Point(12, 24)
        Me.chkDoubleBuffer.Name = "chkDoubleBuffer"
        Me.chkDoubleBuffer.Size = New System.Drawing.Size(336, 16)
        Me.chkDoubleBuffer.TabIndex = 3
        Me.chkDoubleBuffer.Text = "Use Double Buffering"
        Me.chkDoubleBuffer.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 355)
        Me.Controls.Add(Me.chkDoubleBuffer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tmrRefresh As System.Windows.Forms.Timer
    Private WithEvents chkDoubleBuffer As System.Windows.Forms.CheckBox

End Class
