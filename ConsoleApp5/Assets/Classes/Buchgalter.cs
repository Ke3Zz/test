using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Assets.Crud;

namespace ConsoleApp5.Assets.Classes
{
    internal class Buchgalter
    {
        public void BuchgalterMenu()
        {
            string[] menu = new string[] { "Создать", "Просмотреть", "Выйти" };
            Console.WriteLine("Выберите вариант");

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            int Global = 0;
            CrudBuchgalter crudSotrudnik = new CrudBuchgalter();
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
                                crudSotrudnik.Create();
                                break;
                            case 1:
                                Console.WriteLine("Выбран чтение из приложения");
                                crudSotrudnik.Read();
                                break;
                            case 2:
                                return;
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
