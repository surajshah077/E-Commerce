﻿// <auto-generated />
using E_Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Commerce.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231004060015_galleryMigration")]
    partial class galleryMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_Commerce.Models.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutId"));

                    b.Property<string>("AboutTitle1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AboutTitle2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("phoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("shortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("About");

                    b.HasData(
                        new
                        {
                            AboutId = 1,
                            AboutTitle1 = "Learn More",
                            AboutTitle2 = "About Us",
                            Image = "",
                            Image2 = "",
                            Message = "Book a Table",
                            Video = "",
                            description = "Write description Here",
                            phoneNumber = 9808300810L,
                            shortDescription = "Write a short Description Here"
                        });
                });

            modelBuilder.Entity("E_Commerce.Models.Chefs", b =>
                {
                    b.Property<int>("ChefsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChefsId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profileImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("socialMediaLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChefsId");

                    b.ToTable("chefs");
                });

            modelBuilder.Entity("E_Commerce.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<string>("eventDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("events");
                });

            modelBuilder.Entity("E_Commerce.Models.Gallery", b =>
                {
                    b.Property<int>("GalleryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GalleryId"));

                    b.Property<string>("GalleryPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GalleryId");

                    b.ToTable("gallery");
                });

            modelBuilder.Entity("E_Commerce.Models.Main", b =>
                {
                    b.Property<int>("MainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MainId"));

                    b.Property<string>("AboutDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("AboutHeading1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AboutHeading2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MainId");

                    b.ToTable("mains");

                    b.HasData(
                        new
                        {
                            MainId = 1,
                            AboutDescription = "Sed autem laudantium dolores. Voluptatem itaque ea consequatur eveniet. Eum quas beatae cumque eum quaerat.",
                            AboutHeading1 = "Enjoy Your Healthy",
                            AboutHeading2 = "Delicious Food",
                            Image = "",
                            Video = ""
                        });
                });

            modelBuilder.Entity("E_Commerce.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"));

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemPhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profileImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuId");

                    b.ToTable("menu");
                });

            modelBuilder.Entity("E_Commerce.Models.Register", b =>
                {
                    b.Property<int>("RegisterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegisterId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("role")
                        .HasColumnType("int");

                    b.HasKey("RegisterId");

                    b.ToTable("register");
                });

            modelBuilder.Entity("E_Commerce.Models.Static", b =>
                {
                    b.Property<int>("StaticId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaticId"));

                    b.Property<string>("Event")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gallery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GalleryTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GalleryTitle2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Menu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuTitle2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuTopic1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuTopic2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuTopic3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuTopic4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Testimonials")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialsTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialsTitle2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chefs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chefsTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chefsTitle2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chefsTitle3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventTitle2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventTitle3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaticId");

                    b.ToTable("statics");

                    b.HasData(
                        new
                        {
                            StaticId = 1,
                            Event = "EVENTS",
                            Gallery = "GALLERY",
                            GalleryTitle = "Check",
                            GalleryTitle2 = "Our Gallery",
                            Menu = "OUR MENU",
                            MenuTitle = "Check Our",
                            MenuTitle2 = "Yummy Menu",
                            MenuTopic1 = "Starters",
                            MenuTopic2 = "Breakfast",
                            MenuTopic3 = "Lunch",
                            MenuTopic4 = "Dinner",
                            Testimonials = "TESTIMONIALS",
                            TestimonialsTitle = "What Are They",
                            TestimonialsTitle2 = "Saying About Us",
                            chefs = "CHEFS",
                            chefsTitle = "Our",
                            chefsTitle2 = "Proffesional",
                            chefsTitle3 = "Chefs",
                            eventTitle = "Share ",
                            eventTitle2 = "Your Moments",
                            eventTitle3 = "In Our Restaurant"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
