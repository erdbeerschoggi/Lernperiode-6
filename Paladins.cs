using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Paladins
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

        public void AttackWithWeapon(ZarkonsFleet enemy)
        {
            Console.WriteLine($"{Name} greift {enemy.Name} mit {Weapon} an!");
            enemy.TakeDamageZarkonsFleet(30);
        }

        public void AttackWithLion(ZarkonsFleet enemy)
        {
            Console.WriteLine($"{Name} greift {enemy.Name} mit {Weapon} an!");
            enemy.TakeDamageZarkonsFleet(50);
        }

        public void Defend(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} konnte sich schützen und verliehrt nur {damage}");
        }

        public void TakeDamagePaladin(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} nimmt {damage} Schaden");
        }
    }
}
