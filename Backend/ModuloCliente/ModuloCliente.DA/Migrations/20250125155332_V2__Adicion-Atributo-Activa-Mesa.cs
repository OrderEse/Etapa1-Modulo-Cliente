using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuloCliente.DA.Migrations
{
    /// <inheritdoc />
    public partial class V2__AdicionAtributoActivaMesa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activa",
                table: "MESA",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activa",
                table: "MESA");
        }
    }
}
