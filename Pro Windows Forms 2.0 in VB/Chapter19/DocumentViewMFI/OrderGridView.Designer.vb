Imports Microsoft.VisualBasic
Imports System
Namespace DocumentView
	Public Partial Class OrderGridView
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.cmdRemove = New System.Windows.Forms.Button()
			Me.cmdAdd = New System.Windows.Forms.Button()
			Me.list = New System.Windows.Forms.ListView()
			Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
			Me.SuspendLayout()
			' 
			' cmdRemove
			' 
			Me.cmdRemove.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cmdRemove.Location = New System.Drawing.Point(280, 37)
			Me.cmdRemove.Name = "cmdRemove"
			Me.cmdRemove.Size = New System.Drawing.Size(112, 28)
			Me.cmdRemove.TabIndex = 8
			Me.cmdRemove.Text = "Remove Item"
'			Me.cmdRemove.Click += New System.EventHandler(Me.cmdRemove_Click);
			' 
			' cmdAdd
			' 
			Me.cmdAdd.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cmdAdd.Location = New System.Drawing.Point(280, 5)
			Me.cmdAdd.Name = "cmdAdd"
			Me.cmdAdd.Size = New System.Drawing.Size(112, 28)
			Me.cmdAdd.TabIndex = 7
			Me.cmdAdd.Text = "Add Random Item"
'			Me.cmdAdd.Click += New System.EventHandler(Me.cmdAdd_Click);
			' 
			' list
			' 
			Me.list.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
			Me.list.FullRowSelect = True
			Me.list.Location = New System.Drawing.Point(4, 5)
			Me.list.MultiSelect = False
			Me.list.Name = "list"
			Me.list.Size = New System.Drawing.Size(264, 136)
			Me.list.TabIndex = 6
			Me.list.View = System.Windows.Forms.View.Details
			' 
			' ColumnHeader1
			' 
			Me.ColumnHeader1.Text = "ID"
			Me.ColumnHeader1.Width = 30
			' 
			' ColumnHeader2
			' 
			Me.ColumnHeader2.Text = "Name"
			Me.ColumnHeader2.Width = 100
			' 
			' ColumnHeader3
			' 
			Me.ColumnHeader3.Text = "Price"
			Me.ColumnHeader3.Width = 50
			' 
			' ColumnHeader4
			' 
			Me.ColumnHeader4.Text = "Description"
			Me.ColumnHeader4.Width = 200
			' 
			' OrderGridView
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.cmdRemove)
			Me.Controls.Add(Me.cmdAdd)
			Me.Controls.Add(Me.list)
			Me.Name = "OrderGridView"
			Me.Size = New System.Drawing.Size(397, 146)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents cmdRemove As System.Windows.Forms.Button
		Private WithEvents cmdAdd As System.Windows.Forms.Button
		Private list As System.Windows.Forms.ListView
		Private ColumnHeader1 As System.Windows.Forms.ColumnHeader
		Private ColumnHeader2 As System.Windows.Forms.ColumnHeader
		Private ColumnHeader3 As System.Windows.Forms.ColumnHeader
		Private ColumnHeader4 As System.Windows.Forms.ColumnHeader
	End Class
End Namespace
