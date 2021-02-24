using LayerAppBLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerAppBLL.Interfaces
{
    public interface IAccountsService:IDisposable
    {
        AccountDTO GetAccount(int id);
        IEnumerable<AccountDTO> GetAccounts();

        void Delete(AccountDTO account);
    }
}
