﻿// <auto-generated />
using System;
using Booking.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Booking.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Booking.Entities.Models.BookingGuest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookingID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GuestID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BookingID");

                    b.HasIndex("GuestID");

                    b.ToTable("BookingGuests");
                });

            modelBuilder.Entity("Booking.Entities.Models.Bookings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckinDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckoutDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("RoomID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("RoomID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Booking.Entities.Models.Guest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCKN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3c8f549d-8308-4026-a47a-5bb72512fc81"),
                            Address = "123 Main St",
                            CreatedDate = new DateTime(2024, 7, 27, 12, 30, 26, 243, DateTimeKind.Utc).AddTicks(6090),
                            DateOfBirth = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            IsActive = true,
                            LastName = "Doe",
                            Phone = "123-456-7890",
                            TCKN = "12345678901"
                        },
                        new
                        {
                            Id = new Guid("50ae029a-3b3a-4136-b5f2-e8aa61a7ac75"),
                            Address = "456 Elm St",
                            CreatedDate = new DateTime(2024, 7, 27, 12, 30, 26, 243, DateTimeKind.Utc).AddTicks(6095),
                            DateOfBirth = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.doe@example.com",
                            FirstName = "Jane",
                            IsActive = true,
                            LastName = "Doe",
                            Phone = "987-654-3210",
                            TCKN = "10987654321"
                        });
                });

            modelBuilder.Entity("Booking.Entities.Models.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("17f418c1-eba4-4952-8bea-66e0af4faa03"),
                            Address = "789 Oak St",
                            CreatedDate = new DateTime(2024, 7, 27, 12, 30, 26, 243, DateTimeKind.Utc).AddTicks(6232),
                            Email = "contact@grandhotel.com",
                            IsActive = true,
                            Name = "Grand Hotel",
                            Phone = "555-123-4567",
                            Stars = 5
                        });
                });

            modelBuilder.Entity("Booking.Entities.Models.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("BookingID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookingID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Booking.Entities.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("RoomTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("HotelID");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Booking.Entities.Models.RoomType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3b3888d2-13fa-4f48-920a-f070e2fa5584"),
                            Capacity = 2,
                            CreatedDate = new DateTime(2024, 7, 27, 12, 30, 26, 243, DateTimeKind.Utc).AddTicks(6257),
                            Description = "A luxurious suite with a king-sized bed and ocean view.",
                            IsActive = true,
                            Name = "Deluxe Suite",
                            PricePerNight = 250.00m
                        },
                        new
                        {
                            Id = new Guid("68895d81-17b4-40ff-aa83-40918d98f023"),
                            Capacity = 2,
                            CreatedDate = new DateTime(2024, 7, 27, 12, 30, 26, 243, DateTimeKind.Utc).AddTicks(6263),
                            Description = "A comfortable room with all standard amenities.",
                            IsActive = true,
                            Name = "Standard Room",
                            PricePerNight = 100.00m
                        });
                });

            modelBuilder.Entity("Booking.Entities.Models.Staff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("HotelID");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Booking.Entities.Models.BookingGuest", b =>
                {
                    b.HasOne("Booking.Entities.Models.Bookings", "Booking")
                        .WithMany("BookingGuests")
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booking.Entities.Models.Guest", "Guest")
                        .WithMany("BookingGuests")
                        .HasForeignKey("GuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("Booking.Entities.Models.Bookings", b =>
                {
                    b.HasOne("Booking.Entities.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Booking.Entities.Models.Payment", b =>
                {
                    b.HasOne("Booking.Entities.Models.Bookings", "Booking")
                        .WithMany("Payments")
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("Booking.Entities.Models.Room", b =>
                {
                    b.HasOne("Booking.Entities.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booking.Entities.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("Booking.Entities.Models.Staff", b =>
                {
                    b.HasOne("Booking.Entities.Models.Hotel", "Hotel")
                        .WithMany("Staffs")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Booking.Entities.Models.Bookings", b =>
                {
                    b.Navigation("BookingGuests");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Booking.Entities.Models.Guest", b =>
                {
                    b.Navigation("BookingGuests");
                });

            modelBuilder.Entity("Booking.Entities.Models.Hotel", b =>
                {
                    b.Navigation("Rooms");

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("Booking.Entities.Models.Room", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Booking.Entities.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
