using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim.Infrastructure.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public List<TEntity> GetAll();
        public Task<TEntity?> GetById(string id);
        public Task AddAsync(TEntity entity);
        public void Update(TEntity entity);
        public Task Delete(string id);
    }
}
