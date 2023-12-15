using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Assets.Models;
using ConsoleApp5.Assets.Serialized;
namespace ConsoleApp5.Assets.Crud
{

    internal class CrudNapitock :  ICrud
    {
        public List<Napitock> napitocks = new List<Napitock>();
        public Napitock napitock = new Napitock();
        public void Create()
        {
            Console.WriteLine("Введите айди напитка");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    napitock.structNapitock.ID = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
            Console.WriteLine("Введите наименнование товара");
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
                    napitock.structNapitock.Name = cash;
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
                    napitock.structNapitock.Cost = num;
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
                    napitock.structNapitock.much = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
            napitocks.Add(napitock);
            SerializedNapitock.MySerialize(napitocks);
            Console.Clear();

        }
        public void Delete(int index)
        {
            napitocks.RemoveAt(index);
        }
        public void Update(int index)
        {
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    napitocks[index].structNapitock.ID = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
            Console.WriteLine("Введите наименнование товара");
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
                    napitocks[index].structNapitock.Name = cash;
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
                    napitocks[index].structNapitock.Cost = num;
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
                    napitocks[index].structNapitock.much = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
        }
        public void Read()
        {
            Console.WriteLine("Данные о товаре");
            SerializedNapitock.MyDeserialize();
            foreach (var item in napitocks)
            {
                Console.WriteLine($"{item.structNapitock.ID}");
                Console.WriteLine($"{item.structNapitock.Name}");
                Console.WriteLine($"{item.structNapitock.Cost}");
                Console.WriteLine($"{item.structNapitock.much}");
            }
        }
    }
}
