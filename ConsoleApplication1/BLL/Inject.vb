Public Class Inject
    Inherits BLL
    Sub New(ByVal bll As BLL)
        _prop = bll
    End Sub
End Class
