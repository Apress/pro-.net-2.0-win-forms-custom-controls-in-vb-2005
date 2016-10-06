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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.imagesSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.listView = New System.Windows.Forms.ListView
        Me.lblStatus = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'imagesSmall
        '
        Me.imagesSmall.ImageStream = CType(resources.GetObject("imagesSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagesSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.imagesSmall.Images.SetKeyName(0, "")
        '
        'listView
        '
        Me.listView.AllowColumnReorder = True
        Me.listView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listView.Location = New System.Drawing.Point(4, 5)
        Me.listView.Name = "listView"
        Me.listView.Size = New System.Drawing.Size(385, 300)
        Me.listView.SmallImageList = Me.imagesSmall
        Me.listView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.listView.TabIndex = 5
        Me.listView.UseCompatibleStateImageBehavior = False
        Me.listView.View = System.Windows.Forms.View.Details
        Me.listView.VirtualMode = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(8, 317)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 341)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.listView)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "ListView Virtualization"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents imagesSmall As System.Windows.Forms.ImageList
    Private WithEvents listView As System.Windows.Forms.ListView
    Private WithEvents lblStatus As System.Windows.Forms.Label

End Class
