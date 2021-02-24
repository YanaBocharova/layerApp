using LayerApp.DAL.EF;
using LayerApp.DAL.Entities;
using LayerApp.DAL.Exception;
using LayerApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerApp.DAL.Repositories
{
    public class AccountsRepository : BaseRepository<Account, int>
    {
        public AccountsRepository(DatabaseContext context) : base(context)
        {
        }
        public override Account Get(int accountId)
        {
            var item = table.FirstOrDefault(acc => acc.Id==accountId);
            if (item is null)
            {
                throw new InccorectIdException();
            }
            return item;
        }
        public override void Update(Account item)
        {
            var srch = Get(item.Id);
            srch.Copy(item);
            ctx.SaveChanges();
        }
    }
}
