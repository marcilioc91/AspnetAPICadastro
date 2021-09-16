namespace TesteColmeiaAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class excluindoEndereco : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Enderecoes");
        }
        
        public override void Down()
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
    }
}
