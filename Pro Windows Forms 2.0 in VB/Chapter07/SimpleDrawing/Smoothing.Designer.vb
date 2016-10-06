<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Smoothing
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
        Me.grpHighQuality = New System.Windows.Forms.GroupBox
        Me.picHighQuality = New System.Windows.Forms.PictureBox
        Me.grpAntiAlias = New System.Windows.Forms.GroupBox
        Me.picAntialias = New System.Windows.Forms.PictureBox
        Me.grpHighSpeed = New System.Windows.Forms.GroupBox
        Me.picHighSpeed = New System.Windows.Forms.PictureBox
        Me.grpNone = New System.Windows.Forms.GroupBox
        Me.picNone = New System.Windows.Forms.PictureBox
        Me.grpHighQuality.SuspendLayout()
        CType(Me.picHighQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAntiAlias.SuspendLayout()
        CType(Me.picAntialias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHighSpeed.SuspendLayout()
        CType(Me.picHighSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNone.SuspendLayout()
        CType(Me.picNone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpHighQuality
        '
        Me.grpHighQuality.Controls.Add(Me.picHighQuality)
        Me.grpHighQuality.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpHighQuality.Location = New System.Drawing.Point(22, 276)
        Me.grpHighQuality.Name = "grpHighQuality"
        Me.grpHighQuality.Size = New System.Drawing.Size(344, 85)
        Me.grpHighQuality.TabIndex = 16
        Me.grpHighQuality.TabStop = False
        Me.grpHighQuality.Text = "HighQuality"
        '
        'picHighQuality
        '
        Me.picHighQuality.Location = New System.Drawing.Point(8, 16)
        Me.picHighQuality.Name = "picHighQuality"
        Me.picHighQuality.Size = New System.Drawing.Size(328, 64)
        Me.picHighQuality.TabIndex = 0
        Me.picHighQuality.TabStop = False
        '
        'grpAntiAlias
        '
        Me.grpAntiAlias.Controls.Add(Me.picAntialias)
        Me.grpAntiAlias.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpAntiAlias.Location = New System.Drawing.Point(22, 188)
        Me.grpAntiAlias.Name = "grpAntiAlias"
        Me.grpAntiAlias.Size = New System.Drawing.Size(344, 85)
        Me.grpAntiAlias.TabIndex = 15
        Me.grpAntiAlias.TabStop = False
        Me.grpAntiAlias.Text = "AntiAlias"
        '
        'picAntialias
        '
        Me.picAntialias.Location = New System.Drawing.Point(8, 16)
        Me.picAntialias.Name = "picAntialias"
        Me.picAntialias.Size = New System.Drawing.Size(328, 64)
        Me.picAntialias.TabIndex = 0
        Me.picAntialias.TabStop = False
        '
        'grpHighSpeed
        '
        Me.grpHighSpeed.Controls.Add(Me.picHighSpeed)
        Me.grpHighSpeed.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpHighSpeed.Location = New System.Drawing.Point(22, 100)
        Me.grpHighSpeed.Name = "grpHighSpeed"
        Me.grpHighSpeed.Size = New System.Drawing.Size(344, 85)
        Me.grpHighSpeed.TabIndex = 14
        Me.grpHighSpeed.TabStop = False
        Me.grpHighSpeed.Text = "HighSpeed"
        '
        'picHighSpeed
        '
        Me.picHighSpeed.Location = New System.Drawing.Point(8, 16)
        Me.picHighSpeed.Name = "picHighSpeed"
        Me.picHighSpeed.Size = New System.Drawing.Size(328, 64)
        Me.picHighSpeed.TabIndex = 0
        Me.picHighSpeed.TabStop = False
        '
        'grpNone
        '
        Me.grpNone.Controls.Add(Me.picNone)
        Me.grpNone.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpNone.Location = New System.Drawing.Point(22, 12)
        Me.grpNone.Name = "grpNone"
        Me.grpNone.Size = New System.Drawing.Size(344, 85)
        Me.grpNone.TabIndex = 13
        Me.grpNone.TabStop = False
        Me.grpNone.Text = "None"
        '
        'picNone
        '
        Me.picNone.Location = New System.Drawing.Point(8, 16)
        Me.picNone.Name = "picNone"
        Me.picNone.Size = New System.Drawing.Size(328, 64)
        Me.picNone.TabIndex = 0
        Me.picNone.TabStop = False
        '
        'Smoothing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 383)
        Me.Controls.Add(Me.grpHighQuality)
        Me.Controls.Add(Me.grpAntiAlias)
        Me.Controls.Add(Me.grpHighSpeed)
        Me.Controls.Add(Me.grpNone)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Smoothing"
        Me.Text = "Smoothing"
        Me.grpHighQuality.ResumeLayout(False)
        CType(Me.picHighQuality, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAntiAlias.ResumeLayout(False)
        CType(Me.picAntialias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHighSpeed.ResumeLayout(False)
        CType(Me.picHighSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNone.ResumeLayout(False)
        CType(Me.picNone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents grpHighQuality As System.Windows.Forms.GroupBox
    Private WithEvents picHighQuality As System.Windows.Forms.PictureBox
    Private WithEvents grpAntiAlias As System.Windows.Forms.GroupBox
    Private WithEvents picAntialias As System.Windows.Forms.PictureBox
    Private WithEvents grpHighSpeed As System.Windows.Forms.GroupBox
    Private WithEvents picHighSpeed As System.Windows.Forms.PictureBox
    Private WithEvents grpNone As System.Windows.Forms.GroupBox
    Private WithEvents picNone As System.Windows.Forms.PictureBox
End Class
