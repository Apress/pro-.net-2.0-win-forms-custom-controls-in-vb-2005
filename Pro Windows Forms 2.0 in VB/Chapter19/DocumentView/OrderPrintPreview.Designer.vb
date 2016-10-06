Imports Microsoft.VisualBasic
Imports System
Namespace DocumentView
	Public Partial Class OrderPrintPreview
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
			Me.Preview = New System.Windows.Forms.PrintPreviewControl()
			Me.SuspendLayout()
			' 
			' Preview
			' 
			Me.Preview.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.Preview.AutoZoom = False
			Me.Preview.Location = New System.Drawing.Point(4, 4)
			Me.Preview.Name = "Preview"
			Me.Preview.Size = New System.Drawing.Size(401, 204)
			Me.Preview.TabIndex = 2
			Me.Preview.Zoom = 1
			' 
			' OrderPrintPreview
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.Preview)
			Me.Name = "OrderPrintPreview"
			Me.Size = New System.Drawing.Size(408, 212)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private Preview As System.Windows.Forms.PrintPreviewControl
	End Class
End Namespace
