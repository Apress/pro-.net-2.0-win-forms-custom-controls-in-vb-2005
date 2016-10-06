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
        Me.dateTimePicker4 = New System.Windows.Forms.DateTimePicker
        Me.dateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.dateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'dateTimePicker4
        '
        Me.dateTimePicker4.CustomFormat = "yyyy-mm-dd"
        Me.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimePicker4.Location = New System.Drawing.Point(102, 128)
        Me.dateTimePicker4.Name = "dateTimePicker4"
        Me.dateTimePicker4.Size = New System.Drawing.Size(200, 21)
        Me.dateTimePicker4.TabIndex = 16
        '
        'dateTimePicker3
        '
        Me.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dateTimePicker3.Location = New System.Drawing.Point(102, 92)
        Me.dateTimePicker3.Name = "dateTimePicker3"
        Me.dateTimePicker3.Size = New System.Drawing.Size(200, 21)
        Me.dateTimePicker3.TabIndex = 15
        '
        'dateTimePicker2
        '
        Me.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTimePicker2.Location = New System.Drawing.Point(102, 54)
        Me.dateTimePicker2.Name = "dateTimePicker2"
        Me.dateTimePicker2.Size = New System.Drawing.Size(200, 21)
        Me.dateTimePicker2.TabIndex = 14
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(22, 132)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(68, 13)
        Me.label4.TabIndex = 13
        Me.label4.Text = "Custom ISO:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(22, 96)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(33, 13)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Time:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 58)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(37, 13)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Short:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(22, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(34, 13)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Long:"
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.Location = New System.Drawing.Point(102, 19)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.dateTimePicker1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 242)
        Me.Controls.Add(Me.dateTimePicker4)
        Me.Controls.Add(Me.dateTimePicker3)
        Me.Controls.Add(Me.dateTimePicker2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dateTimePicker1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dateTimePicker4 As System.Windows.Forms.DateTimePicker
    Private WithEvents dateTimePicker3 As System.Windows.Forms.DateTimePicker
    Private WithEvents dateTimePicker2 As System.Windows.Forms.DateTimePicker
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents dateTimePicker1 As System.Windows.Forms.DateTimePicker

End Class
