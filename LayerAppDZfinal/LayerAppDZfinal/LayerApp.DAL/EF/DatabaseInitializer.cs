using LayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerApp.DAL.EF
{
    public class DatabaseInitializer:DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
            var cat1 = new Category { Name = "Category 1" };
            var cat2 = new Category { Name = "Category 2" };
            var cat3 = new Category { Name = "Category 3" };

            var prod1 = new Product
            {
                Name = "Product 1",
                Price = 100,
                Category = cat1
            };
            var prod2 = new Product
            {
                Name = "Product 2",
                Price = 440,
                Category = cat1
            };
            var prod3 = new Product
            {
                Name = "Product 3",
                Price = 222,
                Category = cat2
            };
            var prod4 = new Product
            {
                Name = "Product 4",
                Price = 100,
                Category = cat3
            };

            context.Products.AddRange(new Product[] { prod1, prod2, prod3, prod4 });
            var acc1 = new Account
            {
                Login = "Login 1",
                Password = "111",
                Email = "login111@gmail.com"
            };
            var acc2 = new Account
            {
                Login = "Login 2",
                Password = "222",
                Email = "login222@gmail.com"
            };
            var acc3 = new Account
            {
                Login = "Login 3",
                Password = "333",
                Email = "login333@gmail.com"
            };

            var user1 = new UserInfo
            {
                Name = "Name 1",
                Birth = new DateTime(2000, 10, 13),
                Account = acc1
            };
            var user2 = new UserInfo
            {
                Name = "Name 2",
                Birth = new DateTime(1990, 4, 13),
                Account = acc2
            };
            var user3 = new UserInfo
            {
                Name = "Name 3",
                Birth = new DateTime(1990, 11, 11),
                Account = acc3
            };
            context.UserInfos.AddRange(new UserInfo[] { user1, user2, user3 });
            context.SaveChanges();
        }
    }
}
