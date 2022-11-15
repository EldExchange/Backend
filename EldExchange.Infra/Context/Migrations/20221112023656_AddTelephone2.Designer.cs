﻿// <auto-generated />
using System;
using EldExchange.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EldExchange.Infra.Context.Migrations
{
    [DbContext(typeof(EldDbContext))]
    [Migration("20221112023656_AddTelephone2")]
    partial class AddTelephone2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EldExchange.Domain.Models.DALs.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Complement")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("address", (string)null);
                });

            modelBuilder.Entity("EldExchange.Domain.Models.DALs.Agency", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(18)
                        .IsUnicode(false)
                        .HasColumnType("char(18)")
                        .IsFixedLength();

                    b.Property<bool>("IsWorking")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("agency", (string)null);
                });

            modelBuilder.Entity("EldExchange.Domain.Models.DALs.Currency", b =>
                {
                    b.Property<string>("CurrencyCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CurrencyCode");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("EldExchange.Domain.Models.DALs.Telephone", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Number")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("RegionCode")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id", "Number", "RegionCode", "CountryCode");

                    b.HasIndex("Number", "RegionCode", "CountryCode")
                        .IsUnique();

                    b.ToTable("telephone", (string)null);
                });

            modelBuilder.Entity("EldExchange.Domain.Models.DALs.Address", b =>
                {
                    b.HasOne("EldExchange.Domain.Models.DALs.Agency", null)
                        .WithOne("Address")
                        .HasForeignKey("EldExchange.Domain.Models.DALs.Address", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EldExchange.Domain.Models.DALs.Telephone", b =>
                {
                    b.HasOne("EldExchange.Domain.Models.DALs.Agency", null)
                        .WithMany("Phones")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EldExchange.Domain.Models.DALs.Agency", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Phones");
                });
#pragma warning restore 612, 618
        }
    }
}
