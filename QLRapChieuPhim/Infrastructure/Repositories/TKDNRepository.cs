using QLRapChieuPhim.Entities;
using QLRapChieuPhim.Infrastructure.Entity_Framework_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim.Infrastructure.Repositories
{


    public class TKDNRepository : Repository<TaiKhoanDangNhap>
    {
        public TKDNRepository(QLRapChieuPhimDbContext qLRapChieuPhimDbContext) : base(qLRapChieuPhimDbContext)
        {
        }

        public TaiKhoanDangNhap? Login(string username, string password)
        {
            var tk = _qLRapChieuPhimDbContext.TaiKhoanDangNhaps.FirstOrDefault(x => x.MatKhau == password && x.MaNV == username);
            return tk;
        }

    }
}
