using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class PokemonWorld
    {
        public Player CurrentPlayer { get; private set; }
        public PokeShop Store { get; private set; }
        public PokeGym Gym { get; private set; }
        public List<Pokemon> WildPokemen { get; private set; } 
        public Random Random = new Random();
        public PokemonWorld()
        {
          
            CurrentPlayer = new Player("Bjarne",new Pikachu(), Random);
            Store = new PokeShop();
            Gym = new PokeGym("Kanto");
            WildPokemen = new List<Pokemon>()
            {   new Pikachu(),
                new Pokemon("Arcanine", "fire"),
                new Pokemon("Grovyle", "grass"),
                new Pokemon("Bulbasaur", "grass"),
                new Pokemon("Schyther", "grass"),
                new Pokemon("MewTwo", "psychic"),
                new Pokemon("Mudkip", "mud"),
                new Pokemon("Golem", "mud"),
                new Pokemon("Grimer", "mud"),
                new Pokemon("Lapras", "water"),
                new Pokemon("Oshawott", "water"),
                new Pokemon("Vaporeon", "water"),
            };
            MainMenu();
        }

        public void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to PokemonWorld");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Enter the wilderness");
                Console.WriteLine("2. Go to shop");
                Console.WriteLine("3. Go to Gym");
                Console.WriteLine("4. Log off");

                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        EnterTheWilderness();
                        break;
                    case "2":
                        GoToShop();
                        break;
                    case "3":
                        GoToGym();
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;

                }
            }
        }

        public void EnterTheWilderness()
        {
            bool _inMenu = true;
            while (_inMenu)
            {
                Console.WriteLine("What terrain do u want to go to");
                Console.WriteLine("1. Grass");
                Console.WriteLine("2. Mud");
                Console.WriteLine("3. Water");
                Console.WriteLine("4. Back");

                var userInput = Console.ReadLine();
                Pokemon opponent = new Pokemon("Squirtle", "water");
                switch (userInput)
                {                 
                    case "1":
                        opponent = GetRandomPokemon("grass");
                        break;
                    case "2":
                        opponent = GetRandomPokemon("mud");
                        break;
                    case "3":
                        opponent = GetRandomPokemon("water");
                        break;
                    default:
                        _inMenu = false;
                        break;
                }
                if(_inMenu)
                {
                    Battle(opponent);
                }
               
            }
        }

        public void Battle(Pokemon opponent)
        {
            bool inBattle = true;
            while(inBattle)
            {
                Console.WriteLine($"You encountered a wild {opponent.Name}");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Catch");
                Console.WriteLine("3. Flee");               

                var menuChoice = Console.ReadLine();

                if (menuChoice == "1")
                {
                    AttackPokemon(opponent);
                    inBattle = false;
                }
                else if( menuChoice == "2") 
                {
                    var sucess = TryToCatchPokemon(opponent);
                    if (sucess)
                    {
                        inBattle = false;
                    }
                }
                else
                {
                    Console.WriteLine("You ran away for dear lyfe lol");
                    inBattle = false;
                }
            }
        }

        public bool TryToCatchPokemon(Pokemon opponent)
        {
            bool success = false;
            //ha nok pokeballer (minst 1)
            if (CurrentPlayer.GotBalls())
            {
                success = CurrentPlayer.ThrowBallInFace(opponent);               
            }
            else
            {
                Console.WriteLine("You aint got no ballz!");
            }
            return success;
        }
        public void AttackPokemon(Pokemon opponent)
        {
            //Pause til 13.07
            var myPokemon = CurrentPlayer.SelectedFightingPokemon;
          
            while (opponent.IsAlive() && myPokemon.IsAlive())
            {
                myPokemon.Attack(opponent);
                opponent.Attack(myPokemon);
            }
            if(opponent.IsAlive())
            {
                Console.WriteLine($"{myPokemon.Name} has died :( ... ");
                //changepoken?
            }
            else
            {
                Console.WriteLine("You won the battle!");
                //når kampen er ferdig evt XP til pokemon
            }

            //evt mulighet for å bruke items (potion)
        }
        public Pokemon GetRandomPokemon(string type)
        {
            //var firstHit = WildPokemen.First(pokemon => pokemon.Type == type);
            var possibleOpponens = WildPokemen.Where(pokemon => pokemon.Type == type).ToList();
            var index = Random.Next(0, possibleOpponens.Count);
            return possibleOpponens[index];
        }

        public void GoToShop()
        {
            var shop = new PokeShop();
            shop.ShopMenu();
        }
        public void GoToGym()
        {            
            Gym.EnterGym(CurrentPlayer);
        }
    }
}
