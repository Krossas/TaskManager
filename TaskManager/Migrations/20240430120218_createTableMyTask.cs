using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManager.Migrations
{
    /// <inheritdoc />
    public partial class createTableMyTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Deadline = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: false),
                    IsDone = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyTasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MyTasks",
                columns: new[] { "Id", "Created", "Deadline", "Description", "IsDone", "Order" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 30, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2621), new DateTime(2024, 5, 3, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2662), "Test 01", false, 1 },
                    { 2, new DateTime(2024, 5, 7, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2666), new DateTime(2024, 5, 14, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2668), "Test 02", false, 2 },
                    { 3, new DateTime(2024, 5, 20, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2671), new DateTime(2024, 5, 25, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2672), "Test 03", true, 3 },
                    { 4, new DateTime(2024, 5, 30, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2675), new DateTime(2024, 6, 30, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2679), "Test 04", false, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyTasks");
        }
    }
}
