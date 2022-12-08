﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NatureBlog.Infrastructure;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DestinationUser", b =>
                {
                    b.Property<Guid>("VisitedDestinationsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VisitorsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VisitedDestinationsId", "VisitorsId");

                    b.HasIndex("VisitorsId");

                    b.ToTable("DestinationUser");
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Destination", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Creator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(560)
                        .HasColumnType("nvarchar(560)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("RatingScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Destinations", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Rating", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DestinationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RatingValue")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Ratings", (string)null);
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cordinates")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Regions", (string)null);
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HikingSkill")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.HikingTrail", b =>
                {
                    b.HasBaseType("NatureBlog.Domain.Models.Destination");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<int>("HikingDuration")
                        .HasColumnType("int");

                    b.ToTable("HikingTrails", (string)null);
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Park", b =>
                {
                    b.HasBaseType("NatureBlog.Domain.Models.Destination");

                    b.Property<bool>("HasPlayground")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDogFriendly")
                        .HasColumnType("bit");

                    b.ToTable("Parks", (string)null);
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Seaside", b =>
                {
                    b.HasBaseType("NatureBlog.Domain.Models.Destination");

                    b.Property<bool>("IsGuarded")
                        .HasColumnType("bit");

                    b.Property<bool>("OffersUmbrella")
                        .HasColumnType("bit");

                    b.Property<double>("UmbrellaPrice")
                        .HasColumnType("float");

                    b.ToTable("Seasides", (string)null);
                });

            modelBuilder.Entity("DestinationUser", b =>
                {
                    b.HasOne("NatureBlog.Domain.Models.Destination", null)
                        .WithMany()
                        .HasForeignKey("VisitedDestinationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NatureBlog.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("VisitorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Comment", b =>
                {
                    b.HasOne("NatureBlog.Domain.Models.Destination", "Destination")
                        .WithMany("Comments")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NatureBlog.Domain.Models.User", "Creator")
                        .WithMany("Comments")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Destination", b =>
                {
                    b.HasOne("NatureBlog.Domain.Models.Region", "Region")
                        .WithMany("Destinations")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Rating", b =>
                {
                    b.HasOne("NatureBlog.Domain.Models.Destination", null)
                        .WithMany("Ratings")
                        .HasForeignKey("DestinationId");
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.HikingTrail", b =>
                {
                    b.HasOne("NatureBlog.Domain.Models.Destination", null)
                        .WithOne()
                        .HasForeignKey("NatureBlog.Domain.Models.HikingTrail", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Park", b =>
                {
                    b.HasOne("NatureBlog.Domain.Models.Destination", null)
                        .WithOne()
                        .HasForeignKey("NatureBlog.Domain.Models.Park", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Seaside", b =>
                {
                    b.HasOne("NatureBlog.Domain.Models.Destination", null)
                        .WithOne()
                        .HasForeignKey("NatureBlog.Domain.Models.Seaside", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Destination", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.Region", b =>
                {
                    b.Navigation("Destinations");
                });

            modelBuilder.Entity("NatureBlog.Domain.Models.User", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
