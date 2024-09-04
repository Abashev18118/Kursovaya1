using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursovaya1.Migrations
{
    /// <inheritdoc />
    public partial class ends : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "newhalls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    number_of_hall = table.Column<int>(type: "integer", nullable: false),
                    square = table.Column<double>(type: "double precision", nullable: false),
                    number_of_tables = table.Column<int>(type: "integer", nullable: false),
                    FirstName_LastName = table.Column<string>(type: "text", nullable: false),
                    grafikwaiter = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newhalls", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "newhalls");
        }
    }
}
