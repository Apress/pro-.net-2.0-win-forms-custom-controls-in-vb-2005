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
        Me.SuspendLayout()
        ' 
        ' button1
        ' 
        Me.button1.Location = New System.Drawing.Point(12, 7)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(124, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "DynamicMenu"
        '            Me.button1.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' button11
        ' 
        Me.button11.Location = New System.Drawing.Point(12, 33)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(124, 23)
        Me.button11.TabIndex = 10
        Me.button11.Text = "DynamicDBMenu"
        '            Me.button11.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' button2
        ' 
        Me.button2.Location = New System.Drawing.Point(12, 59)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(124, 23)
        Me.button2.TabIndex = 11
        Me.button2.Text = "ButtonMaker"
        '            Me.button2.Click += New System.EventHandler(Me.cmd_Click);
        ' 
        ' Menu
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(158, 205)
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

End Class


