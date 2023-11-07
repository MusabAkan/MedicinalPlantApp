﻿// <auto-generated />
using System;
using MedicinalPlantApp.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedicinalPlantApp.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231106233325_deletecolumnCreateDate")]
    partial class deletecolumnCreateDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MedicinalPlantApp.Entities.Plant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PlantImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PlantImageId");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("MedicinalPlantApp.Entities.PlantImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PlantImages");
                });

            modelBuilder.Entity("MedicinalPlantApp.Entities.Plant", b =>
                {
                    b.HasOne("MedicinalPlantApp.Entities.PlantImage", "PlantImage")
                        .WithMany()
                        .HasForeignKey("PlantImageId");

                    b.Navigation("PlantImage");
                });
#pragma warning restore 612, 618
        }
    }
}