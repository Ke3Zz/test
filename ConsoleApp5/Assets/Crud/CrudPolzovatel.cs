using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Assets.Models;
using ConsoleApp5.Assets.Serialized;

namespace ConsoleApp5.Assets.Crud
{
    internal class CrudPolzovatel : ICrud
    {
        public List<Polzovatel> polzovatels = new List<Polzovatel>();
        Polzovatel polzovatel = new Polzovatel();
        public void Create()
        {
            Console.WriteLine("Введите айди пользователя");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    polzovatel.polzovatelReg.ID = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
            Console.WriteLine("Введите логин пользователя");
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
                    polzovatel.polzovatelReg.Login = cash;
                    break;
                }
            }
            Console.WriteLine("Введите пароль пользователя");
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
                    polzovatel.polzovatelReg.Password = cash;
                    break;
                }
            }
            Console.WriteLine("Введите роль пользователя");
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
                    polzovatel.polzovatelReg.Role = cash;
                    break;
                }
            }
            polzovatels.Add(polzovatel);
            SerializedPolzovatel.MySerialize(polzovatels);
            Console.Clear();
        }
        public void Delete(int index)
        {
            SerializedPolzovatel.MyDeserialize();
            polzovatels.RemoveAt(index);
            SerializedPolzovatel.MySerialize(polzovatels);
        }
        public void Update(int index)
        {
            Console.WriteLine("Введите айди пользователя");
            polzovatels[index].polzovatelReg.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите логин пользователя");
            polzovatels[index].polzovatelReg.Login = Console.ReadLine();
            Console.WriteLine("Введите пароль пользователя");
            polzovatels[index].polzovatelReg.Password = Console.ReadLine();
            Console.WriteLine("Введите роль пользователя");
            polzovatels[index].polzovatelReg.Role = Console.ReadLine();
            SerializedPolzovatel.MySerialize(polzovatels);

            Console.WriteLine("Введите айди пользователя");
            while (true)
            {
                int num;
                var cash = Console.ReadLine();
                if (int.TryParse(cash, out num))
                {
                    polzovatels[index].polzovatelReg.ID = num;
                    break;
                }
                else
                    Console.WriteLine("Введите целочисленный");
            }
            Console.WriteLine("Введите логин пользователя");
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
                    polzovatels[index].polzovatelReg.Password = cash;
                    break;
                }
            }
            Console.WriteLine("Введите пароль пользователя");
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
                    polzovatels[index].polzovatelReg.Password = cash;
                    break;
                }
            }
            Console.WriteLine("Введите роль пользователя");
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
                    polzovatels[index].polzovatelReg.Role = cash;
                    break;
                }
            }
            polzovatels.Add(polzovatel);
            SerializedPolzovatel.MySerialize(polzovatels);
            Console.Clear();

        }
        public void Read()
        {
            Console.WriteLine("Данные о пользователе");
            SerializedPolzovatel.MyDeserialize();
            foreach (var item in polzovatels)
            {
                Console.WriteLine($"{item.polzovatelReg.ID}");
                Console.WriteLine($"{item.polzovatelReg.Login}");
                Console.WriteLine($"{item.polzovatelReg.Password}");
                Console.WriteLine($"{item.polzovatelReg.Role}");
            }
        }
    }
}
