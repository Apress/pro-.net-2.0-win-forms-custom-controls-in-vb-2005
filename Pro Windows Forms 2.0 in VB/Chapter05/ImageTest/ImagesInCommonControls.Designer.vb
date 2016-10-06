<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImagesInCommonControls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImagesInCommonControls))
        Me.label1 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.button2 = New System.Windows.Forms.Button
        Me.label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
        Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.label1.Location = New System.Drawing.Point(40, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(105, 77)
        Me.label1.TabIndex = 6
        Me.label1.Text = "label1"
        '
        'button1
        '
        Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.button1.Location = New System.Drawing.Point(32, 111)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(132, 74)
        Me.button1.TabIndex = 7
        Me.button1.Text = "button1"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.Image = CType(resources.GetObject("radioButton1.Image"), System.Drawing.Image)
        Me.radioButton1.Location = New System.Drawing.Point(32, 207)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(224, 47)
        Me.radioButton1.TabIndex = 8
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "radioButton1"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Image = CType(resources.GetObject("button2.Image"), System.Drawing.Image)
        Me.button2.Location = New System.Drawing.Point(181, 111)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(101, 74)
        Me.button2.TabIndex = 9
        Me.button2.Text = "button2"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Image)
        Me.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.label2.Location = New System.Drawing.Point(178, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(78, 77)
        Me.label2.TabIndex = 10
        Me.label2.Text = "label2"
        '
        'ImagesInCommonControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 274)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.radioButton1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ImagesInCommonControls"
        Me.Text = "ImagesInCommonControls"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
End Class
