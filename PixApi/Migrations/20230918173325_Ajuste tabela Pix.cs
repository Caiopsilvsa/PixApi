using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixApi.Migrations
{
    /// <inheritdoc />
    public partial class AjustetabelaPix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_pix_PixId",
                table: "clientes");

            migrationBuilder.RenameColumn(
                name: "PixId",
                table: "clientes",
                newName: "pixId");

            migrationBuilder.RenameIndex(
                name: "IX_clientes_PixId",
                table: "clientes",
                newName: "IX_clientes_pixId");

            migrationBuilder.AlterColumn<string>(
                name: "Chave",
                table: "pix",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_pix_Chave",
                table: "pix",
                column: "Chave",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_pix_pixId",
                table: "clientes",
                column: "pixId",
                principalTable: "pix",
                principalColumn: "PixId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_pix_pixId",
                table: "clientes");

            migrationBuilder.DropIndex(
                name: "IX_pix_Chave",
                table: "pix");

            migrationBuilder.RenameColumn(
                name: "pixId",
                table: "clientes",
                newName: "PixId");

            migrationBuilder.RenameIndex(
                name: "IX_clientes_pixId",
                table: "clientes",
                newName: "IX_clientes_PixId");

            migrationBuilder.AlterColumn<string>(
                name: "Chave",
                table: "pix",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_pix_PixId",
                table: "clientes",
                column: "PixId",
                principalTable: "pix",
                principalColumn: "PixId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
