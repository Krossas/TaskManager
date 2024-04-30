using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    /// <inheritdoc />
    public partial class changeDescriptionToNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Order",
                table: "MyTasks",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MyTasks",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Order",
                table: "MyTasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MyTasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Deadline" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2621), new DateTime(2024, 5, 3, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Deadline" },
                values: new object[] { new DateTime(2024, 5, 7, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2666), new DateTime(2024, 5, 14, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Deadline" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2671), new DateTime(2024, 5, 25, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Deadline" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2675), new DateTime(2024, 6, 30, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2679) });
        }
    }
}
