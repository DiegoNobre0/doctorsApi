﻿// <auto-generated />
using System;
using DoctorAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorAPI.Migrations
{
    [DbContext(typeof(DoctorsContext))]
    [Migration("20230720125224_adicionarTabela")]
    partial class adicionarTabela
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoctorAPI.Models.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContraIndicacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Indicacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicamentoUso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModoDeUso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("NumeroDoses")
                        .HasColumnType("real");

                    b.Property<float?>("QuantidadeAmpolas")
                        .HasColumnType("real");

                    b.Property<string>("QuantidadeMg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("QuantidadeMgKg")
                        .HasColumnType("real");

                    b.Property<string>("QuantidadeMl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("QuantidadeSoro")
                        .HasColumnType("real");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dosagemTipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("DoctorAPI.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}