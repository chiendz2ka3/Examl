﻿// <auto-generated />
using System;
using Exam.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exam.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230526170457_AddNewTable")]
    partial class AddNewTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Exam.Entities.ClassRoom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SubjectExamid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectExamid");

                    b.ToTable("ClassRoom");
                });

            modelBuilder.Entity("Exam.Entities.Faculty", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SubjectExamid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.HasIndex("SubjectExamid");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("Exam.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("SubjectExamid")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectExamid");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("Exam.Entities.SubjectExam", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("SubjectExam");
                });

            modelBuilder.Entity("Exam.Entities.ClassRoom", b =>
                {
                    b.HasOne("Exam.Entities.SubjectExam", null)
                        .WithMany("classroom")
                        .HasForeignKey("SubjectExamid");
                });

            modelBuilder.Entity("Exam.Entities.Faculty", b =>
                {
                    b.HasOne("Exam.Entities.SubjectExam", null)
                        .WithMany("faculties")
                        .HasForeignKey("SubjectExamid");
                });

            modelBuilder.Entity("Exam.Entities.Subject", b =>
                {
                    b.HasOne("Exam.Entities.SubjectExam", null)
                        .WithMany("lstsub")
                        .HasForeignKey("SubjectExamid");
                });

            modelBuilder.Entity("Exam.Entities.SubjectExam", b =>
                {
                    b.Navigation("classroom");

                    b.Navigation("faculties");

                    b.Navigation("lstsub");
                });
#pragma warning restore 612, 618
        }
    }
}
