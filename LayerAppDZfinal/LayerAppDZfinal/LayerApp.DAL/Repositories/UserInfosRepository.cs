using LayerApp.DAL.EF;
using LayerApp.DAL.Entities;
using LayerApp.DAL.Exception;
using LayerApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerApp.DAL.Repositories
{
    public class UserInfosRepository : BaseRepository<UserInfo, int>
    {
        public UserInfosRepository(DatabaseContext context) : base(context)
        {
        }

        public override void Update(UserInfo item)
        {
            var srch = Get(item.Id);
            srch.Copy(item);
            ctx.SaveChanges();
        }
        public override UserInfo Get(int accountId)
        {
            var item = table.Include(user => user.Account).FirstOrDefault(user => user.Account.Id == accountId);
            if (item is null)
            {
                throw new InccorectIdException();
            }
            return item;
        }
        public override void Delete(int userId)
        {
            var item = table.FirstOrDefault(user => user.Id == userId);
            if (item is null)
            {
                throw new InccorectIdException();
            }
            table.Remove(item);
            ctx.SaveChanges();
        }

    }
}
