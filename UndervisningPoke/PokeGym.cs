using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class PokeGym
    {
        public GymLeader GymLeader { get; private set; }
        public Player MyTrainer { get; private set; }

        public string GymName { get; private set; }
        public PokeGym(string gymName)
        {
            GymName = gymName;
        }

        public void EnterGym(Player player)
        {
            MyTrainer = player;
            GetGymLeader();
            GymAction();
        }

        public void GymAction()
        {
            while(MyTrainer.SelectedFightingPokemon.IsAlive() && GymLeader.SelectedFightingPokemon.IsAlive())
            {
                MyTrainer.SelectedFightingPokemon.Attack(GymLeader.SelectedFightingPokemon);
            }
            Console.WriteLine("You won the battle");
            MyTrainer.ReceiveBadge(GymLeader);
        }
        public void GetGymLeader()
        {
            switch (GymName)
            {
                case "Kanto":
                    GymLeader = new GymLeader("Steven", "Kanto");
                    break;
                default:
                    GymLeader = new GymLeader("Bjarne", "BjarndeBadgen");
                    break;
            }
        }
    }
}
