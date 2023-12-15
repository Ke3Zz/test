using ConsoleApp5;
using ConsoleApp5.Assets.Menu;

class Program
{
    static void Main(string[] args)
    {
        string[] menu = new string[] { "Вход", "Регистрация", "Выход" };
        Console.WriteLine("Выберите вариант");

        int row = Console.CursorTop;
        int col = Console.CursorLeft;
        int index = 0;
        int Global = 0;
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
                            MenuSingUP MenuSingUP = new MenuSingUP();
                            MenuSingUP.SingUP();
                            break;
                        case 2:
                            Console.WriteLine("Выбран выход из приложения");
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