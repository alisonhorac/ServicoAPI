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

            builder.Property(c => c.Sigla)
                .IsRequired()
                .HasColumnName("Sigla")
                .HasMaxLength(2)
                .HasColumnType("VARCHAR");

            builder.Property(c => c.Estado)
                .IsRequired()
                .HasColumnName("Estado")
                .HasMaxLength(25)
                .HasColumnType("VARCHAR");

            builder.Property(c => c.CodigoSAP)
                .IsRequired()
                .HasColumnName("CodigoSAP");

            builder.HasIndex(c => c.Sigla)
                .IsUnique(true);
        }
    }
}