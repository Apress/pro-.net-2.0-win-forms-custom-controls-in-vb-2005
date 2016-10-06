Imports Microsoft.VisualBasic
Imports System
Namespace MultithreadingClient
    Friend Partial Class AsyncTestResult
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
            Me.txtResults = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
' 
' txtResults
' 
            Me.txtResults.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.txtResults.AutoSize = False
            Me.txtResults.Location = New System.Drawing.Point(13, 13)
            Me.txtResults.Multiline = True
            Me.txtResults.Name = "txtResults"
            Me.txtResults.ReadOnly = True
            Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtResults.Size = New System.Drawing.Size(450, 264)
            Me.txtResults.TabIndex = 8
' 
' AsyncTestResult
' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(475, 289)
            Me.Controls.Add(Me.txtResults)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.Name = "AsyncTestResult"
            Me.Text = "Search Result"
'            Me.Load += New System.EventHandler(Me.AsyncTestResult_Load);
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Friend txtResults As System.Windows.Forms.TextBox

    End Class
End Namespace