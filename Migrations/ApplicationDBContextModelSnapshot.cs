﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using demo.Data;

namespace demo.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("demo.Models.ChuNhiem", b =>
                {
                    b.Property<string>("MaGv")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeacherName")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenLop")
                        .HasColumnType("TEXT");

                    b.HasKey("MaGv");

                    b.HasIndex("PersonID");

                    b.ToTable("ChuNhiem");
                });

            modelBuilder.Entity("demo.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PPhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("demo.Models.HoaDon", b =>
                {
                    b.Property<int>("HoaDonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.HasKey("HoaDonID");

                    b.HasIndex("PersonID");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("demo.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("demo.Models.Person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonCode")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("demo.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("demo.Models.Student", b =>
                {
                    b.HasBaseType("demo.Models.Person");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("University")
                        .HasColumnType("TEXT");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("demo.Models.Teacher", b =>
                {
                    b.HasBaseType("demo.Models.Person");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT")
                        .HasColumnName("Teacher_Address");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT")
                        .HasColumnName("Teacher_PhoneNumber");

                    b.Property<string>("University")
                        .HasColumnType("TEXT")
                        .HasColumnName("Teacher_University");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("demo.Models.ChuNhiem", b =>
                {
                    b.HasOne("demo.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonID");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("demo.Models.HoaDon", b =>
                {
                    b.HasOne("demo.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonID");

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
