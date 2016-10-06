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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.lblLastName = New System.Windows.Forms.Label
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'textBox2
        '
        Me.textBox2.AccessibleDescription = Nothing
        Me.textBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.textBox2, "textBox2")
        Me.textBox2.BackgroundImage = Nothing
        Me.textBox2.Font = Nothing
        Me.textBox2.Name = "textBox2"
        '
        'textBox1
        '
        Me.textBox1.AccessibleDescription = Nothing
        Me.textBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.textBox1, "textBox1")
        Me.textBox1.BackgroundImage = Nothing
        Me.textBox1.Font = Nothing
        Me.textBox1.Name = "textBox1"
        '
        'lblLastName
        '
        Me.lblLastName.AccessibleDescription = Nothing
        Me.lblLastName.AccessibleName = Nothing
        resources.ApplyResources(Me.lblLastName, "lblLastName")
        Me.lblLastName.Font = Nothing
        Me.lblLastName.Name = "lblLastName"
        '
        'lblFirstName
        '
        Me.lblFirstName.AccessibleDescription = Nothing
        Me.lblFirstName.AccessibleName = Nothing
        resources.ApplyResources(Me.lblFirstName, "lblFirstName")
        Me.lblFirstName.Font = Nothing
        Me.lblFirstName.Name = "lblFirstName"
        '
        'Form1
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents lblLastName As System.Windows.Forms.Label
    Private WithEvents lblFirstName As System.Windows.Forms.Label

End Class
