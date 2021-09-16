using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using TesteColmeiaAPI.Models;

namespace TesteColmeiaAPI
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public DbSet<Empresa> empresas { get; set; } // ADICIONANDO O OBJETO PARA A CRIAÇÃO DA TABELA DO DB PELO CODEFIRST
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
