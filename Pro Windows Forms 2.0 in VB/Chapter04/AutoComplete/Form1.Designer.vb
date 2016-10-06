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
        Me.lstColors = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'lstColors
        '
        Me.lstColors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.lstColors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lstColors.FormattingEnabled = True
        Me.lstColors.Location = New System.Drawing.Point(25, 35)
        Me.lstColors.Name = "lstColors"
        Me.lstColors.Size = New System.Drawing.Size(267, 21)
        Me.lstColors.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 90)
        Me.Controls.Add(Me.lstColors)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lstColors As System.Windows.Forms.ComboBox

End Class
