Imports Microsoft.VisualBasic
Imports System

Partial Public Class Test
    Inherits System.Windows.Forms.Form
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
        Me.container2 = New Container()
        Me.containerChild1 = New ContainerControls.ContainerChild()
        Me.container1 = New Container()
        Me.containerChild3 = New ContainerControls.ContainerChild()
        Me.containerChild2 = New ContainerControls.ContainerChild()
        Me.containerChild4 = New ContainerControls.ContainerChild()
        Me.container2.SuspendLayout()
        Me.container1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' container2
        ' 
        Me.container2.Controls.Add(Me.containerChild1)
        Me.container2.Location = New System.Drawing.Point(76, 9)
        Me.container2.Name = "container2"
        Me.container2.Size = New System.Drawing.Size(202, 88)
        Me.container2.TabIndex = 8
        Me.container2.Text = "container2"
        ' 
        ' containerChild1
        ' 
        Me.containerChild1.Location = New System.Drawing.Point(42, 32)
        Me.containerChild1.Name = "containerChild1"
        Me.containerChild1.Size = New System.Drawing.Size(88, 23)
        Me.containerChild1.TabIndex = 0
        Me.containerChild1.Text = "containerChild1"
        ' 
        ' container1
        ' 
        Me.container1.Controls.Add(Me.containerChild4)
        Me.container1.Controls.Add(Me.containerChild3)
        Me.container1.Controls.Add(Me.containerChild2)
        Me.container1.Location = New System.Drawing.Point(76, 128)
        Me.container1.Name = "container1"
        Me.container1.Size = New System.Drawing.Size(202, 148)
        Me.container1.TabIndex = 7
        Me.container1.Text = "container1"
        ' 
        ' containerChild3
        ' 
        Me.containerChild3.Location = New System.Drawing.Point(64, 30)
        Me.containerChild3.Name = "containerChild3"
        Me.containerChild3.Size = New System.Drawing.Size(91, 23)
        Me.containerChild3.TabIndex = 1
        Me.containerChild3.Text = "containerChild3"
        ' 
        ' containerChild2
        ' 
        Me.containerChild2.Location = New System.Drawing.Point(23, 76)
        Me.containerChild2.Name = "containerChild2"
        Me.containerChild2.Size = New System.Drawing.Size(90, 23)
        Me.containerChild2.TabIndex = 0
        Me.containerChild2.Text = "containerChild2"
        ' 
        ' containerChild4
        ' 
        Me.containerChild4.Location = New System.Drawing.Point(101, 106)
        Me.containerChild4.Name = "containerChild4"
        Me.containerChild4.Size = New System.Drawing.Size(75, 23)
        Me.containerChild4.TabIndex = 2
        Me.containerChild4.Text = "containerChild4"
        ' 
        ' Test
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 288)
        Me.Controls.Add(Me.container2)
        Me.Controls.Add(Me.container1)
        Me.Name = "Test"
        Me.Text = "Test"
        Me.container2.ResumeLayout(False)
        Me.container1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private container2 As Container
    Private containerChild1 As ContainerChild
    Private container1 As Container
    Private containerChild3 As ContainerChild
    Private containerChild2 As ContainerChild
    Private containerChild4 As ContainerChild

End Class
