using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IValues:IRepository<Values>
    {
        Task<List<Values>> TableView();
    }
}
