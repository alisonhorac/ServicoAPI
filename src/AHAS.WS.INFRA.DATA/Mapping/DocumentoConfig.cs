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

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Sigla)
                .IsRequired()
                .HasColumnName("Sigla")
                .HasColumnType("VARCHAR(2)")
                .HasMaxLength(2);

            builder.Property(c => c.Denominacao)
                .IsRequired()
                .HasColumnName("Denominacao")
                .HasColumnType("VARCHAR(50)")
                .HasMaxLength(50);

            builder.HasIndex(c => c.Sigla)
                .IsUnique(true);
        }
    }
}