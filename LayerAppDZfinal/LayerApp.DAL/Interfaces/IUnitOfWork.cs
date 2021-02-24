using LayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerApp.DAL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Product,int> ProductsRepository { get; }
        IRepository<Category,int> CategoriesRepository { get; }
        IRepository<Account,int> AccountsRepository { get;}
        IRepository<UserInfo,int> UserInfosRepository { get; }

        void Save();
    }
}
