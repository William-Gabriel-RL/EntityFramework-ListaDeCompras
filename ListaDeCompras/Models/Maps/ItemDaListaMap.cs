using System.Data.Entity.ModelConfiguration;

namespace ListaDeCompras.Models.Maps
{
    internal class ItemDaListaMap : EntityTypeConfiguration<ItemDaLista>
    {
        public ItemDaListaMap()
        {
            ToTable("ItemDaLista");

            // Chave estrangeira Produto
            HasRequired(x => x.Lista).WithMany(l => l.ItemDaLista).HasForeignKey(l => l.IdLista).WillCascadeOnDelete(false);

            // Chave estrangeira Produto
            HasRequired(x => x.Produto).WithMany(l => l.ItemDaLista).HasForeignKey(l => l.CodigoProduto).WillCascadeOnDelete(false);

            // Chave estrangeira Supermercado
            HasOptional(x => x.Supermercado).WithMany(l => l.ItemDaLista).HasForeignKey(l => l.IdSupermercado).WillCascadeOnDelete(false);

            // Resto das Propriedades
            Property(x => x.Preco).HasColumnName("Preco").HasColumnType("float").IsRequired();
            Property(x => x.Quantidade).HasColumnName("Quantidade").HasColumnType("int").IsRequired();
            Property(x => x.Comprado).HasColumnName("Comprado").HasColumnType("bit").IsRequired();
        }
    }
}
