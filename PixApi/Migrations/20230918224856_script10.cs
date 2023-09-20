using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixApi.Migrations
{
    /// <inheritdoc />
    public partial class script10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientePagador",
                table: "transasoes");

            migrationBuilder.DropColumn(
                name: "ClienteRecebedor",
                table: "transasoes");

            migrationBuilder.AddColumn<int>(
                name: "ClientePagadorClienteId",
                table: "transasoes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteRecebedorClienteId",
                table: "transasoes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_transasoes_ClientePagadorClienteId",
                table: "transasoes",
                column: "ClientePagadorClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_transasoes_ClienteRecebedorClienteId",
                table: "transasoes",
                column: "ClienteRecebedorClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_transasoes_clientes_ClientePagadorClienteId",
                table: "transasoes",
                column: "ClientePagadorClienteId",
                principalTable: "clientes",
                principalColumn: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_transasoes_clientes_ClienteRecebedorClienteId",
                table: "transasoes",
                column: "ClienteRecebedorClienteId",
                principalTable: "clientes",
                principalColumn: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_clientes_ClientePagadorClienteId",
                table: "transasoes");

            migrationBuilder.DropForeignKey(
                name: "FK_transasoes_clientes_ClienteRecebedorClienteId",
                table: "transasoes");

            migrationBuilder.DropIndex(
                name: "IX_transasoes_ClientePagadorClienteId",
                table: "transasoes");

            migrationBuilder.DropIndex(
                name: "IX_transasoes_ClienteRecebedorClienteId",
                table: "transasoes");

            migrationBuilder.DropColumn(
                name: "ClientePagadorClienteId",
                table: "transasoes");

            migrationBuilder.DropColumn(
                name: "ClienteRecebedorClienteId",
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
    }
}
