using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<Tentity> where Tentity:class
    {
        Task<List<Tentity>> GetAll();
        Task<Tentity> GetById(int id);
        Task<bool> Insert(Tentity entity);
        Task<bool> Delete(int id);
        Task<bool> Update(Tentity entity);

    }
}
