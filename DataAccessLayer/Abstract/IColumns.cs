using DataAccessLayer.Concrete;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
     public interface IColumns:IRepository<Column>
     {
        Task<List<Entities.Models.TableView>> GetVisibleColumns();
        Task<List<Column>> GetAllColumns();
        Task<bool> UpdateColumns(int id, Column entity);
        //Task<List<Value>> TableView();
        Task<List<Entities.Models.TableView>> TableView();


    }
}
