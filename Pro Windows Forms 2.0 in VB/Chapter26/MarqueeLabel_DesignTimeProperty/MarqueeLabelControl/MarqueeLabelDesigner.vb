Imports System.Windows.Forms.Design
Imports System.ComponentModel
Imports System.ComponentModel.Design

Public Class MarqueeLabelDesigner
    Inherits ControlDesigner

    Private _allowDesignTimeScroll As Boolean
    Public Property AllowDesignTimeScroll() As Boolean
        Get
            Return _allowDesignTimeScroll
        End Get
        Set(ByVal value As Boolean)
            CType(Control, MarqueeLabel).Scroll(value)
            _allowDesignTimeScroll = value
        End Set
    End Property

    Protected Overrides Sub PreFilterProperties(ByVal properties As IDictionary)
        MyBase.PreFilterProperties(properties)

        ' Add a new property.
        properties("AllowDesignTimeScroll") = TypeDescriptor.CreateProperty(GetType(MarqueeLabelDesigner), "AllowDesignTimeScroll", GetType(Boolean), CategoryAttribute.Design, DesignOnlyAttribute.Yes)
    End Sub


    Private _verbs As New DesignerVerbCollection()

    Public Sub New()
        _verbs.Add(New DesignerVerb("Apply Funky Theme", New EventHandler(AddressOf OnVerbFunky)))
    End Sub

    Public Overrides ReadOnly Property Verbs() As DesignerVerbCollection
        Get
            Return _verbs
        End Get
    End Property

    Protected Sub OnVerbFunky(ByVal sender As Object, ByVal e As EventArgs)
        ' Get the associated control.
        Dim lbl As MarqueeLabel = CType(Control, MarqueeLabel)

        ' Get the IComponentChangeService.
        Dim host As IDesignerHost = CType(GetService(GetType(IDesignerHost)), IDesignerHost)
        Dim changeService As IComponentChangeService = CType(GetService(GetType(IComponentChangeService)), IComponentChangeService)

        ' Start the transaction.
        Dim tran As DesignerTransaction = host.CreateTransaction("Apply Funky Theme")

        changeService.OnComponentChanging(lbl, Nothing)
        lbl.ForeColor = Color.LimeGreen
        lbl.BackColor = Color.Yellow
        lbl.Font = New Font(lbl.Font.Name, 48, FontStyle.Bold)
        changeService.OnComponentChanged(lbl, Nothing, Nothing, Nothing)

        ' Commit the transaction.
        tran.Commit()
    End Sub

End Class

