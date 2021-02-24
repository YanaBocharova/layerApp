using LayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerApp.DAL.EF
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        static DatabaseContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DatabaseContext(string connectionString):base(connectionString)
        {

        }
    }
}
