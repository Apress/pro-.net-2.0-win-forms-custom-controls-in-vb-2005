Imports Microsoft.VisualBasic
Imports System
Namespace DataGridViewTest
	Public Partial Class ValidateErrors
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
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataGridView1
			' 
			Me.dataGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.dataGridView1.Location = New System.Drawing.Point(4, 8)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(376, 306)
			Me.dataGridView1.TabIndex = 1
			Me.dataGridView1.Text = "dataGridView1"
'			Me.dataGridView1.UserDeletingRow += New System.Windows.Forms.DataGridViewRowCancelEventHandler(Me.dataGridView1_UserDeletingRow);
'			Me.dataGridView1.CellValidating += New System.Windows.Forms.DataGridViewCellValidatingEventHandler(Me.dataGridView1_CellValidating);
'			Me.dataGridView1.DataError += New System.Windows.Forms.DataGridViewDataErrorEventHandler(Me.dataGridView1_DataError);
			' 
			' ValidateErrors
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(385, 339)
			Me.Controls.Add(Me.dataGridView1)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Name = "ValidateErrors"
			Me.Text = "ValidateErrors"
'			Me.Load += New System.EventHandler(Me.ValidateErrors_Load);
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
	End Class
End Namespace