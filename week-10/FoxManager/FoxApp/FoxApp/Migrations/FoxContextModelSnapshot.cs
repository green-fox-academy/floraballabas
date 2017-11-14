using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FoxApp.Entities;

namespace FoxApp.Migrations
{
    [DbContext(typeof(FoxContext))]
    partial class FoxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoxApp.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassName");

                    b.Property<string>("Technology");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("FoxApp.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassId");

                    b.Property<string>("Name");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FoxApp.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("PriorityLevel");

                    b.Property<int>("StudentId");

                    b.Property<string>("TaskName");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("FoxApp.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassId");

                    b.Property<string>("TeamName");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });
        }
    }
}
