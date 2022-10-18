using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Keeper.Models
{
    public class Trap
    {
        public string name;
        public string position;
        public string trigger;
        public string damage;
    }

    public class Accesory
    {
        public string name;
        public string effect;
        public bool attunement;
        public string type;
    }

    public class Equipment
    {
        public string mainhand;
        public string manhandBonus;
        public string offhand;
        public string offhandBonus;
        public string armour;
        public List<string> consumables = new List<string>();
        public List<Accesory> Accesories = new List<Accesory>();
    }
}
