﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParticipationMicroservice.DBContexts;

namespace ParticipationMicroservice.Migrations
{
    [DbContext(typeof(ParticipationContext))]
    [Migration("20220705125833_ParticipationMicroservice.Models.AddForeignKeys")]
    partial class ParticipationMicroserviceModelsAddForeignKeys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParticipationMicroservice.Model.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoOfSlots")
                        .HasColumnType("int");

                    b.Property<int?>("Sport")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.HasIndex("Sport");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ParticipationMicroservice.Model.Participation", b =>
                {
                    b.Property<int>("ParticipationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Event")
                        .HasColumnType("int");

                    b.Property<int?>("Sport")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ParticipationId");

                    b.HasIndex("Event");

                    b.HasIndex("Sport");

                    b.ToTable("Participations");
                });

            modelBuilder.Entity("ParticipationMicroservice.Model.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int?>("ParticipationId")
                        .HasColumnType("int");

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Sport")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("ParticipationId");

                    b.HasIndex("Sport");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("ParticipationMicroservice.Model.Sport", b =>
                {
                    b.Property<int>("SportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NoOfPlayers")
                        .HasColumnType("int");

                    b.Property<string>("SportName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sportType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportId");

                    b.ToTable("Sports");
                });

            modelBuilder.Entity("ParticipationMicroservice.Model.Event", b =>
                {
                    b.HasOne("ParticipationMicroservice.Model.Sport", "Sports")
                        .WithMany()
                        .HasForeignKey("Sport");
                });

            modelBuilder.Entity("ParticipationMicroservice.Model.Participation", b =>
                {
                    b.HasOne("ParticipationMicroservice.Model.Event", "Events")
                        .WithMany()
                        .HasForeignKey("Event");

                    b.HasOne("ParticipationMicroservice.Model.Sport", "Sports")
                        .WithMany()
                        .HasForeignKey("Sport");
                });

            modelBuilder.Entity("ParticipationMicroservice.Model.Player", b =>
                {
                    b.HasOne("ParticipationMicroservice.Model.Participation", null)
                        .WithMany("PlayerName")
                        .HasForeignKey("ParticipationId");

                    b.HasOne("ParticipationMicroservice.Model.Sport", "Sports")
                        .WithMany()
                        .HasForeignKey("Sport");
                });
#pragma warning restore 612, 618
        }
    }
}
