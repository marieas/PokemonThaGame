using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class Pokemon
    {
        public int Level { get; private set; }
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }

        public Pokemon(string name, string type)
        {
            Level = 1;
            Health = 100;
            Strength = 50;
            Name = name;
            Type = type;
        }

        public bool IsAlive()
        {
            if(Health > 0) return true; 
            
            return false;
        }

        public void LooseHealth(int healthToLoose)
        {
            Health -= healthToLoose;
        }

        public void Attack(Pokemon opponent)
        {
            Console.WriteLine($"{Name} is beating {opponent.Name}");
            opponent.LooseHealth(Strength);
            Console.WriteLine($"{opponent.Name} has lost {Strength} hp");
        }
        public void Flee()
        {

        }
    }
}
