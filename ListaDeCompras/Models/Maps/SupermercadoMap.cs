using System.Data.Entity.ModelConfiguration;

namespace ListaDeCompras.Models.Maps
{
    public class SupermercadoMap : EntityTypeConfiguration<Supermercado>
    {
        public SupermercadoMap()
        {
            ToTable("Supermercados");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasColumnName("Nome").IsRequired().HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.Logradouro).HasColumnName("Logradouro").IsRequired().HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.Bairro).HasColumnName("Bairro").IsRequired().HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.Cidade).HasColumnName("Cidade").IsRequired().HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.Estado).HasColumnName("Estado").IsRequired().HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.CEP).HasColumnName("CEP").IsRequired().HasColumnType("varchar").HasMaxLength(9);
        }
    }
}
