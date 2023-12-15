using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Assets;
using ConsoleApp5.Assets.Classes;
namespace ConsoleApp5.Assets.Menu
{
    internal class MenuSingUP
    {
       MenuChose menuChose = new MenuChose();
       public void SingUP()
        {
            Console.WriteLine("Введите логин");
            menuChose.LoginMenu = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            List<char> passChar = new List<char>();
            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter)
                    break;
                else
                {
                    Console.Write("*");
                    passChar.Add(cki.KeyChar);
                }
            }
            Console.WriteLine();
            string passStr = null;
            foreach (char c in passChar)
                menuChose.PasswordMenu += c;
            menuChose.Login();
       }
    }
}
