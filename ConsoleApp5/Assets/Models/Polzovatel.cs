using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Assets.Models
{
    internal class Polzovatel
    {
        [System.Serializable] public struct PolzovatelReg
        {
            public int ID;
            public string Login;
            public string Password;
            public string Role;
        }
        public PolzovatelReg polzovatelReg;
    }
}
