Imports Microsoft.VisualBasic
Imports System

Partial Friend Class ProportionalResizing
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
        Dim treeNode4 As New System.Windows.Forms.TreeNode("Node1")
        Dim treeNode5 As New System.Windows.Forms.TreeNode("Node2")
        Dim treeNode6 As New System.Windows.Forms.TreeNode("Node0", New System.Windows.Forms.TreeNode() {treeNode4, treeNode5})
        Dim listViewItem3 As New System.Windows.Forms.ListViewItem("Item1")
        Dim listViewItem4 As New System.Windows.Forms.ListViewItem("Item2")
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
        Me.tableLayoutPanel1.Controls.Add(Me.treeView1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.listView1, 1, 0)
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0F))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(257, 136)
        Me.tableLayoutPanel1.TabIndex = 0
        ' 
        ' treeView1
        ' 
        Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeView1.Location = New System.Drawing.Point(3, 3)
        Me.treeView1.Name = "treeView1"
        treeNode4.Name = "Node1"
        treeNode4.Text = "Node1"
        treeNode5.Name = "Node2"
        treeNode5.Text = "Node2"
        treeNode6.Name = "Node0"
        treeNode6.Text = "Node0"
        Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {treeNode6})
        Me.treeView1.Scrollable = False
        Me.treeView1.Size = New System.Drawing.Size(122, 130)
        Me.treeView1.TabIndex = 1
        ' 
        ' listView1
        ' 
        Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {listViewItem3, listViewItem4})
        Me.listView1.Location = New System.Drawing.Point(131, 3)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(123, 130)
        Me.listView1.TabIndex = 3
        ' 
        ' BiPaneProportionalResize
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(263, 151)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.Name = "BiPaneProportionalResize"
        Me.Text = "Bi-Pane Proportional Resize"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private treeView1 As System.Windows.Forms.TreeView
    Private listView1 As System.Windows.Forms.ListView

End Class
