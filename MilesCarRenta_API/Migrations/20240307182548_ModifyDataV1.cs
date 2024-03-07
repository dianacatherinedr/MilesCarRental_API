using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilesCarRenta_API.Migrations
{
    /// <inheritdoc />
    public partial class ModifyDataV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3098), new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3115), new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3117), new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3119), new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3121), new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3122), new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.InsertData(
                table: "ReturnOptions",
                columns: new[] { "Id", "Address", "Created_at", "Description", "Location_id", "Name_receiving_mamanger", "Updated_at" },
                values: new object[] { 6, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esta locación no tiene opcion de devolución", 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReturnOptions",
                keyColumn: "Id",
                keyValue: 6);

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
        }
    }
}
