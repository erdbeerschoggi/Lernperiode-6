using static RPG.Program;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
        }


        public class Paladins 
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public string TeamRole { get; set; }
            public string Lion { get; set; }
            public string Weapon { get; set; }


            public Paladins(string name, int health, string TeamRole, string lion, string Weapon) 
            {
                Paladins Lance = new Paladins("Lance", 100, "Team builder", "Blue Lion", "Sniperrifle");
                Paladins Keith = new Paladins("Keith", 100, "Right Hand Man", "Red Lion", "EnergySword");
                Paladins Shiro = new Paladins("Shiro", 100, "Leader", "Black Lion", "Galra Tech Arm");
                Paladins Pidge = new Paladins("Pidge", 100, "The Brains", "Green Lion", "Electric Grappling Hook");
                Paladins Hunk = new Paladins("Hunk", 100, "Engineer", "Yellow Lion", "EnergyGun");
                Paladins Allura = new Paladins("Allura", 100, "Princess", "Blue Lion", "AlteanAlchemy"); //Maybe remove her if the code gets to complicated, because shes not that important for the basic game

            }
            
        }

        public class ZarkonsFleet
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public string TeamRole { get; set; }
            public string Weapon { get; set; }

            public ZarkonsFleet(string Name, int Health, string TeamRole, string Weapon) 
            {
                ZarkonsFleet Zarkon = new ZarkonsFleet("Zarkon", 100, "Emperor", "GalraTech");
                ZarkonsFleet Lotor = new ZarkonsFleet("Lotor", 100, "Prince", "Sword");
                ZarkonsFleet Haggar = new ZarkonsFleet("Haggar", 100, "Right Hand Man", "AlteanAlchemy");
                ZarkonsFleet Sendak = new ZarkonsFleet("Sendak", 100, "Part of Zarkons Fleet", "Army");
            }
            
        }

        public class Weapons
        {
            public string WeaponName { get; set;}
            public string Ability { get; set;}

            public Weapons(string WeaponName, string Ability)
            {
                Weapons SniperRifle = new Weapons("Sniper Rifle", "Shooting precisely");
                Weapons ElectricGrapplingHook = new Weapons("GrapplingHook", "has a High Voltage Shock");
                Weapons EnergyGun = new Weapons("Energy Gun", "Shooting with alot of strength");
                Weapons EnergySword = new Weapons("Energy Sword", "Sword for close combat");
                Weapons GalraTechArm = new Weapons("Galra Tech Arm", "Energy blades and blasters");
                Weapons AlteanAlchemy = new Weapons("Altean Alchemy", "Healing");
            }
        }

        public class Lions
        {
            public string Name { get; set;}
            public string Lioncolour { get; set;}
            public string LionAbilitys { get; set;}

            public Lions(string Name, string Lioncolour, string LionAbility)
            {
                Lions BlueLion = new Lions("Blue Lion", "Blue", "Ice Rays");
                Lions RedLion = new Lions("Red Lion", "Red", "Electric Rays");
                Lions YellowLion = new Lions("Yellow Lion","Yellow", "Extra Strength - superior Armor");
                Lions GreenLion = new Lions("Green Lion", "Green", "Plant Rays");
                Lions BlackLion = new Lions("Black Lion", "Black", "Wings - Extra strength and speed");
            }
        }

    }
}
