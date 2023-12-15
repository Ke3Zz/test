using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Assets.Models;
using ConsoleApp5.Assets.Serialized;

namespace ConsoleApp5.Assets.Crud
{
    internal class CrudSotrudnik : ICrud
    {
        public List<Sotrudnick> sotrudnicks = new List<Sotrudnick>();
        Sotrudnick sotrudnick = new Sotrudnick();
        public void Create()
        {

                Console.WriteLine("Введите Айди сотрудника");
                sotrudnick.listmembers.id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Фамилию");
                sotrudnick.listmembers.Familia = Console.ReadLine();
                Console.WriteLine("Введите Имя");
                sotrudnick.listmembers.Imya = Console.ReadLine();
                Console.WriteLine("Введите Отчетсво");
                sotrudnick.listmembers.Otchestvo = Console.ReadLine();
                Console.WriteLine("Введите дату рождения");
                sotrudnick.listmembers.DataRosh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите должность");
                sotrudnick.listmembers.Dolshnost = Console.ReadLine();
                Console.WriteLine("Введите зарпалту");
                sotrudnick.listmembers.ZP = Convert.ToDouble(Console.ReadLine());
                sotrudnicks.Add(sotrudnick);
            SerializedSotrudnick.MySerialize(sotrudnicks);
                Console.Clear();

        }
        public void Delete(int index)
        {
            SerializedSotrudnick.MySerialize(sotrudnicks);
            sotrudnicks.RemoveAt(index);
            SerializedSotrudnick.MyDeserialize();
        }
        public void Update(int index)
        {
            Console.WriteLine("Введите айди");
            sotrudnicks[index].listmembers.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Фамилию");
            sotrudnicks[index].listmembers.Familia = Console.ReadLine();
            Console.WriteLine("Введите Имя");
            sotrudnicks[index].listmembers.Imya = Console.ReadLine();
            Console.WriteLine("Введите Отчетсво");
            sotrudnicks[index].listmembers.Otchestvo = Console.ReadLine();
            Console.WriteLine("Введите дату рождения");
            sotrudnicks[index].listmembers.DataRosh = Console.ReadKey().KeyChar;
            Console.WriteLine("Введите должность");
            sotrudnicks[index].listmembers.Dolshnost = Console.ReadLine();
            Console.WriteLine("Введите зарпалту");
            sotrudnicks[index].listmembers.ZP = Convert.ToDouble(Console.ReadLine());
            SerializedSotrudnick.MySerialize(sotrudnicks);
        }
        public void Read()
        {
            Console.WriteLine("Данные о сотрудниках");
            SerializedSotrudnick.MyDeserialize();
            foreach (var item in sotrudnicks)
            {
                Console.WriteLine($"{item.listmembers.id}");
                Console.WriteLine($"{item.listmembers.Familia}");
                Console.WriteLine($"{item.listmembers.Imya}");
                Console.WriteLine($"{item.listmembers.Otchestvo}");
                Console.WriteLine($"{item.listmembers.Dolshnost}");
                
            }
        }
    }
}
