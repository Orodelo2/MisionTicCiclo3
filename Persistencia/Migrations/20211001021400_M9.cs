using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class M9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cantidad_de_empleados",
                table: "Personas",
                newName: "CantidadEmpleados");

            migrationBuilder.RenameColumn(
                name: "Nit",
                table: "Empresas",
                newName: "NIT");

            migrationBuilder.RenameColumn(
                name: "CIF",
                table: "Empresas",
                newName: "Nombre");

            migrationBuilder.AlterColumn<int>(
                name: "NIT",
                table: "Empresas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CantidadEmpleados",
                table: "Personas",
                newName: "Cantidad_de_empleados");

            migrationBuilder.RenameColumn(
                name: "NIT",
                table: "Empresas",
                newName: "Nit");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Empresas",
                newName: "CIF");

            migrationBuilder.AlterColumn<string>(
                name: "Nit",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
