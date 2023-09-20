using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixApi.Migrations
{
    /// <inheritdoc />
    public partial class AjustetabelaTransacaodenovo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_clientes_PixPagadorClienteId",
                table: "transasoes");

            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_clientes_PixRecebedorClienteId",
                table: "transasoes");

            migrationBuilder.DropIndex(
                name: "IX_transasoes_PixPagadorClienteId",
                table: "transasoes");

            migrationBuilder.DropIndex(
                name: "IX_transasoes_PixRecebedorClienteId",
                table: "transasoes");

            migrationBuilder.DropColumn(
                name: "PixPagadorClienteId",
                table: "transasoes");

            migrationBuilder.DropColumn(
                name: "PixRecebedorClienteId",
                table: "transasoes");

            migrationBuilder.AddColumn<string>(
                name: "ClientePagador",
                table: "transasoes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClienteRecebedor",
                table: "transasoes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientePagador",
                table: "transasoes");

            migrationBuilder.DropColumn(
                name: "ClienteRecebedor",
                table: "transasoes");

            migrationBuilder.AddColumn<int>(
                name: "PixPagadorClienteId",
                table: "transasoes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PixRecebedorClienteId",
                table: "transasoes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_transasoes_PixPagadorClienteId",
                table: "transasoes",
                column: "PixPagadorClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_transasoes_PixRecebedorClienteId",
                table: "transasoes",
                column: "PixRecebedorClienteId");

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
    }
}
