using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerApp.DAL.Entities
{
    public class UserInfo:BaseEntity
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public Account Account { get; set; }
        public void Copy(UserInfo from)
        {
            Name = from.Name;
            Birth = from.Birth;
            Account.Copy(from.Account);
        }
    }
}
