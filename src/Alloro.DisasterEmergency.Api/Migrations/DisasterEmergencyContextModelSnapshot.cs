﻿// <auto-generated />
using System;
using Alloro.DisasterEmergency.Api.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alloro.DisasterEmergency.Api.Migrations
{
    [DbContext(typeof(DisasterEmergencyContext))]
    partial class DisasterEmergencyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Alloro.DisasterEmergency.Api.Entities.Disaster", b =>
                {
                    b.Property<int>("DisasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisasterId"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisasterLevelId")
                        .HasColumnType("int");

                    b.Property<int>("DisasterTypeId")
                        .HasColumnType("int");

                    b.Property<double>("Lattitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("NotificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotificationUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int");

                    b.HasKey("DisasterId");

                    b.HasIndex("DisasterLevelId");

                    b.HasIndex("DisasterTypeId");

                    b.HasIndex("ResourceId");

                    b.ToTable("Disaster");
                });

            modelBuilder.Entity("Alloro.DisasterEmergency.Api.Entities.DisasterLevel", b =>
                {
                    b.Property<int>("DisasterLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisasterLevelId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Priority")
                        .HasColumnType("float");

                    b.HasKey("DisasterLevelId");

                    b.ToTable("DisasterLevel");
                });

            modelBuilder.Entity("Alloro.DisasterEmergency.Api.Entities.DisasterType", b =>
                {
                    b.Property<int>("DisasterTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisasterTypeId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisasterTypeId");

                    b.ToTable("DisasterType");
                });

            modelBuilder.Entity("Alloro.DisasterEmergency.Api.Entities.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResourceTypeId")
                        .HasColumnType("int");

                    b.HasKey("ResourceId");

                    b.HasIndex("ResourceTypeId");

                    b.ToTable("Resource");
                });

            modelBuilder.Entity("Alloro.DisasterEmergency.Api.Entities.ResourceType", b =>
                {
                    b.Property<int>("ResourceTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceTypeId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResourceTypeId");

                    b.ToTable("ResourceType");
                });

            modelBuilder.Entity("Alloro.DisasterEmergency.Api.Entities.Disaster", b =>
                {
                    b.HasOne("Alloro.DisasterEmergency.Api.Entities.DisasterLevel", "DisasterLevel")
                        .WithMany("Disasters")
                        .HasForeignKey("DisasterLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Alloro.DisasterEmergency.Api.Entities.DisasterType", "DisasterType")
                        .WithMany("Disasters")
                        .HasForeignKey("DisasterTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Alloro.DisasterEmergency.Api.Entities.Resource", "Resource")
                        .WithMany("Disasters")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DisasterLevel");

                    b.Navigation("DisasterType");

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("Alloro.DisasterEmergency.Api.Entities.Resource", b =>
                {
                    b.HasOne("Alloro.DisasterEmergency.Api.Entities.ResourceType", "ResourceType")
                        .WithMany("Resources")
                        .HasForeignKey("ResourceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ResourceType");
                });

            modelBuilder.Entity("Alloro.DisasterEmergency.Api.Entities.DisasterLevel", b =>
                {
                    b.Navigation("Disasters");
                });

            modelBuilder.Entity("Alloro.DisasterEmergency.Api.Entities.DisasterType", b =>
                {
                    b.Navigation("Disasters");
                });

            modelBuilder.Entity("Alloro.DisasterEmergency.Api.Entities.Resource", b =>
                {
                    b.Navigation("Disasters");
                });

            modelBuilder.Entity("Alloro.DisasterEmergency.Api.Entities.ResourceType", b =>
                {
                    b.Navigation("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}
