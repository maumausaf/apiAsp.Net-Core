using Microsoft.EntityFrameworkCore;
using MyWebApp.Entidades;

namespace MyWebApp
{
    public class MyWebAppContext : DbContext
    {
        public DbSet <Produto> Produtos { get; set; }
        public DbSet <Pedido> Pedidos { get; set; }
        public DbSet <ItemPedido> Itens { get; set; }

        public MyWebAppContext(DbContextOptions<MyWebAppContext> options):base(options) { }

        public MyWebAppContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(p => p.id);
            modelBuilder.Entity<Pedido>().HasKey(p => p.id);
            modelBuilder.Entity<ItemPedido>().HasKey(p => p.id);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }

    }
}
