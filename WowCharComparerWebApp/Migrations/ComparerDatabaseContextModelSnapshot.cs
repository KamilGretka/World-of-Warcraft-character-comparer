﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WowCharComparerWebApp.Data.Database;

namespace WowCharComparerWebApp.Migrations
{
    [DbContext(typeof(ComparerDatabaseContext))]
    partial class ComparerDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WowCharComparerWebApp.Models.Achievement.AchievementCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("ID");

                    b.HasIndex("ID")
                        .IsUnique();

                    b.ToTable("AchievementCategory");
                });

            modelBuilder.Entity("WowCharComparerWebApp.Models.Achievement.AchievementsData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AchievementCategoryID");

                    b.Property<string>("Description");

                    b.Property<int>("FactionId");

                    b.Property<string>("Icon");

                    b.Property<int>("Points");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("AchievementCategoryID");

                    b.HasIndex("ID")
                        .IsUnique();

                    b.ToTable("AchievementsData");
                });

            modelBuilder.Entity("WowCharComparerWebApp.Models.BonusStats", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BonusStatsID");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("BonusStatsID")
                        .IsUnique();

                    b.ToTable("BonusStats");
                });

            modelBuilder.Entity("WowCharComparerWebApp.Models.Internal.APIClient", b =>
                {
                    b.Property<string>("ClientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientName")
                        .IsRequired();

                    b.Property<string>("ClientSecret")
                        .IsRequired();

                    b.Property<DateTime>("ValidationUntil");

                    b.HasKey("ClientID");

                    b.ToTable("APIClient");
                });

            modelBuilder.Entity("WowCharComparerWebApp.Models.Internal.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("IsOnline");

                    b.Property<DateTime>("LastLoginDate");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<Guid>("VerificationToken");

                    b.Property<bool>("Verified");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WowCharComparerWebApp.Models.Achievement.AchievementsData", b =>
                {
                    b.HasOne("WowCharComparerWebApp.Models.Achievement.AchievementCategory")
                        .WithMany("AchievementsData")
                        .HasForeignKey("AchievementCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
