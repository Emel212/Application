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
        protected IRepository<Values> _repository;
        CoreDbContext _ctx;
        public r_values(IRepository<Values> repository)
        {
            _repository = repository;
            _ctx = new CoreDbContext();
        }
        public Task<bool> Delete(int id)
        {
          return  _repository.Delete(id);
            
        }

        public Task<List<Values>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Values> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Task<bool> Insert(Values entity)
        {
            return _repository.Insert(entity);
        }

        public async Task<List<Values>> TableView()
        {
            var query2 = from col in _ctx.Columns join val in _ctx.Values on col.Id equals val.ColumnId where col.IsVisible == true orderby col.Order ascending select val;
            return await query2.ToListAsync();
        }

        public Task<bool> Update(Values entity)
        {
            return _repository.Update(entity);
        }
    }
}
