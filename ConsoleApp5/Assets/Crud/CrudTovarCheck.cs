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
            tovarCheck.listTovar.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название");
            tovarCheck.listTovar.name = Console.ReadLine();
            Console.WriteLine("Введите стоимость");
            tovarCheck.listTovar.costs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость");
            tovarCheck.listTovar.much = Convert.ToInt32(Console.ReadLine());
            //tovarCheck.listTovar.muchInSklad
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
            tovarChecks[index].listTovar.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название");
            tovarChecks[index].listTovar.name = Console.ReadLine();
            Console.WriteLine("Введите стоимость");
            tovarChecks[index].listTovar.costs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость");
            tovarChecks[index].listTovar.much = Convert.ToInt32(Console.ReadLine());
            //tovarCheck.listTovar.muchInSklad
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
