using QLRapChieuPhim.Entities;
using QLRapChieuPhim.Infrastructure.Entity_Framework_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim.Infrastructure.Repositories
{
    public interface ICumRapRepository : IRepository<CumRap>
    {
    }

    public class CumRapRepository : Repository<CumRap>, ICumRapRepository
    {
        public CumRapRepository(QLRapChieuPhimDbContext qLRapChieuPhimDbContext) : base(qLRapChieuPhimDbContext)
        {

        }
    }
}
