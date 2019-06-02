using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Inventory
{
    [Serializable]
    public class Weapon : Item
    {
        public int MinDmg { get; set; }
        public int MaxDmb { get; set; }
    }
}
