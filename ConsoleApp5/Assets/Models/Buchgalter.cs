using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Assets.Models
{
    internal class Buchgalter
    {
        [System.Serializable] public struct ListBuchgalter
        {
            public int ID;
            public int CostSumm;
            public string date;
            public string type;
        }
        public ListBuchgalter listBuchgalter;
    }
}
