using DataAccessLayer.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class r_column : IColumns
    {
        protected IRepository<Column> _repository;
        private CoreDbContext _ctx;
        public r_column(IRepository<Column> repository,CoreDbContext ctx)
        {
            _repository = repository;
            _ctx = ctx;
        }

   
        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<List<Column>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<List<Column>> GetAllColumns()
        {
           var result= from column in _ctx.Columns where column.IsVisible == true orderby column.Order ascending select column;
            return await result.ToListAsync();
        }

        public async Task<Column> GetById(int id)
        {
            var result= await _repository.GetById(id);
            return result;
        }
        
        public async Task<List<Entities.Models.TableView>> GetVisibleColumns()
        {

            var query = _ctx.Columns.Include(x => x.Values)
                        .Where(x => x.IsVisible == true)
                        .OrderBy(x => x.Order)
                        .Select(x => new Entities.Models.TableView
                        {
                            _column = x,
                        
                             
                        });
            var result = await query.ToListAsync();

            return result;
            /*var query = _ctx.Columns.Include(x => x.Values)
            .Where(x => x.IsVisible == true)
            .OrderBy(x => x.Order)
            .Select(x => new Entities.Models.TableView
            {
                _column = x,
                _values =x.Values,
            }).OrderBy(x=>x._column.Order) ;
            var result = await query.ToListAsync();
            return result;*/
            //  var query=from column in _ctx.Columns where column.IsVisible==true  orderby column.Order ascending select column ;
            // return await query.ToListAsync();


            //var newquery = _ctx.Columns.Include(x => x.Values).Select(x => new { x.Name, x.Order, x.IsVisible, x.Id,value= x.Values.Select(x=>x.Value1).SingleOrDefault()}).ToList();
            /*var query = _ctx.Columns.Include(x => x.Values)
            .Where(x => x.IsVisible == true)
            .OrderBy(x => x.Order)
            .Select(x => new {
                Column = x,
                Value = x.Values
            });
            var result = await query.ToListAsync();

            return result;*/

        }

        public async Task<bool> Insert(Column entity)
        {
            return  await _repository.Insert(entity);
        }

        public async Task<bool> UpdateColumns(int id,Column entity)
        {

            var record = _ctx.Find<Column>(id);
            record.IsVisible = entity.IsVisible;
            record.Name = entity.Name;
            record.Order = entity.Order;
          
            var result = await _ctx.SaveChangesAsync();
            if(result>0)
            return true;
            return false;

           // return await _repository.Update(entity);
        }

        public Task<bool> Update(Column entity)
        {
            throw new NotImplementedException();
        }

         public async Task<List<Entities.Models.TableView>> TableView()
       // public async Task<List<Value>> TableView()
        {
          
            /*List<Column> p = await _ctx.Columns.ToListAsync();
            List<Value> i = await _ctx.Values.ToListAsync();
            var query = from column in p
                        join value in i on column.Id equals value.ColumnId into Table1
                        from value in Table1.Where(x => x.Column.IsVisible == true).OrderBy(x => x.Column.Order).ToList()
                        select new Entities.Models.TableView
                        {
                           _column= column,
                           _values=column.Values
                        };

           // List<TableView> tableViewList = query.ToList();
            //Dictionary<Column, Value> tableDictionary = new Dictionary<Column, Value>();

            /*foreach (TableView tableView in tableViewList)
            {
                tableDictionary.Add(tableView._column);
            }*/
          






            List<Column> p = await _ctx.Columns.ToListAsync();
             List<Value> i = await _ctx.Values.ToListAsync();
             var query = from column in p
                         join value in i on column.Id equals value.ColumnId into Table1
                         from value in Table1.Where(x => x.Column.IsVisible == true).OrderBy(x => x.Column.Order)
                         select new Entities.Models.TableView
                         {
                             _column = column,
                             _values = value
                         };


            return query.OrderBy(x=>x._column.Order).ToList();


           /* var query2 = from col in _ctx.Columns join val in _ctx.Values on col.Id equals val.ColumnId where col.IsVisible == true orderby col.Order ascending select val;
            return await query2.ToListAsync();*/

        }
    }
}
