﻿// <auto-generated />
using System;
using MVCalttest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCalttest.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240529121423_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("MVCalttest.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Column")
                        .HasColumnType("int");

                    b.Property<string>("ContentText")
                        .HasColumnType("text");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.Property<int>("TestDocId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestDocId");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("MVCalttest.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("MVCalttest.Models.RegressResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfCreate")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RegressResults");
                });

            modelBuilder.Entity("MVCalttest.Models.RegressTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Additional")
                        .HasColumnType("text");

                    b.Property<string>("Device")
                        .HasColumnType("text");

                    b.Property<string>("EnvironmentNew")
                        .HasColumnType("text");

                    b.Property<string>("EnvironmentOld")
                        .HasColumnType("text");

                    b.Property<string>("Themes")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RegressTemplates");
                });

            modelBuilder.Entity("MVCalttest.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("MVCalttest.Models.TestDoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Columns")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfCreate")
                        .HasColumnType("datetime");

                    b.Property<int>("Rows")
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<string>("Tags")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.HasIndex("UserId");

                    b.ToTable("TestDocs");
                });

            modelBuilder.Entity("MVCalttest.Models.TestPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfCreate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<int?>("TestDocId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TestDocId");

                    b.ToTable("TestPlans");
                });

            modelBuilder.Entity("MVCalttest.Models.TestPlanDoc", b =>
                {
                    b.Property<int>("TestPlanDocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<int>("TestDocId")
                        .HasColumnType("int");

                    b.Property<int>("TestPlanId")
                        .HasColumnType("int");

                    b.HasKey("TestPlanDocId");

                    b.HasIndex("TestDocId");

                    b.HasIndex("TestPlanId");

                    b.ToTable("TestPlanDocs");
                });

            modelBuilder.Entity("MVCalttest.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MVCalttest.Models.UserProject", b =>
                {
                    b.Property<int>("UserProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserProjectId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("UserProjects");
                });

            modelBuilder.Entity("MVCalttest.Models.Content", b =>
                {
                    b.HasOne("MVCalttest.Models.TestDoc", "TestDoc")
                        .WithMany("Contents")
                        .HasForeignKey("TestDocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TestDoc");
                });

            modelBuilder.Entity("MVCalttest.Models.RegressResult", b =>
                {
                    b.HasOne("MVCalttest.Models.User", "User")
                        .WithMany("RegressResults")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MVCalttest.Models.RegressTemplate", b =>
                {
                    b.HasOne("MVCalttest.Models.User", "User")
                        .WithMany("RegressTemplates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MVCalttest.Models.Section", b =>
                {
                    b.HasOne("MVCalttest.Models.Project", "Project")
                        .WithMany("Section")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("MVCalttest.Models.TestDoc", b =>
                {
                    b.HasOne("MVCalttest.Models.Section", "Section")
                        .WithMany("TestDocs")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCalttest.Models.User", "User")
                        .WithMany("TestDocs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MVCalttest.Models.TestPlan", b =>
                {
                    b.HasOne("MVCalttest.Models.TestDoc", "TestDoc")
                        .WithMany()
                        .HasForeignKey("TestDocId");

                    b.Navigation("TestDoc");
                });

            modelBuilder.Entity("MVCalttest.Models.TestPlanDoc", b =>
                {
                    b.HasOne("MVCalttest.Models.TestDoc", "TestDoc")
                        .WithMany("TestPlanDoc")
                        .HasForeignKey("TestDocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCalttest.Models.TestPlan", "TestPlan")
                        .WithMany("TestPlanDoc")
                        .HasForeignKey("TestPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TestDoc");

                    b.Navigation("TestPlan");
                });

            modelBuilder.Entity("MVCalttest.Models.UserProject", b =>
                {
                    b.HasOne("MVCalttest.Models.Project", "Project")
                        .WithMany("UserProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCalttest.Models.User", "User")
                        .WithMany("UserProjects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MVCalttest.Models.Project", b =>
                {
                    b.Navigation("Section");

                    b.Navigation("UserProjects");
                });

            modelBuilder.Entity("MVCalttest.Models.Section", b =>
                {
                    b.Navigation("TestDocs");
                });

            modelBuilder.Entity("MVCalttest.Models.TestDoc", b =>
                {
                    b.Navigation("Contents");

                    b.Navigation("TestPlanDoc");
                });

            modelBuilder.Entity("MVCalttest.Models.TestPlan", b =>
                {
                    b.Navigation("TestPlanDoc");
                });

            modelBuilder.Entity("MVCalttest.Models.User", b =>
                {
                    b.Navigation("RegressResults");

                    b.Navigation("RegressTemplates");

                    b.Navigation("TestDocs");

                    b.Navigation("UserProjects");
                });
#pragma warning restore 612, 618
        }
    }
}
