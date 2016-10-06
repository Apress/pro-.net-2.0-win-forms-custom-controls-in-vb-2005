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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbInterval = New System.Windows.Forms.TrackBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbAmount = New System.Windows.Forms.TrackBar
        Me.MarqueeLabel1 = New MarqueeLabelControl.MarqueeLabel(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarqueeLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbInterval)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbAmount)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(31, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 132)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Scroll Interval:"
        '
        'tbInterval
        '
        Me.tbInterval.Location = New System.Drawing.Point(96, 72)
        Me.tbInterval.Maximum = 500
        Me.tbInterval.Minimum = 10
        Me.tbInterval.Name = "tbInterval"
        Me.tbInterval.Size = New System.Drawing.Size(228, 45)
        Me.tbInterval.TabIndex = 5
        Me.tbInterval.TickFrequency = 10
        Me.tbInterval.Value = 100
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Scroll Amount:"
        '
        'tbAmount
        '
        Me.tbAmount.Location = New System.Drawing.Point(96, 16)
        Me.tbAmount.Maximum = 20
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(228, 45)
        Me.tbAmount.TabIndex = 3
        Me.tbAmount.Value = 10
        '
        'MarqueeLabel1
        '
        Me.MarqueeLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MarqueeLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MarqueeLabel1.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarqueeLabel1.Location = New System.Drawing.Point(0, 0)
        Me.MarqueeLabel1.Name = "MarqueeLabel1"
        Me.MarqueeLabel1.ScrollPixelAmount = 10
        Me.MarqueeLabel1.ScrollTimeInterval = 100
        Me.MarqueeLabel1.Size = New System.Drawing.Size(409, 147)
        Me.MarqueeLabel1.TabIndex = 8
        Me.MarqueeLabel1.Text = "This Scrolls!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 337)
        Me.Controls.Add(Me.MarqueeLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarqueeLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbInterval As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbAmount As System.Windows.Forms.TrackBar
    Friend WithEvents MarqueeLabel1 As MarqueeLabelControl.MarqueeLabel

End Class
