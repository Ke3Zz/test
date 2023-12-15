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
            buchgalter.listBuchgalter.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Стоимость");
            buchgalter.listBuchgalter.CostSumm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите тип");
            buchgalter.listBuchgalter.type = Console.ReadLine();
            Console.WriteLine("Введите дату");
            buchgalter.listBuchgalter.date = Console.ReadLine();
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
            buchgalters[index].listBuchgalter.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Стоимость");
            buchgalters[index].listBuchgalter.CostSumm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите тип");
            buchgalters[index].listBuchgalter.type = Console.ReadLine();
            Console.WriteLine("Введите дату");
            buchgalters[index].listBuchgalter.date = Console.ReadLine();
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
