using Microsoft.EntityFrameworkCore.Migrations;

namespace Facturador_EFCore3.Migrations
{
    public partial class ProveedoresOrigen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Proveedores",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Proveedores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Proveedores");
        }
    }
}
