using Microsoft.EntityFrameworkCore;
using QLRapChieuPhim.Entities;
using System;
using System.Collections.Generic;

namespace QLRapChieuPhim.Infrastructure.Entity_Framework_Core
{
    public class QLRapChieuPhimDbContext : DbContext
    {
        public DbSet<CumRap> CumRaps { get; set; }
        public DbSet<KeHoach> KeHoachs { get; set; }
        public DbSet<LichChieu> LichChieus { get; set; }
        public DbSet<Phim> Phims { get; set; }
        public DbSet<PhimTheLoaiPhu> PhimTheLoaiPhus { get; set; }
        public DbSet<Rap> Raps { get; set; }
        public DbSet<SuatChieu> Suats { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        public string DbPath { get; } =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLRapChieuPhimDB;Integrated Security=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(DbPath);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LichChieu>(b =>
            {
                b.ToTable("LichChieu");
                b.HasOne<Phim>().WithMany().HasForeignKey(g => g.MaPhim).IsRequired();
                b.HasOne<Rap>().WithMany().HasForeignKey(g => g.MaRap).IsRequired();
                b.Property(x => x.NgayChieu).IsRequired();
                b.Property(x => x.ChuoiMaSuat).IsRequired().HasMaxLength(100);

                b.HasKey(record => new { record.MaPhim, record.MaRap });
            });

            modelBuilder.Entity<CumRap>(b =>
            {
                b.ToTable("CumRap");
                b.Property(x => x.TenCum).IsRequired().HasMaxLength(50);
                b.Property(x => x.DiaChi).IsRequired().HasMaxLength(100);
                b.HasKey(x => x.MaCum);
            });

            modelBuilder.Entity<Rap>(b =>
            {
                b.ToTable("Rap");
                b.HasOne<CumRap>().WithMany().HasForeignKey(g => g.MaCum).IsRequired();
                b.Property(x => x.TongGhe).IsRequired();
                b.HasKey(x => x.MaRap);
            });
            modelBuilder.Entity<Phim>(b =>
            {
                b.ToTable("Phim");
                b.HasOne<TheLoai>().WithMany().HasForeignKey(x => x.MaTheLoaiChinh).IsRequired();
                b.Property(x => x.ThoiLuong).IsRequired();
                b.Property(x => x.TenPhim).IsRequired();
                b.Property(x => x.CoLa3D).IsRequired();
                b.HasKey(x => x.MaPhim);
            });

            modelBuilder.Entity<KeHoach>(b =>
            {
                b.ToTable("KeHoach");
                b.HasOne<CumRap>().WithMany().HasForeignKey(x => x.MaCum).IsRequired();
                b.HasOne<Phim>().WithMany().HasForeignKey(x => x.MaPhim).IsRequired(); ;
                b.Property(x => x.NgayKetThuc).IsRequired();
                b.Property(x => x.NgayKhoiChieu).IsRequired();
                b.HasKey(x => x.Id);
            });
             modelBuilder.Entity<PhimTheLoaiPhu>(b =>
            {
                b.ToTable("PhimTheLoaiPhu");
                b.HasOne<Phim>().WithMany().HasForeignKey(x => x.MaPhim).IsRequired();
                b.HasOne<TheLoai>().WithMany().HasForeignKey(x => x.MaTheLoai).IsRequired();
                b.HasKey(record => new { record.MaTheLoai, record.MaPhim });

            })
                ; modelBuilder.Entity<SuatChieu>(b =>
            {
                b.ToTable("SuatChieu");

                b.Property(x => x.GioBatDau).IsRequired();
                b.Property(x => x.PhutBatDau).IsRequired();
                b.HasKey(x => x.MaSuat);
            });
             modelBuilder.Entity<TheLoai>(b =>
            {
                b.ToTable("TheLoai");
                b.Property(x => x.TenTheLoai).IsRequired();
                b.HasKey(x => x.MaTheLoai);

            });
            

         



            //modelBuilder.Entity<Phim>().ToTable("Phim")
            //    .HasKey(record => record.MaPhim);

            //modelBuilder.Entity<PhimTheLoaiPhu>().ToTable("PhimTheLoaiPhu")
            //    .HasKey(record => record.MaPhim);



            //modelBuilder.Entity<SuatChieu>().ToTable("SuatChieu")
            //    .HasKey(record => record.MaSuat);

            //modelBuilder.Entity<TheLoai>().ToTable("TheLoai")
            //    .HasKey(record => record.MaTheLoai);
        }

        public QLRapChieuPhimDbContext()
        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = System.IO.Path.Join(path, "blogging.db");
        }

    }

}


