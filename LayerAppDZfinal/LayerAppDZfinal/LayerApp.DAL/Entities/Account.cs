using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerApp.DAL.Entities
{
    public class Account
    {
        [Key]
        [ForeignKey("UserInfo")]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public UserInfo UserInfo { get; set; }
        public void Copy(Account from)
        {
            Login = from.Login;
            Password = from.Password;
            Email = from.Email;
        }
    }
}
