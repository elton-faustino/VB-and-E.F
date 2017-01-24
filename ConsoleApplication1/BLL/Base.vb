Public Class Base(Of T As Class)
    Inherits BLL

    Private _iBll As IBLL

    Sub New()
        _iBll = New Inject(_prop)
    End Sub

    Overloads Sub Adicionar(Of T As Class)(ByVal cl As T)
        _iBll.Adicionar(cl)
    End Sub

End Class
