using System;
using System.Web;
using System.Collections.Generic;

namespace Keeper.Models
{
    public class Region
    {
        public string name;
        public List<Trap> traps = new List<Trap>();
        public List<Unit> population = new List<Unit>();
    }
}
