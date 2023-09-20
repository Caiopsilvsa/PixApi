using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixApi.Migrations
{
    /// <inheritdoc />
    public partial class OutraMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PixClientePagador",
                table: "transasoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PixClienteRecebedor",
                table: "transasoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PixClientePagador",
                table: "transasoes");

            migrationBuilder.DropColumn(
                name: "PixClienteRecebedor",
                table: "transasoes");
        }
    }
}
