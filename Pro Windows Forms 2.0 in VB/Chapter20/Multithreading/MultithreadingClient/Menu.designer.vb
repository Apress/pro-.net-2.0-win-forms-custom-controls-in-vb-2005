Imports Microsoft.VisualBasic
Imports System
Namespace MultithreadingClient
    Public Partial Class Menu
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
            Me.button1 = New System.Windows.Forms.Button
            Me.button2 = New System.Windows.Forms.Button
            Me.button3 = New System.Windows.Forms.Button
            Me.button4 = New System.Windows.Forms.Button
            Me.button5 = New System.Windows.Forms.Button
            Me.button6 = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(12, 12)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(168, 23)
            Me.button1.TabIndex = 0
            Me.button1.Text = "SyncTest"
            '
            'button2
            '
            Me.button2.Location = New System.Drawing.Point(12, 41)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(168, 23)
            Me.button2.TabIndex = 1
            Me.button2.Text = "AsyncTest"
            '
            'button3
            '
            Me.button3.Location = New System.Drawing.Point(12, 70)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(168, 23)
            Me.button3.TabIndex = 2
            Me.button3.Text = "AsyncTest2"
            '
            'button4
            '
            Me.button4.Location = New System.Drawing.Point(12, 99)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(168, 23)
            Me.button4.TabIndex = 3
            Me.button4.Text = "AsyncTestBackgroundWorker"
            '
            'button5
            '
            Me.button5.Location = New System.Drawing.Point(12, 128)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(168, 23)
            Me.button5.TabIndex = 4
            Me.button5.Text = "AsyncTestMultiple"
            '
            'button6
            '
            Me.button6.Location = New System.Drawing.Point(12, 157)
            Me.button6.Name = "button6"
            Me.button6.Size = New System.Drawing.Size(168, 23)
            Me.button6.TabIndex = 5
            Me.button6.Text = "TaskManagerClient"
            '
            'Menu
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(194, 200)
            Me.Controls.Add(Me.button6)
            Me.Controls.Add(Me.button5)
            Me.Controls.Add(Me.button4)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "Menu"
            Me.Text = "Menu"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents button2 As System.Windows.Forms.Button
        Private WithEvents button3 As System.Windows.Forms.Button
        Private WithEvents button4 As System.Windows.Forms.Button
        Private WithEvents button5 As System.Windows.Forms.Button
        Private WithEvents button6 As System.Windows.Forms.Button

    End Class
End Namespace

