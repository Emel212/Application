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
    public class r_column : IColumns
    {
        protected IRepository<Column> _repository;
        CoreDbContext _ctx;
        public r_column(IRepository<Column> repository)
        {
            _repository = repository;
            _ctx = new CoreDbContext();
        }

        public async Task<bool> ChangeColumnOrder(string direction, int id)
        {
           
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<List<Column>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<List<Column>> GetAllColumns()
        {
           var result= from column in _ctx.Columns  orderby column.Order ascending select column;
            return await result.ToListAsync();
        }

        public async Task<Column> GetById(int id)
        {
            var result= await _repository.GetById(id);
            return result;
        }
        
        public async Task<List<Column>> GetVisibleColumns()
        {
            var query=from column in _ctx.Columns where column.IsVisible==true  orderby column.Order ascending select column ;
             return await query.ToListAsync();
                      
        }

       

        public async Task<bool> Insert(Column entity)
        {
            return  await _repository.Insert(entity);
        }

        public async Task<bool> UpdateColumns(int id,Column entity)
        {
            var record = _ctx.Find<Column>(id);
            record.IsVisible = entity.IsVisible;
            record.Name = entity.Name;
            record.Order = entity.Order;
          
            var result = await _ctx.SaveChangesAsync();
            if(result>0)
            return true;
            return false;

           // return await _repository.Update(entity);
        }

        public Task<bool> Update(Column entity)
        {
            throw new NotImplementedException();
        }
    }
}
