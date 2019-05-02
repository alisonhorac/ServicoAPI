using AHAS.WS.LOGIC.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AHAS.WS.INFRA.DATA.Context
{
    internal class EstadoSAPConfig : IEntityTypeConfiguration<EstadoSAP>
    {
        public void Configure(EntityTypeBuilder<EstadoSAP> builder)
        {
            builder.ToTable("TbEstadoSAP");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Sigla)
                .IsRequired()
                .HasColumnName("Sigla")
                .HasColumnType("VARCHAR(2)")
                .HasMaxLength(2);

            builder.Property(c => c.Estado)
                .IsRequired()
                .HasColumnName("Estado")
                .HasColumnType("VARCHAR(25)")
                .HasMaxLength(25);

            builder.Property(c => c.CodigoSAP)
                .IsRequired()
                .HasColumnName("CodigoSAP");

            builder.HasIndex(c => c.Sigla)
                .IsUnique(true);
        }
    }
}