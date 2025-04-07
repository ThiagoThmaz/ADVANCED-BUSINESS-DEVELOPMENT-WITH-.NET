using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RM557992.Domain.Entities;

namespace RM557992.Infrastructure.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIOS");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                   .HasColumnName("ID")
                   .IsRequired();

            builder.Property(u => u.Nome)
                   .HasColumnName("NOME")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(u => u.Email)
                   .HasColumnName("EMAIL")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasMany(u => u.Carros)
                   .WithOne()
                   .HasForeignKey("UsuarioId"); 
        }
    }
}
