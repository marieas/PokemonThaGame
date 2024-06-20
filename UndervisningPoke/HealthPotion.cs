using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class HealthPotion : Item
    {
        public HealthPotion() : base("HealthPotion")
        {
            
        }

        public override void UseItem()
        {
            PrintInfo();
            Console.WriteLine("Drinking healthPotion");
        }
    }
}
