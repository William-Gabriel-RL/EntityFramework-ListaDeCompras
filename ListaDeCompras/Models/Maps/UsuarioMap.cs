using System.Data.Entity.ModelConfiguration;

namespace ListaDeCompras.Models.Maps
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuarios");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasColumnName("Nome").IsRequired().HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.Email).HasColumnName("Email").IsRequired().HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.Senha).HasColumnName("Senha").IsRequired().HasColumnType("varchar").HasMaxLength(255);
        }
    }
}
