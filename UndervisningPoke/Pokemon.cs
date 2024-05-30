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

        public void Attack()
        {

        }
        public void Flee()
        {

        }
    }
}
