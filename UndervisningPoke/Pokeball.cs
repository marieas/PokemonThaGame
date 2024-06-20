using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class Pokeball : Item
    {
        public Pokeball() : base("Pokeball")
        {
            
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Using pokeball");
        }

        public override void UseItem()
        {
            PrintInfo();
        }
    }
}
