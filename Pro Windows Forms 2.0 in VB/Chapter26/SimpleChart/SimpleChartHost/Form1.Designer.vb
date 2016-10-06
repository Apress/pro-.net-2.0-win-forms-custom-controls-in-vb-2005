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
        Me.Label1 = New System.Windows.Forms.Label
        Me.SimpleChart1 = New SimpleChartControl.SimpleChart
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Historical Sales Report"
        '
        'SimpleChart1
        '
        Me.SimpleChart1.Bars.Add(New SimpleChartControl.BarItem("Bar 1", 300.0!))
        Me.SimpleChart1.Bars.Add(New SimpleChartControl.BarItem("Bar 2", 220.0!))
        Me.SimpleChart1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleChart1.Name = "SimpleChart1"
        Me.SimpleChart1.Size = New System.Drawing.Size(423, 242)
        Me.SimpleChart1.TabIndex = 6
        Me.SimpleChart1.Text = "SimpleChart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 335)
        Me.Controls.Add(Me.SimpleChart1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleChart1 As SimpleChartControl.SimpleChart

End Class
