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
        Me.toolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pictureBox2 = New System.Windows.Forms.PictureBox
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox2.Location = New System.Drawing.Point(164, 108)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox2.TabIndex = 3
        Me.pictureBox2.TabStop = False
        Me.toolTip2.SetToolTip(Me.pictureBox2, "This is a tooltip.")
        '
        'toolTip1
        '
        Me.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip1.ToolTipTitle = "Titled ToolTip"
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Location = New System.Drawing.Point(28, 108)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox1.TabIndex = 2
        Me.pictureBox1.TabStop = False
        Me.toolTip1.SetToolTip(Me.pictureBox1, "This is a tooltip.")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 240)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents toolTip2 As System.Windows.Forms.ToolTip
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox

End Class
