using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GotCharacterApp.Entities;

namespace GotCharacterApp.Migrations
{
    [DbContext(typeof(GotCharacterContext))]
    [Migration("20171103104103_initialGot")]
    partial class initialGot
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GotCharacterApp.Models.GotCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsAlive");

                    b.Property<bool>("IsFavourite");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("GotCharacters");
                });
        }
    }
}
