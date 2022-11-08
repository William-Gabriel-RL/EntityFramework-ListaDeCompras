using System.Data.Entity.ModelConfiguration;

namespace ListaDeCompras.Models.Maps
{
    public class ListaMap : EntityTypeConfiguration<Lista>
    {
        public ListaMap()
        {
            ToTable("Listas");
            HasKey(x => x.Id);
            Property(x => x.Data).HasColumnName("Data").IsRequired().HasColumnType("date");
            Property(x => x.EstaAtiva).HasColumnName("EstaAtiva").IsRequired().HasColumnType("bit");
            Property(x => x.Total).HasColumnName("Total").IsRequired().HasColumnType("float");
            Property(x => x.IdUsuario).HasColumnName("IdUsuario").IsRequired().HasColumnType("int");
        }
    }
}
