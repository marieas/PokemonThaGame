using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningPoke
{
    internal class Badge
    {
        public string BadgeName { get; private set; }

        public Badge(string badgeName)
        {
            BadgeName = badgeName;
        }
    }
}
