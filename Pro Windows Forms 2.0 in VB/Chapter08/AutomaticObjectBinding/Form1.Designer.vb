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
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim ModelNameLabel As System.Windows.Forms.Label
        Dim ModelNumberLabel As System.Windows.Forms.Label
        Dim UnitCostLabel As System.Windows.Forms.Label
        Me.ProductListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ProductListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.ModelNameTextBox = New System.Windows.Forms.TextBox
        Me.ModelNumberTextBox = New System.Windows.Forms.TextBox
        Me.UnitCostTextBox = New System.Windows.Forms.TextBox
        Me.ProductListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        DescriptionLabel = New System.Windows.Forms.Label
        ModelNameLabel = New System.Windows.Forms.Label
        ModelNumberLabel = New System.Windows.Forms.Label
        UnitCostLabel = New System.Windows.Forms.Label
        CType(Me.ProductListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductListBindingNavigator.SuspendLayout()
        CType(Me.ProductListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductListBindingNavigator
        '
        Me.ProductListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductListBindingNavigator.BindingSource = Me.ProductListBindingSource
        Me.ProductListBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductListBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductListBindingNavigatorSaveItem})
        Me.ProductListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductListBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductListBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductListBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductListBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductListBindingNavigator.Name = "ProductListBindingNavigator"
        Me.ProductListBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductListBindingNavigator.Size = New System.Drawing.Size(342, 25)
        Me.ProductListBindingNavigator.TabIndex = 0
        Me.ProductListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ProductListBindingNavigatorSaveItem
        '
        Me.ProductListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductListBindingNavigatorSaveItem.Enabled = False
        Me.ProductListBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductListBindingNavigatorSaveItem.Name = "ProductListBindingNavigatorSaveItem"
        Me.ProductListBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(47, 50)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 1
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductListBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(132, 47)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescriptionTextBox.TabIndex = 2
        '
        'ModelNameLabel
        '
        ModelNameLabel.AutoSize = True
        ModelNameLabel.Location = New System.Drawing.Point(47, 76)
        ModelNameLabel.Name = "ModelNameLabel"
        ModelNameLabel.Size = New System.Drawing.Size(70, 13)
        ModelNameLabel.TabIndex = 3
        ModelNameLabel.Text = "Model Name:"
        '
        'ModelNameTextBox
        '
        Me.ModelNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductListBindingSource, "ModelName", True))
        Me.ModelNameTextBox.Location = New System.Drawing.Point(132, 73)
        Me.ModelNameTextBox.Name = "ModelNameTextBox"
        Me.ModelNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelNameTextBox.TabIndex = 4
        '
        'ModelNumberLabel
        '
        ModelNumberLabel.AutoSize = True
        ModelNumberLabel.Location = New System.Drawing.Point(47, 102)
        ModelNumberLabel.Name = "ModelNumberLabel"
        ModelNumberLabel.Size = New System.Drawing.Size(79, 13)
        ModelNumberLabel.TabIndex = 5
        ModelNumberLabel.Text = "Model Number:"
        '
        'ModelNumberTextBox
        '
        Me.ModelNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductListBindingSource, "ModelNumber", True))
        Me.ModelNumberTextBox.Location = New System.Drawing.Point(132, 99)
        Me.ModelNumberTextBox.Name = "ModelNumberTextBox"
        Me.ModelNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelNumberTextBox.TabIndex = 6
        '
        'UnitCostLabel
        '
        UnitCostLabel.AutoSize = True
        UnitCostLabel.Location = New System.Drawing.Point(47, 128)
        UnitCostLabel.Name = "UnitCostLabel"
        UnitCostLabel.Size = New System.Drawing.Size(53, 13)
        UnitCostLabel.TabIndex = 7
        UnitCostLabel.Text = "Unit Cost:"
        '
        'UnitCostTextBox
        '
        Me.UnitCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductListBindingSource, "UnitCost", True))
        Me.UnitCostTextBox.Location = New System.Drawing.Point(132, 125)
        Me.UnitCostTextBox.Name = "UnitCostTextBox"
        Me.UnitCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UnitCostTextBox.TabIndex = 8
        '
        'ProductListBindingSource
        '
        Me.ProductListBindingSource.DataSource = GetType(AutomaticObjectBinding.Product)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 289)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(ModelNameLabel)
        Me.Controls.Add(Me.ModelNameTextBox)
        Me.Controls.Add(ModelNumberLabel)
        Me.Controls.Add(Me.ModelNumberTextBox)
        Me.Controls.Add(UnitCostLabel)
        Me.Controls.Add(Me.UnitCostTextBox)
        Me.Controls.Add(Me.ProductListBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ProductListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductListBindingNavigator.ResumeLayout(False)
        Me.ProductListBindingNavigator.PerformLayout()
        CType(Me.ProductListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProductListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModelNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModelNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitCostTextBox As System.Windows.Forms.TextBox

End Class
