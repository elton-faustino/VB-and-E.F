Public MustInherit Class BLL
    Implements IBLL
    Private _bll As BLL
    Public Property _prop() As BLL
        Get
            Return _bll
        End Get
        Set(ByVal value As BLL)
            _bll = value
        End Set
    End Property
    Public Sub Adicionar(Of T As Class)(TEntity As T) Implements IBLL.Adicionar
        Dim rs As New Repositorio(Of T)
        rs.Add(TEntity)
    End Sub
    Public Function GetById(Of T As Class)(id As Integer) As Object Implements IBLL.GetById

    End Function
    Public Function Listar(Of T As Class)() As Object Implements IBLL.Listar

    End Function
    Public Sub Remove(Of T As Class)(TEntity As T) Implements IBLL.Remove

    End Sub
    Public Sub update(Of T As Class)(TEntity As T) Implements IBLL.update

    End Sub
End Class

