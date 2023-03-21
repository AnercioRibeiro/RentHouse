﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentHouseAPI.Data;

#nullable disable

namespace RentHouseAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230321163113_AddMigrationToDB")]
    partial class AddMigrationToDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("RentHouseAPI.Models.County", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Counties");
                });

            modelBuilder.Entity("RentHouseAPI.Models.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("RentHouseAPI.Models.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CountyId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .HasColumnType("TEXT");

                    b.Property<string>("Division")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Elevator")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Floor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Identifier")
                        .HasColumnType("TEXT");

                    b.Property<string>("Latitude")
                        .HasColumnType("TEXT");

                    b.Property<string>("Longitude")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentPeriodicy")
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PublicationCountyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PublicationProvinceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tipology")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CountyId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("RentHouseAPI.Models.Publication", b =>
                {
                    b.HasOne("RentHouseAPI.Models.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyId");

                    b.HasOne("RentHouseAPI.Models.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId");

                    b.Navigation("County");

                    b.Navigation("Province");
                });
#pragma warning restore 612, 618
        }
    }
}