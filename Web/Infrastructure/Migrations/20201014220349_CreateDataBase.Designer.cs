﻿// <auto-generated />
using System;
using Infrastructure.DataTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(EF_Context))]
    [Migration("20201014220349_CreateDataBase")]
    partial class CreateDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("AppCore.Models.Entidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("texto")
                        .HasColumnType("TEXT");

                    b.Property<int>("valor")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Entidades");
                });
#pragma warning restore 612, 618
        }
    }
}
