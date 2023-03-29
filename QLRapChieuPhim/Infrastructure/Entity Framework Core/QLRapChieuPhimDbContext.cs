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

        public string DbPath { get; } =
            "Data Source=DESKTOP-5B19LU8\\SQLEXPRESS;Initial Catalog=QLRapChieuPhimDB;Integrated Security=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(DbPath);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LichChieu>()
                .HasKey(table => new { table.PhimId, table.RapId });

           // modelBuilder.Entity<KeHoach>().HasOne(record => record.MaCum)

            

        }

        public QLRapChieuPhimDbContext()
        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = System.IO.Path.Join(path, "blogging.db");
        }

    }

}


