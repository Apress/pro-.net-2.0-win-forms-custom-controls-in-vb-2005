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
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer
        Me.pnlFileList = New System.Windows.Forms.Panel
        Me.cmdHide = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.pnlShow = New System.Windows.Forms.Panel
        Me.cmdShow = New System.Windows.Forms.Button
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.pnlFileList.SuspendLayout()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        Me.pnlShow.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(29, 10)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.pnlFileList)
        Me.splitContainer1.Panel1MinSize = 50
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.splitContainer2)
        Me.splitContainer1.Size = New System.Drawing.Size(520, 371)
        Me.splitContainer1.SplitterDistance = 168
        Me.splitContainer1.TabIndex = 24
        Me.splitContainer1.Text = "splitContainer1"
        '
        'pnlFileList
        '
        Me.pnlFileList.Controls.Add(Me.cmdHide)
        Me.pnlFileList.Controls.Add(Me.ListView1)
        Me.pnlFileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFileList.Location = New System.Drawing.Point(0, 0)
        Me.pnlFileList.Name = "pnlFileList"
        Me.pnlFileList.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pnlFileList.Size = New System.Drawing.Size(168, 371)
        Me.pnlFileList.TabIndex = 21
        '
        'cmdHide
        '
        Me.cmdHide.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdHide.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdHide.Location = New System.Drawing.Point(0, 351)
        Me.cmdHide.Name = "cmdHide"
        Me.cmdHide.Size = New System.Drawing.Size(167, 20)
        Me.cmdHide.TabIndex = 23
        Me.cmdHide.Text = "<< Hide"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.Location = New System.Drawing.Point(0, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(165, 342)
        Me.ListView1.TabIndex = 22
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Name = "ColumnHeader1"
        Me.ColumnHeader1.Text = "File"
        Me.ColumnHeader1.Width = 99
        '
        'splitContainer2
        '
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer2.Name = "splitContainer2"
        Me.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.Controls.Add(Me.webBrowser1)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.TextBox1)
        Me.splitContainer2.Size = New System.Drawing.Size(348, 371)
        Me.splitContainer2.SplitterDistance = 175
        Me.splitContainer2.TabIndex = 0
        Me.splitContainer2.Text = "splitContainer2"
        '
        'webBrowser1
        '
        Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(348, 175)
        Me.webBrowser1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(348, 192)
        Me.TextBox1.TabIndex = 1
        '
        'pnlShow
        '
        Me.pnlShow.Controls.Add(Me.cmdShow)
        Me.pnlShow.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlShow.Location = New System.Drawing.Point(10, 10)
        Me.pnlShow.Name = "pnlShow"
        Me.pnlShow.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.pnlShow.Size = New System.Drawing.Size(19, 371)
        Me.pnlShow.TabIndex = 25
        Me.pnlShow.Visible = False
        '
        'cmdShow
        '
        Me.cmdShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdShow.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdShow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShow.Location = New System.Drawing.Point(0, 0)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(16, 371)
        Me.cmdShow.TabIndex = 21
        Me.cmdShow.Text = ">"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 391)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.pnlShow)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Split Window"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.pnlFileList.ResumeLayout(False)
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel2.ResumeLayout(False)
        Me.splitContainer2.Panel2.PerformLayout()
        Me.splitContainer2.ResumeLayout(False)
        Me.pnlShow.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents pnlFileList As System.Windows.Forms.Panel
    Private WithEvents cmdHide As System.Windows.Forms.Button
    Private WithEvents ListView1 As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents splitContainer2 As System.Windows.Forms.SplitContainer
    Private WithEvents webBrowser1 As System.Windows.Forms.WebBrowser
    Private WithEvents TextBox1 As System.Windows.Forms.TextBox
    Private WithEvents pnlShow As System.Windows.Forms.Panel
    Private WithEvents cmdShow As System.Windows.Forms.Button

End Class
