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
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid
        Me.GradientPanel1 = New GradientPanelControl.GradientPanel
        Me.SuspendLayout()
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Location = New System.Drawing.Point(12, 130)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.SelectedObject = Me.GradientPanel1
        Me.PropertyGrid1.Size = New System.Drawing.Size(408, 249)
        Me.PropertyGrid1.TabIndex = 1
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(200, 100)
        Me.GradientPanel1.TabIndex = 2
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(446, 412)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents GradientPanel1 As GradientPanelControl.GradientPanel

End Class
