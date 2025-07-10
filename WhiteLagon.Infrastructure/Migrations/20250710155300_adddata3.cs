using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhiteLagon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adddata3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Villas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Price", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 10, 15, 53, 0, 387, DateTimeKind.Utc).AddTicks(947), 0, new DateTime(2025, 7, 10, 15, 53, 0, 387, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Price", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 10, 15, 53, 0, 387, DateTimeKind.Utc).AddTicks(958), 0, new DateTime(2025, 7, 10, 15, 53, 0, 387, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Price", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 10, 15, 53, 0, 387, DateTimeKind.Utc).AddTicks(961), 0, new DateTime(2025, 7, 10, 15, 53, 0, 387, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Price", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 10, 15, 53, 0, 387, DateTimeKind.Utc).AddTicks(963), 0, new DateTime(2025, 7, 10, 15, 53, 0, 387, DateTimeKind.Utc).AddTicks(963) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Villas");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 9, 14, 55, 32, 507, DateTimeKind.Utc).AddTicks(4935), new DateTime(2025, 7, 9, 14, 55, 32, 507, DateTimeKind.Utc).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 9, 14, 55, 32, 507, DateTimeKind.Utc).AddTicks(4946), new DateTime(2025, 7, 9, 14, 55, 32, 507, DateTimeKind.Utc).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 9, 14, 55, 32, 507, DateTimeKind.Utc).AddTicks(4948), new DateTime(2025, 7, 9, 14, 55, 32, 507, DateTimeKind.Utc).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 9, 14, 55, 32, 507, DateTimeKind.Utc).AddTicks(4950), new DateTime(2025, 7, 9, 14, 55, 32, 507, DateTimeKind.Utc).AddTicks(4950) });
        }
    }
}
