using DataAccessLayer.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class r_records : IRecord
    {
        protected IRepository<Record> _repository;
        public r_records(IRepository<Record> repository)
        {
            _repository = repository;
        }
        public Task<bool> Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Task<List<Record>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Record> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Task<bool> Insert(Record entity)
        {
            return _repository.Insert(entity);
        }

        public Task<bool> Update(Record entity)
        {
            return _repository.Update(entity);
        }
    }
}
