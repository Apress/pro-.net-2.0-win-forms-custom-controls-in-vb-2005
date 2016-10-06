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
        Me.imagesLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.txtSelected = New System.Windows.Forms.TextBox
        Me.cmdResizeColumns = New System.Windows.Forms.Button
        Me.listView = New System.Windows.Forms.ListView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkGroups = New System.Windows.Forms.CheckBox
        Me.optTile = New System.Windows.Forms.RadioButton
        Me.optLargeIcon = New System.Windows.Forms.RadioButton
        Me.optList = New System.Windows.Forms.RadioButton
        Me.optDetails = New System.Windows.Forms.RadioButton
        Me.optSmallIcon = New System.Windows.Forms.RadioButton
        Me.cmdFillList = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imagesSmall
        '
        Me.imagesSmall.ImageStream = CType(resources.GetObject("imagesSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagesSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.imagesSmall.Images.SetKeyName(0, "")
        '
        'imagesLarge
        '
        Me.imagesLarge.ImageStream = CType(resources.GetObject("imagesLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagesLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.imagesLarge.Images.SetKeyName(0, "")
        '
        'txtSelected
        '
        Me.txtSelected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelected.Location = New System.Drawing.Point(7, 299)
        Me.txtSelected.Multiline = True
        Me.txtSelected.Name = "txtSelected"
        Me.txtSelected.ReadOnly = True
        Me.txtSelected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSelected.Size = New System.Drawing.Size(254, 73)
        Me.txtSelected.TabIndex = 15
        '
        'cmdResizeColumns
        '
        Me.cmdResizeColumns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdResizeColumns.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdResizeColumns.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResizeColumns.Location = New System.Drawing.Point(269, 228)
        Me.cmdResizeColumns.Name = "cmdResizeColumns"
        Me.cmdResizeColumns.Size = New System.Drawing.Size(114, 24)
        Me.cmdResizeColumns.TabIndex = 14
        Me.cmdResizeColumns.Text = "Auto Resize Columns"
        '
        'listView
        '
        Me.listView.AllowColumnReorder = True
        Me.listView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listView.FullRowSelect = True
        Me.listView.GridLines = True
        Me.listView.LargeImageList = Me.imagesLarge
        Me.listView.Location = New System.Drawing.Point(7, 11)
        Me.listView.MultiSelect = False
        Me.listView.Name = "listView"
        Me.listView.Size = New System.Drawing.Size(254, 282)
        Me.listView.SmallImageList = Me.imagesSmall
        Me.listView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.listView.TabIndex = 11
        Me.listView.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkGroups)
        Me.GroupBox1.Controls.Add(Me.optTile)
        Me.GroupBox1.Controls.Add(Me.optLargeIcon)
        Me.GroupBox1.Controls.Add(Me.optList)
        Me.GroupBox1.Controls.Add(Me.optDetails)
        Me.GroupBox1.Controls.Add(Me.optSmallIcon)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(269, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 177)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View"
        '
        'chkGroups
        '
        Me.chkGroups.AutoSize = True
        Me.chkGroups.Location = New System.Drawing.Point(14, 150)
        Me.chkGroups.Name = "chkGroups"
        Me.chkGroups.Size = New System.Drawing.Size(89, 17)
        Me.chkGroups.TabIndex = 11
        Me.chkGroups.Text = "Show Groups"
        '
        'optTile
        '
        Me.optTile.Checked = True
        Me.optTile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optTile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTile.Location = New System.Drawing.Point(16, 119)
        Me.optTile.Name = "optTile"
        Me.optTile.Size = New System.Drawing.Size(56, 16)
        Me.optTile.TabIndex = 1
        Me.optTile.TabStop = True
        Me.optTile.Tag = ""
        Me.optTile.Text = "Tile"
        '
        'optLargeIcon
        '
        Me.optLargeIcon.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optLargeIcon.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLargeIcon.Location = New System.Drawing.Point(16, 48)
        Me.optLargeIcon.Name = "optLargeIcon"
        Me.optLargeIcon.Size = New System.Drawing.Size(76, 16)
        Me.optLargeIcon.TabIndex = 0
        Me.optLargeIcon.Text = "LargeIcon"
        '
        'optList
        '
        Me.optList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optList.Location = New System.Drawing.Point(16, 96)
        Me.optList.Name = "optList"
        Me.optList.Size = New System.Drawing.Size(56, 16)
        Me.optList.TabIndex = 0
        Me.optList.Text = "List"
        '
        'optDetails
        '
        Me.optDetails.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optDetails.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDetails.Location = New System.Drawing.Point(16, 72)
        Me.optDetails.Name = "optDetails"
        Me.optDetails.Size = New System.Drawing.Size(72, 16)
        Me.optDetails.TabIndex = 0
        Me.optDetails.Text = "Details"
        '
        'optSmallIcon
        '
        Me.optSmallIcon.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optSmallIcon.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSmallIcon.Location = New System.Drawing.Point(16, 24)
        Me.optSmallIcon.Name = "optSmallIcon"
        Me.optSmallIcon.Size = New System.Drawing.Size(72, 16)
        Me.optSmallIcon.TabIndex = 0
        Me.optSmallIcon.Text = "SmallIcon"
        '
        'cmdFillList
        '
        Me.cmdFillList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFillList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdFillList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFillList.Location = New System.Drawing.Point(269, 198)
        Me.cmdFillList.Name = "cmdFillList"
        Me.cmdFillList.Size = New System.Drawing.Size(114, 24)
        Me.cmdFillList.TabIndex = 12
        Me.cmdFillList.Text = "Fill List"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 383)
        Me.Controls.Add(Me.txtSelected)
        Me.Controls.Add(Me.cmdResizeColumns)
        Me.Controls.Add(Me.listView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdFillList)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "ListView Example"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents imagesSmall As System.Windows.Forms.ImageList
    Private WithEvents imagesLarge As System.Windows.Forms.ImageList
    Private WithEvents txtSelected As System.Windows.Forms.TextBox
    Private WithEvents cmdResizeColumns As System.Windows.Forms.Button
    Private WithEvents listView As System.Windows.Forms.ListView
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents chkGroups As System.Windows.Forms.CheckBox
    Private WithEvents optTile As System.Windows.Forms.RadioButton
    Private WithEvents optLargeIcon As System.Windows.Forms.RadioButton
    Private WithEvents optList As System.Windows.Forms.RadioButton
    Private WithEvents optDetails As System.Windows.Forms.RadioButton
    Private WithEvents optSmallIcon As System.Windows.Forms.RadioButton
    Private WithEvents cmdFillList As System.Windows.Forms.Button

End Class
