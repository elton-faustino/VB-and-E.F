Public Class Repositorio(Of T As Class)
    Private _Context As DB
    Sub New()
        _Context = New DB()
    End Sub
    Public Sub Add(TEntity As T)
        _Context.Set(Of T).Add(TEntity)
        _Context.SaveChanges()
    End Sub
    Public Overridable Function GetAll()
        Return _Context.Set(Of T)()
    End Function
    Public Overridable Function GetById(ByVal id)
        Return _Context.Set(Of T).Find(id)
    End Function
    Public Sub Update(TEntity As T)
        _Context.Entry(TEntity).State = Entity.EntityState.Modified
        _Context.SaveChanges()
    End Sub
    Public Sub Remove(TEntity As T)
        _Context.Set(Of T).Remove(TEntity)
        _Context.SaveChanges()
    End Sub
End Class
