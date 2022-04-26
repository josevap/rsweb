﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RSWEB_Proekt.Data;

#nullable disable

namespace RSWEB_Proekt.Migrations
{
    [DbContext(typeof(RSWEB_ProektContext))]
    partial class RSWEB_ProektContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RSWEB_Proekt.Models.Predmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.Property<string>("Programa")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("Semestar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("RSWEB_Proekt.Models.PredmetProfesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PredmetId")
                        .HasColumnType("int");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PredmetId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("PredmetProfesor");
                });

            modelBuilder.Entity("RSWEB_Proekt.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AkademskiRang")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StepenNaObrazovanie")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("RSWEB_Proekt.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Index")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("RSWEB_Proekt.Models.StudentPredmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PredmetId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PredmetId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentPredmet");
                });

            modelBuilder.Entity("RSWEB_Proekt.Models.Predmet", b =>
                {
                    b.HasOne("RSWEB_Proekt.Models.Profesor", null)
                        .WithMany("Predmets")
                        .HasForeignKey("ProfesorId");
                });

            modelBuilder.Entity("RSWEB_Proekt.Models.PredmetProfesor", b =>
                {
                    b.HasOne("RSWEB_Proekt.Models.Predmet", "Predmet")
                        .WithMany("Profesors")
                        .HasForeignKey("PredmetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RSWEB_Proekt.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predmet");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("RSWEB_Proekt.Models.StudentPredmet", b =>
                {
                    b.HasOne("RSWEB_Proekt.Models.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RSWEB_Proekt.Models.Student", "Student")
                        .WithMany("Predmets")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predmet");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("RSWEB_Proekt.Models.Predmet", b =>
                {
                    b.Navigation("Profesors");
                });

            modelBuilder.Entity("RSWEB_Proekt.Models.Profesor", b =>
                {
                    b.Navigation("Predmets");
                });

            modelBuilder.Entity("RSWEB_Proekt.Models.Student", b =>
                {
                    b.Navigation("Predmets");
                });
#pragma warning restore 612, 618
        }
    }
}