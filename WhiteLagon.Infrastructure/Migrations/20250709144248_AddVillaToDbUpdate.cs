using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhiteLagon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaToDbUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Villas",
                newName: "Updated_At");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Villas",
                newName: "Created_At");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updated_At",
                table: "Villas",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "Villas",
                newName: "CreatedAt");
        }
    }
}
