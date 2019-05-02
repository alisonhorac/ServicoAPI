using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AHAS.WS.INFRA.DATA.Migrations
{
    public partial class InicialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbContaContabil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Conta = table.Column<long>(nullable: false),
                    Balanco = table.Column<string>(type: "VARCHAR(75)", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbContaContabil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbDocumento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sigla = table.Column<string>(type: "VARCHAR(2)", maxLength: 2, nullable: false),
                    Denominacao = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbDocumento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbEmpresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CNPJ = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    IE = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    Unidade = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    UF = table.Column<string>(type: "VARCHAR(2)", maxLength: 2, nullable: false),
                    Codigo = table.Column<string>(type: "VARCHAR(4)", maxLength: 4, nullable: false),
                    LocalNegocio = table.Column<string>(type: "VARCHAR(4)", maxLength: 4, nullable: false),
                    Centro = table.Column<string>(type: "VARCHAR(4)", maxLength: 4, nullable: false),
                    Sigla = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbEmpresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbEstadoSAP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoSAP = table.Column<long>(nullable: false),
                    Sigla = table.Column<string>(type: "VARCHAR(2)", maxLength: 2, nullable: false),
                    Estado = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbEstadoSAP", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbContaContabil_Conta",
                table: "TbContaContabil",
                column: "Conta",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbDocumento_Sigla",
                table: "TbDocumento",
                column: "Sigla",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbEmpresa_CNPJ",
                table: "TbEmpresa",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbEmpresa_IE",
                table: "TbEmpresa",
                column: "IE",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbEstadoSAP_Sigla",
                table: "TbEstadoSAP",
                column: "Sigla",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbContaContabil");

            migrationBuilder.DropTable(
                name: "TbDocumento");

            migrationBuilder.DropTable(
                name: "TbEmpresa");

            migrationBuilder.DropTable(
                name: "TbEstadoSAP");
        }
    }
}
