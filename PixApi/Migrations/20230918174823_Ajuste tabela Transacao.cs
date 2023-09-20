using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixApi.Migrations
{
    /// <inheritdoc />
    public partial class AjustetabelaTransacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_pix_PixPagadorPixId",
                table: "transasoes");

            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_pix_PixRecebedorPixId",
                table: "transasoes");

            migrationBuilder.RenameColumn(
                name: "PixRecebedorPixId",
                table: "transasoes",
                newName: "PixRecebedorClienteId");

            migrationBuilder.RenameColumn(
                name: "PixPagadorPixId",
                table: "transasoes",
                newName: "PixPagadorClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_transasoes_PixRecebedorPixId",
                table: "transasoes",
                newName: "IX_transasoes_PixRecebedorClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_transasoes_PixPagadorPixId",
                table: "transasoes",
                newName: "IX_transasoes_PixPagadorClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_transasoes_clientes_PixPagadorClienteId",
                table: "transasoes",
                column: "PixPagadorClienteId",
                principalTable: "clientes",
                principalColumn: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_transasoes_clientes_PixRecebedorClienteId",
                table: "transasoes",
                column: "PixRecebedorClienteId",
                principalTable: "clientes",
                principalColumn: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_clientes_PixPagadorClienteId",
                table: "transasoes");

            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_clientes_PixRecebedorClienteId",
                table: "transasoes");

            migrationBuilder.RenameColumn(
                name: "PixRecebedorClienteId",
                table: "transasoes",
                newName: "PixRecebedorPixId");

            migrationBuilder.RenameColumn(
                name: "PixPagadorClienteId",
                table: "transasoes",
                newName: "PixPagadorPixId");

            migrationBuilder.RenameIndex(
                name: "IX_transasoes_PixRecebedorClienteId",
                table: "transasoes",
                newName: "IX_transasoes_PixRecebedorPixId");

            migrationBuilder.RenameIndex(
                name: "IX_transasoes_PixPagadorClienteId",
                table: "transasoes",
                newName: "IX_transasoes_PixPagadorPixId");

            migrationBuilder.AddForeignKey(
                name: "FK_transasoes_pix_PixPagadorPixId",
                table: "transasoes",
                column: "PixPagadorPixId",
                principalTable: "pix",
                principalColumn: "PixId");

            migrationBuilder.AddForeignKey(
                name: "FK_transasoes_pix_PixRecebedorPixId",
                table: "transasoes",
                column: "PixRecebedorPixId",
                principalTable: "pix",
                principalColumn: "PixId");
        }
    }
}
