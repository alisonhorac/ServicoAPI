using AHAS.WS.LOGIC.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AHAS.WS.INFRA.DATA.Context
{
    internal class EmpresaConfig : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("TbEmpresa");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.CNPJ)
                .IsRequired()
                .HasColumnName("CNPJ")
                .HasColumnType("VARCHAR(14)")
                .HasMaxLength(14);

            builder.Property(c => c.IE)
                .IsRequired()
                .HasColumnName("IE")
                .HasColumnType("VARCHAR(14)")
                .HasMaxLength(14);

            builder.Property(c => c.Centro)
                .IsRequired()
                .HasColumnName("Centro")
                .HasColumnType("VARCHAR(4)")
                .HasMaxLength(4);

            builder.Property(c => c.Codigo)
                .IsRequired()
                .HasColumnName("Codigo")
                .HasColumnType("VARCHAR(4)")
                .HasMaxLength(4);

            builder.Property(c => c.LocalNegocio)
                .IsRequired()
                .HasColumnName("LocalNegocio")
                .HasColumnType("VARCHAR(4)")
                .HasMaxLength(4);

            builder.Property(c => c.UF)
                .IsRequired()
                .HasColumnName("UF")
                .HasColumnType("VARCHAR(2)")
                .HasMaxLength(2);

            builder.Property(c => c.Unidade)
                .IsRequired()
                .HasColumnName("Unidade")
                .HasColumnType("VARCHAR(100)")
                .HasMaxLength(100);

            builder.Property(c => c.Sigla)
                .IsRequired()
                .HasColumnName("Sigla")
                .HasColumnType("VARCHAR(15)")
                .HasMaxLength(15);

            builder.HasIndex(c => c.CNPJ)
                .IsUnique(true);
            builder.HasIndex(c => c.IE)
                .IsUnique(true);
        }
    }
}