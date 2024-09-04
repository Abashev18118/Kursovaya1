using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursovaya1.Migrations
{
    /// <inheritdoc />
    public partial class end8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_halls_waiters_FirstNameId",
                table: "halls");

            migrationBuilder.DropIndex(
                name: "IX_halls_FirstNameId",
                table: "halls");

            migrationBuilder.DropColumn(
                name: "FirstNameId",
                table: "halls");

            migrationBuilder.AddColumn<string>(
                name: "FirstName_LastName",
                table: "halls",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "grafikwaiter",
                table: "halls",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName_LastName",
                table: "halls");

            migrationBuilder.DropColumn(
                name: "grafikwaiter",
                table: "halls");

            migrationBuilder.AddColumn<Guid>(
                name: "FirstNameId",
                table: "halls",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_halls_FirstNameId",
                table: "halls",
                column: "FirstNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_halls_waiters_FirstNameId",
                table: "halls",
                column: "FirstNameId",
                principalTable: "waiters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
