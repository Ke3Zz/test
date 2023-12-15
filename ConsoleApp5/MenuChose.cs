using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Assets.Classes;
namespace ConsoleApp5
{
    internal class MenuChose
    {
        public string LoginMenu;
        public string PasswordMenu;
        public int globalList;

        public void Login()
        {
            Admin admin = new Admin();
            Manager manager = new Manager();
            Kassa kassa = new Kassa();
            Sklad sklad = new Sklad();
            Buchgalter buchgalter = new Buchgalter();
            switch (LoginMenu)
            {
                case "A":
                    switch (PasswordMenu)
                    {
                        case "A":
                        globalList = 1;
                            Console.Clear();
                            Console.WriteLine($"Вы авторизовались как Администратор логин {LoginMenu}");
                            admin.AdminMenu();
                            break;

                    }
                    break;
                case "M":
                    switch (PasswordMenu)
                    {
                        case "M":
                            globalList = 2;
                            Console.Clear();
                            Console.WriteLine($"Вы авторизовались как Менеджер логин {LoginMenu}");
                            manager.AdminMenu();
                            break;

                    }
                    break;
                case "S":
                    switch (PasswordMenu)
                    {
                        case "S":
                            globalList = 3;
                            Console.Clear();
                            Console.WriteLine($"Вы авторизовались как Менеджер склада логин {LoginMenu}");
                            sklad.BuchgalterMenu();
                            break;

                    }
                    break;
                case "C":
                    switch (PasswordMenu)
                    {
                        case "C":
                            globalList = 4;
                            Console.Clear();
                            Console.WriteLine($"Вы авторизовались как Кассир логин {LoginMenu}");
                            kassa.KassaMenu();
                            break;

                    }
                    break;
                case "B":
                    switch (PasswordMenu)
                    {
                        case "B":
                            globalList = 5;
                            Console.Clear();
                            Console.WriteLine($"Вы авторизовались как Бухгалтер логин {LoginMenu}");
                            buchgalter.BuchgalterMenu();
                            break;
                    }
                    break;
                    default:
                    Console.Clear();
                    Console.WriteLine("Повторите авторизацию снова"+ "\n");
                    Console.WriteLine(" ");
                    break;
            }
        }
    }
}
