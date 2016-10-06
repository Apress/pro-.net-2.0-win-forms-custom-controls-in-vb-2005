Imports Microsoft.VisualBasic
Imports System
Namespace MultithreadingClient
    Friend Partial Class AsyncTestMultiple
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.cmdNewSearch = New System.Windows.Forms.ToolStripButton()

            Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.statusPanel = New System.Windows.Forms.ToolStripStatusLabel()
            Me.toolStrip1.SuspendLayout()

            Me.statusStrip1.SuspendLayout()
            Me.SuspendLayout()
' 
' toolStrip1
' 
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.cmdNewSearch })
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"

            Me.toolStrip1.TabIndex = 0
            Me.toolStrip1.Text = "toolStrip1"
' 
' cmdNewSearch
' 
            Me.cmdNewSearch.Name = "cmdNewSearch"

            Me.cmdNewSearch.Text = "New Search"
'            Me.cmdNewSearch.Click += New System.EventHandler(Me.cmdNewSearch_Click);
' 
' statusStrip1
' 
            Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.statusPanel })
            Me.statusStrip1.Location = New System.Drawing.Point(0, 0)
            Me.statusStrip1.Name = "statusStrip1"
            Me.statusStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
            Me.statusStrip1.TabIndex = 1
            Me.statusStrip1.Text = "statusStrip1"
' 
' statusPanel
' 
            Me.statusPanel.Name = "statusPanel"
' 
' AsyncTestMultiple
' 
            Me.Controls.Add(toolStrip1)
            Me.Controls.Add(statusStrip1)
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(448, 401)
            Me.IsMdiContainer = True
            Me.Name = "AsyncTestMultiple"
            Me.Text = "Prime Number Searcher"
'            Me.FormClosed += New System.Windows.Forms.FormClosedEventHandler(Me.AsyncTestMultiple_FormClosed);
            Me.toolStrip1.ResumeLayout(False)
            Me.statusStrip1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private toolStrip1 As System.Windows.Forms.ToolStrip
        Private WithEvents cmdNewSearch As System.Windows.Forms.ToolStripButton
        Private statusStrip1 As System.Windows.Forms.StatusStrip
        Private statusPanel As System.Windows.Forms.ToolStripStatusLabel
    End Class
End Namespace