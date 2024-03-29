﻿// <auto-generated />
using HierarchyGUI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HierarchyGUI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191011042118_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("HierarchyGUI.Models.Credential", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Admin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("UserName");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("HierarchyGUI.Models.Group", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Commander")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mission")
                        .HasColumnType("TEXT");

                    b.Property<string>("Motto")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("HierarchyGUI.Models.HeadquartersAF", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChiefOfStaff")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecAF")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("HeadquartersAF");
                });

            modelBuilder.Entity("HierarchyGUI.Models.Majcom", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Commander")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mission")
                        .HasColumnType("TEXT");

                    b.Property<string>("Motto")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Majcoms");
                });

            modelBuilder.Entity("HierarchyGUI.Models.NumberedAF", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Commander")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mission")
                        .HasColumnType("TEXT");

                    b.Property<string>("Motto")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("NumberedAFs");
                });

            modelBuilder.Entity("HierarchyGUI.Models.Squadron", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Commander")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mission")
                        .HasColumnType("TEXT");

                    b.Property<string>("Motto")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Squadrons");
                });

            modelBuilder.Entity("HierarchyGUI.Models.Wing", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Commander")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mission")
                        .HasColumnType("TEXT");

                    b.Property<string>("Motto")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Wings");
                });
#pragma warning restore 612, 618
        }
    }
}
