using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Assets.Models;
using ConsoleApp5.Assets.Serialized;

namespace ConsoleApp5.Assets.Crud
{
    internal class CrudTovarCheck : ICrud
    {
        public List<TovarCheck> tovarChecks = new List<TovarCheck>();
        public TovarCheck tovarCheck = new TovarCheck();
        
        public void Create()
        {
            Console.WriteLine("Введите айди");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    tovarCheck.listTovar.id = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }

            Console.WriteLine("Введите название");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    Console.WriteLine("Введите сторочно");
                }
                else
                {
                    tovarCheck.listTovar.name = cash;
                    break;
                }
            }
            Console.WriteLine("Введите стоимость");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    tovarCheck.listTovar.costs = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
            Console.WriteLine("Введите количество");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    tovarCheck.listTovar.much = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
            tovarCheck.listTovar.much = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите айди");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    tovarCheck.listTovar.muchInSklad = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
            tovarChecks.Add(tovarCheck);
            SerializedTovarCheck.MySerialize(tovarChecks);
            Console.Clear();
        }
        public void Delete(int index)
        {
            SerializedBuchgalter.MyDeserialize();
            tovarChecks.RemoveAt(index);
            //SerializedBuchgalter.MySerialize(tovarChecks);
        }
        public void Update(int index)
        {
            Console.WriteLine("Введите айди");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    tovarChecks[index].listTovar.id = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }

            Console.WriteLine("Введите название");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    Console.WriteLine("Введите сторочно");
                }
                else
                {
                    tovarChecks[index].listTovar.name = cash;
                    break;
                }
            }
            Console.WriteLine("Введите стоимость");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    tovarChecks[index].listTovar.costs = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
            Console.WriteLine("Введите количество");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    tovarChecks[index].listTovar.much = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
            tovarCheck.listTovar.much = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите айди");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    tovarChecks[index].listTovar.muchInSklad = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
            tovarChecks.Add(tovarCheck);
            SerializedTovarCheck.MySerialize(tovarChecks);
            Console.Clear();
        }
        public void Read()
        {
            Console.WriteLine("Данные о листе");
            SerializedTovarCheck.MyDeserialize();
            foreach(var item in tovarChecks)
            {
                Console.WriteLine($"{item.listTovar.id}");
                Console.WriteLine($"{item.listTovar.name}");
                Console.WriteLine($"{item.listTovar.costs}");
                Console.WriteLine($"{item.listTovar.much}");
                Console.WriteLine($"{item.listTovar.muchInSklad}");
            }

        }
    }
}
