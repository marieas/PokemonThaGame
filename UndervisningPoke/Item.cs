using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal abstract class Item
    {
        public string ItemType { get; private set; }
        public Item(string itemType)
        {
            ItemType = itemType;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{ItemType}");
        }
        public abstract void UseItem();
    }
}
