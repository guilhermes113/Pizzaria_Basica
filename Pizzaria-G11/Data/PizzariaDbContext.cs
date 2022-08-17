using Microsoft.EntityFrameworkCore;
using PizzariAtv.Models;

namespace PizzariAtv.Data
{
    public class PizzariaDbContext : DbContext
    {
        public PizzariaDbContext(DbContextOptions<PizzariaDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzasSabores>().HasKey(ps => new 
            {
                ps.PizzaId,
                ps.SaborId
            });

        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Sabor> Sabores { get; set; }
        public DbSet<Tamanho> Tamanhos { get; set; }
        public DbSet<PizzasSabores> PizzasSabores { get; set; }
        
    }
}
