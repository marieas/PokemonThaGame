using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class GymLeader : PokemonTrainer
    {
       
       
        public Badge GymBadge { get; private set; }
        

        public GymLeader(string name, string badgeName): base(name)
        {
            Pokemonz.Add(new Pokemon("Bjarne", "Bror"));
            SelectedFightingPokemon = Pokemonz[0];
            GymBadge = new Badge(badgeName);
        }

        public void Encounter()
        {
            Console.WriteLine($"You encountered {Name}");
        }

        //Logikk for om en av pokemenna dør, skal man velge en ny dersom han har flere tilgjengelig
        public void ChoosePokemon()
        {//random shit
            ChangePokemon();
        }

        //Når han ikke har flere levende pokemen skal han gi fra seg badgen!
        public Badge GiveBadge()
        {
            Console.WriteLine($"You won {GymBadge.BadgeName}");
            return GymBadge;
        }

    }
}
