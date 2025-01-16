using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Numero_Identificacion = table.Column<int>(type: "int", nullable: false),
                    Primer_Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Segundo_Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Primer_Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Segundo_Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fecha_nacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Valor_Estimado_Seguro = table.Column<decimal>(type: "money", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Numero_Identificacion);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
