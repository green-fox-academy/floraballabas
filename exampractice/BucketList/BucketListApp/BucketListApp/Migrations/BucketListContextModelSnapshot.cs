using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BucketListApp.Entities;

namespace BucketListApp.Migrations
{
    [DbContext(typeof(BucketListContext))]
    partial class BucketListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BucketListApp.Models.BucketList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity");

                    b.Property<bool>("IsAchieved");

                    b.Property<bool>("IsPlanned");

                    b.HasKey("Id");

                    b.ToTable("BucketLists");
                });
        }
    }
}
