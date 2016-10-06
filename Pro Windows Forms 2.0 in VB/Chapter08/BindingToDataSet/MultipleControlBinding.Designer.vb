<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultipleControlBinding
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblUnitCost = New System.Windows.Forms.Label
        Me.lblModelNumber = New System.Windows.Forms.Label
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdPrev = New System.Windows.Forms.Button
        Me.cboModelName = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.lblUnitCost)
        Me.GroupBox1.Controls.Add(Me.lblModelNumber)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(20, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 174)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.Location = New System.Drawing.Point(8, 58)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(300, 104)
        Me.lblDescription.TabIndex = 6
        '
        'lblUnitCost
        '
        Me.lblUnitCost.Location = New System.Drawing.Point(168, 16)
        Me.lblUnitCost.Name = "lblUnitCost"
        Me.lblUnitCost.Size = New System.Drawing.Size(136, 32)
        Me.lblUnitCost.TabIndex = 5
        '
        'lblModelNumber
        '
        Me.lblModelNumber.Location = New System.Drawing.Point(8, 16)
        Me.lblModelNumber.Name = "lblModelNumber"
        Me.lblModelNumber.Size = New System.Drawing.Size(140, 32)
        Me.lblModelNumber.TabIndex = 4
        '
        'cmdNext
        '
        Me.cmdNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNext.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdNext.Location = New System.Drawing.Point(244, 238)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(92, 28)
        Me.cmdNext.TabIndex = 17
        Me.cmdNext.Text = "Next >>"
        '
        'cmdPrev
        '
        Me.cmdPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdPrev.Enabled = False
        Me.cmdPrev.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdPrev.Location = New System.Drawing.Point(20, 238)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(92, 28)
        Me.cmdPrev.TabIndex = 16
        Me.cmdPrev.Text = "<< Prev"
        '
        'cboModelName
        '
        Me.cboModelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModelName.FormattingEnabled = True
        Me.cboModelName.Location = New System.Drawing.Point(20, 16)
        Me.cboModelName.Name = "cboModelName"
        Me.cboModelName.Size = New System.Drawing.Size(316, 21)
        Me.cboModelName.TabIndex = 15
        '
        'MultipleControlBinding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 283)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.cboModelName)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MultipleControlBinding"
        Me.Text = "MultipleControlBinding"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lblDescription As System.Windows.Forms.Label
    Private WithEvents lblUnitCost As System.Windows.Forms.Label
    Private WithEvents lblModelNumber As System.Windows.Forms.Label
    Private WithEvents cmdNext As System.Windows.Forms.Button
    Private WithEvents cmdPrev As System.Windows.Forms.Button
    Private WithEvents cboModelName As System.Windows.Forms.ComboBox
End Class
