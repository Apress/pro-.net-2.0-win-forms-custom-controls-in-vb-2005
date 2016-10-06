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
        Me.components = New System.ComponentModel.Container
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.grpValidation = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpValidation.SuspendLayout()
        Me.SuspendLayout()
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        Me.errProvider.DataMember = ""
        '
        'cmdClose
        '
        Me.cmdClose.CausesValidation = False
        Me.cmdClose.Location = New System.Drawing.Point(204, 208)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 24)
        Me.cmdClose.TabIndex = 19
        Me.cmdClose.Text = "Cancel"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(122, 208)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(76, 24)
        Me.cmdOK.TabIndex = 17
        Me.cmdOK.Text = "OK"
        '
        'grpValidation
        '
        Me.grpValidation.Controls.Add(Me.Label3)
        Me.grpValidation.Controls.Add(Me.txtEmail)
        Me.grpValidation.Controls.Add(Me.Label2)
        Me.grpValidation.Controls.Add(Me.Label1)
        Me.grpValidation.Controls.Add(Me.txtFirstName)
        Me.grpValidation.Controls.Add(Me.txtLastName)
        Me.grpValidation.Location = New System.Drawing.Point(9, 11)
        Me.grpValidation.Name = "grpValidation"
        Me.grpValidation.Size = New System.Drawing.Size(368, 124)
        Me.grpValidation.TabIndex = 18
        Me.grpValidation.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(84, 84)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(152, 21)
        Me.txtEmail.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(84, 24)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(152, 21)
        Me.txtFirstName.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(84, 48)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(152, 21)
        Me.txtLastName.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 243)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.grpValidation)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpValidation.ResumeLayout(False)
        Me.grpValidation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents errProvider As System.Windows.Forms.ErrorProvider
    Private WithEvents cmdClose As System.Windows.Forms.Button
    Private WithEvents cmdOK As System.Windows.Forms.Button
    Private WithEvents grpValidation As System.Windows.Forms.GroupBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtFirstName As System.Windows.Forms.TextBox
    Private WithEvents txtLastName As System.Windows.Forms.TextBox

End Class
