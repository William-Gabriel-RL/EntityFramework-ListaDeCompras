using ListaDeCompras.Models;
using ListaDeCompras.Models.Maps;
using System.Data.Entity;

namespace ListaDeCompras.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Data Source=MAGNATI-10865-F;Initial Catalog=EntityListaCompras;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Supermercado> Supermercados { get; set; }
        public DbSet<ProdutoSupermercado> ProdutoSupermercado { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Lista> Listas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new SupermercadoMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ListaMap());
            modelBuilder.Configurations.Add(new ProdutoSupermercadoMap());
        }
    }
}
