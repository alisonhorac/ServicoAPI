using AHAS.WS.LOGIC.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AHAS.WS.INFRA.DATA.Context
{
    internal class DocumentoConfig : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            builder.ToTable("TbDocumento");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Sigla)
                .IsRequired()
                .HasColumnName("Sigla")
                .HasMaxLength(2)
                .HasColumnType("VARCHAR");

            builder.Property(c => c.Denominacao)
                .IsRequired()
                .HasColumnName("Denominacao")
                .HasMaxLength(50)
                .HasColumnType("VARCHAR");

            builder.HasIndex(c => c.Sigla)
                .IsUnique(true);
        }
    }
}