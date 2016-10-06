Imports Microsoft.VisualBasic
Imports System
Namespace DataGridViewTest
	Public Partial Class Selection
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
			Me.txtSelectionInfo = New System.Windows.Forms.TextBox()
			Me.cmdSelectionInfo = New System.Windows.Forms.Button()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' txtSelectionInfo
			' 
			Me.txtSelectionInfo.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtSelectionInfo.Location = New System.Drawing.Point(7, 7)
			Me.txtSelectionInfo.Multiline = True
			Me.txtSelectionInfo.Name = "txtSelectionInfo"
			Me.txtSelectionInfo.ReadOnly = True
			Me.txtSelectionInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
			Me.txtSelectionInfo.Size = New System.Drawing.Size(395, 89)
			Me.txtSelectionInfo.TabIndex = 5
			' 
			' cmdSelectionInfo
			' 
			Me.cmdSelectionInfo.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cmdSelectionInfo.Location = New System.Drawing.Point(408, 13)
			Me.cmdSelectionInfo.Name = "cmdSelectionInfo"
			Me.cmdSelectionInfo.Size = New System.Drawing.Size(89, 54)
			Me.cmdSelectionInfo.TabIndex = 4
			Me.cmdSelectionInfo.Text = "Get Selection Info"
'			Me.cmdSelectionInfo.Click += New System.EventHandler(Me.cmdSelectionInfo_Click);
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.splitContainer1.Location = New System.Drawing.Point(0, -2)
			Me.splitContainer1.Name = "splitContainer1"
			Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.dataGridView1)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.txtSelectionInfo)
			Me.splitContainer1.Panel2.Controls.Add(Me.cmdSelectionInfo)
			Me.splitContainer1.Size = New System.Drawing.Size(509, 370)
			Me.splitContainer1.SplitterDistance = 263
			Me.splitContainer1.TabIndex = 2
			Me.splitContainer1.Text = "splitContainer1"
			' 
			' dataGridView1
			' 
			Me.dataGridView1.AllowUserToOrderColumns = True
			Me.dataGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.dataGridView1.Location = New System.Drawing.Point(8, 7)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(495, 251)
			Me.dataGridView1.TabIndex = 1
'			Me.dataGridView1.SelectionChanged += New System.EventHandler(Me.dataGridView1_SelectionChanged);
			' 
			' Selection
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(509, 367)
			Me.Controls.Add(Me.splitContainer1)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Name = "Selection"
			Me.Text = "Selection"
'			Me.Load += New System.EventHandler(Me.Selection_Load);
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.Panel2.PerformLayout()
			Me.splitContainer1.ResumeLayout(False)
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private txtSelectionInfo As System.Windows.Forms.TextBox
		Private WithEvents cmdSelectionInfo As System.Windows.Forms.Button
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
	End Class
End Namespace