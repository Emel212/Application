using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IValues:IRepository<Value>
    {
        Task<List<Value>> TableView();
        Task<bool> UpdateValue(int id, Value entity);
    }
}
