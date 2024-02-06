using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("c4e0d0e7-5f06-48c7-9246-11fe12f2c602"), null, "Actividades Personales", 50 },
                    { new Guid("c4e0d0e7-5f06-48c7-9246-11fe12f2c657"), null, "Actividades Pendientes", 20 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[,]
                {
                    { new Guid("c4e0d0e7-5f06-48c7-9246-11fe12f2c100"), new Guid("c4e0d0e7-5f06-48c7-9246-11fe12f2c657"), null, new DateTime(2024, 1, 26, 12, 42, 43, 115, DateTimeKind.Local).AddTicks(2194), 1, "Pago de servicios publicos" },
                    { new Guid("c4e0d0e7-5f06-48c7-9246-11fe12f2c110"), new Guid("c4e0d0e7-5f06-48c7-9246-11fe12f2c602"), null, new DateTime(2024, 1, 26, 12, 42, 43, 115, DateTimeKind.Local).AddTicks(2216), 0, "Terminar pelicula" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c4e0d0e7-5f06-48c7-9246-11fe12f2c100"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c4e0d0e7-5f06-48c7-9246-11fe12f2c110"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("c4e0d0e7-5f06-48c7-9246-11fe12f2c602"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("c4e0d0e7-5f06-48c7-9246-11fe12f2c657"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
