using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pav.TpFinal.Infraestructura.Datos.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Domicilio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PorcentajePesoCarne = table.Column<double>(type: "float", nullable: false),
                    TipoAlimentacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Latitud = table.Column<double>(type: "float(10)", precision: 10, scale: 8, nullable: false),
                    Longitud = table.Column<double>(type: "float(10)", precision: 10, scale: 8, nullable: false),
                    Limite = table.Column<int>(type: "int", nullable: false),
                    TipoAlimentacion = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sectores_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Mamiferos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<double>(type: "float(6)", precision: 6, scale: 2, nullable: false),
                    TipoAlimentacion = table.Column<int>(type: "int", nullable: false),
                    EspecieId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrigenId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ValorFijo = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mamiferos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mamiferos_Especies_EspecieId",
                        column: x => x.EspecieId,
                        principalTable: "Especies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Mamiferos_Paises_OrigenId",
                        column: x => x.OrigenId,
                        principalTable: "Paises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Mamiferos_Sectores_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectores",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "Documento", "Domicilio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("5e28d916-2da9-47e4-ae92-575bf0f39dca"), "87654321", "Tucumán", "María" },
                    { new Guid("b7ea7d14-815b-4456-85c4-38797129c9c9"), "12345678", "Tucumán", "Luis" }
                });

            migrationBuilder.InsertData(
                table: "Especies",
                columns: new[] { "Id", "Codigo", "Nombre", "PorcentajePesoCarne", "TipoAlimentacion" },
                values: new object[,]
                {
                    { new Guid("19e3ed45-e594-41b3-8bae-fa0c103dec49"), 2, "Jirafa", 0.0, 1 },
                    { new Guid("63d662d8-146d-4008-b39c-6e5c1cd69a20"), 1, "León", 0.69999999999999996, 0 },
                    { new Guid("8b31d8da-2739-470d-853b-252bedf06259"), 3, "Tigre", 0.5, 0 },
                    { new Guid("afc60bb5-a80f-482c-ba26-c93403030160"), 4, "Rinoceronte", 0.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("054e3ed8-5dbe-4056-9ff3-baddf3c550b0"), "Australia" },
                    { new Guid("6c64f000-406b-43a1-8359-8195a6a006e3"), "Singapur" },
                    { new Guid("82740fb1-fb05-446f-8e50-ed5aa38bb824"), "Sudáfrica" },
                    { new Guid("f5ab1981-6085-4a2d-b08b-82d32ed7daf2"), "Canadá" }
                });

            migrationBuilder.InsertData(
                table: "Sectores",
                columns: new[] { "Id", "EmpleadoId", "Latitud", "Limite", "Longitud", "Numero", "TipoAlimentacion" },
                values: new object[,]
                {
                    { new Guid("06edc761-d2d7-4200-aa31-67015b41b0e6"), new Guid("5e28d916-2da9-47e4-ae92-575bf0f39dca"), -26.257249999999999, 10, -65.523514000000006, 5, 0 },
                    { new Guid("2a8a5405-fda0-4652-94af-2bf804fb8c6e"), new Guid("b7ea7d14-815b-4456-85c4-38797129c9c9"), -26.252358999999998, 10, -65.521511000000004, 2, 0 },
                    { new Guid("7525a7f1-d3d3-432c-a80c-b2cebc403962"), new Guid("b7ea7d14-815b-4456-85c4-38797129c9c9"), -26.250724000000002, 10, -65.522827000000007, 1, 1 },
                    { new Guid("a33c0338-44ba-47ca-82aa-96ac66498d0d"), new Guid("5e28d916-2da9-47e4-ae92-575bf0f39dca"), -26.257249999999999, 10, -65.523514000000006, 4, 0 },
                    { new Guid("e1baf61a-27f8-45e4-97ae-9d7cb232a97a"), new Guid("5e28d916-2da9-47e4-ae92-575bf0f39dca"), -26.254660999999999, 10, -65.522726000000006, 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mamiferos_EspecieId",
                table: "Mamiferos",
                column: "EspecieId");

            migrationBuilder.CreateIndex(
                name: "IX_Mamiferos_OrigenId",
                table: "Mamiferos",
                column: "OrigenId");

            migrationBuilder.CreateIndex(
                name: "IX_Mamiferos_SectorId",
                table: "Mamiferos",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Sectores_EmpleadoId",
                table: "Sectores",
                column: "EmpleadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mamiferos");

            migrationBuilder.DropTable(
                name: "Especies");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Sectores");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
