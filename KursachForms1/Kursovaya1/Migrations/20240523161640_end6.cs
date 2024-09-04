using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursovaya1.Migrations
{
    /// <inheritdoc />
    public partial class end6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "number_of_hall",
                table: "restaurant");

            migrationBuilder.AddColumn<string>(
                name: "type_of_hall",
                table: "restaurant",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type_of_hall",
                table: "restaurant");

            migrationBuilder.AddColumn<int>(
                name: "number_of_hall",
                table: "restaurant",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
