﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using primerparcial19.Data;

namespace primerparcial19.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("primerparcial19.Models.Inscripciones", b =>
                {
                    b.Property<int>("InscripcionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Disponibles")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Limite")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Semestre")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tomados")
                        .HasColumnType("INTEGER");

                    b.HasKey("InscripcionId");

                    b.ToTable("Incripcion");
                });
#pragma warning restore 612, 618
        }
    }
}
