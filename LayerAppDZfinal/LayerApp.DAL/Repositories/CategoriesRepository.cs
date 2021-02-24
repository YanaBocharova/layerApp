using AutoMapper;
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
    public class CategoriesRepository : BaseRepository<Category, int>
    {
        public CategoriesRepository(DatabaseContext context) : base(context)
        {
        }

        public override void Update(Category item)
        {
            var srch = Get(item.Id);
            //srch.Copy(item);
            var cnfg = new MapperConfiguration(mCnfg => { });
            var mapper = cnfg.CreateMapper();
            var res = mapper.Map(item, srch);
            ctx.SaveChanges();
        }
    }
}
