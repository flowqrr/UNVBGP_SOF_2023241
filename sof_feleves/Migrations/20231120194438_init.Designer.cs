﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using sof_feleves.Repository;

#nullable disable

namespace sof_feleves.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231120194438_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AppointmentSiteUser", b =>
                {
                    b.Property<string>("ApplicantsId")
                        .HasColumnType("text");

                    b.Property<string>("AppointmentsID")
                        .HasColumnType("text");

                    b.HasKey("ApplicantsId", "AppointmentsID");

                    b.HasIndex("AppointmentsID");

                    b.ToTable("AppointmentSiteUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("sof_feleves.Models.Appointment", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MaxApplicants")
                        .HasColumnType("integer");

                    b.Property<string>("ServiceID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("ServiceID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("sof_feleves.Models.Service", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("HostID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("HostID");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ID = "yoga_class1",
                            HostID = "yoga_host1",
                            Name = "Yoga class"
                        },
                        new
                        {
                            ID = "dance_class1",
                            HostID = "dance_host1",
                            Name = "Dance class"
                        },
                        new
                        {
                            ID = "nail_salon1",
                            HostID = "nail_host1",
                            Name = "Nail salon"
                        },
                        new
                        {
                            ID = "chiropractor1",
                            HostID = "chiropractor_host1",
                            Name = "Chiropractor"
                        });
                });

            modelBuilder.Entity("sof_feleves.Models.SiteUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("SurName")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "yoga_host1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3ab54ec8-43fa-4460-8e59-1bf4eb25de0e",
                            Email = "yoga@yoga.yoga",
                            EmailConfirmed = false,
                            FirstName = "Yoga",
                            LockoutEnabled = false,
                            NormalizedUserName = "YOGA",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "49fce046-55c5-45a2-b63b-98e5e20ec2d9",
                            SurName = "Master",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "dance_host1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f8083bd-8b9f-4177-83a0-0660fed2ad25",
                            Email = "dance@dance.dance",
                            EmailConfirmed = false,
                            FirstName = "Dance",
                            LockoutEnabled = false,
                            NormalizedUserName = "DANCE",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c1572c36-e0f2-47e6-994c-b17b53dd166f",
                            SurName = "Master",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "nail_host1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fff85fba-2672-4695-9522-dcdbeabe2250",
                            Email = "nail@nail.nail",
                            EmailConfirmed = false,
                            FirstName = "Nail",
                            LockoutEnabled = false,
                            NormalizedUserName = "NAIL",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "83493925-4102-4e25-af57-609509c34062",
                            SurName = "Master",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "chiropractor_host1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "02bd6c3f-27f3-4ebd-bec5-76e1f16f6c6c",
                            Email = "chiropractor@chiropractor.chiropractor",
                            EmailConfirmed = false,
                            FirstName = "Chiropractor",
                            LockoutEnabled = false,
                            NormalizedUserName = "CHIROPRACTOR",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "40936ace-219f-4435-a80a-6ed9b784083b",
                            SurName = "Master",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("AppointmentSiteUser", b =>
                {
                    b.HasOne("sof_feleves.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("ApplicantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sof_feleves.Models.Appointment", null)
                        .WithMany()
                        .HasForeignKey("AppointmentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("sof_feleves.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("sof_feleves.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sof_feleves.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("sof_feleves.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("sof_feleves.Models.Appointment", b =>
                {
                    b.HasOne("sof_feleves.Models.Service", "Service")
                        .WithMany("Appointments")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");
                });

            modelBuilder.Entity("sof_feleves.Models.Service", b =>
                {
                    b.HasOne("sof_feleves.Models.SiteUser", "Host")
                        .WithMany("HostedServices")
                        .HasForeignKey("HostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Host");
                });

            modelBuilder.Entity("sof_feleves.Models.Service", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("sof_feleves.Models.SiteUser", b =>
                {
                    b.Navigation("HostedServices");
                });
#pragma warning restore 612, 618
        }
    }
}
