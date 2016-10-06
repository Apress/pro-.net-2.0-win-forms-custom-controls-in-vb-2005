Imports Microsoft.VisualBasic
Imports System
Namespace MultithreadingClient
    Friend Partial Class AsyncTestQuery
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtTo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtFrom = New System.Windows.Forms.TextBox()
            Me.cmdFind = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' GroupBox1
            ' 
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtTo)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtFrom)
            Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox1.Location = New System.Drawing.Point(9, 11)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(223, 98)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Find Prime Numbers"
            ' 
            ' Label3
            ' 
            Me.Label3.Location = New System.Drawing.Point(16, 60)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(52, 20)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "To:"
            ' 
            ' txtTo
            ' 
            Me.txtTo.Location = New System.Drawing.Point(80, 56)
            Me.txtTo.Name = "txtTo"
            Me.txtTo.Size = New System.Drawing.Size(100, 21)
            Me.txtTo.TabIndex = 3
            Me.txtTo.Text = "500000"
            ' 
            ' Label2
            ' 
            Me.Label2.Location = New System.Drawing.Point(16, 32)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(52, 20)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "From:"
            ' 
            ' txtFrom
            ' 
            Me.txtFrom.Location = New System.Drawing.Point(80, 28)
            Me.txtFrom.Name = "txtFrom"
            Me.txtFrom.Size = New System.Drawing.Size(100, 21)
            Me.txtFrom.TabIndex = 0
            Me.txtFrom.Text = "1"
            ' 
            ' cmdFind
            ' 
            Me.cmdFind.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cmdFind.Location = New System.Drawing.Point(37, 135)
            Me.cmdFind.Name = "cmdFind"
            Me.cmdFind.Size = New System.Drawing.Size(80, 24)
            Me.cmdFind.TabIndex = 5
            Me.cmdFind.Text = "OK"

            ' 
            ' button1
            ' 
            Me.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Location = New System.Drawing.Point(124, 135)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(80, 24)
            Me.button1.TabIndex = 6
            Me.button1.Text = "Cancel"
            ' 
            ' AsyncTestQuery
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(252, 171)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.cmdFind)
            Me.Controls.Add(Me.GroupBox1)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "AsyncTestQuery"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Asynchronous Test"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Friend GroupBox1 As System.Windows.Forms.GroupBox
        Friend cmdFind As System.Windows.Forms.Button
        Friend Label3 As System.Windows.Forms.Label
        Friend txtTo As System.Windows.Forms.TextBox
        Friend Label2 As System.Windows.Forms.Label
        Friend txtFrom As System.Windows.Forms.TextBox
        Friend button1 As System.Windows.Forms.Button

    End Class
End Namespace

