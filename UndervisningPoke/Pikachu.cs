using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class Pikachu : Pokemon
    {
        public Pikachu() : base("Pikachu","Lightning")
        {
                
        }

        public void LightningStrike(Pokemon opponent)
        {
            Console.WriteLine("Lightening is striking opponent");
            Attack(opponent);
        }
    }
}
