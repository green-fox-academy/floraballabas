using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RedditApp.Entities;

namespace RedditApp.Migrations
{
    [DbContext(typeof(ContentContext))]
    [Migration("20171115101106_redditMigration")]
    partial class redditMigration
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

                    b.Property<string>("Url");

                    b.Property<int>("Votes");

                    b.HasKey("Id");

                    b.ToTable("Contents");
                });
        }
    }
}
