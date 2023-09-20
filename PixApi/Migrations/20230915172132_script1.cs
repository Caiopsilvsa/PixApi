using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixApi.Migrations
{
    /// <inheritdoc />
    public partial class script1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pix",
                columns: table => new
                {
                    pixId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pix", x => x.pixId);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    clienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    saldo = table.Column<int>(type: "int", nullable: false),
                    pixId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.clienteId);
                    table.ForeignKey(
                        name: "FK_clientes_pix_pixId",
                        column: x => x.pixId,
                        principalTable: "pix",
                        principalColumn: "pixId");
                });

            migrationBuilder.CreateTable(
                name: "transasoes",
                columns: table => new
                {
                    transacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pixRecebedorpixId = table.Column<int>(type: "int", nullable: true),
                    pixPagadorpixId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transasoes", x => x.transacaoId);
                    table.ForeignKey(
                        name: "FK_transasoes_pix_pixPagadorpixId",
                        column: x => x.pixPagadorpixId,
                        principalTable: "pix",
                        principalColumn: "pixId");
                    table.ForeignKey(
                        name: "FK_transasoes_pix_pixRecebedorpixId",
                        column: x => x.pixRecebedorpixId,
                        principalTable: "pix",
                        principalColumn: "pixId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_pixId",
                table: "clientes",
                column: "pixId");

            migrationBuilder.CreateIndex(
                name: "IX_transasoes_pixPagadorpixId",
                table: "transasoes",
                column: "pixPagadorpixId");

            migrationBuilder.CreateIndex(
                name: "IX_transasoes_pixRecebedorpixId",
                table: "transasoes",
                column: "pixRecebedorpixId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "transasoes");

            migrationBuilder.DropTable(
                name: "pix");
        }
    }
}
