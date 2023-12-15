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
    internal static class SerializedSotrudnick
    {
        public static void MySerialize(List<Sotrudnick> sotrudnicks)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string json = JsonSerializer.Serialize(sotrudnicks);
            File.WriteAllText(desktop + "\\Sotrudnick.json", json);
        }
        public static List<Sotrudnick> MyDeserialize()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string json = File.ReadAllText(desktop + "\\Sotrudnick.json");
            List<Sotrudnick> sotrudnicks = JsonSerializer.Deserialize<List<Sotrudnick>>(json);
            return sotrudnicks;
        }
    }
}
