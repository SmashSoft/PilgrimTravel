﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Temples.Repository.DataContext;

namespace Temples.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Temples.DataEntities.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Address2")
                        .HasMaxLength(100);

                    b.Property<string>("Address3")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("Created");

                    b.Property<bool>("Deleted");

                    b.Property<string>("District");

                    b.Property<string>("State");

                    b.Property<string>("Taluk")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("Updated");

                    b.Property<int>("ZipCode")
                        .HasMaxLength(6);

                    b.HasKey("ID");

                    b.ToTable("Addresses");

                    b.HasData(
                        new { ID = 1, Address1 = "East Fort", Address2 = "Pahavangadi", Address3 = "", Created = new DateTime(2018, 12, 28, 18, 18, 52, 407, DateTimeKind.Local), Deleted = false, District = "Trivandrum", State = "Kerala", Taluk = "Trivandrum", ZipCode = 679001 }
                    );
                });

            modelBuilder.Entity("Temples.DataEntities.Models.Diety", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.Property<string>("DietyName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Features")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.Property<bool>("IsPrimary");

                    b.Property<int>("TempleID");

                    b.HasKey("ID");

                    b.HasIndex("TempleID");

                    b.ToTable("Dieties");

                    b.HasData(
                        new { ID = 1, Description = "Pazhavangadi Maha Ganapathi", DietyName = "Ganapathi", Features = "Very popular Ganesha Temple in Trivandrum", IsPrimary = true, TempleID = 1 }
                    );
                });

            modelBuilder.Entity("Temples.DataEntities.Models.Style", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Styles");

                    b.HasData(
                        new { ID = 1, Description = "Based on Architectural style", Name = "Architecture" }
                    );
                });

            modelBuilder.Entity("Temples.DataEntities.Models.Temple", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressID");

                    b.Property<DateTime?>("Created");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("Note");

                    b.Property<int>("StyleID");

                    b.Property<DateTime?>("Updated");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("StyleID");

                    b.ToTable("Temples");

                    b.HasData(
                        new { ID = 1, AddressID = 1, Created = new DateTime(2018, 12, 28, 18, 18, 52, 404, DateTimeKind.Local), Deleted = false, Name = "Pazhavangadi Ganapathi Temple", Note = "Managed by CRPF", StyleID = 1 }
                    );
                });

            modelBuilder.Entity("Temples.DataEntities.Models.TempleBlob", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created");

                    b.Property<bool>("Deleted");

                    b.Property<string>("History")
                        .IsRequired();

                    b.Property<string>("Importance")
                        .IsRequired();

                    b.Property<int>("TempleID");

                    b.Property<DateTime?>("Updated");

                    b.HasKey("ID");

                    b.HasIndex("TempleID");

                    b.ToTable("TempleBlobs");

                    b.HasData(
                        new { ID = 1, Created = new DateTime(2018, 12, 28, 18, 18, 52, 407, DateTimeKind.Local), Deleted = false, History = "Established in xxxx", Importance = "Important template in Trivandrum", TempleID = 1 }
                    );
                });

            modelBuilder.Entity("Temples.DataEntities.Models.TempleType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("ID");

                    b.ToTable("TempleTypes");

                    b.HasData(
                        new { ID = 1L, Description = "Managed by Private trust", Name = "Private" }
                    );
                });

            modelBuilder.Entity("Temples.Repository.DataContext.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Temples.Repository.DataContext.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Temples.Repository.DataContext.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Temples.Repository.DataContext.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Temples.Repository.DataContext.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Temples.DataEntities.Models.Diety", b =>
                {
                    b.HasOne("Temples.DataEntities.Models.Temple", "PrimaryTemple")
                        .WithMany()
                        .HasForeignKey("TempleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Temples.DataEntities.Models.Temple", b =>
                {
                    b.HasOne("Temples.DataEntities.Models.Address", "PrimaryAddress")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Temples.DataEntities.Models.Style", "PrimaryStyle")
                        .WithMany()
                        .HasForeignKey("StyleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Temples.DataEntities.Models.TempleBlob", b =>
                {
                    b.HasOne("Temples.DataEntities.Models.Temple", "PrimaryTemple")
                        .WithMany()
                        .HasForeignKey("TempleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
