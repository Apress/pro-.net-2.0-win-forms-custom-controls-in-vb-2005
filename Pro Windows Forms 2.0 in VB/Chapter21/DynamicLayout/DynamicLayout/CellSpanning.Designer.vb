Imports Microsoft.VisualBasic
Imports System

Partial Public Class CellSpanning
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
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.button10 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.tableLayoutPanel1.ColumnCount = 4
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.08092F))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.34104F))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
        Me.tableLayoutPanel1.Controls.Add(Me.button1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.button2, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.button5, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button6, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button7, 2, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button8, 3, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button9, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.button10, 3, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.button3, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button4, 0, 1)
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 4
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(348, 249)
        Me.tableLayoutPanel1.TabIndex = 0
        ' 
        ' button1
        ' 
        Me.button1.Location = New System.Drawing.Point(5, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = True
        ' 
        ' button2
        ' 
        Me.tableLayoutPanel1.SetColumnSpan(Me.button2, 3)
        Me.button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button2.Location = New System.Drawing.Point(116, 5)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(227, 40)
        Me.button2.TabIndex = 1
        Me.button2.Text = "ColumnSpan = 3"
        Me.button2.UseVisualStyleBackColor = True
        ' 
        ' button5
        ' 
        Me.button5.Location = New System.Drawing.Point(116, 53)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(52, 23)
        Me.button5.TabIndex = 4
        Me.button5.Text = "button5"
        Me.button5.UseVisualStyleBackColor = True
        ' 
        ' button6
        ' 
        Me.button6.Location = New System.Drawing.Point(116, 101)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(52, 23)
        Me.button6.TabIndex = 5
        Me.button6.Text = "button6"
        Me.button6.UseVisualStyleBackColor = True
        ' 
        ' button7
        ' 
        Me.button7.Location = New System.Drawing.Point(5, 161)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(75, 23)
        Me.button7.TabIndex = 6
        Me.button7.Text = "button7"
        Me.button7.UseVisualStyleBackColor = True
        ' 
        ' button8
        ' 
        Me.button8.Location = New System.Drawing.Point(116, 161)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(52, 23)
        Me.button8.TabIndex = 7
        Me.button8.Text = "button8"
        Me.button8.UseVisualStyleBackColor = True
        ' 
        ' button9
        ' 
        Me.button9.Location = New System.Drawing.Point(176, 161)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(75, 23)
        Me.button9.TabIndex = 8
        Me.button9.Text = "button9"
        Me.button9.UseVisualStyleBackColor = True
        ' 
        ' button10
        ' 
        Me.button10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button10.Location = New System.Drawing.Point(262, 197)
        Me.button10.Name = "button10"
        Me.button10.Size = New System.Drawing.Size(81, 47)
        Me.button10.TabIndex = 9
        Me.button10.Text = "Row = 4" & Constants.vbLf & "Column = 3"
        Me.button10.UseVisualStyleBackColor = True
        ' 
        ' button3
        ' 
        Me.tableLayoutPanel1.SetColumnSpan(Me.button3, 2)
        Me.button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button3.Location = New System.Drawing.Point(176, 53)
        Me.button3.Name = "button3"
        Me.tableLayoutPanel1.SetRowSpan(Me.button3, 2)
        Me.button3.Size = New System.Drawing.Size(167, 100)
        Me.button3.TabIndex = 2
        Me.button3.Text = "ColumnSpan = 2" & Constants.vbLf & "RowSpan = 2"
        Me.button3.UseVisualStyleBackColor = True
        ' 
        ' button4
        ' 
        Me.button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button4.Location = New System.Drawing.Point(5, 53)
        Me.button4.Name = "button4"
        Me.tableLayoutPanel1.SetRowSpan(Me.button4, 2)
        Me.button4.Size = New System.Drawing.Size(103, 100)
        Me.button4.TabIndex = 3
        Me.button4.Text = "RowSpan = 2"
        Me.button4.UseVisualStyleBackColor = True
        ' 
        ' CellSpanning
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 273)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.Name = "CellSpanning"
        Me.Text = "CellSpanning"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private button1 As System.Windows.Forms.Button
    Private button2 As System.Windows.Forms.Button
    Private button3 As System.Windows.Forms.Button
    Private button4 As System.Windows.Forms.Button
    Private button5 As System.Windows.Forms.Button
    Private button6 As System.Windows.Forms.Button
    Private button7 As System.Windows.Forms.Button
    Private button8 As System.Windows.Forms.Button
    Private button9 As System.Windows.Forms.Button
    Private button10 As System.Windows.Forms.Button
End Class
