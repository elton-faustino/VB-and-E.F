Module Module1

    Sub Main()
        Dim p As New Pessoa
        'Console.WriteLine("ola")
        'Console.ReadKey()
        'Soma(5, 10)
        PreencherNome("João", "455646464")
        Listar()
        'Atuliza(p)
        'GetById(1)
        'Remove(p)
    End Sub
    'Private pessoaDB As BLL
    Sub New()
        'pessoaDB = New BLL()
    End Sub
    Sub Soma(numero1 As Integer, numero2 As Integer)
        Dim resultado As Integer

        resultado = numero1 + numero2

        Console.WriteLine("o resultado da soma é " + resultado.ToString())

        Console.ReadKey()

    End Sub
    Sub PreencherNome(Nome As String, Cpf As String)
        Dim pessoa = New Pessoa()

        Dim base As New Base(Of Pessoa)


        pessoa.strNome = Nome
        pessoa.strCpf = Cpf
        'pessoaDB.Adicionar(pessoa)
        base.Adicionar(pessoa)
        Console.WriteLine("Nome " + pessoa.strNome + " cpf " + pessoa.strCpf)
        Console.ReadKey()
    End Sub
    Sub Listar()
        Dim pessoa As IEnumerable(Of Pessoa)
        'pessoa = pessoaDB.Listar()
        For Each p In pessoa
            Console.WriteLine(p.strNome + " ID " + p.ID.ToString())
        Next
        Console.ReadKey()
    End Sub
    Sub GetById(Id As Integer)
        Dim p As New Pessoa
        'p = pessoaDB.GetById(Id)
        Console.WriteLine("ID:" + p.ID.ToString() + " Nome:" + p.strNome.ToString() + " cpf:" + p.strCpf.ToString())
        Console.ReadKey()
    End Sub
    Sub Atuliza(p As Pessoa)
        p.ID = 1
        'p = pessoaDB.GetById(p.ID)
        p.strCpf = "357313398-30"
        'pessoaDB.update(p)
        Console.WriteLine("ID:" + p.ID.ToString() + " Nome:" + p.strNome.ToString() + " cpf:" + p.strCpf.ToString())
        Console.ReadKey()
    End Sub
    Sub Remove(p As Pessoa)
        p.ID = 5
        'p = pessoaDB.GetById(p.ID)
        'pessoaDB.Remove(p)
        Console.WriteLine("Excluido com sucesso")
        Console.ReadKey()
    End Sub

End Module
