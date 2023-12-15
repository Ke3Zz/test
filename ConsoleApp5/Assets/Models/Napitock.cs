using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Assets.Models
{
    internal class Napitock
    {
        [System.Serializable]public struct StructNapitock
        {
            public int ID;
            public string Name;
            public int Cost;
            public int much;
        }
        public StructNapitock structNapitock;
    }
}
