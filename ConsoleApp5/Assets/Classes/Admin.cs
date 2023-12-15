using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Assets.Crud;

namespace ConsoleApp5.Assets.Classes
{
    internal class Admin
    {
        public void AdminMenu()
        {
            string[] menu = new string[] {"___Администрация___", "Создать", "Просмотреть", "Обновление", "Удаление",
                                          "___Бухгалтер___", "Создать", "Просмотреть", "Обновление", "Удаление",
                                          "___Кассир___", "Создать", "Просмотреть", "Обновление", "Удаление",
                                          "___М.Персанала___", "Создать", "Просмотреть", "Обновление", "Удаление",
                                          "___М.Склада___", "Создать", "Просмотреть", "Обновление", "Удаление",};
            Console.WriteLine("Выберите вариант");

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            int Global = 0;
            CrudPolzovatel crudSotrudnik = new CrudPolzovatel();
            CrudBuchgalter crudSotrudnik1 = new CrudBuchgalter();
            CrudTovarCheck crudSotrudnik2 = new CrudTovarCheck();
            CrudSotrudnik crudSotrudnik3 = new CrudSotrudnik();
            CrudNapitock crudSotrudnik4 = new CrudNapitock();
            while (true)
            {
                while (true)
                {
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
                                    Console.WriteLine("Выбран обновление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik.Read();
                                    Console.WriteLine(" ");
                                    crudSotrudnik.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 4:
                                    Console.WriteLine("Выбран удаление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik.Read();
                                    Console.WriteLine(" ");
                                    crudSotrudnik.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine("Выбрано создание");
                                    crudSotrudnik1.Create();
                                    break;
                                case 6:
                                    Console.WriteLine("Выбран чтение из листа");
                                    crudSotrudnik1.Read();
                                    break;
                                case 7:
                                    Console.Clear();
                                    Console.WriteLine("Выбран обновление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik.Read();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Введите индекс");
                                    crudSotrudnik.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 8:
                                    Console.WriteLine("Выбран обновление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik.Read();
                                    Console.WriteLine(" ");
                                    crudSotrudnik1.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 9:
                                    Console.WriteLine("Выбран удаление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik1.Read();
                                    Console.WriteLine(" ");
                                    crudSotrudnik1.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 10:
                                    Console.Clear();
                                    Console.WriteLine("Выбрано создание");
                                    crudSotrudnik2.Create();
                                    break;
                                case 11:
                                    Console.WriteLine("Выбран чтение из листа");
                                    crudSotrudnik2.Read();
                                    break;
                                case 12:
                                    Console.Clear();
                                    Console.WriteLine("Выбран обновление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik2.Read();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Введите индекс");
                                    crudSotrudnik2.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 13:
                                    Console.Clear();
                                    Console.WriteLine("Выбран удаление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik2.Read();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Введите индекс");
                                    crudSotrudnik2.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 14:
                                    Console.Clear();
                                    Console.WriteLine("Выбрано создание");
                                    crudSotrudnik3.Create();
                                    break;
                                case 15:
                                    Console.WriteLine("Выбран чтение из листа");
                                    crudSotrudnik3.Read();
                                    break;
                                case 16:
                                    Console.Clear();
                                    Console.WriteLine("Выбран обновление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik3.Read();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Введите индекс");
                                    crudSotrudnik3.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 17:
                                    Console.Clear();
                                    Console.WriteLine("Выбран удаление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik3.Read();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Введите индекс");
                                    crudSotrudnik3.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 18:
                                    Console.WriteLine("Выбран удаление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik3.Read();
                                    Console.WriteLine(" ");
                                    crudSotrudnik3.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 19:
                                    Console.Clear();
                                    Console.WriteLine("Выбрано создание");
                                    crudSotrudnik4.Create();
                                    break;
                                case 20:
                                    Console.WriteLine("Выбран чтение из листа");
                                    crudSotrudnik4.Read();
                                    break;
                                case 21:
                                    Console.Clear();
                                    Console.WriteLine("Выбран обновление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik4.Read();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Введите индекс");
                                    crudSotrudnik4.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 22:
                                    Console.Clear();
                                    Console.WriteLine("Выбран удаление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik4.Read();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Введите индекс");
                                    crudSotrudnik4.Update(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 23:
                                    Console.WriteLine("Выбран удаление из листа");
                                    Console.WriteLine(" ");
                                    crudSotrudnik4.Read();
                                    Console.WriteLine(" ");
                                    crudSotrudnik4.Update(Convert.ToInt32(Console.ReadLine()));
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
