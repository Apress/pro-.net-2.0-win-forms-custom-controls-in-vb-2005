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
        Me.cmdAsyncState = New System.Windows.Forms.Button
        Me.lbl = New System.Windows.Forms.Label
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmdAsyncState
        '
        Me.cmdAsyncState.Location = New System.Drawing.Point(44, 204)
        Me.cmdAsyncState.Name = "cmdAsyncState"
        Me.cmdAsyncState.Size = New System.Drawing.Size(141, 24)
        Me.cmdAsyncState.TabIndex = 5
        Me.cmdAsyncState.Text = "GetAsyncState() for ""D"""
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(43, 79)
        Me.lbl.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(0, 13)
        Me.lbl.TabIndex = 4
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(44, 26)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(205, 41)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "<Text will never appear here because of Form.KeyPreview>"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.cmdAsyncState)
        Me.Controls.Add(Me.lbl)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Key Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cmdAsyncState As System.Windows.Forms.Button
    Private WithEvents lbl As System.Windows.Forms.Label
    Private WithEvents textBox1 As System.Windows.Forms.TextBox

End Class
