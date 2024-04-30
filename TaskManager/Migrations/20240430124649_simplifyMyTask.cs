using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    /// <inheritdoc />
    public partial class simplifyMyTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "MyTasks");

            migrationBuilder.DropColumn(
                name: "Deadline",
                table: "MyTasks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MyTasks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deadline",
                table: "MyTasks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Deadline" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 32, 10, 951, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 5, 3, 14, 32, 10, 951, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Deadline" },
                values: new object[] { new DateTime(2024, 5, 7, 14, 32, 10, 951, DateTimeKind.Local).AddTicks(757), new DateTime(2024, 5, 14, 14, 32, 10, 951, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Deadline" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 32, 10, 951, DateTimeKind.Local).AddTicks(762), new DateTime(2024, 5, 25, 14, 32, 10, 951, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Deadline" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 32, 10, 951, DateTimeKind.Local).AddTicks(767), new DateTime(2024, 6, 30, 14, 32, 10, 951, DateTimeKind.Local).AddTicks(770) });
        }
    }
}
