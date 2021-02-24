using LayerApp.DAL.Entities;
using LayerApp.DAL.Interfaces;
using LayerAppBLL.DTO;
using LayerAppBLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerAppBLL.Services
{
    public class AccountsService : BaseService, IAccountsService
    {
        public AccountsService(IUnitOfWork uow) : base(uow) { }

        public void Delete(AccountDTO account)
        {
            var acc = mapper.Map<Account>(account);
            db.AccountsRepository.Delete(acc.Id);
            db.Save();
        }

        public void Dispose() => db.Dispose();
     

        public AccountDTO GetAccount(int id)
        {
            var acount = db.AccountsRepository.Get(id);
            return mapper.Map<AccountDTO>(acount);
        }

        public IEnumerable<AccountDTO> GetAccounts()
        {
            var acounts = db.AccountsRepository.GetAll();
            return mapper.Map<IEnumerable<AccountDTO>>(acounts);
        }
    }
}
