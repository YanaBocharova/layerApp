using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LayerAppDZfinal.Application
{
    public class App
    {
        public void Start()
        {
            while(true)
            {
                Clear();
                Menu();
                int action;
                int.TryParse(ReadLine(), out action);
                RunAction(action);

                ReadKey();
            }
        }

        private void RunAction(int action)
        {
            switch (action)
            {
                default:
                    break;
            }
        }

        private void Menu()
        {
            WriteLine("[1] Show categoryies");
            WriteLine("[2] Show products");
            WriteLine("[3] Show accounts");
            WriteLine("[4] Show usersinfo");

            WriteLine("[5] delete by id category");
            WriteLine("[6] delete by id product");
            WriteLine("[7] delete by id account");
            WriteLine("[8] delete by id usersinfo");


            WriteLine("[9]  add category");
            WriteLine("[10] add product");
            WriteLine("[11] add account");
            WriteLine("[12] add usersinfo");


            WriteLine("[13] Apdate category");

        }
    }
}
