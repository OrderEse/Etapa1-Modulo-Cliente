using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuloCliente.DA.Migrations
{
    /// <inheritdoc />
    public partial class V3__AdicionAtributoMesaEliminado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "MESA",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "MESA");
        }
    }
}
