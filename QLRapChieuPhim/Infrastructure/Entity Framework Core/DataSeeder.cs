using QLRapChieuPhim.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim.Infrastructure.Entity_Framework_Core
{
    public class DataSeeder
    {
        public static void SeedCumRap(QLRapChieuPhimDbContext context)
        {
            if (!context.CumRaps.Any())
            {
                var cumraplist = new List<CumRap>
                {
                    new CumRap { MaCum = "1",TenCum = "Afghanistan" },
                    new CumRap {MaCum = "2", TenCum = "Albania" },
                    new CumRap { MaCum = "3",TenCum = "Algeria" },
                    new CumRap { MaCum = "4",TenCum = "Andorra" },
                    new CumRap { MaCum = "5",TenCum = "Angola" },
                };
                context.AddRange(cumraplist);
                context.SaveChanges();
            } 
            var cumraplist1 = new List<TheLoai>
                {
                    new TheLoai { MaTheLoai = "1", TenTheLoai = "Afghanistan" },
                    new TheLoai { MaTheLoai = "2", TenTheLoai = "Albania" },
                    new TheLoai { MaTheLoai = "3", TenTheLoai = "Algeria" },
                    new TheLoai { MaTheLoai = "4", TenTheLoai = "Andorra" },
                    new TheLoai { MaTheLoai = "5", TenTheLoai = "Angola" },
                };
                context.AddRange(cumraplist1);
                context.SaveChanges();
            }
        }
    }
