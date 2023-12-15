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
    internal static class SerializedTovarCheck
    {
        public static void MySerialize(List<TovarCheck> tovarChecks)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string json = JsonSerializer.Serialize(tovarChecks);
            File.WriteAllText(desktop, json);
        }
        public static List<TovarCheck> MyDeserialize()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string json = File.ReadAllText(desktop);
            List<TovarCheck> tovarChecks = JsonSerializer.Deserialize<List<TovarCheck>>(json);
            return tovarChecks;
        }
    }
}
