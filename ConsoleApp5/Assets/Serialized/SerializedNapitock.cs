using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using ConsoleApp5.Assets.Models;

namespace ConsoleApp5.Assets.Serialized
{
    internal static class SerializedNapitock
    {
        public static void MySerialize(List<Napitock> napitocks)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string json = JsonSerializer.Serialize(napitocks);
            File.WriteAllText(desktop, json);
        }
        public static List<Napitock> MyDeserialize()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string json = File.ReadAllText(desktop);
            List<Napitock> napitocks = JsonSerializer.Deserialize<List<Napitock>>(json);
            return napitocks;
        }
    }
}
