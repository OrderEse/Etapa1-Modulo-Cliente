using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuloCliente.DA.Migrations
{
    /// <inheritdoc />
    public partial class V1__CreacionTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RESTAURANTE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagenLugar = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RESTAURANTE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MESA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestauranteId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MESA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MESA_RESTAURANTE_RestauranteId",
                        column: x => x.RestauranteId,
                        principalTable: "RESTAURANTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SOLICITUD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pedido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesaId = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOLICITUD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SOLICITUD_MESA_MesaId",
                        column: x => x.MesaId,
                        principalTable: "MESA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MESA_RestauranteId",
                table: "MESA",
                column: "RestauranteId");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITUD_MesaId",
                table: "SOLICITUD",
                column: "MesaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SOLICITUD");

            migrationBuilder.DropTable(
                name: "MESA");

            migrationBuilder.DropTable(
                name: "RESTAURANTE");
        }
    }
}
