using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Assets.Models
{
    internal class Sotrudnick
    {
        [System.Serializable]public struct list
        {
            public int id;
            public string Familia;
            public string Imya;
            public string Otchestvo;
            public int DataRosh;
            public string Dolshnost;
            public double ZP;
        }
        public list listmembers;
        
    }
}
