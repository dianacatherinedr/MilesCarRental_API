using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MilesCarRenta_API.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plate_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vehicule_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Engine_capacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Location_id = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<float>(type: "real", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReturnOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_receiving_mamanger = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_id = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOptions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Created_at", "Engine_capacity", "Location_id", "Model", "Plate_number", "Status", "Updated_at", "Vehicule_type" },
                values: new object[,]
                {
                    { 1, "Chevrolet", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9584), "1600cc", 1, "2018", "PTH15E", "D", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9597), "Camioneta" },
                    { 2, "Chevrolet", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9600), "1200cc", 1, "2022", "KNQ32", "D", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9601), "Automovil" },
                    { 3, "Mazda", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9603), "1400cc", 2, "2009", "ATR21", "O", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9604), "Automovil" },
                    { 4, "Nissan", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9605), "1600cc", 3, "2017", "KNP98", "O", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9606), "Campero" },
                    { 5, "Nissan", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9607), "1600cc", 4, "2017", "KNP98", "O", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9608), "Campero" },
                    { 6, "Wolsvagen", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9609), "1600cc", 3, "2007", "ARS45", "D", new DateTime(2024, 3, 7, 0, 39, 5, 482, DateTimeKind.Local).AddTicks(9610), "Sub" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Created_at", "Description", "Latitude", "Longitude", "Name", "Updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parque deportivo", 10.4881f, -66.8796f, "Parque Central", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Telecomunicaciones", 48.8584f, 2.2945f, "Torre Central", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plaza principal", 55.7539f, 37.6208f, "Plaza de Bolivar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parque de Recreacion", -13.1631f, -72.545f, "Salitre Magico", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estadio", 29.9792f, 31.1344f, "Movistar Arena", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ReturnOptions",
                columns: new[] { "Id", "Address", "Created_at", "Description", "Location_id", "Name_receiving_mamanger", "Updated_at" },
                values: new object[,]
                {
                    { 1, " CALLE 26 #35-180 ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La devolucion se realizará en horario de la tarde", 2, "Luisa Quevedo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, " CALLE 1N #185-96 ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La devolucion se realizará en horario de la mañana en el local directamente", 4, "Maria Rojas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, " CALLE 24N #259-123 ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La devolucion se realizará en horario de la mañana", 5, "Camila Duque", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, " Carrera 15 #54-43 Bastilla Parqueadero ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La devolucion se realizará en horario laboral de 8 a 12 y de 2 a 6 en el parqueadero disponible", 1, "Lorena Arias", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, " 80 con calle 10 #89-74", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La devolucion se realizará en horario de la tarde en el local directamente", 3, "Eliza Flores", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "ReturnOptions");
        }
    }
}
