﻿// <auto-generated />
using System;
using EventManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventManagement.Migrations
{
    [DbContext(typeof(EventDb))]
    [Migration("20191203124233_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventLib.Credential", b =>
                {
                    b.Property<int>("CredentialId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Eid");

                    b.Property<string>("Password");

                    b.Property<int>("Rid");

                    b.Property<string>("Username");

                    b.HasKey("CredentialId");

                    b.HasIndex("Eid")
                        .IsUnique();

                    b.HasIndex("Rid")
                        .IsUnique();

                    b.ToTable("Credential");
                });

            modelBuilder.Entity("EventLib.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptName");

                    b.HasKey("DeptId");

                    b.HasIndex("DeptId")
                        .IsUnique();

                    b.ToTable("Department");
                });

            modelBuilder.Entity("EventLib.Employee", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeptId");

                    b.Property<string>("EemailId");

                    b.Property<string>("Name");

                    b.HasKey("Eid");

                    b.HasIndex("DeptId");

                    b.HasIndex("Eid")
                        .IsUnique();

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EventLib.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventDesc");

                    b.Property<DateTime>("EventEndDate");

                    b.Property<string>("EventName");

                    b.Property<DateTime>("EventStartDate");

                    b.Property<bool>("Status");

                    b.Property<bool>("Type");

                    b.HasKey("EventId");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.ToTable("Event");
                });

            modelBuilder.Entity("EventLib.EventParticipant", b =>
                {
                    b.Property<int>("EventId");

                    b.Property<int>("DeptId");

                    b.HasKey("EventId", "DeptId");

                    b.ToTable("EventParticipant");
                });

            modelBuilder.Entity("EventLib.Meeting", b =>
                {
                    b.Property<int>("MId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EId");

                    b.Property<DateTime>("EndTime");

                    b.Property<DateTime>("MDate");

                    b.Property<string>("MName");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("MId");

                    b.HasIndex("EId");

                    b.HasIndex("MId")
                        .IsUnique();

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("EventLib.MeetingParticipant", b =>
                {
                    b.Property<int>("MId");

                    b.Property<int>("EmpId");

                    b.HasKey("MId", "EmpId");

                    b.ToTable("MeetingParticipant");
                });

            modelBuilder.Entity("EventLib.Registration", b =>
                {
                    b.Property<int>("Regid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Eid");

                    b.Property<string>("EventId");

                    b.HasKey("Regid");

                    b.HasIndex("Regid")
                        .IsUnique();

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("EventLib.Role", b =>
                {
                    b.Property<int>("Rid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("User");

                    b.HasKey("Rid");

                    b.HasIndex("Rid")
                        .IsUnique();

                    b.ToTable("Role");
                });

            modelBuilder.Entity("EventLib.Credential", b =>
                {
                    b.HasOne("EventLib.Employee", "Employee")
                        .WithOne("Credential")
                        .HasForeignKey("EventLib.Credential", "Eid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventLib.Role", "Roles")
                        .WithOne("Credentials")
                        .HasForeignKey("EventLib.Credential", "Rid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventLib.Employee", b =>
                {
                    b.HasOne("EventLib.Department")
                        .WithMany("Employees")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventLib.Meeting", b =>
                {
                    b.HasOne("EventLib.Employee")
                        .WithMany("Meetings")
                        .HasForeignKey("EId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
