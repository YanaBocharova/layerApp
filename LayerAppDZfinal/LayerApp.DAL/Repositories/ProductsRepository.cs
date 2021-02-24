using LayerApp.DAL.EF;
using LayerApp.DAL.Entities;
using LayerApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerApp.DAL.Repositories
{
    public class ProductsRepository : BaseRepository<Product, int>
    {
        public ProductsRepository(DatabaseContext context) : base(context)
        {
        }

        public override void Update(Product item)
        {
            var srch = Get(item.Id);
            srch.Copy(item);
            ctx.SaveChanges();
        }
    }
}
