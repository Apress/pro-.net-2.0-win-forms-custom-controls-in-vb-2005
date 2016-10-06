<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LookupTable
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
        Me.label1 = New System.Windows.Forms.Label
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboModelName = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(12, 52)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(110, 16)
        Me.label1.TabIndex = 31
        Me.label1.Text = "Change its Category:"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(122, 48)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(267, 21)
        Me.cboCategory.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Select a Record:"
        '
        'cboModelName
        '
        Me.cboModelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModelName.FormattingEnabled = True
        Me.cboModelName.Location = New System.Drawing.Point(122, 18)
        Me.cboModelName.Name = "cboModelName"
        Me.cboModelName.Size = New System.Drawing.Size(267, 21)
        Me.cboModelName.TabIndex = 28
        '
        'LookupTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 193)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboModelName)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LookupTable"
        Me.Text = "LookupTable"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cboCategory As System.Windows.Forms.ComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cboModelName As System.Windows.Forms.ComboBox
End Class
