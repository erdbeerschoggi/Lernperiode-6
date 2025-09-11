using static RPG.Program;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paladins
            Paladins Lance = new Paladins("Lance", 100, "Team builder", "Blue Lion", "Sniperrifle");
            Paladins Keith = new Paladins("Keith", 100, "Right Hand Man", "Red Lion", "EnergySword");
            Paladins Shiro = new Paladins("Shiro", 100, "Leader", "Black Lion", "Galra Tech Arm");
            Paladins Pidge = new Paladins("Pidge", 100, "The Brains", "Green Lion", "Electric Grappling Hook");
            Paladins Hunk = new Paladins("Hunk", 100, "Engineer", "Yellow Lion", "EnergyGun");
            Paladins Allura = new Paladins("Allura", 100, "Princess", "Blue Lion", "AlteanAlchemy"); //Maybe remove her if the code gets to complicated, because shes not that important for the basic game

            //Zarkons Fleet
            ZarkonsFleet Zarkon = new ZarkonsFleet("Zarkon", 100, "Emperor", "GalraTech");
            ZarkonsFleet Lotor = new ZarkonsFleet("Lotor", 100, "Prince", "Sword");
            ZarkonsFleet Haggar = new ZarkonsFleet("Haggar", 100, "Right Hand Man", "AlteanAlchemy");
            ZarkonsFleet Sendak = new ZarkonsFleet("Sendak", 100, "Part of Zarkons Fleet", "Army");

            //Weapons
            Weapons SniperRifle = new Weapons("Sniper Rifle", "Shooting precisely");
            Weapons ElectricGrapplingHook = new Weapons("GrapplingHook", "has a High Voltage Shock");
            Weapons EnergyGun = new Weapons("Energy Gun", "Shooting with alot of strength");
            Weapons EnergySword = new Weapons("Energy Sword", "Sword for close combat");
            Weapons GalraTechArm = new Weapons("Galra Tech Arm", "Energy blades and blasters");
            Weapons AlteanAlchemy = new Weapons("Altean Alchemy", "Healing");

            //Lions
            Lions BlueLion = new Lions("Blue Lion", "Blue", "Ice Rays");
            Lions RedLion = new Lions("Red Lion", "Red", "Electric Rays");
            Lions YellowLion = new Lions("Yellow Lion", "Yellow", "Extra Strength - superior Armor");
            Lions GreenLion = new Lions("Green Lion", "Green", "Plant Rays");
            Lions BlackLion = new Lions("Black Lion", "Black", "Wings - Extra strength and speed");


            //The Code
            // Liste aller Paladins
            List<Paladins> paladins = new List<Paladins>
            {
                Lance, Keith, Shiro, Pidge, Hunk, Allura
            };

            // Menü anzeigen
            Console.WriteLine("Wähle einen Paladin aus:");
            for (int i = 0; i < paladins.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {paladins[i].Name}");
            }

            // Eingabe lesen
            Console.Write("Deine Auswahl: ");
            int auswahl = Convert.ToInt32(Console.ReadLine()) - 1;

            // Gewählten Paladin + Attribute anzeigen
            if (auswahl >= 0 && auswahl < paladins.Count)
            {
                Paladins selected = paladins[auswahl];

                Console.WriteLine("\n--- Gewählter Paladin ---");
                Console.WriteLine($"Name:   {selected.Name}");
                Console.WriteLine($"Health: {selected.Health}");
                Console.WriteLine($"Role:   {selected.Teamrole}");
                Console.WriteLine($"Lion:   {selected.Lion}");
                Console.WriteLine($"Weapon: {selected.Weapon}");
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl!");
            }
        }


        public class Paladins 
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public string Teamrole { get; set; }
            public string Lion { get; set; }
            public string Weapon { get; set; }


            public Paladins(string name, int health, string teamrole, string lion, string weapon) 
            {
                Name = name;
                Health = health;
                Teamrole = teamrole;
                Lion = lion;
                Weapon = weapon;

            }
            
        }

        public class ZarkonsFleet
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public string Teamrole { get; set; }
            public string Weapon { get; set; }

            public ZarkonsFleet(string name, int health, string teamrole, string weapon) 
            {
                Name = name;
                Health = health;
                Teamrole = teamrole;
                Weapon = weapon;
                
            }
            
        }

        public class Weapons
        {
            public string WeaponName { get; set;}
            public string Ability { get; set;}

            public Weapons(string weaponName, string ability)
            {
                WeaponName = weaponName;
                Ability = ability;
            }
        }

        public class Lions
        {
            public string Name { get; set;}
            public string Lioncolour { get; set;}
            public string LionAbilitys { get; set;}

            public Lions(string name, string lioncolour, string lionAbility)
            {
                Name = name;
                Lioncolour = lioncolour;
                LionAbilitys = lionAbility;
            }
        }

    }
}
