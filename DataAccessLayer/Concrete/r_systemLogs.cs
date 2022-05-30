using DataAccessLayer.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class r_systemLogs : IsystemLogs
    {
        protected IRepository<SystemLogs> _repository;
        CoreDbContext _ctx;
        public r_systemLogs(IRepository<SystemLogs> repository)
        {
            _repository = repository;
            _ctx = new CoreDbContext();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SystemLogs>> GetAll()
        {
           return await  _repository.GetAll();
        }

        public Task<SystemLogs> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(SystemLogs entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(SystemLogs entity)
        {
            throw new NotImplementedException();
        }
    }
}
