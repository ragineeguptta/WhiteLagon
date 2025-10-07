using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class aminitytodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VillaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Amenities_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Description", "Name", "VillaId" },
                values: new object[,]
                {
                    { 1, null, "Amenity 1", 1 },
                    { 2, null, "Amenity 2", 2 },
                    { 3, null, "Amenity 3", 1 },
                    { 4, null, "Amenity 4", 4 },
                    { 5, null, "Amenity 5", 4 },
                    { 6, null, "Amenity 6", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 10, 6, 10, 30, 28, 533, DateTimeKind.Utc).AddTicks(592), new DateTime(2025, 10, 6, 10, 30, 28, 533, DateTimeKind.Utc).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 10, 6, 10, 30, 28, 533, DateTimeKind.Utc).AddTicks(596), new DateTime(2025, 10, 6, 10, 30, 28, 533, DateTimeKind.Utc).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 10, 6, 10, 30, 28, 533, DateTimeKind.Utc).AddTicks(598), new DateTime(2025, 10, 6, 10, 30, 28, 533, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 10, 6, 10, 30, 28, 533, DateTimeKind.Utc).AddTicks(599), new DateTime(2025, 10, 6, 10, 30, 28, 533, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_VillaId",
                table: "Amenities",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 9, 9, 15, 5, 24, 421, DateTimeKind.Utc).AddTicks(6746), new DateTime(2025, 9, 9, 15, 5, 24, 421, DateTimeKind.Utc).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 9, 9, 15, 5, 24, 421, DateTimeKind.Utc).AddTicks(6756), new DateTime(2025, 9, 9, 15, 5, 24, 421, DateTimeKind.Utc).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 9, 9, 15, 5, 24, 421, DateTimeKind.Utc).AddTicks(6758), new DateTime(2025, 9, 9, 15, 5, 24, 421, DateTimeKind.Utc).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2025, 9, 9, 15, 5, 24, 421, DateTimeKind.Utc).AddTicks(6759), new DateTime(2025, 9, 9, 15, 5, 24, 421, DateTimeKind.Utc).AddTicks(6759) });
        }
    }
}
