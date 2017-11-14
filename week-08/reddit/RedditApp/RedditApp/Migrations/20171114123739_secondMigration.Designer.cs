using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RedditApp.Entities;

namespace RedditApp.Migrations
{
    [DbContext(typeof(ContentContext))]
    [Migration("20171114123739_secondMigration")]
    partial class secondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RedditApp.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Post");

                    b.Property<int>("Votes");

                    b.HasKey("Id");

                    b.ToTable("Contents");
                });
        }
    }
}
