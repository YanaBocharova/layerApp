using LayerApp.DAL.Interfaces;
using LayerAppBLL.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerAppBLL.Interfaces
{
    public abstract class BaseService
    {
        protected IUnitOfWork db;
        protected Mapper mapper;
        public BaseService(IUnitOfWork uow)
        {
            db = uow;
            mapper = Mapper.Instance;
        }

        public void Save()
        {
            db.Save();
        }
    }
}
