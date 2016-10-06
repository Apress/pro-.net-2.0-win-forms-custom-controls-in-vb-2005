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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pic = New System.Windows.Forms.PictureBox
        Me.txt = New System.Windows.Forms.TextBox
        Me.cmd = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstLog = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.pic)
        Me.GroupBox1.Controls.Add(Me.txt)
        Me.GroupBox1.Controls.Add(Me.cmd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 148)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(92, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "And here:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Test keyboard events here:"
        '
        'pic
        '
        Me.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic.Location = New System.Drawing.Point(156, 48)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(192, 48)
        Me.pic.TabIndex = 3
        Me.pic.TabStop = False
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(156, 20)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(192, 21)
        Me.txt.TabIndex = 1
        '
        'cmd
        '
        Me.cmd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd.Location = New System.Drawing.Point(156, 100)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(88, 28)
        Me.cmd.TabIndex = 4
        Me.cmd.Text = "Button1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Test mouse events here:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(25, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Label3"
        '
        'lstLog
        '
        Me.lstLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLog.FormattingEnabled = True
        Me.lstLog.IntegralHeight = False
        Me.lstLog.Location = New System.Drawing.Point(9, 163)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.Size = New System.Drawing.Size(384, 212)
        Me.lstLog.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 383)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstLog)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Event Tracker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents pic As System.Windows.Forms.PictureBox
    Private WithEvents txt As System.Windows.Forms.TextBox
    Private WithEvents cmd As System.Windows.Forms.Button
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents lstLog As System.Windows.Forms.ListBox

End Class
