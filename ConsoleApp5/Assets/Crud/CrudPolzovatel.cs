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
            polzovatel.polzovatelReg.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите логин пользователя");
            polzovatel.polzovatelReg.Login = Console.ReadLine();
            Console.WriteLine("Введите пароль пользователя");
            polzovatel.polzovatelReg.Password = Console.ReadLine();
            Console.WriteLine("Введите роль пользователя");
            polzovatel.polzovatelReg.Role = Console.ReadLine();
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
