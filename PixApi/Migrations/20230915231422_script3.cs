using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixApi.Migrations
{
    /// <inheritdoc />
    public partial class script3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_pix_pixId",
                table: "clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_pix_pixPagadorpixId",
                table: "transasoes");

            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_pix_pixRecebedorpixId",
                table: "transasoes");

            migrationBuilder.RenameColumn(
                name: "pixRecebedorpixId",
                table: "transasoes",
                newName: "PixRecebedorPixId");

            migrationBuilder.RenameColumn(
                name: "pixPagadorpixId",
                table: "transasoes",
                newName: "PixPagadorPixId");

            migrationBuilder.RenameColumn(
                name: "transacaoId",
                table: "transasoes",
                newName: "TransacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_transasoes_pixRecebedorpixId",
                table: "transasoes",
                newName: "IX_transasoes_PixRecebedorPixId");

            migrationBuilder.RenameIndex(
                name: "IX_transasoes_pixPagadorpixId",
                table: "transasoes",
                newName: "IX_transasoes_PixPagadorPixId");

            migrationBuilder.RenameColumn(
                name: "dataCriacao",
                table: "pix",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "chave",
                table: "pix",
                newName: "Chave");

            migrationBuilder.RenameColumn(
                name: "pixId",
                table: "pix",
                newName: "PixId");

            migrationBuilder.RenameColumn(
                name: "saldo",
                table: "clientes",
                newName: "Saldo");

            migrationBuilder.RenameColumn(
                name: "pixId",
                table: "clientes",
                newName: "PixId");

            migrationBuilder.RenameColumn(
                name: "clienteNome",
                table: "clientes",
                newName: "ClienteNome");

            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "clientes",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_clientes_pixId",
                table: "clientes",
                newName: "IX_clientes_PixId");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_pix_PixId",
                table: "clientes",
                column: "PixId",
                principalTable: "pix",
                principalColumn: "PixId",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_pix_PixId",
                table: "clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_pix_PixPagadorPixId",
                table: "transasoes");

            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_pix_PixRecebedorPixId",
                table: "transasoes");

            migrationBuilder.RenameColumn(
                name: "PixRecebedorPixId",
                table: "transasoes",
                newName: "pixRecebedorpixId");

            migrationBuilder.RenameColumn(
                name: "PixPagadorPixId",
                table: "transasoes",
                newName: "pixPagadorpixId");

            migrationBuilder.RenameColumn(
                name: "TransacaoId",
                table: "transasoes",
                newName: "transacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_transasoes_PixRecebedorPixId",
                table: "transasoes",
                newName: "IX_transasoes_pixRecebedorpixId");

            migrationBuilder.RenameIndex(
                name: "IX_transasoes_PixPagadorPixId",
                table: "transasoes",
                newName: "IX_transasoes_pixPagadorpixId");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "pix",
                newName: "dataCriacao");

            migrationBuilder.RenameColumn(
                name: "Chave",
                table: "pix",
                newName: "chave");

            migrationBuilder.RenameColumn(
                name: "PixId",
                table: "pix",
                newName: "pixId");

            migrationBuilder.RenameColumn(
                name: "Saldo",
                table: "clientes",
                newName: "saldo");

            migrationBuilder.RenameColumn(
                name: "PixId",
                table: "clientes",
                newName: "pixId");

            migrationBuilder.RenameColumn(
                name: "ClienteNome",
                table: "clientes",
                newName: "clienteNome");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "clientes",
                newName: "clienteId");

            migrationBuilder.RenameIndex(
                name: "IX_clientes_PixId",
                table: "clientes",
                newName: "IX_clientes_pixId");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_pix_pixId",
                table: "clientes",
                column: "pixId",
                principalTable: "pix",
                principalColumn: "pixId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transasoes_pix_pixPagadorpixId",
                table: "transasoes",
                column: "pixPagadorpixId",
                principalTable: "pix",
                principalColumn: "pixId");

            migrationBuilder.AddForeignKey(
                name: "FK_transasoes_pix_pixRecebedorpixId",
                table: "transasoes",
                column: "pixRecebedorpixId",
                principalTable: "pix",
                principalColumn: "pixId");
        }
    }
}
