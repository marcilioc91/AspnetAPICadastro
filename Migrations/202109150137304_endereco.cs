namespace TesteColmeiaAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class endereco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cep = c.String(),
                        logradouro = c.String(),
                        complemento = c.String(),
                        bairro = c.String(),
                        localidade = c.String(),
                        uf = c.String(),
                        ibge = c.String(),
                        gia = c.String(),
                        ddd = c.String(),
                        siafi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Enderecoes");
        }
    }
}
