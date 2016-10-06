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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstFonts = New System.Windows.Forms.ListBox
        Me.lblSampleText = New System.Windows.Forms.Label
        Me.lstColors = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(210, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Choose a Font:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 12)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Choose a Color:"
        '
        'lstFonts
        '
        Me.lstFonts.FormattingEnabled = True
        Me.lstFonts.Location = New System.Drawing.Point(210, 22)
        Me.lstFonts.Name = "lstFonts"
        Me.lstFonts.Size = New System.Drawing.Size(180, 134)
        Me.lstFonts.TabIndex = 17
        '
        'lblSampleText
        '
        Me.lblSampleText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSampleText.Location = New System.Drawing.Point(18, 178)
        Me.lblSampleText.Name = "lblSampleText"
        Me.lblSampleText.Size = New System.Drawing.Size(372, 96)
        Me.lblSampleText.TabIndex = 16
        Me.lblSampleText.Text = "Click an item in one of the lists above to change the font or color of this text." & _
            " Once the initial conditions are set up (i.e., the binding), this operation happ" & _
            "ens automatically."
        '
        'lstColors
        '
        Me.lstColors.FormattingEnabled = True
        Me.lstColors.Location = New System.Drawing.Point(14, 22)
        Me.lstColors.Name = "lstColors"
        Me.lstColors.Size = New System.Drawing.Size(176, 134)
        Me.lstColors.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 281)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstFonts)
        Me.Controls.Add(Me.lblSampleText)
        Me.Controls.Add(Me.lstColors)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Binding Unusual Properties"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents lstFonts As System.Windows.Forms.ListBox
    Private WithEvents lblSampleText As System.Windows.Forms.Label
    Private WithEvents lstColors As System.Windows.Forms.ListBox

End Class
