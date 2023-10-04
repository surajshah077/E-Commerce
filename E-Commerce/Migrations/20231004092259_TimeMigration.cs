using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class TimeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_bookTable",
                table: "bookTable");

            migrationBuilder.RenameTable(
                name: "bookTable",
                newName: "booking");

            migrationBuilder.AddPrimaryKey(
                name: "PK_booking",
                table: "booking",
                column: "bookTableId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_booking",
                table: "booking");

            migrationBuilder.RenameTable(
                name: "booking",
                newName: "bookTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookTable",
                table: "bookTable",
                column: "bookTableId");
        }
    }
}
