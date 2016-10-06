Imports Microsoft.VisualBasic
Imports System
Namespace DataGridViewTest
	Public Partial Class UnboundImage
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnboundImage))
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.imageList = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataGridView1
			' 
			Me.dataGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.dataGridView1.Location = New System.Drawing.Point(5, 4)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(405, 306)
			Me.dataGridView1.TabIndex = 1
			Me.dataGridView1.Text = "dataGridView1"
'			Me.dataGridView1.CellValueChanged += New System.Windows.Forms.DataGridViewCellEventHandler(Me.dataGridView1_CellValueChanged);
			' 
			' imageList
			' 
			Me.imageList.ImageStream = (CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList.Images.SetKeyName(0, "new2.bmp")
			Me.imageList.Images.SetKeyName(1, "folder.bmp")
			' 
			' UnboundImage
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(417, 322)
			Me.Controls.Add(Me.dataGridView1)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Name = "UnboundImage"
			Me.Text = "UnboundImage"
'			Me.Load += New System.EventHandler(Me.UnboundImage_Load);
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
		Private imageList As System.Windows.Forms.ImageList
	End Class
End Namespace