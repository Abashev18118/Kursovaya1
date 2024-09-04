using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursovaya1.Migrations
{
    /// <inheritdoc />
    public partial class end5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_restaurant_halls_Restaurant_hallid",
                table: "restaurant");

            migrationBuilder.DropIndex(
                name: "IX_restaurant_Restaurant_hallid",
                table: "restaurant");

            migrationBuilder.DropColumn(
                name: "Restaurant_hallid",
                table: "restaurant");

            migrationBuilder.AddColumn<int>(
                name: "number_of_hall",
                table: "restaurant",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "number_of_hall",
                table: "restaurant");

            migrationBuilder.AddColumn<Guid>(
                name: "Restaurant_hallid",
                table: "restaurant",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_restaurant_Restaurant_hallid",
                table: "restaurant",
                column: "Restaurant_hallid");

            migrationBuilder.AddForeignKey(
                name: "FK_restaurant_halls_Restaurant_hallid",
                table: "restaurant",
                column: "Restaurant_hallid",
                principalTable: "halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
