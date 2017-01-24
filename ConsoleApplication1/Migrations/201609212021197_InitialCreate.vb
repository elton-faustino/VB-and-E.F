Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Pessoas",
                Function(c) New With
                    {
                        .ID = c.Int(nullable := False, identity := True),
                        .strCpf = c.String(),
                        .strNome = c.String()
                    }) _
                .PrimaryKey(Function(t) t.ID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Pessoas")
        End Sub
    End Class
End Namespace
