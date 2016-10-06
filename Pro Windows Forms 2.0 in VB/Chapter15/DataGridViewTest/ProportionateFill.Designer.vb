Imports Microsoft.VisualBasic
Imports System
Namespace DataGridViewTest
	Public Partial Class ProportionateFill
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
			Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataGridView1
			' 
			Me.dataGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
			dataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
			dataGridViewCellStyle1.FormatProvider = New System.Globalization.CultureInfo("en-US")
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False
			Me.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1
			Me.dataGridView1.Location = New System.Drawing.Point(7, 7)
			Me.dataGridView1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 3)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(391, 319)
			Me.dataGridView1.TabIndex = 1
			Me.dataGridView1.Text = "dataGridView1"
			' 
			' ProportionateFill
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(406, 353)
			Me.Controls.Add(Me.dataGridView1)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Margin = New System.Windows.Forms.Padding(3, 3, 3, 3)
			Me.Name = "ProportionateFill"
			Me.Text = "ProportionateFill"
'			Me.Load += New System.EventHandler(Me.ProportionateFill_Load);
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataGridView1 As System.Windows.Forms.DataGridView
	End Class
End Namespace