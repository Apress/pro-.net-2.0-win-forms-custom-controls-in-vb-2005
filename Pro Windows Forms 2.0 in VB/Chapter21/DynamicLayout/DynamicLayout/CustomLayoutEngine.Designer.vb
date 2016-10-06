Imports Microsoft.VisualBasic
Imports System

Partial Public Class CustomLayoutEngine
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
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        ' 
        ' button1
        ' 
        Me.button1.Location = New System.Drawing.Point(0, 0)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = True
        ' 
        ' button2
        ' 
        Me.button2.Location = New System.Drawing.Point(23, 51)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "button2"
        Me.button2.UseVisualStyleBackColor = True
        ' 
        ' button3
        ' 
        Me.button3.Location = New System.Drawing.Point(31, 59)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 23)
        Me.button3.TabIndex = 2
        Me.button3.Text = "button3"
        Me.button3.UseVisualStyleBackColor = True
        ' 
        ' CustomLayoutEngine
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 342)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Name = "CustomLayoutEngine"
        Me.Text = "CustomLayoutEngine"
        '            Me.Load += New System.EventHandler(Me.CustomLayoutEngine_Load);
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private button1 As System.Windows.Forms.Button
    Private button2 As System.Windows.Forms.Button
    Private button3 As System.Windows.Forms.Button
End Class
