﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManager.Data;

#nullable disable

namespace TaskManager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240430120218_createTableMyTask")]
    partial class createTableMyTask
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("TaskManager.Model.MyTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDone")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MyTasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 4, 30, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2621),
                            Deadline = new DateTime(2024, 5, 3, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2662),
                            Description = "Test 01",
                            IsDone = false,
                            Order = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 5, 7, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2666),
                            Deadline = new DateTime(2024, 5, 14, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2668),
                            Description = "Test 02",
                            IsDone = false,
                            Order = 2
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 5, 20, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2671),
                            Deadline = new DateTime(2024, 5, 25, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2672),
                            Description = "Test 03",
                            IsDone = true,
                            Order = 3
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2024, 5, 30, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2675),
                            Deadline = new DateTime(2024, 6, 30, 14, 2, 18, 505, DateTimeKind.Local).AddTicks(2679),
                            Description = "Test 04",
                            IsDone = false,
                            Order = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
