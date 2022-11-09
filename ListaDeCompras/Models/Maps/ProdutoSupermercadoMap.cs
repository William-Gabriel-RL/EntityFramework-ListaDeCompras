using System.Data.Entity.ModelConfiguration;

namespace ListaDeCompras.Models.Maps
{
    public class ProdutoSupermercadoMap : EntityTypeConfiguration<ProdutoSupermercado>
    {
        public ProdutoSupermercadoMap()
        {
            ToTable("ProdutoSupermercado");
            HasKey(x => x.Id);
            // Chave estrangeira Produto
            HasRequired(x => x.Produto).WithMany(l => l.ProdutoSupermercado).HasForeignKey(l => l.CodigoProduto).WillCascadeOnDelete(false);

            // Chave estrangeira Supermercado
            HasRequired(x => x.Supermercado).WithMany(l => l.ProdutoSupermercado).HasForeignKey(l => l.IdSupermercado).WillCascadeOnDelete(false);

            Property(x => x.Preco).HasColumnName("Preco").IsRequired().HasColumnType("float");
        }
    }
}
