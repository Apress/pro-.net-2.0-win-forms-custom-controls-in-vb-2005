Imports Microsoft.VisualBasic
Imports System

Partial Public Class TableLayoutTest
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
        Me.button8 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' button8
        ' 
        Me.button8.Dock = System.Windows.Forms.DockStyle.Left
        Me.button8.Location = New System.Drawing.Point(158, 191)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(75, 55)
        Me.button8.TabIndex = 7
        Me.button8.Text = "Left Dock"
        Me.button8.UseVisualStyleBackColor = True
        ' 
        ' button7
        ' 
        Me.button7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.button7.Location = New System.Drawing.Point(5, 223)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(145, 23)
        Me.button7.TabIndex = 6
        Me.button7.Text = "Bottom Dock"
        Me.button7.UseVisualStyleBackColor = True
        ' 
        ' button6
        ' 
        Me.button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button6.Location = New System.Drawing.Point(158, 129)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(145, 54)
        Me.button6.TabIndex = 5
        Me.button6.Text = "Fill Dock"
        Me.button6.UseVisualStyleBackColor = True
        ' 
        ' button5
        ' 
        Me.button5.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.button5.Location = New System.Drawing.Point(5, 144)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(145, 23)
        Me.button5.TabIndex = 4
        Me.button5.Text = "Left-Right"
        Me.button5.UseVisualStyleBackColor = True
        ' 
        ' button4
        ' 
        Me.button4.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.button4.Location = New System.Drawing.Point(158, 67)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(145, 54)
        Me.button4.TabIndex = 3
        Me.button4.Text = "All Sides"
        Me.button4.UseVisualStyleBackColor = True
        ' 
        ' button3
        ' 
        Me.button3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.button3.Location = New System.Drawing.Point(75, 98)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 23)
        Me.button3.TabIndex = 2
        Me.button3.Text = "Bottom-Right"
        Me.button3.UseVisualStyleBackColor = True
        ' 
        ' button2
        ' 
        Me.button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button2.Location = New System.Drawing.Point(193, 20)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "No Anchor"
        Me.button2.UseVisualStyleBackColor = True
        ' 
        ' button1
        ' 
        Me.button1.Location = New System.Drawing.Point(5, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Top-Left"
        Me.button1.UseVisualStyleBackColor = True
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
        Me.tableLayoutPanel1.Controls.Add(Me.button1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.button2, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.button3, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button4, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button5, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.button6, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.button7, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.button8, 1, 3)
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 4
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(308, 251)
        Me.tableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutTest
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 275)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.Name = "TableLayoutTest"
        Me.Text = "TableLayoutTest"
        '            Me.Load += New System.EventHandler(Me.TableLayoutTest_Load);
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private button8 As System.Windows.Forms.Button
    Private button7 As System.Windows.Forms.Button
    Private button6 As System.Windows.Forms.Button
    Private button5 As System.Windows.Forms.Button
    Private button4 As System.Windows.Forms.Button
    Private button3 As System.Windows.Forms.Button
    Private button2 As System.Windows.Forms.Button
    Private button1 As System.Windows.Forms.Button
    Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel



End Class
