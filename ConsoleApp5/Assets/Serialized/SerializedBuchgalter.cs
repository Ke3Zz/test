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
    internal static class SerializedBuchgalter
    {
        public static void MySerialize(List<Buchgalter> buchgalters)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string json = JsonSerializer.Serialize(buchgalters);
            File.WriteAllText(desktop, json);
        }
        public static List<Buchgalter> MyDeserialize()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string json = File.ReadAllText(desktop);
            List<Buchgalter> buchgalters = JsonSerializer.Deserialize<List<Buchgalter>>(json);
            return buchgalters;
        }
    }
}
