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
            
            Console.WriteLine("Введите наименнование напитка");
            napitock.structNapitock.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите наименнование напитка");
            napitock.structNapitock.Name = Console.ReadLine();
            Console.WriteLine("Введите стоимость");
            napitock.structNapitock.Cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество");
            napitock.structNapitock.much = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("Введите наименнование напитка");
            napitocks[index].structNapitock.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите наименнование напитка");
            napitocks[index].structNapitock.Name = Console.ReadLine();
            Console.WriteLine("Введите стоимость");
            napitocks[index].structNapitock.Cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество");
            napitocks[index].structNapitock.much = Convert.ToInt32(Console.ReadLine());
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
