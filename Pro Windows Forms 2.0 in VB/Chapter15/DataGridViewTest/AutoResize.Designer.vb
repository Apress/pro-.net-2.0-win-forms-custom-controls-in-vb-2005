Imports Microsoft.VisualBasic
Imports System
Namespace DataGridViewTest
	Public Partial Class AutoResize
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
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.optWrapDesc = New System.Windows.Forms.RadioButton()
			Me.optNoWrap = New System.Windows.Forms.RadioButton()
			Me.optAllWrap = New System.Windows.Forms.RadioButton()
			Me.lstAutoSizeRows = New System.Windows.Forms.ComboBox()
			Me.lstAutoSizeColumns = New System.Windows.Forms.ComboBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dataGridView1
			' 
			Me.dataGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.dataGridView1.Location = New System.Drawing.Point(5, 5)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(493, 317)
			Me.dataGridView1.TabIndex = 1
			Me.dataGridView1.Text = "dataGridView1"
			' 
			' panel1
			' 
			Me.panel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel1.Controls.Add(Me.optWrapDesc)
			Me.panel1.Controls.Add(Me.optNoWrap)
			Me.panel1.Controls.Add(Me.optAllWrap)
			Me.panel1.Controls.Add(Me.lstAutoSizeRows)
			Me.panel1.Controls.Add(Me.lstAutoSizeColumns)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Location = New System.Drawing.Point(5, 332)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(493, 51)
			Me.panel1.TabIndex = 2
			' 
			' optWrapDesc
			' 
			Me.optWrapDesc.AutoSize = True
			Me.optWrapDesc.Location = New System.Drawing.Point(331, 33)
			Me.optWrapDesc.Name = "optWrapDesc"
			Me.optWrapDesc.Size = New System.Drawing.Size(132, 17)
			Me.optWrapDesc.TabIndex = 6
			Me.optWrapDesc.Text = "Wrap Description Only"
'			Me.optWrapDesc.CheckedChanged += New System.EventHandler(Me.optWrapDesc_CheckedChanged);
			' 
			' optNoWrap
			' 
			Me.optNoWrap.AutoSize = True
			Me.optNoWrap.Location = New System.Drawing.Point(331, 17)
			Me.optNoWrap.Name = "optNoWrap"
			Me.optNoWrap.Size = New System.Drawing.Size(110, 17)
			Me.optNoWrap.TabIndex = 5
			Me.optNoWrap.Text = "Wrap No Columns"
'			Me.optNoWrap.CheckedChanged += New System.EventHandler(Me.optNoWrap_CheckedChanged);
			' 
			' optAllWrap
			' 
			Me.optAllWrap.AutoSize = True
			Me.optAllWrap.Location = New System.Drawing.Point(331, 1)
			Me.optAllWrap.Name = "optAllWrap"
			Me.optAllWrap.Size = New System.Drawing.Size(108, 17)
			Me.optAllWrap.TabIndex = 4
			Me.optAllWrap.Text = "Wrap All Columns"
'			Me.optAllWrap.CheckedChanged += New System.EventHandler(Me.optAllWrap_CheckedChanged);
			' 
			' lstAutoSizeRows
			' 
			Me.lstAutoSizeRows.CausesValidation = False
			Me.lstAutoSizeRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.lstAutoSizeRows.FormattingEnabled = True
			Me.lstAutoSizeRows.Location = New System.Drawing.Point(133, 24)
			Me.lstAutoSizeRows.Name = "lstAutoSizeRows"
			Me.lstAutoSizeRows.Size = New System.Drawing.Size(144, 21)
			Me.lstAutoSizeRows.TabIndex = 3
'			Me.lstAutoSizeRows.SelectedIndexChanged += New System.EventHandler(Me.lst_SelectedIndexChanged);
			' 
			' lstAutoSizeColumns
			' 
			Me.lstAutoSizeColumns.CausesValidation = False
			Me.lstAutoSizeColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.lstAutoSizeColumns.FormattingEnabled = True
			Me.lstAutoSizeColumns.Location = New System.Drawing.Point(133, 1)
			Me.lstAutoSizeColumns.Name = "lstAutoSizeColumns"
			Me.lstAutoSizeColumns.Size = New System.Drawing.Size(144, 21)
			Me.lstAutoSizeColumns.TabIndex = 2
'			Me.lstAutoSizeColumns.SelectedIndexChanged += New System.EventHandler(Me.lst_SelectedIndexChanged);
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(26, 27)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(105, 13)
			Me.label2.TabIndex = 1
			Me.label2.Text = "AutoSizeRowsMode:"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 7)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(119, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "AutoSizeColumnsMode:"
			' 
			' AutoResize
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(510, 389)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.dataGridView1)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Name = "AutoResize"
			Me.Text = "AutoResize"
'			Me.Load += New System.EventHandler(Me.AutoResize_Load);
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents lstAutoSizeColumns As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private WithEvents lstAutoSizeRows As System.Windows.Forms.ComboBox
		Private WithEvents optNoWrap As System.Windows.Forms.RadioButton
		Private WithEvents optAllWrap As System.Windows.Forms.RadioButton
		Private WithEvents optWrapDesc As System.Windows.Forms.RadioButton
	End Class
End Namespace