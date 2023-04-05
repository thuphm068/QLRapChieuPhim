using Microsoft.EntityFrameworkCore;
using QLRapChieuPhim.Entities;
using QLRapChieuPhim.Infrastructure.Entity_Framework_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly QLRapChieuPhimDbContext _qLRapChieuPhimDbContext;
        protected Repository(QLRapChieuPhimDbContext qLRapChieuPhimDbContext)
        {
            _qLRapChieuPhimDbContext = qLRapChieuPhimDbContext;

            //if (_qLRapChieuPhimDbContext != null)
            //    _qLRapChieuPhimDbContext = qLRapChieuPhimDbContext;
            //else 
            //    _qLRapChieuPhimDbContext = new QLRapChieuPhimDbContext();
        }

        public List<TEntity> GetAll()
        {
            return _qLRapChieuPhimDbContext.Set<TEntity>().ToList();
        }
        public async Task<TEntity?> GetById(string id)
        {
            return await _qLRapChieuPhimDbContext.Set<TEntity>().FindAsync(id);
        }
        public async Task AddAsync(TEntity entity)
        {
            try
            {
                var result = await _qLRapChieuPhimDbContext.Set<TEntity>().AddAsync(entity);

                _qLRapChieuPhimDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(TEntity entity)
        {
            try
            {
                var updateEntity = _qLRapChieuPhimDbContext.Set<TEntity>().Update(entity);
                _qLRapChieuPhimDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task Delete(string id)
        {
            try
            {
                var deleteRecord = await this.GetById(id);

                _qLRapChieuPhimDbContext.Set<TEntity>().Remove(deleteRecord);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
