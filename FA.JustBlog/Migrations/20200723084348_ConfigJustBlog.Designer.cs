﻿// <auto-generated />
using System;
using FA.JustBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FA.JustBlog.Migrations
{
    [DbContext(typeof(JustBlogContext))]
    [Migration("20200723084348_ConfigJustBlog")]
    partial class ConfigJustBlog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-preview.7.20365.15");

            modelBuilder.Entity("FA.JustBlog.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FA.JustBlog.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostContent")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("FA.JustBlog.Models.PostTagMap", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTagMaps");
                });

            modelBuilder.Entity("FA.JustBlog.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("FA.JustBlog.Models.Post", b =>
                {
                    b.HasOne("FA.JustBlog.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("FA.JustBlog.Models.PostTagMap", b =>
                {
                    b.HasOne("FA.JustBlog.Models.Post", null)
                        .WithMany("PostTagMaps")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.JustBlog.Models.Tag", null)
                        .WithMany("PostTagMaps")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
