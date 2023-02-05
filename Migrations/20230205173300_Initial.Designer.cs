﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestingSQLRelationships.Data;

#nullable disable

namespace TestingSQLRelationships.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230205173300_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.CSInterest", b =>
                {
                    b.Property<int>("CSInterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CSInterestId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CSInterestId");

                    b.ToTable("CSInterests");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.CSInterestUser", b =>
                {
                    b.Property<string>("SlackId")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SlackId");

                    b.Property<int>("CSInterestId")
                        .HasColumnType("int");

                    b.HasKey("SlackId", "CSInterestId");

                    b.HasIndex("CSInterestId");

                    b.ToTable("CSInterestUsers");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.CareerPhase", b =>
                {
                    b.Property<int>("CareerPhaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CareerPhaseId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CareerPhaseId");

                    b.ToTable("CareerPhase");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.ExperienceLevel", b =>
                {
                    b.Property<int>("ExperienceLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExperienceLevelId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExperienceLevelId");

                    b.ToTable("ExperienceLevel");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.Hobby", b =>
                {
                    b.Property<int>("HobbyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HobbyId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HobbyId");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.HobbyUser", b =>
                {
                    b.Property<string>("SlackId")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SlackId");

                    b.Property<int>("HobbyId")
                        .HasColumnType("int");

                    b.HasKey("SlackId", "HobbyId");

                    b.HasIndex("HobbyId");

                    b.ToTable("HobbyUsers");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.Likes", b =>
                {
                    b.Property<string>("SlackId1")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Liker User");

                    b.Property<string>("SlackId2")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Liked User");

                    b.Property<bool>("IsMatch")
                        .HasColumnType("bit")
                        .HasColumnName("IsMatch");

                    b.HasKey("SlackId1", "SlackId2");

                    b.HasIndex("SlackId2");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.NaturalLanguage", b =>
                {
                    b.Property<int>("NaturalLanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NaturalLanguageId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NaturalLanguageId");

                    b.ToTable("NaturalLanguages");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.NaturalLanguageUser", b =>
                {
                    b.Property<string>("SlackId")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SlackId");

                    b.Property<int>("NaturalLanguageId")
                        .HasColumnType("int");

                    b.HasKey("SlackId", "NaturalLanguageId");

                    b.HasIndex("NaturalLanguageId");

                    b.ToTable("NaturalLanguageUsers");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.ProgrammingLanguage", b =>
                {
                    b.Property<int>("ProgrammingLanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgrammingLanguageId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgrammingLanguageId");

                    b.ToTable("ProgrammingLanguages");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.ProgrammingLanguageUser", b =>
                {
                    b.Property<string>("SlackId")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SlackId");

                    b.Property<int>("ProgrammingLanguageId")
                        .HasColumnType("int");

                    b.HasKey("SlackId", "ProgrammingLanguageId");

                    b.HasIndex("ProgrammingLanguageId");

                    b.ToTable("ProgrammingLanguageUsers");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("QuestionString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId")
                        .HasName("QuestionId");

                    b.HasIndex("QuestionId")
                        .IsUnique();

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.QuestionAnswerBlock", b =>
                {
                    b.Property<int>("QuestionAnswerBlockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionAnswerBlockId"));

                    b.Property<string>("AnswerString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionString")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SlackId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("QuestionAnswerBlockId")
                        .HasName("QuestionAnswerBlockId");

                    b.HasIndex("SlackId");

                    b.ToTable("QuestionAnswerBlocks");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.Rejections", b =>
                {
                    b.Property<string>("SlackId1")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Rejecting User");

                    b.Property<string>("SlackId2")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Rejected User");

                    b.HasKey("SlackId1", "SlackId2");

                    b.HasIndex("SlackId2");

                    b.ToTable("Rejections");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.User", b =>
                {
                    b.Property<string>("SlackId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("CareerPhaseId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("ExperienceLevelId")
                        .HasColumnType("int");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("SlackId")
                        .HasName("User_SlackId");

                    b.HasIndex("CareerPhaseId");

                    b.HasIndex("ExperienceLevelId");

                    b.HasIndex("GenderId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("SlackId")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TestingSQLRelationships.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TestingSQLRelationships.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestingSQLRelationships.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TestingSQLRelationships.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.CSInterestUser", b =>
                {
                    b.HasOne("TestingSQLRelationships.Models.CSInterest", "CSInterest")
                        .WithMany("CSInterestUsers")
                        .HasForeignKey("CSInterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestingSQLRelationships.Models.User", "User")
                        .WithMany("CSInterestUsers")
                        .HasForeignKey("SlackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CSInterest");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.HobbyUser", b =>
                {
                    b.HasOne("TestingSQLRelationships.Models.Hobby", "Hobby")
                        .WithMany("HobbyUsers")
                        .HasForeignKey("HobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestingSQLRelationships.Models.User", "User")
                        .WithMany("HobbyUsers")
                        .HasForeignKey("SlackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hobby");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.Likes", b =>
                {
                    b.HasOne("TestingSQLRelationships.Models.User", "User1")
                        .WithMany("UsersLiked")
                        .HasForeignKey("SlackId1")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TestingSQLRelationships.Models.User", "User2")
                        .WithMany("LikedBy")
                        .HasForeignKey("SlackId2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User1");

                    b.Navigation("User2");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.NaturalLanguageUser", b =>
                {
                    b.HasOne("TestingSQLRelationships.Models.NaturalLanguage", "NaturalLanguage")
                        .WithMany("NaturalLanguageUsers")
                        .HasForeignKey("NaturalLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestingSQLRelationships.Models.User", "User")
                        .WithMany("NaturalLanguageUsers")
                        .HasForeignKey("SlackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NaturalLanguage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.ProgrammingLanguageUser", b =>
                {
                    b.HasOne("TestingSQLRelationships.Models.ProgrammingLanguage", "ProgrammingLanguage")
                        .WithMany("ProgrammingLanguageUsers")
                        .HasForeignKey("ProgrammingLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestingSQLRelationships.Models.User", "User")
                        .WithMany("ProgrammingLanguageUsers")
                        .HasForeignKey("SlackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProgrammingLanguage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.QuestionAnswerBlock", b =>
                {
                    b.HasOne("TestingSQLRelationships.Models.User", "User")
                        .WithMany("QuestionAnswerBlocks")
                        .HasForeignKey("SlackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.Rejections", b =>
                {
                    b.HasOne("TestingSQLRelationships.Models.User", "User1")
                        .WithMany("UsersRejected")
                        .HasForeignKey("SlackId1")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TestingSQLRelationships.Models.User", "User2")
                        .WithMany("RejectedBy")
                        .HasForeignKey("SlackId2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User1");

                    b.Navigation("User2");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.User", b =>
                {
                    b.HasOne("TestingSQLRelationships.Models.CareerPhase", "CareerPhase")
                        .WithMany("Users")
                        .HasForeignKey("CareerPhaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestingSQLRelationships.Models.ExperienceLevel", "ExperienceLevel")
                        .WithMany("Users")
                        .HasForeignKey("ExperienceLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestingSQLRelationships.Models.Gender", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CareerPhase");

                    b.Navigation("ExperienceLevel");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.CSInterest", b =>
                {
                    b.Navigation("CSInterestUsers");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.CareerPhase", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.ExperienceLevel", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.Gender", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.Hobby", b =>
                {
                    b.Navigation("HobbyUsers");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.NaturalLanguage", b =>
                {
                    b.Navigation("NaturalLanguageUsers");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.ProgrammingLanguage", b =>
                {
                    b.Navigation("ProgrammingLanguageUsers");
                });

            modelBuilder.Entity("TestingSQLRelationships.Models.User", b =>
                {
                    b.Navigation("CSInterestUsers");

                    b.Navigation("HobbyUsers");

                    b.Navigation("LikedBy");

                    b.Navigation("NaturalLanguageUsers");

                    b.Navigation("ProgrammingLanguageUsers");

                    b.Navigation("QuestionAnswerBlocks");

                    b.Navigation("RejectedBy");

                    b.Navigation("UsersLiked");

                    b.Navigation("UsersRejected");
                });
#pragma warning restore 612, 618
        }
    }
}