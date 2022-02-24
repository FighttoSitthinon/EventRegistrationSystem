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
    [Migration("20220224051056_UPDATE_SEED_TICKET")]
    partial class UPDATE_SEED_TICKET
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
                            Id = "533FEFD0-49FF-4E7F-8A72-8CF5073A3177",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1112),
                            Description = "ต้อนรับความสุขในช่วงต้นปี ด้วยการชวนทุกคนมาสัมผัสบรรยากาศสุดอบอุ่นที่ “จริงใจ มาร์เก็ต เชียงใหม่” แหล่งรวมสินค้าทำมือ อาหารพื้นเมือง และวัฒนธรรมท้องถิ่น จากพ่อกาดแม่กาดที่ตั้งอกตั้งใจสร้างสรรค์สินค้าทำมือ ปลูกผักปลอดสาร และปรุงรสอาหารพื้นเมืองให้สะอาด อร่อย เหมือนทำให้คนในครอบครัวได้อิ่มอร่อยอย่างสุขใจ",
                            EndDate = new DateTime(2022, 6, 4, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1100),
                            Latitude = 18.806058023549401,
                            Longitude = 98.996183226269395,
                            Name = "ช้อปงานคราฟต์ เสพงานศิลป์",
                            StartDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1099),
                            Status = 1,
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1113)
                        },
                        new
                        {
                            Id = "5C8F38F5-5DFE-4F5D-8006-F9106A04A978",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1134),
                            Description = "Join us in moving Thai contemporary art scene forward with Art Move: A Fundraising Exhibition for Bangkok Art and Culture Centre 2022, and acquire contemporary artworks by 49 leading Thai artists.",
                            EndDate = new DateTime(2022, 9, 12, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1129),
                            Latitude = 13.746659899999999,
                            Longitude = 100.53029960000001,
                            Name = "Art Move : A Fundraising Exhibition for Bangkok Art and Culture Centre 2022",
                            StartDate = new DateTime(2022, 6, 4, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1128),
                            Status = 1,
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1136)
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
                            Id = "2234597B-5CA5-414E-9A49-47C5E9D1BC9D",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 170, DateTimeKind.Utc).AddTicks(9572),
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
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = "1B83A892-06D0-4333-9E9B-7EFE159D55BE",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1223),
                            Email = "test1@test01.com",
                            EventId = "533FEFD0-49FF-4E7F-8A72-8CF5073A3177",
                            PhoneNumber = "021234567",
                            Status = 1,
                            TicketNumber = "7D393E6F072D44C",
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1225)
                        },
                        new
                        {
                            Id = "2C6482F0-CAEA-470F-8A0C-57C427B60BB4",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1378),
                            Email = "test2@test02.com",
                            EventId = "533FEFD0-49FF-4E7F-8A72-8CF5073A3177",
                            PhoneNumber = "021256788",
                            Status = 1,
                            TicketNumber = "37C093A113E346E",
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1379)
                        },
                        new
                        {
                            Id = "AF8503CC-37C0-4215-A810-73D9FC3ADA11",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1404),
                            Email = "test1@test01.com",
                            EventId = "5C8F38F5-5DFE-4F5D-8006-F9106A04A978",
                            PhoneNumber = "021234567",
                            Status = 1,
                            TicketNumber = "1E257458D8584A1",
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1405)
                        },
                        new
                        {
                            Id = "6A4E74FE-9930-4A1B-BECE-73BFEC01D970",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1425),
                            Email = "test2@test02.com",
                            EventId = "5C8F38F5-5DFE-4F5D-8006-F9106A04A978",
                            PhoneNumber = "021256788",
                            Status = 1,
                            TicketNumber = "FD7BEBCDB4DD403",
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1426)
                        });
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
                            Id = "1F71117E-AA5B-4A55-8BA5-916AC95825F6",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1000),
                            Email = "ADMIN",
                            PasswordHash = new byte[] { 71, 55, 243, 250, 95, 196, 120, 236, 3, 80, 236, 11, 174, 89, 202, 43, 97, 222, 127, 152, 253, 181, 16, 123, 25, 144, 128, 124, 99, 105, 176, 193 },
                            PasswordSalt = new byte[] { 102, 98, 52, 101, 48, 48, 49, 100, 52, 56, 100, 100, 52, 50, 54, 98, 57, 56, 98, 53, 101, 99, 98, 54, 99, 48, 57, 57, 49, 99, 50, 57 },
                            Status = 1,
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1002)
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
                            Id = "595B7B06-1A94-4B56-880A-161398C19491",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1059),
                            RoleId = "2234597B-5CA5-414E-9A49-47C5E9D1BC9D",
                            Status = 0,
                            UpdatedBy = "SYSTEM",
                            UpdatedDate = new DateTime(2022, 2, 24, 5, 10, 56, 171, DateTimeKind.Utc).AddTicks(1060),
                            UserId = "1F71117E-AA5B-4A55-8BA5-916AC95825F6"
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