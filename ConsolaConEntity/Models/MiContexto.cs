using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaConEntity.Models
{
    public class MiContexto : DbContext
    {
        public MiContexto(DbContextOptions<MiContexto> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Cosa> Cosas { get; set; }
    }

    ///// <summary>
    ///// Añadimos esta mierda para poderlo poner en el Add-Migration InitialCreate por consola
    ///// </summary>
    //public class MiContextoFactory : IDesignTimeDbContextFactory<MiContexto>
    //{
    //    public MiContexto CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<MiContexto>();
    //        optionsBuilder.UseSqlite("Data Source=blog.db");

    //        return new MiContexto(optionsBuilder.Options);
    //    }
    //}
}
