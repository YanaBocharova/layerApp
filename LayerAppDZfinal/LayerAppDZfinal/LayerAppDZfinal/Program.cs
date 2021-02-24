using LayerApp.DAL.Interfaces;
using LayerApp.DAL.Repositories;
using LayerAppBLL.DTO;
using LayerAppBLL.Interfaces;
using LayerAppBLL.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerAppDZfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            IUnitOfWork uow = new UnitOfWork(connection);

            // получение всех данных продуктов
            IProductsService products = new ProductsService(uow);
            var prods = products.GetProducts();
            foreach (var item in prods)
            {
                Console.WriteLine($"{item.Name}  price={item.Price}$ ");
            }
            //------------------------------------------------
            // получение всех данных категории
            ICategoriesService categories = new CategoriesService(uow);
            var categors= categories.GetCategories().ToList();

            // обновление
            var cat1 = categors[0];
            cat1.Name = "Update category!!!";
            categories.Update(cat1);
            ;
            // добавление
            //CategoryDTO dTO = new CategoryDTO
            //{
            //    Name = "New Category"
            //};
            //categories.Add(dTO);

            //// удаление
            //var cat2 = categors[1];
            //categories.Delete(cat2);

            foreach (var item in categors)
            {
                Console.WriteLine($"{item.Name}  id={item.Id}");
            }
            //----------------------------------------------
            // получение всех данных акаутов
            IAccountsService accounts = new AccountsService(uow);
            var accs = accounts.GetAccounts().ToList();
            
            //accounts.Delete(accs[0]);
            //show accounts
            //foreach (var item in accs)
            //{
            //    Console.WriteLine($"{item.Login} {item.Password}");
            //}
            //--------------------------------------------------
            // получение всех данных пользователей
            IUserInfosService usersservice = new UserInfosService(uow);

            //получение пользователя по акаунту
            var userByacc = usersservice.GetUserInfoByAccount(accs[2]);
            Console.WriteLine("______________");
            Console.WriteLine($"{userByacc.Name}  {userByacc.Id} " +
            $"\nlogin:{userByacc.Account.Login} password:{userByacc.Account.Password}");
            Console.WriteLine("______________");

            // добавление аккаунта
            AccountDTO account = new AccountDTO
            {
                Login = "00000",
                Password = "000"
            };
            // добавление пользователя
            UserInfoDTO userInfo = new UserInfoDTO
            {
                Birth = new DateTime(1990, 10, 10),
                Name = "Mikki", Account = account
                
            };
            usersservice.Add(userInfo);

            var users = usersservice.GetUserInfos().ToList();

            //удаленеи пользователя
            usersservice.Delete(users[2]);

            var users2 = usersservice.GetUserInfos().ToList();
            //show users
            foreach (var item in users2)
            {
                Console.WriteLine($"{item.Name} {item.Birth.ToShortDateString()}");
            }

        }
    }
}
