using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class galleryMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gallery",
                table: "statics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GalleryTitle",
                table: "statics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GalleryTitle2",
                table: "statics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "chefs",
                table: "statics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "chefsTitle",
                table: "statics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "chefsTitle2",
                table: "statics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "chefsTitle3",
                table: "statics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "chefs",
                columns: table => new
                {
                    ChefsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profileImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    socialMediaLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chefs", x => x.ChefsId);
                });

            migrationBuilder.CreateTable(
                name: "gallery",
                columns: table => new
                {
                    GalleryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GalleryPicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gallery", x => x.GalleryId);
                });

            migrationBuilder.CreateTable(
                name: "register",
                columns: table => new
                {
                    RegisterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_register", x => x.RegisterId);
                });

            migrationBuilder.UpdateData(
                table: "About",
                keyColumn: "AboutId",
                keyValue: 1,
                column: "Video",
                value: "");

            migrationBuilder.UpdateData(
                table: "mains",
                keyColumn: "MainId",
                keyValue: 1,
                columns: new[] { "Image", "Video" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "statics",
                keyColumn: "StaticId",
                keyValue: 1,
                columns: new[] { "Gallery", "GalleryTitle", "GalleryTitle2", "chefs", "chefsTitle", "chefsTitle2", "chefsTitle3" },
                values: new object[] { "GALLERY", "Check", "Our Gallery", "CHEFS", "Our", "Proffesional", "Chefs" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chefs");

            migrationBuilder.DropTable(
                name: "gallery");

            migrationBuilder.DropTable(
                name: "register");

            migrationBuilder.DropColumn(
                name: "Gallery",
                table: "statics");

            migrationBuilder.DropColumn(
                name: "GalleryTitle",
                table: "statics");

            migrationBuilder.DropColumn(
                name: "GalleryTitle2",
                table: "statics");

            migrationBuilder.DropColumn(
                name: "chefs",
                table: "statics");

            migrationBuilder.DropColumn(
                name: "chefsTitle",
                table: "statics");

            migrationBuilder.DropColumn(
                name: "chefsTitle2",
                table: "statics");

            migrationBuilder.DropColumn(
                name: "chefsTitle3",
                table: "statics");

            migrationBuilder.UpdateData(
                table: "About",
                keyColumn: "AboutId",
                keyValue: 1,
                column: "Video",
                value: "You can upload video Here");

            migrationBuilder.UpdateData(
                table: "mains",
                keyColumn: "MainId",
                keyValue: 1,
                columns: new[] { "Image", "Video" },
                values: new object[] { "abooutImages/hero-img.png", "aboutVideo" });
        }
    }
}
