using System.Data.Entity.ModelConfiguration;

namespace ListaDeCompras.Models.Maps
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("Produtos");
            HasKey(x => x.CodigoDeBarras);

            Property(x => x.Nome).HasColumnName("Nome").IsRequired().HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.Descricao).HasColumnName("Descricao").IsRequired().HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.Foto).HasColumnName("Foto").IsOptional().HasColumnType("varbinary");
        }
    }
}
