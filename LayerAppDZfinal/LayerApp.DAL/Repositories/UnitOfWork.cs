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
    public class UnitOfWork : IUnitOfWork

    {
        private DatabaseContext context;
        private static ProductsRepository _productsRepository;
        private static CategoriesRepository _categoriesRepository;
        private static AccountsRepository _acountsRepository;
        private static UserInfosRepository _userInfosRepository;
        private bool disposed = false;

        public IRepository<Product, int> ProductsRepository => _productsRepository ?? (_productsRepository = new ProductsRepository(context));
        public IRepository<Category, int> CategoriesRepository => _categoriesRepository ?? (_categoriesRepository = new Repositories.CategoriesRepository(context));
        public IRepository<Account, int> AccountsRepository => _acountsRepository ?? (_acountsRepository = new AccountsRepository(context));
        public IRepository<UserInfo, int> UserInfosRepository => _userInfosRepository ?? (_userInfosRepository = new UserInfosRepository(context));

       

        public UnitOfWork(string connection)
        {
            context = new DatabaseContext(connection);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposed = true;
            }
        }

        public void Save() => context.SaveChanges();
    }
}
