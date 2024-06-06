using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class Item
    {
       public string ItemType { get; private set; }
        public Item(string itemT)
        {
            ItemType = itemT;
        }
    }
}
