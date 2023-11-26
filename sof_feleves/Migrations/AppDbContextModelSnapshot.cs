﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using sof_feleves.Repository;

#nullable disable

namespace sof_feleves.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "d137f1d3-bd11-4e13-a162-e0a2235eeacb",
                            Name = "Host",
                            NormalizedName = "HOST"
                        },
                        new
                        {
                            Id = "0",
                            ConcurrencyStamp = "6b96fdf3-72d5-42bf-998f-3183e9d0f0d9",
                            Name = "Guest",
                            NormalizedName = "GUEST"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "yoga_host1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "dance_host1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "nail_host1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "chiropractor_host1",
                            RoleId = "1"
                        });
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

            modelBuilder.Entity("sof_feleves.Models.Post", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("ImageContentType")
                        .HasColumnType("text");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("bytea");

                    b.Property<string>("ServiceID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("ID");

                    b.HasIndex("ServiceID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("sof_feleves.Models.Service", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("HostID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

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

                    b.Property<string>("ProfilePicContentType")
                        .HasColumnType("text");

                    b.Property<byte[]>("ProfilePicData")
                        .HasColumnType("bytea");

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
                            ConcurrencyStamp = "d4be014c-7710-4d55-b1ba-61a8ae1e41ed",
                            Email = "yoga@yoga.yoga",
                            EmailConfirmed = false,
                            FirstName = "Yoga",
                            LockoutEnabled = false,
                            NormalizedUserName = "YOGA",
                            PasswordHash = "AQAAAAEAACcQAAAAEN0xXEZG3rhLPCOayV/4j2l/x4sIQOvPTpkw2U4MBT4/o0vTGXFHPDHG2neOHMBxzg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bca54161-20e8-487a-a01a-e3a1266437fb",
                            SurName = "Master",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "dance_host1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7704cfe8-050e-477b-b275-7731b160d073",
                            Email = "dance@dance.dance",
                            EmailConfirmed = false,
                            FirstName = "Dance",
                            LockoutEnabled = false,
                            NormalizedUserName = "DANCE",
                            PasswordHash = "AQAAAAEAACcQAAAAEGbOtHofS9DogjoDpZ6V6dlb2Wl6vEFEaEDgrW+RcyRgLXJbVPpdI/aKgdmreGCC+w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ba2cfa75-5d5b-4cd1-8252-f164f16ed908",
                            SurName = "Master",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "nail_host1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "69024b12-39e0-4d5a-ab12-7855b377ea10",
                            Email = "nail@nail.nail",
                            EmailConfirmed = false,
                            FirstName = "Nail",
                            LockoutEnabled = false,
                            NormalizedUserName = "NAIL",
                            PasswordHash = "AQAAAAEAACcQAAAAEFzdsFDqGX3zBPlqxbE8G58bzksJUtFgeE75gKQDiEzWk0ku3ni64UIFdTANQigrpw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "955b52bb-46cc-4013-a57d-4b52a05dedb4",
                            SurName = "Master",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "chiropractor_host1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6b20dfab-6141-478c-b80f-adb0d6e4156f",
                            Email = "chiropractor@chiropractor.chiropractor",
                            EmailConfirmed = false,
                            FirstName = "Chiropractor",
                            LockoutEnabled = false,
                            NormalizedUserName = "CHIROPRACTOR",
                            PasswordHash = "AQAAAAEAACcQAAAAECmTgg38qlzvUtK91Lq8N7XK0ObwFMB0LfFUM7G5v762ZXFmQgxAYYTj6qpuvwJaIQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "24a85fb3-80eb-4fdb-b739-33162a37ffac",
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

            modelBuilder.Entity("sof_feleves.Models.Post", b =>
                {
                    b.HasOne("sof_feleves.Models.Service", "Service")
                        .WithMany("Posts")
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

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("sof_feleves.Models.SiteUser", b =>
                {
                    b.Navigation("HostedServices");
                });
#pragma warning restore 612, 618
        }
    }
}
