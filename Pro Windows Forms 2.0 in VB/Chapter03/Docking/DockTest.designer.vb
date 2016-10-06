<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DockTest
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
        Me.txtDock = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.udDockPaddingForm = New System.Windows.Forms.NumericUpDown
        Me.udDockPaddingPanel = New System.Windows.Forms.NumericUpDown
        Me.lstDockPanel = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstDockTextBox = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlDock = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        CType(Me.udDockPaddingForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udDockPaddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDock.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDock
        '
        Me.txtDock.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtDock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDock.Location = New System.Drawing.Point(20, 20)
        Me.txtDock.Multiline = True
        Me.txtDock.Name = "txtDock"
        Me.txtDock.Size = New System.Drawing.Size(128, 262)
        Me.txtDock.TabIndex = 0
        Me.txtDock.Text = "I'm docked to the edge of this Panel." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Panel is docked to the edge of the f" & _
            "orm." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Panel's DockPadding gives the necessary room to breathe."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdUpdate)
        Me.GroupBox1.Controls.Add(Me.udDockPaddingForm)
        Me.GroupBox1.Controls.Add(Me.udDockPaddingPanel)
        Me.GroupBox1.Controls.Add(Me.lstDockPanel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lstDockTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(178, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 224)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configure"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(160, 180)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(84, 24)
        Me.cmdUpdate.TabIndex = 10
        Me.cmdUpdate.Text = "Update"
        '
        'udDockPaddingForm
        '
        Me.udDockPaddingForm.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.udDockPaddingForm.Location = New System.Drawing.Point(160, 32)
        Me.udDockPaddingForm.Name = "udDockPaddingForm"
        Me.udDockPaddingForm.Size = New System.Drawing.Size(52, 21)
        Me.udDockPaddingForm.TabIndex = 4
        '
        'udDockPaddingPanel
        '
        Me.udDockPaddingPanel.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.udDockPaddingPanel.Location = New System.Drawing.Point(160, 56)
        Me.udDockPaddingPanel.Name = "udDockPaddingPanel"
        Me.udDockPaddingPanel.Size = New System.Drawing.Size(52, 21)
        Me.udDockPaddingPanel.TabIndex = 5
        Me.udDockPaddingPanel.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'lstDockPanel
        '
        Me.lstDockPanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstDockPanel.Location = New System.Drawing.Point(156, 100)
        Me.lstDockPanel.Name = "lstDockPanel"
        Me.lstDockPanel.Size = New System.Drawing.Size(92, 21)
        Me.lstDockPanel.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dock Panel To:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dock TextBox To:"
        '
        'lstDockTextBox
        '
        Me.lstDockTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstDockTextBox.Location = New System.Drawing.Point(156, 124)
        Me.lstDockTextBox.Name = "lstDockTextBox"
        Me.lstDockTextBox.Size = New System.Drawing.Size(92, 21)
        Me.lstDockTextBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Set Panel's DockPadding:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Set Form's DockPadding:"
        '
        'pnlDock
        '
        Me.pnlDock.Controls.Add(Me.txtDock)
        Me.pnlDock.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlDock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDock.Location = New System.Drawing.Point(0, 0)
        Me.pnlDock.Name = "pnlDock"
        Me.pnlDock.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlDock.Size = New System.Drawing.Size(224, 302)
        Me.pnlDock.TabIndex = 11
        '
        'DockTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 302)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlDock)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DockTest"
        Me.Text = "Docking At Work"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.udDockPaddingForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udDockPaddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDock.ResumeLayout(False)
        Me.pnlDock.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDock As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents udDockPaddingForm As System.Windows.Forms.NumericUpDown
    Friend WithEvents udDockPaddingPanel As System.Windows.Forms.NumericUpDown
    Friend WithEvents lstDockPanel As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstDockTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlDock As System.Windows.Forms.Panel
End Class
