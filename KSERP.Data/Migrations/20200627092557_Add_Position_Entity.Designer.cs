﻿// <auto-generated />
using System;
using KSERP.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KSERP.Data.Migrations
{
    [DbContext(typeof(KSERP_Dbcontext))]
    [Migration("20200627092557_Add_Position_Entity")]
    partial class Add_Position_Entity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KSERP.Data.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("KSERP.Data.Entities.Car.CarCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("CarCategories");
                });

            modelBuilder.Entity("KSERP.Data.Entities.Car.CarCategoryColor", b =>
                {
                    b.Property<int>("CarCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CarColorId")
                        .HasColumnType("int");

                    b.HasKey("CarCategoryId", "CarColorId");

                    b.HasIndex("CarColorId");

                    b.ToTable("CarCategoryColors");
                });

            modelBuilder.Entity("KSERP.Data.Entities.Car.CarColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HEXCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)")
                        .HasMaxLength(7);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CarColors");
                });

            modelBuilder.Entity("KSERP.Data.Entities.Car.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Engine")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("GearBox")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("MY")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SalesPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValue(0L);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("YOM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("CarModels");
                });

            modelBuilder.Entity("KSERP.Data.Entities.Car.CarModelCategory", b =>
                {
                    b.Property<int>("CarCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CarModelId")
                        .HasColumnType("int");

                    b.HasKey("CarCategoryId", "CarModelId");

                    b.HasIndex("CarModelId");

                    b.ToTable("CarModelCategories");
                });

            modelBuilder.Entity("KSERP.Data.Entities.Car.CarModelColor", b =>
                {
                    b.Property<int>("CarColorId")
                        .HasColumnType("int");

                    b.Property<int>("CarModelId")
                        .HasColumnType("int");

                    b.HasKey("CarColorId", "CarModelId");

                    b.HasIndex("CarModelId");

                    b.ToTable("CarModelColors");
                });

            modelBuilder.Entity("KSERP.Data.Entities.Oganization.Dealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("CompanyRepresentBy")
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.Property<string>("CompanyTax")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("RepresentativePosition")
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.Property<string>("SalesHotline")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("ServicesHotline")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Dealers");
                });

            modelBuilder.Entity("KSERP.Data.Entities.Oganization.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DealerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("DealerId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("KSERP.Data.Entities.Oganization.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ParentId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("KSERP.Data.Entities.Car.CarCategory", b =>
                {
                    b.HasOne("KSERP.Data.Entities.Brand", "Brand")
                        .WithMany("CarCategories")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KSERP.Data.Entities.Car.CarCategoryColor", b =>
                {
                    b.HasOne("KSERP.Data.Entities.Car.CarCategory", "CarCategory")
                        .WithMany("CarCategoryColors")
                        .HasForeignKey("CarCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KSERP.Data.Entities.Car.CarColor", "CarColor")
                        .WithMany("CarCategoryColors")
                        .HasForeignKey("CarColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KSERP.Data.Entities.Car.CarModelCategory", b =>
                {
                    b.HasOne("KSERP.Data.Entities.Car.CarCategory", "CarCategory")
                        .WithMany("CarModelCategories")
                        .HasForeignKey("CarCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KSERP.Data.Entities.Car.CarModel", "CarModel")
                        .WithMany("CarModelCategories")
                        .HasForeignKey("CarModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KSERP.Data.Entities.Car.CarModelColor", b =>
                {
                    b.HasOne("KSERP.Data.Entities.Car.CarColor", "CarColor")
                        .WithMany("CarModelColors")
                        .HasForeignKey("CarColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KSERP.Data.Entities.Car.CarModel", "CarModel")
                        .WithMany("CarModelColors")
                        .HasForeignKey("CarModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KSERP.Data.Entities.Oganization.Dealer", b =>
                {
                    b.HasOne("KSERP.Data.Entities.Brand", "Brand")
                        .WithMany("Dealers")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KSERP.Data.Entities.Oganization.Department", b =>
                {
                    b.HasOne("KSERP.Data.Entities.Oganization.Dealer", "Dealer")
                        .WithMany("Departments")
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KSERP.Data.Entities.Oganization.Position", b =>
                {
                    b.HasOne("KSERP.Data.Entities.Oganization.Department", "Department")
                        .WithMany("Positions")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KSERP.Data.Entities.Oganization.Position", "Parent")
                        .WithMany("Childs")
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}
