using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Facturador_EFCore3.Migrations
{
    public partial class Inicial_Facturador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 25, nullable: false),
                    Documento = table.Column<string>(maxLength: 15, nullable: false),
                    Direccion = table.Column<string>(maxLength: 50, nullable: true),
                    Correo = table.Column<string>(maxLength: 100, nullable: false),
                    Telefonos = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 25, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(9,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FchEmision = table.Column<DateTime>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    FacturaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facturas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacturaDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacturaId = table.Column<int>(nullable: false),
                    ProductoId = table.Column<int>(nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false, computedColumnSql: "[Cantidad] * [Precio]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturaDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacturaDetalle_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacturaDetalle_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Correo", "Direccion", "Documento", "Nombre", "Telefonos" },
                values: new object[,]
                {
                    { 1, "juan.rulfo@efc3.com", "Calle 1 Cra 1", "11111", "Juan Rulfo", "3011111111" },
                    { 2, "pedro.paramo@efc3.com", "Calle 2 Cra 2", "22222", "Pedro Páramo", "3022222222" },
                    { 3, "rosario.tijeras@efc3.com", "Calle 3 Cra 3", "33333", "Rosario Tijeras", "3033333333" },
                    { 4, "alicia.adorada@efc3.com", "Calle 4 Cra 4", "44444", "Alicia Adoorada", "3044444444" },
                    { 5, "juancho.polo@efc3.com", "Calle 5 Cra 5", "55555", "Juancho Polo", "3055555555" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Descripcion", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Para iluminar tu vida", "Lámpara", 40.99m },
                    { 2, "Para esparcimiento", "Tableta Inteligente", 180.99m },
                    { 3, "Para trabajo", "Laptop", 250m },
                    { 4, "Para trabajar comodamente", "Mouse Microsoft", 98.89m },
                    { 5, "Para tus copias de respaldo", "Disco Externo", 75.50m },
                    { 6, "Para comunicaciones en línea", "Diadema con microfono", 15.99m },
                    { 7, "Para imprimir los trabajos", "Impresora laser", 65.99m },
                    { 8, "Para digitalizar los documentos", "Escanner", 50.45m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacturaDetalle_FacturaId",
                table: "FacturaDetalle",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaDetalle_ProductoId",
                table: "FacturaDetalle",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ClienteId",
                table: "Facturas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_FacturaId",
                table: "Facturas",
                column: "FacturaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacturaDetalle");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
