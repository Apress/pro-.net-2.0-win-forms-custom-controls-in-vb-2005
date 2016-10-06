Imports Microsoft.VisualBasic
Imports System

Partial Public Class LocalizableDialog
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
        Me.button3 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.optLong = New System.Windows.Forms.RadioButton()
        Me.optShort = New System.Windows.Forms.RadioButton()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.AutoSize = True
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
        Me.tableLayoutPanel1.Controls.Add(Me.button3, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.button2, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.button1, 0, 0)
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(230, 12)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0F))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(100, 90)
        Me.tableLayoutPanel1.TabIndex = 0
        ' 
        ' button1
        ' 
        Me.button1.AutoSize = True
        Me.button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button1.Location = New System.Drawing.Point(3, 3)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(94, 24)
        Me.button1.TabIndex = 0
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = True
        ' 
        ' button2
        ' 
        Me.button2.AutoSize = True
        Me.button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button2.Location = New System.Drawing.Point(3, 33)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(94, 24)
        Me.button2.TabIndex = 1
        Me.button2.Text = "button2"
        Me.button2.UseVisualStyleBackColor = True
        ' 
        ' button3
        ' 
        Me.button3.AutoSize = True
        Me.button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button3.Location = New System.Drawing.Point(3, 63)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(94, 24)
        Me.button3.TabIndex = 2
        Me.button3.Text = "button3"
        Me.button3.UseVisualStyleBackColor = True
        ' 
        ' textBox1
        ' 
        Me.textBox1.Location = New System.Drawing.Point(12, 12)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(202, 242)
        Me.textBox1.TabIndex = 1
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.optShort)
        Me.groupBox1.Controls.Add(Me.optLong)
        Me.groupBox1.Location = New System.Drawing.Point(230, 115)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(100, 100)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Choose Text"
        ' 
        ' optLong
        ' 
        Me.optLong.AutoSize = True
        Me.optLong.Location = New System.Drawing.Point(15, 29)
        Me.optLong.Name = "optLong"
        Me.optLong.Size = New System.Drawing.Size(49, 17)
        Me.optLong.TabIndex = 3
        Me.optLong.Text = "Long"
        Me.optLong.UseVisualStyleBackColor = True
        '            Me.optLong.CheckedChanged += New System.EventHandler(Me.optLong_CheckedChanged);
        ' 
        ' optShort
        ' 
        Me.optShort.AutoSize = True
        Me.optShort.Checked = True
        Me.optShort.Location = New System.Drawing.Point(15, 52)
        Me.optShort.Name = "optShort"
        Me.optShort.Size = New System.Drawing.Size(50, 17)
        Me.optShort.TabIndex = 4
        Me.optShort.TabStop = True
        Me.optShort.Text = "Short"
        Me.optShort.UseVisualStyleBackColor = True
        '            Me.optShort.CheckedChanged += New System.EventHandler(Me.optShort_CheckedChanged);
        ' 
        ' LocalizableDialog
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(346, 266)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "LocalizableDialog"
        Me.Text = "LocalizableDialog"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private button3 As System.Windows.Forms.Button
    Private button2 As System.Windows.Forms.Button
    Private button1 As System.Windows.Forms.Button
    Private textBox1 As System.Windows.Forms.TextBox
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents optShort As System.Windows.Forms.RadioButton
    Private WithEvents optLong As System.Windows.Forms.RadioButton
End Class
