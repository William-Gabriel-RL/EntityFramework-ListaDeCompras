using System.Data.Entity.ModelConfiguration;

namespace ListaDeCompras.Models.Maps
{
    public class ListaMap : EntityTypeConfiguration<Lista>
    {
        public ListaMap()
        {
            ToTable("Listas");
            // Chave Primária
            HasKey(x => x.Id);

            // Chave Estrangeira
            HasRequired(x => x.Usuario)
                // Relação de um usuário para várias listas
                .WithMany(l => l.Listas)
                .HasForeignKey(l => l.IdUsuario)
                .WillCascadeOnDelete(false);


            Property(x => x.Data).HasColumnName("Data").IsRequired().HasColumnType("date");
            Property(x => x.EstaAtiva).HasColumnName("EstaAtiva").IsRequired().HasColumnType("bit");
            Property(x => x.Total).HasColumnName("Total").IsRequired().HasColumnType("float");
        }
    }
}
