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

        public DbSet<Endereco> enderecos { get; set; }

        public DbSet<Empresa> empresas { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
