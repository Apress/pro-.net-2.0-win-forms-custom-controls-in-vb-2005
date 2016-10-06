Imports Microsoft.VisualBasic
Imports System

Partial Public Class DynamicDBMenu
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
        Me.cmdAdmin = New System.Windows.Forms.Button
        Me.cmdUser = New System.Windows.Forms.Button
        Me.mnuMain = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuManageHardware = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSetUpUserAccounts = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuChangeDisplay = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.Contents = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.About = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAdmin
        '
        Me.cmdAdmin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdAdmin.Location = New System.Drawing.Point(159, 158)
        Me.cmdAdmin.Name = "cmdAdmin"
        Me.cmdAdmin.Size = New System.Drawing.Size(80, 24)
        Me.cmdAdmin.TabIndex = 5
        Me.cmdAdmin.Text = "Admin Level"
        '
        'cmdUser
        '
        Me.cmdUser.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdUser.Location = New System.Drawing.Point(71, 158)
        Me.cmdUser.Name = "cmdUser"
        Me.cmdUser.Size = New System.Drawing.Size(80, 24)
        Me.cmdUser.TabIndex = 4
        Me.cmdUser.Text = "User Level"
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuTools, Me.mnuHelp})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(306, 24)
        Me.mnuMain.TabIndex = 6
        Me.mnuMain.Text = "menuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuClose, Me.mnuSave, Me.toolStripSeparator1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(152, 22)
        Me.mnuNew.Text = "New"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(152, 22)
        Me.mnuOpen.Text = "Open"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuClose.Text = "Close"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(152, 22)
        Me.mnuSave.Text = "Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuManageHardware, Me.mnuSetUpUserAccounts, Me.mnuChangeDisplay})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(44, 20)
        Me.mnuTools.Text = "Tools"
        '
        'mnuManageHardware
        '
        Me.mnuManageHardware.Name = "mnuManageHardware"
        Me.mnuManageHardware.Size = New System.Drawing.Size(189, 22)
        Me.mnuManageHardware.Text = "Manage Hardware"
        '
        'mnuSetUpUserAccounts
        '
        Me.mnuSetUpUserAccounts.Name = "mnuSetUpUserAccounts"
        Me.mnuSetUpUserAccounts.Size = New System.Drawing.Size(189, 22)
        Me.mnuSetUpUserAccounts.Text = "Set Up User Accounts"
        '
        'mnuChangeDisplay
        '
        Me.mnuChangeDisplay.Name = "mnuChangeDisplay"
        Me.mnuChangeDisplay.Size = New System.Drawing.Size(189, 22)
        Me.mnuChangeDisplay.Text = "Change Display"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Contents, Me.toolStripSeparator2, Me.About})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(40, 20)
        Me.mnuHelp.Text = "Help"
        '
        'Contents
        '
        Me.Contents.Name = "Contents"
        Me.Contents.Size = New System.Drawing.Size(129, 22)
        Me.Contents.Text = "Contents"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(126, 6)
        '
        'About
        '
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(129, 22)
        Me.About.Text = "About"
        '
        'DynamicDBMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 205)
        Me.Controls.Add(Me.cmdAdmin)
        Me.Controls.Add(Me.cmdUser)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "DynamicDBMenu"
        Me.Text = "DynamicDBMenu"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents cmdAdmin As System.Windows.Forms.Button
    Friend WithEvents cmdUser As System.Windows.Forms.Button
    Private mnuMain As System.Windows.Forms.MenuStrip
    Private mnuFile As System.Windows.Forms.ToolStripMenuItem
    Private mnuNew As System.Windows.Forms.ToolStripMenuItem
    Private mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Private mnuClose As System.Windows.Forms.ToolStripMenuItem
    Private mnuSave As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private mnuExit As System.Windows.Forms.ToolStripMenuItem
    Private mnuTools As System.Windows.Forms.ToolStripMenuItem
    Private mnuManageHardware As System.Windows.Forms.ToolStripMenuItem
    Private mnuSetUpUserAccounts As System.Windows.Forms.ToolStripMenuItem
    Private mnuChangeDisplay As System.Windows.Forms.ToolStripMenuItem
    Private mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Private Contents As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private About As System.Windows.Forms.ToolStripMenuItem
End Class
