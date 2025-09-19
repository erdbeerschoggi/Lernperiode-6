using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class ZarkonsFleet
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
        public void Attack(Paladins hero)
        {
            int dmg = 15;
            Console.WriteLine($"{Name} schlägt mit {Weapon} zurück und verursacht {dmg} Schaden an {hero.Name}.");
            hero.Health -= dmg;
            if (hero.Health < 0) hero.Health = 0;
            Console.WriteLine($"{hero.Name} hat jetzt {hero.Health} Health.");
        }


        public void TakeDamageZarkonsFleet(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} nimmt {damage} Schaden");
        }
    }
}
