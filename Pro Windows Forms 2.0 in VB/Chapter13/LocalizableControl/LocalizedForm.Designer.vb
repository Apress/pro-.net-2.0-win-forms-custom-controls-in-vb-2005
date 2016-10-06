<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocalizedForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocalizedForm))
        Me.LocalizableUserControl1 = New LocalizableControl.LocalizableUserControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LocalizableUserControl1
        '
        resources.ApplyResources(Me.LocalizableUserControl1, "LocalizableUserControl1")
        Me.LocalizableUserControl1.Name = "LocalizableUserControl1"
        Me.LocalizableUserControl1.NonLocalizableText = "nonLocalizable"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Label1.Name = "Label1"
        '
        'LocalizedForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LocalizableUserControl1)
        Me.Name = "LocalizedForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LocalizableUserControl1 As LocalizableControl.LocalizableUserControl
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
