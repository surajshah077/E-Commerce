using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Net.Mime.MediaTypeNames;

namespace E_Commerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<About> About { get; set; }
        public DbSet<Main> mains { get; set; }
        public DbSet<Static> statics { get; set; }
        public DbSet<Menu> menu { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<Chefs> chefs { get; set; }
        public DbSet<Gallery> gallery { get; set; }
        public DbSet<Register> register { get; set; }
        public DbSet<bookTable> booking { get; set; }
        public DbSet<Contact> contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Main>().HasData(
               new Main
               {
                   MainId = 1,
                   AboutHeading1 = "Enjoy Your Healthy",
                   AboutHeading2 = "Delicious Food",
                   AboutDescription = "Sed autem laudantium dolores. Voluptatem itaque ea consequatur eveniet. Eum quas beatae cumque eum quaerat.",
                   Image = "",
                   Video = ""
               });
            modelBuilder.Entity<About>().HasData(
                new About
                {
                    AboutId = 1,
                    AboutTitle1= "Learn More",
                    AboutTitle2= "About Us",
                    Image="~/aboutImages",
                    Message= "Book a Table",
                    phoneNumber =9808300810,
                    shortDescription="Write a short Description Here",
                    description="Write description Here",
                    Video="",
                    Image2= "~/aboutImages"
                });
            modelBuilder.Entity<Static>().HasData(
                new Static
                {
                    StaticId= 1,
                    Menu= "OUR MENU",
                    MenuTitle= "Check Our",
                    MenuTitle2= "Yummy Menu",
                    MenuTopic1= "Starters",
                    MenuTopic2= "Breakfast",
                    MenuTopic3= "Lunch",
                    MenuTopic4= "Dinner",
                    Testimonials= "TESTIMONIALS",
                    TestimonialsTitle = "What Are They",
                    TestimonialsTitle2= "Saying About Us",
                    Event= "EVENTS",
                    eventTitle= "Share ",
                    eventTitle2 = "Your Moments",
                    eventTitle3 = "In Our Restaurant",
                    chefs= "CHEFS",
                    chefsTitle= "Our",
                    chefsTitle2= "Proffesional",
                    chefsTitle3= "Chefs",
                    Gallery= "GALLERY",
                    GalleryTitle= "Check",
                    GalleryTitle2= "Our Gallery",
                    Table= "BOOK A TABLE",
                    TableTitle = "Book",
                    TableTitle2 = "Your Stay",
                    TableTitle3 = "With Us",
                    ContactAddress= "A108 Adam Street, New York, NY 535022",
                    ContactEmail = "contact@example.com",
                    ContactPhone = "+977-9808300810",
                    WorkingDays = TimeSpan.FromHours(9),
                    Weekend = TimeSpan.FromHours(10),
                });
        }
       
    }
}
