using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GoTApp.Entities;

namespace GoTApp.Migrations
{
    [DbContext(typeof(GoTCharacterContext))]
    partial class GoTCharacterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoTApp.Models.GoTCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsAlive");

                    b.Property<bool>("IsLikeable");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("GoTCharacters");
                });
        }
    }
}
