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
    public class r_values : IValues
    {
        protected IRepository<Value> _repository;
        private CoreDbContext _ctx;
        public r_values(IRepository<Value> repository,CoreDbContext ctx)
        {
            _repository = repository;
            _ctx = ctx;
           
        }
        public Task<bool> Delete(int id)
        {
          return  _repository.Delete(id);
            
        }

        public Task<List<Value>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Value> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Task<bool> Insert(Value entity)
        {
            return _repository.Insert(entity);
        }

        public async Task<List<Value>> TableView()
        {
            var query2 = from col in _ctx.Columns join val in _ctx.Values on col.Id equals val.ColumnId where col.IsVisible == true orderby col.Order select val;
            return await query2.ToListAsync();

        }
        
     

        public Task<bool> Update(Value entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateValue(int id, Value entity)
        {

            var record = _ctx.Find<Value>(id);
            record.Value1 = entity.Value1;

            var result = await _ctx.SaveChangesAsync();
            if (result > 0)
                return true;
            return false;

        }
    }
}
