namespace TesteColmeiaAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empresa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cnpj = c.String(),
                        nome_fantasia = c.String(),
                        telefone = c.String(),
                        email = c.String(),
                        data_do_cadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresas");
        }
    }
}
