﻿// <auto-generated />
using System;
using EventRegistrationSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventRegistrationSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220223165451_UPDATE_SEED_USER_AND_EVENT")]
    partial class UPDATE_SEED_USER_AND_EVENT
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EventRegistrationSystem.Models.Event", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = "5E03D00E-0F88-4F7C-A63D-A0763A3BB790",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4609),
                            Description = "ต้อนรับความสุขในช่วงต้นปี ด้วยการชวนทุกคนมาสัมผัสบรรยากาศสุดอบอุ่นที่ “จริงใจ มาร์เก็ต เชียงใหม่” แหล่งรวมสินค้าทำมือ อาหารพื้นเมือง และวัฒนธรรมท้องถิ่น จากพ่อกาดแม่กาดที่ตั้งอกตั้งใจสร้างสรรค์สินค้าทำมือ ปลูกผักปลอดสาร และปรุงรสอาหารพื้นเมืองให้สะอาด อร่อย เหมือนทำให้คนในครอบครัวได้อิ่มอร่อยอย่างสุขใจ",
                            EndDate = new DateTime(2022, 6, 3, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4597),
                            Latitude = 18.806058023549401,
                            Longitude = 98.996183226269395,
                            Name = "ช้อปงานคราฟต์ เสพงานศิลป์",
                            StartDate = new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4597),
                            Status = 1,
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4610)
                        },
                        new
                        {
                            Id = "FBF3749B-FA56-4EE7-BAA8-9B0046FE3F52",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4615),
                            Description = "Join us in moving Thai contemporary art scene forward with Art Move: A Fundraising Exhibition for Bangkok Art and Culture Centre 2022, and acquire contemporary artworks by 49 leading Thai artists.",
                            EndDate = new DateTime(2022, 9, 11, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4615),
                            Latitude = 13.746659899999999,
                            Longitude = 100.53029960000001,
                            Name = "Art Move : A Fundraising Exhibition for Bangkok Art and Culture Centre 2022",
                            StartDate = new DateTime(2022, 6, 3, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4614),
                            Status = 1,
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4616)
                        });
                });

            modelBuilder.Entity("EventRegistrationSystem.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "8E034006-5CED-4DF2-8C09-189EB890FBA2",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(3326),
                            Name = "ADMIN"
                        });
                });

            modelBuilder.Entity("EventRegistrationSystem.Models.Ticket", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TicketNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("EventRegistrationSystem.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "77705621-0CD5-4B80-80CD-61F6A66A040F",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4514),
                            Email = "ADMIN",
                            PasswordHash = new byte[] { 44, 4, 184, 239, 99, 156, 239, 218, 156, 227, 57, 59, 149, 162, 2, 112, 181, 164, 220, 249, 170, 185, 212, 9, 126, 169, 182, 133, 31, 220, 245, 173 },
                            PasswordSalt = new byte[] { 102, 53, 97, 98, 99, 100, 102, 49, 55, 99, 97, 53, 52, 55, 97, 52, 57, 102, 49, 52, 50, 54, 56, 48, 56, 56, 98, 100, 48, 48, 99, 101 },
                            Status = 1,
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4515)
                        });
                });

            modelBuilder.Entity("EventRegistrationSystem.Models.UserRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = "8AECC518-E481-48DD-9207-7F477BBB39DB",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4573),
                            RoleId = "8E034006-5CED-4DF2-8C09-189EB890FBA2",
                            Status = 0,
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 23, 16, 54, 50, 800, DateTimeKind.Utc).AddTicks(4573),
                            UserId = "77705621-0CD5-4B80-80CD-61F6A66A040F"
                        });
                });

            modelBuilder.Entity("EventRegistrationSystem.Models.Ticket", b =>
                {
                    b.HasOne("EventRegistrationSystem.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("EventRegistrationSystem.Models.UserRole", b =>
                {
                    b.HasOne("EventRegistrationSystem.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventRegistrationSystem.Models.User", "User")
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
