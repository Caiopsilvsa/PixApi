using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixApi.Migrations
{
    /// <inheritdoc />
    public partial class script2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_pix_pixId",
                table: "clientes");

            migrationBuilder.AlterColumn<int>(
                name: "pixId",
                table: "clientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_pix_pixId",
                table: "clientes",
                column: "pixId",
                principalTable: "pix",
                principalColumn: "pixId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_pix_pixId",
                table: "clientes");

            migrationBuilder.AlterColumn<int>(
                name: "pixId",
                table: "clientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_pix_pixId",
                table: "clientes",
                column: "pixId",
                principalTable: "pix",
                principalColumn: "pixId");
        }
    }
}
