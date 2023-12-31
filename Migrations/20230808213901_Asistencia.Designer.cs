﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using iglesia.Data;

#nullable disable

namespace iglesia.Migrations
{
    [DbContext(typeof(TuDbContext))]
    [Migration("20230808213901_Asistencia")]
    partial class Asistencia
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("iglesia.Models.EventoModel", b =>
                {
                    b.Property<int>("ID_evento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID_evento"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Fecha")
                        .HasColumnType("timestamp with time zone");

                    b.Property<TimeSpan>("Hora_fin")
                        .HasColumnType("interval");

                    b.Property<TimeSpan>("Hora_inicio")
                        .HasColumnType("interval");

                    b.Property<double?>("Latitud")
                        .HasColumnType("double precision");

                    b.Property<double?>("Longitud")
                        .HasColumnType("double precision");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("ID_evento");

                    b.ToTable("EventosLiturgicos");
                });
#pragma warning restore 612, 618
        }
    }
}
