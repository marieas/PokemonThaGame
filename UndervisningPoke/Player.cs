using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class Player : PokemonTrainer
    {      
        public int Cash { get; private set; }       
        public List<Item> Items { get; private set; }
        public List<Badge> GymBadges { get; private set; }
        private Random _random;
        public Player(string name, Pokemon startPokemon, Random random) : base(name)
        {
            Cash = 1000;
            Items = new List<Item>(){  new Pokeball(),
                                       new Pokeball(),
                                       new HealthPotion()
                                    };
            GymBadges = new List<Badge>();
            Pokemonz.Add(startPokemon);
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

        public void ReceiveBadge(GymLeader leader)
        {
            var recievedBadge = leader.GiveBadge();
            GymBadges.Add(recievedBadge);
        }

        public bool ThrowBallInFace(Pokemon pokemon)
        {
            //kaste en pokeball i trynet
            Console.WriteLine($"Throwing a ball in {pokemon.Name}`s face... ");
            var item = Items.First(item => item.ItemType == "Pokeball");
            item.UseItem();
            Items.Remove(item);
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
            ChangePokemon();
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
