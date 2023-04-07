﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLRapChieuPhim.Infrastructure.Entity_Framework_Core;

#nullable disable

namespace QLRapChieuPhim.Migrations
{
    [DbContext(typeof(QLRapChieuPhimDbContext))]
    [Migration("20230403060709_modify2")]
    partial class modify2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QLRapChieuPhim.Entities.CumRap", b =>
                {
                    b.Property<string>("MaCum")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenCum")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaCum");

                    b.ToTable("CumRap", (string)null);
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.KeHoach", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MaCum")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MaPhim")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKhoiChieu")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MaCum");

                    b.HasIndex("MaPhim");

                    b.ToTable("KeHoach", (string)null);
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.LichChieu", b =>
                {
                    b.Property<string>("MaPhim")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaRap")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("ChuoiMaSuat")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgayChieu")
                        .HasColumnType("datetime2");

                    b.HasKey("MaPhim", "MaRap");

                    b.HasIndex("MaRap");

                    b.ToTable("LichChieu", (string)null);
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.Phim", b =>
                {
                    b.Property<string>("MaPhim")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("CoLa3D")
                        .HasColumnType("bit");

                    b.Property<bool>("CoLongTieng")
                        .HasColumnType("bit");

                    b.Property<string>("MaTheLoaiChinh")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("TenPhim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ThoiLuong")
                        .HasColumnType("int");

                    b.HasKey("MaPhim");

                    b.HasIndex("MaTheLoaiChinh");

                    b.ToTable("Phim", (string)null);
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.PhimTheLoaiPhu", b =>
                {
                    b.Property<string>("MaTheLoai")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MaPhim")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("MaTheLoai", "MaPhim");

                    b.HasIndex("MaPhim");

                    b.ToTable("PhimTheLoaiPhu", (string)null);
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.Rap", b =>
                {
                    b.Property<string>("MaRap")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MaCum")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("TongGhe")
                        .HasColumnType("int");

                    b.HasKey("MaRap");

                    b.HasIndex("MaCum");

                    b.ToTable("Rap", (string)null);
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.SuatChieu", b =>
                {
                    b.Property<string>("MaSuat")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("GioBatDau")
                        .HasColumnType("int");

                    b.Property<int>("PhutBatDau")
                        .HasColumnType("int");

                    b.HasKey("MaSuat");

                    b.ToTable("SuatChieu", (string)null);
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.TheLoai", b =>
                {
                    b.Property<string>("MaTheLoai")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("TenTheLoai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaTheLoai");

                    b.ToTable("TheLoai", (string)null);
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.KeHoach", b =>
                {
                    b.HasOne("QLRapChieuPhim.Entities.CumRap", null)
                        .WithMany()
                        .HasForeignKey("MaCum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLRapChieuPhim.Entities.Phim", null)
                        .WithMany()
                        .HasForeignKey("MaPhim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.LichChieu", b =>
                {
                    b.HasOne("QLRapChieuPhim.Entities.Phim", null)
                        .WithMany()
                        .HasForeignKey("MaPhim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLRapChieuPhim.Entities.Rap", null)
                        .WithMany()
                        .HasForeignKey("MaRap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.Phim", b =>
                {
                    b.HasOne("QLRapChieuPhim.Entities.TheLoai", null)
                        .WithMany()
                        .HasForeignKey("MaTheLoaiChinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.PhimTheLoaiPhu", b =>
                {
                    b.HasOne("QLRapChieuPhim.Entities.Phim", null)
                        .WithMany()
                        .HasForeignKey("MaPhim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLRapChieuPhim.Entities.TheLoai", null)
                        .WithMany()
                        .HasForeignKey("MaTheLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QLRapChieuPhim.Entities.Rap", b =>
                {
                    b.HasOne("QLRapChieuPhim.Entities.CumRap", null)
                        .WithMany()
                        .HasForeignKey("MaCum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
