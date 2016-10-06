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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdClose = New System.Windows.Forms.Button
        Me.grpValidation = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.cmdOK = New System.Windows.Forms.Button
        Me.requiredFirstName = New ValidationComponents.RequiredFieldValidator(Me.components)
        Me.requiredLastName = New ValidationComponents.RequiredFieldValidator(Me.components)
        Me.regularExpressionValidator1 = New ValidationComponents.RegularExpressionValidator(Me.components)
        Me.grpValidation.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.CausesValidation = False
        Me.cmdClose.Location = New System.Drawing.Point(203, 209)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 24)
        Me.cmdClose.TabIndex = 19
        Me.cmdClose.Text = "Cancel"
        '
        'grpValidation
        '
        Me.grpValidation.Controls.Add(Me.Label3)
        Me.grpValidation.Controls.Add(Me.txtEmail)
        Me.grpValidation.Controls.Add(Me.Label2)
        Me.grpValidation.Controls.Add(Me.Label1)
        Me.grpValidation.Controls.Add(Me.txtFirstName)
        Me.grpValidation.Controls.Add(Me.txtLastName)
        Me.grpValidation.Location = New System.Drawing.Point(16, 10)
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
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(121, 209)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(76, 24)
        Me.cmdOK.TabIndex = 17
        Me.cmdOK.Text = "OK"
        '
        'requiredFirstName
        '
        Me.requiredFirstName.CancelFocusChangeWhenInvalid = False
        Me.requiredFirstName.ControlToValidate = Me.txtFirstName
        Me.requiredFirstName.ErrorMessage = "A first name is required."
        Me.requiredFirstName.Icon = CType(resources.GetObject("requiredFirstName.Icon"), System.Drawing.Icon)
        '
        'requiredLastName
        '
        Me.requiredLastName.CancelFocusChangeWhenInvalid = False
        Me.requiredLastName.ControlToValidate = Me.txtLastName
        Me.requiredLastName.ErrorMessage = "A last name is required."
        Me.requiredLastName.Icon = CType(resources.GetObject("requiredLastName.Icon"), System.Drawing.Icon)
        '
        'regularExpressionValidator1
        '
        Me.regularExpressionValidator1.CancelFocusChangeWhenInvalid = True
        Me.regularExpressionValidator1.ControlToValidate = Me.txtEmail
        Me.regularExpressionValidator1.ErrorMessage = "Not a valid email address."
        Me.regularExpressionValidator1.Icon = CType(resources.GetObject("regularExpressionValidator1.Icon"), System.Drawing.Icon)
        Me.regularExpressionValidator1.ValidationExpression = "^\S+@\S+\.\S+$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 242)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.grpValidation)
        Me.Controls.Add(Me.cmdOK)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpValidation.ResumeLayout(False)
        Me.grpValidation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdClose As System.Windows.Forms.Button
    Private WithEvents grpValidation As System.Windows.Forms.GroupBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtFirstName As System.Windows.Forms.TextBox
    Private WithEvents txtLastName As System.Windows.Forms.TextBox
    Private WithEvents cmdOK As System.Windows.Forms.Button
    Private WithEvents requiredFirstName As ValidationComponents.RequiredFieldValidator
    Private WithEvents requiredLastName As ValidationComponents.RequiredFieldValidator
    Private WithEvents regularExpressionValidator1 As ValidationComponents.RegularExpressionValidator

End Class
