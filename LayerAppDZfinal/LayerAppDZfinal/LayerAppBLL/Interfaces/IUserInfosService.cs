using LayerAppBLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerAppBLL.Interfaces
{
    public interface IUserInfosService:IDisposable
    {
        UserInfoDTO GetUserInfo(int id);
        IEnumerable<UserInfoDTO> GetUserInfos();
        UserInfoDTO GetUserInfoByAccount(AccountDTO acount);

        void Add(UserInfoDTO item);
        void Update(UserInfoDTO item);
        void Delete(UserInfoDTO item);
    }
}
