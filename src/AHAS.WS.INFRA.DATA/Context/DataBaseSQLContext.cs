using AHAS.WS.LOGIC.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

//Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 2.1.8
//Install-Package Microsoft.EntityFrameworkCore -Version 2.1.8
//Install-Package Microsoft.EntityFrameworkCore.Tools -Version 2.1.8
//update-database
//dotnet ef migrations add InicialMigration
//update-database
namespace AHAS.WS.INFRA.DATA.Context
{
    public class DataBaseSQLContext : DbContext
    {
        public DbSet<ContaContabil> ContasContabeis { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EstadoSAP> Estados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=DBWebAPI;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContaContabil>(new ContaContabilConfig().Configure);
            modelBuilder.Entity<Documento>(new DocumentoConfig().Configure);
            modelBuilder.Entity<Empresa>(new EmpresaConfig().Configure);
            modelBuilder.Entity<EstadoSAP>(new EstadoSAPConfig().Configure);

            base.OnModelCreating(modelBuilder);
        }
    }
}
