﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuicDataServer.Data;

namespace QuicPerformanceDataServer.Migrations
{
    [DbContext(typeof(PerformanceContext))]
    [Migration("20200914154603_HPSData")]
    partial class HPSData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuicDataServer.Models.Db.DbHpsTestRecord", b =>
                {
                    b.Property<int>("DbHpsTestRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommitHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DbMachineId")
                        .HasColumnType("int");

                    b.Property<int>("DbPlatformId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TestDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DbHpsTestRecordId");

                    b.HasIndex("DbMachineId");

                    b.HasIndex("DbPlatformId");

                    b.ToTable("HpsTestRecords");
                });

            modelBuilder.Entity("QuicDataServer.Models.Db.DbMachine", b =>
                {
                    b.Property<int>("DbMachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPUInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemoryInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NicInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DbMachineId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("QuicDataServer.Models.Db.DbPlatform", b =>
                {
                    b.Property<int>("DbPlatformId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PlatformName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DbPlatformId");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("QuicDataServer.Models.Db.DbRpsTestRecord", b =>
                {
                    b.Property<int>("DbRpsTestRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommitHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConnectionCount")
                        .HasColumnType("int");

                    b.Property<int>("DbMachineId")
                        .HasColumnType("int");

                    b.Property<int>("DbPlatformId")
                        .HasColumnType("int");

                    b.Property<int>("ParallelRequests")
                        .HasColumnType("int");

                    b.Property<int>("RequestSize")
                        .HasColumnType("int");

                    b.Property<int>("ResponseSize")
                        .HasColumnType("int");

                    b.Property<DateTime>("TestDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DbRpsTestRecordId");

                    b.HasIndex("DbMachineId");

                    b.HasIndex("DbPlatformId");

                    b.ToTable("RpsTestRecords");
                });

            modelBuilder.Entity("QuicDataServer.Models.Db.DbTest", b =>
                {
                    b.Property<int>("DbTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DbPlatformId")
                        .HasColumnType("int");

                    b.Property<string>("TestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DbTestId");

                    b.HasIndex("DbPlatformId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("QuicDataServer.Models.Db.DbTestRecord", b =>
                {
                    b.Property<int>("DbTestRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommitHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DbMachineId")
                        .HasColumnType("int");

                    b.Property<int>("DbTestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TestDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DbTestRecordId");

                    b.HasIndex("DbMachineId");

                    b.HasIndex("DbTestId");

                    b.ToTable("TestRecords");
                });

            modelBuilder.Entity("QuicDataServer.Models.Db.DbThroughputTestRecord", b =>
                {
                    b.Property<int>("DbThroughputTestRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommitHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DbMachineId")
                        .HasColumnType("int");

                    b.Property<int>("DbPlatformId")
                        .HasColumnType("int");

                    b.Property<bool>("Encryption")
                        .HasColumnType("bit");

                    b.Property<bool>("Loopback")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfStreams")
                        .HasColumnType("int");

                    b.Property<bool>("SendBuffering")
                        .HasColumnType("bit");

                    b.Property<bool>("ServerToClient")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TestDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DbThroughputTestRecordId");

                    b.HasIndex("DbMachineId");

                    b.HasIndex("DbPlatformId");

                    b.ToTable("ThroughputTestRecords");
                });

            modelBuilder.Entity("QuicDataServer.Models.Db.DbHpsTestRecord", b =>
                {
                    b.HasOne("QuicDataServer.Models.Db.DbMachine", null)
                        .WithMany("HpsTestRecords")
                        .HasForeignKey("DbMachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuicDataServer.Models.Db.DbPlatform", null)
                        .WithMany("HpsTests")
                        .HasForeignKey("DbPlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("QuicDataServer.Models.Db.HpsTestResult", "TestResults", b1 =>
                        {
                            b1.Property<int>("DbHpsTestRecordId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<double>("Result")
                                .HasColumnType("float");

                            b1.HasKey("DbHpsTestRecordId", "Id");

                            b1.ToTable("HpsTestResult");

                            b1.WithOwner()
                                .HasForeignKey("DbHpsTestRecordId");
                        });
                });

            modelBuilder.Entity("QuicDataServer.Models.Db.DbRpsTestRecord", b =>
                {
                    b.HasOne("QuicDataServer.Models.Db.DbMachine", null)
                        .WithMany("RpsTestRecords")
                        .HasForeignKey("DbMachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuicDataServer.Models.Db.DbPlatform", null)
                        .WithMany("RpsTests")
                        .HasForeignKey("DbPlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("QuicDataServer.Models.Db.RpsTestResult", "TestResults", b1 =>
                        {
                            b1.Property<int>("DbRpsTestRecordId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<double>("Result")
                                .HasColumnType("float");

                            b1.HasKey("DbRpsTestRecordId", "Id");

                            b1.ToTable("RpsTestResult");

                            b1.WithOwner()
                                .HasForeignKey("DbRpsTestRecordId");
                        });
                });

            modelBuilder.Entity("QuicDataServer.Models.Db.DbTest", b =>
                {
                    b.HasOne("QuicDataServer.Models.Db.DbPlatform", null)
                        .WithMany("Tests")
                        .HasForeignKey("DbPlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuicDataServer.Models.Db.DbTestRecord", b =>
                {
                    b.HasOne("QuicDataServer.Models.Db.DbMachine", null)
                        .WithMany("TestRecords")
                        .HasForeignKey("DbMachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuicDataServer.Models.Db.DbTest", null)
                        .WithMany("TestRecords")
                        .HasForeignKey("DbTestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("QuicDataServer.Models.Db.TestResult", "TestResults", b1 =>
                        {
                            b1.Property<int>("DbTestRecordId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<double>("Result")
                                .HasColumnType("float");

                            b1.HasKey("DbTestRecordId", "Id");

                            b1.ToTable("TestResult");

                            b1.WithOwner()
                                .HasForeignKey("DbTestRecordId");
                        });
                });

            modelBuilder.Entity("QuicDataServer.Models.Db.DbThroughputTestRecord", b =>
                {
                    b.HasOne("QuicDataServer.Models.Db.DbMachine", null)
                        .WithMany("ThroughputTestRecords")
                        .HasForeignKey("DbMachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuicDataServer.Models.Db.DbPlatform", null)
                        .WithMany("ThroughputTests")
                        .HasForeignKey("DbPlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("QuicDataServer.Models.Db.ThroughputTestResult", "TestResults", b1 =>
                        {
                            b1.Property<int>("DbThroughputTestRecordId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<double>("Result")
                                .HasColumnType("float");

                            b1.HasKey("DbThroughputTestRecordId", "Id");

                            b1.ToTable("ThroughputTestResult");

                            b1.WithOwner()
                                .HasForeignKey("DbThroughputTestRecordId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}