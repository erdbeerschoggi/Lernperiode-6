using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Lions
    {
        public string Name { get; set; }
        public string Lioncolour { get; set; }
        public string LionAbilitys { get; set; }

        public Lions(string name, string lioncolour, string lionAbility)
        {
            Name = name;
            Lioncolour = lioncolour;
            LionAbilitys = lionAbility;
        }
    }
}
