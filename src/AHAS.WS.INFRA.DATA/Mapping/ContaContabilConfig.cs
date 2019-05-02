using AHAS.WS.LOGIC.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AHAS.WS.INFRA.DATA.Context
{
    internal class ContaContabilConfig : IEntityTypeConfiguration<ContaContabil>
    {
        public void Configure(EntityTypeBuilder<ContaContabil> builder)
        {
            builder.ToTable("TbContaContabil");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Conta)
                .IsRequired()
                .HasColumnName("Conta");

            builder.Property(c => c.Balanco)
                .IsRequired()
                .HasColumnName("Balanco")
                .HasColumnType("VARCHAR(75)")
                .HasMaxLength(75);

            builder.HasIndex(c => c.Conta)
                .IsUnique(true);
        }
    }
}