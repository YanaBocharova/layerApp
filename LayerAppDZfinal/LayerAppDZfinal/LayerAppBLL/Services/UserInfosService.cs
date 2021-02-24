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
    public class UserInfosService : BaseService, IUserInfosService
    {
        public UserInfosService(IUnitOfWork uow) : base(uow) { }

        public void Add(UserInfoDTO item)
        {
            var user = mapper.Map<UserInfo>(item);
            db.UserInfosRepository.Create(user);
        }

        public void Delete(UserInfoDTO item)
        {
            db.AccountsRepository.Delete(item.Account.Id);
            db.UserInfosRepository.Delete(item.Id);
            db.Save();
        }

        public void Dispose() => db.Dispose();

        public UserInfoDTO GetUserInfo(int id)
        {
            var userinfo = db.UserInfosRepository.Get(id);
            return mapper.Map<UserInfoDTO>(userinfo);
        }

        public UserInfoDTO GetUserInfoByAccount(AccountDTO account)
        {
            var acc = mapper.Map<Account>(account);
            var user= db.UserInfosRepository.Get(account.Id);
            return mapper.Map<UserInfoDTO>(user);
            
        }

        public IEnumerable<UserInfoDTO> GetUserInfos()
        {
            var userinfos = db.UserInfosRepository.GetAll();
            return mapper.Map<IEnumerable<UserInfoDTO>>(userinfos);
        }

        public void Update(UserInfoDTO item)
        {
            var user = mapper.Map<UserInfo>(item);
            db.UserInfosRepository.Update(user);
        }
    }
}
