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
        
        public void Create()
        {
            Sotrudnick sotrudnick = new Sotrudnick();
            Console.WriteLine("Введите Айди сотрудника");
                while (true)
                {
                    int num;
                    var cash = Console.ReadLine();
                    if (int.TryParse(cash, out num))
                    {
                        sotrudnick.listmembers.id = num;
                        break;
                    }
                    else
                    Console.WriteLine("Введите целочисленный");
                }

                Console.WriteLine("Введите Фамилию");
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
                    sotrudnick.listmembers.Familia = cash;
                    break;
                    }
                }

                Console.WriteLine("Введите Имя");
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
                        sotrudnick.listmembers.Imya = cash;
                        break;
                    }
                }
                
                Console.WriteLine("Введите Отчетсво");
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
                        sotrudnick.listmembers.Otchestvo = cash;
                        break;
                    }
                }
                Console.WriteLine("Введите дату рождения");
                while (true)
                {
                    int num;
                    var cash = Console.ReadLine();
                    if (int.TryParse(cash, out num))
                    {
                        sotrudnick.listmembers.DataRosh = num;
                        break;
                     }
                    else
                    {
                        Console.WriteLine("Введите целочисленный");
                    }
                }
                Console.WriteLine("Введите должность");
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
                            sotrudnick.listmembers.Dolshnost = cash;
                            break;
                        }
                }
                Console.WriteLine("Введите зарпалту");
                while (true)
                {
                    int num;
                    var cash = Console.ReadLine();
                    if (int.TryParse(cash, out num))
                    {
                        
                        sotrudnick.listmembers.ZP = num;
                        break;
                    }
                    else
                    {
                    Console.WriteLine("Введите cмешанное число");
                    }
                }
               
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
            Sotrudnick sotrudnick = new Sotrudnick();
            Console.WriteLine("Введите Айди сотрудника");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    sotrudnicks[index].listmembers.id = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }

            Console.WriteLine("Введите Фамилию");
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
                    sotrudnicks[index].listmembers.Familia = cash;
                    break;
                }
            }

            Console.WriteLine("Введите Имя");
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
                    sotrudnicks[index].listmembers.Imya = cash;
                    break;
                }
            }

            Console.WriteLine("Введите Отчетсво");
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
                    sotrudnicks[index].listmembers.Otchestvo = cash;
                    break;
                }
            }
            Console.WriteLine("Введите дату рождения");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    sotrudnicks[index].listmembers.DataRosh = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Введите целочисленный");
                }
            }
            Console.WriteLine("Введите должность");
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
                    sotrudnicks[index].listmembers.Dolshnost = cash;
                    break;
                }
            }
            Console.WriteLine("Введите зарпалту");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {

                    sotrudnicks[index].listmembers.ZP = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Введите cмешанное число");
                }
            }
            sotrudnicks.Add(sotrudnick);
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
