using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursovaya1.Migrations
{
    /// <inheritdoc />
    public partial class end3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compositions_dishes_Dishid",
                table: "compositions");

            migrationBuilder.DropForeignKey(
                name: "FK_compositions_orders_Orderid",
                table: "compositions");

            migrationBuilder.DropIndex(
                name: "IX_compositions_Dishid",
                table: "compositions");

            migrationBuilder.DropIndex(
                name: "IX_compositions_Orderid",
                table: "compositions");

            migrationBuilder.DropColumn(
                name: "Dishid",
                table: "compositions");

            migrationBuilder.DropColumn(
                name: "Orderid",
                table: "compositions");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "compositions",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "compositions");

            migrationBuilder.AddColumn<Guid>(
                name: "Dishid",
                table: "compositions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Orderid",
                table: "compositions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_compositions_Dishid",
                table: "compositions",
                column: "Dishid");

            migrationBuilder.CreateIndex(
                name: "IX_compositions_Orderid",
                table: "compositions",
                column: "Orderid");

            migrationBuilder.AddForeignKey(
                name: "FK_compositions_dishes_Dishid",
                table: "compositions",
                column: "Dishid",
                principalTable: "dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_compositions_orders_Orderid",
                table: "compositions",
                column: "Orderid",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
