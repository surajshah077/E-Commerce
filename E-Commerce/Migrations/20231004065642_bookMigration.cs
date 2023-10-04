using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class bookMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Table",
                table: "statics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TableTitle",
                table: "statics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TableTitle2",
                table: "statics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TableTitle3",
                table: "statics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "bookTable",
                columns: table => new
                {
                    bookTableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    BookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    People = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookTable", x => x.bookTableId);
                });

            migrationBuilder.UpdateData(
                table: "statics",
                keyColumn: "StaticId",
                keyValue: 1,
                columns: new[] { "Table", "TableTitle", "TableTitle2", "TableTitle3" },
                values: new object[] { "BOOK A TABLE", "Book", "Your Stay", "With Us" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookTable");

            migrationBuilder.DropColumn(
                name: "Table",
                table: "statics");

            migrationBuilder.DropColumn(
                name: "TableTitle",
                table: "statics");

            migrationBuilder.DropColumn(
                name: "TableTitle2",
                table: "statics");

            migrationBuilder.DropColumn(
                name: "TableTitle3",
                table: "statics");
        }
    }
}
