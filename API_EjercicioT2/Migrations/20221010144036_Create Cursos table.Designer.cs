﻿// <auto-generated />
using System;
using API_EjercicioT2.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_EjercicioT2.Migrations
{
    [DbContext(typeof(EjercicioT2DBContext))]
    [Migration("20221010144036_Create Cursos table")]
    partial class CreateCursostable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API_EjercicioT2.Models.DataModels.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Createby")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasMaxLength(560)
                        .HasColumnType("nvarchar(560)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Objectives")
                        .IsRequired()
                        .HasMaxLength(560)
                        .HasColumnType("nvarchar(560)");

                    b.Property<string>("PublicObjective")
                        .IsRequired()
                        .HasMaxLength(560)
                        .HasColumnType("nvarchar(560)");

                    b.Property<string>("Requirements")
                        .IsRequired()
                        .HasMaxLength(560)
                        .HasColumnType("nvarchar(560)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(280)
                        .HasColumnType("nvarchar(280)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });
#pragma warning restore 612, 618
        }
    }
}
