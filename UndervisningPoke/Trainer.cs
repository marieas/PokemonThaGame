using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class Trainer
    {      
        public List<Pokemon> Pokemonz { get; private set; }
        public int Cash { get; private set; }
        public string Name { get; private set; }    
        public List<Item> Items { get; private set; }
        public Pokemon SelectedFightingPokemon { get; private set; }
        public Trainer(string name, Pokemon startPokemon)
        {
            Cash = 1000;
            Name = name;
            Items = new List<Item>();
            Pokemonz = new List<Pokemon> { startPokemon };
            SelectedFightingPokemon = startPokemon;
        }

        public void ChoosePokemon()
        {

        }
        public void Fight()
        {

        }
        public void Flee()
        {

        }
        public void TryToCatch()
        {

        }
        public void SearchTerrain()
        {

        }
        public void UseItem()
        {

        }
        public void BuyItem()
        {

        }
    }
}
