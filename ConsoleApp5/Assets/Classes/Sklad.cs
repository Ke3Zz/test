using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Assets.Crud;

namespace ConsoleApp5.Assets.Classes
{
    internal class Sklad
    {
        public void BuchgalterMenu()
        {
            string[] menu = new string[] { "Создать", "Просмотреть", "Обновление", "Удаление", "Выйти" };
            Console.WriteLine("Выберите вариант");

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            int Global = 0;
            CrudNapitock crudSotrudnik = new CrudNapitock();
            MenuChose menuChose = new MenuChose();
            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    break;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Вы авторизовались как Менеджер {menuChose.LoginMenu}");
                    Console.WriteLine();
                    DrawMenu(menu, row, col, index);
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (index < menu.Length - 1)
                                index++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (index > 0)
                                index--;
                            break;
                        case ConsoleKey.Enter:
                            switch (index)
                            {
                                case 0:
                                    Console.Clear();
                                    Console.WriteLine("Выбрано создание");
                                    crudSotrudnik.Create();
                                    break;
                                case 1:
                                    Console.WriteLine("Выбран чтение из листа");
                                    crudSotrudnik.Read();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Выбран обновление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik.Read();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Введите индекс");
                                    crudSotrudnik.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Выбран удаление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik.Read();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Введите индекс");
                                    crudSotrudnik.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 4:
                                    Console.WriteLine("Выбран удаление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik.Read();
                                    Console.WriteLine(" ");
                                    crudSotrudnik.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                default:
                                    Console.WriteLine($"Выбран пункт {menu[index]}");
                                    break;
                            }
                            break;
                    }
                    static void DrawMenu(string[] items, int row, int col, int index)
                    {
                        Console.SetCursorPosition(col, row);
                        for (int i = 0; i < items.Length; i++)
                        {
                            if (i == index)
                            {
                                Console.BackgroundColor = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            Console.WriteLine(items[i]);
                            Console.ResetColor();
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
