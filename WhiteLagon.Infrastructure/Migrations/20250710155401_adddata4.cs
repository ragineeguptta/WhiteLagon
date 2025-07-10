using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhiteLagon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adddata4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Price", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9806), 1000, new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Price", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9818), 1200, new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Price", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9821), 2000, new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Price", "Updated_At" },
                values: new object[] { new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9823), 900, new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9823) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
