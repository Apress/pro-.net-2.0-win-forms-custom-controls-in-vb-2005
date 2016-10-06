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
        Me.chkShowManualBufferedPanel = New System.Windows.Forms.CheckBox
        Me.panel2 = New System.Windows.Forms.Panel
        Me.chkShowPanel = New System.Windows.Forms.CheckBox
        Me.chkShowBufferedPanel = New System.Windows.Forms.CheckBox
        Me.panel1 = New System.Windows.Forms.Panel
        Me.BufferedPanel1 = New ControlDoubleBuffered.BufferedPanel
        Me.SuspendLayout()
        '
        'chkShowManualBufferedPanel
        '
        Me.chkShowManualBufferedPanel.AutoSize = True
        Me.chkShowManualBufferedPanel.BackColor = System.Drawing.Color.Transparent
        Me.chkShowManualBufferedPanel.Checked = True
        Me.chkShowManualBufferedPanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowManualBufferedPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowManualBufferedPanel.ForeColor = System.Drawing.Color.White
        Me.chkShowManualBufferedPanel.Location = New System.Drawing.Point(507, 239)
        Me.chkShowManualBufferedPanel.Name = "chkShowManualBufferedPanel"
        Me.chkShowManualBufferedPanel.Size = New System.Drawing.Size(195, 17)
        Me.chkShowManualBufferedPanel.TabIndex = 12
        Me.chkShowManualBufferedPanel.Text = "Show Manually Buffered Panel"
        Me.chkShowManualBufferedPanel.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.Transparent
        Me.panel2.Location = New System.Drawing.Point(507, 294)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(213, 195)
        Me.panel2.TabIndex = 11
        '
        'chkShowPanel
        '
        Me.chkShowPanel.AutoSize = True
        Me.chkShowPanel.BackColor = System.Drawing.Color.Transparent
        Me.chkShowPanel.Checked = True
        Me.chkShowPanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPanel.ForeColor = System.Drawing.Color.White
        Me.chkShowPanel.Location = New System.Drawing.Point(264, 239)
        Me.chkShowPanel.Name = "chkShowPanel"
        Me.chkShowPanel.Size = New System.Drawing.Size(90, 17)
        Me.chkShowPanel.TabIndex = 10
        Me.chkShowPanel.Text = "Show Panel"
        Me.chkShowPanel.UseVisualStyleBackColor = False
        '
        'chkShowBufferedPanel
        '
        Me.chkShowBufferedPanel.AutoSize = True
        Me.chkShowBufferedPanel.BackColor = System.Drawing.Color.Transparent
        Me.chkShowBufferedPanel.Checked = True
        Me.chkShowBufferedPanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowBufferedPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowBufferedPanel.ForeColor = System.Drawing.Color.White
        Me.chkShowBufferedPanel.Location = New System.Drawing.Point(40, 239)
        Me.chkShowBufferedPanel.Name = "chkShowBufferedPanel"
        Me.chkShowBufferedPanel.Size = New System.Drawing.Size(138, 17)
        Me.chkShowBufferedPanel.TabIndex = 9
        Me.chkShowBufferedPanel.Text = "Show BufferedPanel"
        Me.chkShowBufferedPanel.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Location = New System.Drawing.Point(264, 294)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(213, 195)
        Me.panel1.TabIndex = 8
        '
        'BufferedPanel1
        '
        Me.BufferedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BufferedPanel1.Location = New System.Drawing.Point(40, 294)
        Me.BufferedPanel1.Name = "BufferedPanel1"
        Me.BufferedPanel1.Size = New System.Drawing.Size(200, 195)
        Me.BufferedPanel1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ControlDoubleBuffered.My.Resources.Resources.ShopFloor030
        Me.ClientSize = New System.Drawing.Size(782, 520)
        Me.Controls.Add(Me.BufferedPanel1)
        Me.Controls.Add(Me.chkShowManualBufferedPanel)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.chkShowPanel)
        Me.Controls.Add(Me.chkShowBufferedPanel)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents chkShowManualBufferedPanel As System.Windows.Forms.CheckBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents chkShowPanel As System.Windows.Forms.CheckBox
    Private WithEvents chkShowBufferedPanel As System.Windows.Forms.CheckBox
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents BufferedPanel1 As ControlDoubleBuffered.BufferedPanel

End Class
