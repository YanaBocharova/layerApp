using LayerApp.DAL.EF;
using LayerApp.DAL.Entities;
using LayerApp.DAL.Exception;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerApp.DAL.Interfaces
{
    public abstract class BaseRepository<TValue,TKey> : IRepository<TValue, TKey>
        where TValue:class
        where TKey: struct
    {
        protected DatabaseContext ctx;
        protected DbSet<TValue> table;
        public BaseRepository(DatabaseContext context)
        {
            ctx = context;
            table = ctx.Set<TValue>();
        }
        public virtual void Create(TValue item)
        {
            table.Add(item);
            ctx.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var item = Get(id);
            table.Remove(item);
            ctx.SaveChanges();
        }

        public virtual TValue Get(int id)
        {
            var item = table.FirstOrDefault(new Func<TValue, bool>(itm => (itm as BaseEntity).Id == id));
            if (item is null)
            {
                throw new InccorectIdException();
            }
            return item;
        }

        public virtual IEnumerable<TValue> GetAll()
        {
            return table.ToList();
        }

        public virtual IEnumerable<TValue> GetAll(Func<TValue, bool> predicate)
        {
            return table.Where(predicate).ToList();
        }

        public abstract void Update(TValue item);
       
        
    }
}
