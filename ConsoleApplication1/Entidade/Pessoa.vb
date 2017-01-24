Public Class Pessoa
    Private _id As Integer
    Private nome As String
    Private cpf As String
    Public Property strCpf() As String
        Get
            Return cpf
        End Get
        Set(ByVal value As String)
            cpf = value
        End Set
    End Property

    Public Property strNome() As String
        Get
            Return nome
        End Get
        Set(ByVal value As String)
            nome = value
        End Set
    End Property
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

End Class
