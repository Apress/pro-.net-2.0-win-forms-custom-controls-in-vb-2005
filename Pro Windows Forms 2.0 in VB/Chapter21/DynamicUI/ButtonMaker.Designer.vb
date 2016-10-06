Imports Microsoft.VisualBasic
Imports System

Partial Public Class ButtonMaker
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLeft)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCreate)
        Me.GroupBox1.Controls.Add(Me.txtTop)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 128)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Me.Label1.Location = New System.Drawing.Point(16, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Left:"
        ' 
        ' txtLeft
        ' 
        Me.txtLeft.Location = New System.Drawing.Point(76, 52)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(68, 20)
        Me.txtLeft.TabIndex = 4
        Me.txtLeft.Text = "200"
        ' 
        ' Label2
        ' 
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Top:"
        ' 
        ' cmdCreate
        ' 
        Me.cmdCreate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdCreate.Location = New System.Drawing.Point(36, 84)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(112, 28)
        Me.cmdCreate.TabIndex = 2
        Me.cmdCreate.Text = "Create Button"
        '            Me.cmdCreate.Click += New System.EventHandler(Me.cmdCreate_Click);
        ' 
        ' txtTop
        ' 
        Me.txtTop.Location = New System.Drawing.Point(76, 24)
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(68, 20)
        Me.txtTop.TabIndex = 3
        Me.txtTop.Text = "50"
        ' 
        ' statusStrip1
        ' 
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 216)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(391, 22)
        Me.statusStrip1.TabIndex = 11
        Me.statusStrip1.Text = "statusStrip1"
        ' 
        ' lblStatus
        ' 
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(376, 17)
        Me.lblStatus.Spring = True
        ' 
        ' ButtonMaker
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 238)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ButtonMaker"
        Me.Text = "ButtonMaker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend GroupBox1 As System.Windows.Forms.GroupBox
    Friend Label1 As System.Windows.Forms.Label
    Friend txtLeft As System.Windows.Forms.TextBox
    Friend Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdCreate As System.Windows.Forms.Button
    Friend txtTop As System.Windows.Forms.TextBox
    Private statusStrip1 As System.Windows.Forms.StatusStrip
    Private lblStatus As System.Windows.Forms.ToolStripStatusLabel
End Class
