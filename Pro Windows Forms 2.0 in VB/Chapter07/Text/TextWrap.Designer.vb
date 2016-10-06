<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextWrap
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
        Me.lstAlignmentV = New System.Windows.Forms.ComboBox
        Me.label3 = New System.Windows.Forms.Label
        Me.lstTrimming = New System.Windows.Forms.ComboBox
        Me.lstAlignmentH = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lstAlignmentV
        '
        Me.lstAlignmentV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstAlignmentV.FormattingEnabled = True
        Me.lstAlignmentV.Location = New System.Drawing.Point(145, 42)
        Me.lstAlignmentV.Name = "lstAlignmentV"
        Me.lstAlignmentV.Size = New System.Drawing.Size(121, 21)
        Me.lstAlignmentV.TabIndex = 11
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(26, 47)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(104, 13)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Alignment (Vertical):"
        '
        'lstTrimming
        '
        Me.lstTrimming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstTrimming.FormattingEnabled = True
        Me.lstTrimming.Location = New System.Drawing.Point(145, 69)
        Me.lstTrimming.Name = "lstTrimming"
        Me.lstTrimming.Size = New System.Drawing.Size(121, 21)
        Me.lstTrimming.TabIndex = 9
        '
        'lstAlignmentH
        '
        Me.lstAlignmentH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstAlignmentH.FormattingEnabled = True
        Me.lstAlignmentH.Location = New System.Drawing.Point(145, 16)
        Me.lstAlignmentH.Name = "lstAlignmentH"
        Me.lstAlignmentH.Size = New System.Drawing.Size(121, 21)
        Me.lstAlignmentH.TabIndex = 8
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(26, 74)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(53, 13)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Trimming:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(26, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(117, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Alignment (Horizontal):"
        '
        'TextWrap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 392)
        Me.Controls.Add(Me.lstAlignmentV)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lstTrimming)
        Me.Controls.Add(Me.lstAlignmentH)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "TextWrap"
        Me.Text = "TextWrap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lstAlignmentV As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents lstTrimming As System.Windows.Forms.ComboBox
    Private WithEvents lstAlignmentH As System.Windows.Forms.ComboBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
