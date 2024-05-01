﻿// <auto-generated />
using GharxpertAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GharxpertAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240429085714_AddWorkTypeTableToDb")]
    partial class AddWorkTypeTableToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GharxpertAPI.Models.Work", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("WorkDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WorkIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("WorkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("GharxpertAPI.Models.WorkType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("WorkDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkID")
                        .HasColumnType("int");

                    b.Property<string>("WorkImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Work_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("WorkID");

                    b.ToTable("WorkTypes");
                });

            modelBuilder.Entity("GharxpertAPI.Models.WorkType", b =>
                {
                    b.HasOne("GharxpertAPI.Models.Work", "Work")
                        .WithMany()
                        .HasForeignKey("WorkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Work");
                });
#pragma warning restore 612, 618
        }
    }
}