using DataAccessLayer.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> _dbset;
         CoreDbContext _ctx;

        
        public Repository()
        {
            _ctx = new CoreDbContext();
            _dbset = _ctx.Set<T>();
        }
        public async Task<bool> Delete(int id)
        {
            var findId = await GetById(id);
            _ctx.Remove<T>(findId);
           var result= await _ctx.SaveChangesAsync();
            if (result > 0)
                return true;
            return false;
         
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbset.ToListAsync<T>();
        }

        public async Task<T> GetById(int id)
        {
            var result= await _ctx.FindAsync<T>(id);
            return result;
        }

        public async Task<bool> Insert(T entity)
        {
            _ctx.Add<T>(entity);
            var result=await _ctx.SaveChangesAsync();
            if (result > 0)
                return true;
            return false;
        }

        public async Task<bool> Update(T entity)
        {
           
            _ctx.Entry<T>(entity).State = EntityState.Modified;
            int result = await _ctx.SaveChangesAsync();
            if (result > 0)
                return true;
            return false;
        }
    }
}
