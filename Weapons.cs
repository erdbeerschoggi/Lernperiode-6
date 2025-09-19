using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Weapons
    {
            public string WeaponName { get; set; }
            public string Ability { get; set; }

            public Weapons(string weaponName, string ability)
            {
                WeaponName = weaponName;
                Ability = ability;
            }
    }
}
