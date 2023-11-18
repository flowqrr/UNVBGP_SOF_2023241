﻿// <auto-generated />
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
    [Migration("20231118202843_identity")]
    partial class identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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
#pragma warning restore 612, 618
        }
    }
}
