using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursovaya1.Migrations
{
    /// <inheritdoc />
    public partial class end4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_restaurant_RestaurantId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_tables_Tableid",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_RestaurantId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_Tableid",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Restaurantiid",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Tableid",
                table: "orders");

            migrationBuilder.AddColumn<string>(
                name: "RestaurantName",
                table: "orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TableNumber",
                table: "orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestaurantName",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "TableNumber",
                table: "orders");

            migrationBuilder.AddColumn<Guid>(
                name: "RestaurantId",
                table: "orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Restaurantiid",
                table: "orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Tableid",
                table: "orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_orders_RestaurantId",
                table: "orders",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Tableid",
                table: "orders",
                column: "Tableid");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_restaurant_RestaurantId",
                table: "orders",
                column: "RestaurantId",
                principalTable: "restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_tables_Tableid",
                table: "orders",
                column: "Tableid",
                principalTable: "tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
