Imports Microsoft.VisualBasic
Imports System
Namespace DataGridViewTest
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
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button5 = New System.Windows.Forms.Button()
			Me.button6 = New System.Windows.Forms.Button()
			Me.button7 = New System.Windows.Forms.Button()
			Me.button8 = New System.Windows.Forms.Button()
			Me.button9 = New System.Windows.Forms.Button()
			Me.button10 = New System.Windows.Forms.Button()
			Me.button12 = New System.Windows.Forms.Button()
			Me.button13 = New System.Windows.Forms.Button()
			Me.button14 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(12, 7)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(124, 23)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Barebones"
'			Me.button1.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(12, 33)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(124, 23)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Unbound"
'			Me.button2.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(12, 57)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(124, 23)
			Me.button3.TabIndex = 2
			Me.button3.Text = "Selection"
'			Me.button3.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button4
			' 
			Me.button4.Location = New System.Drawing.Point(12, 82)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(124, 23)
			Me.button4.TabIndex = 3
			Me.button4.Text = "CustomSorting"
'			Me.button4.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button5
			' 
			Me.button5.Location = New System.Drawing.Point(12, 107)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(124, 23)
			Me.button5.TabIndex = 4
			Me.button5.Text = "Formatting"
'			Me.button5.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button6
			' 
			Me.button6.Location = New System.Drawing.Point(12, 132)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(124, 23)
			Me.button6.TabIndex = 5
			Me.button6.Text = "AutoResize"
'			Me.button6.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button7
			' 
			Me.button7.Location = New System.Drawing.Point(12, 157)
			Me.button7.Name = "button7"
			Me.button7.Size = New System.Drawing.Size(124, 23)
			Me.button7.TabIndex = 6
			Me.button7.Text = "ProportionateFill"
'			Me.button7.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button8
			' 
			Me.button8.Location = New System.Drawing.Point(12, 182)
			Me.button8.Name = "button8"
			Me.button8.Size = New System.Drawing.Size(124, 23)
			Me.button8.TabIndex = 7
			Me.button8.Text = "Wrapping"
'			Me.button8.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button9
			' 
			Me.button9.Location = New System.Drawing.Point(12, 207)
			Me.button9.Name = "button9"
			Me.button9.Size = New System.Drawing.Size(124, 23)
			Me.button9.TabIndex = 8
			Me.button9.Text = "UnboundImage"
'			Me.button9.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button10
			' 
			Me.button10.Location = New System.Drawing.Point(12, 232)
			Me.button10.Name = "button10"
			Me.button10.Size = New System.Drawing.Size(124, 23)
			Me.button10.TabIndex = 9
			Me.button10.Text = "BoundImage"
'			Me.button10.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button12
			' 
			Me.button12.Location = New System.Drawing.Point(12, 257)
			Me.button12.Name = "button12"
			Me.button12.Size = New System.Drawing.Size(124, 23)
			Me.button12.TabIndex = 11
			Me.button12.Text = "ButtonColumn"
'			Me.button12.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button13
			' 
			Me.button13.Location = New System.Drawing.Point(12, 283)
			Me.button13.Name = "button13"
			Me.button13.Size = New System.Drawing.Size(124, 23)
			Me.button13.TabIndex = 12
			Me.button13.Text = "ValidateErrors"
'			Me.button13.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' button14
			' 
			Me.button14.Location = New System.Drawing.Point(12, 310)
			Me.button14.Name = "button14"
			Me.button14.Size = New System.Drawing.Size(124, 23)
			Me.button14.TabIndex = 13
			Me.button14.Text = "ListColumn"
'			Me.button14.Click += New System.EventHandler(Me.cmd_Click);
			' 
			' Menu
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(158, 350)
			Me.Controls.Add(Me.button14)
			Me.Controls.Add(Me.button13)
			Me.Controls.Add(Me.button12)
			Me.Controls.Add(Me.button10)
			Me.Controls.Add(Me.button9)
			Me.Controls.Add(Me.button8)
			Me.Controls.Add(Me.button7)
			Me.Controls.Add(Me.button6)
			Me.Controls.Add(Me.button5)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
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
		Private WithEvents button7 As System.Windows.Forms.Button
		Private WithEvents button8 As System.Windows.Forms.Button
		Private WithEvents button9 As System.Windows.Forms.Button
		Private WithEvents button10 As System.Windows.Forms.Button
		Private WithEvents button12 As System.Windows.Forms.Button
		Private WithEvents button13 As System.Windows.Forms.Button
		Private WithEvents button14 As System.Windows.Forms.Button

	End Class
End Namespace

