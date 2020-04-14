﻿// <auto-generated />
using System;
using CS321_W3D1_ToDoAPI_EF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CS321_W3D1_ToDoAPI_EF.Migrations
{
    [DbContext(typeof(ToDoContext))]
    partial class ToDoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("CS321_W3D1_ToDoAPI_EF.Models.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(80);

                    b.Property<DateTime>("DueDate");

                    b.Property<bool>("IsComplete");

                    b.HasKey("Id");

                    b.ToTable("ToDos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Laundry",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsComplete = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "Shopping",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsComplete = false
                        },
                        new
                        {
                            Id = 3,
                            Description = "Mow lawn",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsComplete = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
