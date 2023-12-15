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
    internal static class SerializedPolzovatel
    {
        public static void MySerialize(List<Polzovatel> polzovatels)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string json = JsonSerializer.Serialize(polzovatels);
            File.WriteAllText(desktop, json);
        }
        public static List<Polzovatel> MyDeserialize()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string json = File.ReadAllText(desktop);
            List<Polzovatel> polzovatels = JsonSerializer.Deserialize<List<Polzovatel>>(json);
            return polzovatels;
        }
    }
}
