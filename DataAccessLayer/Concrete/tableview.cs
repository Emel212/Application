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
    public class TableView : ITableview
    {
        private CoreDbContext _ctx;

        public TableView(CoreDbContext ctx)
        {
            _ctx = ctx;
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

        public async Task<Dictionary<Column,Value>> Tableview()
        {
            List<Column> p = await _ctx.Columns.ToListAsync();
            List<Value> i = await _ctx.Values.ToListAsync();
            var query = from column in p
                        join value in i on column.Id equals value.ColumnId into Table1
                        from value in Table1.Where(x => x.Column.IsVisible == true).Distinct().OrderBy(x => x.Column.Order).ToList()
                        select new Entities.Models.TableView
                        {
                         
                            
                        };
            List<Entities.Models.TableView> tableViewList = query.ToList();

            Dictionary<Column, Value> tableDictionary = new Dictionary<Column, Value>();

/*foreach (Entities.Models.TableView tableView in tableViewList)
            {
                tableDictionary.Add(tableView._column);
            }*/
            return tableDictionary;
          
        }

        public Task<bool> Update(ITableview entity)
        {
            throw new NotImplementedException();
        }
    }
}
