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
        protected IRepository<SystemLog> _repository;
        private CoreDbContext _ctx;
        public r_systemLogs(IRepository<SystemLog> repository,CoreDbContext ctx)
        {
            _repository = repository;
            _ctx = ctx;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SystemLog>> GetAll()
        {
           return await  _repository.GetAll();
        }

        public Task<SystemLog> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(SystemLog entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(SystemLog entity)
        {
            throw new NotImplementedException();
        }
    }
}
