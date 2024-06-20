using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class PokemonTrainer
    {  
        public List<Pokemon> Pokemonz { get; protected set; }
        public string Name { get; private set; }
        public Pokemon SelectedFightingPokemon { get; protected set; }

        public PokemonTrainer(string name)
        {
            Pokemonz = new List<Pokemon>();
            Name = name;
        }
        public void ChangePokemon()
        {

        }
    }
}
