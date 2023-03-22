using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace practica2_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle", new DateTime(2023, 3, 22, 10, 24, 48, 625, DateTimeKind.Local).AddTicks(5433), new DateTime(2023, 3, 22, 10, 24, 48, 625, DateTimeKind.Local).AddTicks(5421), "...", 50, "Villa 1", 5, 200.0 },
                    { 2, "", "Detalle", new DateTime(2023, 3, 22, 10, 24, 48, 625, DateTimeKind.Local).AddTicks(5435), new DateTime(2023, 3, 22, 10, 24, 48, 625, DateTimeKind.Local).AddTicks(5435), "...", 30, "Villa 2", 3, 100.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
