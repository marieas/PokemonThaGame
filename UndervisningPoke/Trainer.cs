using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private Random _random;
        public Trainer(string name, Pokemon startPokemon, Random random)
        {
            Cash = 1000;
            Name = name;
            Items = new List<Item>(){  new Item("Pokeball"),
                                       new Item("Pokeball"),
                                       new Item("HealthPotion")
                                    };
            Pokemonz = new List<Pokemon> { startPokemon };
            SelectedFightingPokemon = startPokemon;
            _random = random;

        }
        public bool GotBalls()
        {
            var pokeballs = Items.Where(item => item.ItemType == "Pokeball").ToList();
            if(pokeballs.Count > 0)
            {
                return true;
            }
            return false;
        }
        public void AddPokemonToCollection(Pokemon pokemon)
        {
            Console.WriteLine($"{pokemon.Name} has been added to bag" );
            Pokemonz.Add(pokemon);
        }

        public bool ThrowBallInFace(Pokemon pokemon)
        {
            //kaste en pokeball i trynet
            Console.WriteLine($"Throwing a ball in {pokemon.Name}`s face... ");
            Items.Remove(Items.First(item => item.ItemType == "Pokeball"));
            var randResult = _random.Next(0, 2);
            if (randResult == 0)
            {
                Console.WriteLine("You sucessfully caught " + pokemon.Name);
                //dersom vi får til, legge i trainers liste av pokemen - print info
                AddPokemonToCollection(pokemon);
                return true;
            }
            else
            {
                Console.WriteLine("The ball was not strong enough to contain pokemon");
                return false;
            }
                
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
