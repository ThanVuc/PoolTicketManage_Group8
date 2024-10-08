﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoolTicketManagementAPI.Data;

#nullable disable

namespace PoolTicketManagementAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241001082309_fullUrl")]
    partial class fullUrl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PoolTicketManagementAPI.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<string>("BillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.HasIndex("UserId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.BusTicket", b =>
                {
                    b.Property<int>("BusTicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusTicketId"));

                    b.Property<string>("BusTicketName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PoolId")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.HasKey("BusTicketId");

                    b.HasIndex("PoolId");

                    b.ToTable("BusTickets");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.CartItem", b =>
                {
                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("TicketId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.EventOfPool", b =>
                {
                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("PoolId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EventId", "PoolId");

                    b.HasIndex("PoolId");

                    b.ToTable("EventOfPools");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.Pool", b =>
                {
                    b.Property<int>("PoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PoolId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PoolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PoolId");

                    b.ToTable("Pools");

                    b.HasData(
                        new
                        {
                            PoolId = 1,
                            Capacity = 75000,
                            Location = "Dien Bien Phu",
                            PoolName = "Children Pool",
                            Url = "http://localhost:5051/images/ho-boi-cho-tre-em.jpeg"
                        },
                        new
                        {
                            PoolId = 2,
                            Capacity = 75000,
                            Location = "Ha Huy Tap",
                            PoolName = "Family Pool",
                            Url = "http://localhost:5051/images/hoboigiadinh.jpg"
                        },
                        new
                        {
                            PoolId = 3,
                            Capacity = 75000,
                            Location = "Hoa Cuong 9",
                            PoolName = "WaterFall Pool",
                            Url = "http://localhost:5051/images/thac-nuoc-trang-tri-ho-boi-11.jpg"
                        },
                        new
                        {
                            PoolId = 4,
                            Capacity = 75000,
                            Location = "Ha Huy Tap",
                            PoolName = "Artificial Wave Pool",
                            Url = "http://localhost:5051/images/songnhantao.jpg"
                        });
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFAQ")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<long>("View")
                        .HasColumnType("bigint");

                    b.HasKey("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"));

                    b.Property<int>("PoolId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18)");

                    b.Property<string>("TicketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("datetime2");

                    b.HasKey("TicketId");

                    b.HasIndex("PoolId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            PoolId = 1,
                            Price = 99999m,
                            TicketName = "Children Pool Ticket",
                            Url = "http://localhost:5051/images/ho-boi-cho-tre-em.jpeg",
                            ValidFrom = new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1584),
                            ValidUntil = new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1601)
                        },
                        new
                        {
                            TicketId = 2,
                            PoolId = 2,
                            Price = 99999m,
                            TicketName = "Family Pool",
                            Url = "http://localhost:5051/images/hoboigiadinh.jpg",
                            ValidFrom = new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1615),
                            ValidUntil = new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1616)
                        },
                        new
                        {
                            TicketId = 3,
                            PoolId = 3,
                            Price = 99999m,
                            TicketName = "Waterfall Pool Ticket",
                            Url = "http://localhost:5051/images/thac-nuoc-trang-tri-ho-boi-11.jpg",
                            ValidFrom = new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1618),
                            ValidUntil = new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1619)
                        },
                        new
                        {
                            TicketId = 4,
                            PoolId = 4,
                            Price = 99999m,
                            TicketName = "Artifical Wave Pool Ticket",
                            Url = "http://localhost:5051/images/songnhantao.jpg",
                            ValidFrom = new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1621),
                            ValidUntil = new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1622)
                        });
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("CreatedDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.UserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AssignedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.Bill", b =>
                {
                    b.HasOne("PoolTicketManagementAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.BusTicket", b =>
                {
                    b.HasOne("PoolTicketManagementAPI.Models.Pool", "Pool")
                        .WithMany()
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pool");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.CartItem", b =>
                {
                    b.HasOne("PoolTicketManagementAPI.Models.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoolTicketManagementAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.EventOfPool", b =>
                {
                    b.HasOne("PoolTicketManagementAPI.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoolTicketManagementAPI.Models.Pool", "Pool")
                        .WithMany()
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Pool");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.Question", b =>
                {
                    b.HasOne("PoolTicketManagementAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.Ticket", b =>
                {
                    b.HasOne("PoolTicketManagementAPI.Models.Pool", "Pool")
                        .WithMany()
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pool");
                });

            modelBuilder.Entity("PoolTicketManagementAPI.Models.UserRole", b =>
                {
                    b.HasOne("PoolTicketManagementAPI.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoolTicketManagementAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
