Imports Microsoft.VisualBasic
Imports System

Partial Public Class HandMadeLayoutManager
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
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.tabControl1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Location = New System.Drawing.Point(12, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(332, 302)
        Me.tabControl1.TabIndex = 2
        ' 
        ' tabPage1
        ' 
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Size = New System.Drawing.Size(324, 276)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "TabPage1"
        ' 
        ' tabPage2
        ' 
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Size = New System.Drawing.Size(324, 276)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "TabPage2"
        Me.tabPage2.Visible = False
        ' 
        ' HandMadeLayoutManager
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 326)
        Me.Controls.Add(Me.tabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.Name = "HandMadeLayoutManager"
        Me.Text = "HandMadeLayoutManager"
        '            Me.Load += New System.EventHandler(Me.HandMadeLayoutManager_Load);
        Me.tabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend tabControl1 As System.Windows.Forms.TabControl
    Friend tabPage1 As System.Windows.Forms.TabPage
    Friend tabPage2 As System.Windows.Forms.TabPage
End Class
