Imports Microsoft.VisualBasic
Imports System

Partial Public Class FormsFromFile
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
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.pnlScroll = New System.Windows.Forms.Panel()
        Me.pnlForm = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' openFileDialog
        ' 
        Me.openFileDialog.Filter = "Form Files|*.frm"
        ' 
        ' pnlScroll
        ' 
        Me.pnlScroll.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.pnlScroll.AutoScroll = True
        Me.pnlScroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlScroll.Location = New System.Drawing.Point(0, 0)
        Me.pnlScroll.Name = "pnlScroll"
        Me.pnlScroll.Size = New System.Drawing.Size(200, 100)
        Me.pnlScroll.TabIndex = 0
        ' 
        ' pnlForm
        ' 
        Me.pnlForm.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.pnlForm.AutoSize = True
        Me.pnlForm.ColumnCount = 1
        Me.pnlForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
        Me.pnlForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.RowCount = 1
        Me.pnlForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
        Me.pnlForm.Size = New System.Drawing.Size(200, 100)
        Me.pnlForm.TabIndex = 0
        ' 
        ' cmdBrowse
        ' 
        Me.cmdBrowse.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.cmdBrowse.Location = New System.Drawing.Point(445, 13)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(98, 23)
        Me.cmdBrowse.TabIndex = 5
        Me.cmdBrowse.Text = "Browse..."
        '            Me.cmdBrowse.Click += New System.EventHandler(Me.cmdBrowse_Click);
        ' 
        ' txtFileName
        ' 
        Me.txtFileName.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.txtFileName.Location = New System.Drawing.Point(15, 13)
        Me.txtFileName.Multiline = True
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(423, 23)
        Me.txtFileName.TabIndex = 4
        Me.txtFileName.WordWrap = False
        ' 
        ' panel1
        ' 
        Me.panel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.panel1.AutoScroll = True
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.tableLayoutPanel1)
        Me.panel1.Location = New System.Drawing.Point(15, 42)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.panel1.Size = New System.Drawing.Size(528, 304)
        Me.panel1.TabIndex = 6
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.tableLayoutPanel1.AutoSize = True
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(511, 204)
        Me.tableLayoutPanel1.TabIndex = 0
        ' 
        ' FormsFromFile
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 369)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.Name = "FormsFromFile"
        Me.Text = "FormsFromFile"
        '            Me.Load += New System.EventHandler(Me.FormsFromFile_Load);
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private openFileDialog As System.Windows.Forms.OpenFileDialog
    Private pnlScroll As System.Windows.Forms.Panel
    Private pnlForm As System.Windows.Forms.TableLayoutPanel
    Private WithEvents cmdBrowse As System.Windows.Forms.Button
    Private txtFileName As System.Windows.Forms.TextBox
    Private panel1 As System.Windows.Forms.Panel
    Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
