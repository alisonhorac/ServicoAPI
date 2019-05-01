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

            builder.Property(c => c.CNPJ)
                .IsRequired()
                .HasColumnName("CNPJ")
                .HasMaxLength(14)
                .HasColumnType("VARCHAR");

            builder.Property(c => c.IE)
                .IsRequired()
                .HasColumnName("IE")
                .HasMaxLength(14)
                .HasColumnType("VARCHAR");

            builder.Property(c => c.Centro)
                .IsRequired()
                .HasColumnName("Centro")
                .HasMaxLength(4)
                .HasColumnType("VARCHAR");

            builder.Property(c => c.Codigo)
                .IsRequired()
                .HasColumnName("Codigo")
                .HasMaxLength(4)
                .HasColumnType("VARCHAR");

            builder.Property(c => c.LocalNegocio)
                .IsRequired()
                .HasColumnName("LocalNegocio")
                .HasMaxLength(4)
                .HasColumnType("VARCHAR");

            builder.Property(c => c.UF)
                .IsRequired()
                .HasColumnName("UF")
                .HasMaxLength(2)
                .HasColumnType("VARCHAR");

            builder.Property(c => c.Unidade)
                .IsRequired()
                .HasColumnName("Unidade")
                .HasMaxLength(100)
                .HasColumnType("VARCHAR");

            builder.Property(c => c.Sigla)
                .IsRequired()
                .HasColumnName("Sigla")
                .HasMaxLength(15)
                .HasColumnType("VARCHAR");

            builder.HasIndex(c => c.CNPJ)
                .IsUnique(true);
            builder.HasIndex(c => c.IE)
                .IsUnique(true);
        }
    }
}