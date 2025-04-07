    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RM557992.Domain.Entities;

    namespace RM557992.Infrastructure.Mappings
    {
        public class CarroMap : IEntityTypeConfiguration<Carro>
        {
            public void Configure(EntityTypeBuilder<Carro> builder)
            {
                builder.ToTable("CARROS");

                builder.HasKey(c => c.Id);

                builder.Property(c => c.Id)
                       .HasColumnName("ID")
                       .IsRequired();

                builder.Property(c => c.Placa)
                       .HasColumnName("PLACA")
                       .HasMaxLength(7)
                       .IsRequired();

                builder.Property(c => c.Modelo)
                       .HasColumnName("MODELO")
                       .IsRequired();

                builder.Property(c => c.Ano)
                       .HasColumnName("ANO")
                       .IsRequired();
            }
        }
    }


