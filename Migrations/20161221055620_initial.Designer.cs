using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ConferenceBarrel.Models;

namespace ConferenceBarrel.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20161221055620_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("ConferenceBarrel.Models.Conference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<decimal>("TicketeVlaue");

                    b.HasKey("Id");

                    b.ToTable("Conferences");
                });

            modelBuilder.Entity("ConferenceBarrel.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ConferenceId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ConferenceId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("ConferenceBarrel.Models.Session", b =>
                {
                    b.HasOne("ConferenceBarrel.Models.Conference", "Conference")
                        .WithMany("Sessions")
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
