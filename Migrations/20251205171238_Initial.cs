using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealershipV5.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Ano = table.Column<int>(type: "INTEGER", nullable: false),
                    Potencia = table.Column<int>(type: "INTEGER", nullable: false),
                    Km = table.Column<float>(type: "REAL", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Valor = table.Column<float>(type: "REAL", nullable: false),
                    Cor = table.Column<string>(type: "TEXT", nullable: false),
                    Cambio = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
