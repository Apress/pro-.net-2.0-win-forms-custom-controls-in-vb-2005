Imports Microsoft.VisualBasic
Imports System

Partial Public Class Menu
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button11 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        ' 
        ' button1
        ' 
        Me.button1.Location = New System.Drawing.Point(12, 7)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(144, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "HandMadeLayoutManager"
        '            Me.button1.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' button11
        ' 
        Me.button11.Location = New System.Drawing.Point(12, 33)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(144, 23)
        Me.button11.TabIndex = 10
        Me.button11.Text = "FlowLayoutTest"
        '            Me.button11.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' button2
        ' 
        Me.button2.Location = New System.Drawing.Point(12, 59)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(144, 23)
        Me.button2.TabIndex = 11
        Me.button2.Text = "TableLayoutTest"
        '            Me.button2.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' button3
        ' 
        Me.button3.Location = New System.Drawing.Point(13, 85)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(144, 23)
        Me.button3.TabIndex = 12
        Me.button3.Text = "CellSpanning"
        '            Me.button3.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' button4
        ' 
        Me.button4.Location = New System.Drawing.Point(13, 111)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(144, 23)
        Me.button4.TabIndex = 13
        Me.button4.Text = "LocalizableDialog"
        '            Me.button4.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' button5
        ' 
        Me.button5.Location = New System.Drawing.Point(12, 138)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(144, 23)
        Me.button5.TabIndex = 14
        Me.button5.Text = "ProportionalResizing"
        '            Me.button5.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' button6
        ' 
        Me.button6.Location = New System.Drawing.Point(12, 167)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(144, 23)
        Me.button6.TabIndex = 15
        Me.button6.Text = "TextBoxColumn"
        '            Me.button6.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' button7
        ' 
        Me.button7.Location = New System.Drawing.Point(12, 196)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(144, 23)
        Me.button7.TabIndex = 16
        Me.button7.Text = "FormsFromFile"
        '            Me.button7.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' button8
        ' 
        Me.button8.Location = New System.Drawing.Point(12, 225)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(144, 23)
        Me.button8.TabIndex = 17
        Me.button8.Text = "CustomLayoutEngine"
        '            Me.button8.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' button9
        ' 
        Me.button9.Location = New System.Drawing.Point(12, 254)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(144, 23)
        Me.button9.TabIndex = 18
        Me.button9.Text = "ModularPortal"
        '            Me.button9.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' Menu
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(170, 297)
        Me.Controls.Add(Me.button9)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button11)
        Me.Controls.Add(Me.button1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.Name = "Menu"
        Me.Text = "Menu"
        '            Me.Load += New System.EventHandler(Me.Menu_Load);
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button11 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents button5 As System.Windows.Forms.Button
    Private WithEvents button6 As System.Windows.Forms.Button
    Private WithEvents button7 As System.Windows.Forms.Button
    Private WithEvents button8 As System.Windows.Forms.Button
    Private WithEvents button9 As System.Windows.Forms.Button

End Class


