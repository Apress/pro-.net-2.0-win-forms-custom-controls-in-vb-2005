<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressValueDropDown
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
        Me.cmdClose = New System.Windows.Forms.Button
        Me.lblValue = New System.Windows.Forms.Label
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.lblRange = New System.Windows.Forms.Label
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(184, 5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(16, 16)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "X"
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(6, 60)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(186, 12)
        Me.lblValue.TabIndex = 6
        Me.lblValue.Text = "Current Value = "
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trackBar1
        '
        Me.trackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trackBar1.Location = New System.Drawing.Point(0, 25)
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(192, 45)
        Me.trackBar1.TabIndex = 5
        Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(6, 8)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(82, 13)
        Me.lblRange.TabIndex = 4
        Me.lblRange.Text = "Allowed Range:"
        '
        'ProgressValueDropDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.trackBar1)
        Me.Controls.Add(Me.lblRange)
        Me.Name = "ProgressValueDropDown"
        Me.Size = New System.Drawing.Size(201, 76)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cmdClose As System.Windows.Forms.Button
    Private WithEvents lblValue As System.Windows.Forms.Label
    Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Private WithEvents lblRange As System.Windows.Forms.Label

End Class
