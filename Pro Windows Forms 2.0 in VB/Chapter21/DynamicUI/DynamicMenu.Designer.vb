Imports Microsoft.VisualBasic
Imports System

Partial Public Class DynamicMenu
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.mnuControl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.controlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.startToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.mnuParameters = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.parametersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripContainer1.ContentPanel.SuspendLayout()
        Me.toolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.toolStripContainer1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.mnuControl.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.mnuParameters.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' toolStripContainer1
        ' 
        ' 
        ' toolStripContainer1.ContentPanel
        ' 
        Me.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.White
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.panel2)
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.panel1)
        Me.toolStripContainer1.ContentPanel.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.toolStripContainer1.ContentPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(292, 242)
        Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.toolStripContainer1.Name = "toolStripContainer1"
        Me.toolStripContainer1.Size = New System.Drawing.Size(292, 266)
        Me.toolStripContainer1.TabIndex = 0
        Me.toolStripContainer1.Text = "toolStripContainer1"
        ' 
        ' toolStripContainer1.TopToolStripPanel
        ' 
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.mnuMain)
        ' 
        ' panel2
        ' 
        Me.panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.ContextMenuStrip = Me.mnuControl
        Me.panel2.Controls.Add(Me.checkBox1)
        Me.panel2.Controls.Add(Me.button2)
        Me.panel2.Controls.Add(Me.button1)
        Me.panel2.Controls.Add(Me.label6)
        Me.panel2.Location = New System.Drawing.Point(18, 122)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(252, 100)
        Me.panel2.TabIndex = 6
        '            Me.panel2.Enter += New System.EventHandler(Me.panel_Enter);
        '            Me.panel2.Leave += New System.EventHandler(Me.panel_Leave);
        ' 
        ' mnuControl
        ' 
        Me.mnuControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.controlToolStripMenuItem})
        Me.mnuControl.Name = "mnuControl"
        Me.mnuControl.Size = New System.Drawing.Size(121, 26)
        ' 
        ' controlToolStripMenuItem
        ' 
        Me.controlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.startToolStripMenuItem, Me.stopToolStripMenuItem})
        Me.controlToolStripMenuItem.Name = "controlToolStripMenuItem"
        Me.controlToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.controlToolStripMenuItem.Text = "Control"
        ' 
        ' startToolStripMenuItem
        ' 
        Me.startToolStripMenuItem.Name = "startToolStripMenuItem"
        Me.startToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.startToolStripMenuItem.Text = "Start"
        ' 
        ' stopToolStripMenuItem
        ' 
        Me.stopToolStripMenuItem.Name = "stopToolStripMenuItem"
        Me.stopToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.stopToolStripMenuItem.Text = "Stop"
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(109, 30)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(114, 17)
        Me.checkBox1.TabIndex = 5
        Me.checkBox1.Text = "Run until complete"
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Location = New System.Drawing.Point(107, 57)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(60, 23)
        Me.button2.TabIndex = 4
        Me.button2.Text = "Stop"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(173, 57)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(63, 23)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Start"
        ' 
        ' label6
        ' 
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label6.Location = New System.Drawing.Point(13, 13)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(66, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Test Control"
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.ContextMenuStrip = Me.mnuParameters
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.textBox1)
        Me.panel1.Location = New System.Drawing.Point(18, 16)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(252, 100)
        Me.panel1.TabIndex = 0
        '            Me.panel1.Enter += New System.EventHandler(Me.panel_Enter);
        '            Me.panel1.Leave += New System.EventHandler(Me.panel_Leave);
        ' 
        ' mnuParameters
        ' 
        Me.mnuParameters.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.parametersToolStripMenuItem})
        Me.mnuParameters.Name = "mnuParameters"
        Me.mnuParameters.Size = New System.Drawing.Size(141, 26)
        ' 
        ' parametersToolStripMenuItem
        ' 
        Me.parametersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aToolStripMenuItem, Me.bToolStripMenuItem})
        Me.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem"
        Me.parametersToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.parametersToolStripMenuItem.Text = "Parameters"
        ' 
        ' aToolStripMenuItem
        ' 
        Me.aToolStripMenuItem.Name = "aToolStripMenuItem"
        Me.aToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.aToolStripMenuItem.Text = "A"
        ' 
        ' bToolStripMenuItem
        ' 
        Me.bToolStripMenuItem.Name = "bToolStripMenuItem"
        Me.bToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.bToolStripMenuItem.Text = "B"
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(52, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(50, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Param B:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(52, 39)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(51, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Param A:"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.label1.Location = New System.Drawing.Point(13, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(86, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Test Parameters"
        ' 
        ' textBox2
        ' 
        Me.textBox2.Location = New System.Drawing.Point(107, 59)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(129, 21)
        Me.textBox2.TabIndex = 1
        ' 
        ' textBox1
        ' 
        Me.textBox1.Location = New System.Drawing.Point(107, 33)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(129, 21)
        Me.textBox1.TabIndex = 0
        ' 
        ' mnuMain
        ' 
        Me.mnuMain.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.mnuTopLevel})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(292, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "menuStrip1"
        ' 
        ' fileToolStripMenuItem
        ' 
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.fileToolStripMenuItem.Text = "File"
        ' 
        ' exitToolStripMenuItem
        ' 
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        ' 
        ' mnuTopLevel
        ' 
        Me.mnuTopLevel.Name = "mnuTopLevel"
        Me.mnuTopLevel.Size = New System.Drawing.Size(58, 20)
        Me.mnuTopLevel.Text = "Context"
        ' 
        ' DynamicMenu
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.toolStripContainer1)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "DynamicMenu"
        Me.Text = "DynamicMenu"
        '            Me.Load += New System.EventHandler(Me.DynamicMenu_Load);
        Me.toolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.toolStripContainer1.ResumeLayout(False)
        Me.toolStripContainer1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.mnuControl.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.mnuParameters.ResumeLayout(False)
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private toolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Private mnuMain As System.Windows.Forms.MenuStrip
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private label3 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label1 As System.Windows.Forms.Label
    Private textBox2 As System.Windows.Forms.TextBox
    Private textBox1 As System.Windows.Forms.TextBox
    Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private button2 As System.Windows.Forms.Button
    Private button1 As System.Windows.Forms.Button
    Private label6 As System.Windows.Forms.Label
    Private mnuParameters As System.Windows.Forms.ContextMenuStrip
    Private parametersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private aToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private bToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private mnuControl As System.Windows.Forms.ContextMenuStrip
    Private controlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private startToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private stopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private mnuTopLevel As System.Windows.Forms.ToolStripMenuItem
End Class
