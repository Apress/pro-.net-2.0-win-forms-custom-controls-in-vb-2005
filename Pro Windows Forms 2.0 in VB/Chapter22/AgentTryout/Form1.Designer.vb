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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.axAgent1 = New AxAgentObjects.AxAgent
        Me.cmdClose = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtY = New System.Windows.Forms.TextBox
        Me.txtX = New System.Windows.Forms.TextBox
        Me.cmdMove = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdSpeak = New System.Windows.Forms.Button
        Me.txtSpeak = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdStop = New System.Windows.Forms.Button
        Me.cmdPlay = New System.Windows.Forms.Button
        Me.lstAnimations = New System.Windows.Forms.ListBox
        CType(Me.axAgent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'axAgent1
        '
        Me.axAgent1.Enabled = True
        Me.axAgent1.Location = New System.Drawing.Point(60, 325)
        Me.axAgent1.Name = "axAgent1"
        Me.axAgent1.OcxState = CType(resources.GetObject("axAgent1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axAgent1.Size = New System.Drawing.Size(32, 32)
        Me.axAgent1.TabIndex = 23
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdClose.Location = New System.Drawing.Point(295, 332)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(96, 24)
        Me.cmdClose.TabIndex = 22
        Me.cmdClose.Text = "Close"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtY)
        Me.GroupBox3.Controls.Add(Me.txtX)
        Me.GroupBox3.Controls.Add(Me.cmdMove)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(8, 252)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 64)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Move"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(84, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Y:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "X:"
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(104, 24)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(36, 21)
        Me.txtY.TabIndex = 9
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(36, 24)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(36, 21)
        Me.txtX.TabIndex = 8
        '
        'cmdMove
        '
        Me.cmdMove.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdMove.Location = New System.Drawing.Point(248, 24)
        Me.cmdMove.Name = "cmdMove"
        Me.cmdMove.Size = New System.Drawing.Size(72, 20)
        Me.cmdMove.TabIndex = 7
        Me.cmdMove.Text = "Move"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdSpeak)
        Me.GroupBox2.Controls.Add(Me.txtSpeak)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(8, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 80)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Speak"
        '
        'cmdSpeak
        '
        Me.cmdSpeak.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSpeak.Location = New System.Drawing.Point(248, 20)
        Me.cmdSpeak.Name = "cmdSpeak"
        Me.cmdSpeak.Size = New System.Drawing.Size(72, 20)
        Me.cmdSpeak.TabIndex = 6
        Me.cmdSpeak.Text = "Speak"
        '
        'txtSpeak
        '
        Me.txtSpeak.AcceptsReturn = True
        Me.txtSpeak.Location = New System.Drawing.Point(8, 20)
        Me.txtSpeak.Multiline = True
        Me.txtSpeak.Name = "txtSpeak"
        Me.txtSpeak.Size = New System.Drawing.Size(232, 48)
        Me.txtSpeak.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdStop)
        Me.GroupBox1.Controls.Add(Me.cmdPlay)
        Me.GroupBox1.Controls.Add(Me.lstAnimations)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 144)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Animate"
        '
        'cmdStop
        '
        Me.cmdStop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdStop.Location = New System.Drawing.Point(248, 48)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(72, 20)
        Me.cmdStop.TabIndex = 6
        Me.cmdStop.Text = "Stop"
        '
        'cmdPlay
        '
        Me.cmdPlay.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdPlay.Location = New System.Drawing.Point(248, 24)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(72, 20)
        Me.cmdPlay.TabIndex = 5
        Me.cmdPlay.Text = "Play"
        '
        'lstAnimations
        '
        Me.lstAnimations.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstAnimations.IntegralHeight = False
        Me.lstAnimations.Location = New System.Drawing.Point(8, 22)
        Me.lstAnimations.Name = "lstAnimations"
        Me.lstAnimations.Size = New System.Drawing.Size(232, 109)
        Me.lstAnimations.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 368)
        Me.Controls.Add(Me.axAgent1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.axAgent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents axAgent1 As AxAgentObjects.AxAgent
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents cmdMove As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSpeak As System.Windows.Forms.Button
    Friend WithEvents txtSpeak As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents lstAnimations As System.Windows.Forms.ListBox

End Class
