Public Interface IBLL
    Sub Adicionar(Of T As Class)(TEntity As T)
    Function Listar(Of T As Class)()
    Function GetById(Of T As Class)(id As Integer)
    Sub update(Of T As Class)(TEntity As T)
    Sub Remove(Of T As Class)(TEntity As T)
End Interface
