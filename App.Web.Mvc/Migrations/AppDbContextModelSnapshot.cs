﻿// <auto-generated />
using App.Web.Mvc.App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.Web.Mvc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App.Web.Mvc.App.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Pizza"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Makarna"
                        });
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.CategoryPost", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("PostId1")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PostId1");

                    b.ToTable("CategoryPost");
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Page");
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PostTitle")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Post");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PostTitle = "Sağlıklı Yemekler",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            PostTitle = "Makarna Sosları",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.PostComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Yorum")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostComment");
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.PostImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostImage");
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Setting");
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "elif@gmail.com",
                            Password = "12345",
                            UserName = "Elif"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ayse@gmail.com",
                            Password = "23456",
                            UserName = "Ayşe"
                        });
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.CategoryPost", b =>
                {
                    b.HasOne("App.Web.Mvc.App.Entity.Category", "Category")
                        .WithMany("CategoryPosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Web.Mvc.App.Entity.Post", "Post")
                        .WithMany("CategoryPosts")
                        .HasForeignKey("PostId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.Post", b =>
                {
                    b.HasOne("App.Web.Mvc.App.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.PostComment", b =>
                {
                    b.HasOne("App.Web.Mvc.App.Entity.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.PostImage", b =>
                {
                    b.HasOne("App.Web.Mvc.App.Entity.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.Category", b =>
                {
                    b.Navigation("CategoryPosts");
                });

            modelBuilder.Entity("App.Web.Mvc.App.Entity.Post", b =>
                {
                    b.Navigation("CategoryPosts");
                });
#pragma warning restore 612, 618
        }
    }
}
