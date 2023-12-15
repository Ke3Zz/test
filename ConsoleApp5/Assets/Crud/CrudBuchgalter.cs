using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Assets.Models;
using ConsoleApp5.Assets.Serialized;

namespace ConsoleApp5.Assets.Crud
{
    internal class CrudBuchgalter : ICrud
    {
        public List<Buchgalter> buchgalters = new List<Buchgalter>();
        Buchgalter buchgalter = new Buchgalter();
        public void Create()
        {
            
            Console.WriteLine("Введите айди");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    buchgalter.listBuchgalter.ID = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Введите целочисленный");
                }
            }
            Console.WriteLine("Введите Стоимость");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    buchgalter.listBuchgalter.CostSumm = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Введите целочисленный");
                }
            }
            Console.WriteLine("Введите тип");
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
                    buchgalter.listBuchgalter.type = cash;
                    break;
                }
            }
            Console.WriteLine("Введите дату");
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
                    buchgalter.listBuchgalter.date = cash;
                    break;
                }
            }
            buchgalters.Add(buchgalter);
            SerializedBuchgalter.MySerialize(buchgalters);
            Console.Clear();
        }
        public void Delete(int index)
        {
            SerializedBuchgalter.MyDeserialize();
            buchgalters.RemoveAt(index);
            SerializedBuchgalter.MySerialize(buchgalters);
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
                    buchgalters[index].listBuchgalter.ID = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Введите целочисленный");
                }
            }
            Console.WriteLine("Введите Стоимость");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    buchgalters[index].listBuchgalter.CostSumm = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Введите целочисленный");
                }
            }
            Console.WriteLine("Введите тип");
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
                    buchgalters[index].listBuchgalter.type = cash;
                    break;
                }
            }
            Console.WriteLine("Введите дату");
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
                    buchgalters[index].listBuchgalter.date = cash;
                    break;
                }
            }
            buchgalters.Add(buchgalter);
            SerializedBuchgalter.MySerialize(buchgalters);
            Console.Clear();
        }
        public void Read()
        {
            Console.WriteLine("Данные о листе");
            SerializedBuchgalter.MyDeserialize();
            foreach (var item in buchgalters)
            {
                Console.WriteLine($"{item.listBuchgalter.ID}");
                Console.WriteLine($"{item.listBuchgalter.type}");
                Console.WriteLine($"{item.listBuchgalter.CostSumm}");
                Console.WriteLine($"{item.listBuchgalter.date}");
            }
        }
    }
}
