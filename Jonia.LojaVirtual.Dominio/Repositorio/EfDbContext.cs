using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jonia.LojaVirtual.Dominio.Entidade;

namespace Jonia.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext:DbContext
    {
        public DbSet<Produto> Produtos { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
