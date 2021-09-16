namespace TesteColmeiaAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizacaoEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresas", "cep", c => c.String());
            AddColumn("dbo.Empresas", "logradouro", c => c.String());
            AddColumn("dbo.Empresas", "complemento", c => c.String());
            AddColumn("dbo.Empresas", "bairro", c => c.String());
            AddColumn("dbo.Empresas", "localidade", c => c.String());
            AddColumn("dbo.Empresas", "uf", c => c.String());
            AddColumn("dbo.Empresas", "ibge", c => c.String());
            AddColumn("dbo.Empresas", "gia", c => c.String());
            AddColumn("dbo.Empresas", "ddd", c => c.String());
            AddColumn("dbo.Empresas", "siafi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresas", "siafi");
            DropColumn("dbo.Empresas", "ddd");
            DropColumn("dbo.Empresas", "gia");
            DropColumn("dbo.Empresas", "ibge");
            DropColumn("dbo.Empresas", "uf");
            DropColumn("dbo.Empresas", "localidade");
            DropColumn("dbo.Empresas", "bairro");
            DropColumn("dbo.Empresas", "complemento");
            DropColumn("dbo.Empresas", "logradouro");
            DropColumn("dbo.Empresas", "cep");
        }
    }
}
