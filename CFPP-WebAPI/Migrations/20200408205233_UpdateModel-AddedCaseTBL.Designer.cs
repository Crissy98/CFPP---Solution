﻿// <auto-generated />
using System;
using CFPP.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CFPP_WebAPI.Migrations
{
    [DbContext(typeof(CFPPDbContext))]
    [Migration("20200408205233_UpdateModel-AddedCaseTBL")]
    partial class UpdateModelAddedCaseTBL
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CFPP.Database.Entities.Case", b =>
                {
                    b.Property<int>("CaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerCode")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CaseTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("DPD")
                        .HasColumnType("int");

                    b.Property<decimal?>("OverdueBallance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalBallance")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CaseId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Case");
                });

            modelBuilder.Entity("CFPP.Database.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("VATCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("CustomerId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = 4,
                            CustomerName = "John Doe",
                            VATCode = "JD232456"
                        });
                });

            modelBuilder.Entity("CFPP.Database.Entities.CustomerDetails", b =>
                {
                    b.Property<int>("CustomerDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerDetailsId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerDetailsId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("CustomerDetails");
                });

            modelBuilder.Entity("CFPP.Database.Entities.Case", b =>
                {
                    b.HasOne("CFPP.Database.Entities.Customer", "customer")
                        .WithMany("Cases")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CFPP.Database.Entities.CustomerDetails", b =>
                {
                    b.HasOne("CFPP.Database.Entities.Customer", "customer")
                        .WithOne("customerDetails")
                        .HasForeignKey("CFPP.Database.Entities.CustomerDetails", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
