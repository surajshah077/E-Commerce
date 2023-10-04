using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class initMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutTitle2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    phoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    shortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventPicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "mains",
                columns: table => new
                {
                    MainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutHeading1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutHeading2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mains", x => x.MainId);
                });

            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    itemPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    profileImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "statics",
                columns: table => new
                {
                    StaticId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Menu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuTopic1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuTopic2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuTopic3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuTopic4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Testimonials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestimonialsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestimonialsTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Event = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventTitle3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statics", x => x.StaticId);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "AboutId", "AboutTitle1", "AboutTitle2", "Image", "Image2", "Message", "Video", "description", "phoneNumber", "shortDescription" },
                values: new object[] { 1, "Learn More", "About Us", "", "", "Book a Table", "You can upload video Here", "Write description Here", 9808300810L, "Write a short Description Here" });

            migrationBuilder.InsertData(
                table: "mains",
                columns: new[] { "MainId", "AboutDescription", "AboutHeading1", "AboutHeading2", "Image", "Video" },
                values: new object[] { 1, "Sed autem laudantium dolores. Voluptatem itaque ea consequatur eveniet. Eum quas beatae cumque eum quaerat.", "Enjoy Your Healthy", "Delicious Food", "abooutImages/hero-img.png", "aboutVideo" });

            migrationBuilder.InsertData(
                table: "statics",
                columns: new[] { "StaticId", "Event", "Menu", "MenuTitle", "MenuTitle2", "MenuTopic1", "MenuTopic2", "MenuTopic3", "MenuTopic4", "Testimonials", "TestimonialsTitle", "TestimonialsTitle2", "eventTitle", "eventTitle2", "eventTitle3" },
                values: new object[] { 1, "EVENTS", "OUR MENU", "Check Our", "Yummy Menu", "Starters", "Breakfast", "Lunch", "Dinner", "TESTIMONIALS", "What Are They", "Saying About Us", "Share ", "Your Moments", "In Our Restaurant" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "mains");

            migrationBuilder.DropTable(
                name: "menu");

            migrationBuilder.DropTable(
                name: "statics");
        }
    }
}
