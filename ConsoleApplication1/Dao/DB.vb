Imports System.Data.Entity
Imports System.Configuration
Imports System.Data.Entity.Infrastructure

Public Class DB
    Inherits DbContext
    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("testeDBConnectionString").ConnectionString)
    End Sub
    Private _Pessoa As DbSet(Of Pessoa)
    Public Property Pessoa() As DbSet(Of Pessoa)
        Get
            Return _Pessoa
        End Get
        Set(ByVal value As DbSet(Of Pessoa))
            _Pessoa = value
        End Set
    End Property

End Class
