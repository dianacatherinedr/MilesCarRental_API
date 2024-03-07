using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilesCarRenta_API.Migrations
{
    /// <inheritdoc />
    public partial class ModifyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2854), new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2870), new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2872), new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2874), new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2876), new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2878), new DateTime(2024, 3, 7, 13, 10, 44, 339, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "ReturnOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location_id",
                value: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9600), new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9605), new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9607), new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9609), new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "ReturnOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location_id",
                value: 1);
        }
    }
}
