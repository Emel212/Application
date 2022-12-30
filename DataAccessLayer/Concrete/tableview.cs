using DataAccessLayer.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class tableview : ITableview
    {
        CoreDbContext _ctx;
        public tableview()
        {
            _ctx = new CoreDbContext();
        }
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ITableview>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ITableview> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(ITableview entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TableView>> Tableview()
        {
            List<Column> p = await _ctx.Columns.ToListAsync();
            List<Values> i =await _ctx.Values.ToListAsync();
            var query = from column in p
                        join value in i on column.Id equals value.ColumnId into Table1
                        from value in Table1.Where(x => x.Column.IsVisible == true).OrderBy(x => x.Column.Order).ToList()
                        select new TableView
                        {
                            _column = column,
                            _values = value
                        };
            return  query.ToList();
        }

        public Task<bool> Update(ITableview entity)
        {
            throw new NotImplementedException();
        }
    }
}
