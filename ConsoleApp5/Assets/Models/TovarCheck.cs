using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Assets.Models
{
    internal class TovarCheck
    {
        [System.Serializable]
        public struct list
        {
            public int id;
            public string name;
            public double costs;
            public int much;
            public int muchInSklad;
        }
        public list listTovar;

    }
}
